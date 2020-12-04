/// UnityEditor.WindowLayout : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorWindowLayout {
    

		public static string layoutsPreferencesPath {
			get {
				if( __layoutsPreferencesPath == null ) {
					__layoutsPreferencesPath = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), null, UnityTypes.UnityEditor_WindowLayout.GetMethod( "get_layoutsPreferencesPath", R.StaticMembers ) );
				}
				return __layoutsPreferencesPath();
			}
		}

		public static string layoutsModePreferencesPath {
			get {
				if( __layoutsModePreferencesPath == null ) {
					__layoutsModePreferencesPath = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), null, UnityTypes.UnityEditor_WindowLayout.GetMethod( "get_layoutsModePreferencesPath", R.StaticMembers ) );
				}
				return __layoutsModePreferencesPath();
			}
		}

		public static string layoutsDefaultModePreferencesPath {
			get {
				if( __layoutsDefaultModePreferencesPath == null ) {
					__layoutsDefaultModePreferencesPath = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), null, UnityTypes.UnityEditor_WindowLayout.GetMethod( "get_layoutsDefaultModePreferencesPath", R.StaticMembers ) );
				}
				return __layoutsDefaultModePreferencesPath();
			}
		}

		public static string layoutsProjectPath {
			get {
				if( __layoutsProjectPath == null ) {
					__layoutsProjectPath = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), null, UnityTypes.UnityEditor_WindowLayout.GetMethod( "get_layoutsProjectPath", R.StaticMembers ) );
				}
				return __layoutsProjectPath();
			}
		}

		public static string OldGlobalLayoutPath {
			get {
				if( __OldGlobalLayoutPath == null ) {
					__OldGlobalLayoutPath = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), null, UnityTypes.UnityEditor_WindowLayout.GetMethod( "get_OldGlobalLayoutPath", R.StaticMembers ) );
				}
				return __OldGlobalLayoutPath();
			}
		}

		public static string ProjectLayoutPath {
			get {
				if( __ProjectLayoutPath == null ) {
					__ProjectLayoutPath = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), null, UnityTypes.UnityEditor_WindowLayout.GetMethod( "get_ProjectLayoutPath", R.StaticMembers ) );
				}
				return __ProjectLayoutPath();
			}
		}

		public static string LastLayoutPath {
			get {
				if( __LastLayoutPath == null ) {
					__LastLayoutPath = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), null, UnityTypes.UnityEditor_WindowLayout.GetMethod( "get_LastLayoutPath", R.StaticMembers ) );
				}
				return __LastLayoutPath();
			}
		}
		public static bool LoadWindowLayout( string path, bool newProjectLayoutWasCreated ) {
			if( __LoadWindowLayout_0_2 == null ) {
				__LoadWindowLayout_0_2 = (Func<string,bool, bool>) Delegate.CreateDelegate( typeof( Func<string,bool, bool> ), null, UnityTypes.UnityEditor_WindowLayout.GetMethod( "LoadWindowLayout", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( bool ) }, null ) );
			}
			return __LoadWindowLayout_0_2( path, newProjectLayoutWasCreated );
		}
		
		public static bool LoadWindowLayout( string path, bool newProjectLayoutWasCreated, bool setLastLoadedLayoutName, bool keepMainWindow ) {
			if( __LoadWindowLayout_1_4 == null ) {
				__LoadWindowLayout_1_4 = (Func<string,bool,bool,bool, bool>) Delegate.CreateDelegate( typeof( Func<string,bool,bool,bool, bool> ), null, UnityTypes.UnityEditor_WindowLayout.GetMethod( "LoadWindowLayout", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( bool ), typeof( bool ), typeof( bool ) }, null ) );
			}
			return __LoadWindowLayout_1_4( path, newProjectLayoutWasCreated, setLastLoadedLayoutName, keepMainWindow );
		}
		
		public static void SaveWindowLayout( string path ) {
			if( __SaveWindowLayout_0_1 == null ) {
				__SaveWindowLayout_0_1 = (Action<string>) Delegate.CreateDelegate( typeof( Action<string> ), null, UnityTypes.UnityEditor_WindowLayout.GetMethod( "SaveWindowLayout", R.StaticMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			__SaveWindowLayout_0_1( path );
		}
		
		public static string GetCurrentLayoutPath() {
			if( __GetCurrentLayoutPath_0_0 == null ) {
				__GetCurrentLayoutPath_0_0 = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), null, UnityTypes.UnityEditor_WindowLayout.GetMethod( "GetCurrentLayoutPath", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetCurrentLayoutPath_0_0(  );
		}
		
		
		
		static Func<string> __layoutsPreferencesPath;
		static Func<string> __layoutsModePreferencesPath;
		static Func<string> __layoutsDefaultModePreferencesPath;
		static Func<string> __layoutsProjectPath;
		static Func<string> __OldGlobalLayoutPath;
		static Func<string> __ProjectLayoutPath;
		static Func<string> __LastLayoutPath;
		static Func<string,bool, bool> __LoadWindowLayout_0_2;
		static Func<string,bool,bool,bool, bool> __LoadWindowLayout_1_4;
		static Action<string> __SaveWindowLayout_0_1;
		static Func<string> __GetCurrentLayoutPath_0_0;
	}
}

