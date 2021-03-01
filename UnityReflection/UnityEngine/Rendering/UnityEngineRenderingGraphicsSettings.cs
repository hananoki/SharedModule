/// UnityEngine.Rendering.GraphicsSettings : 2019.4.21f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEngineRenderingGraphicsSettings {

		public static object renderPipelineAsset {
			get {
				if( __getter_renderPipelineAsset == null ) {
					__getter_renderPipelineAsset = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), null, UnityTypes.UnityEngine_Rendering_GraphicsSettings.GetMethod( "get_renderPipelineAsset", R.StaticMembers ) );
				}
				return __getter_renderPipelineAsset();
			}
			set {
				if( __setter_renderPipelineAsset == null ) {
					__setter_renderPipelineAsset = (Action<object>) Delegate.CreateDelegate( typeof( Action<object> ), null, UnityTypes.UnityEngine_Rendering_GraphicsSettings.GetMethod( "set_renderPipelineAsset", R.StaticMembers ) );
			  }
				__setter_renderPipelineAsset( value );
			}
		}

		
		
		static Func<object> __getter_renderPipelineAsset;
		static Action<object> __setter_renderPipelineAsset;
	}
}

