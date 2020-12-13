/// UnityEditor.AudioUtil : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorAudioUtil {
    
		public static void PlayClip( UnityEngine.AudioClip clip, int startSample = 0, bool loop = false ) {
			if( __PlayClip_0_3 == null ) {
				__PlayClip_0_3 = (Action<UnityEngine.AudioClip,int,bool>) Delegate.CreateDelegate( typeof( Action<UnityEngine.AudioClip,int,bool> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "PlayClip", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ), typeof( int ), typeof( bool ) }, null ) );
			}
			__PlayClip_0_3( clip, startSample, loop );
		}
		
		public static void StopClip( UnityEngine.AudioClip clip ) {
			if( __StopClip_0_1 == null ) {
				__StopClip_0_1 = (Action<UnityEngine.AudioClip>) Delegate.CreateDelegate( typeof( Action<UnityEngine.AudioClip> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "StopClip", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			__StopClip_0_1( clip );
		}
		
		public static void PauseClip( UnityEngine.AudioClip clip ) {
			if( __PauseClip_0_1 == null ) {
				__PauseClip_0_1 = (Action<UnityEngine.AudioClip>) Delegate.CreateDelegate( typeof( Action<UnityEngine.AudioClip> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "PauseClip", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			__PauseClip_0_1( clip );
		}
		
		public static void ResumeClip( UnityEngine.AudioClip clip ) {
			if( __ResumeClip_0_1 == null ) {
				__ResumeClip_0_1 = (Action<UnityEngine.AudioClip>) Delegate.CreateDelegate( typeof( Action<UnityEngine.AudioClip> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "ResumeClip", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			__ResumeClip_0_1( clip );
		}
		
		public static void LoopClip( UnityEngine.AudioClip clip, bool on ) {
			if( __LoopClip_0_2 == null ) {
				__LoopClip_0_2 = (Action<UnityEngine.AudioClip,bool>) Delegate.CreateDelegate( typeof( Action<UnityEngine.AudioClip,bool> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "LoopClip", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ), typeof( bool ) }, null ) );
			}
			__LoopClip_0_2( clip, on );
		}
		
		public static bool IsClipPlaying( UnityEngine.AudioClip clip ) {
			if( __IsClipPlaying_0_1 == null ) {
				__IsClipPlaying_0_1 = (Func<UnityEngine.AudioClip, bool>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, bool> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "IsClipPlaying", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __IsClipPlaying_0_1( clip );
		}
		
		public static void StopAllClips() {
			if( __StopAllClips_0_0 == null ) {
				__StopAllClips_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "StopAllClips", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			__StopAllClips_0_0(  );
		}
		
		public static float GetClipPosition( UnityEngine.AudioClip clip ) {
			if( __GetClipPosition_0_1 == null ) {
				__GetClipPosition_0_1 = (Func<UnityEngine.AudioClip, float>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, float> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetClipPosition", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __GetClipPosition_0_1( clip );
		}
		
		public static int GetClipSamplePosition( UnityEngine.AudioClip clip ) {
			if( __GetClipSamplePosition_0_1 == null ) {
				__GetClipSamplePosition_0_1 = (Func<UnityEngine.AudioClip, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, int> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetClipSamplePosition", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __GetClipSamplePosition_0_1( clip );
		}
		
		public static void SetClipSamplePosition( UnityEngine.AudioClip clip, int iSamplePosition ) {
			if( __SetClipSamplePosition_0_2 == null ) {
				__SetClipSamplePosition_0_2 = (Action<UnityEngine.AudioClip,int>) Delegate.CreateDelegate( typeof( Action<UnityEngine.AudioClip,int> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "SetClipSamplePosition", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ), typeof( int ) }, null ) );
			}
			__SetClipSamplePosition_0_2( clip, iSamplePosition );
		}
		
		public static int GetSampleCount( UnityEngine.AudioClip clip ) {
			if( __GetSampleCount_0_1 == null ) {
				__GetSampleCount_0_1 = (Func<UnityEngine.AudioClip, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, int> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetSampleCount", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __GetSampleCount_0_1( clip );
		}
		
		public static int GetChannelCount( UnityEngine.AudioClip clip ) {
			if( __GetChannelCount_0_1 == null ) {
				__GetChannelCount_0_1 = (Func<UnityEngine.AudioClip, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, int> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetChannelCount", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __GetChannelCount_0_1( clip );
		}
		
		public static int GetBitRate( UnityEngine.AudioClip clip ) {
			if( __GetBitRate_0_1 == null ) {
				__GetBitRate_0_1 = (Func<UnityEngine.AudioClip, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, int> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetBitRate", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __GetBitRate_0_1( clip );
		}
		
		public static int GetBitsPerSample( UnityEngine.AudioClip clip ) {
			if( __GetBitsPerSample_0_1 == null ) {
				__GetBitsPerSample_0_1 = (Func<UnityEngine.AudioClip, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, int> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetBitsPerSample", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __GetBitsPerSample_0_1( clip );
		}
		
		public static int GetFrequency( UnityEngine.AudioClip clip ) {
			if( __GetFrequency_0_1 == null ) {
				__GetFrequency_0_1 = (Func<UnityEngine.AudioClip, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, int> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetFrequency", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __GetFrequency_0_1( clip );
		}
		
		public static int GetSoundSize( UnityEngine.AudioClip clip ) {
			if( __GetSoundSize_0_1 == null ) {
				__GetSoundSize_0_1 = (Func<UnityEngine.AudioClip, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, int> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetSoundSize", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __GetSoundSize_0_1( clip );
		}
		
		public static UnityEngine.AudioCompressionFormat GetSoundCompressionFormat( UnityEngine.AudioClip clip ) {
			if( __GetSoundCompressionFormat_0_1 == null ) {
				__GetSoundCompressionFormat_0_1 = (Func<UnityEngine.AudioClip, UnityEngine.AudioCompressionFormat>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, UnityEngine.AudioCompressionFormat> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetSoundCompressionFormat", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __GetSoundCompressionFormat_0_1( clip );
		}
		
		public static UnityEngine.AudioCompressionFormat GetTargetPlatformSoundCompressionFormat( UnityEngine.AudioClip clip ) {
			if( __GetTargetPlatformSoundCompressionFormat_0_1 == null ) {
				__GetTargetPlatformSoundCompressionFormat_0_1 = (Func<UnityEngine.AudioClip, UnityEngine.AudioCompressionFormat>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, UnityEngine.AudioCompressionFormat> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetTargetPlatformSoundCompressionFormat", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __GetTargetPlatformSoundCompressionFormat_0_1( clip );
		}
		
		public static string[] GetAmbisonicDecoderPluginNames() {
			if( __GetAmbisonicDecoderPluginNames_0_0 == null ) {
				__GetAmbisonicDecoderPluginNames_0_0 = (Func<string[]>) Delegate.CreateDelegate( typeof( Func<string[]> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetAmbisonicDecoderPluginNames", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetAmbisonicDecoderPluginNames_0_0(  );
		}
		
		public static bool HasPreview( UnityEngine.AudioClip clip ) {
			if( __HasPreview_0_1 == null ) {
				__HasPreview_0_1 = (Func<UnityEngine.AudioClip, bool>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, bool> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "HasPreview", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __HasPreview_0_1( clip );
		}
		
		public static UnityEditor.AudioImporter GetImporterFromClip( UnityEngine.AudioClip clip ) {
			if( __GetImporterFromClip_0_1 == null ) {
				__GetImporterFromClip_0_1 = (Func<UnityEngine.AudioClip, UnityEditor.AudioImporter>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, UnityEditor.AudioImporter> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetImporterFromClip", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __GetImporterFromClip_0_1( clip );
		}
		
		public static float[] GetMinMaxData( UnityEditor.AudioImporter importer ) {
			if( __GetMinMaxData_0_1 == null ) {
				__GetMinMaxData_0_1 = (Func<UnityEditor.AudioImporter, float[]>) Delegate.CreateDelegate( typeof( Func<UnityEditor.AudioImporter, float[]> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetMinMaxData", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.AudioImporter ) }, null ) );
			}
			return __GetMinMaxData_0_1( importer );
		}
		
		public static double GetDuration( UnityEngine.AudioClip clip ) {
			if( __GetDuration_0_1 == null ) {
				__GetDuration_0_1 = (Func<UnityEngine.AudioClip, double>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, double> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetDuration", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __GetDuration_0_1( clip );
		}
		
		public static int GetFMODMemoryAllocated() {
			if( __GetFMODMemoryAllocated_0_0 == null ) {
				__GetFMODMemoryAllocated_0_0 = (Func<int>) Delegate.CreateDelegate( typeof( Func<int> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetFMODMemoryAllocated", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetFMODMemoryAllocated_0_0(  );
		}
		
		public static float GetFMODCPUUsage() {
			if( __GetFMODCPUUsage_0_0 == null ) {
				__GetFMODCPUUsage_0_0 = (Func<float>) Delegate.CreateDelegate( typeof( Func<float> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetFMODCPUUsage", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetFMODCPUUsage_0_0(  );
		}
		
		public static bool IsTrackerFile( UnityEngine.AudioClip clip ) {
			if( __IsTrackerFile_0_1 == null ) {
				__IsTrackerFile_0_1 = (Func<UnityEngine.AudioClip, bool>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, bool> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "IsTrackerFile", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __IsTrackerFile_0_1( clip );
		}
		
		public static int GetMusicChannelCount( UnityEngine.AudioClip clip ) {
			if( __GetMusicChannelCount_0_1 == null ) {
				__GetMusicChannelCount_0_1 = (Func<UnityEngine.AudioClip, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioClip, int> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetMusicChannelCount", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioClip ) }, null ) );
			}
			return __GetMusicChannelCount_0_1( clip );
		}
		
		public static UnityEngine.AnimationCurve GetLowpassCurve( UnityEngine.AudioLowPassFilter lowPassFilter ) {
			if( __GetLowpassCurve_0_1 == null ) {
				__GetLowpassCurve_0_1 = (Func<UnityEngine.AudioLowPassFilter, UnityEngine.AnimationCurve>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AudioLowPassFilter, UnityEngine.AnimationCurve> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetLowpassCurve", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.AudioLowPassFilter ) }, null ) );
			}
			return __GetLowpassCurve_0_1( lowPassFilter );
		}
		
		public static UnityEngine.Vector3 GetListenerPos() {
			if( __GetListenerPos_0_0 == null ) {
				__GetListenerPos_0_0 = (Func<UnityEngine.Vector3>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Vector3> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "GetListenerPos", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetListenerPos_0_0(  );
		}
		
		public static void UpdateAudio() {
			if( __UpdateAudio_0_0 == null ) {
				__UpdateAudio_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "UpdateAudio", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			__UpdateAudio_0_0(  );
		}
		
		public static void SetListenerTransform( UnityEngine.Transform t ) {
			if( __SetListenerTransform_0_1 == null ) {
				__SetListenerTransform_0_1 = (Action<UnityEngine.Transform>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Transform> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "SetListenerTransform", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Transform ) }, null ) );
			}
			__SetListenerTransform_0_1( t );
		}
		
		public static bool HasAudioCallback( UnityEngine.MonoBehaviour behaviour ) {
			if( __HasAudioCallback_0_1 == null ) {
				__HasAudioCallback_0_1 = (Func<UnityEngine.MonoBehaviour, bool>) Delegate.CreateDelegate( typeof( Func<UnityEngine.MonoBehaviour, bool> ), null, UnityTypes.UnityEditor_AudioUtil.GetMethod( "HasAudioCallback", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.MonoBehaviour ) }, null ) );
			}
			return __HasAudioCallback_0_1( behaviour );
		}
		
		
		
		static Action<UnityEngine.AudioClip,int,bool> __PlayClip_0_3;
		static Action<UnityEngine.AudioClip> __StopClip_0_1;
		static Action<UnityEngine.AudioClip> __PauseClip_0_1;
		static Action<UnityEngine.AudioClip> __ResumeClip_0_1;
		static Action<UnityEngine.AudioClip,bool> __LoopClip_0_2;
		static Func<UnityEngine.AudioClip, bool> __IsClipPlaying_0_1;
		static Action __StopAllClips_0_0;
		static Func<UnityEngine.AudioClip, float> __GetClipPosition_0_1;
		static Func<UnityEngine.AudioClip, int> __GetClipSamplePosition_0_1;
		static Action<UnityEngine.AudioClip,int> __SetClipSamplePosition_0_2;
		static Func<UnityEngine.AudioClip, int> __GetSampleCount_0_1;
		static Func<UnityEngine.AudioClip, int> __GetChannelCount_0_1;
		static Func<UnityEngine.AudioClip, int> __GetBitRate_0_1;
		static Func<UnityEngine.AudioClip, int> __GetBitsPerSample_0_1;
		static Func<UnityEngine.AudioClip, int> __GetFrequency_0_1;
		static Func<UnityEngine.AudioClip, int> __GetSoundSize_0_1;
		static Func<UnityEngine.AudioClip, UnityEngine.AudioCompressionFormat> __GetSoundCompressionFormat_0_1;
		static Func<UnityEngine.AudioClip, UnityEngine.AudioCompressionFormat> __GetTargetPlatformSoundCompressionFormat_0_1;
		static Func<string[]> __GetAmbisonicDecoderPluginNames_0_0;
		static Func<UnityEngine.AudioClip, bool> __HasPreview_0_1;
		static Func<UnityEngine.AudioClip, UnityEditor.AudioImporter> __GetImporterFromClip_0_1;
		static Func<UnityEditor.AudioImporter, float[]> __GetMinMaxData_0_1;
		static Func<UnityEngine.AudioClip, double> __GetDuration_0_1;
		static Func<int> __GetFMODMemoryAllocated_0_0;
		static Func<float> __GetFMODCPUUsage_0_0;
		static Func<UnityEngine.AudioClip, bool> __IsTrackerFile_0_1;
		static Func<UnityEngine.AudioClip, int> __GetMusicChannelCount_0_1;
		static Func<UnityEngine.AudioLowPassFilter, UnityEngine.AnimationCurve> __GetLowpassCurve_0_1;
		static Func<UnityEngine.Vector3> __GetListenerPos_0_0;
		static Action __UpdateAudio_0_0;
		static Action<UnityEngine.Transform> __SetListenerTransform_0_1;
		static Func<UnityEngine.MonoBehaviour, bool> __HasAudioCallback_0_1;
	}
}

