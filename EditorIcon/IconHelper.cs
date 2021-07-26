using HananokiRuntime.Extensions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityReflection;


namespace HananokiEditor {

	public static class Icon {

		static Dictionary<string, Texture2D> s_iconCache;

		public static Texture2D iconFailed => AssetDatabase.LoadAssetAtPath<Texture2D>( AssetDatabase.GUIDToAssetPath( "39bd12b4c648ffa45b5dcbe9874af5d4" ) );



		static Icon() {
			s_iconCache = new Dictionary<string, Texture2D>();
		}


		public static Texture2D GetOrLoadFromBuiltin( string iconName ) {
			if( iconName.IsEmpty() ) return null;
			Texture2D tex = null;
			s_iconCache.TryGetValue( iconName, out tex );
			if( tex == null ) {
				//Debug.Log( iconName );
				tex = UnityEditorEditorGUIUtility.LoadIcon( iconName );
				if( tex == null ) return null;
				s_iconCache.Add( iconName, tex );
			}
			return tex;
		}


		public static Texture2D Get( string lightskin, string darkskin ) {
			if( EditorGUIUtility.isProSkin ) {
				return Get( darkskin );
			}
			return Get( lightskin );
		}

		public static Texture2D GetPackageManagerIcon( string name ) {
			if( EditorGUIUtility.isProSkin ) {
				return Get( $"icons/packagemanager/dark/{name}.png" );
			}

			return Get( $"icons/packagemanager/light/{name}.png" );
		}


		public static Texture2D GetBuiltinSKins( string name ) {
			if( EditorGUIUtility.isProSkin ) {
				return GetOrLoadFromBuiltin( $"builtin skins/darkskin/images/{name}.png" );
			}

			return GetOrLoadFromBuiltin( $"builtin skins/lightskin/images/{name}.png" );
		}


		public static string GetBuiltinPath( string path ) {
			var paths = path.Split( '/' );
			if( EditorGUIUtility.isProSkin ) {
				paths[ paths.Length - 1 ] = "d_" + paths[ paths.Length - 1 ];
			}

			return string.Join( "/", paths );
		}

		public static Texture2D GetBuiltin( string path ) {
			if( EditorGUIUtility.isProSkin ) {
				var icon = Get( GetBuiltinPath( path ) );
				if( icon != null ) return icon;
			}
			return Get( path );
		}



		public static Texture2D Get( string name ) {
			if( s_iconCache.ContainsKey( name ) ) {
				return s_iconCache[ name ];
			}
			if( name.IsEmpty() ) return null;

			Texture2D icon;

			//try {
			//	icon = EditorGUIUtility.FindTexture( name ) as Texture2D;
			//	if( icon != null ) {
			//		s_iconCache.Add( name, icon );
			//		return icon;
			//	}
			//}
			//catch( Exception ) {
			//}

			//try {
			//	Texture2D iconz = EditorGUIUtility.Load( name ) as Texture2D;
			//	//var iconz = EditorGUIUtility.IconContent( name ).image as Texture2D;
			//	if( iconz != null ) {
			//		s_iconCache.Add( name, iconz );
			//		return iconz;
			//	}
			//}
			//catch( Exception ) {
			//}

			//try {
			//	Texture2D iconz = EditorGUIUtility.Load( "icons/" + name + ".png" ) as Texture2D;
			//	//var iconz = EditorGUIUtility.IconContent( name ).image as Texture2D;
			//	if( iconz != null ) {
			//		s_iconCache.Add( name, iconz );
			//		return iconz;
			//	}
			//}
			//catch( Exception ) {
			//}

			//try {
			//	Texture2D iconz = EditorGUIUtility.Load( name ) as Texture2D;
			//	//var iconz = EditorGUIUtility.IconContent( name ).image as Texture2D;
			//	if( iconz != null ) {
			//		s_iconCache.Add( name, iconz );
			//		return iconz;
			//	}
			//}
			//catch( Exception ) {
			//}

			var a = AssetDatabase.FindAssets( "Icons" );
			foreach( var b in a ) {
				var v = AssetDatabase.GUIDToAssetPath( b );
				var vv = Path.GetExtension( v );
				if( !string.IsNullOrEmpty( vv ) ) continue;

				icon = AssetDatabase.LoadAssetAtPath<Texture2D>( v + "/" + name + ".png" );
				if( icon != null ) {
					//UnityEngine.Debug.Log( "m_iconCache: add: " + name );
					s_iconCache.Add( name, icon );
					return icon;
				}
			}

			{
				var lst = Resources.FindObjectsOfTypeAll<Texture2D>().Where( x => x.name.Contains( name ) ).ToArray();
				if( 0 < lst.Length ) {
					s_iconCache.Add( name, lst[ 0 ] );
					return lst[ 0 ];
				}
			}

			if( s_iconCache.ContainsKey( "icon_failed" ) ) {
				return s_iconCache[ "icon_failed" ];
			}
			s_iconCache.Add( name, iconFailed );
#if HANANOKI_DEBUG
			Debug.Log( $"icon not found {name}." );
#endif
			return null;
		}

	}

}
