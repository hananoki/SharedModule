
using System;

namespace Hananoki {
	public static partial class UnityTypes {

		static Type _UnityEngine_SpriteRenderer;
		public static Type UnityEngine_SpriteRenderer => Get( ref _UnityEngine_SpriteRenderer, "UnityEngine.SpriteRenderer", "UnityEngine.CoreModule" );

		static Type _UnityEngine_UI_Image;
		public static Type UnityEngine_UI_Image => Get( ref _UnityEngine_UI_Image, "UnityEngine.UI.Image", "UnityEngine.UI" );

		static Type _UnityEngine_UI_RawImage;
		public static Type UnityEngine_UI_RawImage => Get( ref _UnityEngine_UI_RawImage, "UnityEngine.UI.RawImage", "UnityEngine.UI" );

		static Type _TMPro_TMP_Text;
		public static Type TMPro_TMP_Text => Get( ref _TMPro_TMP_Text, "TMPro.TMP_Text", "Unity.TextMeshPro" );

		static Type _TMPro_TextMeshProUGUI;
		public static Type TMPro_TextMeshProUGUI => Get( ref _TMPro_TextMeshProUGUI, "TMPro.TextMeshProUGUI", "Unity.TextMeshPro" );

		static Type _UnityEditor_UI_SpriteDrawUtility;
		public static Type UnityEditor_UI_SpriteDrawUtility => Get( ref _UnityEditor_UI_SpriteDrawUtility, "UnityEditor.UI.SpriteDrawUtility", "UnityEditor.UI" );

		static Type _UnityEditorInternal_InternalEditorUtility;
		public static Type UnityEditorInternal_InternalEditorUtility => Get( ref _UnityEditorInternal_InternalEditorUtility, "UnityEditorInternal.InternalEditorUtility", "UnityEditor" );

	}
}
