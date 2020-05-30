#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace Hananoki {
	public static class HEditorStyles {

		static GUIStyle s_folderField;
		public static GUIStyle folderField {
			get {
				if( s_folderField == null ) {
					s_folderField = new GUIStyle( EditorStyles.textField );
					s_folderField.alignment = TextAnchor.MiddleLeft;
					s_folderField.imagePosition = ImagePosition.ImageLeft;
					s_folderField.fixedHeight = 18;
					//s_folderField.margin = new RectOffset( 0, 0, 0, 0 );
					//s_folderField.padding = new RectOffset( 0, 0, 0, 0 );
				}
				return s_folderField;
			}
		}

		static GUIStyle s_treeViweArea;
		public static GUIStyle treeViweArea {
			get {
				if( s_treeViweArea == null ) {
					s_treeViweArea = new GUIStyle( GUI.skin.box );
					s_treeViweArea.margin = new RectOffset( 0, 0, 0, 0 );
					s_treeViweArea.padding = new RectOffset( 0, 0, 0, 0 );
				}
				return s_treeViweArea;
			}
		}


		static GUIStyle s_ImageButton;
		public static GUIStyle imageButton {
			get {
				if( s_ImageButton == null ) {
					s_ImageButton = new GUIStyle( GUI.skin.button );
					//s_ImageButton.padding.left = 2;
					//s_ImageButton.padding.right = 2;
					s_ImageButton.padding = new RectOffset( 0, 0, 0, 0 );
				}
				return s_ImageButton;
			}
		}


		static GUIStyle s_IconButton;
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

		static GUIStyle s_FoldoutText;
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
}

#endif
