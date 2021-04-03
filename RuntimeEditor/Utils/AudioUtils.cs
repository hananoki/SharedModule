using UnityReflection;

namespace HananokiEditor {

	public sealed class AudioUtils {

		public static void PlayClip( UnityEngine.AudioClip audioClip, int startSample = 0, bool loop = false ) {
			if( audioClip == null ) return;

			if( UnitySymbol.UNITY_2020_2_OR_NEWER ) {
				UnityEditorAudioUtil.PlayPreviewClip( audioClip, startSample, loop );
			}
			else {
				UnityEditorAudioUtil.PlayClip( audioClip, startSample, loop );
			}
		}

		public static void StopAllClips() {
			if( UnitySymbol.UNITY_2020_2_OR_NEWER ) {
				UnityEditorAudioUtil.StopAllPreviewClips();
			}
			else {
				UnityEditorAudioUtil.StopAllClips();
			}
		}
	}
}
