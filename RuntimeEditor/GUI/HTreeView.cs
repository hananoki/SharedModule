﻿using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using System.Linq;

namespace Hananoki {
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
			return GetSelection().Select( _id => (T) FindItem( _id, rootItem ) ).ToArray();
		}


		public void InitID() {
			m_id = 0;
		}
		public int GetID() {
			m_id++;
			return m_id;
		}

		public override void OnGUI( Rect rect ) {
			if( !isInitialized ) return;

			base.OnGUI( rect );
		}

		new public void ExpandAll() {
			if( rootItem == null ) return;
			base.ExpandAll();
		}

		new public void Reload() {
			//if( m_registerItems.Count == 0 ) return;
			base.Reload();
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

		protected override void RowGUI( RowGUIArgs args ) {
			if( args.item.id == -1 ) return;

			OnRowGUI( args );
		}

		protected virtual void OnRowGUI( RowGUIArgs args ) { }

		protected void DefaultRowGUI( RowGUIArgs args ) {
			base.RowGUI( args );
		}


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
}
