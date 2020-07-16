/// UnityEditor.PrefabOverridesWindow : 2019.3.10f1

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public partial class UnityPrefabOverridesWindow {
    public object m_instance;
    public object GetInstance() { return m_instance; }

    public UnityPrefabOverridesWindow( UnityEngine.GameObject selectedGameObject ) {
      m_instance = Activator.CreateInstance( R.Type("UnityEditor.PrefabOverridesWindow", "UnityEditor.dll"), R.AllMembers | System.Reflection.BindingFlags.CreateInstance, Type.DefaultBinder, new object[] {  selectedGameObject  }, System.Globalization.CultureInfo.CurrentCulture );
    }
    public UnityPrefabOverridesWindow( UnityEngine.GameObject[] selectedGameObjects ) {
      m_instance = Activator.CreateInstance( R.Type("UnityEditor.PrefabOverridesWindow", "UnityEditor.dll"), R.AllMembers | System.Reflection.BindingFlags.CreateInstance, Type.DefaultBinder, new object[] {  selectedGameObjects  }, System.Globalization.CultureInfo.CurrentCulture );
    }


    delegate bool Method_ApplyAll0();
    Method_ApplyAll0 __ApplyAll0;
    public bool ApplyAll() {
      if( __ApplyAll0 == null ) {
        __ApplyAll0 = (Method_ApplyAll0) Delegate.CreateDelegate( typeof( Method_ApplyAll0 ), m_instance, R.Method("ApplyAll", "UnityEditor.PrefabOverridesWindow", "UnityEditor.dll") );
      }
      return __ApplyAll0(  );
    }



    delegate bool Method_RevertAll0();
    Method_RevertAll0 __RevertAll0;
    public bool RevertAll() {
      if( __RevertAll0 == null ) {
        __RevertAll0 = (Method_RevertAll0) Delegate.CreateDelegate( typeof( Method_RevertAll0 ), m_instance, R.Method("RevertAll", "UnityEditor.PrefabOverridesWindow", "UnityEditor.dll") );
      }
      return __RevertAll0(  );
    }



    delegate void Method_OnOpen0();
    Method_OnOpen0 __OnOpen0;
    public void OnOpen() {
      if( __OnOpen0 == null ) {
        __OnOpen0 = (Method_OnOpen0) Delegate.CreateDelegate( typeof( Method_OnOpen0 ), m_instance, R.Method("OnOpen", "UnityEditor.PrefabOverridesWindow", "UnityEditor.dll") );
      }
      __OnOpen0(  );
    }



    delegate void Method_OnClose0();
    Method_OnClose0 __OnClose0;
    public void OnClose() {
      if( __OnClose0 == null ) {
        __OnClose0 = (Method_OnClose0) Delegate.CreateDelegate( typeof( Method_OnClose0 ), m_instance, R.Method("OnClose", "UnityEditor.PrefabOverridesWindow", "UnityEditor.dll") );
      }
      __OnClose0(  );
    }



    delegate bool Method_IsShowingActionButton0();
    Method_IsShowingActionButton0 __IsShowingActionButton0;
    public bool IsShowingActionButton() {
      if( __IsShowingActionButton0 == null ) {
        __IsShowingActionButton0 = (Method_IsShowingActionButton0) Delegate.CreateDelegate( typeof( Method_IsShowingActionButton0 ), m_instance, R.Method("IsShowingActionButton", "UnityEditor.PrefabOverridesWindow", "UnityEditor.dll") );
      }
      return __IsShowingActionButton0(  );
    }



	}
}

#endif

