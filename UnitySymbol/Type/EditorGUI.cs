
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEditor_EditorGUI;
		public static Type UnityEditor_EditorGUI => Get( ref _UnityEditor_EditorGUI, "UnityEditor.EditorGUI", "UnityEditor" );

		static Type _UnityEditor_EditorGUI_ObjectFieldValidator;
		public static Type UnityEditor_EditorGUI_ObjectFieldValidator => Get( ref _UnityEditor_EditorGUI_ObjectFieldValidator, "UnityEditor.EditorGUI+ObjectFieldValidator", "UnityEditor" );

		static Type _UnityEditor_EditorGUILayout;
		public static Type UnityEditor_EditorGUILayout => Get( ref _UnityEditor_EditorGUILayout, "UnityEditor.EditorGUILayout", "UnityEditor" );

		static Type _UnityEditor_EditorGUIUtility;
		public static Type UnityEditor_EditorGUIUtility => Get( ref _UnityEditor_EditorGUIUtility, "UnityEditor.EditorGUIUtility", "UnityEditor" );

		static Type _UnityEditor_EditorStyles;
		public static Type UnityEditor_EditorStyles => Get( ref _UnityEditor_EditorStyles, "UnityEditor.EditorStyles", "UnityEditor" );

		static Type _UnityEditor_SplitterGUILayout;
		public static Type UnityEditor_SplitterGUILayout => Get( ref _UnityEditor_SplitterGUILayout, "UnityEditor.SplitterGUILayout", "UnityEditor" );

		static Type _UnityEditor_SplitterState;
		public static Type UnityEditor_SplitterState => Get( ref _UnityEditor_SplitterState, "UnityEditor.SplitterState", "UnityEditor" );

		static Type _UnityEditor_TransformRotationGUI;
		public static Type UnityEditor_TransformRotationGUI => Get( ref _UnityEditor_TransformRotationGUI, "UnityEditor.TransformRotationGUI", "UnityEditor" );

	}
}
