/// UnityEditor.AnimatorInspector : 2020.2.1f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorAnimatorInspector {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorAnimatorInspector( object instance ){
			m_instance = instance;
    }
    public UnityEditorAnimatorInspector() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_AnimatorInspector, new object[] {} );
    }
    

		public static object styles {
			get {
				if( __styles == null ) {
					__styles = UnityTypes.UnityEditor_AnimatorInspector.GetField( "styles", R.StaticMembers );
				}
				return (object) __styles.GetValue( null );
			}
			set {
				if( __styles == null ) {
					__styles = UnityTypes.UnityEditor_AnimatorInspector.GetField( "styles", R.StaticMembers );
				}
				__styles.SetValue( null, value );
			}
		}

		public void OnInspectorGUI() {
			if( __OnInspectorGUI_0_0 == null ) {
				__OnInspectorGUI_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_AnimatorInspector.GetMethod( "OnInspectorGUI", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__OnInspectorGUI_0_0();
		}
		
		
		
		static FieldInfo __styles;
		Action __OnInspectorGUI_0_0;
	}
}

