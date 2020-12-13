using HananokiEditor.Extensions;
using System;
using UnityEditor;
using UnityEngine;

namespace HananokiEditor {
	public static class HGUIToolbar {

		//static GUIStyle s_ToolbarDropDown;
		//public static GUIStyle toolbarDropDown {
		//	get {
		//		if( s_ToolbarDropDown == null ) {
		//			s_ToolbarDropDown = new GUIStyle( "ToolbarDropDown" );
		//			s_ToolbarDropDown.alignment = TextAnchor.MiddleCenter;
		//			s_ToolbarDropDown.stretchWidth = false;
		//			s_ToolbarDropDown.fixedHeight = 18;
		//			if( UnitySymbol.Has( "UNITY_2019_3_OR_NEWER" ) ) {
		//				s_ToolbarDropDown.fixedHeight = 20;
		//			}
		//		}
		//		return s_ToolbarDropDown;
		//	}
		//}
		static GUIStyle s_ToolbarDropDown;
		static GUIStyle toolbarDropDown {
			get {
				if( s_ToolbarDropDown == null ) {
					s_ToolbarDropDown = new GUIStyle( "ToolbarDropDown" );
					s_ToolbarDropDown.alignment = TextAnchor.MiddleCenter;
				}
				return s_ToolbarDropDown;
			}
		}


		public static void Begin( float space = 0 ) {
			GUILayout.BeginHorizontal();
			if( 0 < space ) GUILayout.Space( space );
			GUILayout.BeginHorizontal( EditorStyles.toolbar );
		}

		public static void End() {
			GUILayout.EndHorizontal();
			//if( 0 < space ) GUILayout.Space( space*2 );
			GUILayout.EndHorizontal();
		}


		//public static void DefaultDraw( Action draw, float space = 0 ) {
		//	Begin( space );
		//	draw?.Invoke();
		//	End();
		//}

		#region Button

		public static bool Button( string s, Texture image, params GUILayoutOption[] options ) {
			var size = EditorStyles.toolbarButton.CalcSize( EditorHelper.TempContent( s, image ) );
			return Button( EditorHelper.TempContent( s, image ), GUILayout.Width( size.x ) );
		}
		public static bool Button( string s, params GUILayoutOption[] options ) {
			return Button( EditorHelper.TempContent( s ), options );
		}
		public static bool Button( Texture image, params GUILayoutOption[] options ) {
			return Button( EditorHelper.TempContent( image ), GUILayout.Width( 26 ) );
		}
		public static bool Button( Texture image, string tooltip, params GUILayoutOption[] options ) {
			return Button( EditorHelper.TempContent( image, tooltip ), GUILayout.Width( 26 ) );
		}
		public static bool Button( GUIContent content, params GUILayoutOption[] options ) {
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

		#endregion


		#region Toggle

		public static bool Toggle( bool value, string s, Texture image ) {
			var size = EditorStyles.toolbarButton.CalcSize( s.content() );
			var rc = GUILayoutUtility.GetRect( s.content(), EditorStyles.toolbarButton, GUILayout.Width( size.x + 24 ) );
			return Toggle( rc, value, EditorHelper.TempContent( s, image ), EditorStyles.toolbarButton );
			//return Toggle( value, EditorHelper.TempContent( s, image ), Toolbarbutton2, options );
		}
		public static bool Toggle( bool value, Texture image ) {
			var cont = EditorHelper.TempContent( image );
			//var size = EditorStyles.toolbarButton.CalcSize( cont );
			//var rc = GUILayoutUtility.GetRect( cont, EditorStyles.toolbarButton, GUILayout.Width( 26 ) );
			return Toggle( value, EditorHelper.TempContent( image ), EditorStyles.toolbarButton, GUILayout.Width( 26 ) );
		}

		public static bool Toggle( bool value, string s, params GUILayoutOption[] options ) {
			return Toggle( value, EditorHelper.TempContent( s ), EditorStyles.toolbarButton, options );
		}
		public static bool Toggle( bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options ) {
			var rc = GUILayoutUtility.GetRect( content, style, options );
			return Toggle( rc, value, content, style );
		}
		public static bool Toggle( Rect position, bool value, GUIContent content, GUIStyle style ) {
			//bool ret=false;
			//bool ret2 = false;
			//if( Event.current.type == EventType.MouseDown ) {
			//	ret2 = true;
			//}
			var result = EditorHelper.HasMouseClick( position );

			if( GUI.Toggle( position, value, content, style ) ) {
				//ret= true;
				//Debug.Log( Event.current.type );
			}
			//if( Event.current.type != EventType.Used ) {
			//	return false;
			//}
			return result;
		}


		#endregion


		#region DropDown

		public static bool DropDown( string text, Texture2D image, Action action, params GUILayoutOption[] options ) {
			return DropDown( EditorHelper.TempContent( text, image ), action, options );
		}

		public static bool DropDown( Texture2D image, Action action, params GUILayoutOption[] options ) {
			return DropDown( EditorHelper.TempContent( image ), action, options );
		}

		public static bool DropDown( string text, Action action, params GUILayoutOption[] options ) {
			return DropDown( EditorHelper.TempContent( text ), action, options );
		}

		public static bool DropDown( string text, params GUILayoutOption[] options ) {
			return DropDown( EditorHelper.TempContent( text ), null, options );
		}

		public static bool DropDown( string text, string tooltip, Action action, params GUILayoutOption[] options ) {
			return DropDown( EditorHelper.TempContent( text, tooltip ), action, options );
		}

		public static bool DropDown( GUIContent content, Action action, params GUILayoutOption[] options ) {
			var size = EditorStyles.toolbarDropDown.CalcSize( EditorHelper.TempContent( content.text ) );
			var r = GUILayoutUtility.GetRect( content, toolbarDropDown, GUILayout.Width( size.x + 16 ) );
			HEditorGUI.lastRect = r;
			var result = EditorHelper.HasMouseClick( r );
			if( result ) {
				//Event.current.Use(); 
				action?.Invoke();
			}
			GUI.Button( r, content, toolbarDropDown );
			return result;
		}

		#endregion

	}
}

