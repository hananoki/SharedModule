/// UnityEditor.EditorSettings : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorEditorSettings {

		public static bool enterPlayModeOptionsEnabled {
			get {
				if( __getter_enterPlayModeOptionsEnabled == null ) {
					__getter_enterPlayModeOptionsEnabled = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), null, UnityTypes.UnityEditor_EditorSettings.GetMethod( "get_enterPlayModeOptionsEnabled", R.StaticMembers ) );
				}
				return __getter_enterPlayModeOptionsEnabled();
			}
			set {
				if( __setter_enterPlayModeOptionsEnabled == null ) {
					__setter_enterPlayModeOptionsEnabled = (Action<bool>) Delegate.CreateDelegate( typeof( Action<bool> ), null, UnityTypes.UnityEditor_EditorSettings.GetMethod( "set_enterPlayModeOptionsEnabled", R.StaticMembers ) );
			  }
				__setter_enterPlayModeOptionsEnabled( value );
			}
		}

		
		
		static Func<bool> __getter_enterPlayModeOptionsEnabled;
		static Action<bool> __setter_enterPlayModeOptionsEnabled;
	}
}

