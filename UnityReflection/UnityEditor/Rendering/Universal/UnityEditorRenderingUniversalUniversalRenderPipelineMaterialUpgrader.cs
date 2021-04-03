/// UnityEditor.Rendering.Universal.UniversalRenderPipelineMaterialUpgrader : 2020.3.0f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorRenderingUniversalUniversalRenderPipelineMaterialUpgrader {

		public static class Cache<T> {
			public static T cache;
		}

		public static void UpgradeProjectMaterials() {
			if( __UpgradeProjectMaterials_0_0 == null ) {
				__UpgradeProjectMaterials_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), null, UnityTypes.UnityEditor_Rendering_Universal_UniversalRenderPipelineMaterialUpgrader.GetMethod( "UpgradeProjectMaterials", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			__UpgradeProjectMaterials_0_0();
		}
		
		public static void UpgradeSelectedMaterials() {
			if( __UpgradeSelectedMaterials_0_0 == null ) {
				__UpgradeSelectedMaterials_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), null, UnityTypes.UnityEditor_Rendering_Universal_UniversalRenderPipelineMaterialUpgrader.GetMethod( "UpgradeSelectedMaterials", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			__UpgradeSelectedMaterials_0_0();
		}
		
		
		
		static Action __UpgradeProjectMaterials_0_0;
		static Action __UpgradeSelectedMaterials_0_0;
	}
}

