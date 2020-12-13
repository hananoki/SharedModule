/// UnityEditor.EditorUserBuildSettings : 2019.4.5f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorEditorUserBuildSettings {

		public static class Cache<T> {
			public static T cache;
		}

		public static UnityEditor.BuildTargetGroup activeBuildTargetGroup {
			get {
				if( __activeBuildTargetGroup == null ) {
					__activeBuildTargetGroup = (Func<UnityEditor.BuildTargetGroup>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTargetGroup> ), null, UnityTypes.UnityEditor_EditorUserBuildSettings.GetMethod( "get_activeBuildTargetGroup", R.StaticMembers ) );
				}
				return __activeBuildTargetGroup();
			}
		}

		public static int GetCompressionType( UnityEditor.BuildTargetGroup targetGroup ) {
			if( __GetCompressionType_0_1 == null ) {
				__GetCompressionType_0_1 = UnityTypes.UnityEditor_EditorUserBuildSettings.GetMethod( "GetCompressionType", R.StaticMembers );
			}
			return (int) __GetCompressionType_0_1.Invoke( null, new object[] {  targetGroup  } );
		}
		
		public static void SetCompressionType( UnityEditor.BuildTargetGroup targetGroup, int type ) {
			if( __SetCompressionType_0_2 == null ) {
				__SetCompressionType_0_2 = UnityTypes.UnityEditor_EditorUserBuildSettings.GetMethod( "SetCompressionType", R.StaticMembers );
			}
			__SetCompressionType_0_2.Invoke( null, new object[] {  targetGroup, type  } );
		}
		
		
		
		static Func<UnityEditor.BuildTargetGroup> __activeBuildTargetGroup;
		static MethodInfo __GetCompressionType_0_1;
		static MethodInfo __SetCompressionType_0_2;
	}
}

