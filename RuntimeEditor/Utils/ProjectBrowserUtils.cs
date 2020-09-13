
using UnityEngine;
using UnityEditor;
using Hananoki.Extensions;

using System.Reflection;
using System;

namespace Hananoki {
	public static partial class ProjectBrowserUtils {

		static EditorWindow ProjectBrowserWindow => HEditorWindow.Find( UnityTypes.ProjectBrowser );




		static PropertyInfo s_ProjectBrowser_isLocked;
		static FieldInfo s_ProjectBrowser_m_IsLocked;




		/// <summary>
		/// 
		/// </summary>
		static void init() {
			if( UnityTypes.ProjectBrowser != null ) {
				if( UnitySymbol.Has( "UNITY_2018_1_OR_NEWER" ) ) {
					s_ProjectBrowser_isLocked = UnityTypes.ProjectBrowser.GetProperty( "isLocked", BindingFlags.NonPublic | BindingFlags.Instance );
				}
				else {
					s_ProjectBrowser_m_IsLocked = UnityTypes.ProjectBrowser.GetField( "m_IsLocked", BindingFlags.NonPublic | BindingFlags.Instance );
				}
			}
		}


		public static string currentProjectFolderPath {
			get {
				var window = ProjectBrowserWindow;
				string s;
				if( UnityEditorProjectBrowser.IsTwoColumns( window ) ) {
					s = UnityEditorProjectBrowser.GetActiveFolderPath( window );
				}
				else {
					s = UnityEditorProjectBrowser.GetSelectedPath();
					if( !AssetDatabase.IsValidFolder( s ) ) {
						s = s.GetDirectory();
					}
				}
				return s;
			}
		}

		public static void CreateFolder( string name ) {
			string s = currentProjectFolderPath;

			var ss = AssetDatabase.GenerateUniqueAssetPath( $"{s}/{name}" );
			AssetDatabase.CreateFolder( System.IO.Path.GetDirectoryName( ss ), System.IO.Path.GetFileName( ss ) );
		}



		/// <summary>
		/// プロジェクトブラウザの検索文字列を指定します
		/// </summary>
		/// <param name="searchString"></param>
		public static void SetSearch( string searchString ) => UnityEditorProjectBrowser.SetSearch( ProjectBrowserWindow, searchString );


		public static bool IsTwoColumns() => UnityEditorProjectBrowser.IsTwoColumns( ProjectBrowserWindow );




		public static bool m_IsLocked {
			get {
				init();
				if( UnitySymbol.Has( "UNITY_2018_1_OR_NEWER" ) ) {
					return (bool) s_ProjectBrowser_isLocked.GetValue( ProjectBrowserWindow );
				}
				else {
					return (bool) s_ProjectBrowser_m_IsLocked.GetValue( ProjectBrowserWindow );
				}
			}
			set {
				init();
				if( UnitySymbol.Has( "UNITY_2018_1_OR_NEWER" ) ) {
					s_ProjectBrowser_isLocked.SetValue( ProjectBrowserWindow, value );
				}
				else {
					s_ProjectBrowser_m_IsLocked.SetValue( ProjectBrowserWindow, value );
				}
			}
		}

		//static void m_ProjectBrowser_m_IsLocked_SetValue( bool b ) {
		//	Project_InitHelper();
		//	m_ProjectBrowser_m_IsLocked.SetValue( ProjectBrowserWindow, b );
		//}



		static void unlock() {
			m_IsLocked = false;
			Selection.selectionChanged -= unlock;
		}


		/// <summary>
		/// プロジェクトブラウザの表示状態を維持してオブジェクトの選択を行います
		/// </summary>
		/// <param name="obj"></param>
		public static void SelectionChangedLockProjectWindow( UnityEngine.Object obj ) {
			if( obj == null ) return;
			SelectionChangedLockProjectWindow( AssetDatabase.GetAssetPath( obj ) );
		}


		public static void SelectionChangedLockProjectWindow( string path ) {
			if( string.IsNullOrEmpty( path ) ) return;

			ProjectBrowserUtils.m_IsLocked = true;
			Selection.selectionChanged += unlock;

			Selection.activeObject = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>( path );
		}


		public static void lockOnce() {
			ProjectBrowserUtils.m_IsLocked = true;
			Selection.selectionChanged += unlock;
		}


		public static void ShowFolderContents( string assetPath, bool revealAndFrameInFolderTree ) {
			var obj = assetPath.LoadAssetAtPath();
			if( obj == null ) return;

			UnityEditorProjectBrowser.ShowFolderContents( ProjectBrowserWindow, obj.GetInstanceID(), true );
		}




		//public static string ValidateCreateNewAssetPath( string pathName ) {
		//	var obj = ProjectBrowser_ValidateCreateNewAssetPath.Invoke( ProjectBrowserWindow, new object[] { pathName } );
		//	return obj as string;
		//}
	}
}
