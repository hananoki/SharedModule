/// UnityEngine.UIElements.VisualElement : 2019.4.5f1

#if UNITY_2019_1_OR_NEWER

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEngineUIElementsVisualElement {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEngineUIElementsVisualElement( object instance ){
			m_instance = instance;
    }
    public UnityEngineUIElementsVisualElement() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEngine_UIElements_VisualElement, new object[] {} );
    }
    

		public void AddStyleSheetPath( string sheetPath ) {
			if( __AddStyleSheetPath_0_1 == null ) {
				__AddStyleSheetPath_0_1 = (Action<string>) Delegate.CreateDelegate( typeof( Action<string> ), m_instance, UnityTypes.UnityEngine_UIElements_VisualElement.GetMethod( "AddStyleSheetPath", R.InstanceMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			__AddStyleSheetPath_0_1( sheetPath );
		}
		
		
		
		Action<string> __AddStyleSheetPath_0_1;
	}
}

#endif // UNITY_2019_1_OR_NEWER


