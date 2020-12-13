/// UnityEditor.Toolbar : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorToolbar {

		public static class Cache<T> {
			public static T cache;
		}

		public static void RepaintToolbar() {
			if( __RepaintToolbar_0_0 == null ) {
				__RepaintToolbar_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), null, UnityTypes.UnityEditor_Toolbar.GetMethod( "RepaintToolbar", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			__RepaintToolbar_0_0();
		}
		
		
		
		static Action __RepaintToolbar_0_0;
	}
}

