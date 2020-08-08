//#define ENABLE_LEGACY_PREFERENCE
#if UNITY_2018_3_OR_NEWER
//#undef ENABLE_LEGACY_PREFERENCE
#endif

using Hananoki.Reflection;
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Hananoki {
	public class HEditorWindow : EditorWindow {
		protected Action drawGUI;

		public void SetPositionCenter( EditorWindow parent ) {
			SetPositionCenter( parent, position.width, position.height );
		}

		public void SetPositionCenter( EditorWindow parent, float width, float height ) {
			var pos = parent.position;
			var x = pos.x + ( pos.width * 0.5f ) - ( width * 0.5f );
			var y = pos.y + ( pos.height * 0.5f ) - ( height * 0.5f );
			position = new Rect( x, y, width, height );
		}

		public void DrawArea() {
			try {
				var w = position.width - 10;
				var h = position.height;
				using( new GUILayout.AreaScope( new Rect( 10, 10, w - 10, h ) ) ) {
					drawGUI?.Invoke();
				}
			}
			catch( System.Exception e ) {
				Debug.LogException( e );
			}
		}


		public static EditorWindow ShowConsoleWindow( bool utility = false ) {
			return GetWindow( R.Type( "UnityEditor.ConsoleWindow" ), utility );
		}

		public static EditorWindow ShowAnimationWindow( bool utility = false ) {
			return GetWindow( R.Type( "UnityEditor.AnimationWindow" ), utility );
		}

		public static EditorWindow ShowAnimatorControllerTool( bool utility = false ) {
			return GetWindow( R.Type( "UnityEditor.Graphs.AnimatorControllerTool", "UnityEditor.Graphs.dll" ), utility );
		}


		public static EditorWindow ShowProfilerWindow( bool utility = false ) {
			return GetWindow( R.Type( "UnityEditor.ProfilerWindow" ), utility );
		}

		public static EditorWindow ShowTimelineWindow( bool utility = false ) {
			if( UnitySymbol.Has( "UNITY_2019_1_OR_NEWER" ) ) {
				var asm = R.LoadAssembly( "Unity.Timeline.Editor" );
				if( asm == null ) {
					Debug.LogWarning( "Timeline is not installed." );
					return null;
				}
				return GetWindow( R.Type( "UnityEditor.Timeline.TimelineWindow", "Unity.Timeline.Editor" ), utility );
			}
			else {
				return GetWindow( R.Type( "UnityEditor.Timeline.TimelineWindow", "UnityEditor.Timeline" ), utility );
			}
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
	}



	public class HSettingsEditorWindow : HEditorWindow {

		public class LayoutScope : GUI.Scope {
			public LayoutScope() {
				GUILayout.BeginHorizontal();
				GUILayout.Space( 4 );
				GUILayout.BeginVertical();
			}
			protected override void CloseScope() {
				GUILayout.EndVertical();
				GUILayout.Space( 4 );
				GUILayout.EndHorizontal();
			}
		}

		public string headerMame;
		public string headerVersion;
		public Action gui;
		Vector2 scrollPos;


		public void DrawTitleBar() {
			GUILayout.BeginHorizontal();
			GUILayout.Space( 8f );
			GUIContent content = new GUIContent( headerMame );
			GUILayout.Label( content, "SettingsHeader", GUILayout.MaxHeight( 30 ) );
			GUILayout.FlexibleSpace();
			//this.m_TreeView.currentProvider.OnTitleBarGUI();
			GUILayout.Label( headerVersion, EditorStyles.miniLabel );
			GUILayout.EndHorizontal();
		}

		void OnGUI() {
			DrawTitleBar();

			scrollPos = EditorGUILayout.BeginScrollView( scrollPos );
			GUILayout.BeginHorizontal();
			GUILayout.Space( 4 );
			GUILayout.BeginVertical();
			gui?.Invoke();
			GUILayout.EndVertical();
			GUILayout.Space( 4 );
			GUILayout.EndHorizontal();
			EditorGUILayout.EndScrollView();
		}
	}



}
