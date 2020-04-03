﻿
using Hananoki.Reflection;
using Hananoki.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

using Pref = Hananoki.SharedModule.SharedPreference;


namespace Hananoki.SharedModule {
	[InitializeOnLoad]
	[Serializable]
	public class SharedPreference {
		public string language;

		public static Pref i;


		static SharedPreference() {
			Load();
		}


		public static void Load() {
			if( i != null ) return;
			i = EditorPrefJson<Pref>.Get( Package.editorPrefName );
			s_localizeEvent = null;
			LoadLocalize();
		}



		public static void Save() {
			EditorPrefJson<Pref>.Set( Package.editorPrefName, i );
		}

		static List<MethodInfo> s_localizeEvent;



		public static void LoadLocalize() {
			EditorLocalize.Load( Package.name, i.language, "2ca67e52d0e4c5a439729c95e8bf5e45" );

			if( s_localizeEvent == null ) {
				s_localizeEvent = new List<MethodInfo>();
				var t = typeof( EditorLocalizeClass );
				foreach( Assembly assembly in AppDomain.CurrentDomain.GetAssemblies() ) {
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
			}
			foreach( var m in s_localizeEvent ) m.Invoke( null, null );

			EditorUtils.RepaintEditorWindow();
		}
	}



	public class SharedPreferenceWindow : HSettingsEditorWindow {

		public static string[] localeFiles;
		public static string[] localeFilesPopup;

		public static void Open() {
			var window = GetWindow<SharedPreferenceWindow>();
			window.SetTitle( new GUIContent( Package.name, Icon.Get( "SettingsIcon" ) ) );
		}

		void OnEnable() {
			drawGUI = DrawGUI;
			Pref.Load();
		}



		/// <summary>
		/// 
		/// </summary>
		static void DrawGUI() {
			if( localeFiles == null ) {
				localeFiles = DirectoryUtils.GetFileGUIDs( AssetDatabase.GUIDToAssetPath( "95cedfc7731853946b0b3650f175d73a" ), "*.csv" );
				localeFilesPopup = localeFiles.Select( x => AssetDatabase.GUIDToAssetPath( x ).FileNameWithoutExtension() ).ToArray();
			}
#if UNITY_2019_1_OR_NEWER
			EditorGUILayout.LabelField( "Support", "2019.1 - xxx" );
#elif UNITY_2018_3_OR_NEWER
			EditorGUILayout.LabelField( "Support", "2018.3 - 2018.4" );
#elif UNITY_2017_1_OR_NEWER
			EditorGUILayout.LabelField( "Support", "2017.1 - 2018.2" );
#else
			EditorGUILayout.LabelField( "Support", "Not Support" );
#endif
			EditorGUI.BeginChangeCheck();
			int n = ArrayUtility.IndexOf( localeFiles, Pref.i.language );
			if( n < 0 ) {
				n = 0;
			}
			n = EditorGUILayout.Popup( S._Language, n, localeFilesPopup );

			if( EditorGUI.EndChangeCheck() ) {
				Pref.i.language = localeFiles[ n ];
				Pref.LoadLocalize();
				Pref.Save();
			}

			GUILayout.Space( 8f );

		}





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
			Pref.Load();
			DrawGUI();
		}
	}
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
