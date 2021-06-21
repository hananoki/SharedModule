/// UnityEditor.ShaderUtil : 2020.3.8f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorShaderUtil {

		public static class Cache<T> {
			public static T cache;
		}

		public static bool AddNewShaderToCollection( UnityEngine.Shader shader, UnityEngine.ShaderVariantCollection collection ) {
			if( __AddNewShaderToCollection_0_2 == null ) {
				__AddNewShaderToCollection_0_2 = (Func<UnityEngine.Shader,UnityEngine.ShaderVariantCollection, bool>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Shader,UnityEngine.ShaderVariantCollection, bool> ), null, UnityTypes.UnityEditor_ShaderUtil.GetMethod( "AddNewShaderToCollection", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Shader ), typeof( UnityEngine.ShaderVariantCollection ) }, null ) );
			}
			return __AddNewShaderToCollection_0_2( shader, collection );
		}
		
		
		
		static Func<UnityEngine.Shader,UnityEngine.ShaderVariantCollection, bool> __AddNewShaderToCollection_0_2;
	}
}

