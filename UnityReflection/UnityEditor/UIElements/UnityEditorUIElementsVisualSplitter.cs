/// UnityEditor.UIElements.VisualSplitter : 2019.4.5f1

#if UNITY_2019_1_OR_NEWER

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorUIElementsVisualSplitter {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorUIElementsVisualSplitter( object instance ){
			m_instance = instance;
    }
    public UnityEditorUIElementsVisualSplitter() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_UIElements_VisualSplitter, new object[] {} );
    }
    

		public int splitSize {
			get {
				if( __splitSize == null ) {
					__splitSize = UnityTypes.UnityEditor_UIElements_VisualSplitter.GetField( "splitSize", R.InstanceMembers );
				}
				return (int) __splitSize.GetValue( m_instance );
			}
			set {
				if( __splitSize == null ) {
					__splitSize = UnityTypes.UnityEditor_UIElements_VisualSplitter.GetField( "splitSize", R.InstanceMembers );
				}
				__splitSize.SetValue( m_instance, value );
			}
		}

		public void Add( UnityEngine.UIElements.VisualElement child ) {
			if( __Add_0_1 == null ) {
				__Add_0_1 = (Action<UnityEngine.UIElements.VisualElement>) Delegate.CreateDelegate( typeof( Action<UnityEngine.UIElements.VisualElement> ), m_instance, UnityTypes.UnityEditor_UIElements_VisualSplitter.GetMethod( "Add", R.InstanceMembers, null, new Type[]{ typeof( UnityEngine.UIElements.VisualElement ) }, null ) );
			}
			__Add_0_1( child );
		}
		
		public void AddToClassList( string className ) {
			if( __AddToClassList_0_1 == null ) {
				__AddToClassList_0_1 = (Action<string>) Delegate.CreateDelegate( typeof( Action<string> ), m_instance, UnityTypes.UnityEditor_UIElements_VisualSplitter.GetMethod( "AddToClassList", R.InstanceMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			__AddToClassList_0_1( className );
		}
		
		
		
		FieldInfo __splitSize;
		Action<UnityEngine.UIElements.VisualElement> __Add_0_1;
		Action<string> __AddToClassList_0_1;
	}
}

#endif // UNITY_2019_1_OR_NEWER


