/// UnityEditor.SceneView : 2019.4.21f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorSceneView {
		public object m_instance;
    
    public UnityEditorSceneView( object instance ){
			m_instance = instance;
    }
    public UnityEditorSceneView() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_SceneView, new object[] {} );
    }
    

		//public object draggingLocked {
		//	get {
		//		if( __getter_draggingLocked == null ) {
		//			__getter_draggingLocked = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), m_instance, UnityTypes.UnityEditor_SceneView.GetMethod( "get_draggingLocked", R.InstanceMembers ) );
		//		}
		//		return __getter_draggingLocked();
		//	}
		//	set {
		//		if( __setter_draggingLocked == null ) {
		//			__setter_draggingLocked = (Action<object>) Delegate.CreateDelegate( typeof( Action<object> ), m_instance, UnityTypes.UnityEditor_SceneView.GetMethod( "set_draggingLocked", R.InstanceMembers ) );
		//	  }
		//		__setter_draggingLocked( value );
		//	}
		//}

		
		
		Func<object> __getter_draggingLocked;
		Action<object> __setter_draggingLocked;
	}
}

