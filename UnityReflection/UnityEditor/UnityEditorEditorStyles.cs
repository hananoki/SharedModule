/// UnityEditor.EditorStyles : 2020.3.0f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorEditorStyles {

		public static UnityEngine.GUIStyle inspectorTitlebar {
			get {
				if( __getter_inspectorTitlebar == null ) {
					__getter_inspectorTitlebar = (Func<UnityEngine.GUIStyle>) Delegate.CreateDelegate( typeof( Func<UnityEngine.GUIStyle> ), null, UnityTypes.UnityEditor_EditorStyles.GetMethod( "get_inspectorTitlebar", R.StaticMembers ) );
				}
				return __getter_inspectorTitlebar();
			}
		}

		
		
		static Func<UnityEngine.GUIStyle> __getter_inspectorTitlebar;
	}
}

