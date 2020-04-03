using Hananoki.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;

namespace Hananoki {
	public static class EditorLocalize {
		public static Dictionary<string, EditorLocalizeDictionary> s_dic;

		public static EditorLocalizeDictionary GetPakage( string packageName ) => s_dic[ packageName ];

		public static EditorLocalizeDictionary Load( string packageName, string loadGUID, string defaultGUID ) {
			if( s_dic == null ) {
				s_dic = new Dictionary<string, EditorLocalizeDictionary>();
			}

			var _localize = new EditorLocalizeDictionary();
			_localize.Load( loadGUID.IsEmpty() ? defaultGUID : loadGUID );

			if( s_dic.ContainsKey( packageName ) ) {
				s_dic[ packageName ] = _localize;
			}
			else {
				s_dic.Add( packageName, _localize );
			}
			return _localize;
		}

		public static string GetLocalizeName() {
			return GUIDUtils.GetAssetPath( Hananoki.SharedModule.SharedPreference.i.language ).FileName();
		}

		public static string Tr( EditorLocalizeDictionary _localize, string s ) {
			if( _localize == null ) return s;
			if( _localize.m_dic.ContainsKey( s ) ) {
				return _localize.m_dic[ s ];
			}
			return s;
		}

		public static string[] Tr( EditorLocalizeDictionary _localize, string[] ss ) {
			if( _localize == null ) return ss;
			var lst = new List<string>();
			foreach( var s in ss ) {
				if( _localize.m_dic.ContainsKey( s ) ) {
					lst.Add( _localize.m_dic[ s ] );
				}
				else {
					lst.Add( s );
				}
			}
			return lst.ToArray();
		}
	}



	public class EditorLocalizeDictionary {

		public Dictionary<string, string> m_dic = new Dictionary<string, string>();

		public void Load( string guid ) {
			var filepPath = AssetDatabase.GUIDToAssetPath( guid );
			m_dic = new Dictionary<string, string>();
			if( File.Exists( filepPath ) ) {
				var ss = File.ReadAllText( filepPath ).Split( '\n' );
				for( int i = 0; i < ss.Length; i++ ) {
					var s = ss[ i ];
					s = s.TrimEnd( '\r' );
					if( string.IsNullOrEmpty( s ) ) continue;
					if( s[ 0 ] == '#' ) continue;

					var sss = s.Split( '	' );
					if( sss.Length == 2 ) {
						m_dic.Add( sss[ 0 ], sss[ 1 ] );
					}
				}
			}
		}
	}


	[AttributeUsage( AttributeTargets.Class )]
	public class EditorLocalizeClass : Attribute { }

	[AttributeUsage( AttributeTargets.Method )]
	public class EditorLocalizeMethod : Attribute { }
}