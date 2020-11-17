using Hananoki.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;

namespace Hananoki {
	public static class EditorLocalize {
		public static Dictionary<string, EditorLocalizeDictionary> s_dic;

		public static System.Collections.Hashtable s_dic2;

		public static EditorLocalizeDictionary GetPakage( string packageName ) => s_dic[ packageName ];

		public static EditorLocalizeDictionary Load( string packageName, string loadGUID, string defaultGUID ) {
			if( s_dic == null ) {
				s_dic = new Dictionary<string, EditorLocalizeDictionary>();
			}
			
			if( s_dic2 == null ) {
				s_dic2 = new System.Collections.Hashtable();
				s_dic2.Add( "af", "Afrikaans (af)" );
				s_dic2.Add( "ar", "Arabic (ar)" );
				s_dic2.Add( "eu", "Basque (eu)" );
				s_dic2.Add( "be", "Belarusian (be)" );
				s_dic2.Add( "bg", "Bulgarian (bg)" );
				s_dic2.Add( "ca", "Catalan (ca)" );
				s_dic2.Add( "cs", "Czech (cs)" );
				s_dic2.Add( "da", "Danish (da)" );
				s_dic2.Add( "nl", "Dutch (nl)" );
				s_dic2.Add( "en", "English (en)" );
				s_dic2.Add( "en-US", "English (en)" );
				s_dic2.Add( "et", "Estonian (et)" );
				s_dic2.Add( "fi", "Finnish (fi)" );
				s_dic2.Add( "fr", "French (fr)" );
				s_dic2.Add( "de", "German (de)" );
				s_dic2.Add( "el", "Greek (el)" );
				s_dic2.Add( "he", "Hebrew (he)" );
				s_dic2.Add( "is", "Icelandic (is)" );
				s_dic2.Add( "id", "Indonesian (id)" );
				s_dic2.Add( "it", "Italian (it)" );
				s_dic2.Add( "ja", "Japanese (ja)" );
				s_dic2.Add( "ja-JP", "Japanese (ja)" );
				s_dic2.Add( "ko", "Korean (ko)" );
				s_dic2.Add( "lv", "Latvian (lv)" );
				s_dic2.Add( "lt", "Lithuanian (lt)" );
				s_dic2.Add( "no", "Norwegian (no)" );
				s_dic2.Add( "pl", "Polish (pl)" );
				s_dic2.Add( "pt", "Portuguese (pt)" );
				s_dic2.Add( "ro", "Romanian (ro)" );
				s_dic2.Add( "ru", "Russian (ru)" );
				s_dic2.Add( "sk", "Slovak (sk)" );
				s_dic2.Add( "sl", "Slovenian (sl)" );
				s_dic2.Add( "es", "Spanish (es)" );
				s_dic2.Add( "sv", "Swedish (sv)" );
				s_dic2.Add( "th", "Thai (th)" );
				s_dic2.Add( "tr", "Turkish (tr)" );
				s_dic2.Add( "uk", "Ukrainian (uk)" );
				s_dic2.Add( "vi", "Vietnamese (vi)" );
				s_dic2.Add( "zh-CN", "ChineseSimplified (zh-CN)" );
				s_dic2.Add( "zh-TW", "ChineseTraditional (zh-TW)" );
				s_dic2.Add( "hu", "Hungarian (hu)" );
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
			return GUIDUtils.GetAssetPath( Hananoki.SharedModule.SettingsEditor.i.language ).FileName();
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


	[AttributeUsage( AttributeTargets.Class )]
	public class SettingsClass : Attribute { }

	[AttributeUsage( AttributeTargets.Method )]
	public class SettingsMethod : Attribute { }
}