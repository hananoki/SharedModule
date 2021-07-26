/// HananokiEditor.FavoriteAssets.Utils : 2020.3.8f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class HananokiEditorFavoriteAssetsUtils {

		public static class Cache<T> {
			public static T cache;
		}

		public static void ShowMenu( UnityEngine.Rect rc ) {
			if( __ShowMenu_0_1 == null ) {
				__ShowMenu_0_1 = (Action<UnityEngine.Rect>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Rect> ), null, UnityTypes.HananokiEditor_FavoriteAssets_Utils.GetMethod( "ShowMenu", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Rect ) }, null ) );
			}
			__ShowMenu_0_1( rc );
		}
		
		
		
		static Action<UnityEngine.Rect> __ShowMenu_0_1;
	}
}

