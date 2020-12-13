/// UnityEditor.SceneManagement.EditorSceneManager : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorSceneManagementEditorSceneManager {
    
		public static UnityEngine.SceneManagement.Scene GetSceneByHandle( int handle ) {
			if( __GetSceneByHandle_0_1 == null ) {
				__GetSceneByHandle_0_1 = (Func<int, UnityEngine.SceneManagement.Scene>) Delegate.CreateDelegate( typeof( Func<int, UnityEngine.SceneManagement.Scene> ), null, UnityTypes.UnityEditor_SceneManagement_EditorSceneManager.GetMethod( "GetSceneByHandle", R.StaticMembers, null, new Type[]{ typeof( int ) }, null ) );
			}
			return __GetSceneByHandle_0_1( handle );
		}
		
		
		
		static Func<int, UnityEngine.SceneManagement.Scene> __GetSceneByHandle_0_1;
	}
}

