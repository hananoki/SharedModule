using HananokiRuntime.Extensions;
using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityObject = UnityEngine.Object;


namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {

		public static string quote( this string s ) {
			return '"' + s + '"';
		}
		public static string separatorToOS( this string s ) {
			return s.Replace( '/', Path.DirectorySeparatorChar );
		}

		public static string separatorToSlash( this string s ) {
			return s.Replace( Path.DirectorySeparatorChar, '/' );
		}


		/// <summary>
		/// 入力パスをいい感じのディレクトリ名にする
		/// </summary>
		public static string PrettyDirectoryName( this string s ) {
			s = s.TrimEnd( '/', '\\' );
			s = s.FileToDirectory();
			s = s.separatorToSlash();
			return s;
		}


		/// <summary>
		/// 絶対パスを相対パスに変換
		/// </summary>
		/// <returns></returns>
		public static string ToRelativePath( this string s ) {
			Uri u1 = new Uri( Environment.CurrentDirectory );
			Uri u2 = new Uri( s );
			return u1.MakeRelativeUri( u2 ).ToString();
		}


		public static string nicify( this string s ) {
			return ObjectNames.NicifyVariableName( s );
		}

		public static string stringModify( this string s1 ) {
			s1 = s1.Replace( " ", "" );
			s1 = s1.Replace( "-", "_" );
			s1 = s1.Replace( ".", "_" );
			s1 = s1.Replace( "&", "_" );
			s1 = s1.Replace( ",", "_" );
			s1 = s1.Replace( "?", "_" );
			s1 = s1.Replace( "[", "_" );
			s1 = s1.Replace( "]", "_" );
			s1 = s1.Replace( "(", "_" );
			s1 = s1.Replace( ")", "_" );
			s1 = s1.Replace( "+", "_" );
			s1 = s1.Replace( "\"", "_" );
			s1 = s1.Replace( "$", "_" );
			s1 = s1.Replace( "…", "_" );
			s1 = s1.Replace( "#", "Sharp" );
			s1 = s1.Replace( "！", "_" );
			s1 = s1.Replace( "「", "_" );
			s1 = s1.Replace( "」", "_" );
			s1 = s1.Replace( "？", "_" );

			return s1;
		}

		public static int toInt( this string s ) {
			return int.Parse( s );
		}

		public static string ToStringLower( this object obj ) {
			return obj.ToString().ToLower();
		}

		public static GUIContent content( this string s ) {
			return new GUIContent( s );
		}
		public static GUIContent content( this Texture2D s ) {
			return new GUIContent( s );
		}

		public static GUIContent contentTemp( this string s ) {
			return EditorHelper.TempContent( s, s );
		}

		public static Texture2D GetCachedIcon( this string s ) {
			return (Texture2D) AssetDatabase.GetCachedIcon( s );
		}



		/// <summary>
		/// GUIDからアセットパスを取得します
		/// </summary>
		/// <param name="guid">GUID</param>
		/// <returns></returns>
		public static string ToAssetPath( this string guid_or_path ) {
			if( guid_or_path.IsEmpty() ) return string.Empty;
			if( guid_or_path.StartWithAssets() ) return guid_or_path;
			return AssetDatabase.GUIDToAssetPath( guid_or_path );
		}


		public static string ToGUID( this string guid_or_path ) {
			if( guid_or_path.IsEmpty() ) return string.Empty;
			if( guid_or_path.StartWithAssets() ) return AssetDatabase.AssetPathToGUID( guid_or_path );
			return guid_or_path;
		}

		public static string ToFullPath( this string path ) => Path.GetFullPath( path );



		public static string[] GetFilesFromAssetPath( this string assetPath ) {
			return DirectoryUtils.GetFiles( assetPath, "*", SearchOption.AllDirectories )
				.Where( x => !x.EndsWith( ".meta" ) )
				.ToArray();
		}

		public static string[] GetFilesFromAssetGUID( this string guid ) {
			return GetFilesFromAssetPath( guid.ToAssetPath() );
		}


		/////////////////////////////////////////
		public static bool StartWithAssets( this string assetPath ) {
			if( assetPath.IsEmpty() ) return false;
			if( assetPath[ 1 ] == 's' || assetPath[ 1 ] == 'S' ) return true; // Assets
			if( assetPath[ 0 ] == 'P' || assetPath[ 0 ] == 'p' ) return true; // Package
			return false;
		}

		/////////////////////////////////////////
		public static bool StartWithResource( this string assetPath ) {
			if( assetPath.IsEmpty() ) return false;
			if( assetPath[ 0 ] == 'R' || assetPath[ 0 ] == 'r' ) return true; // Resource
			return false;
		}

		/////////////////////////////////////////
		public static bool StartWithPackage( this string assetPath ) {
			if( assetPath.IsEmpty() ) return false;
			if( assetPath[ 0 ] == 'P' || assetPath[ 0 ] == 'p' ) return true; // Package
			return false;
		}


		/////////////////////////////////////////
		public static Type GetAssetType( this string guid_or_path ) {
			var assetPath = guid_or_path.ToAssetPath();
			if( assetPath.IsEmpty() ) return null;
			try {
				return AssetDatabase.GetMainAssetTypeAtPath( assetPath );
			}
			catch( Exception e ) {
				Debug.LogException( e );
				Debug.Log( assetPath );
			}
			return null;
		}


		/////////////////////////////////////////
		public static UnityObject LoadAsset( this string s ) => LoadAsset<UnityObject>( s );

		public static T LoadAsset<T>( this string s ) where T : UnityObject {
			return (T) LoadAsset( s, typeof( T ) );
		}

		public static UnityObject LoadAsset( this string s, Type t ) {
			if( s.IsEmpty() ) return null;
			if( s.StartWithAssets() ) return AssetDatabase.LoadAssetAtPath( s, t );

			return AssetDatabaseUtils.LoadAssetAtGUID( s, t );
		}



		/////////////////////////////////////////
		public static UnityObject[] LoadAllAssets( this string s ) {
			if( s.StartWithAssets() ) return AssetDatabase.LoadAllAssetsAtPath( s );

			return AssetDatabase.LoadAllAssetsAtPath( s.ToAssetPath() );
		}


		public static UnityObject[] LoadAllSubAssets( this string s ) {
			return AssetDatabaseUtils.LoadAllSubAssets( s );
		}


		public static Vector2 CalcSizeFromLabel( this string s ) {
			return CalcSize( s, EditorStyles.label );
		}

		public static Vector2 CalcSize( this string s, GUIStyle style ) {
			return style.CalcSize( EditorHelper.TempContent( s ) );
		}

		public static string GenerateUniqueAssetPath( this string s ) {
			return AssetDatabase.GenerateUniqueAssetPath( s );
		}


		public static string FileNameWithoutExtension( this string s ) {
			if( s.IsEmpty() ) return string.Empty;
			return Path.GetFileNameWithoutExtension( s );
		}

		public static string DirectoryName( this string s ) {
			if( s.IsEmpty() ) return string.Empty;
			return Path.GetDirectoryName( s );
		}

		public static string FileName( this string s ) {
			if( s.IsEmpty() ) return string.Empty;
			return Path.GetFileName( s );
		}

		public static string Extension( this string s ) {
			if( s.IsEmpty() ) return string.Empty;
			return Path.GetExtension( s );
		}

		public static string GetExtension( this string s ) {
			if( s.IsEmpty() ) return string.Empty;
			return Path.GetExtension( s );
		}

		public static string GetDirectory( this string s ) {
			if( s.IsEmpty() ) return string.Empty;
			return Path.GetDirectoryName( s );
		}

		public static string TryReplace( this string s, string oldValue, string newValue ) {
			if( s.IsEmpty() ) return string.Empty;
			return s.Replace( oldValue, newValue );
		}


		/// <summary>
		/// 引数で渡した拡張子であるかどうかを判定します
		/// </summary>
		/// <param name="s"></param>
		/// <param name="ext">拡張子 (.は付けてもつけなくてもよい)</param>
		/// <returns></returns>
		public static bool HasExtention( this string s, string ext ) {
			return s.EndsWith( ext );
		}


		public static bool IsExistsFile( this string s ) {
			return File.Exists( s );
		}

		public static bool IsExistsDirectory( this string s ) {
			return Directory.Exists( s );
		}

		public static string FileToDirectory( this string s ) {
			if( s.IsExistsFile() ) {
				s = s.DirectoryName();
			}
			return s;
		}


		public static T FromJson<T>( this string path ) where T : class {
			var json = path.ReadAllText();
			if( json.IsEmpty() ) return null;
			return JsonUtility.FromJson<T>( json );
		}

		public static string ReadAllText( this string path ) {
			if( !path.IsExistsFile() ) return string.Empty;
			return fs.ReadAllText( path );
		}

		public static void WriteAllText( this string path, string contents ) {
			//if( !path.IsExistsFile() ) return string.Empty;
			fs.WriteAllText( path, contents );
		}


		public static void ExecuteMenuItem( this string path ) {
			EditorApplication.ExecuteMenuItem( path );
		}


		public static Type TypeGetType( this string s ) {
			return s.IsEmpty() ? null : Type.GetType( s );
		}
	}
}
