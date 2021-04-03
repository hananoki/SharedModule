
using HananokiEditor.Extensions;
using HananokiRuntime;
using HananokiRuntime.Extensions;
using System;
using UnityEditor;
using UnityEngine;
using UnityObject = UnityEngine.Object;

namespace HananokiEditor {

	public static class HEditorGUI {
		public static Rect lastRect;

		public static void DrawDebugRect( Rect position ) {
			EditorGUI.DrawRect( position, new Color( 0, 0, 1, 0.2f ) );
		}
		public static void DrawDebugRectAtLastRect() {
			DrawDebugRect( GUILayoutUtility.GetLastRect() );
		}


		public static Vector3 Vector3Field( Rect position, GUIContent content, Vector3 _value, params GUILayoutOption[] options ) {
			var r = EditorGUI.PrefixLabel( position, content );
			//EditorGUI.DrawRect( , Color.black );
			if( EditorHelper.HasMouseClick( position.W( r.x - EditorGUI.indentLevel * 16 ), EventMouseButton.R ) ) {
				var m = new GenericMenu();
				m.AddItem( SharedModule.S._Copy, ( context ) => EditorHelper.MenuCopyPos( (Vector3) context ), _value );
				//m.AddItem( SharedModule.S._Paste, ( context ) => {
				//	//ref Vector3 = (ref Vector3)context;
				//	_value = EditorHelper.GetMenuPastePos();
				//} );
				m.DropDownPopupRect( position );
			}
			return EditorGUI.Vector3Field( r, "", _value );
		}


		public static float Slider( Rect position, float value, float start, float end ) {
			int controlID = GUIUtility.GetControlID( "HEditorSliderKnob".GetHashCode(), FocusType.Passive, position );
			return GUI.Slider( position, value, 0, start, end, GUI.skin.horizontalSlider, GUI.skin.horizontalSliderThumb, true, controlID );
		}


		#region MiniLabel
		public static void MiniLabel( Rect position, string title ) {
			MiniLabel( position, EditorHelper.TempContent( title ) );
		}
		public static void MiniLabel( Rect position, GUIContent content ) {
			GUI.Label( position, content, EditorStyles.miniLabel );
		}
		#endregion


		#region MiniLabelR

		public static void MiniLabelR( Rect position, string title ) {
			var lrc = position;
			var cont = EditorHelper.TempContent( $"{title}" );
			var size = HEditorStyles.versionLabel.CalcSize( cont );

			lrc = lrc.AlignR( size.x );
			lrc.x -= 4;
			lrc = lrc.AlignCenterH( 12 );
			EditorGUI.DrawRect( lrc, SharedModule.SettingsEditor.i.versionBackColor );
			HEditorStyles.versionLabel.normal.textColor = SharedModule.SettingsEditor.i.versionTextColor;
			GUI.Label( lrc, $"{title}", HEditorStyles.versionLabel );
		}

		#endregion



		#region HeaderTitle

		public static void DrawLine( Rect rc ) {
			using( new GUIColorScope() ) {
				if( EditorGUIUtility.isProSkin ) {
					GUI.color = ColorUtils.RGB( 176 );
				}
				else {
					GUI.color = ColorUtils.RGB( 77 );
				}
				rc.y = rc.yMax - 1;
				rc.height = 1;
				EditorGUI.DrawRect( rc, GUI.color );
			}
		}


		public static void HeaderTitle( Rect position, string title ) {
			try {
				position.height = EditorGUIUtility.singleLineHeight;
				//position.y += 4;
				EditorGUI.LabelField( position, title, EditorStyles.boldLabel );
				DrawLine( position );
			}
			catch( ExitGUIException ) {
			}
			catch( System.Exception e ) {
				Debug.LogError( e );
			}
		}

		#endregion



		#region PropertyField

		public static void PropertyField( SerializedProperty prop, Texture2D icon, Action action ) {
			PropertyField( prop, prop.displayName, icon, action );
		}
		public static void PropertyField( SerializedProperty prop, GUIContent content, Texture2D icon, Action action ) {
			PropertyField( prop, content.text, icon, action );
		}

		public static void PropertyField( SerializedProperty prop, string displayName, Texture2D icon, Action action ) {
			var cont = EditorHelper.TempContent( displayName );
			var rect = GUILayoutUtility.GetRect( cont, EditorStyles.objectField );
			var lsss = EditorGUI.PrefixLabel( rect, cont );
			EditorGUI.PropertyField( lsss, prop, GUIContent.none );
			lsss.x -= 16;
			lsss.width = 16;
			lastRect = lsss;
			if( HEditorGUI.IconButton( lsss, icon, 1 ) ) {
				action?.Invoke();
			}
		}

		public static void PropertyField( SerializedProperty prop, Texture2D icon, Action action, Texture2D icon2, Action action2 ) {
			var cont = EditorHelper.TempContent( prop.displayName );
			var rect = GUILayoutUtility.GetRect( cont, EditorStyles.objectField );
			var lsss = EditorGUI.PrefixLabel( rect, cont );
			EditorGUI.PropertyField( lsss, prop, GUIContent.none );
			lsss.x -= 32;
			lsss.width = 16;
			if( HEditorGUI.IconButton( lsss, icon, 1 ) ) {
				action?.Invoke();
			}
			lsss.x += 16;
			if( HEditorGUI.IconButton( lsss, icon2, 1 ) ) {
				action2?.Invoke();
			}
		}

		#endregion



		#region FileFiled

		public static string FileFiled( Rect position, string path, string[] filters ) {
			return FileFiled( position, null, path, filters );
		}
		// フォームのファイル拡張子 { "Image files", "png,jpg,jpeg", "All files", "*" }。
		public static string FileFiled( Rect position, GUIContent content, string path, string[] filters ) {
			var name = path.IsEmpty() ? "None (File)" : path;
			var rcL = position;
			rcL.width -= 18;

			//if( !path.IsEmpty() && !path.IsExistsFile() ) {
			//	HEditorGUI.DrawDebugRect( position );
			//}
			var icon = EditorIcon.icons_processed_unityeditor_defaultasset_icon_asset;
			if( content == null ) {
				EditorGUI.LabelField( rcL, GUIContent.none, EditorHelper.TempContent( name, icon ), HEditorStyles.folderField );
			}
			else {
				rcL = EditorGUI.PrefixLabel( rcL, GUIUtility.GetControlID( FocusType.Passive ), content );
				EditorGUI.LabelField( rcL, EditorHelper.TempContent( name, icon ), HEditorStyles.folderField );
			}

			if( IconButton( position.AlignR( 16 ), EditorIcon.folder, 1 ) ) {
				// new string[] { "Image files", "png,jpg,jpeg", "All files", "*" }
				var path2 = EditorUtility.OpenFilePanelWithFilters( "Select File", "", filters );
				if( !path2.IsEmpty() && path != path2 ) {
					path = path2;
					GUI.changed = true;
				}
				//throw new ExitGUIException();
			}
			HEditorGUI.lastRect = rcL;

			return path;
		}

		#endregion



		#region FolderFiled

		public static string FolderFiled( Rect position, string path ) {
			return FolderFiled( position, null, path );
		}

		public static string FolderFiled( Rect position, GUIContent content, string path ) {
			var name = path.IsEmpty() ? "None (Folder)" : path;
			var rcL = position;
			rcL.width -= 18;

			var icon = EditorIcon.folder;

			if( content == null ) {
				EditorGUI.LabelField( rcL, GUIContent.none, EditorHelper.TempContent( name, icon ), HEditorStyles.folderField );
			}
			else {
				rcL = EditorGUI.PrefixLabel( rcL, GUIUtility.GetControlID( FocusType.Passive ), content );
				EditorGUI.LabelField( rcL, EditorHelper.TempContent( name, icon ), HEditorStyles.folderField );
			}
			if( IconButton( position.AlignR( 16 ), EditorIcon.folder, 1 ) ) {
				var path2 = EditorUtility.OpenFolderPanel( "Select Folder", "", "" );
				if( !path2.IsEmpty() && path != path2 ) {
					path = path2;
					GUI.changed = true;
				}
			}
			HEditorGUI.lastRect = rcL;

			return path;
		}

		#endregion



		#region ImageButton

		public static bool ImageButton( Rect position, Texture2D image ) {
			return ImageButton( position, image, string.Empty );
		}
		public static bool ImageButton( Rect position, Texture2D image, string tooltip ) {
			return ImageButton( position, EditorHelper.TempContent( image, tooltip ), HEditorStyles.imageButton );
		}
		public static bool ImageButton( Rect position, GUIContent content, GUIStyle style ) {
			bool result = false;
			//position.y += heighOffset;
			if( EditorHelper.HasMouseClick( position ) ) {
				Event.current.Use();
				result = true;
			}
			GUI.Button( position, content, style );
			return result;
		}

		#endregion



		#region IconButton

		public static bool IconButton( Rect position, Texture2D image, float heighOffset = 0 ) {
			return IconButton( position, image, string.Empty, heighOffset );
		}
		public static bool IconButton( Rect position, Texture2D image, string tooltip, float heighOffset = 0 ) {
			return IconButton( position, EditorHelper.TempContent( image, tooltip ), HEditorStyles.iconButton, heighOffset );
		}
		public static bool IconButton( Rect position, GUIContent content, GUIStyle style, float heighOffset = 0 ) {
			bool result = false;
			position.y += heighOffset;
			HEditorGUI.lastRect = position;
			//if( EditorHelper.HasMouseClick( position ) ) {
			//	//Event.current.Use();
			//	result = true;
			//}
			//else if( EditorHelper.HasMouseClick( position, EventMouseButton.R ) ) {
			//	//Event.current.Use();
			//	result = true;
			//}

			// ドッキングボタンの対応
			// MouseUpでボタン押したことにする
			GUI.changed = false;
			result = GUI.Button( position, content, style );
			GUI.changed = result;
			return result;
		}

		#endregion



		#region FlatButton
		public static bool FlatButton( Rect position, string text ) {
			return FlatButton( position, text.content(), HEditorStyles.flatButton );
		}

		public static bool FlatButton( Rect position, string text, GUIStyle style ) {
			return FlatButton( position, text.content(), style );
		}

		public static bool FlatButton( Rect position, GUIContent content, GUIStyle style ) {
			bool result = false;
			//EditorGUI.DrawRect( position, ColorUtils.RGBA( 149, 149, 149, 119 ) );
			result = GUI.Button( position, content, style );
			GUI.changed = result;
			return result;
		}
		#endregion

		public static bool ClickableIcon( Rect position, Texture2D image ) {

			return ClickableIcon( position, image, GUI.enabled ? 1.00f : 0.4f );
		}
		public static bool ClickableIcon( Rect position, Texture2D image, float alpha = 1.0f ) {
			bool result = false;
			HEditorGUI.lastRect = position;

			GUI.DrawTexture( position, image, ScaleMode.StretchToFill, true, 0, new Color( 1, 1, 1, alpha ), 0, 0 );
			if( EditorHelper.HasMouseClick( position ) ) {
				result = true;
			}
			return result;
		}



		#region DropDown

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

			var rr = lastRect.AlignCenter( 12, 12 );
			//rr.y -= 1;
			GUI.DrawTexture( rr, SharedModule.Icon.icondropdown_, ScaleMode.ScaleToFit );
			//EditorGUI.DrawRect( lastRect, new Color( 0, 0, 1, 0.5f ) );
			return false;
		}

		#endregion



		#region ObjectFieldAndAction<T>

		public static T ObjectFieldAndAction<T>( Rect position, string label, SerializedProperty obj, Action<SerializedProperty> addButton = null, bool allowSceneObjects = false ) where T : UnityObject {
			try {
				if( label.IsEmpty() ) {
					var r = position;
					if( addButton != null ) {
						r.width -= 16;
						var rr = position.AlignR( 16 );
						if( HEditorGUI.IconButton( rr, EditorIcon.plus ) ) {
							addButton.Invoke( obj );
						}
					}
					return (T) EditorGUI.ObjectField( r, obj.objectReferenceValue, typeof( T ), allowSceneObjects );
				}
				return (T) EditorGUI.ObjectField( position, EditorHelper.TempContent( label ), obj.objectReferenceValue, typeof( T ), allowSceneObjects );
			}
			catch( ExitGUIException ) {
			}
			return (T) obj.objectReferenceValue;
		}

		public static T ObjectFieldAndAction<T>( Rect position, SerializedProperty obj, Action<SerializedProperty> addButton = null, bool allowSceneObjects = false ) where T : UnityObject {
			return ObjectFieldAndAction<T>( position, null, obj, addButton, allowSceneObjects );
		}

		public static T ObjectField<T>( Rect position, string label, T obj, bool allowSceneObjects = false ) where T : UnityObject {
			return ObjectField<T>( position, EditorHelper.TempContent( label ), obj, allowSceneObjects );
		}

		public static T ObjectField<T>( Rect position, GUIContent content, T obj, bool allowSceneObjects = false ) where T : UnityObject {
			try {
				if( content.text.IsEmpty() ) {
					return (T) EditorGUI.ObjectField( position, obj, typeof( T ), allowSceneObjects );
				}
				return (T) EditorGUI.ObjectField( position, content, obj, typeof( T ), allowSceneObjects );
			}
			catch( ExitGUIException ) {
			}
			return (T) obj;
		}

		public static T ObjectField<T>( Rect position, T obj, bool allowSceneObjects = false ) where T : UnityObject {
			return ObjectField<T>( position, string.Empty, obj, allowSceneObjects );
		}

		#endregion



		#region GUIDObjectField<T>

		public static string GUIDObjectField<T>( Rect position, string guid, bool safeCheck = true ) where T : UnityObject {
			T value = null;
			var path = AssetDatabase.GUIDToAssetPath( guid );
			if( !path.IsEmpty() ) {
				value = AssetDatabase.LoadAssetAtPath<T>( path );
			}
			using( new GUIBackgroundColorScope() ) {
				if( safeCheck && value == null ) {
					GUI.backgroundColor = HEditorStyles.fieldInvalidColor;
				}

				if( value == null && !guid.IsEmpty() ) {
					var sz = guid.CalcSize( EditorStyles.miniLabel );
					EditorGUI.DrawRect( position.W( sz.x ).AlignCenterH( sz.y ), HEditorStyles.fieldInvalidColor );
					HEditorGUI.MiniLabel( position, guid );
					//HEditorGUI.MiniLabelR( position, guid );
					value = ObjectField<T>( position.AlignR( 32 ), value );
				}
				else {
					value = ObjectField<T>( position, value );
				}
				if( value == null ) return guid;
			}

			return AssetDatabase.AssetPathToGUID( AssetDatabase.GetAssetPath( value ) );
		}

		public static string GUIDObjectField<T>( Rect position, GUIContent content, string guid, bool safeCheck = true ) where T : UnityObject {
			T value = null;
			var path = AssetDatabase.GUIDToAssetPath( guid );
			if( !path.IsEmpty() ) {
				value = AssetDatabase.LoadAssetAtPath<T>( path );
			}

			using( new GUIBackgroundColorScope() ) {
				if( safeCheck && value == null ) {
					GUI.backgroundColor = HEditorStyles.fieldInvalidColor;
				}

				if( value == null && !guid.IsEmpty() ) {
					var sz = guid.CalcSize( EditorStyles.miniLabel );
					EditorGUI.DrawRect( position.W( sz.x ).AlignCenterH( sz.y ), HEditorStyles.fieldInvalidColor );
					HEditorGUI.MiniLabel( position, guid );
					//HEditorGUI.MiniLabelR( position, guid );
					value = ObjectField<T>( position.AlignR( 32 ), content, value );
				}
				else {
					value = ObjectField<T>( position, content, value );
				}
				if( value == null ) return string.Empty;
			}

			return AssetDatabase.AssetPathToGUID( AssetDatabase.GetAssetPath( value ) );
		}


		#endregion

	}
}
