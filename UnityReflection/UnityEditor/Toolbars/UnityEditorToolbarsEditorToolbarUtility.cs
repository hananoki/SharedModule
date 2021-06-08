/// UnityEditor.Toolbars.EditorToolbarUtility : 2021.1.7f1

#if UNITY_2021_1_OR_NEWER

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorToolbarsEditorToolbarUtility {

		public static class Cache<T> {
			public static T cache;
		}

		public static void LoadStyleSheets( string name, UnityEngine.UIElements.VisualElement target ) {
			if( __LoadStyleSheets_0_2 == null ) {
				__LoadStyleSheets_0_2 = (Action<string, UnityEngine.UIElements.VisualElement>) Delegate.CreateDelegate( typeof( Action<string, UnityEngine.UIElements.VisualElement> ), null, UnityTypes.UnityEditor_Toolbars_EditorToolbarUtility.GetMethod( "LoadStyleSheets", R.StaticMembers, null, new Type[] { typeof( string ), typeof( UnityEngine.UIElements.VisualElement ) }, null ) );
			}
			__LoadStyleSheets_0_2( name, target );
		}



		static Action<string, UnityEngine.UIElements.VisualElement> __LoadStyleSheets_0_2;
	}
}

#endif
