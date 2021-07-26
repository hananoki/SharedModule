/// HananokiEditor.SelectionHistory.Main : 2020.3.8f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class HananokiEditorSelectionHistoryMain {

		public static class Cache<T> {
			public static T cache;
		}

		public static void Prev() {
			if( __Prev_0_0 == null ) {
				__Prev_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), null, UnityTypes.HananokiEditor_SelectionHistory_Main.GetMethod( "Prev", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			__Prev_0_0();
		}
		
		public static void Next() {
			if( __Next_0_0 == null ) {
				__Next_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), null, UnityTypes.HananokiEditor_SelectionHistory_Main.GetMethod( "Next", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			__Next_0_0();
		}
		
		public static bool HasPrev() {
			if( __HasPrev_0_0 == null ) {
				__HasPrev_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), null, UnityTypes.HananokiEditor_SelectionHistory_Main.GetMethod( "HasPrev", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __HasPrev_0_0();
		}
		
		public static bool HasNext() {
			if( __HasNext_0_0 == null ) {
				__HasNext_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), null, UnityTypes.HananokiEditor_SelectionHistory_Main.GetMethod( "HasNext", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __HasNext_0_0();
		}
		
		
		
		static Action __Prev_0_0;
		static Action __Next_0_0;
		static Func<bool> __HasPrev_0_0;
		static Func<bool> __HasNext_0_0;
	}
}

