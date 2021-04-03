/// UnityEditorInternal.AnimationWindowCurve : 2020.3.0f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorInternalAnimationWindowCurve {
		public object m_instance;
    
    public UnityEditorInternalAnimationWindowCurve( object instance ){
			m_instance = instance;
    }
    public UnityEditorInternalAnimationWindowCurve( UnityEngine.AnimationClip clip, UnityEditor.EditorCurveBinding binding, System.Type valueType ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditorInternal_AnimationWindowCurve, new object[] { clip, binding, valueType } );
    }
    

		public UnityEditor.EditorCurveBinding binding {
			get {
				if( __getter_binding == null ) {
					__getter_binding = (Func<UnityEditor.EditorCurveBinding>) Delegate.CreateDelegate( typeof( Func<UnityEditor.EditorCurveBinding> ), m_instance, UnityTypes.UnityEditorInternal_AnimationWindowCurve.GetMethod( "get_binding", R.InstanceMembers ) );
				}
				return __getter_binding();
			}
		}

		
		
		Func<UnityEditor.EditorCurveBinding> __getter_binding;
	}
}

