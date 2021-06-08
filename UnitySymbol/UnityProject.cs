using UnityEditor;

namespace HananokiEditor {
	public static class UnityProject {

		static int s_urpFlag = -1;
		static int s_hdrpFlag = -1;
		static string[] s_packageGUID = { "6f8f5c087a5cb4bd19c1e4898d57e453", "d5ac453c34e359d439de9d724772ed3d" };
		static int[] s_packageFlag = new int[ s_packageGUID.Length ];


		public static bool URP {
			get {
				if( s_urpFlag < 0 ) {
					s_urpFlag = 0;
					foreach( var s in Unsupported.GetSubmenus( "Assets" ) ) {
						//Debug.Log( s );
						if( s.Contains( "Assets/Create/Rendering/Universal Render Pipeline" ) ) {
							s_urpFlag = 1;
							break;
						}
					}
				}
				return s_urpFlag == 0 ? false : true;
			}
		}
		public static bool HDRP {
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

		public static bool check( ref int index, string GUID ) {
			if( index == 0 ) {
				index = -1;
				var path = AssetDatabase.GUIDToAssetPath( GUID );
				if( !string.IsNullOrEmpty( path ) ) index = 1;
			}
			return 0 < index ? true : false;
		}

		public static bool VFX => check( ref s_packageFlag[ 0 ], s_packageGUID[ 0 ] );
		public static bool ShaderGraph => check( ref s_packageFlag[ 1 ], s_packageGUID[ 1 ] );

	}
}
