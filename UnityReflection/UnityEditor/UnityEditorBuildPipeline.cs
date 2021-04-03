/// UnityEditor.BuildPipeline : 2020.3.0f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorBuildPipeline {

		public static class Cache<T> {
			public static T cache;
		}

		public static bool LicenseCheck( UnityEditor.BuildTarget target ) {
			if( __LicenseCheck_0_1 == null ) {
				__LicenseCheck_0_1 = (Func<UnityEditor.BuildTarget, bool>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTarget, bool> ), null, UnityTypes.UnityEditor_BuildPipeline.GetMethod( "LicenseCheck", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.BuildTarget ) }, null ) );
			}
			return __LicenseCheck_0_1( target );
		}
		
		
		
		static Func<UnityEditor.BuildTarget, bool> __LicenseCheck_0_1;
	}
}

