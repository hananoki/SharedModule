using UnityEditor;

namespace UnityReflection {
	public sealed partial class UnityEditorEditorUserBuildSettingsUtils {
		public static BuildTarget CalculateSelectedBuildTarget( BuildTargetGroup group ) {
			var bak = EditorUserBuildSettings.selectedBuildTargetGroup;
			EditorUserBuildSettings.selectedBuildTargetGroup = group;

			var ret = CalculateSelectedBuildTarget();

			EditorUserBuildSettings.selectedBuildTargetGroup = bak;
			return ret;
		}
	}
}

