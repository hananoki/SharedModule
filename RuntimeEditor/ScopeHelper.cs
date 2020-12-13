
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;
using HananokiRuntime;

namespace HananokiEditor {

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
			if( Helper.IsNull( so.targetObject ) ) return;
			if( 0 < so.targetObjects.Length ) {
				if( 0 < so.targetObjects.Where( x => Helper.IsNull( x ) ).ToArray().Length ) return;
			}
			_so = so;
			_so.Update();
		}

		protected override void CloseScope() {
			if( _so == null ) return;
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



	public class StopwatchScope : GUI.Scope {
		System.Diagnostics.Stopwatch m_sw;
		public StopwatchScope() {
			m_sw = new System.Diagnostics.Stopwatch();
			m_sw.Start();
		}
		protected override void CloseScope() {
			m_sw.Stop();
			TimeSpan ts = m_sw.Elapsed;
			Debug.Log( $"　{m_sw.ElapsedMilliseconds}ミリ秒" );
		}
	}


	public class ProgressBarScope : GUI.Scope {
		float m_fval;
		float m_fadd;
		string m_name;
		public ProgressBarScope( string name, int max ) {
			m_name = name;
			m_fval = 0.00f;
			m_fadd = 1.00f / (float) max;
		}

		public void Next( string message ) {
			m_fval += m_fadd;
			if( 1.00f < m_fval ) m_fval = 1.00f;
			EditorUtility.DisplayProgressBar( m_name, message, m_fval );
		}

		protected override void CloseScope() {
			EditorUtility.ClearProgressBar();
		}
	}
}

