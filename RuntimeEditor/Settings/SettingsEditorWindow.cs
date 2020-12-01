
#if ENABLE_HANANOKI_SETTINGS
#pragma warning disable 618
#endif

using Hananoki.Extensions;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

using E = Hananoki.SharedModule.SettingsEditor;
using SS = Hananoki.SharedModule.S;

namespace Hananoki.SharedModule {

	public class SettingsEditorWindow : HSettingsEditorWindow {


		public static string[] localeFilesPopup;
		public class Lang {
			public string file;
			public string popName;
		}
		public static List<Lang> localeFiles;

		public static List<EditorLocalize.LCIDString> m_localeNames;
		public static int m_localeIndex;

		public static void Open() {
			var w = GetWindow<SettingsEditorWindow>();
			w.SetTitle( new GUIContent( Package.name, EditorIcon.settings ) );
			w.headerMame = Package.name;
			w.headerVersion = Package.version;
			w.gui = DrawGUI;
		}



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

			EditorGUI.BeginChangeCheck();
			var idx = m_localeNames.FindIndex( x => x.LCID == E.i.LCID );
			if( idx < 0 ) {
				idx = m_localeNames.FindIndex( x => x.LCID == "en-US" );
			}
			idx = EditorGUILayout.Popup( S._Language, idx, m_localeNames.Select( x => x.NAME ).ToArray() );
			if( EditorGUI.EndChangeCheck() ) {
				E.i.LCID = m_localeNames[ idx ].LCID;
				E.LoadLocalize();
				E.Save();
			}

			HGUIScope.Change();
			GUILayout.Space( 4 );
			E.i.versionTextColor.value = EditorGUILayout.ColorField( S._VersionTextColor, E.i.versionTextColor.value );

			E.i.versionBackColor.value = EditorGUILayout.ColorField( S._VersionBackColor, E.i.versionBackColor.value );

			//E.i.utilityWindow = EditorGUILayout.ToggleLeft( SS._UtilityWindowMode, E.i.utilityWindow );
			if( HGUIScope.End() ) {
				E.Save();
			}

			GUILayout.Space( 8 );

			HEditorGUILayout.HeaderTitle( S._WheretosaveProjectsettings );


			HEditorGUILayout.PreviewFolder( E.i.GetProjectSettingsPath(), OnProjectFolderPreset );

			GUILayout.Space( 8f );
			HGUIScope.Horizontal();
			GUILayout.FlexibleSpace();
			if( GUILayout.Button( SS._ReturnToDefault ) ) {
				E.i.versionTextColor = new EditorColor( ColorUtils.RGB( 72 ), ColorUtils.RGB( 173 ) );
				E.i.versionBackColor = new EditorColor( ColorUtils.RGB( 242 ), ColorUtils.RGB( 41 ) );
				//E.i.utilityWindow = false;
				E.Save();
			}
			HGUIScope.End();


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



#if !ENABLE_HANANOKI_SETTINGS
#if UNITY_2018_3_OR_NEWER && !ENABLE_LEGACY_PREFERENCE
		[SettingsProvider]
		public static SettingsProvider PreferenceView() {
			var provider = new SettingsProvider( $"Preferences/Hananoki", SettingsScope.User ) {
				label = $"Hananoki",
				guiHandler = PreferencesGUI,
				titleBarGuiHandler = () => GUILayout.Label( $"{Package.version}", EditorStyles.miniLabel ),
			};
			return provider;
		}
		public static void PreferencesGUI( string searchText ) {
#else
		[PreferenceItem( "Hananoki" )]
		public static void PreferencesGUI() {
#endif
			using( new LayoutScope() ) DrawGUI();
		}
#endif
	}


#if ENABLE_HANANOKI_SETTINGS
	[SettingsClass]
	public class SettingsEditorEvent {
		[SettingsMethod]
		public static SettingsItem RegisterSettings() {
			return new SettingsItem() {
				//mode = 1,
				displayName = Package.name,
				version = Package.version,
				gui = SettingsEditorWindow.DrawGUI,
			};
		}
	}
#endif
}
