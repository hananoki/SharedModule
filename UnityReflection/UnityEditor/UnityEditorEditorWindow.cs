/// UnityEditor.EditorWindow : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorEditorWindow {
		public object m_instance;
    
    public UnityEditorEditorWindow( object instance ){
			m_instance = instance;
    }
    public UnityEditorEditorWindow() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_EditorWindow, new object[] {} );
    }
    
    

		public bool hasFocus {
			get {
				if( __hasFocus == null ) {
					__hasFocus = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_EditorWindow.GetMethod( "get_hasFocus", R.InstanceMembers ) );
				}
				return __hasFocus();
			}
		}

		public bool docked {
			get {
				if( __docked == null ) {
					__docked = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_EditorWindow.GetMethod( "get_docked", R.InstanceMembers ) );
				}
				return __docked();
			}
		}
		public int GetNumTabs() {
			if( __GetNumTabs_0_0 == null ) {
				__GetNumTabs_0_0 = (Func<int>) Delegate.CreateDelegate( typeof( Func<int> ), m_instance, UnityTypes.UnityEditor_EditorWindow.GetMethod( "GetNumTabs", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __GetNumTabs_0_0(  );
		}
		
		
		
		Func<bool> __hasFocus;
		Func<bool> __docked;
		Func<int> __GetNumTabs_0_0;
	}
}

