
using HananokiEditor.Extensions;
using UnityEditor;
using UnityEngine;
using Process = System.Diagnostics.Process;
using SS = HananokiEditor.SharedModule.S;
using UnityDebug = UnityEngine.Debug;
using UnityObject = UnityEngine.Object;

namespace HananokiEditor {
	public static class ShellUtils {

		const string kExplorer = "EXPLORER.EXE";

		public static void Start( string fileName ) {
			Process.Start( fileName );
		}

		public static void Start( string fileName, string arguments ) {
			Process.Start( fileName, arguments );
		}

		public static void Start( string fileName, string arguments, System.EventHandler exitHandler ) {
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.FileName = fileName;
			p.StartInfo.Arguments = arguments;
			//p.SynchronizingObject = this;
			p.EnableRaisingEvents = true;
			p.Exited += ( sender, e ) => {
				EditorApplication.delayCall += () => {
					exitHandler( sender, e );
				};
			};

			p.Start();
		}



		/// <summary>
		/// 指定したパスをファイラで開きます
		/// </summary>
		/// <param name="path"></param>
		public static void OpenDirectory( string path ) {
			path = path.PrettyDirectoryName();

			if( UnitySymbol.UNITY_EDITOR_WIN ) {

				if( !path.IsExistsDirectory() ) {
					UnityDebug.LogWarning( $"ShellOpenDirectory: Not Found: {path}" );
					EditorUtility.DisplayDialog( SS._Warning, $"Not Found Directory\n{path}", "OK" );
					return;
				}

				// RevealInFinderは開きたいフォルダを選択した状態なのでエクスプローラで開く
				// "\\"はエクスプローラの都合を考えて付けたほうが無難かと思った
				path = $"{path.separatorToOS()}\\";
				Start( kExplorer, path );
			}
			else {
				// ??? 動作未確認
				EditorUtility.RevealInFinder( path );
			}
		}


		/// <summary>
		/// アセットの場所をファイラで開きます
		/// </summary>
		/// <param name="obj"></param>
		public static void OpenDirectory( UnityObject obj ) {
			OpenDirectory( AssetDatabase.GetAssetPath( obj ) );
		}
	}
}
