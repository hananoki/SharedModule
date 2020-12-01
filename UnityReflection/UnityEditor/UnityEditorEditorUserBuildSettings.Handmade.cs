/// UnityEditor.EditorUserBuildSettings : 2019.4.5f1

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;
using System.Reflection;
using UnityEditor;

namespace UnityReflection {
	public enum Compression {
		None,
		Lz4 = 2,
		Lz4HC
	}

	public static class CompressionExtension {
		public static int ToIndex( this Compression i ) {
			if( i == Compression.Lz4 ) return 1;
			if( i == Compression.Lz4HC ) return 2;
			return 0;
		}
		public static int GetInstance( this Compression i ) {
			return (int) i;
		}
	}

	public partial class UnityEditorEditorUserBuildSettings {
		const string typeName = "UnityEditor.EditorUserBuildSettings";

		//public static BuildTargetGroup activeBuildTargetGroup {
		//	get {
		//		return (BuildTargetGroup) R.Property( "activeBuildTargetGroup", typeName ).GetValue( null );
		//	}
		//}
#if false
		delegate BuildTargetGroup __activeBuildTargetGroup();
		static __activeBuildTargetGroup ___activeBuildTargetGroup;


		static MethodInfo _GetCompressionType;
		public static Compression GetCompressionType( BuildTargetGroup targetGroup ) {
			if( _GetCompressionType == null ) {
				_GetCompressionType = UnityTypes.UnityEditor_EditorUserBuildSettings.GetMethod( "GetCompressionType", R.AllMembers );
			}
			var obj = _GetCompressionType.Invoke( null, new object[] { targetGroup } );
			return (Compression) obj;
		}


		static MethodInfo _SetCompressionType;
		public static void SetCompressionType( BuildTargetGroup targetGroup, Compression type ) {

			if( _SetCompressionType == null ) {
				_SetCompressionType = UnityTypes.UnityEditor_EditorUserBuildSettings.GetMethod( "SetCompressionType", R.AllMembers );
			}
			_SetCompressionType.Invoke( null, new object[] { targetGroup, (int) type } );
		}
#endif
	}
}

#endif

