using UnityObject = UnityEngine.Object;

namespace Hananoki {
	public sealed class Helper {
		public static bool New<T>( ref T obj ) where T : new() {
			if( obj != null ) return false;
			obj = new T();
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
