﻿/// UnityEditor.EditorAssemblies : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorEditorAssemblies {
    
		public static System.Reflection.Assembly[] loadedAssemblies {
			get {
				if( __loadedAssemblies == null ) {
					__loadedAssemblies = (Func<System.Reflection.Assembly[]>) Delegate.CreateDelegate( typeof( Func<System.Reflection.Assembly[]> ), null, UnityTypes.UnityEditor_EditorAssemblies.GetMethod( "get_loadedAssemblies", R.StaticMembers ) );
				}
				return __loadedAssemblies();
			}
		}

		public static IEnumerable<Type> loadedTypes {
			get {
				if( __loadedTypes == null ) {
					__loadedTypes = (Func<IEnumerable<Type>>) Delegate.CreateDelegate( typeof( Func<IEnumerable<Type>> ), null, UnityTypes.UnityEditor_EditorAssemblies.GetMethod( "get_loadedTypes", R.StaticMembers ) );
				}
				return __loadedTypes();
			}
		}
		public static IEnumerable<Type> GetAllTypesWithInterface() {
			if( __GetAllTypesWithInterface_0_0 == null ) {
				__GetAllTypesWithInterface_0_0 = (Func<IEnumerable<Type>>) Delegate.CreateDelegate( typeof( Func<IEnumerable<Type>> ), null, UnityTypes.UnityEditor_EditorAssemblies.GetMethod( "GetAllTypesWithInterface", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetAllTypesWithInterface_0_0(  );
		}
		
		public static IEnumerable<Type> GetAllTypesWithInterface( System.Type interfaceType ) {
			if( __GetAllTypesWithInterface_1_1 == null ) {
				__GetAllTypesWithInterface_1_1 = (Func<System.Type, IEnumerable<Type>>) Delegate.CreateDelegate( typeof( Func<System.Type, IEnumerable<Type>> ), null, UnityTypes.UnityEditor_EditorAssemblies.GetMethod( "GetAllTypesWithInterface", R.StaticMembers, null, new Type[]{ typeof( System.Type ) }, null ) );
			}
			return __GetAllTypesWithInterface_1_1( interfaceType );
		}
		
		public static bool IsSubclassOfGenericType( System.Type klass, System.Type genericType ) {
			if( __IsSubclassOfGenericType_0_2 == null ) {
				__IsSubclassOfGenericType_0_2 = (Func<System.Type,System.Type, bool>) Delegate.CreateDelegate( typeof( Func<System.Type,System.Type, bool> ), null, UnityTypes.UnityEditor_EditorAssemblies.GetMethod( "IsSubclassOfGenericType", R.StaticMembers, null, new Type[]{ typeof( System.Type ), typeof( System.Type ) }, null ) );
			}
			return __IsSubclassOfGenericType_0_2( klass, genericType );
		}
		
		public static void ProcessInitializeOnLoadAttributes( System.Type[] types ) {
			if( __ProcessInitializeOnLoadAttributes_0_1 == null ) {
				__ProcessInitializeOnLoadAttributes_0_1 = (Action<System.Type[]>) Delegate.CreateDelegate( typeof( Action<System.Type[]> ), null, UnityTypes.UnityEditor_EditorAssemblies.GetMethod( "ProcessInitializeOnLoadAttributes", R.StaticMembers, null, new Type[]{ typeof( System.Type[] ) }, null ) );
			}
			__ProcessInitializeOnLoadAttributes_0_1( types );
		}
		
		public static IEnumerable<Type> SubclassesOf( System.Type parent ) {
			if( __SubclassesOf_0_1 == null ) {
				__SubclassesOf_0_1 = (Func<System.Type, IEnumerable<Type>>) Delegate.CreateDelegate( typeof( Func<System.Type, IEnumerable<Type>> ), null, UnityTypes.UnityEditor_EditorAssemblies.GetMethod( "SubclassesOf", R.StaticMembers, null, new Type[]{ typeof( System.Type ) }, null ) );
			}
			return __SubclassesOf_0_1( parent );
		}
		
		public static IEnumerable<Type> SubclassesOfClass( System.Type parent ) {
			if( __SubclassesOfClass_0_1 == null ) {
				__SubclassesOfClass_0_1 = (Func<System.Type, IEnumerable<Type>>) Delegate.CreateDelegate( typeof( Func<System.Type, IEnumerable<Type>> ), null, UnityTypes.UnityEditor_EditorAssemblies.GetMethod( "SubclassesOfClass", R.StaticMembers, null, new Type[]{ typeof( System.Type ) }, null ) );
			}
			return __SubclassesOfClass_0_1( parent );
		}
		
		public static IEnumerable<Type> SubclassesOfGenericType( System.Type genericType ) {
			if( __SubclassesOfGenericType_0_1 == null ) {
				__SubclassesOfGenericType_0_1 = (Func<System.Type, IEnumerable<Type>>) Delegate.CreateDelegate( typeof( Func<System.Type, IEnumerable<Type>> ), null, UnityTypes.UnityEditor_EditorAssemblies.GetMethod( "SubclassesOfGenericType", R.StaticMembers, null, new Type[]{ typeof( System.Type ) }, null ) );
			}
			return __SubclassesOfGenericType_0_1( genericType );
		}
		
		
		
		static Func<System.Reflection.Assembly[]> __loadedAssemblies;
		static Func<IEnumerable<Type>> __loadedTypes;
		static Func<IEnumerable<Type>> __GetAllTypesWithInterface_0_0;
		static Func<System.Type, IEnumerable<Type>> __GetAllTypesWithInterface_1_1;
		static Func<System.Type,System.Type, bool> __IsSubclassOfGenericType_0_2;
		static Action<System.Type[]> __ProcessInitializeOnLoadAttributes_0_1;
		static Func<System.Type, IEnumerable<Type>> __SubclassesOf_0_1;
		static Func<System.Type, IEnumerable<Type>> __SubclassesOfClass_0_1;
		static Func<System.Type, IEnumerable<Type>> __SubclassesOfGenericType_0_1;
	}
}

