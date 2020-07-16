/// UnityEditor.GameObjectInspector : 2019.3.0f6

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public class UnityGameObjectInspector {
    public object m_instance;
    public object GetInstance() { return m_instance; }

    public UnityGameObjectInspector( UnityEngine.Object targetObject ) {
      m_instance = UnityEditor.Editor.CreateEditor( targetObject, R.Type("UnityEditor.GameObjectInspector", "UnityEditor.dll") );
    }


    delegate void Method_DoLayerField0( UnityEngine.GameObject go );
    Method_DoLayerField0 __DoLayerField0;
    public void DoLayerField( UnityEngine.GameObject go ) {
      if( __DoLayerField0 == null ) {
        __DoLayerField0 = (Method_DoLayerField0) Delegate.CreateDelegate( typeof( Method_DoLayerField0 ), m_instance, R.Method("DoLayerField", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      __DoLayerField0(  go  );
    }



    delegate void Method_DoTagsField0( UnityEngine.GameObject go );
    Method_DoTagsField0 __DoTagsField0;
    public void DoTagsField( UnityEngine.GameObject go ) {
      if( __DoTagsField0 == null ) {
        __DoTagsField0 = (Method_DoTagsField0) Delegate.CreateDelegate( typeof( Method_DoTagsField0 ), m_instance, R.Method("DoTagsField", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      __DoTagsField0(  go  );
    }



    delegate void Method_DoStaticToggleField0( UnityEngine.GameObject go );
    Method_DoStaticToggleField0 __DoStaticToggleField0;
    public void DoStaticToggleField( UnityEngine.GameObject go ) {
      if( __DoStaticToggleField0 == null ) {
        __DoStaticToggleField0 = (Method_DoStaticToggleField0) Delegate.CreateDelegate( typeof( Method_DoStaticToggleField0 ), m_instance, R.Method("DoStaticToggleField", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      __DoStaticToggleField0(  go  );
    }



    delegate void Method_DoStaticFlagsDropDown0( UnityEngine.GameObject go );
    Method_DoStaticFlagsDropDown0 __DoStaticFlagsDropDown0;
    public void DoStaticFlagsDropDown( UnityEngine.GameObject go ) {
      if( __DoStaticFlagsDropDown0 == null ) {
        __DoStaticFlagsDropDown0 = (Method_DoStaticFlagsDropDown0) Delegate.CreateDelegate( typeof( Method_DoStaticFlagsDropDown0 ), m_instance, R.Method("DoStaticFlagsDropDown", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      __DoStaticFlagsDropDown0(  go  );
    }



    delegate void Method_DoPrefabButtons0();
    Method_DoPrefabButtons0 __DoPrefabButtons0;
    public void DoPrefabButtons() {
      if( __DoPrefabButtons0 == null ) {
        __DoPrefabButtons0 = (Method_DoPrefabButtons0) Delegate.CreateDelegate( typeof( Method_DoPrefabButtons0 ), m_instance, R.Method("DoPrefabButtons", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      __DoPrefabButtons0(  );
    }



    delegate bool Method_HasPreviewGUI0();
    Method_HasPreviewGUI0 __HasPreviewGUI0;
    public bool HasPreviewGUI() {
      if( __HasPreviewGUI0 == null ) {
        __HasPreviewGUI0 = (Method_HasPreviewGUI0) Delegate.CreateDelegate( typeof( Method_HasPreviewGUI0 ), m_instance, R.Method("HasPreviewGUI", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      return __HasPreviewGUI0(  );
    }



    delegate void Method_OnEnable0();
    Method_OnEnable0 __OnEnable0;
    public void OnEnable() {
      if( __OnEnable0 == null ) {
        __OnEnable0 = (Method_OnEnable0) Delegate.CreateDelegate( typeof( Method_OnEnable0 ), m_instance, R.Method("OnEnable", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      __OnEnable0(  );
    }



    delegate void Method_OnDisable0();
    Method_OnDisable0 __OnDisable0;
    public void OnDisable() {
      if( __OnDisable0 == null ) {
        __OnDisable0 = (Method_OnDisable0) Delegate.CreateDelegate( typeof( Method_OnDisable0 ), m_instance, R.Method("OnDisable", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      __OnDisable0(  );
    }



    delegate void Method_OnForceReloadInspector0();
    Method_OnForceReloadInspector0 __OnForceReloadInspector0;
    public void OnForceReloadInspector() {
      if( __OnForceReloadInspector0 == null ) {
        __OnForceReloadInspector0 = (Method_OnForceReloadInspector0) Delegate.CreateDelegate( typeof( Method_OnForceReloadInspector0 ), m_instance, R.Method("OnForceReloadInspector", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      __OnForceReloadInspector0(  );
    }



    delegate void Method_OnPreviewSettings0();
    Method_OnPreviewSettings0 __OnPreviewSettings0;
    public void OnPreviewSettings() {
      if( __OnPreviewSettings0 == null ) {
        __OnPreviewSettings0 = (Method_OnPreviewSettings0) Delegate.CreateDelegate( typeof( Method_OnPreviewSettings0 ), m_instance, R.Method("OnPreviewSettings", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      __OnPreviewSettings0(  );
    }



    delegate void Method_OnPreviewGUI0( UnityEngine.Rect r, UnityEngine.GUIStyle background );
    Method_OnPreviewGUI0 __OnPreviewGUI0;
    public void OnPreviewGUI( UnityEngine.Rect r, UnityEngine.GUIStyle background ) {
      if( __OnPreviewGUI0 == null ) {
        __OnPreviewGUI0 = (Method_OnPreviewGUI0) Delegate.CreateDelegate( typeof( Method_OnPreviewGUI0 ), m_instance, R.Method("OnPreviewGUI", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      __OnPreviewGUI0(  r, background  );
    }



    delegate void Method_ReloadPreviewInstances0();
    Method_ReloadPreviewInstances0 __ReloadPreviewInstances0;
    public void ReloadPreviewInstances() {
      if( __ReloadPreviewInstances0 == null ) {
        __ReloadPreviewInstances0 = (Method_ReloadPreviewInstances0) Delegate.CreateDelegate( typeof( Method_ReloadPreviewInstances0 ), m_instance, R.Method("ReloadPreviewInstances", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      __ReloadPreviewInstances0(  );
    }



    delegate UnityEngine.Texture2D Method_RenderStaticPreview0( string assetPath, UnityEngine.Object[] subAssets, int width, int height );
    Method_RenderStaticPreview0 __RenderStaticPreview0;
    public UnityEngine.Texture2D RenderStaticPreview( string assetPath, UnityEngine.Object[] subAssets, int width, int height ) {
      if( __RenderStaticPreview0 == null ) {
        __RenderStaticPreview0 = (Method_RenderStaticPreview0) Delegate.CreateDelegate( typeof( Method_RenderStaticPreview0 ), m_instance, R.Method("RenderStaticPreview", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      return __RenderStaticPreview0(  assetPath, subAssets, width, height  );
    }



    delegate void Method_OnHeaderGUI0();
    Method_OnHeaderGUI0 __OnHeaderGUI0;
    public void OnHeaderGUI() {
      if( __OnHeaderGUI0 == null ) {
        __OnHeaderGUI0 = (Method_OnHeaderGUI0) Delegate.CreateDelegate( typeof( Method_OnHeaderGUI0 ), m_instance, R.Method("OnHeaderGUI", "UnityEditor.GameObjectInspector", "UnityEditor.dll") );
      }
      __OnHeaderGUI0(  );
    }



	}
}

#endif

