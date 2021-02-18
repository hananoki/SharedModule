using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace HananokiEditor {
	public class GraphicsSettingsUtils {
		public static RenderPipelineAsset currentRenderPipeline {
			get {
#if UNITY_2019_3_OR_NEWER
				return GraphicsSettings.currentRenderPipeline;
#else
				return GraphicsSettings.renderPipelineAsset;
#endif
			}
			set {
#if UNITY_2019_3_OR_NEWER
				GraphicsSettings.renderPipelineAsset = value;
#else
				return GraphicsSettings.renderPipelineAsset;
#endif
			}
		}
	}
}
