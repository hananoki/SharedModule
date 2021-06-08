
using UnityEditor;
using UnityEngine;

namespace HananokiEditor {
	public class EditorStylesHelper {
		public static Font standardFont {
			get {
				if( UnitySymbol.UNITY_2019_3_OR_NEWER ) {
					return EditorStyles.standardFont;
				}
				else {
					var s_Current = UnityTypes.UnityEditor_EditorStyles.GetField<EditorStyles>( "s_Current" );
					if( s_Current == null ) return null;
					return EditorStyles.standardFont;
				}
			}
		}
	}

}
