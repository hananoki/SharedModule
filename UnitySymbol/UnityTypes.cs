using System;
using System.Reflection;
using UnityEngine;

namespace Hananoki {
	public static class UnityAssembly {
		public static Assembly GetAssembly( string name ) {
			return Assembly.Load( name );
		}

		public static Assembly UnityEngine => Assembly.Load( "UnityEngine.dll" );
		public static Assembly UnityEditor => Assembly.Load( "UnityEditor.dll" );
		public static Assembly UnityEditorGraphs => Assembly.Load( "UnityEditor.Graphs.dll" );

		public static Assembly Unity2DTilemapEditor => Assembly.Load( "Unity.2D.Tilemap.Editor" );
		public static Assembly UnityTimelineEditor => Assembly.Load( "Unity.Timeline.Editor" );
		public static Assembly UnityEditorTimeline => Assembly.Load( "UnityEditor.Timeline.dll" );
		public static Assembly UnityTextMeshPro => Assembly.Load( "Unity.TextMeshPro" );
	}


	public static partial class UnityTypes {

		static Type _UnityEditor_CreateAssetUtility;


		#region EditorWindow

		static Type _TimelineWindow;
		public static Type TimelineWindow {
			get {
				if( _TimelineWindow == null ) {
					if( UnitySymbol.UNITY_2019_1_OR_NEWER ) {
						var asm = UnityAssembly.UnityTimelineEditor;
						if( asm == null ) {
							Debug.LogWarning( "Timeline is not installed." );
							return null;
						}
						_TimelineWindow = asm.GetType( "UnityEditor.Timeline.TimelineWindow" );
					}
					else {
						_TimelineWindow = UnityAssembly.UnityEditorTimeline.GetType( "UnityEditor.Timeline.TimelineWindow" );
					}
				}
				return _TimelineWindow;
			}
		}

		static Type _GridPaintPaletteWindow;
		public static Type GridPaintPaletteWindow {
			get {
				if( _GridPaintPaletteWindow == null ) {
					if( UnitySymbol.UNITY_2019_2_OR_NEWER ) {
						_GridPaintPaletteWindow = Type.GetType( "UnityEditor.Tilemaps.GridPaintPaletteWindow, Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
					}
					else {
						_GridPaintPaletteWindow = Type.GetType( "UnityEditor.GridPaintPaletteWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
					}
				}
				return _GridPaintPaletteWindow;
			}
		}


		#endregion

		static Type _UnityEditor_Modules_ModuleManager;
		public static Type UnityEditor_Modules_ModuleManager {
			get {
				if( _UnityEditor_Modules_ModuleManager == null ) {
					_UnityEditor_Modules_ModuleManager = Type.GetType( "UnityEditor.Modules.ModuleManager, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _UnityEditor_Modules_ModuleManager;
			}
		}


		static Type _UnityEngine_SpriteRenderer;
		public static Type UnityEngine_SpriteRenderer {
			get {
				if( _UnityEngine_SpriteRenderer == null ) {
					_UnityEngine_SpriteRenderer = Type.GetType( "UnityEngine.SpriteRenderer, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _UnityEngine_SpriteRenderer;
			}
		}
		static Type _UnityEngine_UI_Image;
		public static Type UnityEngine_UI_Image {
			get {
				if( _UnityEngine_UI_Image == null ) {
					_UnityEngine_UI_Image = Type.GetType( "UnityEngine.UI.Image, UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _UnityEngine_UI_Image;
			}
		}
		static Type _UnityEngine_UI_RawImage;
		public static Type UnityEngine_UI_RawImage {
			get {
				if( _UnityEngine_UI_RawImage == null ) {
					_UnityEngine_UI_RawImage = Type.GetType( "UnityEngine.UI.RawImage, UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _UnityEngine_UI_RawImage;
			}
		}

		



		static Type _TMPro_TMP_Text;
		public static Type TMPro_TMP_Text {
			get {
				if( _TMPro_TMP_Text == null ) {
					_TMPro_TMP_Text = Type.GetType( "TMPro.TMP_Text, Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _TMPro_TMP_Text;
			}
		}
		static Type _TMPro_TextMeshProUGUI;
		public static Type TMPro_TextMeshProUGUI {
			get {
				if( _TMPro_TextMeshProUGUI == null ) {
					_TMPro_TextMeshProUGUI = Type.GetType( "TMPro.TextMeshProUGUI, Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _TMPro_TextMeshProUGUI;
			}
		}

		static Type _UnityEditor_SearchFilter;
		public static Type UnityEditor_SearchFilter {
			get {
				if( _UnityEditor_SearchFilter == null ) {
					_UnityEditor_SearchFilter = UnityAssembly.UnityEditor.GetType( "UnityEditor.SearchFilter" );
				}
				return _UnityEditor_SearchFilter;
			}
		}

		static Type _UnityEditor_ProjectWindowCallback_DoCreateFolder;
		public static Type UnityEditor_ProjectWindowCallback_DoCreateFolder {
			get {
				if( _UnityEditor_ProjectWindowCallback_DoCreateFolder == null ) {
					_UnityEditor_ProjectWindowCallback_DoCreateFolder = UnityAssembly.UnityEditor.GetType( "UnityEditor.ProjectWindowCallback.DoCreateFolder" );
				}
				return _UnityEditor_ProjectWindowCallback_DoCreateFolder;
			}
		}

		#region UIElements

		static Type _VisualElement;
		public static Type VisualElement {
			get {
				if( _VisualElement == null ) {
					if( UnitySymbol.UNITY_2019_1_OR_NEWER ) {
						_VisualElement = UnityAssembly.UnityEngine.GetType( "UnityEngine.UIElements.VisualElement" );
					}
					else {
						_VisualElement = UnityAssembly.UnityEngine.GetType( "UnityEngine.Experimental.UIElements.VisualElement" );
					}
				}
				return _VisualElement;
			}
		}

		static Type _IMGUIContainer;
		public static Type IMGUIContainer {
			get {
				if( _IMGUIContainer == null ) {
					if( UnitySymbol.UNITY_2019_1_OR_NEWER ) {
						_IMGUIContainer = UnityAssembly.UnityEngine.GetType( "UnityEngine.UIElements.IMGUIContainer" );
					}
					else {
						_IMGUIContainer = UnityAssembly.UnityEngine.GetType( "UnityEngine.Experimental.UIElements.IMGUIContainer" );
					}
				}
				return _IMGUIContainer;
			}
		}

		#endregion


	}


}
