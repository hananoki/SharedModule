
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEditor_UIElements_VisualSplitter;
		public static Type UnityEditor_UIElements_VisualSplitter {
			get {
				if( _UnityEditor_UIElements_VisualSplitter == null ) {
					if( UnitySymbol.UNITY_2019_1_OR_NEWER ) {
						_UnityEditor_UIElements_VisualSplitter = Get( ref _UnityEditor_UIElements_VisualSplitter,"UnityEditor.UIElements.VisualSplitter", "UnityEditor" );
					}
					else {
						_UnityEditor_UIElements_VisualSplitter = Get( ref _UnityEditor_UIElements_VisualSplitter,"UnityEngine.Experimental.UIElements.VisualSplitter", "UnityEditor" );
					}
				}
				return _UnityEditor_UIElements_VisualSplitter;
			}
		}

		static Type _UnityEngine_UIElements_StyleSheets_Dimension;
		public static Type UnityEngine_UIElements_StyleSheets_Dimension => Get( ref _UnityEngine_UIElements_StyleSheets_Dimension, "UnityEngine.UIElements.StyleSheets.Dimension", "UnityEngine" );

		static Type _UnityEditor_UIElements_ToolbarButton;
		public static Type UnityEditor_UIElements_ToolbarButton => Get( ref _UnityEditor_UIElements_ToolbarButton, "UnityEditor.UIElements.ToolbarButton", "UnityEditor" );

		static Type _TMPro_EditorUtilities_TMP_UiEditorPanel;
		public static Type TMPro_EditorUtilities_TMP_UiEditorPanel => Get( ref _TMPro_EditorUtilities_TMP_UiEditorPanel, "TMPro.EditorUtilities.TMP_UiEditorPanel", "Unity.TextMeshPro" );

		static Type _UnityEngine_Rendering_Universal_UniversalRenderPipelineAsset;
		public static Type UnityEngine_Rendering_Universal_UniversalRenderPipelineAsset => Get( ref _UnityEngine_Rendering_Universal_UniversalRenderPipelineAsset, "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", "Unity.RenderPipelines.Universal.Runtime" );

		static Type _UnityEngine_Rendering_HighDefinition_HDRenderPipelineAsset;
		public static Type UnityEngine_Rendering_HighDefinition_HDRenderPipelineAsset => Get( ref _UnityEngine_Rendering_HighDefinition_HDRenderPipelineAsset, "UnityEngine.Rendering.HighDefinition.HDRenderPipelineAsset", "Unity.RenderPipelines.HighDefinition.Runtime" );

	}
}
