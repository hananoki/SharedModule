
using HananokiEditor.Extensions;
using HananokiRuntime;
using HananokiRuntime.Extensions;
using System;
using UnityEditor;
using UnityEngine;

using UnityObject = UnityEngine.Object;

namespace HananokiEditor {

	public static class HGUILayout {
		public static void Label( string text, Texture image, params GUILayoutOption[] options ) {
			var style = EditorStyles.label;
			style.fixedHeight = EditorGUIUtility.singleLineHeight;
			GUILayout.Label( EditorHelper.TempContent( text, image ), style, options );
		}

		public static void Label( string text, Texture image, GUIStyle style, params GUILayoutOption[] options ) {
			GUILayout.Label( EditorHelper.TempContent( text, image ), style, options );
		}




		/*
		public static bool Toggle( bool value, string text, params GUILayoutOption[] options ) {
			return Toggle( value, EditorHelper.TempContent( text ), EditorStyles.toggle, options );
		}
		public static bool Toggle( bool value, string text, GUIStyle style, params GUILayoutOption[] options ) {
			return Toggle( value, EditorHelper.TempContent( text ), style, options );
		}

		public static bool Toggle( bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options ) {

			var position = GUILayoutUtility.GetRect( content, style, options );
			var result = EditorHelper.HasMouseClick( position );

			if( value )
				EditorGUI.DrawRect( position, Color.white );
			var b = GUI.Toggle( position, value, content, style );

			return result;
		}
		*/

		static GUIStyle s_ToggleBox;
		public static GUIStyle toggleBox {
			get {
				if( s_ToggleBox == null ) {
					s_ToggleBox = new GUIStyle( EditorStyles.helpBox );
					s_ToggleBox.padding = new RectOffset( 4, 4, 2, 2 );
					s_ToggleBox.margin = new RectOffset( 3, 3, 2, 2 );
					s_ToggleBox.onNormal = s_ToggleBox.normal;
				}
				return s_ToggleBox;
			}
		}

		public static bool ToggleBox( bool value, string text, params GUILayoutOption[] options ) {
			return ToggleBox( value, EditorHelper.TempContent( text ), options );
		}

		public static bool ToggleBox( bool value, GUIContent content, params GUILayoutOption[] options ) {

			var position = GUILayoutUtility.GetRect( content, toggleBox, options );
			var result = EditorHelper.HasMouseClick( position );

			var backgroundColor = GUI.backgroundColor;
			//if( value ) {
			//	GUI.backgroundColor = ColorUtils.RGB( 169, 201, 255 );
			//}

			//if( value )
			//	EditorGUI.DrawRect( position, Color.white );
			using( new GUIBackgroundColorScope() ) {
				if( value ) {
					//GUI.backgroundColor = ColorUtils.RGB( 169, 201, 255 );
					var r = position;
					r.x += 1;
					r.width -= 2;
					EditorGUI.DrawRect( r, EditorGUIUtility.isProSkin ? ColorUtils.RGB( 128, 128, 128 ) : Color.white );
					//GUI.backgroundColor = ColorUtils.RGB( 200, 200, 200 );
				}
				var b = GUI.Toggle( position, value, content, toggleBox );

				return result;
			}
		}


	}




	public static class HEditorGUILayout {

		public static Vector3 Vector3Field( string label, Vector3 value, params GUILayoutOption[] options ) {
			var cont = EditorHelper.TempContent( label );
			var rect = GUILayoutUtility.GetRect( cont, EditorStyles.numberField );
			return HEditorGUI.Vector3Field( rect, cont, value );
		}

		#region LabelField

		public static void LabelField( string text, Texture image, params GUILayoutOption[] options ) {
			var style = EditorStyles.label;
			style.fixedHeight = EditorGUIUtility.singleLineHeight;
			EditorGUILayout.LabelField( EditorHelper.TempContent( text, image ), style, options );
		}

		public static void LabelField( string text, Texture image, GUIStyle style, params GUILayoutOption[] options ) {
			EditorGUILayout.LabelField( EditorHelper.TempContent( text, image ), style, options );
		}

		#endregion

		#region HeaderTitle
		public static bool ToggleBox( string title, bool value, Texture2D iconButton = null, Action actionButton = null ) {
			return ToggleBox( title, value, false, iconButton, actionButton );
		}

		public static bool ToggleBox( string title, bool value, bool boldFont, Texture2D iconButton = null, Action actionButton = null ) {
			bool result = value;
			var backgroundColor = GUI.backgroundColor;
			if( value ) {
				GUI.backgroundColor = ColorUtils.RGB( 169, 201, 255 );
			}

			GUILayout.BeginHorizontal( EditorStyles.helpBox );
			if( boldFont ) {
				GUI.skin.toggle.fontStyle = FontStyle.Bold;
			}
			result = GUILayout.Toggle( value, title, GUILayout.Height( EditorGUIUtility.singleLineHeight ) );
			GUILayout.FlexibleSpace();

			if( iconButton != null ) {
				if( IconButton( iconButton ) ) {
					actionButton?.Invoke();
				}
			}

			GUILayout.EndHorizontal();
			GUI.skin.toggle.fontStyle = FontStyle.Normal;
			GUI.backgroundColor = backgroundColor;

			return result;
		}


		public static bool ToggleBox( bool value, Texture2D ico, string text, bool boldFont = false ) {
			bool result = value;
			var backgroundColor = GUI.backgroundColor;
			if( value ) {
				GUI.backgroundColor = ColorUtils.RGB( 169, 201, 255 );
			}
			GUILayout.BeginHorizontal( EditorStyles.helpBox );
			if( boldFont ) {
				GUI.skin.toggle.fontStyle = FontStyle.Bold;
			}
			result = GUILayout.Toggle( value, ico );
			var r = GUILayoutUtility.GetLastRect();
			r.x += 56;
			GUI.Label( r, text, EditorStyles.boldLabel );
			//GUILayout.FlexibleSpace();

			//if( iconButton != null ) {
			//	if( IconButton( iconButton ) ) {
			//		actionButton?.Invoke();
			//	}
			//}

			GUILayout.EndHorizontal();
			GUI.skin.toggle.fontStyle = FontStyle.Normal;
			GUI.backgroundColor = backgroundColor;

			return result;
		}

		#endregion

		#region HeaderTitle

		public static void HeaderTitle( string title, float space = 4 ) {
			var labelCont = EditorHelper.TempContent( title );
			var rc = GUILayoutUtility.GetRect( labelCont, EditorStyles.label );
			HEditorGUI.HeaderTitle( rc, title );
			GUILayout.Space( space );
		}

		#endregion


		public static void LabelBox( string text ) {
			ScopeHorizontal.Begin( EditorStyles.helpBox );
			GUILayout.Label( text );
			ScopeHorizontal.End();
		}


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



		public static string FileFiled( string label, string file, string[] filters, params GUILayoutOption[] options ) {
			if( !label.IsEmpty() ) {
				EditorGUILayout.LabelField( label/*, EditorStyles.boldLabel*/ );
			}
			var backgroundColor = GUI.backgroundColor;
			if( !file.IsEmpty() && !file.IsExistsFile() ) {
				GUI.backgroundColor = HEditorStyles.helpBoxInvalidColor;
			}
			ScopeHorizontal.Begin( EditorStyles.helpBox );
			var rect = GUILayoutUtility.GetRect( GUIContent.none, HEditorStyles.folderField, options );
			var newfile = HEditorGUI.FileFiled( rect, GUIContent.none, file, filters );
			ScopeHorizontal.End();

			GUI.backgroundColor = backgroundColor;

			return newfile;
		}


		public static string FolderFiled( string label, string path, params GUILayoutOption[] options ) {
			var rect = GUILayoutUtility.GetRect( GUIContent.none, HEditorStyles.folderField, options );

			return HEditorGUI.FolderFiled( rect, EditorHelper.TempContent( label ), path );
		}

		public static string FolderFiled( string path, params GUILayoutOption[] options ) {
			var rect = GUILayoutUtility.GetRect( GUIContent.none, HEditorStyles.folderField, options );

			return HEditorGUI.FolderFiled( rect, path );
		}

		public static void PreviewFolder(/* string label, */string path, Action presetAction = null ) {
			ScopeHorizontal.Begin( EditorStyles.helpBox );
			GUILayout.Label( path );
			GUILayout.FlexibleSpace();
			if( presetAction != null ) {
				if( IconButton( EditorIcon.preset_context ) ) {
					presetAction.Invoke();
				}
			}
			ScopeDisable.Begin( !path.IsExistsDirectory() );
			if( IconButton( EditorIcon.icons_processed_folderempty_icon_asset ) ) {
				ShellUtils.OpenDirectory( path );
			}
			ScopeDisable.End();
			ScopeHorizontal.End();
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


		#region IconButton

		public static bool IconButton( Texture2D image, int marginHeighOffset = 0 ) {
			var style = new GUIStyle( HEditorStyles.iconButton );
			style.margin = new RectOffset( 0, 0, marginHeighOffset, 0 );
			var r = EditorHelper.GetLayout( image, style );
			return HEditorGUI.IconButton( r, EditorHelper.TempContent( image ), style, 0 );
		}
		public static bool IconButton( Texture2D image, string tooltip, int marginHeighOffset = 0 ) {
			var style = new GUIStyle( HEditorStyles.iconButton );
			style.margin = new RectOffset( 0, 0, marginHeighOffset, 0 );
			var r = EditorHelper.GetLayout( image, style );
			return HEditorGUI.IconButton( r, EditorHelper.TempContent( image, tooltip ), style, 0 );
		}

		#endregion



		#region FlatButton

		public static bool FlatButton( string text, Texture2D image, bool expand = false ) {
			var cont = EditorHelper.TempContent( text, image );
			return FlatButton( cont, expand );
		}

		public static bool FlatButton( string text, bool expand = false ) {
			var cont = EditorHelper.TempContent( text );
			return FlatButton( cont, expand );
		}

		public static bool FlatButton( GUIContent content, bool expand = false ) {
			var style = new GUIStyle( HEditorStyles.flatButton );
			var size = content.text.CalcSizeFromLabel();
			var rect = expand ? GUILayoutUtility.GetRect( content, style, GUILayout.Width( size.x + 16 + 8 ) ) : GUILayoutUtility.GetRect( content, style );

			return HEditorGUI.FlatButton( rect, content, style );
		}

		#endregion


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
			GUILayout.BeginHorizontal();
			GUILayout.Space( 15 * EditorGUI.indentLevel );

			var rt = EditorHelper.GetLayout( "", EditorStyles.toggle, GUILayout.Width( 16 ), GUILayout.Height( EditorGUIUtility.singleLineHeight ) );
			rt.y += heighOffset;
			bool b11 = GUI.Toggle( rt, b, "" );
			var r = EditorHelper.GetLayout( s, EditorStyles.label, GUILayout.Height( EditorGUIUtility.singleLineHeight ) );
			r.x -= 2;
			r.y += heighOffset;
			//if( b11 ) HEditorGUI.DrawDebugRect( r );
			GUI.Label( r, s, EditorStyles.label );
			GUILayout.EndHorizontal();

			//HEditorGUI.DrawDebugRectAtLastRect();
			//HEditorGUI.DrawDebugRect( r );
			return b11;
		}


		public static bool SessionToggleLeft( string s, bool b ) {
			return SessionToggleLeft( s, "", b );
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
				if( s2.IsEmpty() ) GUI.Label( r, EditorHelper.TempContent( s1 ), EditorStyles.label );
				else GUI.Label( r, EditorHelper.TempContent( s1, s2 ), EditorStyles.label );
				bool b11 = GUI.Toggle( rt, b, "" );
				return b11;
			}
		}



		#region ObjectFieldAndAction<T>

		public static T ObjectField<T>( T obj, bool allowSceneObjects = false, bool safeCheck = true, params GUILayoutOption[] options ) where T : UnityObject {
			return (T) ObjectField<T>( GUIContent.none, obj, allowSceneObjects, safeCheck, options );
		}

		public static T ObjectField<T>( UnityObject obj, bool allowSceneObjects = false, bool safeCheck = true, params GUILayoutOption[] options ) where T : UnityObject {
			return (T) ObjectField<T>( GUIContent.none, obj, allowSceneObjects, safeCheck, options );
		}

		public static T ObjectField<T>( string label, UnityObject obj, bool allowSceneObjects = false, bool safeCheck = true, params GUILayoutOption[] options ) where T : UnityObject {
			return ObjectField<T>( label.IsEmpty() ? GUIContent.none : EditorHelper.TempContent( label ), obj, allowSceneObjects, safeCheck, options );
		}

		public static T ObjectField<T>( GUIContent content, UnityObject obj, bool allowSceneObjects = false, bool safeCheck = true, params GUILayoutOption[] options ) where T : UnityObject {

			var rc = GUILayoutUtility.GetRect( content, EditorStyles.objectField, options );

			if( content != GUIContent.none ) {
				rc = EditorGUI.PrefixLabel( rc, GUIUtility.GetControlID( FocusType.Passive ), content );
			}

			T _obj;
			using( new GUIBackgroundColorScope() ) {
				if( safeCheck && obj == null ) {
					GUI.backgroundColor = HEditorStyles.fieldInvalidColor;
					rc.width -= 16;
				}
				_obj = (T) EditorGUI.ObjectField( rc, obj, typeof( T ), allowSceneObjects );
			}

			if( _obj == null ) {
				rc.x = rc.xMax;
				rc.width = 16;
				if( HEditorGUI.IconButton( rc, EditorIcon.plus ) ) {
					var path = $"{ProjectBrowserUtils.activeFolderPath}/New {typeof( T ).Name}.asset".GenerateUniqueAssetPath();
					_obj = (T) AssetDatabaseUtils.CreateScriptableObject( typeof( T ), path );
				}
			}
			return _obj;
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




}
