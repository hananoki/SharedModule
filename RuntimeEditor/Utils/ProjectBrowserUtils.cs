
using HananokiEditor.Extensions;
using HananokiRuntime;
using HananokiRuntime.Extensions;
using System.Reflection;
using UnityEditor;
using UnityReflection;

namespace HananokiEditor {
	public static partial class ProjectBrowserUtils {

		static UnityEditorProjectBrowser s_projectBrowser;
		static UnityEditorSearchFilter s_searchFilter;
		static UnityEditorObjectListArea s_objectListArea;

		static UnityEditorPingData s_objectListAreaPing;
		static UnityEditorPingData s_AssetTreePing;

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

			if( s_projectBrowser != null ) {
				s_searchFilter = new UnityEditorSearchFilter( s_projectBrowser.m_SearchFilter );
				s_objectListArea = new UnityEditorObjectListArea( s_projectBrowser.m_ListArea );
				s_objectListAreaPing = new UnityEditorPingData( s_objectListArea.m_Ping );

				if( s_projectBrowser.m_AssetTree != null ) {
					var cont = new UnityEditorIMGUIControlsTreeViewController( s_projectBrowser.m_AssetTree );
					var gui = new UnityEditorAssetsTreeViewGUI( cont.gui );
					s_AssetTreePing = new UnityEditorPingData( gui.m_Ping );
				}
				//s_AssetTreePing = new UnityEditorPingData( s_projectBrowser.m_AssetTree );
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


		public static void CreateScriptAssetFromTemplateFile( string templatePath, string createFolderPath = "" ) {
			if( createFolderPath.IsEmpty() ) {
				createFolderPath = activeFolderPath;
			}
			var filepath = $"{createFolderPath}/{templatePath.Split( '-' )[ 2 ].FileNameWithoutExtension()}";
			if( UnitySymbol.UNITY_2019_1_OR_NEWER ) {
				//ProjectWindowUtil.CreateScriptAssetFromTemplateFile( templatePath, filepath );
				UnityEditorProjectWindowUtil.CreateScriptAssetFromTemplateFile( templatePath, filepath );
			}
			else {
				UnityEditorProjectWindowUtil.CreateScriptAsset( templatePath, filepath );
			}
		}



		public static string CreateFolder( string name ) {
			var ss = AssetDatabase.GenerateUniqueAssetPath( $"{activeFolderPath}/{name}" );
			return AssetDatabase.CreateFolder( System.IO.Path.GetDirectoryName( ss ), System.IO.Path.GetFileName( ss ) );
		}


		public static void SetFolderSelection( bool revealSelectionAndFrameLastSelected, params string[] paths ) {
			if( !init() ) return;

			var ids = UnityEditorProjectBrowser.GetFolderInstanceIDs( paths );
			s_projectBrowser.SetFolderSelection( ids, true );
		}


		/// <summary>
		/// プロジェクトブラウザの検索文字列を指定します
		/// </summary>
		/// <param name="searchString"></param>
		public static void SetSearch( string searchString ) {
			if( !init() ) return;

			s_projectBrowser.SetSearch( searchString );
		}


		public static bool isTwoColumns {
			get {
				if( !init() ) return false;

				return s_projectBrowser.IsTwoColumns();
			}
		}

		public static bool isSearching {
			get {
				if( !init() ) return false;

				return s_searchFilter.IsSearching();
			}
		}

		public static bool pingUsed;

		public static bool isPinging {
			get {
				if( !init() ) return false;

				var ping = isTwoColumns ? s_objectListAreaPing : s_AssetTreePing;

				if( pingUsed ) {
					if( !ping.isPinging ) {
						pingUsed = false;
					}
					return false;
				}
				return ping.isPinging;
			}
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
				if( !init() ) return;

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


		public static void SelectionChangedLockProjectWindow( string path ) {
			if( path.IsEmpty() ) return;

			SelectionChangedLockProjectWindow( path.LoadAsset() );
		}

		/// <summary>
		/// プロジェクトブラウザの表示状態を維持してオブジェクトの選択を行います
		/// </summary>
		/// <param name="obj"></param>
		public static void SelectionChangedLockProjectWindow( UnityEngine.Object obj ) {
			if( obj == null ) return;

			m_IsLocked = true;
			Selection.selectionChanged += unlock;
			Selection.activeObject = obj;
		}


		public static void lockOnce() {
			m_IsLocked = true;
			Selection.selectionChanged += unlock;
		}

	}
}
