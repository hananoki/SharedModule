/// UnityEditor.TypeCache : 2019.4.5f1

#if UNITY_2019_2_OR_NEWER

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorTypeCache {
    
		public static UnityEditor.TypeCache.TypeCollection GetTypesDerivedFrom() {
			if( __GetTypesDerivedFrom_0_0 == null ) {
				__GetTypesDerivedFrom_0_0 = (Func<UnityEditor.TypeCache.TypeCollection>) Delegate.CreateDelegate( typeof( Func<UnityEditor.TypeCache.TypeCollection> ), null, UnityTypes.UnityEditor_TypeCache.GetMethod( "GetTypesDerivedFrom", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetTypesDerivedFrom_0_0(  );
		}
		
		public static UnityEditor.TypeCache.TypeCollection GetTypesDerivedFrom( System.Type parentType ) {
			if( __GetTypesDerivedFrom_1_1 == null ) {
				__GetTypesDerivedFrom_1_1 = (Func<System.Type, UnityEditor.TypeCache.TypeCollection>) Delegate.CreateDelegate( typeof( Func<System.Type, UnityEditor.TypeCache.TypeCollection> ), null, UnityTypes.UnityEditor_TypeCache.GetMethod( "GetTypesDerivedFrom", R.StaticMembers, null, new Type[]{ typeof( System.Type ) }, null ) );
			}
			return __GetTypesDerivedFrom_1_1( parentType );
		}
		
		
		
		static Func<UnityEditor.TypeCache.TypeCollection> __GetTypesDerivedFrom_0_0;
		static Func<System.Type, UnityEditor.TypeCache.TypeCollection> __GetTypesDerivedFrom_1_1;
	}
}

#endif // UNITY_2019_2_OR_NEWER


