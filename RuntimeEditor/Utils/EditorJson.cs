
using Json = UnityReflection.UnityEditorJson;

namespace HananokiEditor {
	public sealed class EditorJson {
		public static string Serialize( System.Object obj, bool pretty = false, string indentText = "  " ) {
			if( UnitySymbol.Has( "UNITY_2019_1_OR_NEWER" ) ) {
				return Json.Serialize( obj, pretty, indentText );
			}
			else {
				return Json.Serialize( obj );
			}
		}

		public static System.Object Deserialize( string json ) {
			return Json.Deserialize( json );
		}
	}
}
