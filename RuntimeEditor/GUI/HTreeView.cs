using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace Hananoki {
	public abstract class HTreeView<T> : TreeView where T : TreeViewItem {
		public HTreeView( TreeViewState state ) : base( state ) { }

		public List<T> m_registerItems;

		public override void OnGUI( Rect rect ) {
			if( !isInitialized ) return;

			base.OnGUI( rect );
		}

		new public void ExpandAll() {
			if( rootItem == null ) return;
			base.ExpandAll();
		}

		new public void Reload() {
			if( m_registerItems.Count == 0 ) return;
			base.Reload();
		}

		protected override TreeViewItem BuildRoot() {
			var root = new TreeViewItem { depth = -1 };

			foreach( var item in m_registerItems ) {
				var _root = root;

				_root.AddChild( item );
			}

			return root;
		}
	}
}
