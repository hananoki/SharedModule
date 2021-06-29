/// UnityEditor.ObjectListArea : 2020.3.8f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorObjectListArea {
		public object m_instance;
    
    public UnityEditorObjectListArea( object instance ){
			m_instance = instance;
    }
   // public UnityEditorObjectListArea( UnityEditor.ObjectListAreaState state, UnityEditor.EditorWindow owner, bool showNoneItem ) {
			//m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_ObjectListArea, new object[] { state, owner, showNoneItem } );
   // }
    

		public object m_Ping {
			get {
				if( __m_Ping == null ) {
					__m_Ping = UnityTypes.UnityEditor_ObjectListArea.GetField( "m_Ping", R.InstanceMembers );
				}
				return (object) __m_Ping.GetValue( m_instance );
			}
			set {
				if( __m_Ping == null ) {
					__m_Ping = UnityTypes.UnityEditor_ObjectListArea.GetField( "m_Ping", R.InstanceMembers );
				}
				__m_Ping.SetValue( m_instance, value );
			}
		}

		
		
		FieldInfo __m_Ping;
	}
}

