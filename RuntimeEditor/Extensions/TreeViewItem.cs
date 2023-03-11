using HananokiRuntime.Extensions;
using System.Linq;
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

		public static TreeViewItem SearchByDisplayName( this TreeViewItem item, string displayName, bool RecursiveProcessing = true ) {
			if( !item.IsEmptyChild() && RecursiveProcessing ) {
				foreach( var p in item.children ) {
					var result = p.SearchByDisplayName( displayName, true );
					if( result != null ) return result;
				}
			}

			if( item.displayName == displayName ) return item;
			return null;
		}
		
		public static void AlphabetOrderByDisplayName( this TreeViewItem item, bool RecursiveProcessing = true ) {
			if( item.IsEmptyChild() ) return;

			item.children = item.children.OrderBy( x => x.displayName ).ToList();

			if( !RecursiveProcessing ) return;

			foreach( var p in item.children ) {
				p.AlphabetOrderByDisplayName( true );
			}
		}

	}
}
