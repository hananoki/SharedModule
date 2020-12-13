/// UnityEditor.SceneHierarchyWindow : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorSceneHierarchyWindow {
		public object m_instance;
    
    public UnityEditorSceneHierarchyWindow( object instance ){
			m_instance = instance;
    }
    public UnityEditorSceneHierarchyWindow() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_SceneHierarchyWindow, new object[] {} );
    }
    
    
		public void SetSearchFilter( string searchFilter, UnityEditor.SearchableEditorWindow.SearchMode searchMode, bool setAll, bool delayed = false ) {
			if( __SetSearchFilter_0_4 == null ) {
				__SetSearchFilter_0_4 = (Action<string,UnityEditor.SearchableEditorWindow.SearchMode,bool,bool>) Delegate.CreateDelegate( typeof( Action<string,UnityEditor.SearchableEditorWindow.SearchMode,bool,bool> ), m_instance, UnityTypes.UnityEditor_SceneHierarchyWindow.GetMethod( "SetSearchFilter", R.InstanceMembers, null, new Type[]{ typeof( string ), typeof( UnityEditor.SearchableEditorWindow.SearchMode ), typeof( bool ), typeof( bool ) }, null ) );
			}
			__SetSearchFilter_0_4( searchFilter, searchMode, setAll, delayed );
		}
		
		
		
		Action<string,UnityEditor.SearchableEditorWindow.SearchMode,bool,bool> __SetSearchFilter_0_4;
	}
}

