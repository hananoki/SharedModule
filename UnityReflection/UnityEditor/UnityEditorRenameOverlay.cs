/// UnityEditor.RenameOverlay : 2020.3.8f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorRenameOverlay {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorRenameOverlay( object instance ){
			m_instance = instance;
    }
    public UnityEditorRenameOverlay() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_RenameOverlay, new object[] {} );
    }
    

		public bool IsRenaming() {
			if( __IsRenaming_0_0 == null ) {
				__IsRenaming_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_RenameOverlay.GetMethod( "IsRenaming", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __IsRenaming_0_0();
		}
		
		
		
		Func<bool> __IsRenaming_0_0;
	}
}

