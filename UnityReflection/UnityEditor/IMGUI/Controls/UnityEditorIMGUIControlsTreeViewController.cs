/// UnityEditor.IMGUI.Controls.TreeViewController : 2020.3.8f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorIMGUIControlsTreeViewController {
		public object m_instance;
    
    public UnityEditorIMGUIControlsTreeViewController( object instance ){
			m_instance = instance;
    }
    public UnityEditorIMGUIControlsTreeViewController( UnityEditor.EditorWindow editorWindow, UnityEditor.IMGUI.Controls.TreeViewState treeViewState ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_IMGUI_Controls_TreeViewController, new object[] { editorWindow, treeViewState } );
    }
    

		public object gui {
			get {
				if( __getter_gui == null ) {
					__getter_gui = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), m_instance, UnityTypes.UnityEditor_IMGUI_Controls_TreeViewController.GetMethod( "get_gui", R.InstanceMembers ) );
				}
				return __getter_gui();
			}
			set {
				if( __setter_gui == null ) {
					__setter_gui = (Action<object>) Delegate.CreateDelegate( typeof( Action<object> ), m_instance, UnityTypes.UnityEditor_IMGUI_Controls_TreeViewController.GetMethod( "set_gui", R.InstanceMembers ) );
			  }
				__setter_gui( value );
			}
		}

		
		
		Func<object> __getter_gui;
		Action<object> __setter_gui;
	}
}

