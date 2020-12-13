using HananokiEditor.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;

using E = HananokiEditor.SharedModule.SettingsEditor;

namespace HananokiEditor {

	public static class EditorLocalize {

		public class LCIDString {
			public string LCID;
			public string NAME;
		}

		public static List<LCIDString> s_lcidTable;
		public static Dictionary<string, EditorLocalizeData> s_editorLocalizeData;

		public static EditorLocalizeData GetPakage( string packageName ) => s_editorLocalizeData[ packageName ];

		static void MakePopup() {
			if( s_lcidTable != null ) return;

			s_lcidTable = new List<LCIDString>();
			s_lcidTable.Add( new LCIDString { LCID = "af", NAME = "Afrikaans (af)" } );
			s_lcidTable.Add( new LCIDString { LCID = "ar", NAME = "Arabic (ar)" } );
			s_lcidTable.Add( new LCIDString { LCID = "eu", NAME = "Basque (eu)" } );
			s_lcidTable.Add( new LCIDString { LCID = "be", NAME = "Belarusian (be)" } );
			s_lcidTable.Add( new LCIDString { LCID = "bg", NAME = "Bulgarian (bg)" } );
			s_lcidTable.Add( new LCIDString { LCID = "ca", NAME = "Catalan (ca)" } );
			s_lcidTable.Add( new LCIDString { LCID = "cs", NAME = "Czech (cs)" } );
			s_lcidTable.Add( new LCIDString { LCID = "da", NAME = "Danish (da)" } );
			s_lcidTable.Add( new LCIDString { LCID = "nl", NAME = "Dutch (nl)" } );
			//s_dic2.Add( "en", "English (en)" );
			s_lcidTable.Add( new LCIDString { LCID = "en-US", NAME = "English (en)" } );
			s_lcidTable.Add( new LCIDString { LCID = "et", NAME = "Estonian (et)" } );
			s_lcidTable.Add( new LCIDString { LCID = "fi", NAME = "Finnish (fi)" } );
			s_lcidTable.Add( new LCIDString { LCID = "fr", NAME = "French (fr)" } );
			s_lcidTable.Add( new LCIDString { LCID = "de", NAME = "German (de)" } );
			s_lcidTable.Add( new LCIDString { LCID = "el", NAME = "Greek (el)" } );
			s_lcidTable.Add( new LCIDString { LCID = "he", NAME = "Hebrew (he)" } );
			s_lcidTable.Add( new LCIDString { LCID = "is", NAME = "Icelandic (is)" } );
			s_lcidTable.Add( new LCIDString { LCID = "id", NAME = "Indonesian (id)" } );
			s_lcidTable.Add( new LCIDString { LCID = "it", NAME = "Italian (it)" } );
			//s_dic2.Add( "ja", "Japanese (ja)" );
			s_lcidTable.Add( new LCIDString { LCID = "ja-JP", NAME = "Japanese (ja)" } );
			s_lcidTable.Add( new LCIDString { LCID = "ko", NAME = "Korean (ko)" } );
			s_lcidTable.Add( new LCIDString { LCID = "lv", NAME = "Latvian (lv)" } );
			s_lcidTable.Add( new LCIDString { LCID = "lt", NAME = "Lithuanian (lt)" } );
			s_lcidTable.Add( new LCIDString { LCID = "no", NAME = "Norwegian (no)" } );
			s_lcidTable.Add( new LCIDString { LCID = "pl", NAME = "Polish (pl)" } );
			s_lcidTable.Add( new LCIDString { LCID = "pt", NAME = "Portuguese (pt)" } );
			s_lcidTable.Add( new LCIDString { LCID = "ro", NAME = "Romanian (ro)" } );
			s_lcidTable.Add( new LCIDString { LCID = "ru", NAME = "Russian (ru)" } );
			s_lcidTable.Add( new LCIDString { LCID = "sk", NAME = "Slovak (sk)" } );
			s_lcidTable.Add( new LCIDString { LCID = "sl", NAME = "Slovenian (sl)" } );
			s_lcidTable.Add( new LCIDString { LCID = "es", NAME = "Spanish (es)" } );
			s_lcidTable.Add( new LCIDString { LCID = "sv", NAME = "Swedish (sv)" } );
			s_lcidTable.Add( new LCIDString { LCID = "th", NAME = "Thai (th)" } );
			s_lcidTable.Add( new LCIDString { LCID = "tr", NAME = "Turkish (tr)" } );
			s_lcidTable.Add( new LCIDString { LCID = "uk", NAME = "Ukrainian (uk)" } );
			s_lcidTable.Add( new LCIDString { LCID = "vi", NAME = "Vietnamese (vi)" } );
			s_lcidTable.Add( new LCIDString { LCID = "zh-CN", NAME = "ChineseSimplified (zh-CN)" } );
			s_lcidTable.Add( new LCIDString { LCID = "zh-TW", NAME = "ChineseTraditional (zh-TW)" } );
			s_lcidTable.Add( new LCIDString { LCID = "hu", NAME = "Hungarian (hu)" } );
		}


		public static EditorLocalizeData Load( string packageName, string localizeDir ) {
			return Load( packageName, localizeDir, E.i.LCID );
		}


		public static EditorLocalizeData Load( string packageName, string localizeDir, string LCID ) {
			if( s_editorLocalizeData == null ) {
				s_editorLocalizeData = new Dictionary<string, EditorLocalizeData>();
			}

			MakePopup();

			var fname = $"{localizeDir.ToAssetPath()}/{LCID}.csv";
			//var strings = EditorHelper.LoadSerializedFileAtName<EditorLocalizeDataOld>( fname, LCID );
			var strings = EditorLocalizeData.Load( fname );

			if( s_editorLocalizeData.ContainsKey( packageName ) ) {
				s_editorLocalizeData[ packageName ] = strings;
			}
			else {
				s_editorLocalizeData.Add( packageName, strings );
			}
			return strings;
		}
	}
	

	
}