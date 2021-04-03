#define ENABLE_HANANOKI_SETTINGS

#if ENABLE_HANANOKI_SETTINGS
#pragma warning disable 618
#endif

using HananokiEditor.Extensions;
using HananokiRuntime;
using HananokiRuntime.Extensions;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

using E = HananokiEditor.SharedModule.SettingsEditor;

namespace HananokiEditor.SharedModule {
	[InitializeOnLoad]
	[Serializable]
	public class SettingsEditor {
		public string LCID;
		//public string language;
		public Color selectionColor = Color.white;

		public bool m_asmdefNameSync;
		public bool m_asmdefAutoReferenceOFF;
		public bool m_disableSyncVS;
		public bool m_windowShade;


		public string projectSettingsPath;
		string projectSettingsPathCache;

		public string GetProjectSettingsPath() {
			if( projectSettingsPath.Contains( "ProjectSettings" ) ) return "ProjectSettings";
			try {
				var _dir = projectSettingsPath.ToAssetPath();
				projectSettingsPathCache = _dir;
			}
			catch( UnityException ) {
			}
			catch( Exception e ) {
				Debug.LogException( e );
			}
			if( projectSettingsPathCache.IsExistsDirectory() ) return projectSettingsPathCache;
			return ".";
		}

#if ENABLE_HANANOKI_SETTINGS
		public SettingsWindow.Mode selectSettingMode;
#endif
		public EditorColor versionTextColor = new EditorColor( ColorUtils.RGB( 72 ), ColorUtils.RGB( 173 ) );
		public EditorColor versionBackColor = new EditorColor( ColorUtils.RGB( 242 ), ColorUtils.RGB( 41 ) );
		//public bool utilityWindow;


		public List<UtilityWindowSettingsData> utilityWindowSettingsData;
		public CSPFileData m_CSPFileData;

		public static E i;
		static List<MethodInfo> s_localizeEvent;


		static SettingsEditor() {
			//var lst = PlayerSettingsUtils.GetScriptingDefineSymbolsAtList();
			//if( lst.IndexOf( "ENABLE_HANANOKI_SETTINGS" ) < 0 ) {
			//	Debug.Log( "SetScriptingDefineSymbols: ENABLE_HANANOKI_SETTINGS ... 1.7.1 or later required" );
			//	lst.Add( "ENABLE_HANANOKI_SETTINGS" );
			//	PlayerSettingsUtils.SetScriptingDefineSymbols( lst );
			//}
			Load();
		}



		public static void Load() {
			if( i != null ) return;

			i = EditorPrefJson<E>.Get( Package.editorPrefName );
			if( i.LCID.IsEmpty() ) {
				i.LCID = "en-US";
			}
			if( i.projectSettingsPath.IsEmpty() ) {
				i.projectSettingsPath = "6763de3f012135f439fea4e446738691";
			}

			Helper.New( ref i.utilityWindowSettingsData );
			//if( i.utilityWindowSettingsData == null ) i.utilityWindowSettingsData = new List<UtilityWindowSettingsData>();
			s_localizeEvent = null;
			LoadLocalize();
		}



		public static void Save() {
			EditorPrefJson<E>.Set( Package.editorPrefName, i );
		}



		public static string projectSettingDirectory => E.i.GetProjectSettingsPath();



		public static void LoadLocalize() {
			EditorLocalize.Load( Package.name, "95cedfc7731853946b0b3650f175d73a", E.i.LCID );

			if( s_localizeEvent == null ) {
				s_localizeEvent = new List<MethodInfo>( 64 );
				s_localizeEvent.AddRange( AssemblieUtils.GetAllMethodsWithAttribute<HananokiEditorLocalizeRegister>() );
			}
			foreach( var m in s_localizeEvent ) {
				try {
					m.Invoke( null, null );
				}
				catch( Exception ) {
				}
			}
			HEditorWindow.RepaintWindow( typeof( EditorWindow ) );
		}


		public static bool IsUtilityWindow( Type windowType ) {
			Load();
			foreach( var p in i.utilityWindowSettingsData ) {
				if( windowType == p.GetUtilityType() ) {
					return p.Enable;
				}
			}
			return false;
		}
	}

}
