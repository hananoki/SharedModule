using System;
using System.Reflection;

namespace Hananoki {
	public static class UnityAssembly {
		public static Assembly GetAssembly( string name ) {
			return Assembly.Load( name );
		}

		public static Assembly UnityEngine => Assembly.Load( "UnityEngine.dll" );
		public static Assembly UnityEditor => Assembly.Load( "UnityEditor.dll" );
	}


	public static class UnityTypes {
		static Type _SceneHierarchyWindow;

		public static Type SceneHierarchyWindow {
			get {
				if( _SceneHierarchyWindow == null ) {
					_SceneHierarchyWindow = UnityAssembly.UnityEditor.GetType( "UnityEditor.SceneHierarchyWindow" );
				}
				return _SceneHierarchyWindow;
			}
		}

		static Type _ProjectBrowser;
		public static Type ProjectBrowser {
			get {
				if( _ProjectBrowser == null ) {
					_ProjectBrowser = UnityAssembly.UnityEditor.GetType( "UnityEditor.ProjectBrowser" );
				}
				return _ProjectBrowser;
			}
		}

		static Type _VisualElement;
		public static Type VisualElement {
			get {
				if( _VisualElement == null ) {
					if( UnitySymbol.UNITY_2019_1_OR_NEWER ) {
						_VisualElement = UnityAssembly.UnityEngine.GetType( "UnityEngine.UIElements.VisualElement" );
					}
					else {
						_VisualElement = UnityAssembly.UnityEngine.GetType( "UnityEngine.Experimental.UIElements.VisualElement" );
					}
				}
				return _VisualElement;
			}
		}

		static Type _IMGUIContainer;
		public static Type IMGUIContainer {
			get {
				if( _IMGUIContainer == null ) {
					if( UnitySymbol.UNITY_2019_1_OR_NEWER ) {
						_IMGUIContainer = UnityAssembly.UnityEngine.GetType( "UnityEngine.UIElements.IMGUIContainer" );
					}
					else {
						_IMGUIContainer = UnityAssembly.UnityEngine.GetType( "UnityEngine.Experimental.UIElements.IMGUIContainer" );
					}
				}
				return _IMGUIContainer;
			}
		}
	}

	
}
