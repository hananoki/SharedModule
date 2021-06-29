/// UnityEditor.SearchFilter : 2020.3.8f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorSearchFilter {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorSearchFilter( object instance ){
			m_instance = instance;
    }
    public UnityEditorSearchFilter() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_SearchFilter, new object[] {} );
    }
    

		public bool IsSearching() {
			if( __IsSearching_0_0 == null ) {
				__IsSearching_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_SearchFilter.GetMethod( "IsSearching", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __IsSearching_0_0();
		}
		
		
		
		Func<bool> __IsSearching_0_0;
	}
}

