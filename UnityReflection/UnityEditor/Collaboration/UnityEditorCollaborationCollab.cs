/// UnityEditor.Collaboration.Collab : 2019.4.16f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorCollaborationCollab {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorCollaborationCollab( object instance ){
			m_instance = instance;
    }
    public UnityEditorCollaborationCollab() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_Collaboration_Collab, new object[] {} );
    }
    

		public static object IsToolbarVisible {
			get {
				if( __IsToolbarVisible == null ) {
					__IsToolbarVisible = UnityTypes.UnityEditor_Collaboration_Collab.GetField( "IsToolbarVisible", R.StaticMembers );
				}
				return (object) __IsToolbarVisible.GetValue( null );
			}
			set {
				if( __IsToolbarVisible == null ) {
					__IsToolbarVisible = UnityTypes.UnityEditor_Collaboration_Collab.GetField( "IsToolbarVisible", R.StaticMembers );
				}
				__IsToolbarVisible.SetValue( null, value );
			}
		}

		public static object instance {
			get {
				if( __getter_instance == null ) {
					__getter_instance = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), null, UnityTypes.UnityEditor_Collaboration_Collab.GetMethod( "get_instance", R.StaticMembers ) );
				}
				return __getter_instance();
			}
		}

		public bool IsCollabEnabledForCurrentProject() {
			if( __IsCollabEnabledForCurrentProject_0_0 == null ) {
				__IsCollabEnabledForCurrentProject_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_Collaboration_Collab.GetMethod( "IsCollabEnabledForCurrentProject", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __IsCollabEnabledForCurrentProject_0_0();
		}
		
		
		
		static FieldInfo __IsToolbarVisible;
		static Func<object> __getter_instance;
		Func<bool> __IsCollabEnabledForCurrentProject_0_0;
	}
}

