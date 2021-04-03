/// UnityEditor.SceneViewMotion : 2019.4.21f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorSceneViewMotion {

		public static class Cache<T> {
			public static T cache;
		}

		public static int s_ViewToolID {
			get {
				if( __s_ViewToolID == null ) {
					__s_ViewToolID = UnityTypes.UnityEditor_SceneViewMotion.GetField( "s_ViewToolID", R.StaticMembers );
				}
				return (int) __s_ViewToolID.GetValue( null );
			}
			set {
				if( __s_ViewToolID == null ) {
					__s_ViewToolID = UnityTypes.UnityEditor_SceneViewMotion.GetField( "s_ViewToolID", R.StaticMembers );
				}
				__s_ViewToolID.SetValue( null, value );
			}
		}

		public static void DoViewTool( UnityEditor.SceneView view ) {
			if( __DoViewTool_0_1 == null ) {
				__DoViewTool_0_1 = (Action<UnityEditor.SceneView>) Delegate.CreateDelegate( typeof( Action<UnityEditor.SceneView> ), null, UnityTypes.UnityEditor_SceneViewMotion.GetMethod( "DoViewTool", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.SceneView ) }, null ) );
			}
			__DoViewTool_0_1( view );
		}
		
		public static UnityEngine.Vector3 GetMovementDirection() {
			if( __GetMovementDirection_0_0 == null ) {
				__GetMovementDirection_0_0 = (Func<UnityEngine.Vector3>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Vector3> ), null, UnityTypes.UnityEditor_SceneViewMotion.GetMethod( "GetMovementDirection", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetMovementDirection_0_0();
		}
		
		
		
		static FieldInfo __s_ViewToolID;
		static Action<UnityEditor.SceneView> __DoViewTool_0_1;
		static Func<UnityEngine.Vector3> __GetMovementDirection_0_0;
	}
}

