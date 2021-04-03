
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditorEditorUserBuildSettings = UnityReflection.UnityEditorEditorUserBuildSettings;

namespace HananokiEditor {
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

		public static void SetScriptingDefineSymbols( IEnumerable<string> defines ) {
			SetScriptingDefineSymbols( defines.ToArray() );
		}
		public static void SetScriptingDefineSymbols( params string[] defines ) {
			SetScriptingDefineSymbols( string.Join( ";", defines ) );
		}


		//public static void AddPreloadedAssets( params Object[] objects ) {
		//	var lst = PlayerSettings.GetPreloadedAssets().ToList();
		//	lst.AddRange( objects );
		//	PlayerSettings.SetPreloadedAssets( lst.Distinct().ToArray() );
		//}
	}
}
