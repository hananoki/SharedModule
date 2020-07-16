
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Hananoki.Extensions {
	public static partial class EditorExtensions {

		public static string quote( this string s ) {
			return '"' + s + '"';
		}

		public static string pathSeparator( this string s ) {
			return s.Replace( '/', '\\' );
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
			s1 = s1.Replace( "…", "_" );
			s1 = s1.Replace( "#", "Sharp" );
			s1 = s1.Replace( "！", "_" );


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


		public static string GenerateUniqueAssetPath( this string s ) {
			return AssetDatabase.GenerateUniqueAssetPath( s );
		}


		public static string FileNameWithoutExtension( this string s ) {
			return Path.GetFileNameWithoutExtension( s );
		}

		public static string DirectoryName( this string s ) {
			return Path.GetDirectoryName( s );
		}

		public static string FileName( this string s ) {
			return Path.GetFileName( s );
		}

		public static string Extension( this string s ) {
			return Path.GetExtension( s );
		}

		public static string GetExtension( this string s ) {
			return Path.GetExtension( s );
		}

		public static string GetDirectory( this string s ) {
			if( s == "" ) return "";
			return Path.GetDirectoryName( s );
		}

		public static string TryReplace( this string s, string oldValue, string newValue ) {
			if( s == null ) return string.Empty;
			return s.Replace( oldValue, newValue );
		}

		public static string colorTag( this string s, string color ) {
			return "<color=" + s + ">" + s + "</color>";
		}


		/// <summary>
		/// スネークケースをアッパーキャメル(パスカル)ケースに変換します
		/// 例) quoted_printable_encode → QuotedPrintableEncode
		/// </summary>
		//public static string SnakeToUpperCamel( this string self ) {
		//	if( string.IsNullOrEmpty( self ) ) return self;

		//	return self
		//			.Split( new[] { '_' }, StringSplitOptions.RemoveEmptyEntries )
		//			.Select( s => char.ToUpperInvariant( s[ 0 ] ) + s.Substring( 1, s.Length - 1 ) )
		//			.Aggregate( string.Empty, ( s1, s2 ) => s1 + s2 )
		//	;
		//}

		/// <summary>
		/// スネークケースをローワーキャメル(キャメル)ケースに変換します
		/// 例) quoted_printable_encode → quotedPrintableEncode
		/// </summary>
		//public static string SnakeToLowerCamel( this string self ) {
		//	if( string.IsNullOrEmpty( self ) ) return self;

		//	return self
		//			.SnakeToUpperCamel()
		//			.Insert( 0, char.ToLowerInvariant( self[ 0 ] ).ToString() ).Remove( 1, 1 )
		//	;
		//}
	}
}
