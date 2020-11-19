using UnityEngine;
using System.Collections.Generic;

namespace Hananoki {
	[PreferBinarySerialization]
	public class EditorLocalizeData : ScriptableObject {
		public string[] m_Strings;
		public List<string> m_Keys;
	}
}
