/// UnityEditorInternal.AnimationWindowState : 2020.2.1f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorInternalAnimationWindowState {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorInternalAnimationWindowState( object instance ){
			m_instance = instance;
    }
    public UnityEditorInternalAnimationWindowState() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditorInternal_AnimationWindowState, new object[] {} );
    }
    

		public UnityEngine.AnimationClip activeAnimationClip {
			get {
				if( __getter_activeAnimationClip == null ) {
					__getter_activeAnimationClip = (Func<UnityEngine.AnimationClip>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AnimationClip> ), m_instance, UnityTypes.UnityEditorInternal_AnimationWindowState.GetMethod( "get_activeAnimationClip", R.InstanceMembers ) );
				}
				return __getter_activeAnimationClip();
			}
			set {
				if( __setter_activeAnimationClip == null ) {
					__setter_activeAnimationClip = (Action<UnityEngine.AnimationClip>) Delegate.CreateDelegate( typeof( Action<UnityEngine.AnimationClip> ), m_instance, UnityTypes.UnityEditorInternal_AnimationWindowState.GetMethod( "set_activeAnimationClip", R.InstanceMembers ) );
			  }
				__setter_activeAnimationClip( value );
			}
		}

		public UnityEngine.GameObject activeGameObject {
			get {
				if( __getter_activeGameObject == null ) {
					__getter_activeGameObject = (Func<UnityEngine.GameObject>) Delegate.CreateDelegate( typeof( Func<UnityEngine.GameObject> ), m_instance, UnityTypes.UnityEditorInternal_AnimationWindowState.GetMethod( "get_activeGameObject", R.InstanceMembers ) );
				}
				return __getter_activeGameObject();
			}
		}

		public float currentTime {
			get {
				if( __getter_currentTime == null ) {
					__getter_currentTime = (Func<float>) Delegate.CreateDelegate( typeof( Func<float> ), m_instance, UnityTypes.UnityEditorInternal_AnimationWindowState.GetMethod( "get_currentTime", R.InstanceMembers ) );
				}
				return __getter_currentTime();
			}
			set {
				if( __setter_currentTime == null ) {
					__setter_currentTime = (Action<float>) Delegate.CreateDelegate( typeof( Action<float> ), m_instance, UnityTypes.UnityEditorInternal_AnimationWindowState.GetMethod( "set_currentTime", R.InstanceMembers ) );
			  }
				__setter_currentTime( value );
			}
		}

		public bool previewing {
			get {
				if( __getter_previewing == null ) {
					__getter_previewing = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditorInternal_AnimationWindowState.GetMethod( "get_previewing", R.InstanceMembers ) );
				}
				return __getter_previewing();
			}
		}

		public bool playing {
			get {
				if( __getter_playing == null ) {
					__getter_playing = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditorInternal_AnimationWindowState.GetMethod( "get_playing", R.InstanceMembers ) );
				}
				return __getter_playing();
			}
		}

		public void StartPreview() {
			if( __StartPreview_0_0 == null ) {
				__StartPreview_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditorInternal_AnimationWindowState.GetMethod( "StartPreview", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__StartPreview_0_0();
		}
		
		public void StopPreview() {
			if( __StopPreview_0_0 == null ) {
				__StopPreview_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditorInternal_AnimationWindowState.GetMethod( "StopPreview", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__StopPreview_0_0();
		}
		
		public void StartPlayback() {
			if( __StartPlayback_0_0 == null ) {
				__StartPlayback_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditorInternal_AnimationWindowState.GetMethod( "StartPlayback", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__StartPlayback_0_0();
		}
		
		public void StopPlayback() {
			if( __StopPlayback_0_0 == null ) {
				__StopPlayback_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditorInternal_AnimationWindowState.GetMethod( "StopPlayback", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__StopPlayback_0_0();
		}
		
		
		
		Func<UnityEngine.AnimationClip> __getter_activeAnimationClip;
		Action<UnityEngine.AnimationClip> __setter_activeAnimationClip;
		Func<UnityEngine.GameObject> __getter_activeGameObject;
		Func<float> __getter_currentTime;
		Action<float> __setter_currentTime;
		Func<bool> __getter_previewing;
		Func<bool> __getter_playing;
		Action __StartPreview_0_0;
		Action __StopPreview_0_0;
		Action __StartPlayback_0_0;
		Action __StopPlayback_0_0;
	}
}

