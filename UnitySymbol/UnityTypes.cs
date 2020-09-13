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
	}


	public static partial class UnityTypes {

		#region EditorWindow

		//static Type _SceneHierarchyWindow;

		//public static Type SceneHierarchyWindow {
		//	get {
		//		if( _SceneHierarchyWindow == null ) {
		//			_SceneHierarchyWindow = UnityAssembly.UnityEditor.GetType( "UnityEditor.SceneHierarchyWindow" );
		//		}
		//		return _SceneHierarchyWindow;
		//	}
		//}

		//static Type _ProjectBrowser;
		//public static Type ProjectBrowser {
		//	get {
		//		if( _ProjectBrowser == null ) {
		//			_ProjectBrowser = UnityAssembly.UnityEditor.GetType( "UnityEditor.ProjectBrowser" );
		//		}
		//		return _ProjectBrowser;
		//	}
		//}

		//static Type _LightingExplorerWindow;
		//public static Type LightingExplorerWindow {
		//	get {
		//		if( _LightingExplorerWindow == null ) {
		//			_LightingExplorerWindow = UnityAssembly.UnityEditor.GetType( "UnityEditor.LightingExplorerWindow" );
		//		}
		//		return _LightingExplorerWindow;
		//	}
		//}

		//static Type _AnimationWindow;
		//public static Type AnimationWindow {
		//	get {
		//		if( _AnimationWindow == null ) {
		//			_AnimationWindow = UnityAssembly.UnityEditor.GetType( "UnityEditor.AnimationWindow" );
		//		}
		//		return _AnimationWindow;
		//	}
		//}

		//static Type _AnimatorControllerTool;
		//public static Type AnimatorControllerTool {
		//	get {
		//		if( _AnimatorControllerTool == null ) {
		//			_AnimatorControllerTool = UnityAssembly.UnityEditorGraphs.GetType( "UnityEditor.Graphs.AnimatorControllerTool" );
		//		}
		//		return _AnimatorControllerTool;
		//	}
		//}



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



		static Type _UnityEditor_CreateAssetUtility;
		public static Type UnityEditor_CreateAssetUtility {
			get {
				if( _UnityEditor_CreateAssetUtility == null ) {
					_UnityEditor_CreateAssetUtility = UnityAssembly.UnityEditor.GetType( "UnityEditor.CreateAssetUtility" );
				}
				return _UnityEditor_CreateAssetUtility;
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
