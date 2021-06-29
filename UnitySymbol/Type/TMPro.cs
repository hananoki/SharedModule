
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _TMPro_TMP_Text;
		public static Type TMPro_TMP_Text => Get( ref _TMPro_TMP_Text, "TMPro.TMP_Text", "Unity.TextMeshPro" );

		static Type _TMPro_TextMeshPro;
		public static Type TMPro_TextMeshPro => Get( ref _TMPro_TextMeshPro, "TMPro.TextMeshPro", "Unity.TextMeshPro" );

		static Type _TMPro_TextMeshProUGUI;
		public static Type TMPro_TextMeshProUGUI => Get( ref _TMPro_TextMeshProUGUI, "TMPro.TextMeshProUGUI", "Unity.TextMeshPro" );

		static Type _TMPro_TMP_FontAsset;
		public static Type TMPro_TMP_FontAsset => Get( ref _TMPro_TMP_FontAsset, "TMPro.TMP_FontAsset", "Unity.TextMeshPro" );

	}
}
