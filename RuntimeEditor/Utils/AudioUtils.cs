using UnityReflection;

namespace HananokiEditor {

	public sealed class AudioUtils {

		public static void PlayClip( UnityEngine.AudioClip clip, int startSample = 0, bool loop = false ) {
			if( UnitySymbol.UNITY_2020_2_OR_NEWER ) {
				UnityEditorAudioUtil.PlayPreviewClip( clip, startSample, loop );
			}
			else {
				UnityEditorAudioUtil.PlayClip( clip, startSample, loop );
			}
		}

		public static void StopAllClips(  ) {
			if( UnitySymbol.UNITY_2020_2_OR_NEWER ) {
				UnityEditorAudioUtil.StopAllPreviewClips();
			}
			else {
				UnityEditorAudioUtil.StopAllClips();
			}
		}
	}
}
