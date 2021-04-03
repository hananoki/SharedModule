
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEngine_Rendering_GraphicsSettings;
		public static Type UnityEngine_Rendering_GraphicsSettings => Get( ref _UnityEngine_Rendering_GraphicsSettings, "UnityEngine.Rendering.GraphicsSettings", "UnityEngine" );

		static Type _UnityEditor_SceneViewMotion;
		public static Type UnityEditor_SceneViewMotion => Get( ref _UnityEditor_SceneViewMotion, "UnityEditor.SceneViewMotion", "UnityEditor" );

		static Type _UnityEditor_EditorApplication;
		public static Type UnityEditor_EditorApplication => Get( ref _UnityEditor_EditorApplication, "UnityEditor.EditorApplication", "UnityEditor" );

		static Type _UnityEditor_SettingsWindow;
		public static Type UnityEditor_SettingsWindow => Get( ref _UnityEditor_SettingsWindow, "UnityEditor.SettingsWindow", "UnityEditor" );

		static Type _DesktopStandaloneBuildWindowExtension;
		public static Type DesktopStandaloneBuildWindowExtension => Get( ref _DesktopStandaloneBuildWindowExtension, "DesktopStandaloneBuildWindowExtension", "UnityEditor" );

		static Type _UnityEditor_PostprocessBuildPlayer;
		public static Type UnityEditor_PostprocessBuildPlayer => Get( ref _UnityEditor_PostprocessBuildPlayer, "UnityEditor.PostprocessBuildPlayer", "UnityEditor" );

		static Type _UnityEditor_WebGL_HttpServerEditorWrapper;
		public static Type UnityEditor_WebGL_HttpServerEditorWrapper => Get( ref _UnityEditor_WebGL_HttpServerEditorWrapper, "UnityEditor.WebGL.HttpServerEditorWrapper", "UnityEditor.WebGL.Extensions" );

		static Type _UnityEditor_BuildPipeline;
		public static Type UnityEditor_BuildPipeline => Get( ref _UnityEditor_BuildPipeline, "UnityEditor.BuildPipeline", "UnityEditor" );

		static Type _UnityEditor_Unsupported;
		public static Type UnityEditor_Unsupported => Get( ref _UnityEditor_Unsupported, "UnityEditor.Unsupported", "UnityEditor" );

	}
}
