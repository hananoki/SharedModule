/// UnityEditor.SceneHierarchyWindow : 2019.4.16f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorSceneHierarchyWindow {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorSceneHierarchyWindow( object instance ){
			m_instance = instance;
    }
    public UnityEditorSceneHierarchyWindow() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_SceneHierarchyWindow, new object[] {} );
    }
    

		public static object s_LastInteractedHierarchy {
			get {
				if( __s_LastInteractedHierarchy == null ) {
					__s_LastInteractedHierarchy = UnityTypes.UnityEditor_SceneHierarchyWindow.GetField( "s_LastInteractedHierarchy", R.StaticMembers );
				}
				return (object) __s_LastInteractedHierarchy.GetValue( null );
			}
			set {
				if( __s_LastInteractedHierarchy == null ) {
					__s_LastInteractedHierarchy = UnityTypes.UnityEditor_SceneHierarchyWindow.GetField( "s_LastInteractedHierarchy", R.StaticMembers );
				}
				__s_LastInteractedHierarchy.SetValue( null, value );
			}
		}

		public string m_SearchFilter {
			get {
				if( __m_SearchFilter == null ) {
					__m_SearchFilter = UnityTypes.UnityEditor_SceneHierarchyWindow.GetField( "m_SearchFilter", R.InstanceMembers );
				}
				return (string) __m_SearchFilter.GetValue( m_instance );
			}
			set {
				if( __m_SearchFilter == null ) {
					__m_SearchFilter = UnityTypes.UnityEditor_SceneHierarchyWindow.GetField( "m_SearchFilter", R.InstanceMembers );
				}
				__m_SearchFilter.SetValue( m_instance, value );
			}
		}

		public object sceneHierarchy {
			get {
				if( __getter_sceneHierarchy == null ) {
					__getter_sceneHierarchy = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), m_instance, UnityTypes.UnityEditor_SceneHierarchyWindow.GetMethod( "get_sceneHierarchy", R.InstanceMembers ) );
				}
				return __getter_sceneHierarchy();
			}
		}

		public void SetSearchFilter( string searchFilter, UnityEditor.SearchableEditorWindow.SearchMode searchMode, bool setAll, bool delayed = false ) {
			if( __SetSearchFilter_0_4 == null ) {
				__SetSearchFilter_0_4 = (Action<string,UnityEditor.SearchableEditorWindow.SearchMode,bool,bool>) Delegate.CreateDelegate( typeof( Action<string,UnityEditor.SearchableEditorWindow.SearchMode,bool,bool> ), m_instance, UnityTypes.UnityEditor_SceneHierarchyWindow.GetMethod( "SetSearchFilter", R.InstanceMembers, null, new Type[]{ typeof( string ), typeof( UnityEditor.SearchableEditorWindow.SearchMode ), typeof( bool ), typeof( bool ) }, null ) );
			}
			__SetSearchFilter_0_4( searchFilter, searchMode, setAll, delayed );
		}
		
		
		
		static FieldInfo __s_LastInteractedHierarchy;
		FieldInfo __m_SearchFilter;
		Func<object> __getter_sceneHierarchy;
		Action<string,UnityEditor.SearchableEditorWindow.SearchMode,bool,bool> __SetSearchFilter_0_4;
	}
}

