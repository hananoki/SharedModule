/// UnityEditor.RectTransformEditor : 2019.4.5f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorRectTransformEditor {
    
		public static void SetAnchorSmart( UnityEngine.RectTransform rect, float value, int axis, bool isMax, bool smart ) {
			if( __SetAnchorSmart_0_5 == null ) {
				__SetAnchorSmart_0_5 = (Action<UnityEngine.RectTransform,float,int,bool,bool>) Delegate.CreateDelegate( typeof( Action<UnityEngine.RectTransform,float,int,bool,bool> ), null, UnityTypes.UnityEditor_RectTransformEditor.GetMethod( "SetAnchorSmart", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.RectTransform ), typeof( float ), typeof( int ), typeof( bool ), typeof( bool ) }, null ) );
			}
			__SetAnchorSmart_0_5( rect, value, axis, isMax, smart );
		}
		
		public static void SetAnchorSmart( UnityEngine.RectTransform rect, float value, int axis, bool isMax, bool smart, bool enforceExactValue ) {
			if( __SetAnchorSmart_1_6 == null ) {
				__SetAnchorSmart_1_6 = (Action<UnityEngine.RectTransform,float,int,bool,bool,bool>) Delegate.CreateDelegate( typeof( Action<UnityEngine.RectTransform,float,int,bool,bool,bool> ), null, UnityTypes.UnityEditor_RectTransformEditor.GetMethod( "SetAnchorSmart", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.RectTransform ), typeof( float ), typeof( int ), typeof( bool ), typeof( bool ), typeof( bool ) }, null ) );
			}
			__SetAnchorSmart_1_6( rect, value, axis, isMax, smart, enforceExactValue );
		}
		
		public static void SetAnchorSmart( UnityEngine.RectTransform rect, float value, int axis, bool isMax, bool smart, bool enforceExactValue, bool enforceMinNoLargerThanMax, bool moveTogether ) {
			if( __SetAnchorSmart_2_8 == null ) {
				__SetAnchorSmart_2_8 = (Action<UnityEngine.RectTransform,float,int,bool,bool,bool,bool,bool>) Delegate.CreateDelegate( typeof( Action<UnityEngine.RectTransform,float,int,bool,bool,bool,bool,bool> ), null, UnityTypes.UnityEditor_RectTransformEditor.GetMethod( "SetAnchorSmart", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.RectTransform ), typeof( float ), typeof( int ), typeof( bool ), typeof( bool ), typeof( bool ), typeof( bool ), typeof( bool ) }, null ) );
			}
			__SetAnchorSmart_2_8( rect, value, axis, isMax, smart, enforceExactValue, enforceMinNoLargerThanMax, moveTogether );
		}
		
		public static void SetPivotSmart( UnityEngine.RectTransform rect, float value, int axis, bool smart, bool parentSpace ) {
			if( __SetPivotSmart_0_5 == null ) {
				__SetPivotSmart_0_5 = (Action<UnityEngine.RectTransform,float,int,bool,bool>) Delegate.CreateDelegate( typeof( Action<UnityEngine.RectTransform,float,int,bool,bool> ), null, UnityTypes.UnityEditor_RectTransformEditor.GetMethod( "SetPivotSmart", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.RectTransform ), typeof( float ), typeof( int ), typeof( bool ), typeof( bool ) }, null ) );
			}
			__SetPivotSmart_0_5( rect, value, axis, smart, parentSpace );
		}
		
		
		
		static Action<UnityEngine.RectTransform,float,int,bool,bool> __SetAnchorSmart_0_5;
		static Action<UnityEngine.RectTransform,float,int,bool,bool,bool> __SetAnchorSmart_1_6;
		static Action<UnityEngine.RectTransform,float,int,bool,bool,bool,bool,bool> __SetAnchorSmart_2_8;
		static Action<UnityEngine.RectTransform,float,int,bool,bool> __SetPivotSmart_0_5;
	}
}

