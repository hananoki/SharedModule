
#if UNITY_2019_1_OR_NEWER

using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityReflection;


namespace HananokiEditor {
	public class HTwoPaneEditorWindow<T> : HNEditorWindow<T> where T : EditorWindow {

		SessionStateFloat m_leftPaneSize;

		IMGUIContainer m_imguiToolbar;
		UnityEditorUIElementsVisualSplitter m_Splitter;
		UnityEngineUIElementsIMGUIContainer m_TreeViewContainerL;
		UnityEngineUIElementsIMGUIContainer m_TreeViewContainerR;
		VisualElement m_rightPanel;

		protected virtual void OnDrawToolBar() { }
		protected virtual void OnDrawLeftPane() { }
		protected virtual void OnDrawRightPane() { }

		//void OnEnable() {
		//}
		void OnDestroy() {
			m_leftPaneSize.Value = 1 - m_rightPanel.style.flexGrow.value;
			//Debug.Log( m_rightPanel.style.flexGrow );
		}

		public void SetupUI( float defaultLeftWidth = 0.2f ) {
			if( m_leftPaneSize == null ) {
				m_leftPaneSize = new SessionStateFloat( $"{typeof( T ).Name}.m_leftPaneSize", defaultLeftWidth );
			}
			var rt = new UnityEngineUIElementsVisualElement( rootVisualElement );
			rt.AddStyleSheetPath( "StyleSheets/SettingsWindowCommon.uss" );
			rt.AddStyleSheetPath( "StyleSheets/SettingsWindow" + ( EditorGUIUtility.isProSkin ? "Dark" : "Light" ) + ".uss" );
			rootVisualElement.style.flexDirection = FlexDirection.Column;

			m_imguiToolbar = new IMGUIContainer( OnDrawToolBar );

			m_Splitter = new UnityEditorUIElementsVisualSplitter();
			m_Splitter.splitSize = 10;
			m_Splitter.AddToClassList( "settings-splitter" );

			m_TreeViewContainerL = new UnityEngineUIElementsIMGUIContainer( OnDrawLeftPane );

			IMGUIContainer ccc = (IMGUIContainer) m_TreeViewContainerL.m_instance;
			ccc.style.flexGrow =  m_leftPaneSize.Value;
			ccc.style.flexBasis = 0f;
			m_TreeViewContainerL.focusOnlyIfHasFocusableControls = false;
			( (IMGUIContainer) m_TreeViewContainerL.m_instance ).AddToClassList( "settings-tree-imgui-container" );

			m_rightPanel = new VisualElement {
				style =     {
					flexGrow =  1 -m_leftPaneSize.Value,
					flexBasis = 0f
				}
			};
			m_rightPanel.AddToClassList( "settings-panel" );

			m_TreeViewContainerR = new UnityEngineUIElementsIMGUIContainer( OnDrawRightPane );
			IMGUIContainer cccc = (IMGUIContainer) m_TreeViewContainerR.m_instance;
			cccc.style.flexGrow = 1;
			cccc.style.flexBasis = 0f;
			m_TreeViewContainerR.focusOnlyIfHasFocusableControls = false;

			//////////////////////////

			rootVisualElement.Add( m_imguiToolbar );
			rootVisualElement.Add( (VisualElement) m_Splitter.m_instance );
			m_Splitter.Add( (VisualElement) m_TreeViewContainerL.m_instance );
			m_Splitter.Add( m_rightPanel );
			//m_rightPanel.Add( toolbarSearchField );
			m_rightPanel.Add( (VisualElement) m_TreeViewContainerR.m_instance );
		}


	}
}
#endif
