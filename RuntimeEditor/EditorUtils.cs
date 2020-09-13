
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

		//public static bool CheckDefineFolder() {
		//	var dia = AssetDatabase.GUIDToAssetPath( LocalSettings.i.m_folderDefine );
		//	if( string.IsNullOrEmpty( dia ) ) {
		//		if( EditorUtility.DisplayDialog( "確認", "LocalSettings.m_folderDefine\nフォルダーが設定されていません", "OK" ) ) {
		//			Selection.activeObject = LocalSettings.i;
		//			return false;
		//		}
		//	}
		//	return true;
		//}


		public static void RepaintEditorWindow() {
			foreach( EditorWindow a in Resources.FindObjectsOfTypeAll( typeof( EditorWindow ) ) ) {
				a.Repaint();
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


		//public static void Refresh() {
		//	AssetDatabase.SaveAssets();
		//	AssetDatabase.Refresh();
		//}


		#region EditorWindow



		public static EditorWindow ProjectBrowser() {
			var t = typeof( UnityEditor.EditorWindow ).Assembly.GetType( "UnityEditor.ProjectBrowser" );

			return EditorWindow.GetWindow( t, false, "Project", false );
		}

		public static EditorWindow SceneHierarchyWindow() {
			var t = typeof( UnityEditor.EditorWindow ).Assembly.GetType( "UnityEditor.SceneHierarchyWindow" );

			return EditorWindow.GetWindow( t, false, "Hierarchy", false );
		}






		public static Type AnimatorWindowType {
			get {
				var asm = Assembly.Load( "UnityEditor.Graphs" );
				Module editorGraphModule = asm.GetModule( "UnityEditor.Graphs.dll" );
				return editorGraphModule.GetType( "UnityEditor.Graphs.AnimatorControllerTool" );
			}
		}

		public static EditorWindow AnimatorWindow() {
			return EditorWindow.GetWindow( AnimatorWindowType, false, "Animator", false );
		}


		public static EditorWindow ConsoleWindow() {
			var asm = Assembly.Load( "UnityEditor" );
			var typeConslWindow = asm.GetType( "UnityEditor.ConsoleWindow" );
			return EditorWindow.GetWindow( typeConslWindow, true, "Console", false );
		}

		public static EditorWindow AssetStoreWindow( bool utility = false ) {
			//アセットストアウィンドウ
			var asm = Assembly.Load( "UnityEditor" );
			var typeAssetWindow = asm.GetType( "UnityEditor.AssetStoreWindow" );
			return EditorWindow.GetWindow( typeAssetWindow, utility, "Asset Store", false );
		}

		#endregion


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


		/// <summary>
		/// Verify whether it can be converted to the specified component.
		/// </summary>
		public static bool CanConvertTo<T>( UnityEngine.Object context )
		 where T : MonoBehaviour {
			return context && context.GetType() != typeof( T );
		}


		/// <summary>
		/// Convert to the specified component.
		/// </summary>
		public static void ConvertTo<T>( UnityEngine.Object context ) where T : MonoBehaviour {
			var target = context as MonoBehaviour;
			var so = new SerializedObject( target );
			so.Update();

			bool oldEnable = target.enabled;
			target.enabled = false;

			// Find MonoScript of the specified component.
			foreach( var script in Resources.FindObjectsOfTypeAll<MonoScript>() ) {
				if( script.GetClass() != typeof( T ) )
					continue;

				// Set 'm_Script' to convert.
				so.FindProperty( "m_Script" ).objectReferenceValue = script;
				so.ApplyModifiedProperties();
				break;
			}

		 ( so.targetObject as MonoBehaviour ).enabled = oldEnable;
		}
	}

	public class HEditorApplication {
		public static void RepaintInspectorWindow() {
			HEditorWindow.FindArray( UnityTypes.InspectorWindow ).RepaintArray();
			//EditorWindowUtils.InspectorWindow?.Repaint();
		}
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
