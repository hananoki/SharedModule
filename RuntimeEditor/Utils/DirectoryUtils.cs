#if UNITY_EDITOR

using System.IO;
using System.Linq;
using UnityEngine;
using UnityEditor;
//using HananokiEditor;

namespace Hananoki {

	public static class DirectoryUtils {

		public static string[] GetFiles( string path ) {
			return Directory
					.GetFiles( path )
					.Select( c => Prettyfy( c ) )
					.ToArray();
		}

		public static string[] GetFiles( string path, string searchPattern ) {
			return Directory
					.GetFiles( path, searchPattern )
					.Select( c => Prettyfy( c ) )
					.ToArray();
		}

		public static string[] GetFiles( string path, string searchPattern, SearchOption searchOption ) {
			return Directory
					.GetFiles( path, searchPattern, searchOption )
					.Select( c => Prettyfy( c ) )
					.ToArray();
		}

		public static string Prettyfy( string dir ) {
			return dir.Replace( "\\", "/" ).TrimEnd( '/' );
		}

		public static string[] GetFileGUIDs( string path, string searchPattern ) {
			var ss = GetFiles( path, searchPattern );
			for( int i = 0; i < ss.Length; i++ ) {
				ss[ i ] = AssetDatabase.AssetPathToGUID( ss[ i ] );
			}
			return ss;
		}
	}



	public static class fs {
		public static void mkdir( string path ) {
			if( !Directory.Exists( path ) ) {
				Directory.CreateDirectory( path );
			}
		}
		public static void mv( string src, string dst ) {
			
			if( File.Exists( src ) ) {
				if( File.Exists( dst ) ) {
					File.Delete( dst );
				}
				File.Move( src, dst );
			}
			
			if( Directory.Exists( src ) ) {
				if( Directory.Exists( dst ) ) {
					Directory.Delete( dst );
				}
				Directory.Move( src, dst );
			}
		}
		public static void cp( string src, string dst, bool overwrite = false ) {
			if( !overwrite ) {
				if( File.Exists( dst ) ) return;
			}
			if( !Directory.Exists( Path.GetDirectoryName( dst ) ) ) {
				Directory.CreateDirectory( Path.GetDirectoryName( dst ) );
			}
			File.Copy( src, dst, overwrite );
		}
		public static void rm( string path, bool recursive = false ) {
			//try {
			if( Directory.Exists( path ) ) {
				Directory.Delete( path, recursive );
			}
			else if( File.Exists( path ) ) {
				File.Delete( path );
			}
			//}
			//catch( DirectoryNotFoundException e ) {
			//	Debug.LogException( e );
			//}
			//catch( System.Exception e ) {
			//	Debug.LogException( e );
			//}
		}


		public static string ReadAllText( string path ) {
			if( !File.Exists( path ) ) return null;

			return File.ReadAllText( path );
		}
	}
}

#endif
