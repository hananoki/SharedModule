
#if ENABLE_HANANOKI_SETTINGS
#pragma warning disable 618
#endif

using Hananoki.Extensions;
using Hananoki.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

using E = Hananoki.SharedModule.SettingsEditor;
using SS = Hananoki.SharedModule.S;

namespace Hananoki.SharedModule {
	[InitializeOnLoad]
	[Serializable]
	public class SettingsEditor {
		public string LCID;
		public string language;
		public Color selectionColor = Color.white;

		public static E i;

		public EditorColor versionTextColor = new EditorColor( ColorUtils.RGB( 72 ), ColorUtils.RGB( 173 ) );
		public EditorColor versionBackColor = new EditorColor( ColorUtils.RGB( 242 ), ColorUtils.RGB( 41 ) );
		public bool utilityWindow;

		static List<MethodInfo> s_localizeEvent;

		static SettingsEditor() {
			Load();
		}


		public static void Load() {
			if( i != null ) return;
			i = EditorPrefJson<E>.Get( Package.editorPrefName );
			s_localizeEvent = null;
			LoadLocalize();
		}



		public static void Save() {
			EditorPrefJson<E>.Set( Package.editorPrefName, i );
		}



		public static string projectSettingDirectory {
			get {
#if ENABLE_USER_SETTINGS_FOLDER
				return $"{GUIDUtils.GetAssetPath( "6763de3f012135f439fea4e446738691" )}";
#else
				return $"{Environment.CurrentDirectory}/ProjectSettings";
#endif
			}
		}


		public static void LoadLocalize() {
			EditorLocalize.Load( Package.name, "95cedfc7731853946b0b3650f175d73a", E.i.LCID );

			if( s_localizeEvent == null ) {
				s_localizeEvent = new List<MethodInfo>();
				var t = typeof( EditorLocalizeClass );
				foreach( Assembly assembly in AppDomain.CurrentDomain.GetAssemblies() ) {
					try {
						foreach( Type type in assembly.GetTypes() ) {
							try {
								if( type.GetCustomAttribute( t ) == null ) continue;
								var mm = R.Methods( typeof( EditorLocalizeMethod ), type.FullName, assembly.FullName.Split( ',' )[ 0 ] );
								s_localizeEvent.AddRange( mm );
							}
							catch( Exception ee ) {
								Debug.LogException( ee );
							}
						}
					}
					catch( ReflectionTypeLoadException ) {
						Debug.LogError( assembly.FullName );
					}
					catch( Exception e ) {
						Debug.LogError( e );
					}
				}
			}
			foreach( var m in s_localizeEvent ) {
				//Debug.Log("Invoke: "+m.Name);
				m.Invoke( null, null );
			}
			HEditorWindow.RepaintWindow( typeof( EditorWindow ) );
		}
	}



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


			if( m_localeNames == null ) {
				m_localeNames = new List<EditorLocalize.LCIDString>();// EditorLocalize.s_lcidTable.OrderBy( x => x.NAME ).ToList();
				var files = "95cedfc7731853946b0b3650f175d73a".GetFilesFromAssetGUID().Select( x => x.FileNameWithoutExtension() ).ToList();
				foreach( var rp in files ) {
					var p = EditorLocalize.s_lcidTable.Find( x => x.LCID == rp );
					if( p == null ) continue;
					m_localeNames.Add( p );
				}
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

			EditorGUI.BeginChangeCheck();


			GUILayout.Space( 4 );
			try {
				E.i.versionTextColor.value = EditorGUILayout.ColorField( S._VersionTextColor, E.i.versionTextColor.value );
			}
			catch( ExitGUIException ) {
			}

			try {
				E.i.versionBackColor.value = EditorGUILayout.ColorField( S._VersionBackColor, E.i.versionBackColor.value );
			}
			catch( ExitGUIException ) {
			}

			E.i.utilityWindow = EditorGUILayout.ToggleLeft( SS._UtilityWindowMode, E.i.utilityWindow );

			HGUIScope.Horizontal( () => {
				GUILayout.FlexibleSpace();
				if( GUILayout.Button( SS._ReturnToDefault ) ) {
					E.i.versionTextColor = new EditorColor( ColorUtils.RGB( 72 ), ColorUtils.RGB( 173 ) );
					E.i.versionBackColor = new EditorColor( ColorUtils.RGB( 242 ), ColorUtils.RGB( 41 ) );
					E.i.utilityWindow = false;
					E.Save();
				}
			} );


			if( EditorGUI.EndChangeCheck() ) {
				E.Save();
			}

			GUILayout.Space( 8f );

			//#if ENABLE_HANANOKI_SETTINGS && LOCAL_TEST
			//			using( new GUILayout.HorizontalScope() ) {
			//				GUILayout.FlexibleSpace();
			//				if( GUILayout.Button( "Open Settings" ) ) {
			//					SettingsWindow.Open();
			//				}
			//			}
			//#endif
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
