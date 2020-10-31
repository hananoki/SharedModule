
using Hananoki.Extensions;
using System;
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityObject = UnityEngine.Object;

namespace Hananoki {




	public static class EditorUtils {
		

		public static void ForceReloadInspectors() {
			var _ForceReloadInspectors = typeof( UnityEditor.EditorUtility ).GetMethod( "ForceReloadInspectors", BindingFlags.NonPublic | BindingFlags.Static );
			_ForceReloadInspectors.Invoke( null, null );
		}


		public static void SetPrefabOverride( object userData ) {
			SerializedProperty serializedProperty = (SerializedProperty) userData;

			serializedProperty.serializedObject.Update();
			serializedProperty.prefabOverride = false;
			serializedProperty.serializedObject.ApplyModifiedProperties();

			//Assembly assembly = typeof( UnityEditor.EditorUtility ).Assembly;

			ForceReloadInspectors();
			//EditorUtility.ForceReloadInspectors();
			//Debug.Log(aaa);
			GUI.FocusControl( "" );

			serializedProperty.serializedObject.Update();
			serializedProperty.prefabOverride = false;
			serializedProperty.serializedObject.ApplyModifiedProperties();
			ForceReloadInspectors();
		}

		public static void showNotification( string text ) {
			if( SceneView.lastActiveSceneView ) {
				GUIContent guiContent = new GUIContent();
				guiContent.text = text;
				guiContent.image = EditorGUIUtility.FindTexture( "SceneAsset Icon" );

				//UnityEditor.SceneView.currentDrawingSceneView.ShowNotification( guiContent );
				SceneView.lastActiveSceneView.ShowNotification( guiContent );
				SceneView.RepaintAll();
			}
		}



		/// <summary>
		/// ファイラで指定したパスを開く
		/// </summary>
		/// <param name="path"></param>
		public static void ShellOpenDirectory( string path ) {
			if( UnitySymbol.Has( "UNITY_EDITOR_WIN" ) ) {
				path = path.Replace( "/", "\\" ) + "\\";

				if( !Directory.Exists( path ) ) {
					Debug.LogWarning( $"ShellOpenDirectory: Not Found: {path}" );
					EditorUtility.DisplayDialog( "Warning", $"Not Found Directory\n{path}", "OK" );
					return;
				}
				// RevealInFinderは開きたいフォルダを選択した状態なのでエクスプローラで開く
				System.Diagnostics.Process.Start( "EXPLORER.EXE", path );
			}
			else {
				// ??? 動作未確認
				EditorUtility.RevealInFinder( path );
			}
		}

		public static void ShellOpenDirectory( UnityObject obj ) {
			ShellOpenDirectory( AssetDatabase.GetAssetPath( obj ) );
		}





		#region ScreenCapture

		static string MakeScreenCaptureFileName( int width, int height ) {
			string fpath = string.Format( "{0}/ScreenShot/ScreenShot_{1}x{2}_{3}",
													Directory.GetCurrentDirectory(),
													width, height,
													DateTime.Now.ToString( "yyyy-MM-dd_HH-mm-ss" ) );

			string f = fpath;
			int index = 1;

			while( File.Exists( f + ".png" ) ) {
				f = string.Format( "{0}_{1}", fpath, index );
				index++;
			}

			return f + ".png";
		}

		public static int s_captureScale = 1;

		public static void SaveScreenCapture() {
			var dname = Directory.GetCurrentDirectory() + "/ScreenShot";
			if( !Directory.Exists( dname ) ) {
				Directory.CreateDirectory( dname );
			}

			string filename = MakeScreenCaptureFileName( (int) Handles.GetMainGameViewSize().x * s_captureScale, (int) Handles.GetMainGameViewSize().y * s_captureScale );
#if UNITY_2017_1_OR_NEWER
			ScreenCapture.CaptureScreenshot( filename, s_captureScale );
#else
			Application.CaptureScreenshot( filename, Multi );
#endif
			Debug.Log( $"SaveScreenCapture: {filename }" );

			var gameview = EditorWindow.GetWindow( typeof( EditorWindow ).Assembly.GetType( "UnityEditor.GameView" ) );
			// GameViewを再描画 
			gameview.Repaint();
		}

		#endregion


		
	}
}

namespace Hananoki {
	public static partial class UnityEditorUserBuildSettingsUtils {
		public static BuildTarget CalculateSelectedBuildTarget( BuildTargetGroup group ) {
			var bak = EditorUserBuildSettings.selectedBuildTargetGroup;
			EditorUserBuildSettings.selectedBuildTargetGroup = group;

			var ret = CalculateSelectedBuildTarget();

			EditorUserBuildSettings.selectedBuildTargetGroup = bak;
			return ret;
		}
	}
}
