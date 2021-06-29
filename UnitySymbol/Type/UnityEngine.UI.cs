
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEngine_UI_Image;
		public static Type UnityEngine_UI_Image => Get( ref _UnityEngine_UI_Image, "UnityEngine.UI.Image", "UnityEngine.UI" );

		static Type _UnityEngine_UI_RawImage;
		public static Type UnityEngine_UI_RawImage => Get( ref _UnityEngine_UI_RawImage, "UnityEngine.UI.RawImage", "UnityEngine.UI" );

		static Type _UnityEditor_UI_SpriteDrawUtility;
		public static Type UnityEditor_UI_SpriteDrawUtility => Get( ref _UnityEditor_UI_SpriteDrawUtility, "UnityEditor.UI.SpriteDrawUtility", "UnityEngine.UI" );

	}
}
