
using System;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Hananoki {
	public static class SettingTest {
		public static string projectSettingDirectory {
			get {
#if UNITY_EDITOR
#if ENABLE_USER_SETTINGS_FOLDER
				return $"{AssetDatabase.GUIDToAssetPath( "6763de3f012135f439fea4e446738691" )}";
#else
				return $"{Environment.CurrentDirectory}/ProjectSettings";
#endif
#else
				return "";
#endif
			}
		}
	}
}

