
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEditor_Toolbar;
		public static Type UnityEditor_Toolbar => Get( ref _UnityEditor_Toolbar, "UnityEditor.Toolbar", "UnityEditor" );

		static Type _UnityEditor_GUIView;
		public static Type UnityEditor_GUIView => Get( ref _UnityEditor_GUIView, "UnityEditor.GUIView", "UnityEditor" );

	}
}
