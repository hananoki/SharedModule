/// UnityEditor.Json : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorJson {
    
		public static System.Object Deserialize( string json ) {
			if( __Deserialize_0_1 == null ) {
				__Deserialize_0_1 = (Func<string, System.Object>) Delegate.CreateDelegate( typeof( Func<string, System.Object> ), null, UnityTypes.UnityEditor_Json.GetMethod( "Deserialize", R.StaticMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			return __Deserialize_0_1( json );
		}
		
		public static string Serialize( System.Object obj, bool pretty = false, string indentText = "  " ) {
			if( __Serialize_0_3 == null ) {
				__Serialize_0_3 = (Func<System.Object,bool,string, string>) Delegate.CreateDelegate( typeof( Func<System.Object,bool,string, string> ), null, UnityTypes.UnityEditor_Json.GetMethod( "Serialize", R.StaticMembers, null, new Type[]{ typeof( System.Object ), typeof( bool ), typeof( string ) }, null ) );
			}
			return __Serialize_0_3( obj, pretty, indentText );
		}
		
		
		
		static Func<string, System.Object> __Deserialize_0_1;
		static Func<System.Object,bool,string, string> __Serialize_0_3;
	}
}

