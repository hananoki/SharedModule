
#if UNITY_2019_1_OR_NEWER
using System.Linq;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;


namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {
		public static VisualElement SearchByName( this VisualElement target, string name ) {
			if( target == null ) return null;

			if( target.name == name ) return target;

			if( 0 < target.childCount ) {
				foreach( var p in target.Children() ) {
					var pp = SearchByName( p, name );
					if( pp != null ) return pp;
				}
			}
			return null;
		}

		public static void SetFont( this VisualElement target, UnityEngine.Font font ) {
			if( target == null ) return;

			target.style.unityFont = font;
			var txt = target as TextElement;
			//if( txt != null ) {
			//	//Debug.Log( txt.text );
			//	txt.text = L10n.Tr( txt.text );
			//	var toolbarMenu = target as ToolbarMenu;
			//	if( toolbarMenu != null ) {
			//		foreach( var p in toolbarMenu.menu.MenuItems().OfType<DropdownMenuAction>() ) {
			//			p.SetField( "<name>k__BackingField", L10n.Tr( p.name ) );
			//		}
			//		//Debug.Log( toolbarMenu.text );
			//	}
			//}
			if( 0 < target.childCount ) {
				foreach( var p in target.Children() ) {
					SetFont( p, font );
				}
			}
		}

	}
}

#endif
