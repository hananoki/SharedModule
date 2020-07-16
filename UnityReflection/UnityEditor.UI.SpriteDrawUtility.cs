/// UnityEditor.UI.SpriteDrawUtility : 2019.3.0f6

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public static partial class UnityUISpriteDrawUtility {
    delegate void Method_DrawSprite0( UnityEngine.Sprite sprite, UnityEngine.Rect drawArea, UnityEngine.Color color );
    static Method_DrawSprite0 __DrawSprite0;
    public static void DrawSprite( UnityEngine.Sprite sprite, UnityEngine.Rect drawArea, UnityEngine.Color color ) {
      if( __DrawSprite0 == null ) {
        __DrawSprite0 = (Method_DrawSprite0) Delegate.CreateDelegate( typeof( Method_DrawSprite0 ), null, R.Method( 3, "DrawSprite", "UnityEditor.UI.SpriteDrawUtility", "UnityEditor.UI") );
      }
      __DrawSprite0(  sprite, drawArea, color  );
    }

    delegate void Method_DrawSprite1( UnityEngine.Texture tex, UnityEngine.Rect drawArea, UnityEngine.Rect outer, UnityEngine.Rect uv, UnityEngine.Color color );
    static Method_DrawSprite1 __DrawSprite1;
    public static void DrawSprite( UnityEngine.Texture tex, UnityEngine.Rect drawArea, UnityEngine.Rect outer, UnityEngine.Rect uv, UnityEngine.Color color ) {
      if( __DrawSprite1 == null ) {
        __DrawSprite1 = (Method_DrawSprite1) Delegate.CreateDelegate( typeof( Method_DrawSprite1 ), null, R.Method( 5, "DrawSprite", "UnityEditor.UI.SpriteDrawUtility", "UnityEditor.UI") );
      }
      __DrawSprite1(  tex, drawArea, outer, uv, color  );
    }

    delegate void Method_DrawSprite2( UnityEngine.Texture tex, UnityEngine.Rect drawArea, UnityEngine.Vector4 padding, UnityEngine.Rect outer, UnityEngine.Rect inner, UnityEngine.Rect uv, UnityEngine.Color color, UnityEngine.Material mat );
    static Method_DrawSprite2 __DrawSprite2;
    public static void DrawSprite( UnityEngine.Texture tex, UnityEngine.Rect drawArea, UnityEngine.Vector4 padding, UnityEngine.Rect outer, UnityEngine.Rect inner, UnityEngine.Rect uv, UnityEngine.Color color, UnityEngine.Material mat ) {
      if( __DrawSprite2 == null ) {
        __DrawSprite2 = (Method_DrawSprite2) Delegate.CreateDelegate( typeof( Method_DrawSprite2 ), null, R.Method( 8, "DrawSprite", "UnityEditor.UI.SpriteDrawUtility", "UnityEditor.UI") );
      }
      __DrawSprite2(  tex, drawArea, padding, outer, inner, uv, color, mat  );
    }



	}
}

#endif

