
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEditor_Build_BuildPlatforms;
		public static Type UnityEditor_Build_BuildPlatforms => Get( ref _UnityEditor_Build_BuildPlatforms, "UnityEditor.Build.BuildPlatforms", "UnityEditor" );

		static Type _UnityEditor_Build_BuildPlatform;
		public static Type UnityEditor_Build_BuildPlatform => Get( ref _UnityEditor_Build_BuildPlatform, "UnityEditor.Build.BuildPlatform", "UnityEditor" );

		static Type _UnityEditor_BuildPipeline;
		public static Type UnityEditor_BuildPipeline => Get( ref _UnityEditor_BuildPipeline, "UnityEditor.BuildPipeline", "UnityEditor" );

		static Type _UnityEditor_EditorSettings;
		public static Type UnityEditor_EditorSettings => Get( ref _UnityEditor_EditorSettings, "UnityEditor.EditorSettings", "UnityEditor" );

		static Type _UnityEditor_EditorUserBuildSettings;
		public static Type UnityEditor_EditorUserBuildSettings => Get( ref _UnityEditor_EditorUserBuildSettings, "UnityEditor.EditorUserBuildSettings", "UnityEditor" );

		static Type _UnityEditor_EditorUserBuildSettingsUtils;
		public static Type UnityEditor_EditorUserBuildSettingsUtils => Get( ref _UnityEditor_EditorUserBuildSettingsUtils, "UnityEditor.EditorUserBuildSettingsUtils", "UnityEditor" );

		static Type _UnityEditor_Modules_ModuleManager;
		public static Type UnityEditor_Modules_ModuleManager => Get( ref _UnityEditor_Modules_ModuleManager, "UnityEditor.Modules.ModuleManager", "UnityEditor" );

		static Type _UnityEditor_PostprocessBuildPlayer;
		public static Type UnityEditor_PostprocessBuildPlayer => Get( ref _UnityEditor_PostprocessBuildPlayer, "UnityEditor.PostprocessBuildPlayer", "UnityEditor" );

		static Type _DesktopStandaloneBuildWindowExtension;
		public static Type DesktopStandaloneBuildWindowExtension => Get( ref _DesktopStandaloneBuildWindowExtension, "DesktopStandaloneBuildWindowExtension", "UnityEditor" );

		static Type _UnityEditor_WebGL_HttpServerEditorWrapper;
		public static Type UnityEditor_WebGL_HttpServerEditorWrapper => Get( ref _UnityEditor_WebGL_HttpServerEditorWrapper, "UnityEditor.WebGL.HttpServerEditorWrapper", "UnityEditor.WebGL.Extensions" );

		static Type _UnityEditor_UnityType;
		public static Type UnityEditor_UnityType => Get( ref _UnityEditor_UnityType, "UnityEditor.UnityType", "UnityEditor" );

	}
}
