/// Unity.MPE.ProcessService : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityMPEProcessService {

		public static int level {
			get {
				if( __getter_level == null ) {
					__getter_level = (Func<int>) Delegate.CreateDelegate( typeof( Func<int> ), null, UnityTypes.Unity_MPE_ProcessService.GetMethod( "get_level", R.StaticMembers ) );
				}
				return __getter_level();
			}
		}

		
		
		static Func<int> __getter_level;
	}
}

