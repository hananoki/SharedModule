/// UnityEditor.EditorGUILayout : 2019.3.10f1

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public static partial class UnityEditorGUILayout {
    delegate bool Method_FoldoutTitlebar0( bool foldout, UnityEngine.GUIContent label, bool skipIconSpacing );
    static Method_FoldoutTitlebar0 __FoldoutTitlebar0;
    public static bool FoldoutTitlebar( bool foldout, UnityEngine.GUIContent label, bool skipIconSpacing ) {
      if( __FoldoutTitlebar0 == null ) {
        __FoldoutTitlebar0 = (Method_FoldoutTitlebar0) Delegate.CreateDelegate( typeof( Method_FoldoutTitlebar0 ), null, R.Method( 3, "FoldoutTitlebar", "UnityEditor.EditorGUILayout", "UnityEditor.dll") );
      }
      return __FoldoutTitlebar0(  foldout, label, skipIconSpacing  );
    }

    delegate bool Method_FoldoutTitlebar1( bool foldout, UnityEngine.GUIContent label, bool skipIconSpacing, UnityEngine.GUIStyle baseStyle, UnityEngine.GUIStyle textStyle );
    static Method_FoldoutTitlebar1 __FoldoutTitlebar1;
    public static bool FoldoutTitlebar( bool foldout, UnityEngine.GUIContent label, bool skipIconSpacing, UnityEngine.GUIStyle baseStyle, UnityEngine.GUIStyle textStyle ) {
      if( __FoldoutTitlebar1 == null ) {
        __FoldoutTitlebar1 = (Method_FoldoutTitlebar1) Delegate.CreateDelegate( typeof( Method_FoldoutTitlebar1 ), null, R.Method( 5, "FoldoutTitlebar", "UnityEditor.EditorGUILayout", "UnityEditor.dll") );
      }
      return __FoldoutTitlebar1(  foldout, label, skipIconSpacing, baseStyle, textStyle  );
    }



    delegate bool Method_LinkLabel0( string label, params UnityEngine.GUILayoutOption[] options );
    static Method_LinkLabel0 __LinkLabel0;
    public static bool LinkLabel( string label, params UnityEngine.GUILayoutOption[] options ) {
      if( __LinkLabel0 == null ) {
        __LinkLabel0 = (Method_LinkLabel0) Delegate.CreateDelegate( typeof( Method_LinkLabel0 ), null, R.Method( 2, "LinkLabel", "UnityEditor.EditorGUILayout", "UnityEditor.dll") );
      }
      return __LinkLabel0(  label, options  );
    }

    delegate bool Method_LinkLabel1( UnityEngine.GUIContent label, params UnityEngine.GUILayoutOption[] options );
    static Method_LinkLabel1 __LinkLabel1;
    public static bool LinkLabel( UnityEngine.GUIContent label, params UnityEngine.GUILayoutOption[] options ) {
      if( __LinkLabel1 == null ) {
        __LinkLabel1 = (Method_LinkLabel1) Delegate.CreateDelegate( typeof( Method_LinkLabel1 ), null, R.Method( 2, "LinkLabel", "UnityEditor.EditorGUILayout", "UnityEditor.dll") );
      }
      return __LinkLabel1(  label, options  );
    }



    delegate float Method_PowerSlider0( string label, float value, float leftValue, float rightValue, float power, params UnityEngine.GUILayoutOption[] options );
    static Method_PowerSlider0 __PowerSlider0;
    public static float PowerSlider( string label, float value, float leftValue, float rightValue, float power, params UnityEngine.GUILayoutOption[] options ) {
      if( __PowerSlider0 == null ) {
        __PowerSlider0 = (Method_PowerSlider0) Delegate.CreateDelegate( typeof( Method_PowerSlider0 ), null, R.Method( 6, "PowerSlider", "UnityEditor.EditorGUILayout", "UnityEditor.dll") );
      }
      return __PowerSlider0(  label, value, leftValue, rightValue, power, options  );
    }

    delegate float Method_PowerSlider1( UnityEngine.GUIContent label, float value, float leftValue, float rightValue, float power, params UnityEngine.GUILayoutOption[] options );
    static Method_PowerSlider1 __PowerSlider1;
    public static float PowerSlider( UnityEngine.GUIContent label, float value, float leftValue, float rightValue, float power, params UnityEngine.GUILayoutOption[] options ) {
      if( __PowerSlider1 == null ) {
        __PowerSlider1 = (Method_PowerSlider1) Delegate.CreateDelegate( typeof( Method_PowerSlider1 ), null, R.Method( 6, "PowerSlider", "UnityEditor.EditorGUILayout", "UnityEditor.dll") );
      }
      return __PowerSlider1(  label, value, leftValue, rightValue, power, options  );
    }



    delegate bool Method_ToggleTitlebar0( bool foldout, UnityEngine.GUIContent label, ref bool toggleValue );
    static Method_ToggleTitlebar0 __ToggleTitlebar0;
    public static bool ToggleTitlebar( bool foldout, UnityEngine.GUIContent label, ref bool toggleValue ) {
      if( __ToggleTitlebar0 == null ) {
        __ToggleTitlebar0 = (Method_ToggleTitlebar0) Delegate.CreateDelegate( typeof( Method_ToggleTitlebar0 ), null, R.Method( 3, "ToggleTitlebar", "UnityEditor.EditorGUILayout", "UnityEditor.dll") );
      }
      return __ToggleTitlebar0(  foldout, label, ref toggleValue  );
    }

    delegate bool Method_ToggleTitlebar1( bool foldout, UnityEngine.GUIContent label, UnityEditor.SerializedProperty property );
    static Method_ToggleTitlebar1 __ToggleTitlebar1;
    public static bool ToggleTitlebar( bool foldout, UnityEngine.GUIContent label, UnityEditor.SerializedProperty property ) {
      if( __ToggleTitlebar1 == null ) {
        __ToggleTitlebar1 = (Method_ToggleTitlebar1) Delegate.CreateDelegate( typeof( Method_ToggleTitlebar1 ), null, R.Method( 3, "ToggleTitlebar", "UnityEditor.EditorGUILayout", "UnityEditor.dll") );
      }
      return __ToggleTitlebar1(  foldout, label, property  );
    }



    delegate string Method_ToolbarSearchField0( string text, params UnityEngine.GUILayoutOption[] options );
    static Method_ToolbarSearchField0 __ToolbarSearchField0;
    public static string ToolbarSearchField( string text, params UnityEngine.GUILayoutOption[] options ) {
      if( __ToolbarSearchField0 == null ) {
        __ToolbarSearchField0 = (Method_ToolbarSearchField0) Delegate.CreateDelegate( typeof( Method_ToolbarSearchField0 ), null, R.Method( 2, "ToolbarSearchField", "UnityEditor.EditorGUILayout", "UnityEditor.dll") );
      }
      return __ToolbarSearchField0(  text, options  );
    }

    delegate string Method_ToolbarSearchField1( string text, string[] searchModes, ref int searchMode, params UnityEngine.GUILayoutOption[] options );
    static Method_ToolbarSearchField1 __ToolbarSearchField1;
    public static string ToolbarSearchField( string text, string[] searchModes, ref int searchMode, params UnityEngine.GUILayoutOption[] options ) {
      if( __ToolbarSearchField1 == null ) {
        __ToolbarSearchField1 = (Method_ToolbarSearchField1) Delegate.CreateDelegate( typeof( Method_ToolbarSearchField1 ), null, R.Method( 4, "ToolbarSearchField", "UnityEditor.EditorGUILayout", "UnityEditor.dll") );
      }
      return __ToolbarSearchField1(  text, searchModes, ref searchMode, options  );
    }





	}
}

#endif

