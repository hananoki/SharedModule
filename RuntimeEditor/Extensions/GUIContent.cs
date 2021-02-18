
using UnityEditor;
using UnityEngine;

namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {
		public static Vector2 CalcSizeFromLabel( this GUIContent content ) {
			return EditorStyles.label.CalcSize( content );
		}

		public static float CalcWidth_label( this GUIContent content ) {
			return EditorStyles.label.CalcSize( content ).x;
		}

		public static float CalcWidth_miniLabel( this GUIContent content ) {
			return EditorStyles.miniLabel.CalcSize( content ).x;
		}
	}
}
