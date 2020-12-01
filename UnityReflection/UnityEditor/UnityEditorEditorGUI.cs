/// UnityEditor.EditorGUI : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;
using UnityEngine;
using UnityObject = UnityEngine.Object;

namespace UnityReflection {
  public sealed partial class UnityEditorEditorGUI {
    
		public static string ToolbarSearchField( UnityEngine.Rect position, string text, bool showWithPopupArrow ) {
			if( __ToolbarSearchField_0_3 == null ) {
				__ToolbarSearchField_0_3 = (Func<UnityEngine.Rect,string,bool, string>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect,string,bool, string> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "ToolbarSearchField", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Rect ), typeof( string ), typeof( bool ) }, null ) );
			}
			return __ToolbarSearchField_0_3( position, text, showWithPopupArrow );
		}
		
		public static string ToolbarSearchField( int id, UnityEngine.Rect position, string text, bool showWithPopupArrow ) {
			if( __ToolbarSearchField_1_4 == null ) {
				__ToolbarSearchField_1_4 = (Func<int,UnityEngine.Rect,string,bool, string>) Delegate.CreateDelegate( typeof( Func<int,UnityEngine.Rect,string,bool, string> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "ToolbarSearchField", R.StaticMembers, null, new Type[]{ typeof( int ), typeof( UnityEngine.Rect ), typeof( string ), typeof( bool ) }, null ) );
			}
			return __ToolbarSearchField_1_4( id, position, text, showWithPopupArrow );
		}
		
		public static string ToolbarSearchField( UnityEngine.Rect position, string[] searchModes, ref int searchMode, string text ) {
			if( __ToolbarSearchField_2_4 == null ) {
				__ToolbarSearchField_2_4 = (Method_ToolbarSearchField_2_4) Delegate.CreateDelegate( typeof( Method_ToolbarSearchField_2_4 ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "ToolbarSearchField", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Rect ), typeof( string[] ), typeof( int ).MakeByRefType(), typeof( string ) }, null ) );
			}
			return __ToolbarSearchField_2_4( position, searchModes, ref searchMode, text );
		}
		
		public static string ToolbarSearchField( int id, UnityEngine.Rect position, string[] searchModes, ref int searchMode, string text ) {
			if( __ToolbarSearchField_3_5 == null ) {
				__ToolbarSearchField_3_5 = (Method_ToolbarSearchField_3_5) Delegate.CreateDelegate( typeof( Method_ToolbarSearchField_3_5 ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "ToolbarSearchField", R.StaticMembers, null, new Type[]{ typeof( int ), typeof( UnityEngine.Rect ), typeof( string[] ), typeof( int ).MakeByRefType(), typeof( string ) }, null ) );
			}
			return __ToolbarSearchField_3_5( id, position, searchModes, ref searchMode, text );
		}
		
		public static void PingObjectOrShowPreviewOnClick( UnityObject targetObject, UnityEngine.Rect position ) {
			if( __PingObjectOrShowPreviewOnClick_0_2 == null ) {
				__PingObjectOrShowPreviewOnClick_0_2 = (Action<UnityObject,UnityEngine.Rect>) Delegate.CreateDelegate( typeof( Action<UnityObject,UnityEngine.Rect> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "PingObjectOrShowPreviewOnClick", R.StaticMembers, null, new Type[]{ typeof( UnityObject ), typeof( UnityEngine.Rect ) }, null ) );
			}
			__PingObjectOrShowPreviewOnClick_0_2( targetObject, position );
		}
		
		public static bool FoldoutTitlebar( UnityEngine.Rect position, UnityEngine.GUIContent label, bool foldout, bool skipIconSpacing ) {
			if( __FoldoutTitlebar_0_4 == null ) {
				__FoldoutTitlebar_0_4 = (Func<UnityEngine.Rect,UnityEngine.GUIContent,bool,bool, bool>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect,UnityEngine.GUIContent,bool,bool, bool> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "FoldoutTitlebar", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( bool ), typeof( bool ) }, null ) );
			}
			return __FoldoutTitlebar_0_4( position, label, foldout, skipIconSpacing );
		}
		
		public static bool FoldoutTitlebar( UnityEngine.Rect position, UnityEngine.GUIContent label, bool foldout, bool skipIconSpacing, UnityEngine.GUIStyle baseStyle, UnityEngine.GUIStyle textStyle ) {
			if( __FoldoutTitlebar_1_6 == null ) {
				__FoldoutTitlebar_1_6 = (Func<UnityEngine.Rect,UnityEngine.GUIContent,bool,bool,UnityEngine.GUIStyle,UnityEngine.GUIStyle, bool>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect,UnityEngine.GUIContent,bool,bool,UnityEngine.GUIStyle,UnityEngine.GUIStyle, bool> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "FoldoutTitlebar", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( bool ), typeof( bool ), typeof( UnityEngine.GUIStyle ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __FoldoutTitlebar_1_6( position, label, foldout, skipIconSpacing, baseStyle, textStyle );
		}
		
		public static bool ButtonWithDropdownList( string buttonName, string[] buttonNames, UnityEditor.GenericMenu.MenuFunction2 callback, params UnityEngine.GUILayoutOption[] options ) {
			if( __ButtonWithDropdownList_0_4 == null ) {
				__ButtonWithDropdownList_0_4 = (Func<string,string[],UnityEditor.GenericMenu.MenuFunction2,UnityEngine.GUILayoutOption[], bool>) Delegate.CreateDelegate( typeof( Func<string,string[],UnityEditor.GenericMenu.MenuFunction2,UnityEngine.GUILayoutOption[], bool> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "ButtonWithDropdownList", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( string[] ), typeof( UnityEditor.GenericMenu.MenuFunction2 ), typeof( UnityEngine.GUILayoutOption[] ) }, null ) );
			}
			return __ButtonWithDropdownList_0_4( buttonName, buttonNames, callback, options );
		}
		
		public static bool ButtonWithDropdownList( UnityEngine.GUIContent content, string[] buttonNames, UnityEditor.GenericMenu.MenuFunction2 callback, params UnityEngine.GUILayoutOption[] options ) {
			if( __ButtonWithDropdownList_1_4 == null ) {
				__ButtonWithDropdownList_1_4 = (Func<UnityEngine.GUIContent,string[],UnityEditor.GenericMenu.MenuFunction2,UnityEngine.GUILayoutOption[], bool>) Delegate.CreateDelegate( typeof( Func<UnityEngine.GUIContent,string[],UnityEditor.GenericMenu.MenuFunction2,UnityEngine.GUILayoutOption[], bool> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "ButtonWithDropdownList", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.GUIContent ), typeof( string[] ), typeof( UnityEditor.GenericMenu.MenuFunction2 ), typeof( UnityEngine.GUILayoutOption[] ) }, null ) );
			}
			return __ButtonWithDropdownList_1_4( content, buttonNames, callback, options );
		}
		
		
		
		static Func<UnityEngine.Rect,string,bool, string> __ToolbarSearchField_0_3;
		static Func<int,UnityEngine.Rect,string,bool, string> __ToolbarSearchField_1_4;
		delegate string Method_ToolbarSearchField_2_4(  UnityEngine.Rect position, string[] searchModes, ref int searchMode, string text  );
		static Method_ToolbarSearchField_2_4 __ToolbarSearchField_2_4;
		delegate string Method_ToolbarSearchField_3_5(  int id, UnityEngine.Rect position, string[] searchModes, ref int searchMode, string text  );
		static Method_ToolbarSearchField_3_5 __ToolbarSearchField_3_5;
		static Action<UnityObject,UnityEngine.Rect> __PingObjectOrShowPreviewOnClick_0_2;
		static Func<UnityEngine.Rect,UnityEngine.GUIContent,bool,bool, bool> __FoldoutTitlebar_0_4;
		static Func<UnityEngine.Rect,UnityEngine.GUIContent,bool,bool,UnityEngine.GUIStyle,UnityEngine.GUIStyle, bool> __FoldoutTitlebar_1_6;
		static Func<string,string[],UnityEditor.GenericMenu.MenuFunction2,UnityEngine.GUILayoutOption[], bool> __ButtonWithDropdownList_0_4;
		static Func<UnityEngine.GUIContent,string[],UnityEditor.GenericMenu.MenuFunction2,UnityEngine.GUILayoutOption[], bool> __ButtonWithDropdownList_1_4;
	}
}

