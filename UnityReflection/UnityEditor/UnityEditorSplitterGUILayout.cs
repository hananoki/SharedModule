/// UnityEditor.SplitterGUILayout : 2019.3.0f6

#if UNITY_EDITOR

using HananokiEditor;
//using Hananoki.Reflection;
using System;
using System.Reflection;

namespace UnityReflection {
	public static class UnityEditorSplitterGUILayout {
		public static class R {
			public const BindingFlags StaticMembers = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
			public const BindingFlags InstanceMembers = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
			public const BindingFlags AllMembers = StaticMembers | InstanceMembers;
		}

		static MethodInfo _BeginHorizontalSplit1;

		public static void BeginHorizontalSplit( UnityEditorSplitterState state, params UnityEngine.GUILayoutOption[] options ) {
			if( _BeginHorizontalSplit1 == null ) {
				_BeginHorizontalSplit1 = UnityTypes.UnityEditor_SplitterGUILayout.GetMethod( "BeginHorizontalSplit", R.AllMembers, null, new Type[] { UnityTypes.UnityEditor_SplitterState, typeof( UnityEngine.GUILayoutOption[] ) }, null );
			}
			//R.Method( 2, "BeginHorizontalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll" ).Invoke( null, new object[] { state.GetInstance(), options } );
			_BeginHorizontalSplit1.Invoke( null, new object[] { state.m_instance, options } );
		}

		//public static void BeginHorizontalSplit( UnitySplitterState state, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options ) {
		//	R.Method( 3, "BeginHorizontalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll" ).Invoke( null, new object[] { state.GetInstance(), style, options } );
		//}



		delegate void Method_EndHorizontalSplit0();
		static Method_EndHorizontalSplit0 __EndHorizontalSplit0;
		public static void EndHorizontalSplit() {
			if( __EndHorizontalSplit0 == null ) {
				__EndHorizontalSplit0 = (Method_EndHorizontalSplit0) Delegate.CreateDelegate( typeof( Method_EndHorizontalSplit0 ), null, UnityTypes.UnityEditor_SplitterGUILayout.GetMethod( "EndHorizontalSplit", R.AllMembers ) );
			}
			__EndHorizontalSplit0();
		}



		//public static void BeginVerticalSplit( UnitySplitterState state, params UnityEngine.GUILayoutOption[] options ) {
		//	R.Method( 2, "BeginVerticalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll" ).Invoke( null, new object[] { state.GetInstance(), options } );
		//}

		//public static void BeginVerticalSplit( UnitySplitterState state, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options ) {
		//	R.Method( 3, "BeginVerticalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll" ).Invoke( null, new object[] { state.GetInstance(), style, options } );
		//}



		//delegate void Method_EndVerticalSplit0();
		//static Method_EndVerticalSplit0 __EndVerticalSplit0;
		//public static void EndVerticalSplit() {
		//	if( __EndVerticalSplit0 == null ) {
		//		__EndVerticalSplit0 = (Method_EndVerticalSplit0) Delegate.CreateDelegate( typeof( Method_EndVerticalSplit0 ), null, R.Method( "EndVerticalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll" ) );
		//	}
		//	__EndVerticalSplit0();
		//}



	}
}

#endif

