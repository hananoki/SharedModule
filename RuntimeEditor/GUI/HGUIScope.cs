
using System.Runtime.CompilerServices;
using System;
using UnityEditor;
using UnityEngine;

namespace Hananoki {
	public static class HGUIScope {

		static int[] stack = new int[ 16 ];
		static int stackInd;

		public static void Reset() {
			stackInd = 0;
		}
		public static void SafePop() {
			while( 0 < stackInd ) {
				End();
			}
		}

		public static void Horizontal( params GUILayoutOption[] options ) {
			Horizontal( GUIStyle.none, options );
		}
		public static void Horizontal( GUIStyle style, params GUILayoutOption[] options ) {
			stack[ stackInd ] = 0;
			stackInd++;
			GUILayout.BeginHorizontal( style, options );
		}

		public static void Vertical( params GUILayoutOption[] options ) {
			Vertical( GUIStyle.none, options );
		}
		public static void Vertical( GUIStyle style, params GUILayoutOption[] options ) {
			stack[ stackInd ] = 1;
			stackInd++;
			GUILayout.BeginVertical( style, options );
		}

		public static void Change() {
			stack[ stackInd ] = 2;
			stackInd++;
			EditorGUI.BeginChangeCheck();
		}

		public static void Disable( bool disabled ) {
			stack[ stackInd ] = 3;
			stackInd++;
			EditorGUI.BeginDisabledGroup( disabled );
		}

		static float _right;
		public static void Layout( float left = 8, float right = 8 ) {
			stack[ stackInd ] = 4;
			stackInd++;
			GUILayout.BeginHorizontal();
			if( 0 < left ) GUILayout.Space( left );
			GUILayout.BeginVertical();
			_right = right;
		}


		public static bool End() {
			bool result = false;
			stackInd--;
			switch( stack[ stackInd ] ) {
			case 0:
				GUILayout.EndHorizontal();
				break;
			case 1:
				GUILayout.EndVertical();
				break;
			case 2:
				result = EditorGUI.EndChangeCheck();
				break;
			case 3:
				EditorGUI.EndDisabledGroup();
				break;
			case 4:
				GUILayout.EndVertical();
				if( 0 < _right ) GUILayout.Space( _right );
				GUILayout.EndHorizontal();
				break;
			}
			return result;
		}

	}
}
