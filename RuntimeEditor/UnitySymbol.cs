using System.Collections.Generic;
using System.Linq;
using UnityEditor;

namespace Hananoki {
	public static class UnitySymbol {
		static List<string> s_lst;

		public static bool Has( string symbol ) {
			if( s_lst == null) s_lst = EditorUserBuildSettings.activeScriptCompilationDefines.Where( x => x.StartsWith( "UNITY_" ) ).ToList();
			return s_lst.Contains( symbol );
		}
	}
}
