
using Hananoki.Reflection;
using System;
using System.Collections.Generic;
using UnityEditor;

namespace Hananoki {
	public class UnityEditorBuildPlayerWindow {

		//static IDictionary<string, string> _s_ModuleNames;

		//public static Dictionary<string, string> s_ModuleNames {
		//	get {
		//		if( _s_ModuleNames == null ) {
		//			_s_ModuleNames = (IDictionary<string, string>) UnityTypes.BuildPlayerWindow.GetField( "s_ModuleNames", R.AllMembers ).GetValue( null );
		//		}
		//		return (Dictionary<string, string>) _s_ModuleNames;
		//	}
		//}

		

		public static void BuildPlayerAndRun() {
			UnityTypes.BuildPlayerWindow.MethodInvoke( "BuildPlayerAndRun", new Type[] { }, null );
		}

		public static void BuildPlayerAndRun( bool askForBuildLocation ) {
			UnityTypes.BuildPlayerWindow.MethodInvoke( "BuildPlayerAndRun", new Type[] { typeof( bool ) }, new object[] { askForBuildLocation } );
		}


		


		public static string GetUnityHubModuleDownloadURL( string moduleName ) {
			return UnityTypes.BuildPlayerWindow.MethodInvoke<string>( "GetUnityHubModuleDownloadURL", new object[] { moduleName } );
		}

		public static string GetUnityHubModuleDownloadURL( BuildTargetGroup targetGroup, BuildTarget target ) {
			var moduleName = UnityEditorModulesModuleManager.GetTargetStringFrom( targetGroup, target );
			return UnityTypes.BuildPlayerWindow.MethodInvoke<string>( "GetUnityHubModuleDownloadURL", new object[] { moduleName } );
		}


		/// <summary>
		/// BuildTargetGroupはサポートされていますか
		/// </summary>
		/// <param name="targetGroup"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public static bool IsBuildTargetGroupSupported( BuildTargetGroup targetGroup, BuildTarget target ) {
			return UnityTypes.BuildPlayerWindow.MethodInvoke<bool>( "IsBuildTargetGroupSupported", new object[] { targetGroup, target } );
		}


		/// <summary>
		/// StandaloneModuleがロードされていますか
		/// </summary>
		/// <returns></returns>
		public static bool IsAnyStandaloneModuleLoaded() {
			return UnityTypes.BuildPlayerWindow.MethodInvoke<bool>( "IsAnyStandaloneModuleLoaded", null );
		}

		//public static bool IsColorSpaceValid( BuildPlatform platform ) {

		//}


		public bool IsModuleNotInstalled( BuildTargetGroup buildTargetGroup, BuildTarget buildTarget ) {
			return UnityTypes.BuildPlayerWindow.MethodInvoke<bool>( "IsModuleNotInstalled", new object[] { buildTargetGroup, buildTarget } );
		}

		public static bool IsEditorInstalledWithHub() {
			return UnityTypes.BuildPlayerWindow.MethodInvoke<bool>( "IsEditorInstalledWithHub", null );
		}

		public static void ShowBuildPlayerWindow() {
			UnityTypes.BuildPlayerWindow.MethodInvoke( "ShowBuildPlayerWindow", null );
		}

		//public static void ShowBuildTargetSettings() {
		//	UnityTypes.BuildPlayerWindow.MethodInvoke( "ShowBuildPlayerWindow", null );
		//}
	}
}
