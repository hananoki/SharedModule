
using UnityEditor;
using UnityEngine;

namespace Hananoki.Extensions {
	public static partial class EditorExtensions {

		public static void AddItemAndDisable( this GenericMenu menu, bool b, string s, GenericMenu.MenuFunction func ) {
			if( b ) {
				menu.AddItem( s, false, func );
			}
			else {
				menu.AddDisabledItem( s );
			}
		}

		public static void AddItemAndDisable( this GenericMenu menu, bool b, string s, GenericMenu.MenuFunction2 func, object userData ) {
			if( b ) {
				menu.AddItem( s, false, func, userData );
			}
			else {
				menu.AddDisabledItem( s );
			}
		}


		public static void AddItem( this GenericMenu menu, string s, GenericMenu.MenuFunction func ) {
			menu.AddItem( s, false, func );
		}
		public static void AddItem( this GenericMenu menu, string s, bool on, GenericMenu.MenuFunction func ) {
			menu.AddItem( new GUIContent( s ), on, func );
		}

		public static void AddItem( this GenericMenu menu, string s1, string s2, bool on, GenericMenu.MenuFunction func ) {
			menu.AddItem( new GUIContent( s1, s2 ), on, func );
		}




		public static void AddItem( this GenericMenu menu, string s, GenericMenu.MenuFunction2 func, object userData ) {
			menu.AddItem( s, false, func, userData );
		}

		public static void AddItem( this GenericMenu menu, string s, bool on, GenericMenu.MenuFunction2 func, object userData ) {
			menu.AddItem( new GUIContent( s ), on, func, userData );
		}



		public static void AddDisabledItem( this GenericMenu menu, string s ) {
			menu.AddDisabledItem( new GUIContent( s ) );
		}

		public static void AddDisabledItem( this GenericMenu menu, string s1, string s2 ) {
			menu.AddDisabledItem( new GUIContent( s1, s2 ) );
		}

		public static void AddSeparator( this GenericMenu menu ) {
			menu.AddSeparator( "" );
		}


		public static void DropDownAtMousePosition( this GenericMenu menu ) {
			if( Event.current == null ) return;
			menu.DropDownPopupRect( new Rect( Event.current.mousePosition, new Vector2( 0, 0 ) ) );
		}
		public static void DropDownLastRect( this GenericMenu menu ) {
			menu.DropDownPopupRect( GUILayoutUtility.GetLastRect().PopupRect() );
		}
		public static void DropDownPopupRect( this GenericMenu menu, Rect rect ) {
			menu.DropDown( rect );
			GUI.FocusControl( "" );
			Event.current.Use();
		}

	}
}
