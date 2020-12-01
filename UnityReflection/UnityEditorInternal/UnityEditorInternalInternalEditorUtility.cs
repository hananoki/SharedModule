/// UnityEditorInternal.InternalEditorUtility : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorInternalInternalEditorUtility {
    
		public static void RequestScriptReload() {
			if( __RequestScriptReload_0_0 == null ) {
				__RequestScriptReload_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), null, UnityTypes.UnityEditorInternal_InternalEditorUtility.GetMethod( "RequestScriptReload", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			__RequestScriptReload_0_0(  );
		}
		
		
		
		static Action __RequestScriptReload_0_0;
	}
}

