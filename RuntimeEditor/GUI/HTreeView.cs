//using Hananoki.Reflection;
using HananokiEditor.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace HananokiEditor {
	public abstract class HTreeView<T> : TreeView where T : TreeViewItem, new() {
		public HTreeView( TreeViewState state ) : base( state ) { }
		public HTreeView( TreeViewState state, MultiColumnHeader multiColumnHeader ) : base( state, multiColumnHeader ) { }

		public readonly string dragID = $"{typeof( T ).FullName}.GenericData";

		protected SessionStateString m_lastSelectDisplayName = new SessionStateString( $"{typeof( T ).FullName}.m_lastSelectDisplayName" );

		public T m_root;
		public List<T> m_registerItems;
		int m_id;
		public Rect rectGUI;
		protected bool m_expandEventLock;


		public T currentItem {
			get {
				if( !HasSelection() ) return null;
				var a = GetSelection()[ 0 ];
				return (T) FindItem( a, rootItem );
			}
		}



		/////////////////////////////////////////
		public T RollbackLastSelect() {
			var select = m_registerItems.Find( x => x.displayName == m_lastSelectDisplayName );
			if( select != null ) {
				SelectItem( select.id );
				return select;
			}
			return null;
		}


		/////////////////////////////////////////
		public void BackupLastSelect( T item ) {
			m_lastSelectDisplayName.Value = item == null ? "" : item.displayName;
		}


		/////////////////////////////////////////

		/// <summary>
		/// m_rootを含む全てのアイテムをリストで取得する
		/// </summary>
		/// <param name="item"></param>
		/// <param name="results"></param>
		public List<T> GetAllItems() {
			var results = new List<T>();
			GetTreeItems( m_root, ref results );
			return results;
		}

		/// <summary>
		/// 指定アイテムを含む全てのアイテムをリストで取得する
		/// </summary>
		/// <param name="item"></param>
		/// <param name="results"></param>
		public void GetTreeItems( T item, ref List<T> results ) {
			results.Add( item );

			foreach( var p in item.children.OrEmptyIfNull() ) {
				GetTreeItems( (T) p, ref results );
			}
		}

		public void UpdateAllDepth() {
			UpdateDepth( m_root, -1 );
		}

		public void UpdateDepth( T item, int depth ) {
			item.depth = depth;
			foreach( var p in item.children.OrEmptyIfNull() ) {
				UpdateDepth( (T) p, depth + 1 );
			}
		}


		public bool SetExpanded( T item, bool expanded ) {
			return SetExpanded( item.id, expanded );
		}

		/////////////////////////////////////////
		public T ToItem( int id ) {
			return (T) FindItem( id, rootItem );
		}


		/////////////////////////////////////////
		public T[] ToItems( IList<int> ids ) {
			return ids.Select( _id => (T) FindItem( _id, rootItem ) ).Where( x => x != null ).ToArray();
		}


		/////////////////////////////////////////
		public T[] GetSelectionItems() {
			return ToItems( GetSelection() );
		}


		/////////////////////////////////////////
		//public T FindItem( int id ) {
		//	return (T) FindItem( id, rootItem );
		//}


		/////////////////////////////////////////
		public void SelectItem( int id ) {
			try {
				SetSelection( new int[] { id }, TreeViewSelectionOptions.FireSelectionChanged );
				SetFocusAndEnsureSelectedItem();
			}
			catch( Exception e ) {
				Debug.LogException( e );
			}
		}


		/////////////////////////////////////////
		public void SelectItem( TreeViewItem item ) {
			SelectItem( item.id );
		}


		/////////////////////////////////////////
		public void MakeRoot() => m_root = new T { depth = -1 };



		/////////////////////////////////////////
		public void InitID() {
			m_id = 0;
		}


		/////////////////////////////////////////
		public int GetID() {
			m_id++;
			return m_id;
		}


		/////////////////////////////////////////
		public void SetExpandedFollowParents( TreeViewItem item ) {
			while( item.parent != null ) {
				SetExpanded( item.parent.id, true );
				item = item.parent;
			}
		}



		/////////////////////////////////////////
		public void DisableSelectionStyle() {
			// 2019.3以降はm_SelectionStyleで独立してるので書き換えれる
			try {
				if( UnitySymbol.Has( "UNITY_2019_3_OR_NEWER" ) ) {
					object _obj = this;
					var tt = typeof( TreeView );
					var p = tt.GetField( "m_TreeView", BindingFlags.Instance | BindingFlags.NonPublic );
					var _treeView = p.GetValue( _obj );
					var _gui = _treeView.GetProperty<object>( "gui" );
					_gui.SetProperty( "selectionStyle", EditorStyles.label );
				}
			}
			catch( Exception e ) {
				Debug.LogException( e );
			}
		}


		/////////////////////////////////////////
		public void DrawLayoutGUI() {
			GUILayout.Box( "", HEditorStyles.treeViweArea, GUILayout.ExpandWidth( true ), GUILayout.ExpandHeight( true ) );

			var dropRc = GUILayoutUtility.GetLastRect();
			//dropRc.x += 1;
			//dropRc.width -= 2;
			OnGUI( dropRc );
		}



		/////////////////////////////////////////
		public override void OnGUI( Rect rect ) {
			if( !isInitialized ) return;

			rectGUI = rect;
			base.OnGUI( rect );
			if( Event.current.type == EventType.MouseDown && Event.current.button == 0 && rect.Contains( Event.current.mousePosition ) ) {
				SetSelectionNone();
				//Debug.Log( "SetSelectionNone" );
			}
		}


		/////////////////////////////////////////
		protected virtual void OnSelectionNone() { }



		/////////////////////////////////////////
		public void SetSelectionNone() {
			SetSelection( new int[ 0 ], TreeViewSelectionOptions.FireSelectionChanged );
			OnSelectionNone();
		}


		/////////////////////////////////////////
		new public void ExpandAll() {
			if( rootItem == null ) return;
			base.ExpandAll();
		}


		/////////////////////////////////////////
		new public void Reload() {
			//if( m_registerItems.Count == 0 ) return;

			try {
				base.Reload();
			}
			catch( UnityException ) {
			}
			catch( Exception e ) {
				Debug.LogException( e );
			}
		}


		/////////////////////////////////////////

		//↑のReloadと同じだけど、m_registerItemsとm_rootは共存できないので分離
		public void ReloadRoot() {
			if( m_root == null ) return;
			if( m_root.children == null ) return;

			try {
				base.Reload();
			}
			catch( UnityException ) {
			}
			catch( Exception e ) {
				Debug.LogException( e );
			}
		}


		/////////////////////////////////////////
		protected override TreeViewItem BuildRoot() {
			if( m_root != null ) return m_root;

			var root = new TreeViewItem { depth = -1 };

			if( m_registerItems.Count == 0 ) {
				root.AddChild( new TreeViewItem() { id = -1 } );
			}

			foreach( var item in m_registerItems ) {
				var _root = root;

				_root.AddChild( item );
			}

			return root;
		}


		/////////////////////////////////////////
		sealed protected override void RowGUI( RowGUIArgs args ) {
			if( args.item.id == -1 ) return;

			OnRowGUI( (T) args.item, args );
		}



		/////////////////////////////////////////
		protected virtual void OnRowGUI( T item, RowGUIArgs args ) { }


		/////////////////////////////////////////
		protected void DefaultRowGUI( RowGUIArgs args ) {
			base.RowGUI( args );
		}


		/////////////////////////////////////////
		sealed protected override void SelectionChanged( IList<int> selectedIds ) {
			var items = ToItems( selectedIds );
			if( items.Length == 0 ) return;

			OnSelectionChanged( items );
		}


		/////////////////////////////////////////
		protected virtual void OnSelectionChanged( T[] items ) { }



		/////////////////////////////////////////
		sealed protected override void SingleClickedItem( int id ) {
			var item = ToItem( id );
			if( item == null ) return;
			OnSingleClickedItem( item );
		}

		protected virtual void OnSingleClickedItem( T item ) { }


		/////////////////////////////////////////
		sealed protected override void DoubleClickedItem( int id ) {
			var item = ToItem( id );
			if( item == null ) return;
			OnDoubleClickedItem( item );
		}

		protected virtual void OnDoubleClickedItem( T item ) { }


		/////////////////////////////////////////
		sealed protected override void ExpandedStateChanged() {
			if( m_expandEventLock ) return;

			OnExpandedStateChanged();
		}

		protected virtual void OnExpandedStateChanged() { }

		/////////////////////////////////////////
		sealed protected override void SetupDragAndDrop( SetupDragAndDropArgs args ) {
			if( args.draggedItemIDs == null ) return;
			OnSetupDragAndDrop( ToItems( args.draggedItemIDs ) );
		}

		protected virtual void OnSetupDragAndDrop( T[] items ) {
		}

		/////////////////////////////////////////
		sealed protected override bool CanStartDrag( CanStartDragArgs args ) {
			return OnCanStartDrag( (T) args.draggedItem, args );
		}

		protected virtual bool OnCanStartDrag( T item, CanStartDragArgs args ) {
			return false;
		}

		//////////////////////////////////////////////////////////////////////////////////
		#region m_ContextOnItem

		bool _ContextOnItem = false;

		protected virtual void OnContextClicked() { }



		sealed protected override void ContextClicked() {
			if( _ContextOnItem ) {
				_ContextOnItem = false;
				return;
			}
			OnContextClicked();
		}


		sealed protected override void ContextClickedItem( int id ) {
			_ContextOnItem = true;
			base.ContextClickedItem( id );
			OnContextClickedItem( ToItem( id ) );
		}

		protected virtual void OnContextClickedItem( T Item ) { }

		#endregion


		//////////////////////////////////////////////////////////////////////////////////
		#region Label

		public GUIStyle ControlLabel;

		void _Label( Rect rect, GUIContent content, GUIStyle style, RowGUIArgs args ) {
			if( Event.current.type == EventType.Repaint ) {
				style.Draw( rect, content, false, false, args.selected, args.selected );
			}
		}

		protected void Label( RowGUIArgs args, Rect rect, GUIContent content ) {
			Label( rect, content, args );
		}

		protected void Label( RowGUIArgs args, Rect rect, string text ) {
			Label( rect, EditorHelper.TempContent( text ), args );
		}
		protected void Label( RowGUIArgs args, Rect rect, string text, GUIStyle style ) {
			_Label( rect, EditorHelper.TempContent( text ), style, args );
		}

		protected void Label( RowGUIArgs args, Rect rect, string text, Texture2D image ) {
			Label( rect, EditorHelper.TempContent( text, image ), args );
		}
		protected void Label( RowGUIArgs args, Rect rect, string text, Texture2D image, GUIStyle style ) {
			_Label( rect, EditorHelper.TempContent( text, image ), style, args );
		}

		protected void Label( Rect rect, GUIContent content, RowGUIArgs args ) {
			if( ControlLabel == null ) {
				ControlLabel = new GUIStyle( "TV Line" );
				ControlLabel.richText = true;
			}
			_Label( rect, content, ControlLabel, args );
		}

		#endregion
	}



	//public abstract class HTreeViewContextMenu<T> where T : TreeViewItem {
	//	protected Action<T[]> m_action;
	//	protected GenericMenu m;

	//	public void Invoke( T[] item ) {
	//		m = new GenericMenu();
	//		m_action?.Invoke( item );
	//		//m.DropDownAtMousePosition();
	//		m.DropDown( new Rect( Event.current.mousePosition, new Vector2( 0, 0 ) ) );
	//		Event.current.Use();
	//		//m.ShowAsContext();
	//		//Event.current.Use();
	//	}
	//}
}
