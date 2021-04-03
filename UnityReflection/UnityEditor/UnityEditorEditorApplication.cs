/// UnityEditor.EditorApplication : 2019.4.21f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorEditorApplication {

		public static UnityEditor.EditorApplication.CallbackFunction globalEventHandler {
			get {
				if( __globalEventHandler == null ) {
					__globalEventHandler = UnityTypes.UnityEditor_EditorApplication.GetField( "globalEventHandler", R.StaticMembers );
				}
				return (UnityEditor.EditorApplication.CallbackFunction) __globalEventHandler.GetValue( null );
			}
			set {
				if( __globalEventHandler == null ) {
					__globalEventHandler = UnityTypes.UnityEditor_EditorApplication.GetField( "globalEventHandler", R.StaticMembers );
				}
				__globalEventHandler.SetValue( null, value );
			}
		}

		
		
		static FieldInfo __globalEventHandler;
	}
}

