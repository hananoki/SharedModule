#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace Hananoki {


	public static class HEditorStyles {

		static GUIStyle s_underLine;
		public static GUIStyle underLine {
			get {
				if( s_underLine != null ) return s_underLine;

				s_underLine = new GUIStyle();
				s_underLine.normal.background = Shared.Icon.Get( "under_line$" );
				s_underLine.stretchWidth = true;

				return s_underLine;
			}
		}

		static Color? s_fieldInvalidColor;
		public static Color fieldInvalidColor {
			get {
				if( s_fieldInvalidColor != null ) return s_fieldInvalidColor.Value;

				if( UnitySymbol.Has( "UNITY_2019_3_OR_NEWER" ) ) {
					s_fieldInvalidColor = new Color( 1, 0, 0, 0.10f );
				}
				else {
					s_fieldInvalidColor = new Color( 1, 0, 0, 0.15f );
				}

				return s_fieldInvalidColor.Value;
			}
		}


		static GUIStyle s_folderField;
		public static GUIStyle folderField {
			get {
				if( s_folderField != null ) return s_folderField;

				s_folderField = new GUIStyle( EditorStyles.label );
				s_folderField.alignment = TextAnchor.MiddleLeft;
				s_folderField.imagePosition = ImagePosition.ImageLeft;
				s_folderField.fixedHeight = 18;
				//s_folderField.margin = new RectOffset( 0, 0, 0, 0 );
				//s_folderField.padding = new RectOffset( 0, 0, 0, 0 );

				return s_folderField;
			}
		}


		static GUIStyle s_treeViweArea;
		public static GUIStyle treeViweArea {
			get {
				if( s_treeViweArea != null ) return s_treeViweArea;

				s_treeViweArea = new GUIStyle( GUI.skin.box );
				s_treeViweArea.margin = new RectOffset( 0, 0, 0, 0 );
				s_treeViweArea.padding = new RectOffset( 0, 0, 0, 0 );

				return s_treeViweArea;
			}
		}


		static GUIStyle s_ImageButton;
		public static GUIStyle imageButton {
			get {
				if( s_IconButton != null ) return s_IconButton;

				s_ImageButton = new GUIStyle( GUI.skin.button );
				//s_ImageButton.padding.left = 2;
				//s_ImageButton.padding.right = 2;
				s_ImageButton.padding = new RectOffset( 0, 0, 0, 0 );

				return s_ImageButton;
			}
		}


		static GUIStyle s_IconButton;
		public static GUIStyle iconButton {
			get {
				if( s_IconButton != null ) return s_IconButton;

				if( UnitySymbol.Has( "UNITY_2019_3_OR_NEWER" ) ) {
					s_IconButton = new GUIStyle( "IconButton" );
				}
				else {
					s_IconButton = new GUIStyle( "IconButton" );
					s_IconButton.fixedWidth = s_IconButton.fixedHeight = 16;
					s_IconButton.padding = new RectOffset( 0, 0, 0, 0 );
					s_IconButton.margin = new RectOffset( 0, 0, 0, 0 );
					s_IconButton.stretchWidth = false;
					s_IconButton.stretchHeight = false;
					//s_IconButton.focused.background = EditorGUIUtility.whiteTexture;
					//s_IconButton.hover.background = EditorGUIUtility.whiteTexture;
				}

				return s_IconButton;
			}
		}



		static GUIStyle s_FoldoutText;
		public static GUIStyle foldoutText {
			get {
				if( s_FoldoutText != null ) return s_FoldoutText;

				s_FoldoutText = new GUIStyle( "ExposablePopupItem" );
				s_FoldoutText.font = EditorStyles.boldLabel.font;
				s_FoldoutText.fontStyle = FontStyle.Bold;
				s_FoldoutText.margin = new RectOffset( 0, 0, 0, 0 );

				return s_FoldoutText;
			}
		}


		static GUIStyle s_DopesheetBackground;
		public static GUIStyle dopesheetBackground {
			get {
				if( s_DopesheetBackground != null ) {
					if( s_DopesheetBackground.normal.background != null ) {
						return s_DopesheetBackground;
					}
					s_DopesheetBackground = null;
				}

				s_DopesheetBackground = new GUIStyle( "DopesheetBackground" );
				if( !EditorGUIUtility.isProSkin ) {
					s_DopesheetBackground.normal.background = EditorIcon.dopesheetBackground;
				}
				return s_DopesheetBackground;
			}
		}


		static GUIStyle s_Popup;
		public static GUIStyle popup {
			get {
				if( s_Popup != null ) return s_Popup;

				if( UnitySymbol.Has( "UNITY_2019_3_OR_NEWER" ) ) {
					s_Popup = new GUIStyle( EditorStyles.popup );
				}
				else {
					s_Popup = new GUIStyle( "Popup" );
				}
				return s_Popup;
			}
		}


		static GUIStyle s_versionLabel;
		public static float vesionLabelSize = 12;
		public static float vesionMiniLabelSize = 10;

		public static GUIStyle versionLabel {
			get {
				if( s_versionLabel != null ) return s_versionLabel;

				s_versionLabel = new GUIStyle( EditorStyles.label );
				//s_versionLabel = new GUIStyle( EditorStyles.miniLabel );
				//Debug.Log( EditorStyles.miniLabel .padding.ToString());
				//s_versionLabel = new GUIStyle( EditorStyles.miniBoldLabel );
				//Debug.Log( EditorStyles.miniBoldLabel.padding.ToString() );
				s_versionLabel.alignment = TextAnchor.MiddleLeft;
				s_versionLabel.padding.top = 0;
				s_versionLabel.padding.bottom = 0;
				return s_versionLabel;
			}
		}
	}



	[System.Serializable]
	public class EditorColor {
		public Color lightskin;
		public Color darkskin;

		public EditorColor( Color lightskin, Color darkskin ) {
			this.lightskin = lightskin;
			this.darkskin = darkskin;
		}

		public static implicit operator Color( EditorColor c ) { return c.value; }

		public Color Inverse() {
			var c = value;
			return new Color( 1.0f - c.r, 1.0f - c.g, 1.0f - c.b );
		}

		public Color value {
			get {
				return EditorGUIUtility.isProSkin ? darkskin : lightskin;
			}
			set {
				if( EditorGUIUtility.isProSkin )
					darkskin = value;
				else
					lightskin = value;
			}
		}
	}


	[CustomPropertyDrawer( typeof( EditorColor ), true )]
	class EditorColorDrawer : PropertyDrawer {

		//public static EditorColor DrawGUILayout( GUIContent label, EditorColor color, params GUILayoutOption[] options ) {
		//	var rc = GUILayoutUtility.GetRect( label, EditorStyles.colorField, options );
		//	return DrawGUI( rc, label, color );
		//}

		//public static EditorColor DrawGUI( Rect rc, GUIContent label, EditorColor color ) {
		//	EditorGUI.ColorField( rc, color == null ? $"None (AnmEventParams)" : objectReference.name, EditorStyles.popup );
		//}

		public override void OnGUI( Rect rc, SerializedProperty property, GUIContent label ) {
			var proSkin = property.FindPropertyRelative( EditorGUIUtility.isProSkin ? "darkskin" : "lightskin" );

			EditorGUI.BeginChangeCheck();
			EditorGUI.PropertyField( rc, proSkin );
			if( EditorGUI.EndChangeCheck() ) {
				//property.intValue = i;
			}
		}
	}
}

#endif
