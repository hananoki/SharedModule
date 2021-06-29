/// UnityEditor.PingData : 2020.3.8f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorPingData {
		public object m_instance;
    
    public UnityEditorPingData( object instance ){
			m_instance = instance;
    }
    public UnityEditorPingData() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_PingData, new object[] {} );
    }
    

		public bool isPinging {
			get {
				if( __getter_isPinging == null ) {
					__getter_isPinging = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_PingData.GetMethod( "get_isPinging", R.InstanceMembers ) );
				}
				return __getter_isPinging();
			}
		}

		
		
		Func<bool> __getter_isPinging;
	}
}

