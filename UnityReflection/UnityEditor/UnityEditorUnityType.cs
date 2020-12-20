/// UnityEditor.UnityType : 2019.4.5f1

using HananokiEditor;
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
    

		public bool isEditorOnly {
			get {
				if( __getter_isEditorOnly == null ) {
					__getter_isEditorOnly = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_UnityType.GetMethod( "get_isEditorOnly", R.InstanceMembers ) );
				}
				return __getter_isEditorOnly();
			}
		}

		public string module {
			get {
				if( __getter_module == null ) {
					__getter_module = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), m_instance, UnityTypes.UnityEditor_UnityType.GetMethod( "get_module", R.InstanceMembers ) );
				}
				return __getter_module();
			}
			set {
				if( __setter_module == null ) {
					__setter_module = (Action<string>) Delegate.CreateDelegate( typeof( Action<string> ), m_instance, UnityTypes.UnityEditor_UnityType.GetMethod( "set_module", R.InstanceMembers ) );
			  }
				__setter_module( value );
			}
		}

		public string name {
			get {
				if( __getter_name == null ) {
					__getter_name = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), m_instance, UnityTypes.UnityEditor_UnityType.GetMethod( "get_name", R.InstanceMembers ) );
				}
				return __getter_name();
			}
			set {
				if( __setter_name == null ) {
					__setter_name = (Action<string>) Delegate.CreateDelegate( typeof( Action<string> ), m_instance, UnityTypes.UnityEditor_UnityType.GetMethod( "set_name", R.InstanceMembers ) );
			  }
				__setter_name( value );
			}
		}

		public string nativeNamespace {
			get {
				if( __getter_nativeNamespace == null ) {
					__getter_nativeNamespace = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), m_instance, UnityTypes.UnityEditor_UnityType.GetMethod( "get_nativeNamespace", R.InstanceMembers ) );
				}
				return __getter_nativeNamespace();
			}
			set {
				if( __setter_nativeNamespace == null ) {
					__setter_nativeNamespace = (Action<string>) Delegate.CreateDelegate( typeof( Action<string> ), m_instance, UnityTypes.UnityEditor_UnityType.GetMethod( "set_nativeNamespace", R.InstanceMembers ) );
			  }
				__setter_nativeNamespace( value );
			}
		}

		public int persistentTypeID {
			get {
				if( __getter_persistentTypeID == null ) {
					__getter_persistentTypeID = (Func<int>) Delegate.CreateDelegate( typeof( Func<int> ), m_instance, UnityTypes.UnityEditor_UnityType.GetMethod( "get_persistentTypeID", R.InstanceMembers ) );
				}
				return __getter_persistentTypeID();
			}
			set {
				if( __setter_persistentTypeID == null ) {
					__setter_persistentTypeID = (Action<int>) Delegate.CreateDelegate( typeof( Action<int> ), m_instance, UnityTypes.UnityEditor_UnityType.GetMethod( "set_persistentTypeID", R.InstanceMembers ) );
			  }
				__setter_persistentTypeID( value );
			}
		}

		public string qualifiedName {
			get {
				if( __getter_qualifiedName == null ) {
					__getter_qualifiedName = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), m_instance, UnityTypes.UnityEditor_UnityType.GetMethod( "get_qualifiedName", R.InstanceMembers ) );
				}
				return __getter_qualifiedName();
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
		
		public static object FindTypeByName( string name ) {
			if( __FindTypeByName_0_1 == null ) {
				__FindTypeByName_0_1 = (Func<string, object>) Delegate.CreateDelegate( typeof( Func<string, object> ), null, UnityTypes.UnityEditor_UnityType.GetMethod( "FindTypeByName", R.StaticMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			return __FindTypeByName_0_1( name );
		}
		
		
		
		Func<bool> __getter_isEditorOnly;
		Func<string> __getter_module;
		Action<string> __setter_module;
		Func<string> __getter_name;
		Action<string> __setter_name;
		Func<string> __getter_nativeNamespace;
		Action<string> __setter_nativeNamespace;
		Func<int> __getter_persistentTypeID;
		Action<int> __setter_persistentTypeID;
		Func<string> __getter_qualifiedName;
		static Func<uint, object> __GetTypeByRuntimeTypeIndex_0_1;
		static Func<int, object> __FindTypeByPersistentTypeID_0_1;
		static Func<string, object> __FindTypeByName_0_1;
	}
}

