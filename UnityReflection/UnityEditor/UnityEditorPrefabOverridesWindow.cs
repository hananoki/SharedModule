/// UnityEditor.PrefabOverridesWindow : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorPrefabOverridesWindow {
		public object m_instance;
    
    public UnityEditorPrefabOverridesWindow( object instance ){
			m_instance = instance;
    }
    public UnityEditorPrefabOverridesWindow( UnityEngine.GameObject selectedGameObject ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_PrefabOverridesWindow, new object[] { selectedGameObject } );
    }
    public UnityEditorPrefabOverridesWindow( UnityEngine.GameObject[] selectedGameObjects ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_PrefabOverridesWindow, new object[] { selectedGameObjects } );
    }
    
    
		public bool ApplyAll() {
			if( __ApplyAll_0_0 == null ) {
				__ApplyAll_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_PrefabOverridesWindow.GetMethod( "ApplyAll", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __ApplyAll_0_0(  );
		}
		
		public bool RevertAll() {
			if( __RevertAll_0_0 == null ) {
				__RevertAll_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_PrefabOverridesWindow.GetMethod( "RevertAll", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __RevertAll_0_0(  );
		}
		
		public void OnOpen() {
			if( __OnOpen_0_0 == null ) {
				__OnOpen_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_PrefabOverridesWindow.GetMethod( "OnOpen", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__OnOpen_0_0(  );
		}
		
		public void OnClose() {
			if( __OnClose_0_0 == null ) {
				__OnClose_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_PrefabOverridesWindow.GetMethod( "OnClose", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__OnClose_0_0(  );
		}
		
		public bool IsShowingActionButton() {
			if( __IsShowingActionButton_0_0 == null ) {
				__IsShowingActionButton_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_PrefabOverridesWindow.GetMethod( "IsShowingActionButton", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __IsShowingActionButton_0_0(  );
		}
		
		
		
		Func<bool> __ApplyAll_0_0;
		Func<bool> __RevertAll_0_0;
		Action __OnOpen_0_0;
		Action __OnClose_0_0;
		Func<bool> __IsShowingActionButton_0_0;
	}
}

