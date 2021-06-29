
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEditor_AnimationWindow;
		public static Type UnityEditor_AnimationWindow => Get( ref _UnityEditor_AnimationWindow, "UnityEditor.AnimationWindow", "UnityEditor" );

		static Type _UnityEditor_AudioMixerWindow;
		public static Type UnityEditor_AudioMixerWindow => Get( ref _UnityEditor_AudioMixerWindow, "UnityEditor.AudioMixerWindow", "UnityEditor" );

		static Type _UnityEditor_AssetStoreWindow;
		public static Type UnityEditor_AssetStoreWindow => Get( ref _UnityEditor_AssetStoreWindow, "UnityEditor.AssetStoreWindow", "UnityEditor" );

		static Type _UnityEditor_BuildPlayerWindow;
		public static Type UnityEditor_BuildPlayerWindow => Get( ref _UnityEditor_BuildPlayerWindow, "UnityEditor.BuildPlayerWindow", "UnityEditor" );

		static Type _UnityEditor_ConsoleWindow;
		public static Type UnityEditor_ConsoleWindow => Get( ref _UnityEditor_ConsoleWindow, "UnityEditor.ConsoleWindow", "UnityEditor" );

		static Type _UnityEditor_EditorWindow;
		public static Type UnityEditor_EditorWindow => Get( ref _UnityEditor_EditorWindow, "UnityEditor.EditorWindow", "UnityEditor" );

		static Type _UnityEditor_GameView;
		public static Type UnityEditor_GameView => Get( ref _UnityEditor_GameView, "UnityEditor.GameView", "UnityEditor" );

		static Type _UnityEditor_Graphs_AnimatorControllerTool;
		public static Type UnityEditor_Graphs_AnimatorControllerTool => Get( ref _UnityEditor_Graphs_AnimatorControllerTool, "UnityEditor.Graphs.AnimatorControllerTool", "UnityEditor.Graphs" );

		static Type _UnityEditor_InspectorWindow;
		public static Type UnityEditor_InspectorWindow => Get( ref _UnityEditor_InspectorWindow, "UnityEditor.InspectorWindow", "UnityEditor" );

		static Type _UnityEditor_LightingExplorerWindow;
		public static Type UnityEditor_LightingExplorerWindow => Get( ref _UnityEditor_LightingExplorerWindow, "UnityEditor.LightingExplorerWindow", "UnityEditor" );

		static Type _UnityEditor_LightingWindow;
		public static Type UnityEditor_LightingWindow => Get( ref _UnityEditor_LightingWindow, "UnityEditor.LightingWindow", "UnityEditor" );

		static Type _UnityEditor_PopupWindow;
		public static Type UnityEditor_PopupWindow => Get( ref _UnityEditor_PopupWindow, "UnityEditor.PopupWindow", "UnityEditor" );

		static Type _UnityEditor_PrefabOverridesWindow;
		public static Type UnityEditor_PrefabOverridesWindow => Get( ref _UnityEditor_PrefabOverridesWindow, "UnityEditor.PrefabOverridesWindow", "UnityEditor" );

		static Type _UnityEditor_ProfilerWindow;
		public static Type UnityEditor_ProfilerWindow => Get( ref _UnityEditor_ProfilerWindow, "UnityEditor.ProfilerWindow", "UnityEditor" );

		static Type _UnityEditor_ProjectBrowser;
		public static Type UnityEditor_ProjectBrowser => Get( ref _UnityEditor_ProjectBrowser, "UnityEditor.ProjectBrowser", "UnityEditor" );

		static Type _UnityEditor_SceneHierarchyWindow;
		public static Type UnityEditor_SceneHierarchyWindow => Get( ref _UnityEditor_SceneHierarchyWindow, "UnityEditor.SceneHierarchyWindow", "UnityEditor" );

		static Type _UnityEditor_SceneView;
		public static Type UnityEditor_SceneView => Get( ref _UnityEditor_SceneView, "UnityEditor.SceneView", "UnityEditor" );

		static Type _UnityEditor_SettingsWindow;
		public static Type UnityEditor_SettingsWindow => Get( ref _UnityEditor_SettingsWindow, "UnityEditor.SettingsWindow", "UnityEditor" );

		static Type _UnityEditor_Timeline_TimelineWindow;
		public static Type UnityEditor_Timeline_TimelineWindow {
			get {
				if( _UnityEditor_Timeline_TimelineWindow == null ) {
					if( UnitySymbol.UNITY_2019_1_OR_NEWER ) {
						_UnityEditor_Timeline_TimelineWindow = Get( ref _UnityEditor_Timeline_TimelineWindow,"UnityEditor.Timeline.TimelineWindow", "Unity.Timeline.Editor" );
					}
					else {
						_UnityEditor_Timeline_TimelineWindow = Get( ref _UnityEditor_Timeline_TimelineWindow,"UnityEditor.Timeline.TimelineWindow", "UnityEditor.Timeline" );
					}
				}
				return _UnityEditor_Timeline_TimelineWindow;
			}
		}

	}
}
