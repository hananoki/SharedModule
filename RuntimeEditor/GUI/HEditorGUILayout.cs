
using Hananoki.Extensions;
using System;
using UnityEditor;
using UnityEngine;

using UnityObject = UnityEngine.Object;

namespace Hananoki {

	public static class HEditorGUILayout {

		#region HeaderTitle



		public static void HeaderTitle( string title, float space = 4 ) {
			var labelCont = EditorHelper.TempContent( title );
			var rc = GUILayoutUtility.GetRect( labelCont, EditorStyles.label );
			HEditorGUI.HeaderTitle( rc, title );
			GUILayout.Space( space );
		}

		#endregion

		public static string TextFieldAndAction( string label, string text, Action buttonAction, bool safeCheck = true, params GUILayoutOption[] options ) {
			var labelCont = EditorHelper.TempContent( label );
			var rc = GUILayoutUtility.GetRect( labelCont, EditorStyles.textField, options );
			rc = EditorGUI.PrefixLabel( rc, GUIUtility.GetControlID( FocusType.Passive ), new GUIContent( label ) );

			using( new GUIBackgroundColorScope() ) {
				if( label.IsEmpty() ) {
					GUI.backgroundColor = HEditorStyles.fieldInvalidColor;
				}
				var fieldRect = rc;
				fieldRect.width -= 18;
				label = EditorGUI.TextField( fieldRect, text );

				if( HEditorGUI.IconButton( rc.AlignR( 16 ), EditorIcon.settings, 1 ) ) {
					buttonAction?.Invoke();
				}
			}
			return label;
		}


		public static string FolderFiled( string label, string path, params GUILayoutOption[] options ) {
			var rect = GUILayoutUtility.GetRect( GUIContent.none, HEditorStyles.folderField, options );

			return HEditorGUI.FolderFiled( rect, EditorHelper.TempContent( label ), path );
		}


		public static float FrameSlider( float value, int leftValue, int rightValue, params GUILayoutOption[] options ) {
			int frame = (int) ( ( value * 60.0f ) + 0.5f );
			frame = EditorGUILayout.IntSlider( frame, leftValue, rightValue );
			return frame / 60.0f;
		}

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

		public static bool ImageButton( Texture2D tex, params GUILayoutOption[] option ) {
			var style = new GUIStyle( HEditorStyles.imageButton );
			//style.margin = new RectOffset( 0, 0, 0, 0 );
			var r = EditorHelper.GetLayout( tex, style, option );
			return HEditorGUI.ImageButton( r, EditorHelper.TempContent( tex ), style );
		}


		public static bool IconButton( Texture2D tex, int marginHeighOffset = 0 ) {
			var style = new GUIStyle( HEditorStyles.iconButton );
			style.margin = new RectOffset( 0, 0, marginHeighOffset, 0 );
			var r = EditorHelper.GetLayout( tex, style );
			return HEditorGUI.IconButton( r, EditorHelper.TempContent( tex ), style, 0 );
		}
		public static bool IconButton( Texture2D tex, string tooltip, int marginHeighOffset = 0 ) {
			var style = new GUIStyle( HEditorStyles.iconButton );
			style.margin = new RectOffset( 0, 0, marginHeighOffset, 0 );
			var r = EditorHelper.GetLayout( tex, style );
			return HEditorGUI.IconButton( r, EditorHelper.TempContent( tex, tooltip ), style, 0 );
		}

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



		#region ObjectFieldAndAction<T>

		public static T ObjectField<T>( string label, UnityObject obj, bool allowSceneObjects = false, params GUILayoutOption[] options ) where T : UnityObject {
			var labelCont = EditorHelper.TempContent( label );
			var rc = GUILayoutUtility.GetRect( labelCont, EditorStyles.objectField, options );
			rc = EditorGUI.PrefixLabel( rc, GUIUtility.GetControlID( FocusType.Passive ), new GUIContent( label ) );

			using( new GUIBackgroundColorScope() ) {
				if( obj == null ) {
					GUI.backgroundColor = HEditorStyles.fieldInvalidColor;
				}
				var _obj = (T) EditorGUI.ObjectField( rc, obj, typeof( T ), allowSceneObjects );
				return _obj;
			}
		}

		public static T ObjectField<T>( UnityObject obj, bool allowSceneObjects = false, bool safeCheck = true, params GUILayoutOption[] options ) where T : UnityObject {
			using( new GUIBackgroundColorScope() ) {
				if( safeCheck && obj == null ) {
					GUI.backgroundColor = HEditorStyles.fieldInvalidColor;
				}
				return (T) EditorGUILayout.ObjectField( obj, typeof( T ), allowSceneObjects, options );
			}
		}

		#endregion


		#region GUIDObjectField<T>

		public static string GUIDObjectField( string label, string guid ) {
			UnityObject value = null;
			var path = AssetDatabase.GUIDToAssetPath( guid );
			if( !string.IsNullOrEmpty( path ) ) {
				value = AssetDatabase.LoadAssetAtPath<UnityObject>( path );
			}

			EditorGUILayout.LabelField( "" );
			var rc = GUILayoutUtility.GetLastRect();

			rc = EditorGUI.PrefixLabel( rc, GUIUtility.GetControlID( FocusType.Passive ), new GUIContent( label ) );
			using( new GUIBackgroundColorScope() ) {
				if( value == null ) {
					GUI.backgroundColor = HEditorStyles.fieldInvalidColor;
				}
				value = EditorGUI.ObjectField( rc, value, typeof( UnityObject ), false );
			}
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
			using( new GUIBackgroundColorScope() ) {
				if( value == null ) {
					GUI.backgroundColor = HEditorStyles.fieldInvalidColor;
				}
				value = (T) EditorGUI.ObjectField( rc, value, typeof( T ), false );
			}
			if( value == null ) return "";

			return AssetDatabase.AssetPathToGUID( AssetDatabase.GetAssetPath( value ) );
		}

		#endregion

	}




	public static class HGUIScope {
		public static void Horizontal( Action action, params GUILayoutOption[] options ) {
			if( action == null ) return;
			GUILayout.BeginHorizontal();
			action.Invoke();
			GUILayout.EndHorizontal();
		}

		public static void Horizontal( GUIStyle style, Action action, params GUILayoutOption[] options ) {
			if( action == null ) return;
			GUILayout.BeginHorizontal( style );
			action.Invoke();
			GUILayout.EndHorizontal();
		}

		public static void Vertical( Action action, params GUILayoutOption[] options ) {
			if( action == null ) return;
			GUILayout.BeginVertical();
			action.Invoke();
			GUILayout.EndVertical();
		}
		public static void Vertical( GUIStyle style, Action action, params GUILayoutOption[] options ) {
			if( action == null ) return;
			GUILayout.BeginVertical( style );
			action.Invoke();
			GUILayout.EndVertical();
		}

		public static void Disable( bool disabled, Action action ) {
			if( action == null ) return;

			EditorGUI.BeginDisabledGroup( disabled );
			action.Invoke();
			EditorGUI.EndDisabledGroup();
		}
	}



}
