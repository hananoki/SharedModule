/// UnityEditor.AssetPostprocessingInternal : 2019.4.5f1

using HananokiEditor;
using System;
using System.Reflection;
using System.Collections.Generic;

namespace UnityReflection {
  public sealed partial class UnityEditorAssetPostprocessingInternal {

		public static class Cache<T> {
			public static T cache;
		}

		public static IEnumerable<MethodInfo> AllPostProcessorMethodsNamed( string callbackName ) {
			if( __AllPostProcessorMethodsNamed_0_1 == null ) {
				__AllPostProcessorMethodsNamed_0_1 = (Func<string, IEnumerable<MethodInfo>>) Delegate.CreateDelegate( typeof( Func<string, IEnumerable<MethodInfo>> ), null, UnityTypes.UnityEditor_AssetPostprocessingInternal.GetMethod( "AllPostProcessorMethodsNamed", R.StaticMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			return __AllPostProcessorMethodsNamed_0_1( callbackName );
		}
		
		
		
		static Func<string, IEnumerable<MethodInfo>> __AllPostProcessorMethodsNamed_0_1;
	}
}

