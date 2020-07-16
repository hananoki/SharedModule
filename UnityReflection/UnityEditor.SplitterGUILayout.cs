/// UnityEditor.SplitterGUILayout : 2019.3.0f6

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public static class UnitySplitterGUILayout {
    public static void BeginHorizontalSplit ( UnitySplitterState state, params UnityEngine.GUILayoutOption[] options ) {
		R.Method( 2, "BeginHorizontalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll" ).Invoke( null, new object[] {  state.GetInstance(), options  } );
	}

    public static void BeginHorizontalSplit ( UnitySplitterState state, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options ) {
		R.Method( 3, "BeginHorizontalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll" ).Invoke( null, new object[] {  state.GetInstance(), style, options  } );
	}



    delegate void Method_EndHorizontalSplit0();
    static Method_EndHorizontalSplit0 __EndHorizontalSplit0;
    public static void EndHorizontalSplit() {
      if( __EndHorizontalSplit0 == null ) {
        __EndHorizontalSplit0 = (Method_EndHorizontalSplit0) Delegate.CreateDelegate( typeof( Method_EndHorizontalSplit0 ), null, R.Method("EndHorizontalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll") );
      }
      __EndHorizontalSplit0(  );
    }



    public static void BeginVerticalSplit ( UnitySplitterState state, params UnityEngine.GUILayoutOption[] options ) {
		R.Method( 2, "BeginVerticalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll" ).Invoke( null, new object[] {  state.GetInstance(), options  } );
	}

    public static void BeginVerticalSplit ( UnitySplitterState state, UnityEngine.GUIStyle style, params UnityEngine.GUILayoutOption[] options ) {
		R.Method( 3, "BeginVerticalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll" ).Invoke( null, new object[] {  state.GetInstance(), style, options  } );
	}



    delegate void Method_EndVerticalSplit0();
    static Method_EndVerticalSplit0 __EndVerticalSplit0;
    public static void EndVerticalSplit() {
      if( __EndVerticalSplit0 == null ) {
        __EndVerticalSplit0 = (Method_EndVerticalSplit0) Delegate.CreateDelegate( typeof( Method_EndVerticalSplit0 ), null, R.Method("EndVerticalSplit", "UnityEditor.SplitterGUILayout", "UnityEditor.dll") );
      }
      __EndVerticalSplit0(  );
    }



	}
}

#endif

