﻿
#define ENABLE_HANANOKI_SETTINGS

#if ENABLE_HANANOKI_SETTINGS

using Hananoki.Extensions;
using Hananoki.Reflection;
using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using System.Linq;

using SS = Hananoki.SharedModule.S;
using E = Hananoki.SharedModule.SettingsEditor;
using UnityEditorSplitterState = UnityReflection.UnityEditorSplitterState;
using UnityEditorSplitterGUILayout = UnityReflection.UnityEditorSplitterGUILayout;
using EditorAssemblies = UnityReflection.UnityEditorEditorAssemblies;

namespace Hananoki.SharedModule {
	public class SettingsItem {
		public int mode;
		public string displayName;
		public string version;
		public Action gui;

		public int hashCode => displayName.GetHashCode() + mode;
	}

	public class SettingsWindow : HEditorWindow {

		public enum Mode {
			Editor,
			Project,
		}

		static SettingsWindow s_instance;
		static SettingsItem[] s_settingsItem;

		UnityEditorSplitterState m_HorizontalSplitter;

		SettingsTreeView m_treeView;


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
			Open( $"{displayName}", 0 );
		}
		public static void OpenProject( string displayName ) {
			E.i.selectSettingMode = Mode.Project;
			Open( $"{displayName}", 1 );
		}

		public static void Open( string displayName, int mode ) {
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

			m_treeView = new SettingsTreeView();

			var settingsMethods = EditorAssemblies.GetAllMethodsWithAttribute<SettingsMethod>();
			s_settingsItem = settingsMethods.Select( x => (SettingsItem) x.Invoke( null, null ) ).ToArray();
			//foreach( var p in settingsMethods ) {
			//	//Debug.Log( p.FullName );
			//}
			//if( s_settingsItem == null ) {
			//	var lst = new System.Collections.Generic.List<SettingsItem>();
			//	var t = typeof( SettingsClass );
			//	foreach( Assembly assembly in AppDomain.CurrentDomain.GetAssemblies() ) {
			//		try {
			//			foreach( Type type in assembly.GetTypes() ) {
			//				try {
			//					if( type.GetCustomAttribute( t ) == null ) continue;
			//					var mm = R.Methods( typeof( SettingsMethod ), type.FullName, assembly.FullName.Split( ',' )[ 0 ] );
			//					//s_localizeEvent.AddRange( mm );
			//					var item = (SettingsItem) mm[ 0 ].Invoke( null, null );
			//					lst.Add( item );
			//				}
			//				catch( Exception ee ) {
			//					Debug.LogException( ee );
			//				}
			//			}
			//		}
			//		catch( ReflectionTypeLoadException ) {
			//		}
			//		catch( Exception e ) {
			//			Debug.LogError( e );
			//		}
			//	}
			//	s_settingsItem = lst.ToArray();
			//}

			if( s_settingsItem != null ) {
				foreach( var item in s_settingsItem ) {
					m_treeView.AddItem( item );
				}
			}

			m_treeView.ReloadAndSorting();
			m_treeView.ExpandAll();
			selectionOpen = true;
		}




		void DrawLeftPane() {
			if( selectionOpen ) {
				m_treeView.SelectAndExpand( E.i.selectSettingName, (int)E.i.selectSettingMode );
				selectionOpen = false;
			}

			m_treeView.DrawLayoutGUI();
		}


		void DrawRightPane() {
			try {
				using( var sc = new GUILayout.ScrollViewScope( m_scroll ) ) {
					m_scroll = sc.scrollPosition;

					HGUIScope.Layout();
					GUILayout.Space( 4 );
					m_treeView.DrawCurrent();
					HGUIScope.End();
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
			//DrawToolBar();

			UnityEditorSplitterGUILayout.BeginHorizontalSplit( m_HorizontalSplitter );

			HGUIScope.Vertical();
			DrawLeftPane();
			HGUIScope.End();

			HGUIScope.Vertical( HEditorStyles.dopesheetBackground );
			DrawRightPane();
			HGUIScope.End();

			UnityEditorSplitterGUILayout.EndHorizontalSplit();
		}
	}
}

#endif
