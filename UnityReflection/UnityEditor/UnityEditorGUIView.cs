/// UnityEditor.GUIView : 2019.4.16f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorGUIView {

		public static object current {
			get {
				if( __getter_current == null ) {
					__getter_current = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), null, UnityTypes.UnityEditor_GUIView.GetMethod( "get_current", R.StaticMembers ) );
				}
				return __getter_current();
			}
		}

		
		
		static Func<object> __getter_current;
	}
}

