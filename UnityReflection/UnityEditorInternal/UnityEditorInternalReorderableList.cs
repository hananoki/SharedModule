/// UnityEditorInternal.ReorderableList : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorInternalReorderableList {
		public object m_instance;
    
    public UnityEditorInternalReorderableList( object instance ){
			m_instance = instance;
    }
    public UnityEditorInternalReorderableList( System.Collections.IList elements, System.Type elementType ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditorInternal_ReorderableList, new object[] { elements, elementType } );
    }
    public UnityEditorInternalReorderableList( System.Collections.IList elements, System.Type elementType, bool draggable, bool displayHeader, bool displayAddButton, bool displayRemoveButton ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditorInternal_ReorderableList, new object[] { elements, elementType, draggable, displayHeader, displayAddButton, displayRemoveButton } );
    }
    public UnityEditorInternalReorderableList( UnityEditor.SerializedObject serializedObject, UnityEditor.SerializedProperty elements ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditorInternal_ReorderableList, new object[] { serializedObject, elements } );
    }
    public UnityEditorInternalReorderableList( UnityEditor.SerializedObject serializedObject, UnityEditor.SerializedProperty elements, bool draggable, bool displayHeader, bool displayAddButton, bool displayRemoveButton ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditorInternal_ReorderableList, new object[] { serializedObject, elements, draggable, displayHeader, displayAddButton, displayRemoveButton } );
    }
    
    
		public void DoListHeader( UnityEngine.Rect headerRect ) {
			if( __DoListHeader_0_1 == null ) {
				__DoListHeader_0_1 = (Action<UnityEngine.Rect>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Rect> ), m_instance, UnityTypes.UnityEditorInternal_ReorderableList.GetMethod( "DoListHeader", R.InstanceMembers, null, new Type[]{ typeof( UnityEngine.Rect ) }, null ) );
			}
			__DoListHeader_0_1( headerRect );
		}
		
		
		
		Action<UnityEngine.Rect> __DoListHeader_0_1;
	}
}

