
#if ENABLE_HANANOKI_SETTINGS
#pragma warning disable 618
#endif

using Hananoki.Reflection;
using Hananoki.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

using E = Hananoki.SharedModule.SettingsEditor;


namespace Hananoki.SharedModule {
	[InitializeOnLoad]
	[Serializable]
	public class SettingsEditor {
		public string language;
		public Color selectionColor = Color.white;

		public static E i;

		public EditorColor versionTextColor = new EditorColor( ColorUtils.RGB( 72 ), ColorUtils.RGB( 173 ) );
		public EditorColor versionBackColor = new EditorColor( ColorUtils.RGB( 242 ) , ColorUtils.RGB( 41 ) );

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
#if ENABLE_HANANOKI_SETTINGS
				return $"{GUIDUtils.GetAssetPath( "6763de3f012135f439fea4e446738691" )}";
#else
				return $"{Environment.CurrentDirectory}/ProjectSettings";
#endif
			}
		}

		public static void LoadLocalize() {
			EditorLocalize.Load( Package.name, i.language, "2ca67e52d0e4c5a439729c95e8bf5e45" );

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
			foreach( var m in s_localizeEvent ) m.Invoke( null, null );

			EditorUtils.RepaintEditorWindow();
		}
	}



	public class SettingsEditorWindow : HSettingsEditorWindow {

		public static string[] localeFiles;
		public static string[] localeFilesPopup;

		public static void Open() {
			var w = GetWindow<SettingsEditorWindow>();
			w.SetTitle( new GUIContent( Package.name, EditorIcon.settings ) );
			w.headerMame = Package.name;
			w.headerVersion = Package.version;
			w.gui = DrawGUI;
		}



		public static void DrawGUI() {
			E.Load();

			if( localeFiles == null ) {
				localeFiles = DirectoryUtils.GetFileGUIDs( AssetDatabase.GUIDToAssetPath( "95cedfc7731853946b0b3650f175d73a" ), "*.csv" );
				localeFilesPopup = localeFiles.Select( x => AssetDatabase.GUIDToAssetPath( x ).FileNameWithoutExtension() ).ToArray();
			}
			//if( UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
			//	EditorGUILayout.LabelField( "Support", "2018.3 - xxx" );
			//}
			//else {
			//	EditorGUILayout.LabelField( "Support", "Not Support" );
			//}

			EditorGUI.BeginChangeCheck();
			int n = ArrayUtility.IndexOf( localeFiles, E.i.language );
			if( n < 0 ) {
				n = 0;
			}
			n = EditorGUILayout.Popup( S._Language, n, localeFilesPopup );

			GUILayout.Space(4);
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

			HGUIScope.Horizontal(()=> {
				GUILayout.FlexibleSpace();
				if( GUILayout.Button( "Default" )){
					E.i.versionTextColor = new EditorColor( ColorUtils.RGB( 72 ), ColorUtils.RGB( 173 ) );
					E.i.versionBackColor = new EditorColor( ColorUtils.RGB( 242 ), ColorUtils.RGB( 41 ) );
					E.Save();
				}
			} );
			

			if( EditorGUI.EndChangeCheck() ) {
				E.i.language = localeFiles[ n ];
				E.LoadLocalize();
				E.Save();
			}

			//EditorGUI.BeginChangeCheck();
			//var _color = EditorGUILayout.ColorField( nameof( Pref.selectionColor ).nicify(), Pref.i.selectionColor );
			//if( EditorGUI.EndChangeCheck() ) {
			//	Pref.i.selectionColor = _color;
			//	Pref.Save();
			//}
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




namespace Hananoki.Shared {
	public static class Icon {
		static Dictionary<string, Texture2D> icons;
		public static Texture2D Get( string s ) {
			if( icons == null ) {
				icons = new Dictionary<string, Texture2D>();
			}
			bool load = false;
			if( !icons.ContainsKey( s ) ) load = true;
			else if( icons[ s ] == null ) load = true;
			if( load ) {
				for( int i = 0; i < SharedEmbed.num; i++ ) {
					if( SharedEmbed.n[ i ] != s ) continue;
					var bb = B64.Decode( "iVBORw0KGgoAAAAN" + SharedEmbed.i[ i ] );
					var t = new Texture2D( SharedEmbed.x[ i ], SharedEmbed.y[ i ] );
					t.LoadImage( bb );
					t.hideFlags |= HideFlags.DontUnloadUnusedAsset;
					if( icons.ContainsKey( s ) ) {
						icons[ s ] = t;
					}
					else {
						icons.Add( SharedEmbed.n[ i ], t );
					}
				}
			}
			return icons[ s ];
		}
	}
}
