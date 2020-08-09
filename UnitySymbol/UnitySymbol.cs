using System.Collections.Generic;
using System.Linq;
using UnityEditor;

namespace Hananoki {
	public static class UnitySymbol {
		static List<string> s_lst;

		public static bool Has( string symbol ) {
			if( s_lst == null ) s_lst = EditorUserBuildSettings.activeScriptCompilationDefines.Where( x => x.StartsWith( "UNITY_" ) ).ToList();
			return s_lst.Contains( symbol );
		}

		public static bool UNITY_2018_1_OR_NEWER => Has( "UNITY_2018_1_OR_NEWER" );
		public static bool UNITY_2018_2_OR_NEWER => Has( "UNITY_2018_2_OR_NEWER" );
		public static bool UNITY_2018_3_OR_NEWER => Has( "UNITY_2018_3_OR_NEWER" );
		public static bool UNITY_2018_4_OR_NEWER => Has( "UNITY_2018_4_OR_NEWER" );
		
		public static bool UNITY_2019_1_OR_NEWER => Has( "UNITY_2019_1_OR_NEWER" );
		public static bool UNITY_2019_2_OR_NEWER => Has( "UNITY_2019_2_OR_NEWER" );
		public static bool UNITY_2019_3_OR_NEWER => Has( "UNITY_2019_3_OR_NEWER" );
		public static bool UNITY_2019_4_OR_NEWER => Has( "UNITY_2019_4_OR_NEWER" );

		public static bool UNITY_2020_1_OR_NEWER => Has( "UNITY_2020_1_OR_NEWER" );

	}
}
