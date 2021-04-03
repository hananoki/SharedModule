/// UnityEditorInternal.AnimationWindowHierarchyDataSource : 2020.3.0f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorInternalAnimationWindowHierarchyDataSource {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorInternalAnimationWindowHierarchyDataSource( object instance ){
			m_instance = instance;
    }
   // public UnityEditorInternalAnimationWindowHierarchyDataSource( UnityEditor.IMGUI.Controls.TreeViewController treeView, UnityEditorInternal.AnimationWindowState animationWindowState ) {
			//m_instance = Activator.CreateInstance( UnityTypes.UnityEditorInternal_AnimationWindowHierarchyDataSource, new object[] { treeView, animationWindowState } );
   // }
    

		public UnityEditor.IMGUI.Controls.TreeViewItem FindItem( int id ) {
			if( __FindItem_0_1 == null ) {
				__FindItem_0_1 = (Func<int, UnityEditor.IMGUI.Controls.TreeViewItem>) Delegate.CreateDelegate( typeof( Func<int, UnityEditor.IMGUI.Controls.TreeViewItem> ), m_instance, UnityTypes.UnityEditorInternal_AnimationWindowHierarchyDataSource.GetMethod( "FindItem", R.InstanceMembers, null, new Type[]{ typeof( int ) }, null ) );
			}
			return __FindItem_0_1( id );
		}
		
		
		
		Func<int, UnityEditor.IMGUI.Controls.TreeViewItem> __FindItem_0_1;
	}
}

