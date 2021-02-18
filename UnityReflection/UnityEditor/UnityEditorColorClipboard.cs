/// UnityEditor.ColorClipboard : 2019.4.16f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorColorClipboard {

		public static class Cache<T> {
			public static T cache;
		}

		public static void SetColor( UnityEngine.Color color ) {
			if( __SetColor_0_1 == null ) {
				__SetColor_0_1 = (Action<UnityEngine.Color>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Color> ), null, UnityTypes.UnityEditor_ColorClipboard.GetMethod( "SetColor", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Color ) }, null ) );
			}
			__SetColor_0_1( color );
		}
		
		public static bool HasColor() {
			if( __HasColor_0_0 == null ) {
				__HasColor_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), null, UnityTypes.UnityEditor_ColorClipboard.GetMethod( "HasColor", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __HasColor_0_0();
		}
		
		public static bool TryGetColor( bool allowHDR, ref UnityEngine.Color color ) {
			if( __TryGetColor_0_2 == null ) {
				__TryGetColor_0_2 = (Method_TryGetColor_0_2) Delegate.CreateDelegate( typeof( Method_TryGetColor_0_2 ), null, UnityTypes.UnityEditor_ColorClipboard.GetMethod( "TryGetColor", R.StaticMembers, null, new Type[]{ typeof( bool ), typeof( UnityEngine.Color ).MakeByRefType() }, null ) );
			}
			return __TryGetColor_0_2( allowHDR, ref color );
		}
		
		
		
		static Action<UnityEngine.Color> __SetColor_0_1;
		static Func<bool> __HasColor_0_0;
		delegate bool Method_TryGetColor_0_2( bool allowHDR, ref UnityEngine.Color color );
		static Method_TryGetColor_0_2 __TryGetColor_0_2;
	}
}

