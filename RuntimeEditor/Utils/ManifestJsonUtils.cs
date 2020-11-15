
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;

namespace Hananoki {
	public static class ManifestJsonUtils {
		static Dictionary<string, object> s_manifest = null;

		const string kPATH = "Packages/manifest.json";

		public static void Load() {
			s_manifest = UnityEditorJson.Deserialize( File.ReadAllText( kPATH ) ) as Dictionary<string, object>;
		}


		public static void Save() {
			File.WriteAllText( kPATH, UnityEditorJson.Serialize( s_manifest, true ) );
			AssetDatabase.Refresh();
		}


		public static IDictionary GetDependencies() {
			return (IDictionary) s_manifest[ "dependencies" ];
		}


		public static void AddPackage( string packageName, string version ) {
			var dic = GetDependencies();

			if( !dic.Contains( packageName ) ) {
				dic.Add( packageName, version );
			}
		}


		public static void RemovePackage( string packageName ) {
			var dic = GetDependencies();

			if( dic.Contains( packageName ) ) {
				dic.Remove( packageName );
			}
		}
	}
}
