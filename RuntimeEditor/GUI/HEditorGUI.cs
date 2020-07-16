
using Hananoki.Extensions;
using System;
using UnityEditor;
using UnityEngine;

using UnityObject = UnityEngine.Object;

namespace Hananoki {

	public static class HEditorGUI {
		public static Rect lastRect;


		#region HeaderTitle

		static void DrawLiine( Rect rc ) {
			using( new GUIColorScope() ) {
				if( EditorGUIUtility.isProSkin )
					GUI.color = ColorUtils.RGB( 176 );
				else
					GUI.color = ColorUtils.RGB( 77 );
				GUI.Box( rc, "", HEditorStyles.underLine );
			}
		}


		public static void HeaderTitle( Rect position, string title ) {
			try {
				position.height = 18;
				position.y += 4;
				EditorGUI.LabelField( position, title, EditorStyles.boldLabel );
				DrawLiine( position );
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
		public static string FileFiled( Rect position, GUIContent content, string path, string[] filters ) {
			var name = path.IsEmpty() ? "None (File)" : path;
			var rcL = position;
			rcL.width -= 18;

			if( content == null ) {
				EditorGUI.LabelField( rcL, GUIContent.none, EditorHelper.TempContent( name ), HEditorStyles.folderField );
			}
			else {
				rcL = EditorGUI.PrefixLabel( rcL, GUIUtility.GetControlID( FocusType.Passive ), content );
				EditorGUI.LabelField( rcL, EditorHelper.TempContent( name ), HEditorStyles.folderField );
			}
			if( IconButton( position.AlignR( 16 ), EditorIcon.folder, 1 ) ) {
				// new string[] { "Image files", "png,jpg,jpeg", "All files", "*" }
				path = EditorUtility.OpenFilePanelWithFilters( "Select File", "", filters );
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

			if( content == null ) {
				EditorGUI.LabelField( rcL, GUIContent.none, EditorHelper.TempContent( name ), HEditorStyles.folderField );
			}
			else {
				rcL = EditorGUI.PrefixLabel( rcL, GUIUtility.GetControlID( FocusType.Passive ), content );
				EditorGUI.LabelField( rcL, EditorHelper.TempContent( name ), HEditorStyles.folderField );
			}
			if( IconButton( position.AlignR( 16 ), EditorIcon.folder, 1 ) ) {
				path = EditorUtility.OpenFolderPanel( "Select Folder", "", "" );
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
			if( EditorHelper.HasMouseClick( position ) ) {
				//Event.current.Use();
				result = true;
			}

			GUI.Button( position, content, style );
			return result;
		}

		#endregion



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
			GUI.DrawTexture( rr, Shared.Icon.Get( "icondropdown$" ), ScaleMode.ScaleToFit );
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


		public static T ObjectField<T>( Rect position, string label, UnityObject obj, bool allowSceneObjects = false ) where T : UnityObject {
			try {
				if( label.IsEmpty() ) {
					return (T) EditorGUI.ObjectField( position, obj, typeof( T ), allowSceneObjects );
				}
				return (T) EditorGUI.ObjectField( position, EditorHelper.TempContent( label ), obj, typeof( T ), allowSceneObjects );
			}
			catch( ExitGUIException ) {
			}
			return (T) obj;
		}

		public static T ObjectField<T>( Rect position, UnityObject obj, bool allowSceneObjects = false ) where T : UnityObject {
			return ObjectField<T>( position, null, obj, allowSceneObjects );
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
				value = ObjectField<T>( position, value );
				if( value == null ) return "";
			}

			return AssetDatabase.AssetPathToGUID( AssetDatabase.GetAssetPath( value ) );
		}

		#endregion

	}
}
