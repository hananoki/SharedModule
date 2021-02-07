using UnityEditor;
using UnityEngine;

namespace HananokiEditor {
	public static class UnityProject {

		static int s_urpFlag = -1;
		static int s_hdrpFlag = -1;

		public static bool hasURP {
			get {
				if( s_urpFlag < 0 ) {
					s_urpFlag = 0;
					foreach( var s in Unsupported.GetSubmenus( "Assets" ) ) {
						//Debug.Log( s );
						if( s.Contains( "Assets/Create/Rendering/Universal Render Pipeline" ) ) {
							s_urpFlag=1;
							break;
						}
					}
				}
				return s_urpFlag == 0 ? false : true;
			}
		}
		public static bool hasHDRP {
			get {
				if( s_hdrpFlag < 0 ) {
					s_hdrpFlag = 0;
					foreach( var s in Unsupported.GetSubmenus( "Assets" ) ) {
						//Debug.Log( s );
						if( s.Contains( "Assets/Create/Rendering/High Definition Render Pipeline Asset" ) ) {
							s_hdrpFlag = 1;
							break;
						}
					}
				}
				return s_hdrpFlag == 0 ? false : true;
			}
		}
	}
}
