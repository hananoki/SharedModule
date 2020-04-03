/// UnityEditor.EditorUserBuildSettingsUtils : 2019.3.0f6

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public static partial class UnityEditorUserBuildSettingsUtils {
    delegate UnityEditor.BuildTarget Method_CalculateSelectedBuildTarget0();
    static Method_CalculateSelectedBuildTarget0 __CalculateSelectedBuildTarget0;
    public static UnityEditor.BuildTarget CalculateSelectedBuildTarget() {
      if( __CalculateSelectedBuildTarget0 == null ) {
        __CalculateSelectedBuildTarget0 = (Method_CalculateSelectedBuildTarget0) Delegate.CreateDelegate( typeof( Method_CalculateSelectedBuildTarget0 ), null, R.Method("CalculateSelectedBuildTarget", "UnityEditor.EditorUserBuildSettingsUtils", "UnityEditor.dll") );
      }
      return __CalculateSelectedBuildTarget0(  );
    }



	}
}

#endif

