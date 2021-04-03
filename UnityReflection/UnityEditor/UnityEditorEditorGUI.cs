/// UnityEditor.EditorGUI : 2020.3.0f1

using HananokiEditor;
using System;
using System.Reflection;
using UnityEngine;
using UnityObject = UnityEngine.Object;

namespace UnityReflection {
	public sealed partial class UnityEditorEditorGUI {

		public static class Cache<T> {
			public static T cache;
		}

		public static string ToolbarSearchField( UnityEngine.Rect position, string text, bool showWithPopupArrow ) {
			if( __ToolbarSearchField_0_3 == null ) {
				__ToolbarSearchField_0_3 = (Func<UnityEngine.Rect, string, bool, string>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, string, bool, string> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "ToolbarSearchField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( string ), typeof( bool ) }, null ) );
			}
			return __ToolbarSearchField_0_3( position, text, showWithPopupArrow );
		}

		public static string ToolbarSearchField( int id, UnityEngine.Rect position, string text, bool showWithPopupArrow ) {
			if( __ToolbarSearchField_1_4 == null ) {
				__ToolbarSearchField_1_4 = (Func<int, UnityEngine.Rect, string, bool, string>) Delegate.CreateDelegate( typeof( Func<int, UnityEngine.Rect, string, bool, string> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "ToolbarSearchField", R.StaticMembers, null, new Type[] { typeof( int ), typeof( UnityEngine.Rect ), typeof( string ), typeof( bool ) }, null ) );
			}
			return __ToolbarSearchField_1_4( id, position, text, showWithPopupArrow );
		}

		public static string ToolbarSearchField( UnityEngine.Rect position, string[] searchModes, ref int searchMode, string text ) {
			if( __ToolbarSearchField_2_4 == null ) {
				__ToolbarSearchField_2_4 = (Method_ToolbarSearchField_2_4) Delegate.CreateDelegate( typeof( Method_ToolbarSearchField_2_4 ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "ToolbarSearchField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( string[] ), typeof( int ).MakeByRefType(), typeof( string ) }, null ) );
			}
			return __ToolbarSearchField_2_4( position, searchModes, ref searchMode, text );
		}

		public static string ToolbarSearchField( int id, UnityEngine.Rect position, string[] searchModes, ref int searchMode, string text ) {
			if( __ToolbarSearchField_3_5 == null ) {
				__ToolbarSearchField_3_5 = (Method_ToolbarSearchField_3_5) Delegate.CreateDelegate( typeof( Method_ToolbarSearchField_3_5 ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "ToolbarSearchField", R.StaticMembers, null, new Type[] { typeof( int ), typeof( UnityEngine.Rect ), typeof( string[] ), typeof( int ).MakeByRefType(), typeof( string ) }, null ) );
			}
			return __ToolbarSearchField_3_5( id, position, searchModes, ref searchMode, text );
		}

		public static void PingObjectOrShowPreviewOnClick( UnityObject targetObject, UnityEngine.Rect position ) {
			if( __PingObjectOrShowPreviewOnClick_0_2 == null ) {
				__PingObjectOrShowPreviewOnClick_0_2 = (Action<UnityObject, UnityEngine.Rect>) Delegate.CreateDelegate( typeof( Action<UnityObject, UnityEngine.Rect> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "PingObjectOrShowPreviewOnClick", R.StaticMembers, null, new Type[] { typeof( UnityObject ), typeof( UnityEngine.Rect ) }, null ) );
			}
			__PingObjectOrShowPreviewOnClick_0_2( targetObject, position );
		}

		public static bool FoldoutTitlebar( UnityEngine.Rect position, UnityEngine.GUIContent label, bool foldout, bool skipIconSpacing ) {
			if( __FoldoutTitlebar_0_4 == null ) {
				__FoldoutTitlebar_0_4 = (Func<UnityEngine.Rect, UnityEngine.GUIContent, bool, bool, bool>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, UnityEngine.GUIContent, bool, bool, bool> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "FoldoutTitlebar", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( bool ), typeof( bool ) }, null ) );
			}
			return __FoldoutTitlebar_0_4( position, label, foldout, skipIconSpacing );
		}

		public static bool FoldoutTitlebar( UnityEngine.Rect position, UnityEngine.GUIContent label, bool foldout, bool skipIconSpacing, UnityEngine.GUIStyle baseStyle, UnityEngine.GUIStyle textStyle ) {
			if( __FoldoutTitlebar_1_6 == null ) {
				__FoldoutTitlebar_1_6 = (Func<UnityEngine.Rect, UnityEngine.GUIContent, bool, bool, UnityEngine.GUIStyle, UnityEngine.GUIStyle, bool>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, UnityEngine.GUIContent, bool, bool, UnityEngine.GUIStyle, UnityEngine.GUIStyle, bool> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "FoldoutTitlebar", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( bool ), typeof( bool ), typeof( UnityEngine.GUIStyle ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __FoldoutTitlebar_1_6( position, label, foldout, skipIconSpacing, baseStyle, textStyle );
		}

		public static bool ButtonWithDropdownList( string buttonName, string[] buttonNames, UnityEditor.GenericMenu.MenuFunction2 callback, params UnityEngine.GUILayoutOption[] options ) {
			if( __ButtonWithDropdownList_0_4 == null ) {
				__ButtonWithDropdownList_0_4 = (Func<string, string[], UnityEditor.GenericMenu.MenuFunction2, UnityEngine.GUILayoutOption[], bool>) Delegate.CreateDelegate( typeof( Func<string, string[], UnityEditor.GenericMenu.MenuFunction2, UnityEngine.GUILayoutOption[], bool> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "ButtonWithDropdownList", R.StaticMembers, null, new Type[] { typeof( string ), typeof( string[] ), typeof( UnityEditor.GenericMenu.MenuFunction2 ), typeof( UnityEngine.GUILayoutOption[] ) }, null ) );
			}
			return __ButtonWithDropdownList_0_4( buttonName, buttonNames, callback, options );
		}

		public static bool ButtonWithDropdownList( UnityEngine.GUIContent content, string[] buttonNames, UnityEditor.GenericMenu.MenuFunction2 callback, params UnityEngine.GUILayoutOption[] options ) {
			if( __ButtonWithDropdownList_1_4 == null ) {
				__ButtonWithDropdownList_1_4 = (Func<UnityEngine.GUIContent, string[], UnityEditor.GenericMenu.MenuFunction2, UnityEngine.GUILayoutOption[], bool>) Delegate.CreateDelegate( typeof( Func<UnityEngine.GUIContent, string[], UnityEditor.GenericMenu.MenuFunction2, UnityEngine.GUILayoutOption[], bool> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "ButtonWithDropdownList", R.StaticMembers, null, new Type[] { typeof( UnityEngine.GUIContent ), typeof( string[] ), typeof( UnityEditor.GenericMenu.MenuFunction2 ), typeof( UnityEngine.GUILayoutOption[] ) }, null ) );
			}
			return __ButtonWithDropdownList_1_4( content, buttonNames, callback, options );
		}

		public static float CalcPrefixLabelWidth( UnityEngine.GUIContent label, UnityEngine.GUIStyle style = null ) {
			if( __CalcPrefixLabelWidth_0_2 == null ) {
				__CalcPrefixLabelWidth_0_2 = (Func<UnityEngine.GUIContent, UnityEngine.GUIStyle, float>) Delegate.CreateDelegate( typeof( Func<UnityEngine.GUIContent, UnityEngine.GUIStyle, float> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "CalcPrefixLabelWidth", R.StaticMembers, null, new Type[] { typeof( UnityEngine.GUIContent ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __CalcPrefixLabelWidth_0_2( label, style );
		}

		public static System.Enum EnumFlagsField( UnityEngine.Rect position, System.Enum enumValue ) {
			if( __EnumFlagsField_0_2 == null ) {
				__EnumFlagsField_0_2 = (Func<UnityEngine.Rect, System.Enum, System.Enum>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, System.Enum, System.Enum> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "EnumFlagsField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( System.Enum ) }, null ) );
			}
			return __EnumFlagsField_0_2( position, enumValue );
		}

		public static System.Enum EnumFlagsField( UnityEngine.Rect position, System.Enum enumValue, UnityEngine.GUIStyle style ) {
			if( __EnumFlagsField_1_3 == null ) {
				__EnumFlagsField_1_3 = (Func<UnityEngine.Rect, System.Enum, UnityEngine.GUIStyle, System.Enum>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, System.Enum, UnityEngine.GUIStyle, System.Enum> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "EnumFlagsField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( System.Enum ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __EnumFlagsField_1_3( position, enumValue, style );
		}

		public static System.Enum EnumFlagsField( UnityEngine.Rect position, string label, System.Enum enumValue ) {
			if( __EnumFlagsField_2_3 == null ) {
				__EnumFlagsField_2_3 = (Func<UnityEngine.Rect, string, System.Enum, System.Enum>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, string, System.Enum, System.Enum> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "EnumFlagsField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( string ), typeof( System.Enum ) }, null ) );
			}
			return __EnumFlagsField_2_3( position, label, enumValue );
		}

		public static System.Enum EnumFlagsField( UnityEngine.Rect position, string label, System.Enum enumValue, UnityEngine.GUIStyle style ) {
			if( __EnumFlagsField_3_4 == null ) {
				__EnumFlagsField_3_4 = (Func<UnityEngine.Rect, string, System.Enum, UnityEngine.GUIStyle, System.Enum>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, string, System.Enum, UnityEngine.GUIStyle, System.Enum> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "EnumFlagsField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( string ), typeof( System.Enum ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __EnumFlagsField_3_4( position, label, enumValue, style );
		}

		public static System.Enum EnumFlagsField( UnityEngine.Rect position, UnityEngine.GUIContent label, System.Enum enumValue ) {
			if( __EnumFlagsField_4_3 == null ) {
				__EnumFlagsField_4_3 = (Func<UnityEngine.Rect, UnityEngine.GUIContent, System.Enum, System.Enum>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, UnityEngine.GUIContent, System.Enum, System.Enum> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "EnumFlagsField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( System.Enum ) }, null ) );
			}
			return __EnumFlagsField_4_3( position, label, enumValue );
		}

		public static System.Enum EnumFlagsField( UnityEngine.Rect position, UnityEngine.GUIContent label, System.Enum enumValue, UnityEngine.GUIStyle style ) {
			if( __EnumFlagsField_5_4 == null ) {
				__EnumFlagsField_5_4 = (Func<UnityEngine.Rect, UnityEngine.GUIContent, System.Enum, UnityEngine.GUIStyle, System.Enum>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, UnityEngine.GUIContent, System.Enum, UnityEngine.GUIStyle, System.Enum> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "EnumFlagsField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( System.Enum ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __EnumFlagsField_5_4( position, label, enumValue, style );
		}

		public static System.Enum EnumFlagsField( UnityEngine.Rect position, UnityEngine.GUIContent label, System.Enum enumValue, bool includeObsolete, UnityEngine.GUIStyle style = null ) {
			if( __EnumFlagsField_6_5 == null ) {
				__EnumFlagsField_6_5 = (Func<UnityEngine.Rect, UnityEngine.GUIContent, System.Enum, bool, UnityEngine.GUIStyle, System.Enum>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, UnityEngine.GUIContent, System.Enum, bool, UnityEngine.GUIStyle, System.Enum> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "EnumFlagsField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( System.Enum ), typeof( bool ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __EnumFlagsField_6_5( position, label, enumValue, includeObsolete, style );
		}

		public static System.Enum EnumFlagsField( UnityEngine.Rect position, UnityEngine.GUIContent label, System.Enum enumValue, bool includeObsolete, ref int changedFlags, ref bool changedToValue, UnityEngine.GUIStyle style ) {
			if( __EnumFlagsField_7_7 == null ) {
				__EnumFlagsField_7_7 = (Method_EnumFlagsField_7_7) Delegate.CreateDelegate( typeof( Method_EnumFlagsField_7_7 ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "EnumFlagsField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( System.Enum ), typeof( bool ), typeof( int ).MakeByRefType(), typeof( bool ).MakeByRefType(), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __EnumFlagsField_7_7( position, label, enumValue, includeObsolete, ref changedFlags, ref changedToValue, style );
		}

		public static System.Enum EnumFlagsField( UnityEngine.Rect position, UnityEngine.GUIContent label, System.Enum enumValue, System.Type enumType, bool includeObsolete, ref int changedFlags, ref bool changedToValue, UnityEngine.GUIStyle style ) {
			if( __EnumFlagsField_8_8 == null ) {
				__EnumFlagsField_8_8 = (Method_EnumFlagsField_8_8) Delegate.CreateDelegate( typeof( Method_EnumFlagsField_8_8 ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "EnumFlagsField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( System.Enum ), typeof( System.Type ), typeof( bool ), typeof( int ).MakeByRefType(), typeof( bool ).MakeByRefType(), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __EnumFlagsField_8_8( position, label, enumValue, enumType, includeObsolete, ref changedFlags, ref changedToValue, style );
		}

		public static int EnumFlagsField( UnityEngine.Rect position, UnityEngine.GUIContent label, int enumValue, System.Type enumType, bool includeObsolete, UnityEngine.GUIStyle style ) {
			if( __EnumFlagsField_9_6 == null ) {
				__EnumFlagsField_9_6 = (Func<UnityEngine.Rect, UnityEngine.GUIContent, int, System.Type, bool, UnityEngine.GUIStyle, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, UnityEngine.GUIContent, int, System.Type, bool, UnityEngine.GUIStyle, int> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "EnumFlagsField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( int ), typeof( System.Type ), typeof( bool ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __EnumFlagsField_9_6( position, label, enumValue, enumType, includeObsolete, style );
		}

		public static UnityEngine.Color DoColorField( UnityEngine.Rect position, int id, UnityEngine.Color value, bool showEyedropper, bool showAlpha, bool hdr ) {
			if( __DoColorField_0_6 == null ) {
				__DoColorField_0_6 = (Func<UnityEngine.Rect, int, UnityEngine.Color, bool, bool, bool, UnityEngine.Color>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, int, UnityEngine.Color, bool, bool, bool, UnityEngine.Color> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "DoColorField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( int ), typeof( UnityEngine.Color ), typeof( bool ), typeof( bool ), typeof( bool ) }, null ) );
			}
			return __DoColorField_0_6( position, id, value, showEyedropper, showAlpha, hdr );
		}

		public static UnityObject DoObjectField( UnityEngine.Rect position, UnityEngine.Rect dropRect, int id, UnityObject obj, UnityObject objBeingEdited, System.Type objType, object validator, bool allowSceneObjects, UnityEngine.GUIStyle style = null ) {
			if( __DoObjectField_0_9 == null ) {
				__DoObjectField_0_9 = UnityTypes.UnityEditor_EditorGUI.GetMethod( "DoObjectField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.Rect ), typeof( int ), typeof( UnityObject ), typeof( UnityObject ), typeof( System.Type ), UnityTypes.UnityEditor_EditorGUI_ObjectFieldValidator, typeof( bool ), typeof( UnityEngine.GUIStyle ) }, null );
			}
			return (UnityObject) __DoObjectField_0_9.Invoke( null, new object[] { position, dropRect, id, obj, objBeingEdited, objType, validator, allowSceneObjects, style } );
		}

		public static UnityObject DoObjectField( UnityEngine.Rect position, UnityEngine.Rect dropRect, int id, System.Type objType, UnityEditor.SerializedProperty property, object validator, bool allowSceneObjects, UnityEngine.GUIStyle style = null ) {
			if( __DoObjectField_1_8 == null ) {
				__DoObjectField_1_8 = UnityTypes.UnityEditor_EditorGUI.GetMethod( "DoObjectField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.Rect ), typeof( int ), typeof( System.Type ), typeof( UnityEditor.SerializedProperty ), UnityTypes.UnityEditor_EditorGUI_ObjectFieldValidator, typeof( bool ), typeof( UnityEngine.GUIStyle ) }, null );
			}
			return (UnityObject) __DoObjectField_1_8.Invoke( null, new object[] { position, dropRect, id, objType, property, validator, allowSceneObjects, style } );
		}

		public static UnityObject DoObjectField( UnityEngine.Rect position, UnityEngine.Rect dropRect, int id, UnityObject obj, System.Type objType, UnityEditor.SerializedProperty property, object validator, bool allowSceneObjects, UnityEngine.GUIStyle style ) {
			if( __DoObjectField_2_9 == null ) {
				__DoObjectField_2_9 = UnityTypes.UnityEditor_EditorGUI.GetMethod( "DoObjectField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.Rect ), typeof( int ), typeof( UnityObject ), typeof( System.Type ), typeof( UnityEditor.SerializedProperty ), UnityTypes.UnityEditor_EditorGUI_ObjectFieldValidator, typeof( bool ), typeof( UnityEngine.GUIStyle ) }, null );
			}
			return (UnityObject) __DoObjectField_2_9.Invoke( null, new object[] { position, dropRect, id, obj, objType, property, validator, allowSceneObjects, style } );
		}

		public static UnityObject DoObjectField( UnityEngine.Rect position, UnityEngine.Rect dropRect, int id, UnityObject obj, UnityObject objBeingEdited, System.Type objType, UnityEditor.SerializedProperty property, object validator, bool allowSceneObjects, UnityEngine.GUIStyle style ) {
			if( __DoObjectField_3_10 == null ) {
				__DoObjectField_3_10 = UnityTypes.UnityEditor_EditorGUI.GetMethod( "DoObjectField", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.Rect ), typeof( int ), typeof( UnityObject ), typeof( UnityObject ), typeof( System.Type ), typeof( UnityEditor.SerializedProperty ), UnityTypes.UnityEditor_EditorGUI_ObjectFieldValidator, typeof( bool ), typeof( UnityEngine.GUIStyle ) }, null );
			}
			return (UnityObject) __DoObjectField_3_10.Invoke( null, new object[] { position, dropRect, id, obj, objBeingEdited, objType, property, validator, allowSceneObjects, style } );
		}

		public static int Popup( UnityEngine.Rect position, UnityEngine.GUIContent label, int selectedIndex, string[] displayedOptions, UnityEngine.GUIStyle style ) {
			if( __Popup_0_5 == null ) {
				__Popup_0_5 = (Func<UnityEngine.Rect, UnityEngine.GUIContent, int, string[], UnityEngine.GUIStyle, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, UnityEngine.GUIContent, int, string[], UnityEngine.GUIStyle, int> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "Popup", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( int ), typeof( string[] ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __Popup_0_5( position, label, selectedIndex, displayedOptions, style );
		}

		public static int Popup( UnityEngine.Rect position, UnityEngine.GUIContent label, int selectedIndex, string[] displayedOptions ) {
			if( __Popup_1_4 == null ) {
				__Popup_1_4 = (Func<UnityEngine.Rect, UnityEngine.GUIContent, int, string[], int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, UnityEngine.GUIContent, int, string[], int> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "Popup", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( int ), typeof( string[] ) }, null ) );
			}
			return __Popup_1_4( position, label, selectedIndex, displayedOptions );
		}

		public static void Popup( UnityEngine.Rect position, UnityEditor.SerializedProperty property, UnityEngine.GUIContent label ) {
			if( __Popup_2_3 == null ) {
				__Popup_2_3 = (Action<UnityEngine.Rect, UnityEditor.SerializedProperty, UnityEngine.GUIContent>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Rect, UnityEditor.SerializedProperty, UnityEngine.GUIContent> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "Popup", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEditor.SerializedProperty ), typeof( UnityEngine.GUIContent ) }, null ) );
			}
			__Popup_2_3( position, property, label );
		}

		public static void Popup( UnityEngine.Rect position, UnityEditor.SerializedProperty property, UnityEngine.GUIContent[] displayedOptions, UnityEngine.GUIContent label ) {
			if( __Popup_3_4 == null ) {
				__Popup_3_4 = (Action<UnityEngine.Rect, UnityEditor.SerializedProperty, UnityEngine.GUIContent[], UnityEngine.GUIContent>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Rect, UnityEditor.SerializedProperty, UnityEngine.GUIContent[], UnityEngine.GUIContent> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "Popup", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEditor.SerializedProperty ), typeof( UnityEngine.GUIContent[] ), typeof( UnityEngine.GUIContent ) }, null ) );
			}
			__Popup_3_4( position, property, displayedOptions, label );
		}

		public static int Popup( UnityEngine.Rect position, int selectedIndex, string[] displayedOptions ) {
			if( __Popup_4_3 == null ) {
				__Popup_4_3 = (Func<UnityEngine.Rect, int, string[], int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, int, string[], int> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "Popup", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( int ), typeof( string[] ) }, null ) );
			}
			return __Popup_4_3( position, selectedIndex, displayedOptions );
		}

		public static int Popup( UnityEngine.Rect position, int selectedIndex, string[] displayedOptions, UnityEngine.GUIStyle style ) {
			if( __Popup_5_4 == null ) {
				__Popup_5_4 = (Func<UnityEngine.Rect, int, string[], UnityEngine.GUIStyle, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, int, string[], UnityEngine.GUIStyle, int> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "Popup", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( int ), typeof( string[] ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __Popup_5_4( position, selectedIndex, displayedOptions, style );
		}

		public static int Popup( UnityEngine.Rect position, int selectedIndex, UnityEngine.GUIContent[] displayedOptions ) {
			if( __Popup_6_3 == null ) {
				__Popup_6_3 = (Func<UnityEngine.Rect, int, UnityEngine.GUIContent[], int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, int, UnityEngine.GUIContent[], int> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "Popup", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( int ), typeof( UnityEngine.GUIContent[] ) }, null ) );
			}
			return __Popup_6_3( position, selectedIndex, displayedOptions );
		}

		public static int Popup( UnityEngine.Rect position, int selectedIndex, UnityEngine.GUIContent[] displayedOptions, UnityEngine.GUIStyle style ) {
			if( __Popup_7_4 == null ) {
				__Popup_7_4 = (Func<UnityEngine.Rect, int, UnityEngine.GUIContent[], UnityEngine.GUIStyle, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, int, UnityEngine.GUIContent[], UnityEngine.GUIStyle, int> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "Popup", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( int ), typeof( UnityEngine.GUIContent[] ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __Popup_7_4( position, selectedIndex, displayedOptions, style );
		}

		public static int Popup( UnityEngine.Rect position, string label, int selectedIndex, string[] displayedOptions ) {
			if( __Popup_8_4 == null ) {
				__Popup_8_4 = (Func<UnityEngine.Rect, string, int, string[], int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, string, int, string[], int> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "Popup", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( string ), typeof( int ), typeof( string[] ) }, null ) );
			}
			return __Popup_8_4( position, label, selectedIndex, displayedOptions );
		}

		public static int Popup( UnityEngine.Rect position, string label, int selectedIndex, string[] displayedOptions, UnityEngine.GUIStyle style ) {
			if( __Popup_9_5 == null ) {
				__Popup_9_5 = (Func<UnityEngine.Rect, string, int, string[], UnityEngine.GUIStyle, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, string, int, string[], UnityEngine.GUIStyle, int> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "Popup", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( string ), typeof( int ), typeof( string[] ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __Popup_9_5( position, label, selectedIndex, displayedOptions, style );
		}

		public static int Popup( UnityEngine.Rect position, UnityEngine.GUIContent label, int selectedIndex, UnityEngine.GUIContent[] displayedOptions ) {
			if( __Popup_10_4 == null ) {
				__Popup_10_4 = (Func<UnityEngine.Rect, UnityEngine.GUIContent, int, UnityEngine.GUIContent[], int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, UnityEngine.GUIContent, int, UnityEngine.GUIContent[], int> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "Popup", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( int ), typeof( UnityEngine.GUIContent[] ) }, null ) );
			}
			return __Popup_10_4( position, label, selectedIndex, displayedOptions );
		}

		public static int Popup( UnityEngine.Rect position, UnityEngine.GUIContent label, int selectedIndex, UnityEngine.GUIContent[] displayedOptions, UnityEngine.GUIStyle style ) {
			if( __Popup_11_5 == null ) {
				__Popup_11_5 = (Func<UnityEngine.Rect, UnityEngine.GUIContent, int, UnityEngine.GUIContent[], UnityEngine.GUIStyle, int>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect, UnityEngine.GUIContent, int, UnityEngine.GUIContent[], UnityEngine.GUIStyle, int> ), null, UnityTypes.UnityEditor_EditorGUI.GetMethod( "Popup", R.StaticMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIContent ), typeof( int ), typeof( UnityEngine.GUIContent[] ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			return __Popup_11_5( position, label, selectedIndex, displayedOptions, style );
		}



		static Func<UnityEngine.Rect,string,bool, string> __ToolbarSearchField_0_3;
		static Func<int,UnityEngine.Rect,string,bool, string> __ToolbarSearchField_1_4;
		delegate string Method_ToolbarSearchField_2_4( UnityEngine.Rect position, string[] searchModes, ref int searchMode, string text );
		static Method_ToolbarSearchField_2_4 __ToolbarSearchField_2_4;
		delegate string Method_ToolbarSearchField_3_5( int id, UnityEngine.Rect position, string[] searchModes, ref int searchMode, string text );
		static Method_ToolbarSearchField_3_5 __ToolbarSearchField_3_5;
		static Action<UnityObject,UnityEngine.Rect> __PingObjectOrShowPreviewOnClick_0_2;
		static Func<UnityEngine.Rect,UnityEngine.GUIContent,bool,bool, bool> __FoldoutTitlebar_0_4;
		static Func<UnityEngine.Rect,UnityEngine.GUIContent,bool,bool,UnityEngine.GUIStyle,UnityEngine.GUIStyle, bool> __FoldoutTitlebar_1_6;
		static Func<string,string[],UnityEditor.GenericMenu.MenuFunction2,UnityEngine.GUILayoutOption[], bool> __ButtonWithDropdownList_0_4;
		static Func<UnityEngine.GUIContent,string[],UnityEditor.GenericMenu.MenuFunction2,UnityEngine.GUILayoutOption[], bool> __ButtonWithDropdownList_1_4;
		static Func<UnityEngine.GUIContent,UnityEngine.GUIStyle, float> __CalcPrefixLabelWidth_0_2;
		static Func<UnityEngine.Rect,System.Enum, System.Enum> __EnumFlagsField_0_2;
		static Func<UnityEngine.Rect,System.Enum,UnityEngine.GUIStyle, System.Enum> __EnumFlagsField_1_3;
		static Func<UnityEngine.Rect,string,System.Enum, System.Enum> __EnumFlagsField_2_3;
		static Func<UnityEngine.Rect,string,System.Enum,UnityEngine.GUIStyle, System.Enum> __EnumFlagsField_3_4;
		static Func<UnityEngine.Rect,UnityEngine.GUIContent,System.Enum, System.Enum> __EnumFlagsField_4_3;
		static Func<UnityEngine.Rect,UnityEngine.GUIContent,System.Enum,UnityEngine.GUIStyle, System.Enum> __EnumFlagsField_5_4;
		static Func<UnityEngine.Rect,UnityEngine.GUIContent,System.Enum,bool,UnityEngine.GUIStyle, System.Enum> __EnumFlagsField_6_5;
		delegate System.Enum Method_EnumFlagsField_7_7( UnityEngine.Rect position, UnityEngine.GUIContent label, System.Enum enumValue, bool includeObsolete, ref int changedFlags, ref bool changedToValue, UnityEngine.GUIStyle style );
		static Method_EnumFlagsField_7_7 __EnumFlagsField_7_7;
		delegate System.Enum Method_EnumFlagsField_8_8( UnityEngine.Rect position, UnityEngine.GUIContent label, System.Enum enumValue, System.Type enumType, bool includeObsolete, ref int changedFlags, ref bool changedToValue, UnityEngine.GUIStyle style );
		static Method_EnumFlagsField_8_8 __EnumFlagsField_8_8;
		static Func<UnityEngine.Rect,UnityEngine.GUIContent,int,System.Type,bool,UnityEngine.GUIStyle, int> __EnumFlagsField_9_6;
		static Func<UnityEngine.Rect,int,UnityEngine.Color,bool,bool,bool, UnityEngine.Color> __DoColorField_0_6;
		static MethodInfo __DoObjectField_0_9;
		static MethodInfo __DoObjectField_1_8;
		static MethodInfo __DoObjectField_2_9;
		static MethodInfo __DoObjectField_3_10;
		static Func<UnityEngine.Rect,UnityEngine.GUIContent,int,string[],UnityEngine.GUIStyle, int> __Popup_0_5;
		static Func<UnityEngine.Rect,UnityEngine.GUIContent,int,string[], int> __Popup_1_4;
		static Action<UnityEngine.Rect,UnityEditor.SerializedProperty,UnityEngine.GUIContent> __Popup_2_3;
		static Action<UnityEngine.Rect,UnityEditor.SerializedProperty,UnityEngine.GUIContent[],UnityEngine.GUIContent> __Popup_3_4;
		static Func<UnityEngine.Rect,int,string[], int> __Popup_4_3;
		static Func<UnityEngine.Rect,int,string[],UnityEngine.GUIStyle, int> __Popup_5_4;
		static Func<UnityEngine.Rect,int,UnityEngine.GUIContent[], int> __Popup_6_3;
		static Func<UnityEngine.Rect,int,UnityEngine.GUIContent[],UnityEngine.GUIStyle, int> __Popup_7_4;
		static Func<UnityEngine.Rect,string,int,string[], int> __Popup_8_4;
		static Func<UnityEngine.Rect,string,int,string[],UnityEngine.GUIStyle, int> __Popup_9_5;
		static Func<UnityEngine.Rect,UnityEngine.GUIContent,int,UnityEngine.GUIContent[], int> __Popup_10_4;
		static Func<UnityEngine.Rect,UnityEngine.GUIContent,int,UnityEngine.GUIContent[],UnityEngine.GUIStyle, int> __Popup_11_5;
	}
}

