
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEngine_Rendering_Universal_UniversalRenderPipelineAsset;
		public static Type UnityEngine_Rendering_Universal_UniversalRenderPipelineAsset => Get( ref _UnityEngine_Rendering_Universal_UniversalRenderPipelineAsset, "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", "Unity.RenderPipelines.Universal.Runtime" );

		static Type _UnityEngine_Rendering_HighDefinition_HDRenderPipelineAsset;
		public static Type UnityEngine_Rendering_HighDefinition_HDRenderPipelineAsset => Get( ref _UnityEngine_Rendering_HighDefinition_HDRenderPipelineAsset, "UnityEngine.Rendering.HighDefinition.HDRenderPipelineAsset", "Unity.RenderPipelines.HighDefinition.Runtime" );

		static Type _UnityEngine_Rendering_RenderPipelineAsset;
		public static Type UnityEngine_Rendering_RenderPipelineAsset {
			get {
				if( _UnityEngine_Rendering_RenderPipelineAsset == null ) {
					if( UnitySymbol.UNITY_2019_1_OR_NEWER ) {
						_UnityEngine_Rendering_RenderPipelineAsset = Get( ref _UnityEngine_Rendering_RenderPipelineAsset,"UnityEngine.Rendering.RenderPipelineAsset", "UnityEngine" );
					}
					else {
						_UnityEngine_Rendering_RenderPipelineAsset = Get( ref _UnityEngine_Rendering_RenderPipelineAsset,"UnityEngine.Experimental.Rendering.RenderPipelineAsset", "UnityEngine" );
					}
				}
				return _UnityEngine_Rendering_RenderPipelineAsset;
			}
		}

		static Type _UnityEditor_Rendering_Universal_UniversalRenderPipelineMaterialUpgrader;
		public static Type UnityEditor_Rendering_Universal_UniversalRenderPipelineMaterialUpgrader => Get( ref _UnityEditor_Rendering_Universal_UniversalRenderPipelineMaterialUpgrader, "UnityEditor.Rendering.Universal.UniversalRenderPipelineMaterialUpgrader", "Unity.RenderPipelines.Universal.Editor" );

		static Type _UnityEngine_Rendering_Universal_ScriptableRenderer;
		public static Type UnityEngine_Rendering_Universal_ScriptableRenderer => Get( ref _UnityEngine_Rendering_Universal_ScriptableRenderer, "UnityEngine.Rendering.Universal.ScriptableRenderer", "Unity.RenderPipelines.Universal.Runtime" );

		static Type _UnityEngine_Rendering_Universal_ScriptableRendererData;
		public static Type UnityEngine_Rendering_Universal_ScriptableRendererData => Get( ref _UnityEngine_Rendering_Universal_ScriptableRendererData, "UnityEngine.Rendering.Universal.ScriptableRendererData", "Unity.RenderPipelines.Universal.Runtime" );

	}
}
