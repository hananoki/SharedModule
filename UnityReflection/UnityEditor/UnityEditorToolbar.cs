/// UnityEditor.Toolbar : 2021.1.7f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
	public sealed partial class UnityEditorToolbar {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;

		public UnityEditorToolbar( object instance ) {
			m_instance = instance;
		}
		public UnityEditorToolbar() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_Toolbar, new object[] { } );
		}



		public static void RepaintToolbar() {
			if( __RepaintToolbar_0_0 == null ) {
				__RepaintToolbar_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), null, UnityTypes.UnityEditor_Toolbar.GetMethod( "RepaintToolbar", R.StaticMembers, null, new Type[] { }, null ) );
			}
			__RepaintToolbar_0_0();
		}

		public void OnDestroy() {
			if( __OnDestroy_0_0 == null ) {
				__OnDestroy_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_Toolbar.GetMethod( "OnDestroy", R.InstanceMembers, null, new Type[] { }, null ) );
			}
			__OnDestroy_0_0();
		}



		static Action __RepaintToolbar_0_0;
		Action __OnDestroy_0_0;
	}
}

