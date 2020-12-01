
using System;

namespace Hananoki {
	public static partial class UnityTypes {

		static Type _UnityEngine_ScriptableObject;
		public static Type UnityEngine_ScriptableObject => Get( ref _UnityEngine_ScriptableObject, "UnityEngine.ScriptableObject", "UnityEngine" );

		static Type _UnityEngine_UIElements_VisualElement;
		public static Type UnityEngine_UIElements_VisualElement {
			get {
				if( _UnityEngine_UIElements_VisualElement == null ) {
					if( UnitySymbol.UNITY_2019_1_OR_NEWER ) {
						_UnityEngine_UIElements_VisualElement = Get( ref _UnityEngine_UIElements_VisualElement,"UnityEngine.UIElements.VisualElement", "UnityEngine" );
					}
					else {
						_UnityEngine_UIElements_VisualElement = Get( ref _UnityEngine_UIElements_VisualElement,"UnityEngine.Experimental.UIElements.VisualElement", "UnityEngine" );
					}
				}
				return _UnityEngine_UIElements_VisualElement;
			}
		}

		static Type _UnityEngine_UIElements_IMGUIContainer;
		public static Type UnityEngine_UIElements_IMGUIContainer {
			get {
				if( _UnityEngine_UIElements_IMGUIContainer == null ) {
					if( UnitySymbol.UNITY_2019_1_OR_NEWER ) {
						_UnityEngine_UIElements_IMGUIContainer = Get( ref _UnityEngine_UIElements_IMGUIContainer,"UnityEngine.UIElements.IMGUIContainer", "UnityEngine" );
					}
					else {
						_UnityEngine_UIElements_IMGUIContainer = Get( ref _UnityEngine_UIElements_IMGUIContainer,"UnityEngine.Experimental.UIElements.IMGUIContainer", "UnityEngine" );
					}
				}
				return _UnityEngine_UIElements_IMGUIContainer;
			}
		}

	}
}
