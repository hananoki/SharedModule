
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEditor_AnimationClipEditor;
		public static Type UnityEditor_AnimationClipEditor => Get( ref _UnityEditor_AnimationClipEditor, "UnityEditor.AnimationClipEditor", "UnityEditor" );

		static Type _UnityEditor_EditorAssemblies;
		public static Type UnityEditor_EditorAssemblies => Get( ref _UnityEditor_EditorAssemblies, "UnityEditor.EditorAssemblies", "UnityEditor" );

		static Type _UnityEditor_Editor;
		public static Type UnityEditor_Editor => Get( ref _UnityEditor_Editor, "UnityEditor.Editor", "UnityEditor" );

		static Type _UnityEditor_EditorWindow;
		public static Type UnityEditor_EditorWindow => Get( ref _UnityEditor_EditorWindow, "UnityEditor.EditorWindow", "UnityEditor" );

		static Type _UnityEditor_GameObjectInspector;
		public static Type UnityEditor_GameObjectInspector => Get( ref _UnityEditor_GameObjectInspector, "UnityEditor.GameObjectInspector", "UnityEditor" );

		static Type _UnityEditor_GenericInspector;
		public static Type UnityEditor_GenericInspector => Get( ref _UnityEditor_GenericInspector, "UnityEditor.GenericInspector", "UnityEditor" );

		static Type _UnityEditor_Modules_ModuleManager;
		public static Type UnityEditor_Modules_ModuleManager => Get( ref _UnityEditor_Modules_ModuleManager, "UnityEditor.Modules.ModuleManager", "UnityEditor" );

		static Type _UnityEditor_ProjectWindowUtil;
		public static Type UnityEditor_ProjectWindowUtil => Get( ref _UnityEditor_ProjectWindowUtil, "UnityEditor.ProjectWindowUtil", "UnityEditor" );

		static Type _UnityEditor_SplitterGUILayout;
		public static Type UnityEditor_SplitterGUILayout => Get( ref _UnityEditor_SplitterGUILayout, "UnityEditor.SplitterGUILayout", "UnityEditor" );

		static Type _UnityEditor_SplitterState;
		public static Type UnityEditor_SplitterState => Get( ref _UnityEditor_SplitterState, "UnityEditor.SplitterState", "UnityEditor" );

		static Type _UnityEditor_SearchFilter;
		public static Type UnityEditor_SearchFilter => Get( ref _UnityEditor_SearchFilter, "UnityEditor.SearchFilter", "UnityEditor" );

		static Type _UnityEditor_SpriteRendererEditor;
		public static Type UnityEditor_SpriteRendererEditor => Get( ref _UnityEditor_SpriteRendererEditor, "UnityEditor.SpriteRendererEditor", "UnityEditor" );

		static Type _UnityEditor_PrefabOverridesWindow;
		public static Type UnityEditor_PrefabOverridesWindow => Get( ref _UnityEditor_PrefabOverridesWindow, "UnityEditor.PrefabOverridesWindow", "UnityEditor" );

		static Type _UnityEditor_PropertyHandler;
		public static Type UnityEditor_PropertyHandler => Get( ref _UnityEditor_PropertyHandler, "UnityEditor.PropertyHandler", "UnityEditor" );

		static Type _UnityEditor_TransformRotationGUI;
		public static Type UnityEditor_TransformRotationGUI => Get( ref _UnityEditor_TransformRotationGUI, "UnityEditor.TransformRotationGUI", "UnityEditor" );

		static Type _UnityEditor_ModelImporterClipEditor;
		public static Type UnityEditor_ModelImporterClipEditor => Get( ref _UnityEditor_ModelImporterClipEditor, "UnityEditor.ModelImporterClipEditor", "UnityEditor" );

		static Type _UnityEditor_UnityType;
		public static Type UnityEditor_UnityType => Get( ref _UnityEditor_UnityType, "UnityEditor.UnityType", "UnityEditor" );

		static Type _UnityEditor_Build_BuildPlatforms;
		public static Type UnityEditor_Build_BuildPlatforms => Get( ref _UnityEditor_Build_BuildPlatforms, "UnityEditor.Build.BuildPlatforms", "UnityEditor" );

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

		static Type _UnityEditor_AnimationWindow;
		public static Type UnityEditor_AnimationWindow => Get( ref _UnityEditor_AnimationWindow, "UnityEditor.AnimationWindow", "UnityEditor" );

		static Type _UnityEditor_Graphs_AnimatorControllerTool;
		public static Type UnityEditor_Graphs_AnimatorControllerTool => Get( ref _UnityEditor_Graphs_AnimatorControllerTool, "UnityEditor.Graphs.AnimatorControllerTool", "UnityEditor.Graphs" );

		static Type _UnityEditor_LightingWindow;
		public static Type UnityEditor_LightingWindow => Get( ref _UnityEditor_LightingWindow, "UnityEditor.LightingWindow", "UnityEditor" );

		static Type _UnityEditor_LightingExplorerWindow;
		public static Type UnityEditor_LightingExplorerWindow => Get( ref _UnityEditor_LightingExplorerWindow, "UnityEditor.LightingExplorerWindow", "UnityEditor" );

		static Type _UnityEditor_BuildPlayerWindow;
		public static Type UnityEditor_BuildPlayerWindow => Get( ref _UnityEditor_BuildPlayerWindow, "UnityEditor.BuildPlayerWindow", "UnityEditor" );

		static Type _UnityEditor_ProjectBrowser;
		public static Type UnityEditor_ProjectBrowser => Get( ref _UnityEditor_ProjectBrowser, "UnityEditor.ProjectBrowser", "UnityEditor" );

		static Type _UnityEditor_SceneHierarchyWindow;
		public static Type UnityEditor_SceneHierarchyWindow => Get( ref _UnityEditor_SceneHierarchyWindow, "UnityEditor.SceneHierarchyWindow", "UnityEditor" );

		static Type _UnityEditor_InspectorWindow;
		public static Type UnityEditor_InspectorWindow => Get( ref _UnityEditor_InspectorWindow, "UnityEditor.InspectorWindow", "UnityEditor" );

		static Type _UnityEditor_GameView;
		public static Type UnityEditor_GameView => Get( ref _UnityEditor_GameView, "UnityEditor.GameView", "UnityEditor" );

		static Type _UnityEditor_SceneView;
		public static Type UnityEditor_SceneView => Get( ref _UnityEditor_SceneView, "UnityEditor.SceneView", "UnityEditor" );

		static Type _UnityEditor_AssetStoreWindow;
		public static Type UnityEditor_AssetStoreWindow => Get( ref _UnityEditor_AssetStoreWindow, "UnityEditor.AssetStoreWindow", "UnityEditor" );

		static Type _UnityEditor_ConsoleWindow;
		public static Type UnityEditor_ConsoleWindow => Get( ref _UnityEditor_ConsoleWindow, "UnityEditor.ConsoleWindow", "UnityEditor" );

		static Type _UnityEditor_ProfilerWindow;
		public static Type UnityEditor_ProfilerWindow => Get( ref _UnityEditor_ProfilerWindow, "UnityEditor.ProfilerWindow", "UnityEditor" );

		static Type _UnityEditor_AudioMixerWindow;
		public static Type UnityEditor_AudioMixerWindow => Get( ref _UnityEditor_AudioMixerWindow, "UnityEditor.AudioMixerWindow", "UnityEditor" );

		static Type _UnityEditor_Json;
		public static Type UnityEditor_Json => Get( ref _UnityEditor_Json, "UnityEditor.Json", "UnityEditor" );

		static Type _UnityEditor_EditorUserBuildSettings;
		public static Type UnityEditor_EditorUserBuildSettings => Get( ref _UnityEditor_EditorUserBuildSettings, "UnityEditor.EditorUserBuildSettings", "UnityEditor" );

		static Type _UnityEditor_TextureUtil;
		public static Type UnityEditor_TextureUtil => Get( ref _UnityEditor_TextureUtil, "UnityEditor.TextureUtil", "UnityEditor" );

		static Type _UnityEditor_AudioUtil;
		public static Type UnityEditor_AudioUtil => Get( ref _UnityEditor_AudioUtil, "UnityEditor.AudioUtil", "UnityEditor" );

		static Type _UnityEditor_CustomEditorAttributes;
		public static Type UnityEditor_CustomEditorAttributes => Get( ref _UnityEditor_CustomEditorAttributes, "UnityEditor.CustomEditorAttributes", "UnityEditor" );

		static Type _UnityEditor_EditorGUI;
		public static Type UnityEditor_EditorGUI => Get( ref _UnityEditor_EditorGUI, "UnityEditor.EditorGUI", "UnityEditor" );

		static Type _UnityEditor_EditorGUILayout;
		public static Type UnityEditor_EditorGUILayout => Get( ref _UnityEditor_EditorGUILayout, "UnityEditor.EditorGUILayout", "UnityEditor" );

		static Type _UnityEditor_EditorGUIUtility;
		public static Type UnityEditor_EditorGUIUtility => Get( ref _UnityEditor_EditorGUIUtility, "UnityEditor.EditorGUIUtility", "UnityEditor" );

		static Type _UnityEditor_TypeCache;
		public static Type UnityEditor_TypeCache => Get( ref _UnityEditor_TypeCache, "UnityEditor.TypeCache", "UnityEditor" );

		static Type _UnityEditor_EditorUserBuildSettingsUtils;
		public static Type UnityEditor_EditorUserBuildSettingsUtils => Get( ref _UnityEditor_EditorUserBuildSettingsUtils, "UnityEditor.EditorUserBuildSettingsUtils", "UnityEditor" );

		static Type _UnityEditor_RectTransformEditor;
		public static Type UnityEditor_RectTransformEditor => Get( ref _UnityEditor_RectTransformEditor, "UnityEditor.RectTransformEditor", "UnityEditor" );

		static Type _UnityEditorInternal_ReorderableList;
		public static Type UnityEditorInternal_ReorderableList => Get( ref _UnityEditorInternal_ReorderableList, "UnityEditorInternal.ReorderableList", "UnityEditor" );

		static Type _UnityEditor_SceneManagement_EditorSceneManager;
		public static Type UnityEditor_SceneManagement_EditorSceneManager => Get( ref _UnityEditor_SceneManagement_EditorSceneManager, "UnityEditor.SceneManagement.EditorSceneManager", "UnityEditor" );

		static Type _UnityEditor_ScriptAttributeUtility;
		public static Type UnityEditor_ScriptAttributeUtility => Get( ref _UnityEditor_ScriptAttributeUtility, "UnityEditor.ScriptAttributeUtility", "UnityEditor" );

		static Type _UnityEditor_IMGUI_Controls_TreeView;
		public static Type UnityEditor_IMGUI_Controls_TreeView => Get( ref _UnityEditor_IMGUI_Controls_TreeView, "UnityEditor.IMGUI.Controls.TreeView", "UnityEditor" );

		static Type _UnityEditor_WindowLayout;
		public static Type UnityEditor_WindowLayout => Get( ref _UnityEditor_WindowLayout, "UnityEditor.WindowLayout", "UnityEditor" );

		static Type _UnityEditor_AssetStoreUtils;
		public static Type UnityEditor_AssetStoreUtils => Get( ref _UnityEditor_AssetStoreUtils, "UnityEditor.AssetStoreUtils", "UnityEditor" );

		static Type _UnityEditor_Lightmapping;
		public static Type UnityEditor_Lightmapping => Get( ref _UnityEditor_Lightmapping, "UnityEditor.Lightmapping", "UnityEditor" );

		static Type _UnityEditor_SyncVS;
		public static Type UnityEditor_SyncVS => Get( ref _UnityEditor_SyncVS, "UnityEditor.SyncVS", "UnityEditor" );

		static Type _UnityEditor_EditorSettings;
		public static Type UnityEditor_EditorSettings => Get( ref _UnityEditor_EditorSettings, "UnityEditor.EditorSettings", "UnityEditor" );

		static Type _UnityEditorInternal_AnimationWindowState;
		public static Type UnityEditorInternal_AnimationWindowState => Get( ref _UnityEditorInternal_AnimationWindowState, "UnityEditorInternal.AnimationWindowState", "UnityEditor" );

		static Type _UnityEditor_AnimatorInspector;
		public static Type UnityEditor_AnimatorInspector => Get( ref _UnityEditor_AnimatorInspector, "UnityEditor.AnimatorInspector", "UnityEditor" );

		static Type _UnityEngine_Animator;
		public static Type UnityEngine_Animator => Get( ref _UnityEngine_Animator, "UnityEngine.Animator", "UnityEngine" );

	}
}
