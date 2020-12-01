
#if ENABLE_HANANOKI_SETTINGS

using Hananoki.Extensions;
using Hananoki.Reflection;
using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

using SS = Hananoki.SharedModule.S;
using E = Hananoki.SharedModule.SettingsEditor;
using UnityEditorSplitterState = UnityReflection.UnityEditorSplitterState;
using UnityEditorSplitterGUILayout = UnityReflection.UnityEditorSplitterGUILayout;


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
		static SettingsItem[] s_settingsItem;

		UnityEditorSplitterState m_HorizontalSplitter;

		SettingsTreeView m_treeViewEditor;
		SettingsTreeView m_treeViewProject;


		//Mode mode;
		Vector2 m_scroll;

		static bool selectionOpen;

		[MenuItem( "Window/Hananoki/Settings" )]
		public static void Open() {
			var window = GetWindow<SettingsWindow>();
			window.SetTitle( new GUIContent( SS._Settings, EditorIcon.settings ) );
		}


		public static void OpenEditor( string displayName ) {
			E.i.selectSettingMode = Mode.Editor;
			Open( $"{displayName}" );
		}
		public static void OpenProject( string displayName ) {
			E.i.selectSettingMode = Mode.Project;
			Open( $"{displayName}" );
		}

		public static void Open( string displayName ) {
			Open();
			E.i.selectSettingName = displayName;
			selectionOpen = true;
		}


		new public static void Repaint() {
			( (EditorWindow) s_instance )?.Repaint();
		}


		void OnDestroy() {
			s_instance = null;
		}

		void OnEnable() {
			s_instance = this;

			m_HorizontalSplitter = new UnityEditorSplitterState( 0.3f, 0.7f );
			//Debug.Log( R.Type( "UnityEditor.SplitterState", "UnityEditor.dll" ).AssemblyQualifiedName );

			m_treeViewEditor = new SettingsTreeView();
			m_treeViewProject = new SettingsTreeView();

			if( s_settingsItem == null ) {
				var lst = new System.Collections.Generic.List<SettingsItem>();
				var t = typeof( SettingsClass );
				foreach( Assembly assembly in AppDomain.CurrentDomain.GetAssemblies() ) {
					try {
						foreach( Type type in assembly.GetTypes() ) {
							try {
								if( type.GetCustomAttribute( t ) == null ) continue;
								var mm = R.Methods( typeof( SettingsMethod ), type.FullName, assembly.FullName.Split( ',' )[ 0 ] );
								//s_localizeEvent.AddRange( mm );
								var item = (SettingsItem) mm[ 0 ].Invoke( null, null );
								lst.Add( item );
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
				s_settingsItem = lst.ToArray();
			}
			if( s_settingsItem != null ) {
				foreach( var item in s_settingsItem ) {
					if( item.mode == 0 ) {
						m_treeViewEditor.AddItem( item );
					}
					else {
						m_treeViewProject.AddItem( item );
					}
				}
			}

			m_treeViewEditor.ReloadAndSorting();
			m_treeViewEditor.ExpandAll();
			m_treeViewProject.ReloadAndSorting();
			m_treeViewProject.ExpandAll();
			selectionOpen = true;
		}


		//public void BeginHorizontalSplit( params GUILayoutOption[] options ) {
		//	R.Method( 2, "BeginHorizontalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll" ).Invoke( null, new object[] { m_HorizontalSplitter, options } );
		//}


		//public void EndHorizontalSplit() {
		//	R.Method( "EndHorizontalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll" ).Invoke( null, null );
		//}


		void DrawLeftPane() {
			if( selectionOpen ) {
				if( E.i.selectSettingMode == 0 ) {
					m_treeViewEditor.SelectAndExpand( E.i.selectSettingName );
				}
				else {
					m_treeViewProject.SelectAndExpand( E.i.selectSettingName );
				}
				selectionOpen = false;
			}

			if( E.i.selectSettingMode == 0 ) {
				m_treeViewEditor.DrawLayoutGUI();
			}
			else {
				m_treeViewProject.DrawLayoutGUI();
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
							if( E.i.selectSettingMode == 0 ) {
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
			GUILayout.Toggle( E.i.selectSettingMode == Mode.Editor, "Editor", EditorStyles.toolbarButton );
			if( EditorGUI.EndChangeCheck() ) {
				E.i.selectSettingMode = Mode.Editor;
			}
			EditorGUI.BeginChangeCheck();
			GUILayout.Toggle( E.i.selectSettingMode == Mode.Project, "Project", EditorStyles.toolbarButton );
			if( EditorGUI.EndChangeCheck() ) {
				E.i.selectSettingMode = Mode.Project;
			}
			GUILayout.EndHorizontal();
		}



		public override void OnDefaultGUI() {
			//P.Load();
			DrawToolBar();

			UnityEditorSplitterGUILayout.BeginHorizontalSplit( m_HorizontalSplitter );
			using( new GUILayout.VerticalScope() ) {
				DrawLeftPane();
			}

			using( new GUILayout.VerticalScope( HEditorStyles.dopesheetBackground ) ) {
				DrawRightPane();
			}
			UnityEditorSplitterGUILayout.EndHorizontalSplit();
		}
	}
}

#endif
