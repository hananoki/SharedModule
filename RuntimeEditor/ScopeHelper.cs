#if UNITY_EDITOR

using System;
using UnityEditor;
using UnityEngine;

namespace Hananoki {

	public class HandlesGUIScope : GUI.Scope {
		public HandlesGUIScope() {
			Handles.BeginGUI();
		}
		protected override void CloseScope() {
			Handles.EndGUI();
		}
	}


	public class GUISkinScope : GUI.Scope {
		GUISkin skin;
		public GUISkinScope( EditorSkin editorSkin ) {
			skin = GUI.skin;
			GUI.skin = EditorGUIUtility.GetBuiltinSkin( editorSkin );
		}
		protected override void CloseScope() {
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


	public class SerializedObjectScope : GUI.Scope {
		SerializedObject _so;

		public SerializedObjectScope( SerializedObject so ) {
			_so = so;
			_so.Update();
		}

		protected override void CloseScope() {
			_so.ApplyModifiedProperties();
		}
	}


	public class LockReloadAssembliesScope : GUI.Scope {
		public LockReloadAssembliesScope() {
			EditorApplication.LockReloadAssemblies();
		}
		protected override void CloseScope() {
			EditorApplication.UnlockReloadAssemblies();
		}
	}


	public class AssetEditingScope : GUI.Scope {
		public AssetEditingScope() {
			AssetDatabase.StartAssetEditing();
		}
		protected override void CloseScope() {
			AssetDatabase.StopAssetEditing();
			AssetDatabase.Refresh();
		}
	}


	public class IsCompilingDisableScope : EditorGUI.DisabledGroupScope {

		public IsCompilingDisableScope() : base( EditorApplication.isCompiling ) {
		}
	}


}

#endif
