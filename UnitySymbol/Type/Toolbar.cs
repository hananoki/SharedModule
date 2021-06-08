
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEditor_Toolbar;
		public static Type UnityEditor_Toolbar => Get( ref _UnityEditor_Toolbar, "UnityEditor.Toolbar", "UnityEditor" );

		static Type _UnityEditor_GUIView;
		public static Type UnityEditor_GUIView => Get( ref _UnityEditor_GUIView, "UnityEditor.GUIView", "UnityEditor" );

		static Type _Unity_MPE_ProcessService;
		public static Type Unity_MPE_ProcessService => Get( ref _Unity_MPE_ProcessService, "Unity.MPE.ProcessService", "UnityEditor" );

		static Type _UnityEditor_AssetPostprocessingInternal;
		public static Type UnityEditor_AssetPostprocessingInternal => Get( ref _UnityEditor_AssetPostprocessingInternal, "UnityEditor.AssetPostprocessingInternal", "UnityEditor" );

		static Type _UnityEditor_Toolbars_EditorToolbarUtility;
		public static Type UnityEditor_Toolbars_EditorToolbarUtility => Get( ref _UnityEditor_Toolbars_EditorToolbarUtility, "UnityEditor.Toolbars.EditorToolbarUtility", "UnityEditor" );

	}
}
