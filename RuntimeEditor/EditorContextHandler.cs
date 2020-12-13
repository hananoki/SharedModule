using HananokiEditor.Extensions;

using UnityEditor;

using SS = HananokiEditor.SharedModule.S;

namespace HananokiEditor {
	public class EditorContextHandler {

		public static void ShowNewInspectorWindow( object context ) {
			var value = context.ContextToObject();

			EditorHelper.ShowNewInspectorWindow( value );
		}

		public static void DuplicateAsset( object context ) {
			var value = context.ContextToObject();

			EditorHelper.DuplicateAsset( value );
		}


		public static void ForceReserializeAssets( object context ) {
			var value = context.ContextToAssetPath();
#if UNITY_2017_3_OR_NEWER
			AssetDatabase.ForceReserializeAssets( new string[] { value } );
#endif
		}


		public static void ProjectBrowserSetSearch( object context ) {
			var value = context.ContextToType();

			ProjectBrowserUtils.SetSearch( $"t:{value.FullName}" );
		}

		public static void CreateScriptAssetFromTemplateFile( object context ) {
			var filePath = (string) context;

			if( filePath.IsExistsFile() ) {
				ProjectBrowserUtils.CreateScriptAssetFromTemplateFile( filePath );
			}
			else {
				EditorUtility.DisplayDialog( SS._Info, SS._Templatefilenotfound, SS._OK );
				//ScriptTemplatesWindow.Open();
			}
		}
	}

}
