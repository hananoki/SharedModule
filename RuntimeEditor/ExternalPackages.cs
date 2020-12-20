
//using UnityEditor;

namespace HananokiEditor {

	public static class ExternalPackages {

		public const string menuBuildAssist = "Window/Hananoki/Build Assist";
		public const string menuManifestJsonUtility = "Window/Hananoki/Manifest Json Utility";
		public const string menuScriptableObjectManager = "Window/Hananoki/Scriptable Object Manager";

		public static bool hasAsmdefEditor {
			get {
				var t = EditorHelper.GetTypeFromString( "HananokiEditor.AsmdefEditorWindow" );
				return t == null ? false : true;
			}
		}
		public static void ExecuteAsmdefEditor( string asmdefName ) {
			var t = EditorHelper.GetTypeFromString( "HananokiEditor.AsmdefEditorWindow" );
			t.MethodInvoke( "OpenAsName", new object[] { asmdefName } );
		}


		public static void ExecuteScriptableObjectManager() {
			var t = EditorHelper.GetTypeFromString( "HananokiEditor.ScriptableObjectManager.MainWindow" );
			var m = t.GetMethod( "Open", R.AllMembers );
			t.MethodInvoke( "Open", null );
		}
	}

}
