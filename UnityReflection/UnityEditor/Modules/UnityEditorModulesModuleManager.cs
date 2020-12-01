/// UnityEditor.Modules.ModuleManager : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorModulesModuleManager {
    
		public static string GetTargetStringFrom( UnityEditor.BuildTargetGroup targetGroup, UnityEditor.BuildTarget target ) {
			if( __GetTargetStringFrom_0_2 == null ) {
				__GetTargetStringFrom_0_2 = (Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, string>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, string> ), null, UnityTypes.UnityEditor_Modules_ModuleManager.GetMethod( "GetTargetStringFrom", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.BuildTargetGroup ), typeof( UnityEditor.BuildTarget ) }, null ) );
			}
			return __GetTargetStringFrom_0_2( targetGroup, target );
		}
		
		
		
		static Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, string> __GetTargetStringFrom_0_2;
	}
}

