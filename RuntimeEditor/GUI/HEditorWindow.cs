using System;
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
	}


	public class HSettingsEditorWindow : HEditorWindow {
		GUIStyle sectionHeader;
		public string sectionName;
#if UNITY_2018_3_OR_NEWER
		public SettingsProvider m_settingsProvider;
#endif

		public class PreferenceLayoutScope : IDisposable {
			public PreferenceLayoutScope( ref Vector2 scrollPos ) {
				scrollPos = EditorGUILayout.BeginScrollView( scrollPos );
				GUILayout.BeginHorizontal();
				GUILayout.Space( 4 );
				GUILayout.BeginVertical();
			}
			public void Dispose() {
				GUILayout.EndVertical();
				GUILayout.Space( 4 );
				GUILayout.EndHorizontal();
				EditorGUILayout.EndScrollView();
			}
		}

		/*
			var rr = R.Type( "UnityEditor.StyleSheets.StyleCatalogKeyword" );
			var marginLeft = R.Field( "marginLeft", "UnityEditor.StyleSheets.StyleCatalogKeyword" );
			

			var ff = UnityStyleSheetsStyleBlock.GetFloat( (int)marginLeft.GetValue( null ), 0 );
			;
			//var aa = R.Methods( "GetStyle", "UnityEditor.Experimental.EditorResources" );
			//var hoge = aa[0].Invoke(null,new object[] { "sb-settings-header",null } );
			 
			var vara = R.Property( "settingsPanel", "UnityEditor.SettingsWindow+Styles" );
			var bl = new UnityStyleSheetsStyleBlock() { m_instance = vara.GetValue( null ) };
			var a = UnityStyleSheetsStyleCatalogKeyword.marginLeft;
			var ff = bl.GetFloat( a, 0 );
			
			GUILayout.Label( ""+ff );
			*/

		void DrawTitleBar( string s ) {
			GUILayout.BeginHorizontal();
			//GUILayout.Space( SettingsWindow.Styles.settingsPanel.GetFloat( StyleKeyword.marginLeft, 0f ) );
			GUILayout.Space( 10 );
			GUIContent content = new GUIContent( s );
			GUILayout.Label( content, "SettingsHeader" );
			GUILayout.FlexibleSpace();
			m_settingsProvider.OnTitleBarGUI();
			GUILayout.EndHorizontal();
		}

		/// <summary>
		/// Implement your own editor GUI here.
		/// </summary>
		void OnGUI() {
#if UNITY_2018_3_OR_NEWER
			try {
				var w = position.width - 4;
				var h = position.height;
				using( new EditorGUI.DisabledGroupScope( EditorApplication.isCompiling ) )
				using( new GUILayout.AreaScope( new Rect( 2, 2, w, h ) ) ) {
					DrawTitleBar( m_settingsProvider.label );
					m_settingsProvider.OnGUI( "" );
				}
			}
			catch( System.Exception e ) {
				Debug.LogError( e );
			}
#else

			try {
				var w = position.width - 4;
				var h = position.height;
				using( new EditorGUI.DisabledGroupScope( EditorApplication.isCompiling ) ) {
					using( new GUILayout.AreaScope( new Rect( 2, 2, w, h ) ) ) {
						if( sectionHeader == null ) {
							sectionHeader = new GUIStyle( EditorStyles.largeLabel );
							sectionHeader.fontStyle = FontStyle.Bold;
							sectionHeader.fontSize = 18;
							sectionHeader.margin.top = 10;
							sectionHeader.margin.left++;
							if( !EditorGUIUtility.isProSkin ) {
								sectionHeader.normal.textColor = new Color( 0.4f, 0.4f, 0.4f, 1f );
							}
							else {
								sectionHeader.normal.textColor = new Color( 0.7f, 0.7f, 0.7f, 1f );
							}
						}
						GUILayout.Label( sectionName, sectionHeader );
						//GUILayout.Space( 10f );
						drawGUI.Invoke();
					}
				}
			}
			catch( System.Exception e ) {
				Debug.LogError( e );
			}
#endif
		}
	}
}