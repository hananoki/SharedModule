/// UnityEditor.ObjectNames : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorObjectNames {

		public static class Cache<T> {
			public static T cache;
		}

		public static string GetTypeName( UnityEngine.Object obj ) {
			if( __GetTypeName_0_1 == null ) {
				__GetTypeName_0_1 = (Func<UnityEngine.Object, string>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Object, string> ), null, UnityTypes.UnityEditor_ObjectNames.GetMethod( "GetTypeName", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Object ) }, null ) );
			}
			return __GetTypeName_0_1( obj );
		}
		
		
		
		static Func<UnityEngine.Object, string> __GetTypeName_0_1;
	}
}

