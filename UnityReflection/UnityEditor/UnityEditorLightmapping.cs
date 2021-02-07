/// UnityEditor.Lightmapping : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorLightmapping {

		public static class Cache<T> {
			public static T cache;
		}

		public static string diskCachePath {
			get {
				if( __getter_diskCachePath == null ) {
					__getter_diskCachePath = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), null, UnityTypes.UnityEditor_Lightmapping.GetMethod( "get_diskCachePath", R.StaticMembers ) );
				}
				return __getter_diskCachePath();
			}
		}

		public static long diskCacheSize {
			get {
				if( __getter_diskCacheSize == null ) {
					__getter_diskCacheSize = (Func<long>) Delegate.CreateDelegate( typeof( Func<long> ), null, UnityTypes.UnityEditor_Lightmapping.GetMethod( "get_diskCacheSize", R.StaticMembers ) );
				}
				return __getter_diskCacheSize();
			}
		}

		public static bool BakeReflectionProbeSnapshot( UnityEngine.ReflectionProbe probe ) {
			if( __BakeReflectionProbeSnapshot_0_1 == null ) {
				__BakeReflectionProbeSnapshot_0_1 = (Func<UnityEngine.ReflectionProbe, bool>) Delegate.CreateDelegate( typeof( Func<UnityEngine.ReflectionProbe, bool> ), null, UnityTypes.UnityEditor_Lightmapping.GetMethod( "BakeReflectionProbeSnapshot", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.ReflectionProbe ) }, null ) );
			}
			return __BakeReflectionProbeSnapshot_0_1( probe );
		}
		
		
		
		static Func<string> __getter_diskCachePath;
		static Func<long> __getter_diskCacheSize;
		static Func<UnityEngine.ReflectionProbe, bool> __BakeReflectionProbeSnapshot_0_1;
	}
}

