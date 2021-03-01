using HananokiEditor.Extensions;

using UnityEngine;
using UnityEditor;
using System.Linq;

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

		public static void SetClipboardGUID( object context ) {
			var path = context.ContextToAssetPath();

			Clipboard.SetText( path.ToGUID() );
			EditorHelper.ShowMessagePop( $"Copy  GUID\n{path.ToGUID()}" );
		}


		public static void ForceReserializeAssets( object context ) {
#if UNITY_2017_3_OR_NEWER
			var value = context.ContextToAssetPath();
			if( value.IsExistsFile() ) {
				AssetDatabase.ForceReserializeAssets( new string[] { value } );
			}
			else {
				var objs = AssetDatabase.FindAssets( "t:Object", new string[] { value } ).Select( x => x.ToAssetPath() ).ToArray();
				using( var prog = new ProgressBarScope( "ForceReserializeAssets", objs.Length ) ) {
					foreach( var path in objs ) {
						prog.Next( path );
						AssetDatabase.ForceReserializeAssets( new string[] { path } );
					}
				}
			}
#else
			Debug.LogError( "Available after UNITY_2017_3_OR_NEWER." );
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
