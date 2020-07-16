
using UnityEditor;
using System.Reflection;
using System;

namespace Hananoki.UnityReflection {
	public static class USceneHierarchyWindow {

		public enum SearchMode {
			All,
			Name,
			Type,
			//Label,
			//AssetBundleName
		}

		static EditorWindow s_SceneHierarchyWindow;
		static EditorWindow SceneHierarchyWindow {
			get {
				if( s_SceneHierarchyWindow == null ) {
					s_SceneHierarchyWindow = EditorWindow.GetWindow( SceneHierarchyWindowType, false, "Hierarchy", false );
				}
				return s_SceneHierarchyWindow;
			}
		}

		static Type s_SceneHierarchyWindowType;
		static Type SceneHierarchyWindowType {
			get {
				if( s_SceneHierarchyWindowType == null ) {
					s_SceneHierarchyWindowType = Assembly.Load( "UnityEditor.dll" ).GetType( "UnityEditor.SceneHierarchyWindow" );
				}
				return s_SceneHierarchyWindowType;
			}
		}

		static MethodInfo s_SceneHierarchyWindowType_SetSearchFilter;
		static MethodInfo SceneHierarchyWindowType_SetSearchFilter {
			get {
				foreach( MethodInfo mi in SceneHierarchyWindowType.GetMethods( BindingFlags.NonPublic | BindingFlags.Instance ) ) {
					if( mi.Name == "SetSearchFilter" ) {
						var para = mi.GetParameters();
						if( para[ 0 ].Name == "searchFilter" ) {
							s_SceneHierarchyWindowType_SetSearchFilter = mi;
							break;
						}
					}
				}
				return s_SceneHierarchyWindowType_SetSearchFilter;
			}
		}



		public static EditorWindow GetWindow() {
			return SceneHierarchyWindow;
		}


		public static void SetSearchFilter( string searchFilter, SearchMode mode = SearchMode.All, bool setAll = false ) {
			if( UnitySymbol.Has( "UNITY_2018_1_OR_NEWER" ) ) {
				SceneHierarchyWindowType_SetSearchFilter.Invoke( SceneHierarchyWindow, new object[] { searchFilter, (int) mode, setAll, false } );
			}
			else {
				SceneHierarchyWindowType_SetSearchFilter.Invoke( SceneHierarchyWindow, new object[] { searchFilter, (int) mode, setAll } );
			}
		}
	}
}
