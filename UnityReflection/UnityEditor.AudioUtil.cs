/// UnityEditor.AudioUtil : 2019.3.2f1

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public static class UnityAudioUtil {
    delegate void Method_PlayClip0( UnityEngine.AudioClip clip, int startSample = 0, bool loop = false );
    static Method_PlayClip0 __PlayClip0;
    public static void PlayClip( UnityEngine.AudioClip clip, int startSample = 0, bool loop = false ) {
      if( __PlayClip0 == null ) {
        __PlayClip0 = (Method_PlayClip0) Delegate.CreateDelegate( typeof( Method_PlayClip0 ), null, R.Method("PlayClip", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      __PlayClip0(  clip, startSample, loop  );
    }



    delegate void Method_StopClip0( UnityEngine.AudioClip clip );
    static Method_StopClip0 __StopClip0;
    public static void StopClip( UnityEngine.AudioClip clip ) {
      if( __StopClip0 == null ) {
        __StopClip0 = (Method_StopClip0) Delegate.CreateDelegate( typeof( Method_StopClip0 ), null, R.Method("StopClip", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      __StopClip0(  clip  );
    }



    delegate void Method_PauseClip0( UnityEngine.AudioClip clip );
    static Method_PauseClip0 __PauseClip0;
    public static void PauseClip( UnityEngine.AudioClip clip ) {
      if( __PauseClip0 == null ) {
        __PauseClip0 = (Method_PauseClip0) Delegate.CreateDelegate( typeof( Method_PauseClip0 ), null, R.Method("PauseClip", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      __PauseClip0(  clip  );
    }



    delegate void Method_ResumeClip0( UnityEngine.AudioClip clip );
    static Method_ResumeClip0 __ResumeClip0;
    public static void ResumeClip( UnityEngine.AudioClip clip ) {
      if( __ResumeClip0 == null ) {
        __ResumeClip0 = (Method_ResumeClip0) Delegate.CreateDelegate( typeof( Method_ResumeClip0 ), null, R.Method("ResumeClip", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      __ResumeClip0(  clip  );
    }



    delegate void Method_LoopClip0( UnityEngine.AudioClip clip, bool on );
    static Method_LoopClip0 __LoopClip0;
    public static void LoopClip( UnityEngine.AudioClip clip, bool on ) {
      if( __LoopClip0 == null ) {
        __LoopClip0 = (Method_LoopClip0) Delegate.CreateDelegate( typeof( Method_LoopClip0 ), null, R.Method("LoopClip", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      __LoopClip0(  clip, on  );
    }



    delegate bool Method_IsClipPlaying0( UnityEngine.AudioClip clip );
    static Method_IsClipPlaying0 __IsClipPlaying0;
    public static bool IsClipPlaying( UnityEngine.AudioClip clip ) {
      if( __IsClipPlaying0 == null ) {
        __IsClipPlaying0 = (Method_IsClipPlaying0) Delegate.CreateDelegate( typeof( Method_IsClipPlaying0 ), null, R.Method("IsClipPlaying", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __IsClipPlaying0(  clip  );
    }



    delegate void Method_StopAllClips0();
    static Method_StopAllClips0 __StopAllClips0;
    public static void StopAllClips() {
      if( __StopAllClips0 == null ) {
        __StopAllClips0 = (Method_StopAllClips0) Delegate.CreateDelegate( typeof( Method_StopAllClips0 ), null, R.Method("StopAllClips", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      __StopAllClips0(  );
    }



    delegate float Method_GetClipPosition0( UnityEngine.AudioClip clip );
    static Method_GetClipPosition0 __GetClipPosition0;
    public static float GetClipPosition( UnityEngine.AudioClip clip ) {
      if( __GetClipPosition0 == null ) {
        __GetClipPosition0 = (Method_GetClipPosition0) Delegate.CreateDelegate( typeof( Method_GetClipPosition0 ), null, R.Method("GetClipPosition", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetClipPosition0(  clip  );
    }



    delegate int Method_GetClipSamplePosition0( UnityEngine.AudioClip clip );
    static Method_GetClipSamplePosition0 __GetClipSamplePosition0;
    public static int GetClipSamplePosition( UnityEngine.AudioClip clip ) {
      if( __GetClipSamplePosition0 == null ) {
        __GetClipSamplePosition0 = (Method_GetClipSamplePosition0) Delegate.CreateDelegate( typeof( Method_GetClipSamplePosition0 ), null, R.Method("GetClipSamplePosition", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetClipSamplePosition0(  clip  );
    }



    delegate void Method_SetClipSamplePosition0( UnityEngine.AudioClip clip, int iSamplePosition );
    static Method_SetClipSamplePosition0 __SetClipSamplePosition0;
    public static void SetClipSamplePosition( UnityEngine.AudioClip clip, int iSamplePosition ) {
      if( __SetClipSamplePosition0 == null ) {
        __SetClipSamplePosition0 = (Method_SetClipSamplePosition0) Delegate.CreateDelegate( typeof( Method_SetClipSamplePosition0 ), null, R.Method("SetClipSamplePosition", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      __SetClipSamplePosition0(  clip, iSamplePosition  );
    }



    delegate int Method_GetSampleCount0( UnityEngine.AudioClip clip );
    static Method_GetSampleCount0 __GetSampleCount0;
    public static int GetSampleCount( UnityEngine.AudioClip clip ) {
      if( __GetSampleCount0 == null ) {
        __GetSampleCount0 = (Method_GetSampleCount0) Delegate.CreateDelegate( typeof( Method_GetSampleCount0 ), null, R.Method("GetSampleCount", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetSampleCount0(  clip  );
    }



    delegate int Method_GetChannelCount0( UnityEngine.AudioClip clip );
    static Method_GetChannelCount0 __GetChannelCount0;
    public static int GetChannelCount( UnityEngine.AudioClip clip ) {
      if( __GetChannelCount0 == null ) {
        __GetChannelCount0 = (Method_GetChannelCount0) Delegate.CreateDelegate( typeof( Method_GetChannelCount0 ), null, R.Method("GetChannelCount", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetChannelCount0(  clip  );
    }



    delegate int Method_GetBitRate0( UnityEngine.AudioClip clip );
    static Method_GetBitRate0 __GetBitRate0;
    public static int GetBitRate( UnityEngine.AudioClip clip ) {
      if( __GetBitRate0 == null ) {
        __GetBitRate0 = (Method_GetBitRate0) Delegate.CreateDelegate( typeof( Method_GetBitRate0 ), null, R.Method("GetBitRate", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetBitRate0(  clip  );
    }



    delegate int Method_GetBitsPerSample0( UnityEngine.AudioClip clip );
    static Method_GetBitsPerSample0 __GetBitsPerSample0;
    public static int GetBitsPerSample( UnityEngine.AudioClip clip ) {
      if( __GetBitsPerSample0 == null ) {
        __GetBitsPerSample0 = (Method_GetBitsPerSample0) Delegate.CreateDelegate( typeof( Method_GetBitsPerSample0 ), null, R.Method("GetBitsPerSample", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetBitsPerSample0(  clip  );
    }



    delegate int Method_GetFrequency0( UnityEngine.AudioClip clip );
    static Method_GetFrequency0 __GetFrequency0;
    public static int GetFrequency( UnityEngine.AudioClip clip ) {
      if( __GetFrequency0 == null ) {
        __GetFrequency0 = (Method_GetFrequency0) Delegate.CreateDelegate( typeof( Method_GetFrequency0 ), null, R.Method("GetFrequency", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetFrequency0(  clip  );
    }



    delegate int Method_GetSoundSize0( UnityEngine.AudioClip clip );
    static Method_GetSoundSize0 __GetSoundSize0;
    public static int GetSoundSize( UnityEngine.AudioClip clip ) {
      if( __GetSoundSize0 == null ) {
        __GetSoundSize0 = (Method_GetSoundSize0) Delegate.CreateDelegate( typeof( Method_GetSoundSize0 ), null, R.Method("GetSoundSize", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetSoundSize0(  clip  );
    }



    delegate UnityEngine.AudioCompressionFormat Method_GetSoundCompressionFormat0( UnityEngine.AudioClip clip );
    static Method_GetSoundCompressionFormat0 __GetSoundCompressionFormat0;
    public static UnityEngine.AudioCompressionFormat GetSoundCompressionFormat( UnityEngine.AudioClip clip ) {
      if( __GetSoundCompressionFormat0 == null ) {
        __GetSoundCompressionFormat0 = (Method_GetSoundCompressionFormat0) Delegate.CreateDelegate( typeof( Method_GetSoundCompressionFormat0 ), null, R.Method("GetSoundCompressionFormat", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetSoundCompressionFormat0(  clip  );
    }



    delegate UnityEngine.AudioCompressionFormat Method_GetTargetPlatformSoundCompressionFormat0( UnityEngine.AudioClip clip );
    static Method_GetTargetPlatformSoundCompressionFormat0 __GetTargetPlatformSoundCompressionFormat0;
    public static UnityEngine.AudioCompressionFormat GetTargetPlatformSoundCompressionFormat( UnityEngine.AudioClip clip ) {
      if( __GetTargetPlatformSoundCompressionFormat0 == null ) {
        __GetTargetPlatformSoundCompressionFormat0 = (Method_GetTargetPlatformSoundCompressionFormat0) Delegate.CreateDelegate( typeof( Method_GetTargetPlatformSoundCompressionFormat0 ), null, R.Method("GetTargetPlatformSoundCompressionFormat", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetTargetPlatformSoundCompressionFormat0(  clip  );
    }



    delegate string[] Method_GetAmbisonicDecoderPluginNames0();
    static Method_GetAmbisonicDecoderPluginNames0 __GetAmbisonicDecoderPluginNames0;
    public static string[] GetAmbisonicDecoderPluginNames() {
      if( __GetAmbisonicDecoderPluginNames0 == null ) {
        __GetAmbisonicDecoderPluginNames0 = (Method_GetAmbisonicDecoderPluginNames0) Delegate.CreateDelegate( typeof( Method_GetAmbisonicDecoderPluginNames0 ), null, R.Method("GetAmbisonicDecoderPluginNames", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetAmbisonicDecoderPluginNames0(  );
    }



    delegate bool Method_HasPreview0( UnityEngine.AudioClip clip );
    static Method_HasPreview0 __HasPreview0;
    public static bool HasPreview( UnityEngine.AudioClip clip ) {
      if( __HasPreview0 == null ) {
        __HasPreview0 = (Method_HasPreview0) Delegate.CreateDelegate( typeof( Method_HasPreview0 ), null, R.Method("HasPreview", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __HasPreview0(  clip  );
    }



    delegate UnityEditor.AudioImporter Method_GetImporterFromClip0( UnityEngine.AudioClip clip );
    static Method_GetImporterFromClip0 __GetImporterFromClip0;
    public static UnityEditor.AudioImporter GetImporterFromClip( UnityEngine.AudioClip clip ) {
      if( __GetImporterFromClip0 == null ) {
        __GetImporterFromClip0 = (Method_GetImporterFromClip0) Delegate.CreateDelegate( typeof( Method_GetImporterFromClip0 ), null, R.Method("GetImporterFromClip", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetImporterFromClip0(  clip  );
    }



    delegate float[] Method_GetMinMaxData0( UnityEditor.AudioImporter importer );
    static Method_GetMinMaxData0 __GetMinMaxData0;
    public static float[] GetMinMaxData( UnityEditor.AudioImporter importer ) {
      if( __GetMinMaxData0 == null ) {
        __GetMinMaxData0 = (Method_GetMinMaxData0) Delegate.CreateDelegate( typeof( Method_GetMinMaxData0 ), null, R.Method("GetMinMaxData", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetMinMaxData0(  importer  );
    }



    delegate System.Double Method_GetDuration0( UnityEngine.AudioClip clip );
    static Method_GetDuration0 __GetDuration0;
    public static System.Double GetDuration( UnityEngine.AudioClip clip ) {
      if( __GetDuration0 == null ) {
        __GetDuration0 = (Method_GetDuration0) Delegate.CreateDelegate( typeof( Method_GetDuration0 ), null, R.Method("GetDuration", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetDuration0(  clip  );
    }



    delegate int Method_GetFMODMemoryAllocated0();
    static Method_GetFMODMemoryAllocated0 __GetFMODMemoryAllocated0;
    public static int GetFMODMemoryAllocated() {
      if( __GetFMODMemoryAllocated0 == null ) {
        __GetFMODMemoryAllocated0 = (Method_GetFMODMemoryAllocated0) Delegate.CreateDelegate( typeof( Method_GetFMODMemoryAllocated0 ), null, R.Method("GetFMODMemoryAllocated", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetFMODMemoryAllocated0(  );
    }



    delegate float Method_GetFMODCPUUsage0();
    static Method_GetFMODCPUUsage0 __GetFMODCPUUsage0;
    public static float GetFMODCPUUsage() {
      if( __GetFMODCPUUsage0 == null ) {
        __GetFMODCPUUsage0 = (Method_GetFMODCPUUsage0) Delegate.CreateDelegate( typeof( Method_GetFMODCPUUsage0 ), null, R.Method("GetFMODCPUUsage", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetFMODCPUUsage0(  );
    }



    delegate bool Method_IsTrackerFile0( UnityEngine.AudioClip clip );
    static Method_IsTrackerFile0 __IsTrackerFile0;
    public static bool IsTrackerFile( UnityEngine.AudioClip clip ) {
      if( __IsTrackerFile0 == null ) {
        __IsTrackerFile0 = (Method_IsTrackerFile0) Delegate.CreateDelegate( typeof( Method_IsTrackerFile0 ), null, R.Method("IsTrackerFile", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __IsTrackerFile0(  clip  );
    }



    delegate int Method_GetMusicChannelCount0( UnityEngine.AudioClip clip );
    static Method_GetMusicChannelCount0 __GetMusicChannelCount0;
    public static int GetMusicChannelCount( UnityEngine.AudioClip clip ) {
      if( __GetMusicChannelCount0 == null ) {
        __GetMusicChannelCount0 = (Method_GetMusicChannelCount0) Delegate.CreateDelegate( typeof( Method_GetMusicChannelCount0 ), null, R.Method("GetMusicChannelCount", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetMusicChannelCount0(  clip  );
    }



    delegate UnityEngine.AnimationCurve Method_GetLowpassCurve0( UnityEngine.AudioLowPassFilter lowPassFilter );
    static Method_GetLowpassCurve0 __GetLowpassCurve0;
    public static UnityEngine.AnimationCurve GetLowpassCurve( UnityEngine.AudioLowPassFilter lowPassFilter ) {
      if( __GetLowpassCurve0 == null ) {
        __GetLowpassCurve0 = (Method_GetLowpassCurve0) Delegate.CreateDelegate( typeof( Method_GetLowpassCurve0 ), null, R.Method("GetLowpassCurve", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetLowpassCurve0(  lowPassFilter  );
    }



    delegate UnityEngine.Vector3 Method_GetListenerPos0();
    static Method_GetListenerPos0 __GetListenerPos0;
    public static UnityEngine.Vector3 GetListenerPos() {
      if( __GetListenerPos0 == null ) {
        __GetListenerPos0 = (Method_GetListenerPos0) Delegate.CreateDelegate( typeof( Method_GetListenerPos0 ), null, R.Method("GetListenerPos", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __GetListenerPos0(  );
    }



    delegate void Method_UpdateAudio0();
    static Method_UpdateAudio0 __UpdateAudio0;
    public static void UpdateAudio() {
      if( __UpdateAudio0 == null ) {
        __UpdateAudio0 = (Method_UpdateAudio0) Delegate.CreateDelegate( typeof( Method_UpdateAudio0 ), null, R.Method("UpdateAudio", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      __UpdateAudio0(  );
    }



    delegate void Method_SetListenerTransform0( UnityEngine.Transform t );
    static Method_SetListenerTransform0 __SetListenerTransform0;
    public static void SetListenerTransform( UnityEngine.Transform t ) {
      if( __SetListenerTransform0 == null ) {
        __SetListenerTransform0 = (Method_SetListenerTransform0) Delegate.CreateDelegate( typeof( Method_SetListenerTransform0 ), null, R.Method("SetListenerTransform", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      __SetListenerTransform0(  t  );
    }



    delegate bool Method_HasAudioCallback0( UnityEngine.MonoBehaviour behaviour );
    static Method_HasAudioCallback0 __HasAudioCallback0;
    public static bool HasAudioCallback( UnityEngine.MonoBehaviour behaviour ) {
      if( __HasAudioCallback0 == null ) {
        __HasAudioCallback0 = (Method_HasAudioCallback0) Delegate.CreateDelegate( typeof( Method_HasAudioCallback0 ), null, R.Method("HasAudioCallback", "UnityEditor.AudioUtil", "UnityEditor.dll") );
      }
      return __HasAudioCallback0(  behaviour  );
    }



	}
}

#endif

