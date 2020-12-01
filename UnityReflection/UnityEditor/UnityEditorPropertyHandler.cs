/// UnityEditor.PropertyHandler : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorPropertyHandler {
		public object m_instance;
    
    public UnityEditorPropertyHandler( object instance ){
			m_instance = instance;
    }
    public UnityEditorPropertyHandler() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_PropertyHandler, new object[] {} );
    }
    
    

		public bool hasPropertyDrawer {
			get {
				if( __hasPropertyDrawer == null ) {
					__hasPropertyDrawer = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_PropertyHandler.GetMethod( "get_hasPropertyDrawer", R.InstanceMembers ) );
				}
				return __hasPropertyDrawer();
			}
		}
		public void AddMenuItems( UnityEditor.SerializedProperty property, UnityEditor.GenericMenu menu ) {
			if( __AddMenuItems_0_2 == null ) {
				__AddMenuItems_0_2 = (Action<UnityEditor.SerializedProperty,UnityEditor.GenericMenu>) Delegate.CreateDelegate( typeof( Action<UnityEditor.SerializedProperty,UnityEditor.GenericMenu> ), m_instance, UnityTypes.UnityEditor_PropertyHandler.GetMethod( "AddMenuItems", R.InstanceMembers, null, new Type[]{ typeof( UnityEditor.SerializedProperty ), typeof( UnityEditor.GenericMenu ) }, null ) );
			}
			__AddMenuItems_0_2( property, menu );
		}
		
		
		
		Func<bool> __hasPropertyDrawer;
		Action<UnityEditor.SerializedProperty,UnityEditor.GenericMenu> __AddMenuItems_0_2;
	}
}

