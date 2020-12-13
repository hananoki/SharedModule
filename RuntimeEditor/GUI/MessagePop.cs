
using HananokiEditor.Extensions;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;


namespace HananokiEditor {
	public class MessagePop : PopupWindowContent {
		string text;
		public static Vector2 windowSize = new Vector2( 300, ( 20 * 5 ) + 36 );
		//int index;
		//string[] dirPopup;
		GUIStyle label;

		 float time;
		public MessagePop( string text = "" ) {
			this.text = text;
			//this.folderPath = folderPath;
			//if( singleton.instance.selectedType == null || singleton.instance.selectedType.type == null ) {
			//	singleton.instance.selectedType = singleton.instance.manageTypes[ 0 ];
			//}
			//dirPopup = P.i.objectDirectories.Where( x => !x.IsEmpty() ).Where( x => Directory.Exists( GUIDUtils.GetAssetPath( x ) ) ).Distinct().ToArray();

			//index = singleton.instance.selectObjectDirectoryIndex;
			//index.Clamp( 0, dirPopup.Length - 1 );
			label = new GUIStyle( EditorStyles.label );
			label.alignment = TextAnchor.MiddleCenter;

			var mouseRect = new Rect( Event.current.mousePosition, Vector2.one );
			windowSize = label.CalcSize( EditorHelper.TempContent( text ) );
			windowSize.x += 16;
			windowSize.y += 16;
			//mouseRect.width = windowSize.x;
			mouseRect.x -= windowSize.x +8;
			mouseRect.y -= windowSize.y*0.5f;

			time =Time.realtimeSinceStartup;
			EditorApplication.update += Calc;

			PopupWindow.Show( mouseRect, this );
		}

		public void Calc() {
			var sa = Time.realtimeSinceStartup - time;
			if( 1.5f < sa ) {
				editorWindow.Close();
			}
		}

		public override void OnGUI( Rect rect ) {
			EditorGUI.LabelField( rect, text, label );
		}

		public override Vector2 GetWindowSize() {
			//if( !folderPath.IsEmpty() ) {
			//	var r = windowSize;
			//	r.y -= 48;
			//	return r;
			//}
			return windowSize;
		}
	}
}

