/// UnityEditor.EditorUserBuildSettings : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorEditorUserBuildSettings {
    

		public static UnityEditor.BuildTargetGroup activeBuildTargetGroup {
			get {
				if( __activeBuildTargetGroup == null ) {
					__activeBuildTargetGroup = (Func<UnityEditor.BuildTargetGroup>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTargetGroup> ), null, UnityTypes.UnityEditor_EditorUserBuildSettings.GetMethod( "get_activeBuildTargetGroup", R.StaticMembers ) );
				}
				return __activeBuildTargetGroup();
			}
		}
		public static Compression GetCompressionType( UnityEditor.BuildTargetGroup targetGroup ) {
			if( __GetCompressionType_0_1 == null ) {
				__GetCompressionType_0_1 = (Func<UnityEditor.BuildTargetGroup, Compression>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTargetGroup, Compression> ), null, UnityTypes.UnityEditor_EditorUserBuildSettings.GetMethod( "GetCompressionType", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.BuildTargetGroup ) }, null ) );
			}
			return __GetCompressionType_0_1( targetGroup );
		}
		
		public static void SetCompressionType( UnityEditor.BuildTargetGroup targetGroup, Compression type ) {
			if( __SetCompressionType_0_2 == null ) {
				__SetCompressionType_0_2 = (Action<UnityEditor.BuildTargetGroup,Compression>) Delegate.CreateDelegate( typeof( Action<UnityEditor.BuildTargetGroup,Compression> ), null, UnityTypes.UnityEditor_EditorUserBuildSettings.GetMethod( "SetCompressionType", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.BuildTargetGroup ), typeof( Compression ) }, null ) );
			}
			__SetCompressionType_0_2( targetGroup, type );
		}
		
		
		
		static Func<UnityEditor.BuildTargetGroup> __activeBuildTargetGroup;
		static Func<UnityEditor.BuildTargetGroup, Compression> __GetCompressionType_0_1;
		static Action<UnityEditor.BuildTargetGroup,Compression> __SetCompressionType_0_2;
	}
}

