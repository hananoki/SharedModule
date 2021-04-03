using System.Collections.Generic;
using System.Linq;
using UnityEditor.Animations;
using UnityEngine;
using UnityObject = UnityEngine.Object;

namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {

		/// <summary>
		/// AnimatorControllerにステート管理されていない残骸オブジェクトを削除します
		/// AnimatorWindow以外でChildAnimatorStateだけ削除したりするとAnimatorState等のサブアセットが残り続けます
		/// </summary>
		/// <param name="self"></param>
		public static void RemoveUnusedSubAssets( this AnimatorController self ) {
			var lst = new List<UnityObject>();

			bool _FindAnimatorState( AnimatorStateMachine stateMachine, AnimatorState find ) {
				foreach( var p in stateMachine.states ) {
					if( p.state == find ) return true;
				}
				foreach( var p in stateMachine.stateMachines ) {
					if( _FindAnimatorState( p.stateMachine, find ) ) return true;
				}
				return false;
			}
			bool _FindBlendTree( AnimatorStateMachine stateMachine, BlendTree find ) {
				foreach( var p in stateMachine.states ) {
					if( p.state.motion.GetType() == typeof( BlendTree ) ) {
						if( p.state.motion == find ) {
							return true;
						}
					}
				}
				foreach( var p in stateMachine.stateMachines ) {
					if( _FindBlendTree( p.stateMachine, find ) ) return true;
				}
				return false;
			}


			bool FindAnimatorState( AnimatorState find ) {
				foreach( var lay in self.layers ) {
					if( _FindAnimatorState( lay.stateMachine, find ) ) return true;
				}
				return false;
			}
			bool FindBlendTree( BlendTree find ) {
				foreach( var lay in self.layers ) {
					if( _FindBlendTree( lay.stateMachine, find ) ) return true;
				}
				return false;
			}

			foreach( var p in self.LoadAllSubAssets() ) {
				if( p.GetType() == typeof( AnimatorState ) ) {
					if( !FindAnimatorState( (AnimatorState) p ) ) {
						lst.Add( p );
					}
				}
				if( p.GetType() == typeof( BlendTree ) ) {
					if( !FindBlendTree( (BlendTree) p ) ) {
						lst.Add( p );
					}
				}
			}
			//AnimatorStateMachine
			//BlendTree
			EditorHelper.Dirty( self, () => {
				foreach( var p in lst ) {
					Debug.Log( p.name );
					UnityObject.DestroyImmediate( p, true );
				}
			} );
		}


		/// <summary>
		/// AnimatorStateの削除とChildAnimatorStateを調整します
		/// </summary>
		/// <param name="self"></param>
		/// <param name="state"></param>
		public static void RemoveState( this AnimatorController self, AnimatorState state ) {
			bool _remove( AnimatorStateMachine stateMachine, AnimatorState find ) {
				var lst = stateMachine.states.ToList();
				for( var i = 0; i < lst.Count; i++ ) {
					if( lst[ i ].state == find ) {
						var obj = lst[ i ].state;
						lst.RemoveAt( i );
						UnityObject.DestroyImmediate( obj, true );
						stateMachine.states = lst.ToArray();
						return true;
					}
				}

				foreach( var p in stateMachine.stateMachines ) {
					if( _remove( p.stateMachine, find ) ) return true;
				}
				return false;
			}

			foreach( var lay in self.layers ) {
				if( _remove( lay.stateMachine, state ) ) break;
			}
		}


		[System.Obsolete( "Use RemoveState( this AnimatorController, AnimatorState ) instead" )]
		public static void RemoveState( this AnimatorController self, string name ) {
			RemoveState( self, name, 0 );
		}

		[System.Obsolete( "Use RemoveState( this AnimatorController, AnimatorState ) instead" )]
		public static void RemoveState( this AnimatorController self, string name, int layerIndex ) {
			var states = new List<ChildAnimatorState>( self.layers[ layerIndex ].stateMachine.states );
			for( var i = 0; i < states.Count; i++ ) {
				if( name == states[ i ].state.name ) {
					var obj = states[ i ].state;
					states.RemoveAt( i );
					UnityObject.DestroyImmediate( obj, true );
				}
			}
			self.layers[ layerIndex ].stateMachine.states = states.ToArray();
		}


		static void TraverseStateMachine( AnimatorController self, AnimatorState findState, System.Action<ChildAnimatorState> action ) {
			bool _recursive( AnimatorStateMachine stateMachine, AnimatorState find ) {
				var lst = stateMachine.states.ToList();
				for( var i = 0; i < lst.Count; i++ ) {
					if( lst[ i ].state == find ) {
						action.Invoke( lst[ i ] );
						return true;
					}
				}

				foreach( var p in stateMachine.stateMachines ) {
					if( _recursive( p.stateMachine, find ) ) return true;
				}
				return false;
			}

			foreach( var lay in self.layers ) {
				if( _recursive( lay.stateMachine, findState ) ) break;
			}
		}



		public static void Copy( this AnimatorState self, AnimatorState from ) {
			self.behaviours = from.behaviours;
			self.transitions = from.transitions;
			self.timeParameterActive = from.timeParameterActive;
			self.mirrorParameterActive = from.mirrorParameterActive;
			self.cycleOffsetParameterActive = from.cycleOffsetParameterActive;
			self.speedParameterActive = from.speedParameterActive;
			self.timeParameter = from.timeParameter;
			self.mirrorParameter = from.mirrorParameter;
			self.cycleOffsetParameter = from.cycleOffsetParameter;
			self.speedParameter = from.speedParameter;
			self.tag = from.tag;
			self.writeDefaultValues = from.writeDefaultValues;
			self.iKOnFeet = from.iKOnFeet;
			self.mirror = from.mirror;
			self.motion = from.motion;
			self.cycleOffset = from.cycleOffset;
			self.speed = from.speed;
			self.motion = from.motion;
		}
	}
}
