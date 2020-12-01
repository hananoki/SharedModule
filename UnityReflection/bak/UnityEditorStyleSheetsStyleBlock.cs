/// UnityEditor.StyleSheets.StyleBlock : 2019.3.0f6

#if false

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public class UnityStyleSheetsStyleBlock {
    public object m_instance;
    public object GetInstance() { return m_instance; }

    //public UnityStyleSheetsStyleBlock( int name, UnityEditor.StyleSheets.StyleState[] states, UnityEditor.StyleSheets.StyleValue[] values, UnityEditor.StyleSheets.StyleCatalog catalog ) {
    //  m_instance = Activator.CreateInstance( R.Type("UnityEditor.StyleSheets.StyleBlock", "UnityEditor.dll"), new object[] {  name, states, values, catalog  } );
    //}


    delegate float Method_GetFloat0( int key, float defaultValue = 0 );
    Method_GetFloat0 __GetFloat0;
    public float GetFloat( int key, float defaultValue = 0 ) {
      if( __GetFloat0 == null ) {
        __GetFloat0 = (Method_GetFloat0) Delegate.CreateDelegate( typeof( Method_GetFloat0 ), m_instance, R.Method( 2, "GetFloat", "UnityEditor.StyleSheets.StyleBlock", "UnityEditor.dll") );
      }
      return __GetFloat0(  key, defaultValue  );
    }

    delegate float Method_GetFloat1( string key, float defaultValue = 0 );
    Method_GetFloat1 __GetFloat1;
    public float GetFloat( string key, float defaultValue = 0 ) {
      if( __GetFloat1 == null ) {
        __GetFloat1 = (Method_GetFloat1) Delegate.CreateDelegate( typeof( Method_GetFloat1 ), m_instance, R.Method( 2, "GetFloat", "UnityEditor.StyleSheets.StyleBlock", "UnityEditor.dll") );
      }
      return __GetFloat1(  key, defaultValue  );
    }



	}
}

#endif

