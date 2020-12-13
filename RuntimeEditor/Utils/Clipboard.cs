
using UnityEngine;

namespace HananokiEditor {

	public static class Clipboard {

		public static void SetText( string text ) {
			GUIUtility.systemCopyBuffer = text;
		}

		public static string GetText() {
			return GUIUtility.systemCopyBuffer;
		}
	}
}
