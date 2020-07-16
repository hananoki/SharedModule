/// UnityEditor.TransformRotationGUI : 2019.3.2f1

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public class UnityTransformRotationGUI {
    public object m_instance;
    public object GetInstance() { return m_instance; }

    public UnityTransformRotationGUI() {
      m_instance = Activator.CreateInstance( R.Type("UnityEditor.TransformRotationGUI", "UnityEditor.dll"), new object[] {  } );
    }


    delegate void Method_OnEnable0( UnityEditor.SerializedProperty m_Rotation, UnityEngine.GUIContent label );
    Method_OnEnable0 __OnEnable0;
    public void OnEnable( UnityEditor.SerializedProperty m_Rotation, UnityEngine.GUIContent label ) {
      if( __OnEnable0 == null ) {
        __OnEnable0 = (Method_OnEnable0) Delegate.CreateDelegate( typeof( Method_OnEnable0 ), m_instance, R.Method("OnEnable", "UnityEditor.TransformRotationGUI", "UnityEditor.dll") );
      }
      __OnEnable0(  m_Rotation, label  );
    }



    delegate void Method_RotationField0();
    Method_RotationField0 __RotationField0;
    public void RotationField() {
      if( __RotationField0 == null ) {
        __RotationField0 = (Method_RotationField0) Delegate.CreateDelegate( typeof( Method_RotationField0 ), m_instance, R.Method( 0, "RotationField", "UnityEditor.TransformRotationGUI", "UnityEditor.dll") );
      }
      __RotationField0(  );
    }

    delegate void Method_RotationField1( bool disabled );
    Method_RotationField1 __RotationField1;
    public void RotationField( bool disabled ) {
      if( __RotationField1 == null ) {
        __RotationField1 = (Method_RotationField1) Delegate.CreateDelegate( typeof( Method_RotationField1 ), m_instance, R.Method( 1, "RotationField", "UnityEditor.TransformRotationGUI", "UnityEditor.dll") );
      }
      __RotationField1(  disabled  );
    }



	}
}

#endif

