using System.Collections.Generic;
using UnityEditor;
using System.Reflection;
using HananokiEditor;

namespace UnityReflection {
	public sealed partial class UnityEditorEditorWindow {

		public UnityEditorDockArea dockArea {
			get {
				return new UnityEditorDockArea( m_Parent );
			}
		}
		public UnityEditorView view {
			get {
				return new UnityEditorView( m_Parent );
			}
		}

		public FieldInfo __GetPanes;
		public List<EditorWindow> GetPanes() {
			if( __GetPanes == null ) {
				__GetPanes = dockArea.GetType().GetField( "m_Panes", R.InstanceMembers );
			}
			return (List<EditorWindow>) __GetPanes.GetValue( dockArea );
			

			//var lst = dockArea.GetField<List<EditorWindow>>( "m_Panes" );
			//return lst;
		}


		public PropertyInfo __containerWindow;
		public object containerWindow {
			get {
				//if( __containerWindow == null ) {
				//	__containerWindow = dockArea.m_instance.GetType().GetProperty( "window", R.InstanceMembers );
				//}
				//return (object) __containerWindow.GetValue( dockArea.m_instance );

				//var __ = dockArea.GetProperty<object>( "window" );
				return view.window;
			}
		}

		public FieldInfo __showMode;
		public int showMode {
			get {
				if( __showMode == null ) {
					__showMode = containerWindow.GetType().GetField( "m_ShowMode", R.InstanceMembers );
				}
				return (int) __showMode.GetValue( containerWindow );

				//var __ = containerWindow.GetField<int>( "m_ShowMode" );
				//return __;
			}
		}
	}
}
