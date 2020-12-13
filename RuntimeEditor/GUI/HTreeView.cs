//using Hananoki.Reflection;
using HananokiEditor.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using System;

namespace HananokiEditor {
	public abstract class HTreeView<T> : TreeView where T : TreeViewItem {
		public HTreeView( TreeViewState state ) : base( state ) { }
		public HTreeView( TreeViewState state, MultiColumnHeader multiColumnHeader ) : base( state, multiColumnHeader ) { }

		public List<T> m_registerItems;
		int m_id;

		public T currentItem {
			get {
				if( !HasSelection() ) return null;
				var a = GetSelection()[ 0 ];
				return (T) FindItem( a, rootItem );
			}
		}

		public T[] GetSelectionItems() {
			return GetSelection().Select( _id => (T) FindItem( _id, rootItem ) ).Where( x => x != null ).ToArray();
		}

		public T FindItem( int id ) {
			return (T) FindItem( id, rootItem );
		}


		public void SelectItem( int id ) {
			SetSelection( new int[] { id }, TreeViewSelectionOptions.FireSelectionChanged );
		}

		public void InitID() {
			m_id = 0;
		}

		public int GetID() {
			m_id++;
			return m_id;
		}


		public void SetExpandedFollowParents( TreeViewItem item ) {
			while( item.parent != null ) {
				SetExpanded( item.parent.id, true );
				item = item.parent;
			}
		}


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


		public void DrawLayoutGUI() {
			GUILayout.Box( "", HEditorStyles.treeViweArea, GUILayout.ExpandWidth( true ), GUILayout.ExpandHeight( true ) );

			var dropRc = GUILayoutUtility.GetLastRect();
			//dropRc.x += 1;
			//dropRc.width -= 2;
			OnGUI( dropRc );
		}


		public override void OnGUI( Rect rect ) {
			if( !isInitialized ) return;

			base.OnGUI( rect );
			if( Event.current.type == EventType.MouseDown && Event.current.button == 0 && rect.Contains( Event.current.mousePosition ) ) {
				SetSelectionNone();
			}
		}


		protected virtual void OnSelectionNone() { }


		public void SetSelectionNone() {
			SetSelection( new int[ 0 ], TreeViewSelectionOptions.FireSelectionChanged );
			OnSelectionNone();
		}

		new public void ExpandAll() {
			if( rootItem == null ) return;
			base.ExpandAll();
		}

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


		protected override TreeViewItem BuildRoot() {
			//Debug.Log( "BuildRoot" );
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

		sealed protected override void RowGUI( RowGUIArgs args ) {
			if( args.item.id == -1 ) return;

			OnRowGUI( args );
		}

		protected virtual void OnRowGUI( RowGUIArgs args ) { }

		protected void DefaultRowGUI( RowGUIArgs args ) {
			base.RowGUI( args );
		}


		#region m_ContextOnItem
		bool _ContextOnItem = false;

		protected virtual void OnContextClicked() { }
		protected virtual void OnContextClickedItem( int id ) { }

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
			OnContextClickedItem( id );
		}

		#endregion















		public GUIStyle ControlLabel;

		void _Label( Rect rect, GUIContent content, GUIStyle style, RowGUIArgs args ) {
			if( Event.current.type == EventType.Repaint ) {
				style.Draw( rect, content, false, false, args.selected, args.selected );
			}
		}

		protected void Label( Rect rect, GUIContent content, RowGUIArgs args ) {
			if( ControlLabel == null ) {
				ControlLabel = new GUIStyle( "TV Line" );
			}
			_Label( rect, content, ControlLabel, args );
		}
		protected void Label( Rect rect, string text, GUIStyle style, RowGUIArgs args ) {
			_Label( rect, EditorHelper.TempContent( text ), style, args );
		}
		protected void Label( Rect rect, string text, RowGUIArgs args ) {
			Label( rect, EditorHelper.TempContent( text ), args );
		}
	}

	public abstract class HTreeViewContextMenu<T> where T : TreeViewItem {
		protected Action<T[]> m_action;
		protected GenericMenu m;

		public void Invoke( T[] item ) {
			m = new GenericMenu();
			m_action?.Invoke( item );
			//m.DropDownAtMousePosition();
			m.DropDown( new Rect( Event.current.mousePosition, new Vector2( 0, 0 ) ) );
			Event.current.Use();
			//m.ShowAsContext();
			//Event.current.Use();
		}
	}
}
