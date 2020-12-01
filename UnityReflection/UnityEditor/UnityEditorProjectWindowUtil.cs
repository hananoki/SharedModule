/// UnityEditor.ProjectWindowUtil : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorProjectWindowUtil {
    
		public static object GetProjectBrowserIfExists() {
			if( __GetProjectBrowserIfExists_0_0 == null ) {
				__GetProjectBrowserIfExists_0_0 = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), null, UnityTypes.UnityEditor_ProjectWindowUtil.GetMethod( "GetProjectBrowserIfExists", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetProjectBrowserIfExists_0_0(  );
		}
		
		public static void CreateScriptAssetFromTemplateFile( string templatePath, string defaultNewFileName ) {
			if( __CreateScriptAssetFromTemplateFile_0_2 == null ) {
				__CreateScriptAssetFromTemplateFile_0_2 = (Action<string,string>) Delegate.CreateDelegate( typeof( Action<string,string> ), null, UnityTypes.UnityEditor_ProjectWindowUtil.GetMethod( "CreateScriptAssetFromTemplateFile", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( string ) }, null ) );
			}
			__CreateScriptAssetFromTemplateFile_0_2( templatePath, defaultNewFileName );
		}
		
		
		
		static Func<object> __GetProjectBrowserIfExists_0_0;
		static Action<string,string> __CreateScriptAssetFromTemplateFile_0_2;
	}
}

