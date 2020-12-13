/// UnityEditor.GameObjectUtility : 2019.4.5f1

using HananokiEditor;
using System;
using System.Reflection;
using UnityEngine;
using System.Collections.Generic;

namespace UnityReflection {
  public sealed partial class UnityEditorGameObjectUtility {

		public static class Cache<T> {
			public static T cache;
		}

		public static object DisplayUpdateChildrenDialogIfNeeded( IEnumerable<GameObject> gameObjects, string title, string message ) {
			if( __DisplayUpdateChildrenDialogIfNeeded_0_3 == null ) {
				__DisplayUpdateChildrenDialogIfNeeded_0_3 = UnityTypes.UnityEditor_GameObjectUtility.GetMethod( "DisplayUpdateChildrenDialogIfNeeded", R.StaticMembers );
			}
			return __DisplayUpdateChildrenDialogIfNeeded_0_3.Invoke( "DisplayUpdateChildrenDialogIfNeeded", new object[] {  gameObjects, title, message  } );
		}
		
		
		
		static MethodInfo __DisplayUpdateChildrenDialogIfNeeded_0_3;
	}
}

