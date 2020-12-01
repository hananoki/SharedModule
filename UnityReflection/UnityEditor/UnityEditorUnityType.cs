/// UnityEditor.UnityType : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorUnityType {
    
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
		
		
		
		static Func<uint, object> __GetTypeByRuntimeTypeIndex_0_1;
		static Func<int, object> __FindTypeByPersistentTypeID_0_1;
	}
}

