
using Hananoki;
using System;
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Hananoki {
	public static class EditorUtils {

		private static Type typeFoldoutTitlebar;
		private static MethodInfo methodInfoFoldoutTitlebar;
		private static MethodInfo EditorGUI_FoldoutTitlebar;

		public static bool FoldoutTitlebar( Rect rect, bool foldout, GUIContent label, bool skipIconSpacing ) {
			if( EditorGUI_FoldoutTitlebar == null ) {
#if UNITY_5_5 || UNITY_5_6 || UNITY_2017_1_OR_NEWER
				var t = System.Reflection.Assembly.Load( "UnityEditor.dll" ).GetType( "UnityEditor.EditorGUI" );
#else
				typeFoldoutTitlebar = Types.GetType( "UnityEditor.EditorGUILayout", "UnityEditor.dll" );
#endif
				EditorGUI_FoldoutTitlebar = t.GetMethod( "FoldoutTitlebar", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static );
			}

			var obj = EditorGUI_FoldoutTitlebar.Invoke( null, new object[] { rect, label, foldout, skipIconSpacing } );
			return Convert.ToBoolean( obj );
		}

		public static bool FoldoutTitlebar( Rect rect, bool foldout, string label, bool skipIconSpacing ) {
			return FoldoutTitlebar( rect, foldout, EditorHelper.TempContent( label ), skipIconSpacing );
		}



		public static bool FoldoutTitlebar( bool foldout, GUIContent label, bool skipIconSpacing ) {
			if( methodInfoFoldoutTitlebar == null ) {
#if UNITY_5_5 || UNITY_5_6 || UNITY_2017_1_OR_NEWER
				typeFoldoutTitlebar = System.Reflection.Assembly.Load( "UnityEditor.dll" ).GetType( "UnityEditor.EditorGUILayout" );
#else
				typeFoldoutTitlebar = Types.GetType( "UnityEditor.EditorGUILayout", "UnityEditor.dll" );
#endif
				methodInfoFoldoutTitlebar = typeFoldoutTitlebar.GetMethod( "FoldoutTitlebar", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static );
			}

			var obj = methodInfoFoldoutTitlebar.Invoke( null, new object[] { foldout, label, skipIconSpacing } );
			return Convert.ToBoolean( obj );
		}
		public static bool FoldoutTitlebar( bool foldout, string label, bool skipIconSpacing ) {
			return FoldoutTitlebar( foldout, EditorHelper.TempContent( label ), skipIconSpacing );
		}



		public static bool AnimationControllerIsRegistered( UnityEditor.Animations.AnimatorController controller, AnimationClip clip ) {
			var st = controller.layers[ 0 ].stateMachine.states;

			if( 0 <= System.Array.FindIndex( controller.animationClips, ( c ) => { return c.name == clip.name; } ) ) {
				int i = System.Array.FindIndex( st, c => c.state.motion == clip );
				if( 0 <= i ) {
					if( st[ i ].state.name != clip.name ) {
						//console.log( st[ i ].state.name );
						st[ i ].state.name = clip.name;
					}
				}
				return true;
			}
			return false;
		}


		//public static void SetBoldFont( SerializedProperty prop ) {
		//	if( prop.prefabOverride ) {
		//		GUI.skin.font = EditorStyles.boldFont;
		//	}
		//	else {
		//		GUI.skin.font = EditorStyles.standardFont;
		//	}
		//}

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
#if UNITY_EDITOR_WIN
			path = path.Replace( "/", "\\" ) + "\\";

			if( !Directory.Exists( path ) ) {
				Debug.LogWarning( $"ShellOpenDirectory: Not Found: {path}" );
				EditorUtility.DisplayDialog( "Warning", $"Not Found Directory\n{path}", "OK" );
				return;
			}
			// RevealInFinderは開きたいフォルダを選択した状態なのでエクスプローラで開く
			System.Diagnostics.Process.Start( "EXPLORER.EXE", path );
#else
			// ??? 動作未確認
			EditorUtility.RevealInFinder( path );
#endif
		}


		public static void Refresh() {
			AssetDatabase.SaveAssets();
			AssetDatabase.Refresh();
		}


		#region EditorWindow

		public static EditorWindow InspectorWindow() {
			Assembly assembly = typeof( EditorWindow ).Assembly;
			foreach( EditorWindow a in Resources.FindObjectsOfTypeAll( assembly.GetType( "UnityEditor.InspectorWindow" ) ) ) {
				//a.Repaint();
				return a;
			}
			return null;
			//return EditorWindow.GetWindow(  ) );
		}

		public static EditorWindow ProjectBrowser() {
			var t = typeof( UnityEditor.EditorWindow ).Assembly.GetType( "UnityEditor.ProjectBrowser" );

			return EditorWindow.GetWindow( t, false, "Project", false );
		}

		public static EditorWindow SceneHierarchyWindow() {
			var t = typeof( UnityEditor.EditorWindow ).Assembly.GetType( "UnityEditor.SceneHierarchyWindow" );

			return EditorWindow.GetWindow( t, false, "Hierarchy", false );
		}

		public static EditorWindow AnimationWindow() {
			//アニメーションウィンドウ
			var asm = Assembly.Load( "UnityEditor" );
			var typeAnimWindow = asm.GetType( "UnityEditor.AnimationWindow" );
			return EditorWindow.GetWindow( typeAnimWindow, true, "Animation", false );
		}

		public static EditorWindow AnimatorWindow() {
			var asm2 = Assembly.Load( "UnityEditor.Graphs" );
			Module editorGraphModule = asm2.GetModule( "UnityEditor.Graphs.dll" );
			var typeAnimatorWindow = editorGraphModule.GetType( "UnityEditor.Graphs.AnimatorControllerTool" );
			return EditorWindow.GetWindow( typeAnimatorWindow, true, "Animator", false );
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
			EditorUtils.InspectorWindow()?.Repaint();
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
