#if UNITY_EDITOR

using HananokiRuntime.Extensions;
using System;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;

namespace HananokiEditor {

	public static class DirectoryUtils {

		#region GetFiles

		public static string[] GetFiles( string path ) {
			if( !Directory.Exists( path ) ) return new string[ 0 ];

			return Directory
					.GetFiles( path )
					.Select( c => Prettyfy( c ) )
					.ToArray();
		}

		public static string[] GetFiles( string path, string searchPattern ) {
			if( !Directory.Exists( path ) ) return new string[ 0 ];

			return Directory
					.GetFiles( path, searchPattern )
					.Select( c => Prettyfy( c ) )
					.ToArray();
		}

		public static string[] GetFiles( string path, string searchPattern, SearchOption searchOption ) {
			if( !Directory.Exists( path ) ) return new string[ 0 ];

			return Directory
					.GetFiles( path, searchPattern, searchOption )
					.Select( c => Prettyfy( c ) )
					.ToArray();
		}

		#endregion



		#region GetDirectories

		public static string[] GetDirectories( string path ) {
			if( !Directory.Exists( path ) ) return new string[ 0 ];

			return Directory.GetDirectories( path );
		}

		public static string[] GetDirectories( string path, string searchPattern ) {
			if( !Directory.Exists( path ) ) return new string[ 0 ];

			return Directory.GetDirectories( path, searchPattern );
		}

		public static string[] GetDirectories( string path, string searchPattern, SearchOption searchOption ) {
			if( !Directory.Exists( path ) ) return new string[ 0 ];

			return Directory.GetDirectories( path, searchPattern, searchOption );
		}

		#endregion



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

		//ディレクトリのコピー
		public static void DirectoryCopy( string sourcePath, string destinationPath ) {
			DirectoryInfo sourceDirectory = new DirectoryInfo( sourcePath );
			DirectoryInfo destinationDirectory = new DirectoryInfo( destinationPath );

			//コピー先のディレクトリがなければ作成する
			if( destinationDirectory.Exists == false ) {
				destinationDirectory.Create();
				destinationDirectory.Attributes = sourceDirectory.Attributes;
			}

			//ファイルのコピー
			foreach( FileInfo fileInfo in sourceDirectory.GetFiles() ) {
				//同じファイルが存在していたら、常に上書きする
				fileInfo.CopyTo( destinationDirectory.FullName + @"\" + fileInfo.Name, true );
			}

			//ディレクトリのコピー（再帰を使用）
			foreach( DirectoryInfo directoryInfo in sourceDirectory.GetDirectories() ) {
				DirectoryCopy( directoryInfo.FullName, destinationDirectory.FullName + @"\" + directoryInfo.Name );
			}
		}

		/// <summary>
		/// フォルダのサイズを取得する
		/// </summary>
		/// <param name="dirInfo">サイズを取得するフォルダ</param>
		/// <returns>フォルダのサイズ（バイト）</returns>
		static long _GetDirectorySize( DirectoryInfo dirInfo ) {
			long size = 0;

			//フォルダ内の全ファイルの合計サイズを計算する
			foreach( FileInfo fi in dirInfo.GetFiles() )
				size += fi.Length;

			//サブフォルダのサイズを合計していく
			foreach( DirectoryInfo di in dirInfo.GetDirectories() )
				size += _GetDirectorySize( di );

			//結果を返す
			return size;
		}
		public static long GetDirectorySize( string path ) {
			if( !Directory.Exists( path ) ) return -1;
			return _GetDirectorySize( new DirectoryInfo( path ) );
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
			else {
				if( File.Exists( dst ) ) {
					// ファイル属性を取得
					FileAttributes fa = File.GetAttributes( dst );
					// 読み取り専用属性を削除（他の属性は変更しない）
					fa = fa & ~FileAttributes.ReadOnly;
					fa = fa & ~FileAttributes.Hidden;
					File.SetAttributes( dst, fa );
				}
			}

			if( !Directory.Exists( Path.GetDirectoryName( dst ) ) ) {
				Directory.CreateDirectory( Path.GetDirectoryName( dst ) );
			}
			if( !File.Exists( src ) ) return;
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

		static Encoding UTF8N = new UTF8Encoding( false );


		public static string ReadAllText( string path ) {
			return ReadAllText( path, UTF8N );
		}

		public static string ReadAllText( string path, Encoding encoding ) {
			if( !File.Exists( path ) ) return string.Empty;

			using( var fs = new FileStream( path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite ) ) {
				using( var st = new StreamReader( fs, encoding ) ) {
					return st.ReadToEnd();
				}
			}
		}

		public static void WriteAllText( string path, string contents ) {
			WriteAllText( path, contents, UTF8N );
		}

		public static void WriteAllText( string path, string contents, Encoding encoding ) {
			using( var fs = new FileStream( path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite ) ) {
				using( var st = new StreamWriter( fs, encoding ) ) {
					st.Write( contents );
				}
			}
		}


		/// <summary>
		/// テキストファイルを書き出します
		/// </summary>
		/// <param name="fname">ファイルパス</param>
		/// <param name="func">書き出しアクション</param>
		/// <param name="autoRefresh">AssetDataBaseにリフレッシュを呼び出すかどうか</param>
		/// <param name="utf8bom">UTF8のbomをつけるかどうか</param>
		public static void WriteFile( string fname, Action<StringBuilder> func, bool autoRefresh = true, bool utf8bom = true, bool newLineLinux = true ) {
			if( fname.IsEmpty() ) return;

			var builder = new StringBuilder();

			func( builder );

			var directoryName = Path.GetDirectoryName( fname );
			if( !directoryName.IsEmpty() && !Directory.Exists( directoryName ) ) {
				Directory.CreateDirectory( directoryName );
			}

			var text = builder.ToString();
			if( newLineLinux ) {
				text = text.Replace( "\r\n", "\n" );
			}

			if( utf8bom )
				File.WriteAllText( fname, text, Encoding.UTF8 );
			else
				File.WriteAllText( fname, text );
			if( autoRefresh ) {
				AssetDatabase.Refresh( ImportAssetOptions.ImportRecursive );
			}
		}
	}
}

#endif
