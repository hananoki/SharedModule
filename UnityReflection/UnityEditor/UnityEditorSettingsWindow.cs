/// UnityEditor.SettingsWindow : 2020.2.7f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorSettingsWindow {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorSettingsWindow( object instance ){
			m_instance = instance;
    }
    public UnityEditorSettingsWindow() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_SettingsWindow, new object[] {} );
    }
    public UnityEditorSettingsWindow( UnityEditor.SettingsScope scope ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_SettingsWindow, new object[] { scope } );
    }
    

		public static object Show( UnityEditor.SettingsScope scopes, string settingsPath = null ) {
			if( __Show_0_2 == null ) {
				__Show_0_2 = (Func<UnityEditor.SettingsScope,string, object>) Delegate.CreateDelegate( typeof( Func<UnityEditor.SettingsScope,string, object> ), null, UnityTypes.UnityEditor_SettingsWindow.GetMethod( "Show", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.SettingsScope ), typeof( string ) }, null ) );
			}
			return __Show_0_2( scopes, settingsPath );
		}
		
		public void Show() {
			if( __Show_0_0 == null ) {
				__Show_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_SettingsWindow.GetMethod( "Show", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__Show_0_0();
		}
		
		public void Show( bool immediateDisplay ) {
			if( __Show_1_1 == null ) {
				__Show_1_1 = (Action<bool>) Delegate.CreateDelegate( typeof( Action<bool> ), m_instance, UnityTypes.UnityEditor_SettingsWindow.GetMethod( "Show", R.InstanceMembers, null, new Type[]{ typeof( bool ) }, null ) );
			}
			__Show_1_1( immediateDisplay );
		}
		
		
		
		static Func<UnityEditor.SettingsScope,string, object> __Show_0_2;
		Action __Show_0_0;
		Action<bool> __Show_1_1;
	}
}

