#if UNITY_EDITOR

using System.Reflection;
using UnityEditor;

namespace Hananoki.Reflection {

	public class UEditorUserBuildSettingsUtils {
		static MethodInfo _CalculateSelectedBuildTarget;

		public static BuildTarget CalculateSelectedBuildTarget( BuildTargetGroup group ) {
			if( _CalculateSelectedBuildTarget == null ) {
				var t = typeof( EditorWindow ).Assembly.GetType( "UnityEditor.EditorUserBuildSettingsUtils" );
				_CalculateSelectedBuildTarget = t.GetMethod( "CalculateSelectedBuildTarget", BindingFlags.Public | BindingFlags.Static );
			}

			var bak = EditorUserBuildSettings.selectedBuildTargetGroup;
			EditorUserBuildSettings.selectedBuildTargetGroup = group;

			var ret = (BuildTarget) _CalculateSelectedBuildTarget.Invoke( null, null );

			EditorUserBuildSettings.selectedBuildTargetGroup = bak;
			return ret;
		}
	}

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
	}

	public class UEditorUserBuildSettings {
		//static PropertyInfo _activeBuildTargetGroup;

		public static BuildTargetGroup activeBuildTargetGroup {
			get {
				//if( _activeBuildTargetGroup == null ) {
				//	var t = typeof( EditorWindow ).Assembly.GetType( "UnityEditor.EditorUserBuildSettings" );
				//	_activeBuildTargetGroup = t.GetProperty( "activeBuildTargetGroup", BindingFlags.NonPublic | BindingFlags.Static );
				//}
				return (BuildTargetGroup) R.Property( "activeBuildTargetGroup", "UnityEditor.EditorUserBuildSettings" ).GetValue( null );
				//return (BuildTargetGroup) _activeBuildTargetGroup.GetValue( null );
			}
		}

		static MethodInfo _GetCompressionType;

		public static Compression GetCompressionType( BuildTargetGroup targetGroup ) {
			if( _GetCompressionType == null ) {
				var t = typeof( EditorWindow ).Assembly.GetType( "UnityEditor.EditorUserBuildSettings" );
				_GetCompressionType = t.GetMethod( "GetCompressionType", BindingFlags.NonPublic | BindingFlags.Static );
			}
			var obj = _GetCompressionType.Invoke( null, new object[] { targetGroup } );
			return (Compression) obj;
		}


		static MethodInfo _SetCompressionType;
		public static void SetCompressionType( BuildTargetGroup targetGroup, Compression type ) {

			if( _SetCompressionType == null ) {
				var t = typeof( EditorWindow ).Assembly.GetType( "UnityEditor.EditorUserBuildSettings" );
				_SetCompressionType = t.GetMethod( "SetCompressionType", BindingFlags.NonPublic | BindingFlags.Static );
			}
			_SetCompressionType.Invoke( null, new object[] { targetGroup, (int)type } );
		}

	}
}


#endif
