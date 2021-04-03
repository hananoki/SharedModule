/// UnityEditor.Unsupported : 2020.3.0f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorUnsupported {

		public static class Cache<T> {
			public static T cache;
		}

		public static string[] GetSubmenusLocalized( string menuPath ) {
			if( __GetSubmenusLocalized_0_1 == null ) {
				__GetSubmenusLocalized_0_1 = (Func<string, string[]>) Delegate.CreateDelegate( typeof( Func<string, string[]> ), null, UnityTypes.UnityEditor_Unsupported.GetMethod( "GetSubmenusLocalized", R.StaticMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			return __GetSubmenusLocalized_0_1( menuPath );
		}
		
		
		
		static Func<string, string[]> __GetSubmenusLocalized_0_1;
	}
}

