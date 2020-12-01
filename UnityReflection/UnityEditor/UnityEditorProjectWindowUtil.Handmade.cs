/// UnityEditor.ProjectWindowUtil : 2019.4.5f1

#if UNITY_EDITOR

using Hananoki;
using Hananoki.Reflection;
using System;
using System.Reflection;

namespace UnityReflection {
	public sealed partial class UnityEditorProjectWindowUtil {
		
		// 2018.4まで
		public static void CreateScriptAsset( string templatePath, string defaultNewFileName ) {
			if( __CreateScriptAsset == null ) {
				__CreateScriptAsset = (Action<string, string>) Delegate.CreateDelegate( typeof( Action<string, string> ), null, UnityTypes.UnityEditor_ProjectWindowUtil.GetMethod( "CreateScriptAsset", R.StaticMembers, null, new Type[] { typeof( string ), typeof( string ) }, null ) );
			}
			__CreateScriptAsset( templatePath, defaultNewFileName );
		}


		static Action<string, string> __CreateScriptAsset;
	}
}

#endif

