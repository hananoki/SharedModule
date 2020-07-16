/// UnityEditor.PropertyHandler : 2019.3.10f1

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public partial class UnityEditorPropertyHandler {
    public object m_instance;
    public object GetInstance() { return m_instance; }

		public UnityEditorPropertyHandler( object instance ) {
			m_instance = instance;
		}

		public UnityEditorPropertyHandler() {
      m_instance = Activator.CreateInstance( R.Type("UnityEditor.PropertyHandler", "UnityEditor.dll"), R.AllMembers | System.Reflection.BindingFlags.CreateInstance, Type.DefaultBinder, new object[] {  }, System.Globalization.CultureInfo.CurrentCulture );
    }


    delegate void Method_AddMenuItems0( UnityEditor.SerializedProperty property, UnityEditor.GenericMenu menu );
    Method_AddMenuItems0 __AddMenuItems0;
    public void AddMenuItems( UnityEditor.SerializedProperty property, UnityEditor.GenericMenu menu ) {
      if( __AddMenuItems0 == null ) {
        __AddMenuItems0 = (Method_AddMenuItems0) Delegate.CreateDelegate( typeof( Method_AddMenuItems0 ), m_instance, R.Method("AddMenuItems", "UnityEditor.PropertyHandler", "UnityEditor.dll") );
      }
      __AddMenuItems0(  property, menu  );
    }


		//public static Func<TObj, TProp> GetGetter<TObj, TProp>( string propName )
		//=> (Func<TObj, TProp>)
		//		Delegate.CreateDelegate( typeof( Func<TObj, TProp> ),
		//				typeof( TObj ).GetProperty( propName ).GetGetMethod() );

		delegate bool __hasPropertyDrawer(  );
		__hasPropertyDrawer ___hasPropertyDrawer;

		public bool hasPropertyDrawer {
			get {
				if( ___hasPropertyDrawer == null ) {
					___hasPropertyDrawer = (__hasPropertyDrawer) Delegate.CreateDelegate(
					typeof( __hasPropertyDrawer ),
					m_instance,
					R.Type( "UnityEditor.PropertyHandler", "UnityEditor.dll" ).GetProperty( "hasPropertyDrawer" ).GetGetMethod() );
				}
				return ___hasPropertyDrawer();
			}
		}
	}
}

#endif

