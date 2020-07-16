
using UnityEngine;
using UnityEditor;
using Hananoki.Reflection;

using System.Reflection;
using System;

namespace Hananoki {
	public static class UnityEditorProjectBrowser {

		static EditorWindow s_ProjectBrowserWindow;
		static EditorWindow ProjectBrowserWindow {
			get {
				if( s_ProjectBrowserWindow == null ) {
					s_ProjectBrowserWindow = EditorWindow.GetWindow( ProjectBrowserType, false, "Project", false );
				}
				return s_ProjectBrowserWindow;
			}
		}


		static Type s_ProjectBrowserType;
		static Type ProjectBrowserType {
			get {
				if( s_ProjectBrowserType == null ) {
					s_ProjectBrowserType = Assembly.Load( "UnityEditor.dll" ).GetType( "UnityEditor.ProjectBrowser" );
				}
				return s_ProjectBrowserType;
			}
		}

		static MethodInfo s_ProjectBrowser_SetSearch;
		static MethodInfo ProjectBrowser_SetSearch {
			get {
				if( s_ProjectBrowser_SetSearch == null ) {
					foreach( MethodInfo mi in ProjectBrowserType.GetMethods( BindingFlags.Public | BindingFlags.Instance ) ) {
						if( mi.Name == "SetSearch" ) {
							var para = mi.GetParameters();
							if( para[ 0 ].Name == "searchString" ) {
								s_ProjectBrowser_SetSearch = mi;
								break;
							}
						}
					}
				}
				return s_ProjectBrowser_SetSearch;
			}
		}


		//static MethodInfo m_ProjectBrowser_FrameObject;
		static MethodInfo s_ProjectBrowser_ShowFolderContents;
		static MethodInfo ProjectBrowser_ShowFolderContents {
			get {
				if( s_ProjectBrowser_ShowFolderContents == null ) {
					s_ProjectBrowser_ShowFolderContents = s_ProjectBrowserType.GetMethod( "ShowFolderContents", BindingFlags.NonPublic | BindingFlags.Instance );
				}
				return s_ProjectBrowser_ShowFolderContents;
			}
		}

		static PropertyInfo s_ProjectBrowser_isLocked;
		static FieldInfo s_ProjectBrowser_m_IsLocked;

		static MethodInfo s_ProjectBrowser_ValidateCreateNewAssetPath;
		static MethodInfo ProjectBrowser_ValidateCreateNewAssetPath {
			get {
				if( s_ProjectBrowser_ValidateCreateNewAssetPath == null ) {
					s_ProjectBrowser_ValidateCreateNewAssetPath = ProjectBrowserType.GetMethod( "ValidateCreateNewAssetPath", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static );
				}
				return s_ProjectBrowser_ValidateCreateNewAssetPath;
			}
		}


		/// <summary>
		/// 
		/// </summary>
		static void init() {


			if( s_ProjectBrowserType != null ) {
				if( UnitySymbol.Has( "UNITY_2018_1_OR_NEWER" ) ) {
					s_ProjectBrowser_isLocked = s_ProjectBrowserType.GetProperty( "isLocked", BindingFlags.NonPublic | BindingFlags.Instance );
				}
				else {
					s_ProjectBrowser_m_IsLocked = s_ProjectBrowserType.GetField( "m_IsLocked", BindingFlags.NonPublic | BindingFlags.Instance );
				}
			}
		}



		public static EditorWindow Window() {
			return ProjectBrowserWindow;
		}

		public static Type Type() {
			return ProjectBrowserType;
		}


		/// <summary>
		/// プロジェクトブラウザの検索文字列を指定します
		/// </summary>
		/// <param name="searchString"></param>
		public static void SetSearch( string searchString ) {
			ProjectBrowser_SetSearch.Invoke( ProjectBrowserWindow, new object[] { searchString } );
		}


		static Func<bool> _IsTwoColumns;
		public static bool IsTwoColumns() {
			if( _IsTwoColumns == null ) {
				init();
				_IsTwoColumns = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), ProjectBrowserWindow, R.Method( "IsTwoColumns", "UnityEditor.ProjectBrowser" ) );
			}
			return _IsTwoColumns();
		}


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

			UnityEditorProjectBrowser.m_IsLocked = true;
			Selection.selectionChanged += unlock;

			Selection.activeObject = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>( path );
		}


		public static void lockOnce() {
			UnityEditorProjectBrowser.m_IsLocked = true;
			Selection.selectionChanged += unlock;
		}


		public static void ShowFolderContents( string assetPath, bool revealAndFrameInFolderTree ) {
			var obj = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>( assetPath );
			if( obj == null ) return;

			ShowFolderContents( obj.GetInstanceID(), true );
		}


		public static void ShowFolderContents( int folderInstanceID, bool revealAndFrameInFolderTree ) {
			ProjectBrowser_ShowFolderContents.Invoke( ProjectBrowserWindow, new object[] { folderInstanceID, revealAndFrameInFolderTree } );
		}


		public static string ValidateCreateNewAssetPath( string pathName ) {
			var obj = ProjectBrowser_ValidateCreateNewAssetPath.Invoke( ProjectBrowserWindow, new object[] { pathName } );
			return obj as string;
		}
	}
}
