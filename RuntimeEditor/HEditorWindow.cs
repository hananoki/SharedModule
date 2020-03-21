using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

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
		
		public class PreferenceLayoutScope : IDisposable {
			Vector2 m_scrollPos;
			public PreferenceLayoutScope() {
				m_scrollPos = EditorGUILayout.BeginScrollView( m_scrollPos );
				GUILayout.BeginHorizontal();
				GUILayout.Space( 4 );
				GUILayout.BeginVertical();
			}
			public void Dispose() {
				GUILayout.EndVertical();
				GUILayout.EndHorizontal();
				EditorGUILayout.EndScrollView();
			}
		}


		/// <summary>
		/// Implement your own editor GUI here.
		/// </summary>
		void OnGUI() {
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
		}
	}
}