/// UnityEditor.GameObjectInspector : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
	public sealed partial class UnityEditorGameObjectInspector {
		public object m_instance;

		public UnityEditorGameObjectInspector( object instance ) {
			m_instance = instance;
		}
		public UnityEditorGameObjectInspector() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_GameObjectInspector, new object[] { } );
		}


		public void DoLayerField( UnityEngine.GameObject go ) {
			if( __DoLayerField_0_1 == null ) {
				__DoLayerField_0_1 = (Action<UnityEngine.GameObject>) Delegate.CreateDelegate( typeof( Action<UnityEngine.GameObject> ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "DoLayerField", R.InstanceMembers, null, new Type[] { typeof( UnityEngine.GameObject ) }, null ) );
			}
			__DoLayerField_0_1( go );
		}

		public void DoTagsField( UnityEngine.GameObject go ) {
			if( __DoTagsField_0_1 == null ) {
				__DoTagsField_0_1 = (Action<UnityEngine.GameObject>) Delegate.CreateDelegate( typeof( Action<UnityEngine.GameObject> ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "DoTagsField", R.InstanceMembers, null, new Type[] { typeof( UnityEngine.GameObject ) }, null ) );
			}
			__DoTagsField_0_1( go );
		}

		public void DoStaticToggleField( UnityEngine.GameObject go ) {
			if( __DoStaticToggleField_0_1 == null ) {
				__DoStaticToggleField_0_1 = (Action<UnityEngine.GameObject>) Delegate.CreateDelegate( typeof( Action<UnityEngine.GameObject> ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "DoStaticToggleField", R.InstanceMembers, null, new Type[] { typeof( UnityEngine.GameObject ) }, null ) );
			}
			__DoStaticToggleField_0_1( go );
		}

		public void DoStaticFlagsDropDown( UnityEngine.GameObject go ) {
			if( __DoStaticFlagsDropDown_0_1 == null ) {
				__DoStaticFlagsDropDown_0_1 = (Action<UnityEngine.GameObject>) Delegate.CreateDelegate( typeof( Action<UnityEngine.GameObject> ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "DoStaticFlagsDropDown", R.InstanceMembers, null, new Type[] { typeof( UnityEngine.GameObject ) }, null ) );
			}
			__DoStaticFlagsDropDown_0_1( go );
		}

		public void DoPrefabButtons() {
			if( __DoPrefabButtons_0_0 == null ) {
				__DoPrefabButtons_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "DoPrefabButtons", R.InstanceMembers, null, new Type[] { }, null ) );
			}
			__DoPrefabButtons_0_0();
		}

		public bool HasPreviewGUI() {
			if( __HasPreviewGUI_0_0 == null ) {
				__HasPreviewGUI_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "HasPreviewGUI", R.InstanceMembers, null, new Type[] { }, null ) );
			}
			return __HasPreviewGUI_0_0();
		}

		public void OnEnable() {
			if( __OnEnable_0_0 == null ) {
				__OnEnable_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "OnEnable", R.InstanceMembers, null, new Type[] { }, null ) );
			}
			__OnEnable_0_0();
		}

		public void OnDisable() {
			if( __OnDisable_0_0 == null ) {
				__OnDisable_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "OnDisable", R.InstanceMembers, null, new Type[] { }, null ) );
			}
			__OnDisable_0_0();
		}

		public void OnForceReloadInspector() {
			if( __OnForceReloadInspector_0_0 == null ) {
				__OnForceReloadInspector_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "OnForceReloadInspector", R.InstanceMembers, null, new Type[] { }, null ) );
			}
			__OnForceReloadInspector_0_0();
		}

		public void OnPreviewSettings() {
			if( __OnPreviewSettings_0_0 == null ) {
				__OnPreviewSettings_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "OnPreviewSettings", R.InstanceMembers, null, new Type[] { }, null ) );
			}
			__OnPreviewSettings_0_0();
		}

		public void OnPreviewGUI( UnityEngine.Rect r, UnityEngine.GUIStyle background ) {
			if( __OnPreviewGUI_0_2 == null ) {
				__OnPreviewGUI_0_2 = (Action<UnityEngine.Rect, UnityEngine.GUIStyle>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Rect, UnityEngine.GUIStyle> ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "OnPreviewGUI", R.InstanceMembers, null, new Type[] { typeof( UnityEngine.Rect ), typeof( UnityEngine.GUIStyle ) }, null ) );
			}
			__OnPreviewGUI_0_2( r, background );
		}

		public void ReloadPreviewInstances() {
			if( __ReloadPreviewInstances_0_0 == null ) {
				__ReloadPreviewInstances_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "ReloadPreviewInstances", R.InstanceMembers, null, new Type[] { }, null ) );
			}
			__ReloadPreviewInstances_0_0();
		}

		public UnityEngine.Texture2D RenderStaticPreview( string assetPath, UnityEngine.Object[] subAssets, int width, int height ) {
			if( __RenderStaticPreview_0_4 == null ) {
				__RenderStaticPreview_0_4 = (Func<string, UnityEngine.Object[], int, int, UnityEngine.Texture2D>) Delegate.CreateDelegate( typeof( Func<string, UnityEngine.Object[], int, int, UnityEngine.Texture2D> ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "RenderStaticPreview", R.InstanceMembers, null, new Type[] { typeof( string ), typeof( UnityEngine.Object[] ), typeof( int ), typeof( int ) }, null ) );
			}
			return __RenderStaticPreview_0_4( assetPath, subAssets, width, height );
		}

		public void OnHeaderGUI() {
			if( __OnHeaderGUI_0_0 == null ) {
				__OnHeaderGUI_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_GameObjectInspector.GetMethod( "OnHeaderGUI", R.InstanceMembers, null, new Type[] { }, null ) );
			}
			__OnHeaderGUI_0_0();
		}



		Action<UnityEngine.GameObject> __DoLayerField_0_1;
		Action<UnityEngine.GameObject> __DoTagsField_0_1;
		Action<UnityEngine.GameObject> __DoStaticToggleField_0_1;
		Action<UnityEngine.GameObject> __DoStaticFlagsDropDown_0_1;
		Action __DoPrefabButtons_0_0;
		Func<bool> __HasPreviewGUI_0_0;
		Action __OnEnable_0_0;
		Action __OnDisable_0_0;
		Action __OnForceReloadInspector_0_0;
		Action __OnPreviewSettings_0_0;
		Action<UnityEngine.Rect, UnityEngine.GUIStyle> __OnPreviewGUI_0_2;
		Action __ReloadPreviewInstances_0_0;
		Func<string, UnityEngine.Object[], int, int, UnityEngine.Texture2D> __RenderStaticPreview_0_4;
		Action __OnHeaderGUI_0_0;
	}
}

