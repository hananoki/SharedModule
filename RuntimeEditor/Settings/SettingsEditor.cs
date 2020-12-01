﻿
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
		//public string language;
		public Color selectionColor = Color.white;

		public string selectSettingName;

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


		public static E i;
		static List<MethodInfo> s_localizeEvent;


		static SettingsEditor() {
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