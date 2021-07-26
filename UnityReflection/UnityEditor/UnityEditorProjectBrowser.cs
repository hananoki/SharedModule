/// UnityEditor.ProjectBrowser : 2020.3.8f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorProjectBrowser {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorProjectBrowser( object instance ){
			m_instance = instance;
    }
   // public UnityEditorProjectBrowser() {
			//m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_ProjectBrowser, new object[] {} );
   // }
    

		public object m_SearchFilter {
			get {
				if( __m_SearchFilter == null ) {
					__m_SearchFilter = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_SearchFilter", R.InstanceMembers );
				}
				return (object) __m_SearchFilter.GetValue( m_instance );
			}
			set {
				if( __m_SearchFilter == null ) {
					__m_SearchFilter = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_SearchFilter", R.InstanceMembers );
				}
				__m_SearchFilter.SetValue( m_instance, value );
			}
		}

		public object m_AssetTree {
			get {
				if( __m_AssetTree == null ) {
					__m_AssetTree = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_AssetTree", R.InstanceMembers );
				}
				return (object) __m_AssetTree.GetValue( m_instance );
			}
			set {
				if( __m_AssetTree == null ) {
					__m_AssetTree = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_AssetTree", R.InstanceMembers );
				}
				__m_AssetTree.SetValue( m_instance, value );
			}
		}

		public object m_FolderTree {
			get {
				if( __m_FolderTree == null ) {
					__m_FolderTree = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_FolderTree", R.InstanceMembers );
				}
				return (object) __m_FolderTree.GetValue( m_instance );
			}
			set {
				if( __m_FolderTree == null ) {
					__m_FolderTree = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_FolderTree", R.InstanceMembers );
				}
				__m_FolderTree.SetValue( m_instance, value );
			}
		}

		public object m_ListArea {
			get {
				if( __m_ListArea == null ) {
					__m_ListArea = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_ListArea", R.InstanceMembers );
				}
				return (object) __m_ListArea.GetValue( m_instance );
			}
			set {
				if( __m_ListArea == null ) {
					__m_ListArea = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_ListArea", R.InstanceMembers );
				}
				__m_ListArea.SetValue( m_instance, value );
			}
		}

		public string m_SearchFieldText {
			get {
				if( __m_SearchFieldText == null ) {
					__m_SearchFieldText = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_SearchFieldText", R.InstanceMembers );
				}
				return (string) __m_SearchFieldText.GetValue( m_instance );
			}
			set {
				if( __m_SearchFieldText == null ) {
					__m_SearchFieldText = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_SearchFieldText", R.InstanceMembers );
				}
				__m_SearchFieldText.SetValue( m_instance, value );
			}
		}

		public double m_NextSearch {
			get {
				if( __m_NextSearch == null ) {
					__m_NextSearch = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_NextSearch", R.InstanceMembers );
				}
				return (double) __m_NextSearch.GetValue( m_instance );
			}
			set {
				if( __m_NextSearch == null ) {
					__m_NextSearch = UnityTypes.UnityEditor_ProjectBrowser.GetField( "m_NextSearch", R.InstanceMembers );
				}
				__m_NextSearch.SetValue( m_instance, value );
			}
		}

		public bool isLocked {
			get {
				if( __getter_isLocked == null ) {
					__getter_isLocked = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "get_isLocked", R.InstanceMembers ) );
				}
				return __getter_isLocked();
			}
			set {
				if( __setter_isLocked == null ) {
					__setter_isLocked = (Action<bool>) Delegate.CreateDelegate( typeof( Action<bool> ), m_instance, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "set_isLocked", R.InstanceMembers ) );
			  }
				__setter_isLocked( value );
			}
		}

		public static string GetSelectedPath() {
			if( __GetSelectedPath_0_0 == null ) {
				__GetSelectedPath_0_0 = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), null, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "GetSelectedPath", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetSelectedPath_0_0();
		}
		
		public static System.Collections.IList GetAllProjectBrowsers() {
			if( __GetAllProjectBrowsers_0_0 == null ) {
				__GetAllProjectBrowsers_0_0 = (Func<System.Collections.IList>) Delegate.CreateDelegate( typeof( Func<System.Collections.IList> ), null, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "GetAllProjectBrowsers", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetAllProjectBrowsers_0_0();
		}
		
		public static int[] GetFolderInstanceIDs( string[] folders ) {
			if( __GetFolderInstanceIDs_0_1 == null ) {
				__GetFolderInstanceIDs_0_1 = (Func<string[], int[]>) Delegate.CreateDelegate( typeof( Func<string[], int[]> ), null, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "GetFolderInstanceIDs", R.StaticMembers, null, new Type[]{ typeof( string[] ) }, null ) );
			}
			return __GetFolderInstanceIDs_0_1( folders );
		}
		
		public void SetSearch( string searchString ) {
			if( __SetSearch_0_1 == null ) {
				__SetSearch_0_1 = (Action<string>) Delegate.CreateDelegate( typeof( Action<string> ), m_instance, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "SetSearch", R.InstanceMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			__SetSearch_0_1( searchString );
		}
		
		public void SetSearch( object searchFilter ) {
			if( __SetSearch_1_1 == null ) {
				__SetSearch_1_1 = (Action<object>) Delegate.CreateDelegate( typeof( Action<object> ), m_instance, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "SetSearch", R.InstanceMembers, null, new Type[]{ typeof( object ) }, null ) );
			}
			__SetSearch_1_1( searchFilter );
		}
		
		public string GetActiveFolderPath() {
			if( __GetActiveFolderPath_0_0 == null ) {
				__GetActiveFolderPath_0_0 = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), m_instance, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "GetActiveFolderPath", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __GetActiveFolderPath_0_0();
		}
		
		public bool IsTwoColumns() {
			if( __IsTwoColumns_0_0 == null ) {
				__IsTwoColumns_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "IsTwoColumns", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __IsTwoColumns_0_0();
		}
		
		public void SetFolderSelection( int[] selectedInstanceIDs, bool revealSelectionAndFrameLastSelected ) {
			if( __SetFolderSelection_0_2 == null ) {
				__SetFolderSelection_0_2 = (Action<int[],bool>) Delegate.CreateDelegate( typeof( Action<int[],bool> ), m_instance, UnityTypes.UnityEditor_ProjectBrowser.GetMethod( "SetFolderSelection", R.InstanceMembers, null, new Type[]{ typeof( int[] ), typeof( bool ) }, null ) );
			}
			__SetFolderSelection_0_2( selectedInstanceIDs, revealSelectionAndFrameLastSelected );
		}
		
		
		
		FieldInfo __m_SearchFilter;
		FieldInfo __m_AssetTree;
		FieldInfo __m_FolderTree;
		FieldInfo __m_ListArea;
		FieldInfo __m_SearchFieldText;
		FieldInfo __m_NextSearch;
		Func<bool> __getter_isLocked;
		Action<bool> __setter_isLocked;
		static Func<string> __GetSelectedPath_0_0;
		static Func<System.Collections.IList> __GetAllProjectBrowsers_0_0;
		static Func<string[], int[]> __GetFolderInstanceIDs_0_1;
		Action<string> __SetSearch_0_1;
		Action<object> __SetSearch_1_1;
		Func<string> __GetActiveFolderPath_0_0;
		Func<bool> __IsTwoColumns_0_0;
		Action<int[],bool> __SetFolderSelection_0_2;
	}
}

