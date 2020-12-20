//using System;

//namespace HananokiEditor {

//	public static partial class HananokiTypes {

//		static Type Get( string typeFullName, string assemblyName ) {
//			return Type.GetType( $"{typeFullName}, {assemblyName}, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
//		}

//		static Type Get( ref Type t, string typeFullName, string assemblyName ) {
//			if( t == null ) {
//				//UnityEngine.Debug.Log( typeFullName );
//				t = Get( typeFullName, assemblyName );
//			}
//			return t;
//		}

//		static Type _UnityEditor_GUIView;
//		public static Type UnityEditor_GUIView => {
//		Editor
//		}
//	}
//}