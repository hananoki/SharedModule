#if UNITY_EDITOR

using System;
using UnityEditor;
using UnityEngine;


namespace Hananoki {

	public class HandlesGUIScope : IDisposable {
		public HandlesGUIScope() {
			Handles.BeginGUI();
		}
		public void Dispose() {
			Handles.EndGUI();
		}
	}


	public class GUISkinScope : IDisposable {
		GUISkin skin;
		public GUISkinScope( EditorSkin editorSkin ) {
			skin = GUI.skin;
			GUI.skin = EditorGUIUtility.GetBuiltinSkin( editorSkin );
		}
		public void Dispose() {
			GUI.skin = skin;
		}
	}


	public class GUIColorScope : GUI.Scope {
		Color color;

		public GUIColorScope() {
			color = GUI.color;
		}

		protected override void CloseScope() {
			GUI.color = color;
		}
	}


	public class GUIBackgroundColorScope : GUI.Scope {
		Color color;

		public GUIBackgroundColorScope() {
			color = GUI.backgroundColor;
		}

		protected override void CloseScope() {
			GUI.backgroundColor = color;
		}
	}
}

#endif
