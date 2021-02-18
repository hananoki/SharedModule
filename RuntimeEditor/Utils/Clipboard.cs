
using UnityEngine;
using UnityReflection;

namespace HananokiEditor {

	public static class Clipboard {

		static Color _color;

		public static void SetColor( Color color ) {
			_color = color;
			if( UnitySymbol.UNITY_2020_1_OR_NEWER ) {
			}
			else {
				UnityEditorColorClipboard.SetColor( color );
			}
		}

		public static Color GetColor() {
			return _color;
		}

		public static void SetText( string text ) {
			GUIUtility.systemCopyBuffer = text;
		}

		public static string GetText() {
			return GUIUtility.systemCopyBuffer;
		}
	}
}
