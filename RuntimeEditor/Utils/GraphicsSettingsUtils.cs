using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//#if UNITY_2019_1_OR_NEWER
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
	}
}
