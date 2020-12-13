/// UnityEditor.TypeCache : 2019.4.5f1

#if UNITY_2019_2_OR_NEWER

using HananokiEditor;
//using Hananoki.Reflection;
using System;
using System.Reflection;
namespace UnityReflection {
  public sealed partial class UnityEditorTypeCache {
		public static class R {
			public const BindingFlags StaticMembers = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
			public const BindingFlags InstanceMembers = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
			public const BindingFlags AllMembers = StaticMembers | InstanceMembers;
		}
		public static class Cache<T> {
			public static T cache;
		}

		public static UnityEditor.TypeCache.MethodCollection GetMethodsWithAttribute( System.Type attrType ) {
			if( __GetMethodsWithAttribute_0_1 == null ) {
				__GetMethodsWithAttribute_0_1 = (Func<System.Type, UnityEditor.TypeCache.MethodCollection>) Delegate.CreateDelegate( typeof( Func<System.Type, UnityEditor.TypeCache.MethodCollection> ), null, UnityTypes.UnityEditor_TypeCache.GetMethod( "GetMethodsWithAttribute", R.StaticMembers, null, new Type[]{ typeof( System.Type ) }, null ) );
			}
			return __GetMethodsWithAttribute_0_1( attrType );
		}
		
		public static UnityEditor.TypeCache.MethodCollection GetMethodsWithAttribute<T>() where T : Attribute {
			if( Cache<Method_GetMethodsWithAttribute_1_0<T>>.cache == null ) {
				Type funcType = typeof(Method_GetMethodsWithAttribute_1_0<>).MakeGenericType( typeof( T ) );
				var mi = UnityTypes.UnityEditor_TypeCache.GetMethod( "GetMethodsWithAttribute", R.StaticMembers, null, new Type[]{  }, null );
				System.Reflection.MethodInfo generic = mi.MakeGenericMethod( typeof( T ) );
				Cache< Method_GetMethodsWithAttribute_1_0<T> >.cache = ( Method_GetMethodsWithAttribute_1_0<T> ) Delegate.CreateDelegate( funcType, null, generic );
			}
			return Cache< Method_GetMethodsWithAttribute_1_0<T> >.cache();
		}
		
		
		
		static Func<System.Type, UnityEditor.TypeCache.MethodCollection> __GetMethodsWithAttribute_0_1;
		delegate UnityEditor.TypeCache.MethodCollection Method_GetMethodsWithAttribute_1_0<T>();
	}
}

#endif // UNITY_2019_2_OR_NEWER


