/// UnityEditor.View : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public partial class UnityEditorView {
		public object m_instance;
    
    public UnityEditorView( object instance ){
			m_instance = instance;
    }
    public UnityEditorView() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_View, new object[] {} );
    }
    

		public object[] allChildren {
			get {
				if( __getter_allChildren == null ) {
					__getter_allChildren = (Func<object[]>) Delegate.CreateDelegate( typeof( Func<object[]> ), m_instance, UnityTypes.UnityEditor_View.GetMethod( "get_allChildren", R.InstanceMembers ) );
				}
				return __getter_allChildren();
			}
		}

		public object parent {
			get {
				if( __getter_parent == null ) {
					__getter_parent = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), m_instance, UnityTypes.UnityEditor_View.GetMethod( "get_parent", R.InstanceMembers ) );
				}
				return __getter_parent();
			}
		}

		public object window {
			get {
				if( __getter_window == null ) {
					__getter_window = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), m_instance, UnityTypes.UnityEditor_View.GetMethod( "get_window", R.InstanceMembers ) );
				}
				return __getter_window();
			}
		}

		
		
		Func<object[]> __getter_allChildren;
		Func<object> __getter_parent;
		Func<object> __getter_window;
	}
}

