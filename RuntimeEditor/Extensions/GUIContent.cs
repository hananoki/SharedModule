
using UnityEditor;
using UnityEngine;

namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {
		//public static Vector2 CalcSizeFromLabel( this GUIContent content ) {
		//	return CalcSize( content, EditorStyles.label );
		//}

		public static float CalcWidth_label( this GUIContent content ) {
			//return EditorStyles.label.CalcSize( content ).x;
			return CalcSize( content, EditorStyles.label ).x;
		}

		public static float CalcWidth_miniLabel( this GUIContent content ) {
			return CalcSize( content, EditorStyles.miniLabel ).x;
		}

		public static Vector2 CalcSize( this GUIContent content, GUIStyle style ) {
			return style.CalcSize( content );
		}
	}
}
