/// UnityEditor.Toolbar : 2021.1.7f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
	public sealed partial class UnityEditorToolbar {


#if UNITY_2021_1_OR_NEWER
		public UnityEngine.UIElements.VisualElement m_Root {
			get {
				if( __m_Root == null ) {
					__m_Root = UnityTypes.UnityEditor_Toolbar.GetField( "m_Root", R.InstanceMembers );
				}
				return (UnityEngine.UIElements.VisualElement) __m_Root.GetValue( m_instance );
			}
			set {
				if( __m_Root == null ) {
					__m_Root = UnityTypes.UnityEditor_Toolbar.GetField( "m_Root", R.InstanceMembers );
				}
				__m_Root.SetValue( m_instance, value );
			}
		}

		

		FieldInfo __m_Root;

#endif
	}
}

