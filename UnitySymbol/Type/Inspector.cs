
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEditor_ShaderVariantCollectionInspector;
		public static Type UnityEditor_ShaderVariantCollectionInspector => Get( ref _UnityEditor_ShaderVariantCollectionInspector, "UnityEditor.ShaderVariantCollectionInspector", "UnityEditor" );

		static Type _UnityEditor_PropertyEditor;
		public static Type UnityEditor_PropertyEditor => Get( ref _UnityEditor_PropertyEditor, "UnityEditor.PropertyEditor", "UnityEditor" );

	}
}
