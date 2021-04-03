using System.Collections.Generic;

namespace HananokiEditor {
	//[PreferBinarySerialization]
	//public class EditorLocalizeDataOld : ScriptableObject {
	//	public string[] m_Strings;
	//	public List<string> m_Keys;
	//}

	public class EditorLocalizeData {
		public string[] m_Strings;
		public List<string> m_Keys;


		public static EditorLocalizeData Load( string filepath ) {
			var data = new EditorLocalizeData();
			data.m_Strings = fs.ReadAllText( filepath ).Split( '\n' );
			return data;
		}
	}
}
