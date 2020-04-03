/// UnityEditor.EditorUserBuildSettings : 2019.3.0f6

#if UNITY_EDITOR

using Hananoki.Reflection;
using System.Reflection;
using UnityEditor;

namespace Hananoki {
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

	public class UnityEditorUserBuildSettings {
		const string typeName = "UnityEditor.EditorUserBuildSettings";

		public static BuildTargetGroup activeBuildTargetGroup {
			get {
				return (BuildTargetGroup) R.Property( "activeBuildTargetGroup", typeName ).GetValue( null );
			}
		}

		static MethodInfo _GetCompressionType;
		public static Compression GetCompressionType( BuildTargetGroup targetGroup ) {
			if( _GetCompressionType == null ) {
				_GetCompressionType = R.Method( "GetCompressionType", typeName );
			}
			var obj = _GetCompressionType.Invoke( null, new object[] { targetGroup } );
			return (Compression) obj;
		}


		static MethodInfo _SetCompressionType;
		public static void SetCompressionType( BuildTargetGroup targetGroup, Compression type ) {

			if( _SetCompressionType == null ) {
				_SetCompressionType = R.Method( "SetCompressionType", typeName );
			}
			_SetCompressionType.Invoke( null, new object[] { targetGroup, (int) type } );
		}
	}
}

#endif

