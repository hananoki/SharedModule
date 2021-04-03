
#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityObject = UnityEngine.Object;

namespace HananokiEditor {
	public class EditorUtils {
		public static void GetOrCreate( ref Editor editor, UnityObject obj ) {
			if( editor != null ) return;
			editor = Editor.CreateEditor( obj );
		}
	}
}
