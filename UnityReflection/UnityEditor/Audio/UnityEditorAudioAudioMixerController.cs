/// UnityEditor.Audio.AudioMixerController : 2019.4.16f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorAudioAudioMixerController {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorAudioAudioMixerController( object instance ){
			m_instance = instance;
    }
    public UnityEditorAudioAudioMixerController() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_Audio_AudioMixerController, new object[] {} );
    }
    

		public object[] allGroups {
			get {
				if( __getter_allGroups == null ) {
					__getter_allGroups = (Func<object[]>) Delegate.CreateDelegate( typeof( Func<object[]> ), m_instance, UnityTypes.UnityEditor_Audio_AudioMixerController.GetMethod( "get_allGroups", R.InstanceMembers ) );
				}
				return __getter_allGroups();
			}
		}

		public object masterGroup {
			get {
				if( __getter_masterGroup == null ) {
					__getter_masterGroup = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), m_instance, UnityTypes.UnityEditor_Audio_AudioMixerController.GetMethod( "get_masterGroup", R.InstanceMembers ) );
				}
				return __getter_masterGroup();
			}
			set {
				if( __setter_masterGroup == null ) {
					__setter_masterGroup = (Action<object>) Delegate.CreateDelegate( typeof( Action<object> ), m_instance, UnityTypes.UnityEditor_Audio_AudioMixerController.GetMethod( "set_masterGroup", R.InstanceMembers ) );
			  }
				__setter_masterGroup( value );
			}
		}

		public static object CreateMixerControllerAtPath( string path ) {
			if( __CreateMixerControllerAtPath_0_1 == null ) {
				__CreateMixerControllerAtPath_0_1 = (Func<string, object>) Delegate.CreateDelegate( typeof( Func<string, object> ), null, UnityTypes.UnityEditor_Audio_AudioMixerController.GetMethod( "CreateMixerControllerAtPath", R.StaticMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			return __CreateMixerControllerAtPath_0_1( path );
		}
		
		
		
		Func<object[]> __getter_allGroups;
		Func<object> __getter_masterGroup;
		Action<object> __setter_masterGroup;
		static Func<string, object> __CreateMixerControllerAtPath_0_1;
	}
}

