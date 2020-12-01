
using NUnit.Framework;

namespace Hananoki.Tests {
	public static class TypeGenerator {
		[Test]
		public static void TypeGeneratorTest() {
			Assert.IsNotNull( UnityTypes.UnityEngine_SpriteRenderer, "UnityEngine_SpriteRenderer" );
			Assert.IsNotNull( UnityTypes.UnityEngine_UI_Image, "UnityEngine_UI_Image" );
			Assert.IsNotNull( UnityTypes.UnityEngine_UI_RawImage, "UnityEngine_UI_RawImage" );
			Assert.IsNotNull( UnityTypes.TMPro_TMP_Text, "TMPro_TMP_Text" );
			Assert.IsNotNull( UnityTypes.TMPro_TextMeshProUGUI, "TMPro_TextMeshProUGUI" );
			Assert.IsNotNull( UnityTypes.UnityEditor_UI_SpriteDrawUtility, "UnityEditor_UI_SpriteDrawUtility" );
			Assert.IsNotNull( UnityTypes.UnityEditorInternal_InternalEditorUtility, "UnityEditorInternal_InternalEditorUtility" );

		}
	}
}

