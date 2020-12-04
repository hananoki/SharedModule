﻿
using Hananoki.Extensions;
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Hananoki {
	public class HEditorWindow : EditorWindow {
		protected Action drawGUI;

		public void SetTitle( string text ) => this.SetTitle( new GUIContent( text ) );

		public void SetTitle( string text, Texture2D image ) => this.SetTitle( new GUIContent( text, image ) );

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

		//protected virtual void ShowButton( Rect r ) {
		//	//r.x -= 16;
		//	HEditorGUI.DrawDebugRect( r );
		//}

		public void OnGUI() {
			HGUIScope.Reset();
			try {
				OnDefaultGUI();
			}
			catch( ExitGUIException ) {
			}
			//catch( MissingReferenceException ) {
			//}
			catch( Exception e ) {
				Debug.LogException( e );
			}
			HGUIScope.SafePop();
		}

		public virtual void OnDefaultGUI() { }

		//public void DefaultDrawToolBar( Action draw ) {
		//	GUILayout.BeginHorizontal( EditorStyles.toolbar );
		//	draw?.Invoke();
		//	GUILayout.EndHorizontal();
		//}

		public static EditorWindow ShowWindow( Type editorWindowType, bool utility = false ) {
			return GetWindow( editorWindowType, utility );
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


		public static void RepaintWindow( Type editorWindowType ) {
			FindArray( editorWindowType ).RepaintArray();
		}


		public static void RepaintProjectWindow() => EditorApplication.RepaintProjectWindow();
		public static void RepaintHierarchyWindow() => EditorApplication.RepaintHierarchyWindow();
		public static void RepaintAnimationWindow() => EditorApplication.RepaintAnimationWindow();
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

		public override void OnDefaultGUI() {
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
