#if !DASABLE_INSPECTOR

using System;
using System.Linq;
using System.Reflection;

using UnityEngine;
using UnityEditor;

using HananokiRuntime;
//using Hananoki.Reflection;
//using HananokiEditor.CustomInspector;

namespace HananokiEditor {
	/// <summary>
	/// Custom inspector for Object including derived classes.
	/// </summary>
	//[CanEditMultipleObjects]
	//[CustomEditor( typeof( UnityEngine.Object ), true )]
	//public class ObjectEditor : Editor {
	//	public override void OnInspectorGUI() {
	//		this.DrawEasyButtons();

	//		// Draw the rest of the inspector as usual
	//		DrawDefaultInspector();
	//	}
	//}

	public static class EasyButtonsEditorExtensions {
		public static void DrawEasyButtons( Editor editor ) {
			// Loop through all methods with no parameters
			var methods = editor.target.GetType().GetMethods( R.AllMembers ).Where( m => m.GetParameters().Length == 0 );
			foreach( var method in methods ) {
				// Get the ButtonAttribute on the method (if any)
				var atb = (InspectorGUIAttribute) Attribute.GetCustomAttribute( method, typeof( InspectorGUIAttribute ) );

				if( atb != null ) {
					foreach( var t in editor.targets ) {
						method.Invoke( t, null );
					}
				}
			}
		}
	}
}

#endif
