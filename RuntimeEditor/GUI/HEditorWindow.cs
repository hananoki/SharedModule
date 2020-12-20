
using HananokiEditor.Extensions;
//using Hananoki.Reflection;
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityReflection;

using E = HananokiEditor.SharedModule.SettingsEditor;
using EE = HananokiEditor.SharedModule.SettingsEditor;

namespace HananokiEditor {
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

		public UnityEditorEditorWindow _editorWindow;
		public bool m_disableShadeMode;
		public bool m_shade;
		public float m_height;

		protected virtual void ShowButton( Rect r ) {
			var rb = r;
			rb.x += ( 17 * 3 );
			//HEditorGUI.DrawDebugRect(rb);
			if( EditorHelper.HasMouseClick( rb ) ) {
				OnClose();
			}

			if( !E.i.m_windowShade ) return;
			if( m_disableShadeMode ) return;
			var a = (Texture2D) EditorIcon.icons_processed_unityengine_ui_aspectratiofitter_icon_asset;

			if( _editorWindow == null ) return;
			//if( _editorWindow.dockArea != null ) {
			if( _editorWindow.showMode == 4 ) return;
			//}

			if( HEditorGUI.IconButton( r, a ) ) {

				//Debug.Log( $"{position}" );
				var dockArea = _editorWindow.dockArea;
				//if( dockArea != null ) {
				//	var wnd = dockArea.GetProperty<object>( "window" );

				//	var inaa = wnd.GetField<int>( "m_ShowMode" );
				//	Debug.Log( inaa );
				//}

				if( position.height < 25 ) {
					var rr = position;
					rr.height = m_height;


					//if( dockArea == null ) Debug.Log( "dockArea null" );


					if( dockArea != null ) {
						var wnd = dockArea.GetProperty<object>( "window" );
						var rrc = wnd.GetProperty<Rect>( "position" );
						//Debug.Log( rrc );
						wnd.SetProperty<Rect>( "position", rr );
					}

					//position = rr;
				}
				else {
					minSize = new Vector2( minSize.x, -10 );
					var rr = position;
					m_height = rr.height;
					rr.height = 21;

					//var dockArea = _editorWindow.dockArea;
					//if( dockArea == null ) Debug.Log( "dockArea null" );
					if( dockArea != null ) {
						var wnd = dockArea.GetProperty<object>( "window" );
						wnd.SetProperty<Rect>( "position", rr );
					}

					//position = rr;
				}
				m_shade = !m_shade;
				//Debug.Log( m_shade );
			}
		}



		public virtual void OnClose() { }

		public void OnGUI() {
			if( _editorWindow == null ) {
				_editorWindow = new UnityEditorEditorWindow( this );
			}
			HGUIScope.Reset();
			try {
				OnDefaultGUI();
			}
			//catch( ArgumentException ) {
			// GUILayout.FlexibleSpace
			//}
			catch( ExitGUIException ) {
			}
			//catch( MissingReferenceException ) {
			//}
			catch( Exception e ) {
				Debug.LogException( e );
			}
			//HGUIScope.SafePop();
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

		


		public static void RepaintWindow( Type editorWindowType ) {
			EditorWindowUtils.FindArray( editorWindowType ).RepaintArray();
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



	public class HNEditorWindow<T> : EditorWindow where T : EditorWindow {

		public UnityEditorEditorWindow m_self;

		public UnityEditorDockArea _dockArea;

		public bool hasFocus => m_self.hasFocus;
		public bool docked => m_self.docked;

		public int showMode => m_self.showMode;

		public void SetTitle( string text ) => this.SetTitle( new GUIContent( text ) );

		public void SetTitle( string text, Texture2D image ) => this.SetTitle( new GUIContent( text, image ) );

		public HNEditorWindow() {
			m_self = new UnityEditorEditorWindow( this );

		}

		public static T GetOrCreate() {
			return GetWindow<T>( EE.IsUtilityWindow( typeof( T ) ) );
		}
		public bool m_shade;
		public float m_height;
		public bool m_disableShadeMode;
		public virtual void OnClose() { }

		protected virtual void ShowButton( Rect r ) {
			var rb = r;
			rb.x += ( 17 * 3 );
			//HEditorGUI.DrawDebugRect( rb );
			if( EditorHelper.HasMouseClick( rb ) ) {
				OnClose();
			}

			if( !E.i.m_windowShade ) return;
			if( m_disableShadeMode ) return;
			var a = (Texture2D) EditorIcon.icons_processed_unityengine_ui_aspectratiofitter_icon_asset;

			if( showMode == 4 ) return;
			//}

			if( HEditorGUI.IconButton( r, a ) ) {
				//var dockArea = _editorWindow.dockArea;

				if( position.height < 25 ) {
					var rr = position;
					rr.height = m_height+21;
					m_self.containerWindow.SetProperty<Rect>( "position", rr );
				}
				else {
					minSize = new Vector2( minSize.x, -10 );
					var rr = position;
					m_height = rr.height;
					rr.height = 21;

					m_self.containerWindow.SetProperty<Rect>( "position", rr );
				}
				m_shade = !m_shade;
				//Debug.Log( m_shade );
			}
		}


		public void OnGUI() {
			try {
				OnDefaultGUI();
			}
			//catch( ArgumentException ) {
			// GUILayout.FlexibleSpace
			//}
			catch( ExitGUIException ) {
			}
			//catch( MissingReferenceException ) {
			//}
			catch( Exception e ) {
				Debug.LogException( e );
			}
		}

		public virtual void OnDefaultGUI() { }
	}
}
