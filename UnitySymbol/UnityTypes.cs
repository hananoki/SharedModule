using System;

namespace HananokiEditor {

	public static partial class UnityTypes {

		static Type Get( string typeFullName, string assemblyName ) {
			return Type.GetType( $"{typeFullName}, {assemblyName}, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
		}

		static Type Get( ref Type t, string typeFullName, string assemblyName ) {
			if( t == null ) {
				//UnityEngine.Debug.Log( typeFullName );
				t = Get( typeFullName, assemblyName );
			}
			return t;
		}

		static Type[] s_generalEditorWindowTypes;
		public static Type[] generalEditorWindowTypes {
			get {
				if( s_generalEditorWindowTypes == null ) {
					s_generalEditorWindowTypes = new Type[] {
						UnityEditor_SceneView,
						UnityEditor_GameView,
						UnityEditor_InspectorWindow,
						UnityEditor_SceneHierarchyWindow,
						UnityEditor_ProjectBrowser,
						UnityEditor_ConsoleWindow
						};
				}
				return s_generalEditorWindowTypes;
			}
		}
	}
}
