/// UnityEditor.Json : 2018.4.0f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
	public sealed partial class UnityEditorJson {

		//public static System.Object Deserialize( string json ) {
		//	if( __Deserialize_0_1 == null ) {
		//		__Deserialize_0_1 = (Func<string, System.Object>) Delegate.CreateDelegate( typeof( Func<string, System.Object> ), null, UnityTypes.UnityEditor_Json.GetMethod( "Deserialize", R.StaticMembers, null, new Type[] { typeof( string ) }, null ) );
		//	}
		//	return __Deserialize_0_1( json );
		//}

		public static string Serialize( System.Object obj ) {
			if( __Serialize_0_1 == null ) {
				__Serialize_0_1 = (Func<System.Object, string>) Delegate.CreateDelegate( typeof( Func<System.Object, string> ), null, UnityTypes.UnityEditor_Json.GetMethod( "Serialize", R.StaticMembers, null, new Type[] { typeof( System.Object ) }, null ) );
			}
			return __Serialize_0_1( obj );
		}



		//static Func<string, System.Object> __Deserialize_0_1;
		static Func<System.Object, string> __Serialize_0_1;
	}
}

