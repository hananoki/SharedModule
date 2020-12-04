/// UnityEditor.EditorAssemblies : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityReflection {
	public sealed partial class UnityEditorEditorAssemblies {
		public static class Cache<T> {
			public static T cache;
		}

		public static IEnumerable<MethodInfo> GetAllMethodsWithAttribute<T>( System.Reflection.BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic ) where T : Attribute {
			if( Cache<Method_GetAllMethodsWithAttribute<T>>.cache == null ) {
				Type funcType = typeof( Method_GetAllMethodsWithAttribute<> ).MakeGenericType( typeof( T ) );
				var mi = UnityTypes.UnityEditor_EditorAssemblies.GetMethod( "GetAllMethodsWithAttribute", R.StaticMembers, null, new Type[] { typeof( System.Reflection.BindingFlags ) }, null );
				MethodInfo generic = mi.MakeGenericMethod( typeof( T ) );
				var de1 = Delegate.CreateDelegate( funcType, null, generic );
				//var de = Delegate.CreateDelegate( funcType, null, mi );
				//Method_GetAllMethodsWithAttribute<T> _GetAllMethodsWithAttribute_0_1 = (Method_GetAllMethodsWithAttribute<T>) de1;
				Cache<Method_GetAllMethodsWithAttribute<T>>.cache = (Method_GetAllMethodsWithAttribute<T>) de1;
			}
			//return __GetAllMethodsWithAttribute_0_1( bindingFlags );
			return Cache<Method_GetAllMethodsWithAttribute<T>>.cache( bindingFlags );
		}


		public static IEnumerable<Type> GetAllTypesWithAttribute<T>( ) where T : Attribute {
			if( Cache<Method__GetAllTypesWithAttribute<T>>.cache == null ) {
				Type funcType = typeof( Method__GetAllTypesWithAttribute<> ).MakeGenericType( typeof( T ) );
				var mi = UnityTypes.UnityEditor_EditorAssemblies.GetMethod( "GetAllTypesWithAttribute", R.StaticMembers, null, new Type[] {  }, null );
				MethodInfo generic = mi.MakeGenericMethod( typeof( T ) );
				var de1 = Delegate.CreateDelegate( funcType, null, generic );
				//var de = Delegate.CreateDelegate( funcType, null, mi );
				//Method_GetAllMethodsWithAttribute<T> dele = 
				Cache<Method__GetAllTypesWithAttribute<T>>.cache = (Method__GetAllTypesWithAttribute<T>) de1;
			}
			//return __GetAllMethodsWithAttribute_0_1( bindingFlags );
			return Cache<Method__GetAllTypesWithAttribute<T>>.cache(  );
		}

		public static IEnumerable<Type> GetAllTypesWithInterface<T>() where T : class {
			if( Cache<Method__GetAllTypesWithInterface<T>>.cache == null ) {
				Type funcType = typeof( Method__GetAllTypesWithInterface<> ).MakeGenericType( typeof( T ) );
				var mi = UnityTypes.UnityEditor_EditorAssemblies.GetMethod( "GetAllTypesWithInterface", R.StaticMembers, null, new Type[] { }, null );
				MethodInfo generic = mi.MakeGenericMethod( typeof( T ) );
				var de1 = Delegate.CreateDelegate( funcType, null, generic );
				//var de = Delegate.CreateDelegate( funcType, null, mi );
				//Method_GetAllMethodsWithAttribute<T> dele = 
				Cache<Method__GetAllTypesWithInterface<T>>.cache = (Method__GetAllTypesWithInterface<T>) de1;
			}
			//return __GetAllMethodsWithAttribute_0_1( bindingFlags );
			return Cache<Method__GetAllTypesWithInterface<T>>.cache();
		}


		delegate IEnumerable<MethodInfo> Method_GetAllMethodsWithAttribute<T>( BindingFlags bindingFlags );

		delegate IEnumerable<Type> Method__GetAllTypesWithAttribute<T>();

		delegate IEnumerable<Type> Method__GetAllTypesWithInterface<T>();
	}
}

