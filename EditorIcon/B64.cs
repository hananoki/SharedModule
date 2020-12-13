
using HananokiRuntime.Extensions;
using System.IO;
using UnityEditor;

using static System.Convert;
using UnityObject = UnityEngine.Object;

namespace HananokiEditor {
	public static class B64 {
		public static string Encode( UnityObject obj ) {
			if( obj == null ) return string.Empty;
			return Encode( AssetDatabase.GetAssetPath( obj ) );
		}
		public static string Encode( string filePath ) {
			if( filePath.IsEmpty() ) return string.Empty;

			return ToBase64String( File.ReadAllBytes( filePath ) );
		}

		public static byte[] Decode( string base64Str ) {
			return FromBase64String( base64Str );
		}
	}
}
