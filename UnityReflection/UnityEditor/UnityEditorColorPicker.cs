/// UnityEditor.ColorPicker : 2019.4.16f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorColorPicker {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorColorPicker( object instance ){
			m_instance = instance;
    }
    public UnityEditorColorPicker() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_ColorPicker, new object[] {} );
    }
    

		public static void Show( object viewToUpdate, UnityEngine.Color col, bool showAlpha = true, bool hdr = false ) {
			if( __Show_0_4 == null ) {
				__Show_0_4 = UnityTypes.UnityEditor_ColorPicker.GetMethod( "Show", R.StaticMembers, null, new Type[]{ typeof( object ), typeof( UnityEngine.Color ), typeof( bool ), typeof( bool ) }, null );
			}
			__Show_0_4.Invoke( null, new object[] {  viewToUpdate, col, showAlpha, hdr  } );
		}
		
		//public static void Show( System.Action`1[[UnityEngine.Color, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]] colorChangedCallback, UnityEngine.Color col, bool showAlpha = true, bool hdr = false ) {
		//	if( __Show_1_4 == null ) {
		//		__Show_1_4 = UnityTypes.UnityEditor_ColorPicker.GetMethod( "Show", R.StaticMembers, null, new Type[]{ typeof( System.Action`1[[UnityEngine.Color, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]] ), typeof( UnityEngine.Color ), typeof( bool ), typeof( bool ) }, null );
		//	}
		//	__Show_1_4.Invoke( null, new object[] {  colorChangedCallback, col, showAlpha, hdr  } );
		//}
		
		//public static void Show( object viewToUpdate, System.Action`1[[UnityEngine.Color, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]] colorChangedCallback, UnityEngine.Color col, bool showAlpha, bool hdr ) {
		//	if( __Show_2_5 == null ) {
		//		__Show_2_5 = UnityTypes.UnityEditor_ColorPicker.GetMethod( "Show", R.StaticMembers, null, new Type[]{ typeof( object ), typeof( System.Action`1[[UnityEngine.Color, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]] ), typeof( UnityEngine.Color ), typeof( bool ), typeof( bool ) }, null );
		//	}
		//	__Show_2_5.Invoke( null, new object[] {  viewToUpdate, colorChangedCallback, col, showAlpha, hdr  } );
		//}
		
		//public void Show() {
		//	if( __Show_0_0 == null ) {
		//		__Show_0_0 = UnityTypes.UnityEditor_ColorPicker.GetMethod( "Show", R.InstanceMembers, null, new Type[]{  }, null );
		//	}
		//	__Show_0_0.Invoke( m_instance, new object[] {  } );
		//}
		
		//public void Show( bool immediateDisplay ) {
		//	if( __Show_1_1 == null ) {
		//		__Show_1_1 = UnityTypes.UnityEditor_ColorPicker.GetMethod( "Show", R.InstanceMembers, null, new Type[]{ typeof( bool ) }, null );
		//	}
		//	__Show_1_1.Invoke( m_instance, new object[] {  immediateDisplay  } );
		//}
		
		
		
		static MethodInfo __Show_0_4;
		static MethodInfo __Show_1_4;
		static MethodInfo __Show_2_5;
		MethodInfo __Show_0_0;
		MethodInfo __Show_1_1;
	}
}

