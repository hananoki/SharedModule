/// UnityEngine.UIElements.IMGUIContainer : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEngineUIElementsIMGUIContainer {
		public object m_instance;
    
    public UnityEngineUIElementsIMGUIContainer( object instance ){
			m_instance = instance;
    }
    public UnityEngineUIElementsIMGUIContainer() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEngine_UIElements_IMGUIContainer, new object[] {} );
    }
    public UnityEngineUIElementsIMGUIContainer( System.Action onGUIHandler ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEngine_UIElements_IMGUIContainer, new object[] { onGUIHandler } );
    }
    

		public bool focusOnlyIfHasFocusableControls {
			get {
				if( __getter_focusOnlyIfHasFocusableControls == null ) {
					__getter_focusOnlyIfHasFocusableControls = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEngine_UIElements_IMGUIContainer.GetMethod( "get_focusOnlyIfHasFocusableControls", R.InstanceMembers ) );
				}
				return __getter_focusOnlyIfHasFocusableControls();
			}
			set {
				if( __setter_focusOnlyIfHasFocusableControls == null ) {
					__setter_focusOnlyIfHasFocusableControls = (Action<bool>) Delegate.CreateDelegate( typeof( Action<bool> ), m_instance, UnityTypes.UnityEngine_UIElements_IMGUIContainer.GetMethod( "set_focusOnlyIfHasFocusableControls", R.InstanceMembers ) );
			  }
				__setter_focusOnlyIfHasFocusableControls( value );
			}
		}

		
		
		Func<bool> __getter_focusOnlyIfHasFocusableControls;
		Action<bool> __setter_focusOnlyIfHasFocusableControls;
	}
}

