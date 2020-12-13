
using System.Runtime.CompilerServices;
using System;
using UnityEditor;
using UnityEngine;

namespace HananokiEditor {
	public static class ScopeHorizontal {
		public static void Begin( params GUILayoutOption[] options ) => GUILayout.BeginHorizontal( options );
		public static void Begin( GUIStyle style, params GUILayoutOption[] options ) => GUILayout.BeginHorizontal( style, options );
		public static void End() => GUILayout.EndHorizontal();
	}
	public static class ScopeVertical {
		public static void Begin( params GUILayoutOption[] options ) => GUILayout.BeginVertical( options );
		public static void Begin( GUIStyle style, params GUILayoutOption[] options ) => GUILayout.BeginVertical( style, options );
		public static void End() => GUILayout.EndVertical();
	}
	public static class ScopeDisable {
		public static void Begin( bool disabled ) => EditorGUI.BeginDisabledGroup( disabled );
		public static void BeginIsCompiling() => EditorGUI.BeginDisabledGroup( EditorApplication.isCompiling );
		public static void End() => EditorGUI.EndDisabledGroup();
	}
	public static class ScopeIsCompile {
		public static void Begin( bool disabled ) => EditorGUI.BeginDisabledGroup( disabled );
		public static void End() => EditorGUI.EndDisabledGroup();
	}
	public static class ScopeChange {
		public static void Begin() => EditorGUI.BeginChangeCheck();
		public static bool End() => EditorGUI.EndChangeCheck();
	}
	public class GUILayoutScope : GUI.Scope {
		float _right;
		public GUILayoutScope( float left = 8, float right = 8 ) {
			GUILayout.BeginHorizontal();
			if( 0 < left ) GUILayout.Space( left );
			GUILayout.BeginVertical();
			_right = right;
		}
		protected override void CloseScope() {
			GUILayout.EndVertical();
			if( 0 < _right ) GUILayout.Space( _right );
			GUILayout.EndHorizontal();
		}
	}



	public static class HGUIScope {

		static int[] stack = new int[ 16 ];
		static int stackInd;

		public static void Reset() {
			stackInd = 0;
		}
		//public static void SafePop() {
		//	while( 0 < stackInd ) {
		//		End();
		//	}
		//}

		[Obsolete( "Horizontal -> ScopeHorizontal.Begin" )]
		public static void Horizontal( params GUILayoutOption[] options ) {
			Horizontal( GUIStyle.none, options );
		}
		[Obsolete( "Horizontal -> ScopeHorizontal.Begin" )]
		public static void Horizontal( GUIStyle style, params GUILayoutOption[] options ) {
			stack[ stackInd ] = 0;
			stackInd++;
			GUILayout.BeginHorizontal( style, options );
		}

		[Obsolete( "Vertical -> ScopeVertical.Begin" )]
		public static void Vertical( params GUILayoutOption[] options ) {
			Vertical( GUIStyle.none, options );
		}
		[Obsolete( "Vertical -> ScopeVertical.Begin" )]
		public static void Vertical( GUIStyle style, params GUILayoutOption[] options ) {
			stack[ stackInd ] = 1;
			stackInd++;
			GUILayout.BeginVertical( style, options );
		}

		[Obsolete( "Change -> ScopeChange.Begin" )]
		public static void Change() {
			stack[ stackInd ] = 2;
			stackInd++;
			EditorGUI.BeginChangeCheck();
		}

		[Obsolete( "Disable -> ScopeDisable.Begin" )]
		public static void Disable( bool disabled ) {
			stack[ stackInd ] = 3;
			stackInd++;
			EditorGUI.BeginDisabledGroup( disabled );
		}

		

		static float _right;
		[Obsolete( "Layout -> using( new GUILayoutScope() )" )]
		public static void Layout( float left = 8, float right = 8 ) {
			stack[ stackInd ] = 4;
			stackInd++;
			GUILayout.BeginHorizontal();
			if( 0 < left ) GUILayout.Space( left );
			GUILayout.BeginVertical();
			_right = right;
		}

		[Obsolete( "ScopeHorizontal, ScopeVertical, ScopeDisable, ScopeChange" )]
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
