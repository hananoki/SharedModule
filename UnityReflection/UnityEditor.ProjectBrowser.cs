/// UnityEditor.ProjectBrowser : 2019.4.5f1

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
	public static partial class UnityEditorProjectBrowser {

		public static System.Collections.IList GetAllProjectBrowsers() {
			return  UnityTypes.ProjectBrowser.MethodInvoke<System.Collections.IList>( "GetAllProjectBrowsers", new object[] { } );
		}

		public static string GetActiveFolderPath( object instance ) {
			return instance.MethodInvoke<string>( "GetActiveFolderPath", new object[] { } );
		}



		public static bool IsTwoColumns( object instance ) {
			if( instance == null ) return false;
			return instance.MethodInvoke<bool>( "IsTwoColumns", new object[] { } );
		}



		public static void SetSearch( object instance, string searchString ) {
			instance.MethodInvoke( "SetSearch", new Type[] { typeof( String ) }, new object[] { searchString } );
		}

		public static void SetSearch( object instance, object searchFilter ) {
			instance.MethodInvoke( "SetSearch", new Type[] { UnityTypes.UnityEditor_SearchFilter }, new object[] { searchFilter } );
		}

		public static void ShowFolderContents( object instance, int folderInstanceID, bool revealAndFrameInFolderTree ) {
			instance.MethodInvoke( "ShowFolderContents", new object[] { folderInstanceID, revealAndFrameInFolderTree } );
		}


		public static string GetSelectedPath() {
			return R.Type( "UnityEditor.ProjectBrowser", "UnityEditor.dll" ).MethodInvoke<string>( "GetSelectedPath", new object[] { } );
		}

		public static bool isLocked( object instance ) {
			return instance.GetProperty<bool>( "isLocked" );
		}
		public static void isLocked( object instance, bool value ) {
			instance.SetProperty<bool>( "isLocked", value );
		}
	}
}

#endif

