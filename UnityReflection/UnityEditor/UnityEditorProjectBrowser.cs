/// UnityEditor.ProjectBrowser : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorProjectBrowser {
		public object m_instance;
    
    public UnityEditorProjectBrowser( object instance ){
			m_instance = instance;
    }
   // public UnityEditorProjectBrowser() {
			//m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_ProjectBrowser, new object[] {} );
   // }
    
    

		public bool isLocked {
			get {
				if( __isLocked == null ) {
					__isLocked = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "get_isLocked", R.InstanceMembers ) );
				}
				return __isLocked();
			}
		}
		public static string GetSelectedPath() {
			if( __GetSelectedPath_0_0 == null ) {
				__GetSelectedPath_0_0 = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), null, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "GetSelectedPath", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetSelectedPath_0_0(  );
		}
		
		public static System.Collections.IList GetAllProjectBrowsers() {
			if( __GetAllProjectBrowsers_0_0 == null ) {
				__GetAllProjectBrowsers_0_0 = (Func<System.Collections.IList>) Delegate.CreateDelegate( typeof( Func<System.Collections.IList> ), null, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "GetAllProjectBrowsers", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetAllProjectBrowsers_0_0(  );
		}
		
		public string GetActiveFolderPath() {
			if( __GetActiveFolderPath_0_0 == null ) {
				__GetActiveFolderPath_0_0 = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), m_instance, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "GetActiveFolderPath", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __GetActiveFolderPath_0_0(  );
		}
		
		public bool IsTwoColumns() {
			if( __IsTwoColumns_0_0 == null ) {
				__IsTwoColumns_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "IsTwoColumns", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __IsTwoColumns_0_0(  );
		}
		
		public void SetSearch( string searchString ) {
			if( __SetSearch_0_1 == null ) {
				__SetSearch_0_1 = (Action<string>) Delegate.CreateDelegate( typeof( Action<string> ), m_instance, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "SetSearch", R.InstanceMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			__SetSearch_0_1( searchString );
		}
		
		//public void SetSearch( UnityEditor.SearchFilter searchFilter ) {
		//	if( __SetSearch_1_1 == null ) {
		//		__SetSearch_1_1 = (Action<UnityEditor.SearchFilter>) Delegate.CreateDelegate( typeof( Action<UnityEditor.SearchFilter> ), m_instance, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "SetSearch", R.InstanceMembers, null, new Type[]{ typeof( UnityEditor.SearchFilter ) }, null ) );
		//	}
		//	__SetSearch_1_1( searchFilter );
		//}
		
		
		
		Func<bool> __isLocked;
		static Func<string> __GetSelectedPath_0_0;
		static Func<System.Collections.IList> __GetAllProjectBrowsers_0_0;
		Func<string> __GetActiveFolderPath_0_0;
		Func<bool> __IsTwoColumns_0_0;
		Action<string> __SetSearch_0_1;
		//Action<UnityEditor.SearchFilter> __SetSearch_1_1;
	}
}

