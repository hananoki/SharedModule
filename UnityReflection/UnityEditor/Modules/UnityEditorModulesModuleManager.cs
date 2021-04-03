/// UnityEditor.Modules.ModuleManager : 2020.3.0f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorModulesModuleManager {

		public static class Cache<T> {
			public static T cache;
		}

		public static string GetTargetStringFrom( UnityEditor.BuildTargetGroup targetGroup, UnityEditor.BuildTarget target ) {
			if( __GetTargetStringFrom_0_2 == null ) {
				__GetTargetStringFrom_0_2 = (Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, string>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, string> ), null, UnityTypes.UnityEditor_Modules_ModuleManager.GetMethod( "GetTargetStringFrom", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.BuildTargetGroup ), typeof( UnityEditor.BuildTarget ) }, null ) );
			}
			return __GetTargetStringFrom_0_2( targetGroup, target );
		}
		
		public static object GetBuildWindowExtension( string target ) {
			if( __GetBuildWindowExtension_0_1 == null ) {
				__GetBuildWindowExtension_0_1 = (Func<string, object>) Delegate.CreateDelegate( typeof( Func<string, object> ), null, UnityTypes.UnityEditor_Modules_ModuleManager.GetMethod( "GetBuildWindowExtension", R.StaticMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			return __GetBuildWindowExtension_0_1( target );
		}
		
		public static object GetBuildPostProcessor( string target ) {
			if( __GetBuildPostProcessor_0_1 == null ) {
				__GetBuildPostProcessor_0_1 = (Func<string, object>) Delegate.CreateDelegate( typeof( Func<string, object> ), null, UnityTypes.UnityEditor_Modules_ModuleManager.GetMethod( "GetBuildPostProcessor", R.StaticMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			return __GetBuildPostProcessor_0_1( target );
		}
		
		public static object GetBuildPostProcessor( UnityEditor.BuildTargetGroup targetGroup, UnityEditor.BuildTarget target ) {
			if( __GetBuildPostProcessor_1_2 == null ) {
				__GetBuildPostProcessor_1_2 = (Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, object>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, object> ), null, UnityTypes.UnityEditor_Modules_ModuleManager.GetMethod( "GetBuildPostProcessor", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.BuildTargetGroup ), typeof( UnityEditor.BuildTarget ) }, null ) );
			}
			return __GetBuildPostProcessor_1_2( targetGroup, target );
		}
		
		
		
		static Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, string> __GetTargetStringFrom_0_2;
		static Func<string, object> __GetBuildWindowExtension_0_1;
		static Func<string, object> __GetBuildPostProcessor_0_1;
		static Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, object> __GetBuildPostProcessor_1_2;
	}
}

