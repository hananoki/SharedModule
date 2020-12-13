/// UnityEditor.TransformRotationGUI : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorTransformRotationGUI {
		public object m_instance;
    
    public UnityEditorTransformRotationGUI( object instance ){
			m_instance = instance;
    }
    public UnityEditorTransformRotationGUI() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_TransformRotationGUI, new object[] {} );
    }
    
    
		public void OnEnable( UnityEditor.SerializedProperty m_Rotation, UnityEngine.GUIContent label ) {
			if( __OnEnable_0_2 == null ) {
				__OnEnable_0_2 = (Action<UnityEditor.SerializedProperty,UnityEngine.GUIContent>) Delegate.CreateDelegate( typeof( Action<UnityEditor.SerializedProperty,UnityEngine.GUIContent> ), m_instance, UnityTypes.UnityEditor_TransformRotationGUI.GetMethod( "OnEnable", R.InstanceMembers, null, new Type[]{ typeof( UnityEditor.SerializedProperty ), typeof( UnityEngine.GUIContent ) }, null ) );
			}
			__OnEnable_0_2( m_Rotation, label );
		}
		
		public void RotationField() {
			if( __RotationField_0_0 == null ) {
				__RotationField_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_TransformRotationGUI.GetMethod( "RotationField", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__RotationField_0_0(  );
		}
		
		public void RotationField( bool disabled ) {
			if( __RotationField_1_1 == null ) {
				__RotationField_1_1 = (Action<bool>) Delegate.CreateDelegate( typeof( Action<bool> ), m_instance, UnityTypes.UnityEditor_TransformRotationGUI.GetMethod( "RotationField", R.InstanceMembers, null, new Type[]{ typeof( bool ) }, null ) );
			}
			__RotationField_1_1( disabled );
		}
		
		
		
		Action<UnityEditor.SerializedProperty,UnityEngine.GUIContent> __OnEnable_0_2;
		Action __RotationField_0_0;
		Action<bool> __RotationField_1_1;
	}
}

