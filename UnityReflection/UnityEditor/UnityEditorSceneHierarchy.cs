/// UnityEditor.SceneHierarchy : 2019.4.16f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorSceneHierarchy {
		public object m_instance;
    
    public UnityEditorSceneHierarchy( object instance ){
			m_instance = instance;
    }
    public UnityEditorSceneHierarchy() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_SceneHierarchy, new object[] {} );
    }
    

		public object treeView {
			get {
				if( __getter_treeView == null ) {
					__getter_treeView = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), m_instance, UnityTypes.UnityEditor_SceneHierarchy.GetMethod( "get_treeView", R.InstanceMembers ) );
				}
				return __getter_treeView();
			}
		}

		
		
		Func<object> __getter_treeView;
	}
}

