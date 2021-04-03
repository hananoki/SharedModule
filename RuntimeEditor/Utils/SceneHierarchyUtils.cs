using HananokiRuntime;
using UnityEditor;
using UnityReflection;

namespace HananokiEditor {
	public class SceneHierarchyUtils {

		static UnityEditorSceneHierarchyWindow s_sceneHierarchyWindow;

		public static string searchFilter {
			get {
				if( !init() ) return string.Empty;

				return s_sceneHierarchyWindow.m_SearchFilter;
			}
		}

		static bool init() {

			if( s_sceneHierarchyWindow == null ) {
				s_sceneHierarchyWindow = new UnityEditorSceneHierarchyWindow( UnityEditorSceneHierarchyWindow.s_LastInteractedHierarchy );
			}
			if( Helper.IsNull( s_sceneHierarchyWindow.m_instance ) ) {
				s_sceneHierarchyWindow = null;
			}

			//if( UnitySymbol.Has( "UNITY_2018_1_OR_NEWER" ) ) {
			//	if( s_ProjectBrowser_isLocked == null ) {
			//		s_ProjectBrowser_isLocked = UnityTypes.UnityEditor_ProjectBrowser.GetProperty( "isLocked", BindingFlags.NonPublic | BindingFlags.Instance );
			//	}
			//}
			//else {
			//	if( s_ProjectBrowser_m_IsLocked == null ) {
			//		s_ProjectBrowser_m_IsLocked = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_IsLocked", BindingFlags.NonPublic | BindingFlags.Instance );
			//	}
			//}
			return s_sceneHierarchyWindow != null ? true : false;
		}


		public static void SetSearchFilter( string searchString ) {
			SetSearchFilter( searchString, SearchableEditorWindow.SearchMode.Type );
		}

		public static void SetSearchFilter( string searchString, SearchableEditorWindow.SearchMode mode ) {
			if( !init() ) return;

			s_sceneHierarchyWindow.SetSearchFilter( searchString, mode, true );
		}


	}
}
