/// UnityEditor.EditorGUILayout : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;
using UnityEngine;
using UnityObject = UnityEngine.Object;

namespace UnityReflection {
  public sealed partial class UnityEditorEditorGUILayout {
    
		public static bool FoldoutTitlebar( bool foldout, UnityEngine.GUIContent label, bool skipIconSpacing ) {
			if( __FoldoutTitlebar_0_3 == null ) {
				__FoldoutTitlebar_0_3 = (Func<bool,UnityEngine.GUIContent,bool, bool>) Delegate.CreateDelegate( typeof( Func<bool,UnityEngine.GUIContent,bool, bool> ), null, UnityTypes.UnityEditor_EditorGUILayout.GetMethod( "FoldoutTitlebar", R.StaticMembers, null, new Type[]{ typeof( bool ), typeof( UnityEngine.GUIContent ), typeof( bool ) }, null ) );
			}
			return __FoldoutTitlebar_0_3( foldout, label, skipIconSpacing );
		}
		
		public static bool FoldoutTitlebar( bool foldout, UnityEngine.GUIContent label, bool skipIconSpacing, UnityEngine.GUIStyle baseStyle, UnityEngine.GUIStyle textStyle ) {
			if( __FoldoutTitlebar_1_5 == null ) {
				__FoldoutTitlebar_1_5 = (Func<bool,UnityEngine.GUIContent,bool,UnityEngine.GUIStyle,UnityEngine.GUIStyle, bool>) Delegate.CreateDelegate( typeof( Func<bool,UnityEngine.GUIContent,bool,UnityEngine.GUIStyle,UnityEngine.GUIStyle, bool> ), null, UnityTypes.UnityEditor_EditorGUILayout.GetMethod( "FoldoutTitlebar", R.StaticMembers, null, new Type[]{ typeof( bool ), typeof( UnityEngine.GUIContent ), typeof( bool ), typeof( UnityEngine.GUIStyle ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __FoldoutTitlebar_1_5( foldout, label, skipIconSpacing, baseStyle, textStyle );
		}
		
		public static bool LinkLabel( string label, params UnityEngine.GUILayoutOption[] options ) {
			if( __LinkLabel_0_2 == null ) {
				__LinkLabel_0_2 = (Func<string,UnityEngine.GUILayoutOption[], bool>) Delegate.CreateDelegate( typeof( Func<string,UnityEngine.GUILayoutOption[], bool> ), null, UnityTypes.UnityEditor_EditorGUILayout.GetMethod( "LinkLabel", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( UnityEngine.GUILayoutOption[] ) }, null ) );
			}
			return __LinkLabel_0_2( label, options );
		}
		
		public static bool LinkLabel( UnityEngine.GUIContent label, params UnityEngine.GUILayoutOption[] options ) {
			if( __LinkLabel_1_2 == null ) {
				__LinkLabel_1_2 = (Func<UnityEngine.GUIContent,UnityEngine.GUILayoutOption[], bool>) Delegate.CreateDelegate( typeof( Func<UnityEngine.GUIContent,UnityEngine.GUILayoutOption[], bool> ), null, UnityTypes.UnityEditor_EditorGUILayout.GetMethod( "LinkLabel", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.GUIContent ), typeof( UnityEngine.GUILayoutOption[] ) }, null ) );
			}
			return __LinkLabel_1_2( label, options );
		}
		
		public static float PowerSlider( string label, float value, float leftValue, float rightValue, float power, params UnityEngine.GUILayoutOption[] options ) {
			if( __PowerSlider_0_6 == null ) {
				__PowerSlider_0_6 = (Func<string,float,float,float,float,UnityEngine.GUILayoutOption[], float>) Delegate.CreateDelegate( typeof( Func<string,float,float,float,float,UnityEngine.GUILayoutOption[], float> ), null, UnityTypes.UnityEditor_EditorGUILayout.GetMethod( "PowerSlider", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( float ), typeof( float ), typeof( float ), typeof( float ), typeof( UnityEngine.GUILayoutOption[] ) }, null ) );
			}
			return __PowerSlider_0_6( label, value, leftValue, rightValue, power, options );
		}
		
		public static float PowerSlider( UnityEngine.GUIContent label, float value, float leftValue, float rightValue, float power, params UnityEngine.GUILayoutOption[] options ) {
			if( __PowerSlider_1_6 == null ) {
				__PowerSlider_1_6 = (Func<UnityEngine.GUIContent,float,float,float,float,UnityEngine.GUILayoutOption[], float>) Delegate.CreateDelegate( typeof( Func<UnityEngine.GUIContent,float,float,float,float,UnityEngine.GUILayoutOption[], float> ), null, UnityTypes.UnityEditor_EditorGUILayout.GetMethod( "PowerSlider", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.GUIContent ), typeof( float ), typeof( float ), typeof( float ), typeof( float ), typeof( UnityEngine.GUILayoutOption[] ) }, null ) );
			}
			return __PowerSlider_1_6( label, value, leftValue, rightValue, power, options );
		}
		
		public static bool ToggleTitlebar( bool foldout, UnityEngine.GUIContent label, ref bool toggleValue ) {
			if( __ToggleTitlebar_0_3 == null ) {
				__ToggleTitlebar_0_3 = (Method_ToggleTitlebar_0_3) Delegate.CreateDelegate( typeof( Method_ToggleTitlebar_0_3 ), null, UnityTypes.UnityEditor_EditorGUILayout.GetMethod( "ToggleTitlebar", R.StaticMembers, null, new Type[]{ typeof( bool ), typeof( UnityEngine.GUIContent ), typeof( bool ).MakeByRefType() }, null ) );
			}
			return __ToggleTitlebar_0_3( foldout, label, ref toggleValue );
		}
		
		public static bool ToggleTitlebar( bool foldout, UnityEngine.GUIContent label, UnityEditor.SerializedProperty property ) {
			if( __ToggleTitlebar_1_3 == null ) {
				__ToggleTitlebar_1_3 = (Func<bool,UnityEngine.GUIContent,UnityEditor.SerializedProperty, bool>) Delegate.CreateDelegate( typeof( Func<bool,UnityEngine.GUIContent,UnityEditor.SerializedProperty, bool> ), null, UnityTypes.UnityEditor_EditorGUILayout.GetMethod( "ToggleTitlebar", R.StaticMembers, null, new Type[]{ typeof( bool ), typeof( UnityEngine.GUIContent ), typeof( UnityEditor.SerializedProperty ) }, null ) );
			}
			return __ToggleTitlebar_1_3( foldout, label, property );
		}
		
		public static string ToolbarSearchField( string text, params UnityEngine.GUILayoutOption[] options ) {
			if( __ToolbarSearchField_0_2 == null ) {
				__ToolbarSearchField_0_2 = (Func<string,UnityEngine.GUILayoutOption[], string>) Delegate.CreateDelegate( typeof( Func<string,UnityEngine.GUILayoutOption[], string> ), null, UnityTypes.UnityEditor_EditorGUILayout.GetMethod( "ToolbarSearchField", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( UnityEngine.GUILayoutOption[] ) }, null ) );
			}
			return __ToolbarSearchField_0_2( text, options );
		}
		
		public static string ToolbarSearchField( string text, string[] searchModes, ref int searchMode, params UnityEngine.GUILayoutOption[] options ) {
			if( __ToolbarSearchField_1_4 == null ) {
				__ToolbarSearchField_1_4 = (Method_ToolbarSearchField_1_4) Delegate.CreateDelegate( typeof( Method_ToolbarSearchField_1_4 ), null, UnityTypes.UnityEditor_EditorGUILayout.GetMethod( "ToolbarSearchField", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( string[] ), typeof( int ).MakeByRefType(), typeof( UnityEngine.GUILayoutOption[] ) }, null ) );
			}
			return __ToolbarSearchField_1_4( text, searchModes, ref searchMode, options );
		}
		
		
		
		static Func<bool,UnityEngine.GUIContent,bool, bool> __FoldoutTitlebar_0_3;
		static Func<bool,UnityEngine.GUIContent,bool,UnityEngine.GUIStyle,UnityEngine.GUIStyle, bool> __FoldoutTitlebar_1_5;
		static Func<string,UnityEngine.GUILayoutOption[], bool> __LinkLabel_0_2;
		static Func<UnityEngine.GUIContent,UnityEngine.GUILayoutOption[], bool> __LinkLabel_1_2;
		static Func<string,float,float,float,float,UnityEngine.GUILayoutOption[], float> __PowerSlider_0_6;
		static Func<UnityEngine.GUIContent,float,float,float,float,UnityEngine.GUILayoutOption[], float> __PowerSlider_1_6;
		delegate bool Method_ToggleTitlebar_0_3(  bool foldout, UnityEngine.GUIContent label, ref bool toggleValue  );
		static Method_ToggleTitlebar_0_3 __ToggleTitlebar_0_3;
		static Func<bool,UnityEngine.GUIContent,UnityEditor.SerializedProperty, bool> __ToggleTitlebar_1_3;
		static Func<string,UnityEngine.GUILayoutOption[], string> __ToolbarSearchField_0_2;
		delegate string Method_ToolbarSearchField_1_4(  string text, string[] searchModes, ref int searchMode, params UnityEngine.GUILayoutOption[] options  );
		static Method_ToolbarSearchField_1_4 __ToolbarSearchField_1_4;
	}
}

