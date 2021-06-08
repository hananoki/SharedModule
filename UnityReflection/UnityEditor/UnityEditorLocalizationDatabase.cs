/// UnityEditor.LocalizationDatabase : 2019.4.21f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorLocalizationDatabase {

		public static class Cache<T> {
			public static T cache;
		}

		public static UnityEngine.SystemLanguage currentEditorLanguage {
			get {
				if( __getter_currentEditorLanguage == null ) {
					__getter_currentEditorLanguage = (Func<UnityEngine.SystemLanguage>) Delegate.CreateDelegate( typeof( Func<UnityEngine.SystemLanguage> ), null, UnityTypes.UnityEditor_LocalizationDatabase.GetMethod( "get_currentEditorLanguage", R.StaticMembers ) );
				}
				return __getter_currentEditorLanguage();
			}
			set {
				if( __setter_currentEditorLanguage == null ) {
					__setter_currentEditorLanguage = (Action<UnityEngine.SystemLanguage>) Delegate.CreateDelegate( typeof( Action<UnityEngine.SystemLanguage> ), null, UnityTypes.UnityEditor_LocalizationDatabase.GetMethod( "set_currentEditorLanguage", R.StaticMembers ) );
			  }
				__setter_currentEditorLanguage( value );
			}
		}

		public static bool enableEditorLocalization {
			get {
				if( __getter_enableEditorLocalization == null ) {
					__getter_enableEditorLocalization = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), null, UnityTypes.UnityEditor_LocalizationDatabase.GetMethod( "get_enableEditorLocalization", R.StaticMembers ) );
				}
				return __getter_enableEditorLocalization();
			}
			set {
				if( __setter_enableEditorLocalization == null ) {
					__setter_enableEditorLocalization = (Action<bool>) Delegate.CreateDelegate( typeof( Action<bool> ), null, UnityTypes.UnityEditor_LocalizationDatabase.GetMethod( "set_enableEditorLocalization", R.StaticMembers ) );
			  }
				__setter_enableEditorLocalization( value );
			}
		}

		public static string GetLocalizationResourceFolder() {
			if( __GetLocalizationResourceFolder_0_0 == null ) {
				__GetLocalizationResourceFolder_0_0 = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), null, UnityTypes.UnityEditor_LocalizationDatabase.GetMethod( "GetLocalizationResourceFolder", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetLocalizationResourceFolder_0_0();
		}
		
		
		
		static Func<UnityEngine.SystemLanguage> __getter_currentEditorLanguage;
		static Action<UnityEngine.SystemLanguage> __setter_currentEditorLanguage;
		static Func<bool> __getter_enableEditorLocalization;
		static Action<bool> __setter_enableEditorLocalization;
		static Func<string> __GetLocalizationResourceFolder_0_0;
	}
}

