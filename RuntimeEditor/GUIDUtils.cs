#if UNITY_EDITOR

using UnityEditor;
using System.IO;

namespace Hananoki {
	using Extensions;

	public static class GUIDUtils {
		public static T LoadAssetAtGUID<T>( string guid ) where T : UnityEngine.Object {
			var path = UnityEditor.AssetDatabase.GUIDToAssetPath( guid );
			T b = AssetDatabase.LoadAssetAtPath( path, typeof( T ) ) as T;
			return b;
		}

		
		public static string GetAssetPath( string guid ) {
			return AssetDatabase.GUIDToAssetPath( guid );
		}


		public static string ToGUID( this string path ) {
			var b = AssetDatabase.AssetPathToGUID( path );
			return b;
		}


		public static string ToGUID( UnityEngine.Object obj ) {
			var a = AssetDatabase.GetAssetPath( obj );
			var b = AssetDatabase.AssetPathToGUID( a );
			return b;
		}


		public static string AdjustDirectoryGUID( this string guid ) {
			var path = GUIDUtils.GetAssetPath( guid );
			if( Directory.Exists( path ) ) {
				return guid;
			}
			else {
				return path.DirectoryName().ToGUID();
			}
		}
	}
}

#endif
