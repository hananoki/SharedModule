/// UnityEditor.AnimationWindow : 2020.3.0f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorAnimationWindow {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorAnimationWindow( object instance ){
			m_instance = instance;
    }
    public UnityEditorAnimationWindow() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_AnimationWindow, new object[] {} );
    }
    

		public object state {
			get {
				if( __getter_state == null ) {
					__getter_state = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), m_instance, UnityTypes.UnityEditor_AnimationWindow.GetMethod( "get_state", R.InstanceMembers ) );
				}
				return __getter_state();
			}
		}

		public void OnEnable() {
			if( __OnEnable_0_0 == null ) {
				__OnEnable_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_AnimationWindow.GetMethod( "OnEnable", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__OnEnable_0_0();
		}
		
		public void Repaint() {
			if( __Repaint_0_0 == null ) {
				__Repaint_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_AnimationWindow.GetMethod( "Repaint", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__Repaint_0_0();
		}
		
		
		
		Func<object> __getter_state;
		Action __OnEnable_0_0;
		Action __Repaint_0_0;
	}
}

