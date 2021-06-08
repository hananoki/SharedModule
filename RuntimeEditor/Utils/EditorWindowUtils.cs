using System;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityReflection;
using EE = HananokiEditor.SharedModule.SettingsEditor;

namespace HananokiEditor {
	public static class EditorWindowUtils {

		/*
		NormalWindow,
		PopupMenu,
		Utility,
		NoShadow,
		MainWindow,
		AuxWindow,
		Tooltip,
		ModalUtility
		*/
		public static T GetWindow<T>() where T : EditorWindow  {
			return EditorWindow.GetWindow<T>( EE.IsUtilityWindow( typeof( T ) ) );
		}


		public static T ShowWindow<T>() where T : EditorWindow {
			return (T) EditorWindow.GetWindow( typeof( T ), EE.IsUtilityWindow( typeof( T ) ) );
		}

		public static EditorWindow ShowWindow( Type editorWindowType ) {
			return EditorWindow.GetWindow( editorWindowType, EE.IsUtilityWindow( editorWindowType ) );
		}

		public static EditorWindow ShowWindow( Type editorWindowType, bool utility ) {
			return EditorWindow.GetWindow( editorWindowType, utility );
		}


		public static void Attach( EditorWindow moveWindow, EditorWindow attachToWindow ) {

			if( attachToWindow == null ) return;
			if( moveWindow == attachToWindow ) return;

			var attach = new UnityEditorEditorWindow( attachToWindow );
			var attachContainer = new UnityEditorContainerWindow( attach.dockArea.window );

			if( attachContainer.m_ShowMode != 0 && attachContainer.m_ShowMode != 4 ) return;

			var move = new UnityEditorEditorWindow( moveWindow );
			var moveContainer = new UnityEditorContainerWindow( move.dockArea.window );
			if( moveContainer.m_ShowMode != 0 && attachContainer.m_ShowMode != 4 ) return;

			move.dockArea.RemoveTab( moveWindow, true, false );

			attach.dockArea.AddTab( moveWindow, false );

			moveWindow.Show();
		}

		public static void Detach( EditorWindow moveWindow ) {
			var move = new UnityEditorEditorWindow( moveWindow );

			if( !move.docked ) return;

			move.dockArea.RemoveTab( moveWindow );
			moveWindow.Show();
		}


		public static UnityEditorContainerWindow GetMainView() {
			//var lst = UnityEditorContainerWindow.windows.Select( x => new UnityEditorContainerWindow( x ) ).ToArray();
			foreach( var w in UnityEditorContainerWindow.windows.Select( x => new UnityEditorContainerWindow( x ) ) ) {
				if( w.m_ShowMode == 4 ) return w;
			}
			return null;
		}

		public static EditorWindow[] FindArray( Type editorWindowType ) {
			return Resources.FindObjectsOfTypeAll( editorWindowType ).Cast<EditorWindow>().ToArray();
		}

		public static EditorWindow Find( Type editorWindowType ) {
			foreach( var p in Resources.FindObjectsOfTypeAll( editorWindowType ) ) {
				return (EditorWindow) p;
			}
			return null;
		}
		public static T Find<T>() where T : EditorWindow => (T) Find( typeof( T ) );


		public static void RepaintProjectWindow() => EditorApplication.RepaintProjectWindow();
		public static void RepaintHierarchyWindow() => EditorApplication.RepaintHierarchyWindow();
		public static void RepaintAnimationWindow() => EditorApplication.RepaintAnimationWindow();

		public static void RepaintInspector() {
			foreach( var p in FindArray( UnityTypes.UnityEditor_InspectorWindow ) ) p.Repaint();
		}
		public static void FocusInspector() {
			foreach( var p in FindArray( UnityTypes.UnityEditor_InspectorWindow ).Select( x => new UnityEditorEditorWindow( x ) ) ) {
				if( !p.hasFocus ) ( (EditorWindow) p.m_instance ).Focus();
			}
		}

		public static void RepaintSceneView() {
			//foreach( var p in FindArray( UnityTypes.UnityEditor_SceneView ) ) p.Repaint();
			SceneView.RepaintAll();
		}
	}
}

