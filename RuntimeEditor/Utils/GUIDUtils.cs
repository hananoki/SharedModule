#if UNITY_EDITOR

using System;
using System.IO;
using HananokiEditor.Extensions;
using HananokiRuntime.Extensions;

namespace HananokiEditor {
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
			return Guid.NewGuid().ToString( "N" );
		}

		public static int NewInt32() {
			return Convert.ToInt32( NewString().Substring( 0, 8 ), 16 );
		}

	}
}

#endif
