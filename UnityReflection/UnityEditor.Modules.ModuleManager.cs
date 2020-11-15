
using Hananoki.Reflection;
using UnityEditor;

namespace Hananoki {
	public static partial class UnityEditorModulesModuleManager {
		public static string GetTargetStringFrom( BuildTargetGroup targetGroup, BuildTarget target ) {
			return UnityTypes.UnityEditor_Modules_ModuleManager.MethodInvoke<string>( "GetTargetStringFrom", new object[] { targetGroup, target } );
		}
	}
}
