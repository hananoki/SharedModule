/// UnityEditor.Audio.AudioMixerController : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorAudioAudioMixerController {
		public object m_instance;
    
    public UnityEditorAudioAudioMixerController( object instance ){
			m_instance = instance;
    }
    public UnityEditorAudioAudioMixerController() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_Audio_AudioMixerController, new object[] {} );
    }
    

		public object[] allGroups {
			get {
				if( __allGroups == null ) {
					__allGroups = (Func<object[]>) Delegate.CreateDelegate( typeof( Func<object[]> ), m_instance, UnityTypes.UnityEditor_Audio_AudioMixerController.GetMethod( "get_allGroups", R.InstanceMembers ) );
				}
				return __allGroups();
			}
		}

		public object masterGroup {
			get {
				if( __masterGroup == null ) {
					__masterGroup = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), m_instance, UnityTypes.UnityEditor_Audio_AudioMixerController.GetMethod( "get_masterGroup", R.InstanceMembers ) );
				}
				return __masterGroup();
			}
		}

		
		
		Func<object[]> __allGroups;
		Func<object> __masterGroup;
	}
}

