/// UnityEditor.RectTransformEditor : 2019.4.5f1

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public static partial class UnityRectTransformEditor {
    delegate void Method_SetAnchorSmart0( UnityEngine.RectTransform rect, float value, int axis, bool isMax, bool smart );
    static Method_SetAnchorSmart0 __SetAnchorSmart0;
    public static void SetAnchorSmart( UnityEngine.RectTransform rect, float value, int axis, bool isMax, bool smart ) {
      if( __SetAnchorSmart0 == null ) {
        __SetAnchorSmart0 = (Method_SetAnchorSmart0) Delegate.CreateDelegate( typeof( Method_SetAnchorSmart0 ), null, R.Method( 5, "SetAnchorSmart", "UnityEditor.RectTransformEditor", "UnityEditor.dll") );
      }
      __SetAnchorSmart0(  rect, value, axis, isMax, smart  );
    }

    delegate void Method_SetAnchorSmart1( UnityEngine.RectTransform rect, float value, int axis, bool isMax, bool smart, bool enforceExactValue );
    static Method_SetAnchorSmart1 __SetAnchorSmart1;
    public static void SetAnchorSmart( UnityEngine.RectTransform rect, float value, int axis, bool isMax, bool smart, bool enforceExactValue ) {
      if( __SetAnchorSmart1 == null ) {
        __SetAnchorSmart1 = (Method_SetAnchorSmart1) Delegate.CreateDelegate( typeof( Method_SetAnchorSmart1 ), null, R.Method( 6, "SetAnchorSmart", "UnityEditor.RectTransformEditor", "UnityEditor.dll") );
      }
      __SetAnchorSmart1(  rect, value, axis, isMax, smart, enforceExactValue  );
    }

    delegate void Method_SetAnchorSmart2( UnityEngine.RectTransform rect, float value, int axis, bool isMax, bool smart, bool enforceExactValue, bool enforceMinNoLargerThanMax, bool moveTogether );
    static Method_SetAnchorSmart2 __SetAnchorSmart2;
    public static void SetAnchorSmart( UnityEngine.RectTransform rect, float value, int axis, bool isMax, bool smart, bool enforceExactValue, bool enforceMinNoLargerThanMax, bool moveTogether ) {
      if( __SetAnchorSmart2 == null ) {
        __SetAnchorSmart2 = (Method_SetAnchorSmart2) Delegate.CreateDelegate( typeof( Method_SetAnchorSmart2 ), null, R.Method( 8, "SetAnchorSmart", "UnityEditor.RectTransformEditor", "UnityEditor.dll") );
      }
      __SetAnchorSmart2(  rect, value, axis, isMax, smart, enforceExactValue, enforceMinNoLargerThanMax, moveTogether  );
    }



    delegate void Method_SetPivotSmart0( UnityEngine.RectTransform rect, float value, int axis, bool smart, bool parentSpace );
    static Method_SetPivotSmart0 __SetPivotSmart0;
    public static void SetPivotSmart( UnityEngine.RectTransform rect, float value, int axis, bool smart, bool parentSpace ) {
      if( __SetPivotSmart0 == null ) {
        __SetPivotSmart0 = (Method_SetPivotSmart0) Delegate.CreateDelegate( typeof( Method_SetPivotSmart0 ), null, R.Method("SetPivotSmart", "UnityEditor.RectTransformEditor", "UnityEditor.dll") );
      }
      __SetPivotSmart0(  rect, value, axis, smart, parentSpace  );
    }



	}
}

#endif

