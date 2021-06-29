/// UnityEditor.AssetsTreeViewGUI : 2020.3.8f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorAssetsTreeViewGUI {
		public object m_instance;
    
    public UnityEditorAssetsTreeViewGUI( object instance ){
			m_instance = instance;
    }
   // public UnityEditorAssetsTreeViewGUI( UnityEditor.IMGUI.Controls.TreeViewController treeView ) {
			//m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_AssetsTreeViewGUI, new object[] { treeView } );
   // }
    

		public object m_Ping {
			get {
				if( __m_Ping == null ) {
					__m_Ping = UnityTypes.UnityEditor_AssetsTreeViewGUI.GetField( "m_Ping", R.InstanceMembers );
				}
				return (object) __m_Ping.GetValue( m_instance );
			}
			set {
				if( __m_Ping == null ) {
					__m_Ping = UnityTypes.UnityEditor_AssetsTreeViewGUI.GetField( "m_Ping", R.InstanceMembers );
				}
				__m_Ping.SetValue( m_instance, value );
			}
		}

		
		
		FieldInfo __m_Ping;
	}
}

