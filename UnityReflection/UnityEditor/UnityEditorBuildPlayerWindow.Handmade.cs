using Hananoki;
using Hananoki.Reflection;
using UnityEditor;
using UnityEngine;
using System;

namespace UnityReflection {
	public sealed partial class UnityEditorBuildPlayerWindow {

		public UnityEditorBuildPlayerWindow() {
			var obj = Resources.FindObjectsOfTypeAll( UnityTypes.UnityEditor_BuildPlayerWindow );
			if( obj == null ) goto err;
			if( obj.Length == 0 ) goto err;

			m_instance = obj[ 0 ];
			return;
			err:
			throw new Exception( "Not Found BuildPlayerWindow" );
		}


		public static string GetUnityHubModuleDownloadURL( BuildTargetGroup targetGroup, BuildTarget target ) {
			var moduleName = UnityEditorModulesModuleManager.GetTargetStringFrom( targetGroup, target );
			return GetUnityHubModuleDownloadURL( moduleName );
		}

	}
}

