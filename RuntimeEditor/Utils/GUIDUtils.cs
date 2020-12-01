#if UNITY_EDITOR

using UnityEditor;
using System.IO;
using System;
using UnityObject = UnityEngine.Object;

namespace Hananoki {
	using Extensions;

	public static class GUIDUtils {

		public static string AdjustDirectoryGUID( this string guid ) {
			if( guid.IsEmpty() ) return string.Empty;

			var path = guid.ToAssetPath();
			if( Directory.Exists( path ) ) {
				return guid;
			}
			else {
				return path.DirectoryName().ToGUID();
			}
		}

		public static string NewString() {
			return System.Guid.NewGuid().ToString( "N" );
		}

		public static int NewInt32() {
			return System.Convert.ToInt32( NewString().Substring( 0, 8 ), 16 );
		}

	}
}

#endif
