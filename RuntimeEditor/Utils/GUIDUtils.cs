#if UNITY_EDITOR

using UnityEditor;
using System.IO;

namespace Hananoki {
	using Extensions;

	public static class GUIDUtils {
		public static T LoadAssetAtGUID<T>( string guid ) where T : UnityEngine.Object {
			var path = AssetDatabase.GUIDToAssetPath( guid );
			T b = AssetDatabase.LoadAssetAtPath( path, typeof( T ) ) as T;
			return b;
		}
		public static UnityEngine.Object LoadAssetAtGUID( System.Type type, string guid ) {
			var path = AssetDatabase.GUIDToAssetPath( guid );
			UnityEngine.Object b = AssetDatabase.LoadAssetAtPath( path, type ) as UnityEngine.Object;
			return b;
		}

		public static UnityEngine.Object LoadAssetAtGUID( string guid ) {
			return LoadAssetAtGUID( typeof( UnityEngine.Object ), guid);
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
			if( guid.IsEmpty() ) return string.Empty;

			var path = GetAssetPath( guid );
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
