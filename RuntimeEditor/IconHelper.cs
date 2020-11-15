﻿
using Hananoki.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Hananoki {
	public class EditorResourceIcon {
		static Dictionary<int, Texture2D> icons;
		public string[] i;

		public EditorResourceIcon( string[] i ) {
			this.i = i;
		}

		public Texture2D Get( int n ) {
			if( icons == null ) {
				icons = new Dictionary<int, Texture2D>();
			}
			bool load = false;
			if( !icons.ContainsKey( n ) ) load = true;
			else if( icons[ n ] == null ) load = true;
			if( load ) {
				//for( int i = 0; i < SharedEmbed.num; i++ ) {
				//if( SharedEmbed.n[ i ] != s ) continue;
				var bb = B64.Decode( "iVBORw0KGgoAAAAN" + i[ n ] );
				const int wOff = 16;
				const int hOff = 20;
				var Widht = BitConverter.ToInt32( new[] { bb[ wOff + 3 ], bb[ wOff + 2 ], bb[ wOff + 1 ], bb[ wOff + 0 ], }, 0 );
				var Height = BitConverter.ToInt32( new[] { bb[ hOff + 3 ], bb[ hOff + 2 ], bb[ hOff + 1 ], bb[ hOff + 0 ], }, 0 );

				var t = new Texture2D( Widht, Height );
				t.LoadImage( bb );
				t.hideFlags |= HideFlags.DontUnloadUnusedAsset;
				if( icons.ContainsKey( n ) ) {
					icons[ n ] = t;
				}
				else {
					icons.Add( n, t );
				}
				//}
			}
			return icons[ n ];
		}
	}

#if false

	public class __EditorResourceIcon {
		string guid;
		Dictionary<string, Texture2D> icons;

		public __EditorResourceIcon( string guid ) {
			this.guid = guid;
		}

		public Texture2D Get( string s ) {
			if( icons == null ) {
				icons = new Dictionary<string, Texture2D>();
			}
			bool load = false;
			if( !icons.ContainsKey( s ) ) load = true;
			else if( icons[ s ] == null ) load = true;

			if( load ) {
				var loadAssets = AssetDatabase.LoadAllAssetsAtPath( guid.GetAssetPathAtGUID() );
				foreach( var p in loadAssets ) {
					if( p.GetType() != typeof( EditorResourceBinary ) ) continue;

					var pp = (EditorResourceBinary) p;
					if( pp.name != s ) continue;

					const int wOff = 16;
					const int hOff = 20;
					if( pp.m_Bytes.IsEmpty() ) continue;

					var Widht = BitConverter.ToInt32( new[] { pp.m_Bytes[ wOff + 3 ], pp.m_Bytes[ wOff + 2 ], pp.m_Bytes[ wOff + 1 ], pp.m_Bytes[ wOff + 0 ], }, 0 );
					var Height = BitConverter.ToInt32( new[] { pp.m_Bytes[ hOff + 3 ], pp.m_Bytes[ hOff + 2 ], pp.m_Bytes[ hOff + 1 ], pp.m_Bytes[ hOff + 0 ], }, 0 );

					var t = new Texture2D( Widht, Height );
					t.LoadImage( pp.m_Bytes );
					t.hideFlags |= HideFlags.DontUnloadUnusedAsset;
					t.hideFlags |= HideFlags.HideInHierarchy;
					t.hideFlags |= HideFlags.HideInInspector;
					if( icons.ContainsKey( s ) ) {
						icons[ s ] = t;
					}
					else {
						icons.Add( s, t );
					}
				}
			}
			Texture2D tex = null;
			icons.TryGetValue( s, out tex );
			return tex;
		}
	}

#endif


	/// <summary>
	/// 
	/// </summary>
	public static class Icon {
		static Dictionary<string, Texture2D> s_iconCache;

		/// <summary>
		/// 
		/// </summary>
		static Icon() {
			s_iconCache = new Dictionary<string, Texture2D>();
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

			try {
				icon = EditorGUIUtility.FindTexture( name ) as Texture2D;
				if( icon != null ) {
					s_iconCache.Add( name, icon );
					return icon;
				}
			}
			catch( Exception ) {
			}

			try {
				Texture2D iconz = EditorGUIUtility.Load( name ) as Texture2D;
				//var iconz = EditorGUIUtility.IconContent( name ).image as Texture2D;
				if( iconz != null ) {
					s_iconCache.Add( name, iconz );
					return iconz;
				}
			}
			catch( Exception ) {
			}

			try {
				Texture2D iconz = EditorGUIUtility.Load( "icons/" + name + ".png" ) as Texture2D;
				//var iconz = EditorGUIUtility.IconContent( name ).image as Texture2D;
				if( iconz != null ) {
					s_iconCache.Add( name, iconz );
					return iconz;
				}
			}
			catch( Exception ) {
			}

			try {
				Texture2D iconz = EditorGUIUtility.Load( name ) as Texture2D;
				//var iconz = EditorGUIUtility.IconContent( name ).image as Texture2D;
				if( iconz != null ) {
					s_iconCache.Add( name, iconz );
					return iconz;
				}
			}
			catch( Exception ) {
			}

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
			return null;
		}
	}
}
