
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEditor_Build_BuildPlatforms;
		public static Type UnityEditor_Build_BuildPlatforms => Get( ref _UnityEditor_Build_BuildPlatforms, "UnityEditor.Build.BuildPlatforms", "UnityEditor" );

		static Type _UnityEditor_Build_BuildPlatform;
		public static Type UnityEditor_Build_BuildPlatform => Get( ref _UnityEditor_Build_BuildPlatform, "UnityEditor.Build.BuildPlatform", "UnityEditor" );

	}
}
