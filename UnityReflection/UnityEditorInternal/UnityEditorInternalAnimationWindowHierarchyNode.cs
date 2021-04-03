/// UnityEditorInternal.AnimationWindowHierarchyNode : 2020.3.0f1

using HananokiEditor;
using System;
using System.Reflection;
using System.Collections;

namespace UnityReflection {
  public sealed partial class UnityEditorInternalAnimationWindowHierarchyNode {
		public object m_instance;
    
    public UnityEditorInternalAnimationWindowHierarchyNode( object instance ){
			m_instance = instance;
    }
    public UnityEditorInternalAnimationWindowHierarchyNode( int instanceID, int depth, UnityEditor.IMGUI.Controls.TreeViewItem parent, System.Type animatableObjectType, string propertyName, string path, string displayName ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditorInternal_AnimationWindowHierarchyNode, new object[] { instanceID, depth, parent, animatableObjectType, propertyName, path, displayName } );
    }
    

		public ICollection curves {
			get {
				if( __curves == null ) {
					__curves = UnityTypes.UnityEditorInternal_AnimationWindowHierarchyNode.GetField( "curves", R.InstanceMembers );
				}
				return (ICollection) __curves.GetValue( m_instance );
			}
			set {
				if( __curves == null ) {
					__curves = UnityTypes.UnityEditorInternal_AnimationWindowHierarchyNode.GetField( "curves", R.InstanceMembers );
				}
				__curves.SetValue( m_instance, value );
			}
		}

		
		
		FieldInfo __curves;
	}
}

