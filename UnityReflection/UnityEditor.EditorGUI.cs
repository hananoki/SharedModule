/// UnityEditor.EditorGUI : 2019.4.0f1

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public static partial class UnityEditorGUI {
    delegate string Method_ToolbarSearchField0( UnityEngine.Rect position, string text, bool showWithPopupArrow );
    static Method_ToolbarSearchField0 __ToolbarSearchField0;
    public static string ToolbarSearchField( UnityEngine.Rect position, string text, bool showWithPopupArrow ) {
      if( __ToolbarSearchField0 == null ) {
        __ToolbarSearchField0 = (Method_ToolbarSearchField0) Delegate.CreateDelegate( typeof( Method_ToolbarSearchField0 ), null, R.Method( 3, "ToolbarSearchField", "UnityEditor.EditorGUI", "UnityEditor.dll") );
      }
      return __ToolbarSearchField0(  position, text, showWithPopupArrow  );
    }

    delegate string Method_ToolbarSearchField1( int id, UnityEngine.Rect position, string text, bool showWithPopupArrow );
    static Method_ToolbarSearchField1 __ToolbarSearchField1;
    public static string ToolbarSearchField( int id, UnityEngine.Rect position, string text, bool showWithPopupArrow ) {
      if( __ToolbarSearchField1 == null ) {
        __ToolbarSearchField1 = (Method_ToolbarSearchField1) Delegate.CreateDelegate( typeof( Method_ToolbarSearchField1 ), null, R.Method( 4, "ToolbarSearchField", "UnityEditor.EditorGUI", "UnityEditor.dll") );
      }
      return __ToolbarSearchField1(  id, position, text, showWithPopupArrow  );
    }

    delegate string Method_ToolbarSearchField2( UnityEngine.Rect position, string[] searchModes, ref int searchMode, string text );
    static Method_ToolbarSearchField2 __ToolbarSearchField2;
    public static string ToolbarSearchField( UnityEngine.Rect position, string[] searchModes, ref int searchMode, string text ) {
      if( __ToolbarSearchField2 == null ) {
        __ToolbarSearchField2 = (Method_ToolbarSearchField2) Delegate.CreateDelegate( typeof( Method_ToolbarSearchField2 ), null, R.Method( 4, "ToolbarSearchField", "UnityEditor.EditorGUI", "UnityEditor.dll") );
      }
      return __ToolbarSearchField2(  position, searchModes, ref searchMode, text  );
    }

    delegate string Method_ToolbarSearchField3( int id, UnityEngine.Rect position, string[] searchModes, ref int searchMode, string text );
    static Method_ToolbarSearchField3 __ToolbarSearchField3;
    public static string ToolbarSearchField( int id, UnityEngine.Rect position, string[] searchModes, ref int searchMode, string text ) {
      if( __ToolbarSearchField3 == null ) {
        __ToolbarSearchField3 = (Method_ToolbarSearchField3) Delegate.CreateDelegate( typeof( Method_ToolbarSearchField3 ), null, R.Method( 5, "ToolbarSearchField", "UnityEditor.EditorGUI", "UnityEditor.dll") );
      }
      return __ToolbarSearchField3(  id, position, searchModes, ref searchMode, text  );
    }



    delegate void Method_PingObjectOrShowPreviewOnClick0( UnityEngine.Object targetObject, UnityEngine.Rect position );
    static Method_PingObjectOrShowPreviewOnClick0 __PingObjectOrShowPreviewOnClick0;
    public static void PingObjectOrShowPreviewOnClick( UnityEngine.Object targetObject, UnityEngine.Rect position ) {
      if( __PingObjectOrShowPreviewOnClick0 == null ) {
        __PingObjectOrShowPreviewOnClick0 = (Method_PingObjectOrShowPreviewOnClick0) Delegate.CreateDelegate( typeof( Method_PingObjectOrShowPreviewOnClick0 ), null, R.Method("PingObjectOrShowPreviewOnClick", "UnityEditor.EditorGUI", "UnityEditor.dll") );
      }
      __PingObjectOrShowPreviewOnClick0(  targetObject, position  );
    }



    delegate bool Method_FoldoutTitlebar0( UnityEngine.Rect position, UnityEngine.GUIContent label, bool foldout, bool skipIconSpacing );
    static Method_FoldoutTitlebar0 __FoldoutTitlebar0;
    public static bool FoldoutTitlebar( UnityEngine.Rect position, UnityEngine.GUIContent label, bool foldout, bool skipIconSpacing ) {
      if( __FoldoutTitlebar0 == null ) {
        __FoldoutTitlebar0 = (Method_FoldoutTitlebar0) Delegate.CreateDelegate( typeof( Method_FoldoutTitlebar0 ), null, R.Method( 4, "FoldoutTitlebar", "UnityEditor.EditorGUI", "UnityEditor.dll") );
      }
      return __FoldoutTitlebar0(  position, label, foldout, skipIconSpacing  );
    }

    delegate bool Method_FoldoutTitlebar1( UnityEngine.Rect position, UnityEngine.GUIContent label, bool foldout, bool skipIconSpacing, UnityEngine.GUIStyle baseStyle, UnityEngine.GUIStyle textStyle );
    static Method_FoldoutTitlebar1 __FoldoutTitlebar1;
    public static bool FoldoutTitlebar( UnityEngine.Rect position, UnityEngine.GUIContent label, bool foldout, bool skipIconSpacing, UnityEngine.GUIStyle baseStyle, UnityEngine.GUIStyle textStyle ) {
      if( __FoldoutTitlebar1 == null ) {
        __FoldoutTitlebar1 = (Method_FoldoutTitlebar1) Delegate.CreateDelegate( typeof( Method_FoldoutTitlebar1 ), null, R.Method( 6, "FoldoutTitlebar", "UnityEditor.EditorGUI", "UnityEditor.dll") );
      }
      return __FoldoutTitlebar1(  position, label, foldout, skipIconSpacing, baseStyle, textStyle  );
    }



	}
}

#endif

