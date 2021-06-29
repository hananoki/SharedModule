using HananokiRuntime.Extensions;
using UnityEditor.IMGUI.Controls;

namespace HananokiEditor.Extensions {

	public static partial class EditorExtensions {

		public static bool IsEmptyChild( this TreeViewItem item ) {
			if( item == null ) return true;
			if( item.children == null ) return true;
			if( item.children.IsEmpty() ) return true;
			return false;
		}

		public static void RemoveChild( this TreeViewItem item, TreeViewItem remove ) {
			if( item == null ) return;

			if( item.children == null ) return;
			item.children.FindRemove( x => x.id == remove.id );
			if( item.children.Count == 0 ) {
				item.children = null;
			}
		}

	}
}
