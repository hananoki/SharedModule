/// UnityEditor.PropertyEditor : 2020.3.8f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorPropertyEditor {

		public static class Cache<T> {
			public static T cache;
		}

		public static object OpenPropertyEditor( UnityEngine.Object obj, bool showWindow = true ) {
			if( __OpenPropertyEditor_0_2 == null ) {
				__OpenPropertyEditor_0_2 = (Func<UnityEngine.Object,bool, object>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Object,bool, object> ), null, UnityTypes.UnityEditor_PropertyEditor.GetMethod( "OpenPropertyEditor", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Object ), typeof( bool ) }, null ) );
			}
			return __OpenPropertyEditor_0_2( obj, showWindow );
		}
		
		
		
		static Func<UnityEngine.Object,bool, object> __OpenPropertyEditor_0_2;
	}
}

