using UnityEditor;

namespace Hananoki {
	public static partial class UnityEditorMenu {

		public static void File_Build_Settings() {
			EditorApplication.ExecuteMenuItem( "File/Build Settings..." );
		}

		public static void File_Build_And_Run() {
			EditorApplication.ExecuteMenuItem( "File/Build And Run" );
		}

		public static void Edit_Preferences() {
			EditorApplication.ExecuteMenuItem( "Edit/Preferences..." );
		}

		public static void Edit_Project_Settings() {
			if( UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				EditorApplication.ExecuteMenuItem( "Edit/Project Settings..." );
			}
		}


		public static void Edit_Project_Settings_Input() {
			if( !UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Input" );
			}
		}

		public static void Edit_Project_Settings_Tags_and_Layers() {
			if( !UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Tags and Layers" );
			}
		}

		public static void Edit_Project_Settings_Audio() {
			if( !UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Audio" );
			}
		}

		public static void Edit_Project_Settings_Time() {
			if( !UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Time" );
			}
		}

		public static void Edit_Project_Settings_Player() {
			if( !UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Player" );
			}
		}

		public static void Edit_Project_Settings_Physics() {
			if( !UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Physics" );
			}
		}

		public static void Edit_Project_Settings_Physics_2D() {
			if( !UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Physics 2D" );
			}
		}

		public static void Edit_Project_Settings_Quality() {
			if( !UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Quality" );
			}
		}

		public static void Edit_Project_Settings_Graphics() {
			if( !UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Graphics" );
			}
		}

		public static void Edit_Project_Settings_Network() {
			if( !UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Network" );
			}
		}

		public static void Edit_Project_Settings_Editor() {
			if( !UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Editor" );
			}
		}

		public static void Edit_Project_Settings_Script_Execution_Order() {
			if( !UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Script Execution Order" );
			}
		}
	}
}
