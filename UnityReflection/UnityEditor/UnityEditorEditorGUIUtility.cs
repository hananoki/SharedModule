/// UnityEditor.EditorGUIUtility : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorEditorGUIUtility {

		public static class Cache<T> {
			public static T cache;
		}

		public static int skinIndex {
			get {
				if( __getter_skinIndex == null ) {
					__getter_skinIndex = (Func<int>) Delegate.CreateDelegate( typeof( Func<int> ), null, UnityTypes.UnityEditor_EditorGUIUtility.GetMethod( "get_skinIndex", R.StaticMembers ) );
				}
				return __getter_skinIndex();
			}
			set {
				if( __setter_skinIndex == null ) {
					__setter_skinIndex = (Action<int>) Delegate.CreateDelegate( typeof( Action<int> ), null, UnityTypes.UnityEditor_EditorGUIUtility.GetMethod( "set_skinIndex", R.StaticMembers ) );
			  }
				__setter_skinIndex( value );
			}
		}

		public static UnityEngine.GUIContent TrTextContent( string key, string text, string tooltip, UnityEngine.Texture icon ) {
			if( __TrTextContent_0_4 == null ) {
				__TrTextContent_0_4 = (Func<string,string,string,UnityEngine.Texture, UnityEngine.GUIContent>) Delegate.CreateDelegate( typeof( Func<string,string,string,UnityEngine.Texture, UnityEngine.GUIContent> ), null, UnityTypes.UnityEditor_EditorGUIUtility.GetMethod( "TrTextContent", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( string ), typeof( string ), typeof( UnityEngine.Texture ) }, null ) );
			}
			return __TrTextContent_0_4( key, text, tooltip, icon );
		}
		
		public static UnityEngine.GUIContent TrTextContent( string text, string tooltip = null, UnityEngine.Texture icon = null ) {
			if( __TrTextContent_1_3 == null ) {
				__TrTextContent_1_3 = (Func<string,string,UnityEngine.Texture, UnityEngine.GUIContent>) Delegate.CreateDelegate( typeof( Func<string,string,UnityEngine.Texture, UnityEngine.GUIContent> ), null, UnityTypes.UnityEditor_EditorGUIUtility.GetMethod( "TrTextContent", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( string ), typeof( UnityEngine.Texture ) }, null ) );
			}
			return __TrTextContent_1_3( text, tooltip, icon );
		}
		
		public static UnityEngine.GUIContent TrTextContent( string text, string tooltip, string iconName ) {
			if( __TrTextContent_2_3 == null ) {
				__TrTextContent_2_3 = (Func<string,string,string, UnityEngine.GUIContent>) Delegate.CreateDelegate( typeof( Func<string,string,string, UnityEngine.GUIContent> ), null, UnityTypes.UnityEditor_EditorGUIUtility.GetMethod( "TrTextContent", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( string ), typeof( string ) }, null ) );
			}
			return __TrTextContent_2_3( text, tooltip, iconName );
		}
		
		public static UnityEngine.GUIContent TrTextContent( string text, UnityEngine.Texture icon ) {
			if( __TrTextContent_3_2 == null ) {
				__TrTextContent_3_2 = (Func<string,UnityEngine.Texture, UnityEngine.GUIContent>) Delegate.CreateDelegate( typeof( Func<string,UnityEngine.Texture, UnityEngine.GUIContent> ), null, UnityTypes.UnityEditor_EditorGUIUtility.GetMethod( "TrTextContent", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( UnityEngine.Texture ) }, null ) );
			}
			return __TrTextContent_3_2( text, icon );
		}
		
		public static UnityEngine.GUIContent TextContent( string textAndTooltip ) {
			if( __TextContent_0_1 == null ) {
				__TextContent_0_1 = (Func<string, UnityEngine.GUIContent>) Delegate.CreateDelegate( typeof( Func<string, UnityEngine.GUIContent> ), null, UnityTypes.UnityEditor_EditorGUIUtility.GetMethod( "TextContent", R.StaticMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			return __TextContent_0_1( textAndTooltip );
		}
		
		public static UnityEngine.Texture2D LoadIcon( string name ) {
			if( __LoadIcon_0_1 == null ) {
				__LoadIcon_0_1 = (Func<string, UnityEngine.Texture2D>) Delegate.CreateDelegate( typeof( Func<string, UnityEngine.Texture2D> ), null, UnityTypes.UnityEditor_EditorGUIUtility.GetMethod( "LoadIcon", R.StaticMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			return __LoadIcon_0_1( name );
		}
		
		public static UnityEngine.AssetBundle GetEditorAssetBundle() {
			if( __GetEditorAssetBundle_0_0 == null ) {
				__GetEditorAssetBundle_0_0 = (Func<UnityEngine.AssetBundle>) Delegate.CreateDelegate( typeof( Func<UnityEngine.AssetBundle> ), null, UnityTypes.UnityEditor_EditorGUIUtility.GetMethod( "GetEditorAssetBundle", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetEditorAssetBundle_0_0();
		}
		
		public static UnityEngine.Color GetDefaultBackgroundColor() {
			if( __GetDefaultBackgroundColor_0_0 == null ) {
				__GetDefaultBackgroundColor_0_0 = (Func<UnityEngine.Color>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Color> ), null, UnityTypes.UnityEditor_EditorGUIUtility.GetMethod( "GetDefaultBackgroundColor", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetDefaultBackgroundColor_0_0();
		}
		
		public static void NotifyLanguageChanged( UnityEngine.SystemLanguage newLanguage ) {
			if( __NotifyLanguageChanged_0_1 == null ) {
				__NotifyLanguageChanged_0_1 = (Action<UnityEngine.SystemLanguage>) Delegate.CreateDelegate( typeof( Action<UnityEngine.SystemLanguage> ), null, UnityTypes.UnityEditor_EditorGUIUtility.GetMethod( "NotifyLanguageChanged", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.SystemLanguage ) }, null ) );
			}
			__NotifyLanguageChanged_0_1( newLanguage );
		}
		
		public static UnityEngine.Object GetBuiltinExtraResource( System.Type type, string path ) {
			if( __GetBuiltinExtraResource_0_2 == null ) {
				__GetBuiltinExtraResource_0_2 = (Func<System.Type,string, UnityEngine.Object>) Delegate.CreateDelegate( typeof( Func<System.Type,string, UnityEngine.Object> ), null, UnityTypes.UnityEditor_EditorGUIUtility.GetMethod( "GetBuiltinExtraResource", R.StaticMembers, null, new Type[]{ typeof( System.Type ), typeof( string ) }, null ) );
			}
			return __GetBuiltinExtraResource_0_2( type, path );
		}
		
		
		
		static Func<int> __getter_skinIndex;
		static Action<int> __setter_skinIndex;
		static Func<string,string,string,UnityEngine.Texture, UnityEngine.GUIContent> __TrTextContent_0_4;
		static Func<string,string,UnityEngine.Texture, UnityEngine.GUIContent> __TrTextContent_1_3;
		static Func<string,string,string, UnityEngine.GUIContent> __TrTextContent_2_3;
		static Func<string,UnityEngine.Texture, UnityEngine.GUIContent> __TrTextContent_3_2;
		static Func<string, UnityEngine.GUIContent> __TextContent_0_1;
		static Func<string, UnityEngine.Texture2D> __LoadIcon_0_1;
		static Func<UnityEngine.AssetBundle> __GetEditorAssetBundle_0_0;
		static Func<UnityEngine.Color> __GetDefaultBackgroundColor_0_0;
		static Action<UnityEngine.SystemLanguage> __NotifyLanguageChanged_0_1;
		static Func<System.Type,string, UnityEngine.Object> __GetBuiltinExtraResource_0_2;
	}
}

