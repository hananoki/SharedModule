
using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using UnityEditor.Animations;

namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {

		public static int GetFrame( this AnimationClip clip, float time ) {
			return (int) ( ( time * clip.frameRate ) + 0.5f );
		}

		public static float GetTime( this AnimationClip clip, int frame ) {
			return frame / clip.frameRate;
		}

		public static List<AnimationEvent> GetAnimationEvents( this AnimationClip clip ) {
			return new List<AnimationEvent>( AnimationUtility.GetAnimationEvents( clip ) );
		}

		public static void SetAnimationEvents( this AnimationClip clip, AnimationEvent[] events ) {
			EditorHelper.Dirty( clip, () => {
				AnimationUtility.SetAnimationEvents( clip, events );
			} );
		}

		public static void RenameState( this AnimatorController self, string originalName, string newName ) {
			RenameState( self, originalName, newName, 0 );
		}

		public static void RenameState( this AnimatorController self, string originalName, string newName, int layerIndex ) {
			var states = new List<ChildAnimatorState>( self.layers[ layerIndex ].stateMachine.states );
			for( var i = 0; i < states.Count; i++ ) {
				if( originalName == states[ i ].state.name ) {
					states[ i ].state.name = newName;
				}
			}
		}


		public static void RemoveState( this AnimatorController self, string name ) {
			RemoveState( self, name, 0 );
		}

		public static void RemoveState( this AnimatorController self, string name, int layerIndex ) {
			var states = new List<ChildAnimatorState>( self.layers[ layerIndex ].stateMachine.states );
			for( var i = 0; i < states.Count; i++ ) {
				if( name == states[ i ].state.name ) {
					states.RemoveAt( i );
				}
			}
			self.layers[ layerIndex ].stateMachine.states = states.ToArray();
		}
	}
}
