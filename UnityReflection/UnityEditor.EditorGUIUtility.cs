/// UnityEditor.EditorGUIUtility : 2019.4.5f1

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public static partial class UnityEditorGUIUtility {
    delegate UnityEngine.GUIContent Method_TrTextContent0( string key, string text, string tooltip, UnityEngine.Texture icon );
    static Method_TrTextContent0 __TrTextContent0;
    public static UnityEngine.GUIContent TrTextContent( string key, string text, string tooltip, UnityEngine.Texture icon ) {
      if( __TrTextContent0 == null ) {
        __TrTextContent0 = (Method_TrTextContent0) Delegate.CreateDelegate( typeof( Method_TrTextContent0 ), null, R.Method( 4, "TrTextContent", "UnityEditor.EditorGUIUtility", "UnityEditor.dll") );
      }
      return __TrTextContent0(  key, text, tooltip, icon  );
    }

    delegate UnityEngine.GUIContent Method_TrTextContent1( string text, string tooltip = null, UnityEngine.Texture icon = null );
    static Method_TrTextContent1 __TrTextContent1;
    public static UnityEngine.GUIContent TrTextContent( string text, string tooltip = null, UnityEngine.Texture icon = null ) {
      if( __TrTextContent1 == null ) {
        __TrTextContent1 = (Method_TrTextContent1) Delegate.CreateDelegate( typeof( Method_TrTextContent1 ), null, R.Method( 3, "TrTextContent", "UnityEditor.EditorGUIUtility", "UnityEditor.dll") );
      }
      return __TrTextContent1(  text, tooltip, icon  );
    }

    delegate UnityEngine.GUIContent Method_TrTextContent2( string text, string tooltip, string iconName );
    static Method_TrTextContent2 __TrTextContent2;
    public static UnityEngine.GUIContent TrTextContent( string text, string tooltip, string iconName ) {
      if( __TrTextContent2 == null ) {
        __TrTextContent2 = (Method_TrTextContent2) Delegate.CreateDelegate( typeof( Method_TrTextContent2 ), null, R.Method( 3, "TrTextContent", "UnityEditor.EditorGUIUtility", "UnityEditor.dll") );
      }
      return __TrTextContent2(  text, tooltip, iconName  );
    }

    delegate UnityEngine.GUIContent Method_TrTextContent3( string text, UnityEngine.Texture icon );
    static Method_TrTextContent3 __TrTextContent3;
    public static UnityEngine.GUIContent TrTextContent( string text, UnityEngine.Texture icon ) {
      if( __TrTextContent3 == null ) {
        __TrTextContent3 = (Method_TrTextContent3) Delegate.CreateDelegate( typeof( Method_TrTextContent3 ), null, R.Method( 2, "TrTextContent", "UnityEditor.EditorGUIUtility", "UnityEditor.dll") );
      }
      return __TrTextContent3(  text, icon  );
    }



    delegate UnityEngine.GUIContent Method_TextContent0( string textAndTooltip );
    static Method_TextContent0 __TextContent0;
    public static UnityEngine.GUIContent TextContent( string textAndTooltip ) {
      if( __TextContent0 == null ) {
        __TextContent0 = (Method_TextContent0) Delegate.CreateDelegate( typeof( Method_TextContent0 ), null, R.Method("TextContent", "UnityEditor.EditorGUIUtility", "UnityEditor.dll") );
      }
      return __TextContent0(  textAndTooltip  );
    }



    delegate UnityEngine.Texture2D Method_LoadIcon0( string name );
    static Method_LoadIcon0 __LoadIcon0;
    public static UnityEngine.Texture2D LoadIcon( string name ) {
      if( __LoadIcon0 == null ) {
        __LoadIcon0 = (Method_LoadIcon0) Delegate.CreateDelegate( typeof( Method_LoadIcon0 ), null, R.Method("LoadIcon", "UnityEditor.EditorGUIUtility", "UnityEditor.dll") );
      }
      return __LoadIcon0(  name  );
    }



    delegate UnityEngine.AssetBundle Method_GetEditorAssetBundle0();
    static Method_GetEditorAssetBundle0 __GetEditorAssetBundle0;
    public static UnityEngine.AssetBundle GetEditorAssetBundle() {
      if( __GetEditorAssetBundle0 == null ) {
        __GetEditorAssetBundle0 = (Method_GetEditorAssetBundle0) Delegate.CreateDelegate( typeof( Method_GetEditorAssetBundle0 ), null, R.Method("GetEditorAssetBundle", "UnityEditor.EditorGUIUtility", "UnityEditor.dll") );
      }
      return __GetEditorAssetBundle0(  );
    }



    delegate UnityEngine.Color Method_GetDefaultBackgroundColor0();
    static Method_GetDefaultBackgroundColor0 __GetDefaultBackgroundColor0;
    public static UnityEngine.Color GetDefaultBackgroundColor() {
      if( __GetDefaultBackgroundColor0 == null ) {
        __GetDefaultBackgroundColor0 = (Method_GetDefaultBackgroundColor0) Delegate.CreateDelegate( typeof( Method_GetDefaultBackgroundColor0 ), null, R.Method("GetDefaultBackgroundColor", "UnityEditor.EditorGUIUtility", "UnityEditor.dll") );
      }
      return __GetDefaultBackgroundColor0(  );
    }



	}
}

#endif

