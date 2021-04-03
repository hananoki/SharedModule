/// UnityEditorInternal.DopeLine : 2020.3.0f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorInternalDopeLine {
		public object m_instance;
    
    public UnityEditorInternalDopeLine( object instance ){
			m_instance = instance;
    }
   // public UnityEditorInternalDopeLine( int hierarchyNodeID, UnityEditorInternal.AnimationWindowCurve[] curves ) {
			//m_instance = Activator.CreateInstance( UnityTypes.UnityEditorInternal_DopeLine, new object[] { hierarchyNodeID, curves } );
   // }
    

		public int hierarchyNodeID {
			get {
				if( __getter_hierarchyNodeID == null ) {
					__getter_hierarchyNodeID = (Func<int>) Delegate.CreateDelegate( typeof( Func<int> ), m_instance, UnityTypes.UnityEditorInternal_DopeLine.GetMethod( "get_hierarchyNodeID", R.InstanceMembers ) );
				}
				return __getter_hierarchyNodeID();
			}
		}

		
		
		Func<int> __getter_hierarchyNodeID;
	}
}

