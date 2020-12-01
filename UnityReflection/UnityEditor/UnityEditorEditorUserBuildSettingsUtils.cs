/// UnityEditor.EditorUserBuildSettingsUtils : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorEditorUserBuildSettingsUtils {
    
		public static UnityEditor.BuildTarget CalculateSelectedBuildTarget() {
			if( __CalculateSelectedBuildTarget_0_0 == null ) {
				__CalculateSelectedBuildTarget_0_0 = (Func<UnityEditor.BuildTarget>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTarget> ), null, UnityTypes.UnityEditor_EditorUserBuildSettingsUtils.GetMethod( "CalculateSelectedBuildTarget", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __CalculateSelectedBuildTarget_0_0(  );
		}
		
		
		
		static Func<UnityEditor.BuildTarget> __CalculateSelectedBuildTarget_0_0;
	}
}

