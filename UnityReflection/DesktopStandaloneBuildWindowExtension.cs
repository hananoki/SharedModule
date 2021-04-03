/// DesktopStandaloneBuildWindowExtension : 2020.2.7f1

using HananokiEditor;
using System;
using System.Collections;

namespace UnityReflection {
  public sealed partial class DesktopStandaloneBuildWindowExtension {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public DesktopStandaloneBuildWindowExtension( object instance ){
			m_instance = instance;
    }
    public DesktopStandaloneBuildWindowExtension( bool hasIl2CppPlayers ) {
			m_instance = Activator.CreateInstance( UnityTypes.DesktopStandaloneBuildWindowExtension, new object[] { hasIl2CppPlayers } );
    }
    

		public static IDictionary GetArchitecturesForPlatform( UnityEditor.BuildTarget target ) {
			if( __GetArchitecturesForPlatform_0_1 == null ) {
				__GetArchitecturesForPlatform_0_1 = (Func<UnityEditor.BuildTarget, IDictionary>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTarget, IDictionary> ), null, UnityTypes.DesktopStandaloneBuildWindowExtension.GetMethod( "GetArchitecturesForPlatform", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.BuildTarget ) }, null ) );
			}
			return __GetArchitecturesForPlatform_0_1( target );
		}
		
		public string GetCannotBuildIl2CppPlayerInCurrentSetupError() {
			if( __GetCannotBuildIl2CppPlayerInCurrentSetupError_0_0 == null ) {
				__GetCannotBuildIl2CppPlayerInCurrentSetupError_0_0 = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), m_instance, UnityTypes.DesktopStandaloneBuildWindowExtension.GetMethod( "GetCannotBuildIl2CppPlayerInCurrentSetupError", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __GetCannotBuildIl2CppPlayerInCurrentSetupError_0_0();
		}
		
		
		
		static Func<UnityEditor.BuildTarget, IDictionary> __GetArchitecturesForPlatform_0_1;
		Func<string> __GetCannotBuildIl2CppPlayerInCurrentSetupError_0_0;
	}
}

