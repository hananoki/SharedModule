
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEngine_VFX_VisualEffectAsset;
		public static Type UnityEngine_VFX_VisualEffectAsset {
			get {
				if( _UnityEngine_VFX_VisualEffectAsset == null ) {
					if( UnitySymbol.UNITY_2019_3_OR_NEWER ) {
						_UnityEngine_VFX_VisualEffectAsset = Get( ref _UnityEngine_VFX_VisualEffectAsset,"UnityEngine.VFX.VisualEffectAsset", "UnityEngine" );
					}
					else {
						_UnityEngine_VFX_VisualEffectAsset = Get( ref _UnityEngine_VFX_VisualEffectAsset,"UnityEngine.Experimental.VFX.VisualEffectAsset", "UnityEngine" );
					}
				}
				return _UnityEngine_VFX_VisualEffectAsset;
			}
		}

	}
}
