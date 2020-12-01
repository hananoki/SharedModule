using System;

namespace Hananoki {

	public static partial class UnityTypes {

		static Type Get( string typeFullName, string assemblyName ) {
			return Type.GetType( $"{typeFullName}, {assemblyName}, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
		}

		static Type Get( ref Type t, string typeFullName, string assemblyName ) {
			if( t == null ) {
				//UnityEngine.Debug.Log( typeFullName );
				t = Get( typeFullName, assemblyName );
			}
			return t;
		}
	}
}
