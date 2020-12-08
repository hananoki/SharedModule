using Hananoki.Reflection;
using System.Collections.Generic;
using UnityEditor;
using System.Reflection;

namespace UnityReflection {
	public sealed partial class UnityEditorEditorWindow {

		public FieldInfo __dockArea;
		public object dockArea {
			get {
				if( __dockArea == null ) {
					__dockArea = typeof( EditorWindow ).GetField( "m_Parent", R.InstanceMembers );
				}
				return (object) __dockArea.GetValue( m_instance );

				//var __ = m_instance.GetField<object>( "m_Parent" );
				//return __;
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
				if( __containerWindow == null ) {
					__containerWindow = dockArea.GetType().GetProperty( "window", R.InstanceMembers );
				}
				return (object) __containerWindow.GetValue( dockArea );

				var __ = dockArea.GetProperty<object>( "window" );
				return __;
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
