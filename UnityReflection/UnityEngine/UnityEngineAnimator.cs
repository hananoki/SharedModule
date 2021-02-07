/// UnityEngine.Animator : 2020.2.1f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEngineAnimator {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEngineAnimator( object instance ){
			m_instance = instance;
    }
    public UnityEngineAnimator() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEngine_Animator, new object[] {} );
    }
    

		public string GetStats() {
			if( __GetStats_0_0 == null ) {
				__GetStats_0_0 = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), m_instance, UnityTypes.UnityEngine_Animator.GetMethod( "GetStats", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __GetStats_0_0();
		}
		
		
		
		Func<string> __GetStats_0_0;
	}
}

