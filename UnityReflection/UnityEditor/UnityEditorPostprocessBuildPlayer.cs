/// UnityEditor.PostprocessBuildPlayer : 2020.2.7f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorPostprocessBuildPlayer {

		public static class Cache<T> {
			public static T cache;
		}

		public static void Launch( UnityEditor.BuildTargetGroup targetGroup, UnityEditor.BuildTarget buildTarget, string path, string productName, UnityEditor.BuildOptions options, UnityEditor.Build.Reporting.BuildReport buildReport ) {
			if( __Launch_0_6 == null ) {
				__Launch_0_6 = (Action<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget,string,string,UnityEditor.BuildOptions,UnityEditor.Build.Reporting.BuildReport>) Delegate.CreateDelegate( typeof( Action<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget,string,string,UnityEditor.BuildOptions,UnityEditor.Build.Reporting.BuildReport> ), null, UnityTypes.UnityEditor_PostprocessBuildPlayer.GetMethod( "Launch", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.BuildTargetGroup ), typeof( UnityEditor.BuildTarget ), typeof( string ), typeof( string ), typeof( UnityEditor.BuildOptions ), typeof( UnityEditor.Build.Reporting.BuildReport ) }, null ) );
			}
			__Launch_0_6( targetGroup, buildTarget, path, productName, options, buildReport );
		}
		
		
		
		static Action<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget,string,string,UnityEditor.BuildOptions,UnityEditor.Build.Reporting.BuildReport> __Launch_0_6;
	}
}

