/// UnityEditor.CharacterControllerEditor : 2019.4.16f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorCharacterControllerEditor {

		public static class Cache<T> {
			public static T cache;
		}

		public static float SizeHandle( UnityEngine.Vector3 localPos, UnityEngine.Vector3 localPullDir, UnityEngine.Matrix4x4 matrix, bool isEdgeHandle ) {
			if( __SizeHandle_0_4 == null ) {
				__SizeHandle_0_4 = (Func<UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Matrix4x4,bool, float>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Matrix4x4,bool, float> ), null, UnityTypes.UnityEditor_CharacterControllerEditor.GetMethod( "SizeHandle", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Vector3 ), typeof( UnityEngine.Vector3 ), typeof( UnityEngine.Matrix4x4 ), typeof( bool ) }, null ) );
			}
			return __SizeHandle_0_4( localPos, localPullDir, matrix, isEdgeHandle );
		}
		
		
		
		static Func<UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Matrix4x4,bool, float> __SizeHandle_0_4;
	}
}

