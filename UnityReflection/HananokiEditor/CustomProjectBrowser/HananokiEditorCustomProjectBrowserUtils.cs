/// HananokiEditor.CustomProjectBrowser.Utils : 2020.3.8f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class HananokiEditorCustomProjectBrowserUtils {

		public static bool drawSupress {
			set {
				if( __setter_drawSupress == null ) {
					__setter_drawSupress = (Action<bool>) Delegate.CreateDelegate( typeof( Action<bool> ), null, UnityTypes.HananokiEditor_CustomProjectBrowser_Utils.GetMethod( "set_drawSupress", R.StaticMembers ) );
			  }
				__setter_drawSupress( value );
			}
		}

		
		
		static Action<bool> __setter_drawSupress;
	}
}

