using Hananoki.Extensions;
using System;
using UnityEditor;
using UnityEngine;

namespace Hananoki {
	public class HGUILayoutToolbar {
		//[InitializeOnLoad]
		public static GUIStyle Toolbarbutton;
		static GUIStyle s_Toolbarbutton2;
		static GUIStyle Toolbarbutton2 {
			get {
				if( s_Toolbarbutton2 == null ) {
					s_Toolbarbutton2 = new GUIStyle( EditorStyles.toolbarButton );
					s_Toolbarbutton2.margin.zero();
					s_Toolbarbutton2.padding.zero();//= new RectOffset(1,1,2,2);
					s_Toolbarbutton2.fontSize = 10;
					s_Toolbarbutton2.fixedHeight = 18;
					if( UnitySymbol.Has( "UNITY_2019_3_OR_NEWER" ) ) {
						s_Toolbarbutton2.fixedHeight = 20;
					}
				}
				return s_Toolbarbutton2;
			}
		}

		static GUIStyle s_ToolbarDropDown;
		public static GUIStyle toolbarDropDown {
			get {
				if( s_ToolbarDropDown ==null) {
					s_ToolbarDropDown = new GUIStyle( "ToolbarDropDown" );
					s_ToolbarDropDown.alignment = TextAnchor.MiddleCenter;
				}
				return s_ToolbarDropDown;
			}
		}

		//	static HGUILayoutToolbar() {
		//		void InitStyle() {
		//			try {
		//				if( EditorStyles.toolbarButton == null ) return;
		//			}
		//			catch( NullReferenceException ) {
		//				return;
		//			}
		//			Toolbarbutton = new GUIStyle( EditorStyles.toolbarButton );


		//			ToolbarDropDown = new GUIStyle( "ToolbarDropDown" );
		//			ToolbarDropDown.alignment = TextAnchor.MiddleCenter;
		//			ToolbarDropDown.padding = new RectOffset( 6, ToolbarDropDown.padding.right, 2, 2 );
		//			ToolbarDropDown.fontSize = 10;

		//			EditorApplication.update -= InitStyle;
		//		}
		//		EditorApplication.update += InitStyle;
		//	}

		public static bool Button( string s, Texture image, params GUILayoutOption[] options ) {
			return Button( EditorHelper.TempContent( s, image ), options );
		}
		public static bool Button( string s, params GUILayoutOption[] options ) {
			return Button( EditorHelper.TempContent( s ), options );
		}
		public static bool Button( Texture image, params GUILayoutOption[] options ) {
			return Button( EditorHelper.TempContent( image ), GUILayout.Width( 26 ) );
		}
		public static bool Button( GUIContent content, params GUILayoutOption[] options ) {
			if( Toolbarbutton2 == null ) return false;
			try {
				var rc = GUILayoutUtility.GetRect( content, EditorStyles.toolbarButton, options );

				if( EditorHelper.HasMouseClick( rc ) ) {
					return true;
				}

				GUI.Button( rc, content, EditorStyles.toolbarButton );
			}
			catch( Exception e ) {
				Debug.LogException( e );
			}
			return false;
		}


		public static bool Toggle( bool value, string s, Texture image ) {
			var size = Toolbarbutton2.CalcSize( s.content() );
			var rc = GUILayoutUtility.GetRect( s.content(), Toolbarbutton2, GUILayout.Width( size.x + 24 ) );
			return Toggle( rc, value, EditorHelper.TempContent( s, image ), Toolbarbutton2 );
			//return Toggle( value, EditorHelper.TempContent( s, image ), Toolbarbutton2, options );
		}
		public static bool Toggle( bool value, string s, params GUILayoutOption[] options ) {
			return Toggle( value, EditorHelper.TempContent( s ), Toolbarbutton2, options );
		}
		public static bool Toggle( bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options ) {
			var rc = GUILayoutUtility.GetRect( content, style, options );
			return Toggle( rc, value, content, style );
		}
		public static bool Toggle( Rect position, bool value, GUIContent content, GUIStyle style ) {
			if( GUI.Toggle( position, value, content, style ) ) {
				return true;
			}
			return false;
		}


		//	public static bool StaticButton( string s, params GUILayoutOption[] options ) {
		//		return StaticButton( EditorHelper.TempContent( s ), options );
		//	}
		//	public static bool StaticButton( Texture image, params GUILayoutOption[] options ) {
		//		return StaticButton( EditorHelper.TempContent( image ), GUILayout.Width( 26 ) );
		//	}
		//	public static bool StaticButton( GUIContent content, params GUILayoutOption[] options ) {
		//		if( Toolbarbutton2 == null ) return false;
		//		try {
		//			GUILayout.Label( content, Toolbarbutton2, options );
		//			if( EditorHelper.HasMouseClick( GUILayoutUtility.GetLastRect() ) ) {
		//				return true;
		//			}
		//		}
		//		catch( Exception e ) {
		//			Debug.LogException( e );
		//		}
		//		return false;
		//	}


		public static bool DropDown( Texture2D image, Action action, params GUILayoutOption[] options ) {
			return DropDown( EditorHelper.TempContent( image ), action, options );
		}

		public static bool DropDown( string s, Action action, params GUILayoutOption[] options ) {
			return DropDown( EditorHelper.TempContent( s ), action, options );
		}

		public static bool DropDown( GUIContent content, Action action, params GUILayoutOption[] options ) {
			var r = GUILayoutUtility.GetRect( content, toolbarDropDown, options );
			HEditorGUI.lastRect = r;
			var result = EditorHelper.HasMouseClick( r );
			if( result ) {
				//Event.current.Use(); 
				action?.Invoke();
			}
			GUI.Button( r, content, toolbarDropDown );
			return result;
		}
	}
}

