
using UnityEditor;

namespace Hananoki {

	public static class EditorFolder {
		public static string resourcePath {
			get {
				return $"{EditorApplication.applicationContentsPath}/Resources";
			}
		}
		public static string scriptTemplatesPath {
			get {
				return $"{resourcePath}/ScriptTemplates";
			}
		}
	}
}
