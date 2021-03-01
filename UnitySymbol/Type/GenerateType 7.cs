
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEngine_Rendering_GraphicsSettings;
		public static Type UnityEngine_Rendering_GraphicsSettings => Get( ref _UnityEngine_Rendering_GraphicsSettings, "UnityEngine.Rendering.GraphicsSettings", "UnityEngine" );

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

	}
}
