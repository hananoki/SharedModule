/// UnityEditor.PrefabUtility : 2019.4.16f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorPrefabUtility {

		public static class Cache<T> {
			public static T cache;
		}

		public static UnityEditor.PrefabInstanceStatus GetPrefabInstanceStatus( UnityEngine.Object componentOrGameObject ) {
			if( __GetPrefabInstanceStatus_0_1 == null ) {
				__GetPrefabInstanceStatus_0_1 = (Func<UnityEngine.Object, UnityEditor.PrefabInstanceStatus>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Object, UnityEditor.PrefabInstanceStatus> ), null, UnityTypes.UnityEditor_PrefabUtility.GetMethod( "GetPrefabInstanceStatus", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Object ) }, null ) );
			}
			return __GetPrefabInstanceStatus_0_1( componentOrGameObject );
		}
		
		public static UnityEditor.PrefabAssetType GetPrefabAssetType( UnityEngine.Object componentOrGameObject ) {
			if( __GetPrefabAssetType_0_1 == null ) {
				__GetPrefabAssetType_0_1 = (Func<UnityEngine.Object, UnityEditor.PrefabAssetType>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Object, UnityEditor.PrefabAssetType> ), null, UnityTypes.UnityEditor_PrefabUtility.GetMethod( "GetPrefabAssetType", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Object ) }, null ) );
			}
			return __GetPrefabAssetType_0_1( componentOrGameObject );
		}
		
		public static UnityEngine.Object GetCorrespondingObjectFromSource_internal( UnityEngine.Object obj ) {
			if( __GetCorrespondingObjectFromSource_internal_0_1 == null ) {
				__GetCorrespondingObjectFromSource_internal_0_1 = (Func<UnityEngine.Object, UnityEngine.Object>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Object, UnityEngine.Object> ), null, UnityTypes.UnityEditor_PrefabUtility.GetMethod( "GetCorrespondingObjectFromSource_internal", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Object ) }, null ) );
			}
			return __GetCorrespondingObjectFromSource_internal_0_1( obj );
		}
		
		
		
		static Func<UnityEngine.Object, UnityEditor.PrefabInstanceStatus> __GetPrefabInstanceStatus_0_1;
		static Func<UnityEngine.Object, UnityEditor.PrefabAssetType> __GetPrefabAssetType_0_1;
		static Func<UnityEngine.Object, UnityEngine.Object> __GetCorrespondingObjectFromSource_internal_0_1;
	}
}

