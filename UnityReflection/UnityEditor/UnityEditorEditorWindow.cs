/// UnityEditor.EditorWindow : 2019.4.5f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorEditorWindow {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorEditorWindow( object instance ){
			m_instance = instance;
    }
    public UnityEditorEditorWindow() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_EditorWindow, new object[] {} );
    }
    

		public object m_Parent {
			get {
				if( __m_Parent == null ) {
					__m_Parent = UnityTypes.UnityEditor_EditorWindow.GetField( "m_Parent", R.InstanceMembers );
				}
				return (object) __m_Parent.GetValue( m_instance );
			}
			set {
				if( __m_Parent == null ) {
					__m_Parent = UnityTypes.UnityEditor_EditorWindow.GetField( "m_Parent", R.InstanceMembers );
				}
				__m_Parent.SetValue( m_instance, value );
			}
		}

		public bool hasFocus {
			get {
				if( __getter_hasFocus == null ) {
					__getter_hasFocus = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_EditorWindow.GetMethod( "get_hasFocus", R.InstanceMembers ) );
				}
				return __getter_hasFocus();
			}
		}

		public bool docked {
			get {
				if( __getter_docked == null ) {
					__getter_docked = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_EditorWindow.GetMethod( "get_docked", R.InstanceMembers ) );
				}
				return __getter_docked();
			}
		}

		public int GetNumTabs() {
			if( __GetNumTabs_0_0 == null ) {
				__GetNumTabs_0_0 = (Func<int>) Delegate.CreateDelegate( typeof( Func<int> ), m_instance, UnityTypes.UnityEditor_EditorWindow.GetMethod( "GetNumTabs", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __GetNumTabs_0_0();
		}
		
		
		
		FieldInfo __m_Parent;
		Func<bool> __getter_hasFocus;
		Func<bool> __getter_docked;
		Func<int> __GetNumTabs_0_0;
	}
}

