/// TMPro.TMP_Text : 2019.4.16f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class TMProTMP_Text {
		public object m_instance;
    
    public TMProTMP_Text( object instance ){
			m_instance = instance;
    }
    public TMProTMP_Text() {
			m_instance = Activator.CreateInstance( UnityTypes.TMPro_TMP_Text, new object[] {} );
    }
    

		public UnityEngine.Object font {
			get {
				if( __getter_font == null ) {
					__getter_font = (Func<UnityEngine.Object>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Object> ), m_instance, UnityTypes.TMPro_TMP_Text.GetMethod( "get_font", R.InstanceMembers ) );
				}
				return __getter_font();
			}
			set {
				if( __setter_font == null ) {
					__setter_font = (Action<UnityEngine.Object>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Object> ), m_instance, UnityTypes.TMPro_TMP_Text.GetMethod( "set_font", R.InstanceMembers ) );
			  }
				__setter_font( value );
			}
		}

		
		
		Func<UnityEngine.Object> __getter_font;
		Action<UnityEngine.Object> __setter_font;
	}
}

