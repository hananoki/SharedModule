
#if ENABLE_HANANOKI_SETTINGS

using Hananoki.Extensions;
using Hananoki.Reflection;
using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

using SS = Hananoki.SharedModule.S;

namespace Hananoki.SharedModule {
	public class SettingsItem {
		public int mode;
		public string displayName;
		public string version;
		public Action gui;
	}

	public class SettingsWindow : HEditorWindow {

		public enum Mode {
			Editor,
			Project,
		}

		static SettingsWindow s_instance;

		object m_HorizontalSplitter;

		SettingsTreeView m_treeViewEditor;
		SettingsTreeView m_treeViewProject;


		Mode mode;
		Vector2 m_scroll;

		string selectionDeley;

		//#if LOCAL_TEST
		[MenuItem( "Window/Hananoki/Settings" )]
		public static void Open() {
			var window = GetWindow<SettingsWindow>();
			window.SetTitle( new GUIContent( SS._Settings, EditorIcon.settings ) );
		}
		//#endif

		public static void OpenEditor( string displayName ) {
			Open( $"Editor/{displayName}" );
		}
		public static void OpenProject( string displayName ) {
			Open( $"Project/{displayName}" );
		}

		public static void Open( string displayName ) {
			s_instance = GetWindow<SettingsWindow>();
			s_instance.SetTitle( new GUIContent( "Settings", EditorIcon.settings ) );

			var dsip = displayName.Split( '/' );
			if( dsip[ 0 ] == "Editor" ) {
				s_instance.mode = Mode.Editor;
			}
			else {
				s_instance.mode = Mode.Project;
			}
			s_instance.selectionDeley = displayName;
		}

		new public static void Repaint() {
			( (EditorWindow) s_instance )?.Repaint();
		}


		public void SelectionDeley( string displayName ) {
		}


		public static void LoadSettingsAttribute() {

			//s_localizeEvent = new List<MethodInfo>();


			//EditorUtils.RepaintEditorWindow();
		}

		void OnDestroy() {
			s_instance = null;
		}

		void OnEnable() {
			s_instance = this;

			var sz = new float[] { 0.3f, 0.7f };
			m_HorizontalSplitter = Activator.CreateInstance( R.Type( "UnityEditor.SplitterState", "UnityEditor.dll" ), new object[] { sz } );

			m_treeViewEditor = new SettingsTreeView();
			m_treeViewProject = new SettingsTreeView();

			var t = typeof( SettingsClass );
			foreach( Assembly assembly in AppDomain.CurrentDomain.GetAssemblies() ) {
				try {
					foreach( Type type in assembly.GetTypes() ) {
						try {
							if( type.GetCustomAttribute( t ) == null ) continue;
							var mm = R.Methods( typeof( SettingsMethod ), type.FullName, assembly.FullName.Split( ',' )[ 0 ] );
							//s_localizeEvent.AddRange( mm );
							var item = (SettingsItem) mm[ 0 ].Invoke( null, null );
							if( item.mode == 0 ) {
								m_treeViewEditor.AddItem( item );
							}
							else {
								m_treeViewProject.AddItem( item );
							}
						}
						catch( Exception ee ) {
							Debug.LogException( ee );
						}
					}
				}
				catch( ReflectionTypeLoadException ) {
				}
				catch( Exception e ) {
					Debug.LogError( e );
				}
			}

			m_treeViewEditor.ReloadAndSorting();
			m_treeViewProject.ReloadAndSorting();
		}

		public void BeginHorizontalSplit( params GUILayoutOption[] options ) {
			R.Method( 2, "BeginHorizontalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll" ).Invoke( null, new object[] { m_HorizontalSplitter, options } );
		}

		public void EndHorizontalSplit() {
			R.Method( "EndHorizontalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll" ).Invoke( null, null );
		}


		void DrawLeftPane() {
			if( !selectionDeley.IsEmpty() ) {
				var dsip = selectionDeley.Split( '/' );
				m_treeViewEditor.SelectItem( dsip[ 1 ] );
				m_treeViewProject.SelectItem( dsip[ 1 ] );
				selectionDeley = string.Empty;

			}
			GUILayout.Box( "", HEditorStyles.treeViweArea, GUILayout.ExpandWidth( true ), GUILayout.ExpandHeight( true ) );

			var dropRc = GUILayoutUtility.GetLastRect();

			if( mode == 0 ) {
				m_treeViewEditor.OnGUI( dropRc );
			}
			else {
				m_treeViewProject.OnGUI( dropRc );
			}
		}

		void DrawRightPane() {
			try {
				using( var sc = new GUILayout.ScrollViewScope( m_scroll ) ) {
					m_scroll = sc.scrollPosition;
					using( new GUILayout.HorizontalScope() ) {
						GUILayout.Space( 8 );
						//GUILayout.Space( 4 );
						using( new GUILayout.VerticalScope() ) {
							GUILayout.Space( 4 );
							//EditorGUIUtility.hierarchyMode = true;

							//if( m_treeView.currentEditor != null ) {
							//	if( m_treeView.currentEditor.target == null ) {
							//		EditorGUILayout.HelpBox( S._SerializedObjecttargethasbeendestroyed, MessageType.Error );
							//		return;
							//	}
							//	else {
							//		m_treeView.currentEditor.OnInspectorGUI();
							//	}
							//}
							if( mode == 0 ) {
								m_treeViewEditor.DrawCurrent();
							}
							else {
								m_treeViewProject.DrawCurrent();
							}
						}
						GUILayout.Space( 4 );
					}
				}
			}
			catch( ArgumentException ) {
			}
			catch( Exception e ) {
				Debug.LogException( e );
			}
		}


		void DrawToolBar() {
			GUILayout.BeginHorizontal( EditorStyles.toolbar );

			EditorGUI.BeginChangeCheck();
			GUILayout.Toggle( mode == Mode.Editor, "Editor", EditorStyles.toolbarButton );
			if( EditorGUI.EndChangeCheck() ) {
				mode = Mode.Editor;
			}
			EditorGUI.BeginChangeCheck();
			GUILayout.Toggle( mode == Mode.Project, "Project", EditorStyles.toolbarButton );
			if( EditorGUI.EndChangeCheck() ) {
				mode = Mode.Project;
			}
			GUILayout.EndHorizontal();
		}



		void OnGUI() {
			//P.Load();
			DrawToolBar();

			BeginHorizontalSplit();
			using( new GUILayout.VerticalScope() ) {
				DrawLeftPane();
			}

			using( new GUILayout.VerticalScope( HEditorStyles.dopesheetBackground ) ) {
				DrawRightPane();
			}
			EndHorizontalSplit();
		}
	}
}

#endif
