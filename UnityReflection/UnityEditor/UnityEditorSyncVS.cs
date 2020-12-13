/// UnityEditor.SyncVS : 2019.4.5f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
	public sealed partial class UnityEditorSyncVS {

		public static class Cache<T> {
			public static T cache;
		}

		public static bool s_Enabled {
			get {
				if( __s_Enabled == null ) {
					__s_Enabled = UnityTypes.UnityEditor_SyncVS.GetField( "s_Enabled", R.StaticMembers );
				}
				return (bool) __s_Enabled.GetValue( null );
			}
			set {
				if( __s_Enabled == null ) {
					__s_Enabled = UnityTypes.UnityEditor_SyncVS.GetField( "s_Enabled", R.StaticMembers );
				}
				__s_Enabled.SetValue( null,  value  );
			}
		}

		public static void SyncSolution() {
			if( __SyncSolution_0_0 == null ) {
				__SyncSolution_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), null, UnityTypes.UnityEditor_SyncVS.GetMethod( "SyncSolution", R.StaticMembers, null, new Type[] { }, null ) );
			}
			__SyncSolution_0_0();
		}



		static FieldInfo __s_Enabled;
		static Action __SyncSolution_0_0;
	}
}

