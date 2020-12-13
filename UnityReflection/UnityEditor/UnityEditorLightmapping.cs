/// UnityEditor.Lightmapping : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorLightmapping {

		public static string diskCachePath {
			get {
				if( __diskCachePath == null ) {
					__diskCachePath = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), null, UnityTypes.UnityEditor_Lightmapping.GetMethod( "get_diskCachePath", R.StaticMembers ) );
				}
				return __diskCachePath();
			}
		}

		public static long diskCacheSize {
			get {
				if( __diskCacheSize == null ) {
					__diskCacheSize = (Func<long>) Delegate.CreateDelegate( typeof( Func<long> ), null, UnityTypes.UnityEditor_Lightmapping.GetMethod( "get_diskCacheSize", R.StaticMembers ) );
				}
				return __diskCacheSize();
			}
		}

		
		
		static Func<string> __diskCachePath;
		static Func<long> __diskCacheSize;
	}
}

