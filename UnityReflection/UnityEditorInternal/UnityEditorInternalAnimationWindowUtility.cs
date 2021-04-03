/// UnityEditorInternal.AnimationWindowUtility : 2020.3.0f1

using HananokiEditor;
using System;
using System.Reflection;
using System.Collections;

namespace UnityReflection {
  public sealed partial class UnityEditorInternalAnimationWindowUtility {

		public static class Cache<T> {
			public static T cache;
		}

		public static void RemoveKeyframes( object state, IList curves, object time ) {
			if( __RemoveKeyframes_0_3 == null ) {
				__RemoveKeyframes_0_3 = UnityTypes.UnityEditorInternal_AnimationWindowUtility.GetMethod( "RemoveKeyframes", R.StaticMembers );
			}
			__RemoveKeyframes_0_3.Invoke( null, new object[] {  state, curves, time  } );
		}
		
		public static bool IsNodeLeftOverCurve( object node ) {
			if( __IsNodeLeftOverCurve_0_1 == null ) {
				__IsNodeLeftOverCurve_0_1 = UnityTypes.UnityEditorInternal_AnimationWindowUtility.GetMethod( "IsNodeLeftOverCurve", R.StaticMembers );
			}
			return (bool) __IsNodeLeftOverCurve_0_1.Invoke( null, new object[] {  node  } );
		}
		
		
		
		static MethodInfo __RemoveKeyframes_0_3;
		static MethodInfo __IsNodeLeftOverCurve_0_1;
	}
}

