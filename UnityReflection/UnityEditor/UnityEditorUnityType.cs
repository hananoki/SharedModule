/// UnityEditor.UnityType : 2019.4.5f1

using HananokiEditor;
//using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorUnityType {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorUnityType( object instance ){
			m_instance = instance;
    }
    public UnityEditorUnityType() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_UnityType, new object[] {} );
    }
    

		public string name {
			get {
				if( __name == null ) {
					__name = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), m_instance, UnityTypes.UnityEditor_UnityType.GetMethod( "get_name", R.InstanceMembers ) );
				}
				return __name();
			}
		}

		public string nativeNamespace {
			get {
				if( __nativeNamespace == null ) {
					__nativeNamespace = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), m_instance, UnityTypes.UnityEditor_UnityType.GetMethod( "get_nativeNamespace", R.InstanceMembers ) );
				}
				return __nativeNamespace();
			}
		}

		public string module {
			get {
				if( __module == null ) {
					__module = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), m_instance, UnityTypes.UnityEditor_UnityType.GetMethod( "get_module", R.InstanceMembers ) );
				}
				return __module();
			}
		}

		public static object GetTypeByRuntimeTypeIndex( uint index ) {
			if( __GetTypeByRuntimeTypeIndex_0_1 == null ) {
				__GetTypeByRuntimeTypeIndex_0_1 = (Func<uint, object>) Delegate.CreateDelegate( typeof( Func<uint, object> ), null, UnityTypes.UnityEditor_UnityType.GetMethod( "GetTypeByRuntimeTypeIndex", R.StaticMembers, null, new Type[]{ typeof( uint ) }, null ) );
			}
			return __GetTypeByRuntimeTypeIndex_0_1( index );
		}
		
		public static object FindTypeByPersistentTypeID( int persistentTypeId ) {
			if( __FindTypeByPersistentTypeID_0_1 == null ) {
				__FindTypeByPersistentTypeID_0_1 = (Func<int, object>) Delegate.CreateDelegate( typeof( Func<int, object> ), null, UnityTypes.UnityEditor_UnityType.GetMethod( "FindTypeByPersistentTypeID", R.StaticMembers, null, new Type[]{ typeof( int ) }, null ) );
			}
			return __FindTypeByPersistentTypeID_0_1( persistentTypeId );
		}
		
		
		
		Func<string> __name;
		Func<string> __nativeNamespace;
		Func<string> __module;
		static Func<uint, object> __GetTypeByRuntimeTypeIndex_0_1;
		static Func<int, object> __FindTypeByPersistentTypeID_0_1;
	}
}

