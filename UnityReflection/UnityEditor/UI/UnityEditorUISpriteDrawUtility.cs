/// UnityEditor.UI.SpriteDrawUtility : 2019.4.5f1

using HananokiEditor;
using System;
using UnityEngine;

namespace UnityReflection {
  public sealed partial class UnityEditorUISpriteDrawUtility {
    
		public static void DrawSprite( Sprite sprite, Rect drawArea, Color color ) {
			if( __DrawSprite_0_3 == null ) {
				__DrawSprite_0_3 = (Action<Sprite,Rect,Color>) Delegate.CreateDelegate( typeof( Action<Sprite,Rect,Color> ), null, UnityTypes.UnityEditor_UI_SpriteDrawUtility.GetMethod( "DrawSprite", R.StaticMembers, null, new Type[]{ typeof( Sprite ), typeof( Rect ), typeof( Color ) }, null ) );
			}
			__DrawSprite_0_3( sprite, drawArea, color );
		}
		
		public static void DrawSprite( Texture tex, Rect drawArea, Rect outer, Rect uv, Color color ) {
			if( __DrawSprite_1_5 == null ) {
				__DrawSprite_1_5 = (Action<Texture,Rect,Rect,Rect,Color>) Delegate.CreateDelegate( typeof( Action<Texture,Rect,Rect,Rect,Color> ), null, UnityTypes.UnityEditor_UI_SpriteDrawUtility.GetMethod( "DrawSprite", R.StaticMembers, null, new Type[]{ typeof( Texture ), typeof( Rect ), typeof( Rect ), typeof( Rect ), typeof( Color ) }, null ) );
			}
			__DrawSprite_1_5( tex, drawArea, outer, uv, color );
		}
		
		public static void DrawSprite( Texture tex, Rect drawArea, Vector4 padding, Rect outer, Rect inner, Rect uv, Color color, Material mat ) {
			if( __DrawSprite_2_8 == null ) {
				__DrawSprite_2_8 = (Action<Texture,Rect,Vector4,Rect,Rect,Rect,Color,Material>) Delegate.CreateDelegate( typeof( Action<Texture,Rect,Vector4,Rect,Rect,Rect,Color,Material> ), null, UnityTypes.UnityEditor_UI_SpriteDrawUtility.GetMethod( "DrawSprite", R.StaticMembers, null, new Type[]{ typeof( Texture ), typeof( Rect ), typeof( Vector4 ), typeof( Rect ), typeof( Rect ), typeof( Rect ), typeof( Color ), typeof( Material ) }, null ) );
			}
			__DrawSprite_2_8( tex, drawArea, padding, outer, inner, uv, color, mat );
		}
		
		
		
		static Action<Sprite,Rect,Color> __DrawSprite_0_3;
		static Action<Texture,Rect,Rect,Rect,Color> __DrawSprite_1_5;
		static Action<Texture,Rect,Vector4,Rect,Rect,Rect,Color,Material> __DrawSprite_2_8;
	}
}

