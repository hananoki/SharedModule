
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {

		public static int GetFrame( this AnimationClip clip, float time ) {
			return (int) ( ( time * clip.frameRate ) + 0.5f );
		}

		public static float GetTime( this AnimationClip clip, int frame ) {
			return frame / clip.frameRate;
		}

		public static List<AnimationEvent> GetEvents( this AnimationClip clip ) {
			return new List<AnimationEvent>( AnimationUtility.GetAnimationEvents( clip ) );
		}


		public static void SetEvents( this AnimationClip clip, AnimationEvent[] events ) {
			EditorHelper.Dirty( clip, () => {
				AnimationUtility.SetAnimationEvents( clip, events );
			} );
		}

		public static void SetEvents( this AnimationClip clip, List<AnimationEvent> events ) {
			SetEvents( clip, events.ToArray() );
		}
	}
}
