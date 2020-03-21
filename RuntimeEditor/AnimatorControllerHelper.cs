
#if UNITY_EDITOR

using System.IO;
using System.Linq;
using UnityEngine;

using UnityEditor;
using UnityEditor.Animations;

namespace Hananoki {

	public static class AnimatorControllerHelper {
		public static void DefaultStatePosition( AnimatorController controller ) {
			foreach( var layer in controller.layers ) {
				layer.stateMachine.anyStatePosition = new Vector3( -168.0f, 0.0f, 0.0f );
				layer.stateMachine.entryPosition = new Vector3( -168.0f, 36.0f, 0.0f );
				layer.stateMachine.exitPosition = new Vector3( -168.0f, -36.0f, 0.0f );
			}
		}

		public static void AddFolder( AnimatorController controller, string apath ) {
			//Debug.Log( path );

			DefaultStatePosition( controller );


			var st = controller.layers[ 0 ].stateMachine.states;
			int addcnt = 0;
			var files = Directory.GetFiles( apath, "*.fbx" );
			float fval = 0.00f;
			float fadd = 1.00f / files.Length;

			foreach( string path in files ) {
				fval += fadd;
				EditorUtility.DisplayProgressBar( "クリップ複製中", path, fval );

				var fbxClipList = AssetDatabase.LoadAllAssetsAtPath( path.Replace( "\\", "/" ) ).
					Where( x => x.GetType() == typeof( AnimationClip ) ).
					Where( x => !x.name.Contains( "__preview__" ) ).ToArray();

				foreach( AnimationClip fbxClip in fbxClipList ) {
					int i = System.Array.FindIndex( st, c => c.state.motion == fbxClip );
					if( 0 <= i ) {
						if( st[ i ].state.name != fbxClip.name ) {
							st[ i ].state.name = fbxClip.name;
						}
						continue;
					}

					//if( 0 <= System.Array.FindIndex( self.animationClips, ( c ) => { return c.name == fbxClip.name; } ) ) {
					//	int i = System.Array.FindIndex( st, c => c.state.motion == fbxClip );
					//	if( 0 <= i ) {
					//		if( st[ i ].state.name != fbxClip.name ) {
					//			//console.log( st[ i ].state.name );
					//			st[ i ].state.name = fbxClip.name;
					//		}
					//	}
					//	continue;
					//}

					var lsls = AssetDatabase.GetLabels( fbxClip );
					var lidx = System.Array.FindIndex( lsls, x => x == "Unused" );
					if( -1 == lidx ) {
						addcnt++;
						var state = controller.AddMotion( fbxClip );
					}
				}
			}
			EditorUtility.ClearProgressBar();
		}

		public static void RemoveAll( AnimatorController controller ) {
			var states = controller.layers[ 0 ].stateMachine.states;

			float fval = 0.00f;
			float fadd = 1.00f / states.Length;

			
			for( int i = states.Length - 1; 0 <= i; i-- ) {
				fval += fadd;
				var c = states[ i ];
				EditorUtility.DisplayProgressBar( "クリップ削除中", string.Format( "{0} : {1}", controller.name, c.state.name ), fval );
				AnimatorControllerHelper.Remove( controller, c.state );
			}

			EditorUtility.ClearProgressBar();
		}

		public static void Remove( AnimatorController controller, AnimatorState state ) {
			//var st = controller.layers[ 0 ].stateMachine.states;
			//var idx =  System.Array.FindIndex( controller.animationClips, ( c ) => { return c.name == name; } );
			//if( idx < 0 ) {
			//	return;
			//}

			//var clip = controller.animationClips[ idx ];

			//int i = System.Array.FindIndex( st, c => c.state.motion == clip );
			//if( 0 <= i ) {
			controller.layers[ 0 ].stateMachine.RemoveState( state );

			//}
		}
	}
}

#endif
