/// UnityEditor.EditorUtility : 2020.3.8f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorEditorUtility {

		public static class Cache<T> {
			public static T cache;
		}

		public static void DisplayObjectContextMenu( UnityEngine.Rect position, UnityEngine.Object context, int contextUserData ) {
			if( __DisplayObjectContextMenu_0_3 == null ) {
				__DisplayObjectContextMenu_0_3 = (Action<UnityEngine.Rect,UnityEngine.Object,int>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Rect,UnityEngine.Object,int> ), null, UnityTypes.UnityEditor_EditorUtility.GetMethod( "DisplayObjectContextMenu", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Rect ), typeof( UnityEngine.Object ), typeof( int ) }, null ) );
			}
			__DisplayObjectContextMenu_0_3( position, context, contextUserData );
		}
		
		public static void DisplayObjectContextMenu( UnityEngine.Rect position, UnityEngine.Object[] context, int contextUserData ) {
			if( __DisplayObjectContextMenu_1_3 == null ) {
				__DisplayObjectContextMenu_1_3 = (Action<UnityEngine.Rect,UnityEngine.Object[],int>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Rect,UnityEngine.Object[],int> ), null, UnityTypes.UnityEditor_EditorUtility.GetMethod( "DisplayObjectContextMenu", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Rect ), typeof( UnityEngine.Object[] ), typeof( int ) }, null ) );
			}
			__DisplayObjectContextMenu_1_3( position, context, contextUserData );
		}
		
		
		
		static Action<UnityEngine.Rect,UnityEngine.Object,int> __DisplayObjectContextMenu_0_3;
		static Action<UnityEngine.Rect,UnityEngine.Object[],int> __DisplayObjectContextMenu_1_3;
	}
}

