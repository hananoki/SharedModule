#define ENABLE_HANANOKI_SETTINGS

#if ENABLE_HANANOKI_SETTINGS
#pragma warning disable 618
#endif

using HananokiEditor.Extensions;
using HananokiRuntime;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

using E = HananokiEditor.SharedModule.SettingsEditor;
using SS = HananokiEditor.SharedModule.S;

namespace HananokiEditor.SharedModule {

	public class SettingsEditorWindowGUI {

		[HananokiSettingsRegister]
		public static SettingsItem RegisterSettings() {
			return new SettingsItem() {
				//mode = 1,
				displayName = Package.nameNicify,
				version = Package.version,
				gui = DrawGUI,
			};
		}


		public static string[] localeFilesPopup;
		public class Lang {
			public string file;
			public string popName;
		}
		public static List<Lang> localeFiles;

		public static List<EditorLocalize.LCIDString> m_localeNames;
		public static int m_localeIndex;



		public static void DrawGUI() {
			E.Load();

			HEditorGUILayout.HeaderTitle( SS._General );

			if( m_localeNames == null ) {
				m_localeNames = new List<EditorLocalize.LCIDString>();// EditorLocalize.s_lcidTable.OrderBy( x => x.NAME ).ToList();
				var files = "95cedfc7731853946b0b3650f175d73a".GetFilesFromAssetGUID().Select( x => x.FileNameWithoutExtension() ).ToList();
				foreach( var rp in files ) {
					var p = EditorLocalize.s_lcidTable.Find( x => x.LCID == rp );
					if( p == null ) continue;
					m_localeNames.Add( p );
				}
				m_localeNames = m_localeNames.OrderBy( x => x.NAME ).ToList();
			}

			ScopeChange.Begin();
			var idx = m_localeNames.FindIndex( x => x.LCID == E.i.LCID );
			if( idx < 0 ) {
				idx = m_localeNames.FindIndex( x => x.LCID == "en-US" );
			}
			idx = EditorGUILayout.Popup( S._Language, idx, m_localeNames.Select( x => x.NAME ).ToArray() );
			if( ScopeChange.End() ) {
				E.i.LCID = m_localeNames[ idx ].LCID;
				E.LoadLocalize();
				E.Save();
			}

			//////////////////////////////////

			ScopeChange.Begin();
			GUILayout.Space( 4 );
			var _versionTextColor = EditorGUILayout.ColorField( S._VersionTextColor, E.i.versionTextColor.value );

			var _versionBackColor = EditorGUILayout.ColorField( S._VersionBackColor, E.i.versionBackColor.value );

			var _windowShade = HEditorGUILayout.ToggleLeft( S._WindowShade, E.i.m_windowShade );

			var _uielementsFontFix = HEditorGUILayout.ToggleLeft( "UIElements Font Fix", E.i.m_uielementsFontFix );

			if( ScopeChange.End() ) {
				E.i.versionTextColor.value = _versionTextColor;
				E.i.versionBackColor.value = _versionBackColor;
				E.i.m_windowShade = _windowShade;
				E.i.m_uielementsFontFix = _uielementsFontFix;
				E.Save();
				EditorWindowUtils.RepaintProjectWindow();
			}

			//////////////////////////////////

			ScopeChange.Begin();

			GUILayout.Space( 8 );

			HEditorGUILayout.HeaderTitle( "AssetPostprocessor" );

			E.i.m_asmdefNameSync = HEditorGUILayout.ToggleLeft( S._MaketheNamefieldthesameasthefilenamewhenimportingasmdef, E.i.m_asmdefNameSync );
			ScopeDisable.Begin( true );
			E.i.m_asmdefAutoReferenceOFF = HEditorGUILayout.ToggleLeft( S._TurnoffAutoReferencedwhenimportingasmdef, E.i.m_asmdefAutoReferenceOFF );
			if( E.i.m_asmdefAutoReferenceOFF ) {
				E.i.m_asmdefAutoReferenceOFF = false;
				E.Save();
			}
			ScopeDisable.End();
			//E.i.m_disableSyncVS = HEditorGUILayout.ToggleLeft( "Kill SyncVS", E.i.m_disableSyncVS );
			//E.i.utilityWindow = EditorGUILayout.ToggleLeft( SS._UtilityWindowMode, E.i.utilityWindow );
			if( ScopeChange.End() ) E.Save();

			//////////////////////////////////
			GUILayout.Space( 8 );

			HEditorGUILayout.HeaderTitle( S._WheretosaveProjectsettings );

			HEditorGUILayout.PreviewFolder( E.i.GetProjectSettingsPath(), OnProjectFolderPreset );

			GUILayout.Space( 8f );
			ScopeHorizontal.Begin();
			GUILayout.FlexibleSpace();
			if( GUILayout.Button( SS._ReturnToDefault ) ) {
				E.i.versionTextColor = new EditorColor( ColorUtils.RGB( 72 ), ColorUtils.RGB( 173 ) );
				E.i.versionBackColor = new EditorColor( ColorUtils.RGB( 242 ), ColorUtils.RGB( 41 ) );
				//E.i.utilityWindow = false;
				E.Save();
			}
			ScopeHorizontal.End();

			//HGUILayout.LinkLabel( "hoge" );

			//#if ENABLE_HANANOKI_SETTINGS && LOCAL_TEST
			//			using( new GUILayout.HorizontalScope() ) {
			//				GUILayout.FlexibleSpace();
			//				if( GUILayout.Button( "Open Settings" ) ) {
			//					SettingsWindow.Open();
			//				}
			//			}
			//#endif
		}

		static void OnProjectFolderPreset() {
			var m = new GenericMenu();
			m.AddItem( S._Makepackagesettings, () => {
				E.i.projectSettingsPath = "6763de3f012135f439fea4e446738691";
				E.Save();
			} );
			m.AddItem( S._UseProjectSettings, () => {
				E.i.projectSettingsPath = "ProjectSettings";
				E.Save();
			} );
			m.DropDownAtMousePosition();
		}
	}
}
