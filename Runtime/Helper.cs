using System.Collections.Generic;
using UnityObject = UnityEngine.Object;

namespace HananokiRuntime {
	public sealed class Helper {
		public static bool New<T>( ref T obj ) where T : new() {
			if( obj != null ) return false;
			obj = new T();
			return true;
		}
		public static bool New<T>( ref T[] obj, int num, bool force = false ) where T : new() {
			if( obj != null && force == false ) return false;
			obj = new T[ num ];
			for( int i = 0; i < num; i++ ) {
				obj[ i ] = new T();
			}
			return true;
		}

		public static bool New<T>( ref List<T> obj, int num ) where T : new() {
			if( obj != null ) return false;
			obj = new List<T>( num );
			for( int i = 0; i < num; i++ ) {
				obj[ i ] = new T();
			}
			return true;
		}

		public static bool IsNull<T>( T obj ) where T : class {
			var unityObj = obj as UnityObject;
			if( !object.ReferenceEquals( unityObj, null ) ) {
				return unityObj == null;
			}
			else {
				return obj == null;
			}
		}
	}
}
