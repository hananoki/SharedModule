
using System.Collections.Generic;
using UnityEditor;
using UnityEditorEditorUserBuildSettings = UnityReflection.UnityEditorEditorUserBuildSettings;

namespace Hananoki {
	public static class PlayerSettingsUtils {

		public static string GetScriptingDefineSymbols() {
			return PlayerSettings.GetScriptingDefineSymbolsForGroup( UnityEditorEditorUserBuildSettings.activeBuildTargetGroup );
		}

		public static string[] GetScriptingDefineSymbolsAtArray() {
			return GetScriptingDefineSymbols().Split( ';' );
		}

		public static List<string> GetScriptingDefineSymbolsAtList() {
			return new List<string>( GetScriptingDefineSymbolsAtArray() );
		}

		public static void SetScriptingDefineSymbols( string defines ) {
			PlayerSettings.SetScriptingDefineSymbolsForGroup( UnityEditorEditorUserBuildSettings.activeBuildTargetGroup, defines );
		}

		public static void SetScriptingDefineSymbols( List<string> defines ) {
			SetScriptingDefineSymbols( string.Join( ";", defines ) );
		}

		public static void SetScriptingDefineSymbols( params string[] defines ) {
			SetScriptingDefineSymbols( string.Join( ";", defines ) );
		}
	}
}
