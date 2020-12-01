/// UnityEditor.BuildPlayerWindow : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorBuildPlayerWindow {
		public object m_instance;
    
    public UnityEditorBuildPlayerWindow( object instance ){
			m_instance = instance;
    }
   // public UnityEditorBuildPlayerWindow() {
			//m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_BuildPlayerWindow, new object[] {} );
   // }
    
    
		public static void BuildPlayerAndRun() {
			if( __BuildPlayerAndRun_0_0 == null ) {
				__BuildPlayerAndRun_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), null, UnityTypes.UnityEditor_BuildPlayerWindow.GetMethod( "BuildPlayerAndRun", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			__BuildPlayerAndRun_0_0(  );
		}
		
		public static void BuildPlayerAndRun( bool askForBuildLocation ) {
			if( __BuildPlayerAndRun_1_1 == null ) {
				__BuildPlayerAndRun_1_1 = (Action<bool>) Delegate.CreateDelegate( typeof( Action<bool> ), null, UnityTypes.UnityEditor_BuildPlayerWindow.GetMethod( "BuildPlayerAndRun", R.StaticMembers, null, new Type[]{ typeof( bool ) }, null ) );
			}
			__BuildPlayerAndRun_1_1( askForBuildLocation );
		}
		
		public static string GetUnityHubModuleDownloadURL( string moduleName ) {
			if( __GetUnityHubModuleDownloadURL_0_1 == null ) {
				__GetUnityHubModuleDownloadURL_0_1 = (Func<string, string>) Delegate.CreateDelegate( typeof( Func<string, string> ), null, UnityTypes.UnityEditor_BuildPlayerWindow.GetMethod( "GetUnityHubModuleDownloadURL", R.StaticMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			return __GetUnityHubModuleDownloadURL_0_1( moduleName );
		}
		
		public static bool IsBuildTargetGroupSupported( UnityEditor.BuildTargetGroup targetGroup, UnityEditor.BuildTarget target ) {
			if( __IsBuildTargetGroupSupported_0_2 == null ) {
				__IsBuildTargetGroupSupported_0_2 = (Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, bool>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, bool> ), null, UnityTypes.UnityEditor_BuildPlayerWindow.GetMethod( "IsBuildTargetGroupSupported", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.BuildTargetGroup ), typeof( UnityEditor.BuildTarget ) }, null ) );
			}
			return __IsBuildTargetGroupSupported_0_2( targetGroup, target );
		}
		
		public static bool IsAnyStandaloneModuleLoaded() {
			if( __IsAnyStandaloneModuleLoaded_0_0 == null ) {
				__IsAnyStandaloneModuleLoaded_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), null, UnityTypes.UnityEditor_BuildPlayerWindow.GetMethod( "IsAnyStandaloneModuleLoaded", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __IsAnyStandaloneModuleLoaded_0_0(  );
		}
		
		public static bool IsEditorInstalledWithHub() {
			if( __IsEditorInstalledWithHub_0_0 == null ) {
				__IsEditorInstalledWithHub_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), null, UnityTypes.UnityEditor_BuildPlayerWindow.GetMethod( "IsEditorInstalledWithHub", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __IsEditorInstalledWithHub_0_0(  );
		}
		
		public static void ShowBuildPlayerWindow() {
			if( __ShowBuildPlayerWindow_0_0 == null ) {
				__ShowBuildPlayerWindow_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), null, UnityTypes.UnityEditor_BuildPlayerWindow.GetMethod( "ShowBuildPlayerWindow", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			__ShowBuildPlayerWindow_0_0(  );
		}
		
		public bool IsModuleNotInstalled( UnityEditor.BuildTargetGroup buildTargetGroup, UnityEditor.BuildTarget buildTarget ) {
			if( __IsModuleNotInstalled_0_2 == null ) {
				__IsModuleNotInstalled_0_2 = (Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, bool>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, bool> ), m_instance, UnityTypes.UnityEditor_BuildPlayerWindow.GetMethod( "IsModuleNotInstalled", R.InstanceMembers, null, new Type[]{ typeof( UnityEditor.BuildTargetGroup ), typeof( UnityEditor.BuildTarget ) }, null ) );
			}
			return __IsModuleNotInstalled_0_2( buildTargetGroup, buildTarget );
		}
		
		
		
		static Action __BuildPlayerAndRun_0_0;
		static Action<bool> __BuildPlayerAndRun_1_1;
		static Func<string, string> __GetUnityHubModuleDownloadURL_0_1;
		static Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, bool> __IsBuildTargetGroupSupported_0_2;
		static Func<bool> __IsAnyStandaloneModuleLoaded_0_0;
		static Func<bool> __IsEditorInstalledWithHub_0_0;
		static Action __ShowBuildPlayerWindow_0_0;
		Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, bool> __IsModuleNotInstalled_0_2;
	}
}

