
using UnityEngine;
using UnityEditor;
using Hananoki.Extensions;
using Hananoki.Reflection;
using System.Reflection;
using UnityReflection;
//using ProjectBrowser = UnityReflection.UnityEditorProjectBrowser;

namespace Hananoki {
	public static partial class ProjectBrowserUtils {

		static UnityEditorProjectBrowser s_projectBrowser;
		static PropertyInfo s_ProjectBrowser_isLocked;
		static FieldInfo s_ProjectBrowser_m_IsLocked;


		/// <summary>
		/// 
		/// </summary>
		static bool init() {

			if( s_projectBrowser == null ) {
				s_projectBrowser = new UnityEditorProjectBrowser();
			}
			if( Helper.IsNull( s_projectBrowser.m_instance ) ) {
				s_projectBrowser = null;
			}

			if( UnitySymbol.Has( "UNITY_2018_1_OR_NEWER" ) ) {
				if( s_ProjectBrowser_isLocked == null ) {
					s_ProjectBrowser_isLocked = UnityTypes.UnityEditor_ProjectBrowser.GetProperty( "isLocked", BindingFlags.NonPublic | BindingFlags.Instance );
				}
			}
			else {
				if( s_ProjectBrowser_m_IsLocked == null ) {
					s_ProjectBrowser_m_IsLocked = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_IsLocked", BindingFlags.NonPublic | BindingFlags.Instance );
				}
			}
			return s_projectBrowser != null ? true : false;
		}


		public static string activeFolderPath {
			get {
				if( !init() ) return string.Empty;

				string s;
				if( s_projectBrowser.IsTwoColumns() ) {
					s = s_projectBrowser.GetActiveFolderPath();
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


		public static void CreateScriptAssetFromTemplateFile( string templatePath ) {
			var filepath = $"{activeFolderPath}/{templatePath.Split( '-' )[ 2 ].FileNameWithoutExtension()}";
			if( UnitySymbol.UNITY_2019_1_OR_NEWER ) {
				//ProjectWindowUtil.CreateScriptAssetFromTemplateFile( templatePath, filepath );
				UnityEditorProjectWindowUtil.CreateScriptAssetFromTemplateFile( templatePath, filepath );
			}
			else {
				UnityEditorProjectWindowUtil.CreateScriptAsset( templatePath, filepath );
			}
		}


		public static void CreateFolder( string name ) {
			string s = activeFolderPath;

			var ss = AssetDatabase.GenerateUniqueAssetPath( $"{s}/{name}" );
			AssetDatabase.CreateFolder( System.IO.Path.GetDirectoryName( ss ), System.IO.Path.GetFileName( ss ) );
		}



		/// <summary>
		/// プロジェクトブラウザの検索文字列を指定します
		/// </summary>
		/// <param name="searchString"></param>
		public static void SetSearch( string searchString ) {
			if( !init() ) return;

			s_projectBrowser.SetSearch( searchString );
		}


		public static bool IsTwoColumns() {
			if( !init() ) return false;

			return s_projectBrowser.IsTwoColumns();
		}



		static bool m_IsLocked {
			get {
				if( !init() ) return false;

				if( UnitySymbol.Has( "UNITY_2018_1_OR_NEWER" ) ) {
					return s_projectBrowser.isLocked;
				}
				else {
					return (bool) s_ProjectBrowser_m_IsLocked.GetValue( s_projectBrowser.m_instance );
				}
			}
			set {
				if( !init() ) return ;

				var browser = new UnityEditorProjectBrowser();
				if( browser.m_instance == null ) return;

				if( UnitySymbol.Has( "UNITY_2018_1_OR_NEWER" ) ) {
					s_ProjectBrowser_isLocked.SetValue( s_projectBrowser.m_instance, value );
				}
				else {
					s_ProjectBrowser_m_IsLocked.SetValue( s_projectBrowser.m_instance, value );
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

			m_IsLocked = true;
			Selection.selectionChanged += unlock;

			Selection.activeObject = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>( path );
		}


		public static void lockOnce() {
			m_IsLocked = true;
			Selection.selectionChanged += unlock;
		}

	}
}
