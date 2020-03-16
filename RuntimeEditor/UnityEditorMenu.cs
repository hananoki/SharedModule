using UnityEditor;

namespace HananokiEditor {
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

#if UNITY_2018_3_OR_NEWER
		public static void Edit_Project_Settings() {
			EditorApplication.ExecuteMenuItem( "Edit/Project Settings..." );
		}
#endif


#if !UNITY_2018_3_OR_NEWER
		public static void Edit_Project_Settings_Input() {
			EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Input" );
		}

		public static void Edit_Project_Settings_Tags_and_Layers() {
			EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Tags and Layers" );
		}

		public static void Edit_Project_Settings_Audio() {
			EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Audio" );
		}

		public static void Edit_Project_Settings_Time() {
			EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Time" );
		}

		public static void Edit_Project_Settings_Player() {
			EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Player" );
		}

		public static void Edit_Project_Settings_Physics() {
			EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Physics" );
		}

		public static void Edit_Project_Settings_Physics_2D() {
			EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Physics 2D" );
		}

		public static void Edit_Project_Settings_Quality() {
			EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Quality" );
		}

		public static void Edit_Project_Settings_Graphics() {
			EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Graphics" );
		}

		public static void Edit_Project_Settings_Network() {
			EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Network" );
		}

		public static void Edit_Project_Settings_Editor() {
			EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Editor" );
		}

		public static void Edit_Project_Settings_Script_Execution_Order() {
			EditorApplication.ExecuteMenuItem( "Edit/Project Settings/Script Execution Order" );
		}
#endif
	}
}
