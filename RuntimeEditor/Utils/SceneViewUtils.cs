#if UNITY_EDITOR
#pragma warning disable 618


using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System;

namespace Hananoki {
	public static class SceneViewUtils {
		static Dictionary<SceneView.OnSceneFunc, Action<SceneView>> s_func = new Dictionary<SceneView.OnSceneFunc, Action<SceneView>>();

		public static void AddGUI( SceneView.OnSceneFunc func ) {
			if( UnitySymbol.Has( "UNITY_2019_1_OR_NEWER" ) ) {
				if( !s_func.ContainsKey( func ) ) {
					var t = typeof( SceneView );
					var ev = t.GetEvent( "duringSceneGui" );
					Action<SceneView> a = ( ss ) => { func( ss ); };
					ev.AddEventHandler( null, a );
					s_func.Add( func, a );
				}
			}
			else {
				SceneView.onSceneGUIDelegate += func;
			}
			Repaint();
		}


		public static void RemoveGUI( SceneView.OnSceneFunc func ) {
			if( UnitySymbol.Has( "UNITY_2019_1_OR_NEWER" ) ) {
				if( s_func.ContainsKey( func ) ) {
					var t = typeof( SceneView );
					var ev = t.GetEvent( "duringSceneGui" );
					ev.RemoveEventHandler( null, s_func[ func ] );
					s_func.Remove( func );
				}
			}
			else {
				SceneView.onSceneGUIDelegate -= func;
			}
			Repaint();
		}


		public static void SetPivot( Vector3 a ) {
			if( SceneView.lastActiveSceneView == null ) return;
			SceneView.lastActiveSceneView.pivot = a;
		}

		public static int sceneViewNum => SceneView.sceneViews.Count;



		public static void Repaint() {
			try {
				foreach( SceneView p in SceneView.sceneViews ) p.Repaint();
			}
			catch( Exception ) {
			}
		}
	}
}

#endif
