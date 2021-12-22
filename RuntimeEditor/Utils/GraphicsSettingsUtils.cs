
//#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityReflection;
//#else
//using UnityEngine.Rendering;
//using UnityEngine.Experimental.Rendering;
//#endif

namespace HananokiEditor {
	public class GraphicsSettingsUtils {
		public static object renderPipelineAsset {
			get {
				return UnityEngineRenderingGraphicsSettings.renderPipelineAsset;
			}
			//			set {
			//#if UNITY_2019_3_OR_NEWER
			//				GraphicsSettings.renderPipelineAsset = value;
			//#else
			//				//GraphicsSettings.renderPipelineAsset = value; ;
			//#endif
			//			}
		}
		

		public static void UpgradeSelectedMaterial() {
			if( UnityProject.URP ) {
				EditorApplication.ExecuteMenuItem( "Edit/Render Pipeline/Universal Render Pipeline/Upgrade Selected Materials to UniversalRP Materials" );
			}
			if( UnityProject.HDRP ) {
				EditorApplication.ExecuteMenuItem( "Edit/Render Pipeline/HD Render Pipeline/Upgrade from Builtin pipeline/Upgrade Selected Materials to High Definition Materials" );
			}

		}
	}
}
