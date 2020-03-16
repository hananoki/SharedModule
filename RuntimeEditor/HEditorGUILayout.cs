#if UNITY_EDITOR

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Hananoki;
using Hananoki.Extensions;

using UnityObject = UnityEngine.Object;
using Hananoki.Reflection;

namespace HananokiEditor {
	public static class HEditorStyles {
		public static GUIStyle s_IconButton;
		public static GUIStyle iconButton {
			get {
				if( s_IconButton == null ) {
#if UNITY_2019_3_OR_NEWER
					s_IconButton = new GUIStyle( "IconButton" );
#else
					s_IconButton = new GUIStyle( "IconButton" );
					s_IconButton.fixedWidth = s_IconButton.fixedHeight = 16;
					s_IconButton.padding = new RectOffset( 0, 0, 0, 0 );
					s_IconButton.margin = new RectOffset( 0, 0, 0, 0 );
					s_IconButton.stretchWidth = false;
					s_IconButton.stretchHeight = false;
#endif
				}
				return s_IconButton;
			}
		}

		public static GUIStyle s_FoldoutText;
		public static GUIStyle foldoutText {
			get {
				if( s_FoldoutText == null ) {
					s_FoldoutText = new GUIStyle( "ExposablePopupItem" );
					s_FoldoutText.font = EditorStyles.boldLabel.font;
					s_FoldoutText.fontStyle = FontStyle.Bold;
					s_FoldoutText.margin = new RectOffset( 0, 0, 0, 0 );
				}
				return s_FoldoutText;
			}
		}
	}



	[InitializeOnLoad]
	public static class HGUILayoutToolbar {
		public static GUIStyle Toolbarbutton;
		static GUIStyle s_Toolbarbutton2;
		static GUIStyle Toolbarbutton2 {
			get {
				if( s_Toolbarbutton2 == null ) {
					s_Toolbarbutton2 = new GUIStyle( EditorStyles.toolbarButton );
					s_Toolbarbutton2.margin.zero();
					s_Toolbarbutton2.padding.zero();//= new RectOffset(1,1,2,2);
					s_Toolbarbutton2.fontSize = 10;
					s_Toolbarbutton2.fixedHeight=20;
				}
				return s_Toolbarbutton2;
			}
		}
		static GUIStyle ToolbarDropDown;

		static HGUILayoutToolbar() {
			void InitStyle() {
				try {
					if( EditorStyles.toolbarButton == null ) return;
				}
				catch( System.NullReferenceException ) {
					return;
				}
				Toolbarbutton = new GUIStyle( EditorStyles.toolbarButton );
				

				ToolbarDropDown = new GUIStyle( "ToolbarDropDown" );
				ToolbarDropDown.alignment = TextAnchor.MiddleCenter;
				ToolbarDropDown.padding = new RectOffset( 6, ToolbarDropDown.padding.right, 2, 2 );
				ToolbarDropDown.fontSize = 10;

				EditorApplication.update -= InitStyle;
			}
			EditorApplication.update += InitStyle;
		}

		public static bool Button( string s, Texture image, params GUILayoutOption[] options ) {
			return Button( EditorHelper.TempContent( s, image ), options );
		}
		public static bool Button( string s, params GUILayoutOption[] options ) {
			return Button( EditorHelper.TempContent( s ), options );
		}
		public static bool Button( Texture image, params GUILayoutOption[] options ) {
			return Button( EditorHelper.TempContent( image ), GUILayout.Width( 26 ) );
		}
		public static bool Button( GUIContent content,  params GUILayoutOption[] options ) {
			if( Toolbarbutton2 == null ) return false;
			try {
				if( GUILayout.Button( content, Toolbarbutton2, options ) ) {
					return true;
				}
			}
			catch( Exception e ) {
				Debug.LogException( e );
			}
			return false;
		}


		public static bool Toggle( bool value, string s, Texture image ) {
			var size = Toolbarbutton2.CalcSize( s.content() );
			var rc = GUILayoutUtility.GetRect( s.content(), Toolbarbutton2, GUILayout.Width( size.x+24 ) );
			return Toggle( rc, value , EditorHelper.TempContent( s, image ), Toolbarbutton2 );
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


		public static bool StaticButton( string s, params GUILayoutOption[] options ) {
			return StaticButton( EditorHelper.TempContent( s ), options );
		}
		public static bool StaticButton( Texture image, params GUILayoutOption[] options ) {
			return StaticButton( EditorHelper.TempContent( image ), GUILayout.Width( 26 ) );
		}
		public static bool StaticButton( GUIContent content, params GUILayoutOption[] options ) {
			if( Toolbarbutton2 == null ) return false;
			try {
				GUILayout.Label( content, Toolbarbutton2, options );
				if( EditorHelper.HasMouseClick( GUILayoutUtility.GetLastRect() ) ) {
					return true;
				}
			}
			catch( Exception e ) {
				Debug.LogException( e );
			}
			return false;
		}


		public static bool DropDown( string s, params GUILayoutOption[] options ) {
			return DropDown( EditorHelper.TempContent( s ), options );
		}

		public static bool DropDown( GUIContent content, params GUILayoutOption[] options ) {
			if( ToolbarDropDown == null ) return false;

			var r = GUILayoutUtility.GetRect( content, ToolbarDropDown, options );
			var result = EditorHelper.HasMouseClick( r );
			if( result ) {
				Event.current.Use();
			}
			GUI.Button( r, content, ToolbarDropDown );
			return result;
		}
	}



	public static class HEditorGUI {
		public static Rect lastRect;


		public static bool IconButton( Rect position, Texture2D tex, float heighOffset = 0 ) {
			return IconButton( position, tex, HEditorStyles.iconButton, heighOffset );
		}
		public static bool IconButton( Rect position, Texture2D tex, GUIStyle style, float heighOffset = 0 ) {
			bool result = false;
			position.y += heighOffset;
			if( EditorHelper.HasMouseClick( position ) ) {
				Event.current.Use();
				result = true;
			}
			//EditorGUI.DrawRect( r2, new Color( 0, 0, 1, 0.2f ) );
			//GUIStyle s = EditorStyles.label;
			//s.name = "IconButton";
			////s.name = "Command";
			//var a = R.Field( "blockId", "UnityEngine.GUIStyle", "UnityEngine.dll" );
			////var mm = a.GetValue( s );
			//a.SetValue( s , 0);
			//EditorGUI.DrawRect( position, new Color( 0, 0, 1, 0.2f ) );
			GUI.Button( position, EditorHelper.TempContent( tex ), style );
			return result;
		}


		public static bool DropDown( Rect position, string text, GUIStyle style, float allowWidth, Action buttonAction, Action allowAction ) {
			return DropDown( position, EditorHelper.TempContent( text ), style, allowWidth, buttonAction, allowAction );
		}

		public static bool DropDown( Rect position, GUIContent content, GUIStyle style, float allowWidth, Action buttonAction, Action allowAction ) {
			lastRect = position;
			lastRect.width = allowWidth;
			lastRect.x += position.width;
			lastRect.x -= lastRect.width;
			if( EditorHelper.HasMouseClick( lastRect ) ) {
				allowAction?.Invoke();
				Event.current.Use();
			}
			if( GUI.Button( position, content, style ) ) {
				buttonAction?.Invoke();
			}

			//EditorGUI.DrawRect( lastRect, new Color( 0, 0, 1, 0.5f ) );
			return false;
		}
	}


	public static class HEditorGUILayout {

		

		public static bool Foldout( bool foldout, string text ) {
			string ssss = "     " + text;

			var cont = new GUIContent( ssss );
			var sz = HEditorStyles.foldoutText.CalcSize( cont );
			var rc = GUILayoutUtility.GetRect( cont, HEditorStyles.foldoutText, GUILayout.Width( sz.x ) );
			//EditorGUI.DrawRect( GUILayoutUtility.GetLastRect(),new Color(0,0,1,0.2f));
			var rc2 = rc;
			rc2.x += 4;
			foldout = EditorGUI.Foldout( rc2, foldout, "" );
			GUI.Button( rc, cont, HEditorStyles.foldoutText );
			return foldout;
		}


		public static bool IconButton( Texture2D tex, int marginHeighOffset = 0 ) {
			var style = new GUIStyle( HEditorStyles.iconButton );
			style.margin = new RectOffset( 0, 0, marginHeighOffset, 0 );
			var r = EditorHelper.GetLayout( tex, style );
			return HEditorGUI.IconButton( r, tex, style, 0 );
		}
		//public static bool DropDown( string text, GUIStyle style, params GUILayoutOption[] options ) {
		//	return DropDown( EditorHelper.TempContent( text ), style, options );
		//}

		//public static bool DropDown( GUIContent content, GUIStyle style, params GUILayoutOption[] options ) {
		//	//if( ToolbarDropDown == null ) return false;
		//	var rect = GUILayoutUtility.GetRect( content, style, options );
		//	GUI.Button( rect, content, style );
		//	//if( EditorHelper.HasMouseClick( GUILayoutUtility.GetLastRect() ) ) {
		//	//	return true;
		//	//}
		//	return false;
		//}
		public static void BoldLabel( string s, Texture2D ico = null ) {
			var fontStyle = EditorStyles.label.fontStyle;
			EditorStyles.label.fontStyle = FontStyle.Bold;

			GUILayout.Label( EditorHelper.TempContent( s, ico ), EditorStyles.label );

			EditorStyles.label.fontStyle = fontStyle;
		}

		public static bool SessionToggle( string label, bool value, Color color ) {
			var rcc = EditorGUILayout.GetControlRect( true, EditorGUIUtility.singleLineHeight );
			EditorGUI.DrawRect( rcc, new Color( 0f, 1f, 0f, 0.25f ) );
			return EditorGUI.Toggle( rcc, ObjectNames.NicifyVariableName( label ), value );
		}

		public static int SessionIntField( string label, int value, Color color ) {
			var rcc = EditorGUILayout.GetControlRect( true, EditorGUIUtility.singleLineHeight );
			EditorGUI.DrawRect( rcc, new Color( 0f, 1f, 0f, 0.25f ) );
			return EditorGUI.IntField( rcc, label, value );
		}


		public static bool ToggleLeft( bool value, Texture2D ico, string text, params GUILayoutOption[] options ) {
			var col1 = ColorUtils.RGB( 169, 201, 255 );
			var col2 = ColorUtils.RGB( 212, 212, 212 );
			if( value ) {
				GUI.backgroundColor = col1;
			}
			else {
				GUI.backgroundColor = col2;
			}

			using( new EditorGUILayout.HorizontalScope( EditorStyles.helpBox ) ) {
				value = GUILayout.Toggle( value, ico );
				var r = GUILayoutUtility.GetLastRect();
				r.x += 56;
				GUI.Label( r, text, EditorStyles.boldLabel );
			}
			return value;
		}

		public static bool ToggleLeft( string s, bool b, float heighOffset = 0 ) {
			using( new GUILayout.HorizontalScope() ) {
				GUILayout.Space( 15 * EditorGUI.indentLevel );

				var rt = EditorHelper.GetLayout( "", EditorStyles.toggle, GUILayout.Width( 16 ) );
				rt.y += heighOffset;
				bool b11 = GUI.Toggle( rt, b, "" );
				var r = EditorHelper.GetLayout( s, EditorStyles.label );
				r.x -= 5;
				r.y += heighOffset;
				GUI.Label( r, s, EditorStyles.label );
				return b11;
			}
		}

		public static bool SessionToggleLeft( string s, bool b ) {
			return SessionToggleLeft( s, s, b );
		}

		public static bool SessionToggleLeft( string s1, string s2, bool b ) {
			using( new GUILayout.HorizontalScope() ) {
				GUILayout.Space( 15 * EditorGUI.indentLevel );
				var rt = GUILayoutUtility.GetRect( EditorHelper.TempContent( "" ), EditorStyles.toggle, GUILayout.Width( 16 ) );
				var r = GUILayoutUtility.GetRect( EditorHelper.TempContent( s1, s2 ), EditorStyles.label );
				r.x -= 5;
				var rr = r;
				rr.x -= 16;
				rr.width += 16;
				EditorGUI.DrawRect( rr, new Color( 0f, 1f, 0f, 0.25f ) );
				GUI.Label( r, EditorHelper.TempContent( s1, s2 ), EditorStyles.label );
				bool b11 = GUI.Toggle( rt, b, "" );
				return b11;
			}
		}

		public static T ObjectField<T>( string label, UnityObject obj, bool allowSceneObjects = false, params GUILayoutOption[] options ) where T : UnityObject {
			return (T) EditorGUILayout.ObjectField( label, obj, typeof( T ), allowSceneObjects, options );
		}
		public static T ObjectField<T>( UnityObject obj, bool allowSceneObjects = false, params GUILayoutOption[] options ) where T : UnityObject {
			return (T) EditorGUILayout.ObjectField( obj, typeof( T ), allowSceneObjects, options );
		}

		public static string GUIDObjectField( string label, string guid ) {
			UnityObject value = null;
			var path = AssetDatabase.GUIDToAssetPath( guid );
			if( !string.IsNullOrEmpty( path ) ) {
				value = AssetDatabase.LoadAssetAtPath<UnityObject>( path );
			}

			EditorGUILayout.LabelField( "" );
			var rc = GUILayoutUtility.GetLastRect();

			rc = EditorGUI.PrefixLabel( rc, GUIUtility.GetControlID( FocusType.Passive ), new GUIContent( label ) );
			//GUI.changed = false;
			value = (UnityObject) EditorGUI.ObjectField( rc, value, typeof( UnityObject ), false );
			//if( GUI.changed ) {
			if( value == null ) return "";

			return AssetDatabase.AssetPathToGUID( AssetDatabase.GetAssetPath( value ) );
		}

		public static string GUIDObjectField<T>( string label, string guid ) where T : UnityObject {
			T value = null;
			var path = AssetDatabase.GUIDToAssetPath( guid );
			if( !path.IsEmpty() ) {
				value = AssetDatabase.LoadAssetAtPath<T>( path );
			}

			EditorGUILayout.LabelField( "" );
			var rc = GUILayoutUtility.GetLastRect();

			rc = EditorGUI.PrefixLabel( rc, GUIUtility.GetControlID( FocusType.Passive ), new GUIContent( label ) );
			//GUI.changed = false;
			value = (T) EditorGUI.ObjectField( rc, value, typeof( T ), false );
			//if( GUI.changed ) {
			if( value == null ) return "";

			return AssetDatabase.AssetPathToGUID( AssetDatabase.GetAssetPath( value ) );
		}
	}
}

#endif
