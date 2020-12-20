/// UnityEngine.UIElements.StyleSheets.Dimension : 2019.4.16f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEngineUIElementsStyleSheetsDimension {
		public object m_instance;
    
    public UnityEngineUIElementsStyleSheetsDimension( object instance ){
			m_instance = instance;
    }
    public UnityEngineUIElementsStyleSheetsDimension( float value, object unit ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEngine_UIElements_StyleSheets_Dimension, new object[] { value, unit } );
    }
    

		public float value {
			get {
				if( __value == null ) {
					__value = UnityTypes.UnityEngine_UIElements_StyleSheets_Dimension.GetField( "value", R.InstanceMembers );
				}
				return (float) __value.GetValue( m_instance );
			}
			set {
				if( __value == null ) {
					__value = UnityTypes.UnityEngine_UIElements_StyleSheets_Dimension.GetField( "value", R.InstanceMembers );
				}
				__value.SetValue( m_instance, value );
			}
		}

		
		
		FieldInfo __value;
	}
}

