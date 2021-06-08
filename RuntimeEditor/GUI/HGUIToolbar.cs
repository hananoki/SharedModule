using HananokiEditor.Extensions;
using HananokiRuntime.Extensions;
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
		public static GUIStyle toolbarDropDown {
			get {
				if( s_ToolbarDropDown == null ) {
					s_ToolbarDropDown = new GUIStyle( "ToolbarDropDown" );
					s_ToolbarDropDown.alignment = TextAnchor.MiddleCenter;

					s_ToolbarDropDown.padding.right = 18;
				}
				return s_ToolbarDropDown;
			}
		}


		public static void Begin() {
			//GUILayout.BeginHorizontal();
			//if( 0 < space ) GUILayout.Space( space );
			GUILayout.BeginHorizontal( EditorStyles.toolbar );
		}


		public static void End() {
			//GUILayout.EndHorizontal();
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
				Rect rc;
				if( !content.text.IsEmpty() && content.image != null ) {
					var xxx = EditorStyles.toolbarButton.CalcSize( new GUIContent( content.text ) ).x + 20;
					rc = GUILayoutUtility.GetRect( content, EditorStyles.toolbarButton, GUILayout.Width( xxx ) );
				}
				else {
					rc = GUILayoutUtility.GetRect( content, EditorStyles.toolbarButton, options );
				}

				return GUI.Button( rc, content, EditorStyles.toolbarButton );
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
		}

		public static bool Toggle( bool value, Texture image ) {
			return Toggle( value, EditorHelper.TempContent( image ), EditorStyles.toolbarButton, GUILayout.Width( 26 ) );
		}

		public static bool Toggle( bool value, Texture image, GUIStyle style ) {
			var cont = EditorHelper.TempContent( image );
			return Toggle( value, EditorHelper.TempContent( image ), style, GUILayout.Width( 26 ) );
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
		public static bool DropDown( string text, Texture2D image, params GUILayoutOption[] options ) {
			return DropDown( EditorHelper.TempContent( text, image ), null, options );
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
			var r = GUILayoutUtility.GetRect( content, toolbarDropDown, options.Length == 0 ? new GUILayoutOption[] { GUILayout.Width( size.x + 16 ) } : options );
			HEditorGUI.lastRect = r;
			var result = EditorHelper.HasMouseClick( r );
			if( result ) {
				action?.Invoke();
				Event.current.Use();//ボタンがアクティブになるため
			}
			GUI.Button( r, content, toolbarDropDown );
			return result;
		}

		#endregion


		#region DropDown2

		public static bool DropDown2( string text, Action buttonAction, Action allowAction, params GUILayoutOption[] options ) {
			return DropDown2( EditorHelper.TempContent( text ), buttonAction, allowAction, options );
		}
		public static bool DropDown2( string text, Texture2D image, Action buttonAction, Action allowAction, params GUILayoutOption[] options ) {
			return DropDown2( EditorHelper.TempContent( text, image ), buttonAction, allowAction, options );
		}
		public static bool DropDown2( Texture2D image, Action buttonAction, Action allowAction, params GUILayoutOption[] options ) {
			return DropDown2( EditorHelper.TempContent( image ), buttonAction, allowAction, options );
		}


		public static bool DropDown2( GUIContent content, Action buttonAction, Action allowAction, params GUILayoutOption[] options ) {
			return ToggleDropDown2( false, content, buttonAction, allowAction, options );
		}

		public static bool ToggleDropDown2( bool toggle, Texture2D image, Action buttonAction, Action allowAction, params GUILayoutOption[] options ) {
			return ToggleDropDown2( toggle, EditorHelper.TempContent( image ), buttonAction, allowAction, options );
		}


		public static bool ToggleDropDown2( bool toggle, GUIContent content, Action buttonAction, Action allowAction, params GUILayoutOption[] options ) {
			Vector2 size;
			if( content.text.IsEmpty() ) {
				size = new Vector2( 28, EditorGUIUtility.singleLineHeight );
			}
			else {
				size = EditorStyles.toolbarDropDown.CalcSize( EditorHelper.TempContent( content.text ) );
			}
			var r = GUILayoutUtility.GetRect( content, toolbarDropDown, options.Length == 0 ? new GUILayoutOption[] { GUILayout.Width( size.x + 16 ) } : options );
			HEditorGUI.lastRect = r;

			var lRect = r;
			lRect.width = 18;
			lRect.x += r.width;
			lRect.x -= lRect.width;
			if( EditorHelper.HasMouseClick( lRect ) ) {
				allowAction?.Invoke();
				Event.current.Use();
			}
			var result = EditorHelper.HasMouseClick( r );
			if( result ) {
				buttonAction?.Invoke();
				Event.current.Use();//ボタンがアクティブになるため
			}
			GUI.Toggle( r, toggle, content, toolbarDropDown );

			if( UnitySymbol.UNITY_2019_3_OR_NEWER ) {
				var rr = lRect.AlignCenter( 12, 12 );
				GUI.DrawTexture( rr, SharedModule.Icon.icondropdown_, ScaleMode.ScaleToFit );
				GUI.Label( lRect.AddH( -3 ), GUIContent.none, HEditorStyles.dopesheetBackground );
			}
			//EditorGUI.DrawRect( lRect , new Color(0,0,1,0.2f));
			return result;
		}

		#endregion

	}
}

