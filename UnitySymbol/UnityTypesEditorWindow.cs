using System;
namespace Hananoki {
	public static partial class UnityTypes {
		static Type _HolographicEmulationWindow;
		public static Type HolographicEmulationWindow {
			get {
				if( _HolographicEmulationWindow == null) {
					_HolographicEmulationWindow = Type.GetType( "UnityEngine.XR.WSA.HolographicEmulationWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _HolographicEmulationWindow;
			}
		}
			
		static Type _BuildPlayerWindow;
		public static Type BuildPlayerWindow {
			get {
				if( _BuildPlayerWindow == null) {
					_BuildPlayerWindow = Type.GetType( "UnityEditor.BuildPlayerWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _BuildPlayerWindow;
			}
		}
			
		static Type _ConsoleWindow;
		public static Type ConsoleWindow {
			get {
				if( _ConsoleWindow == null) {
					_ConsoleWindow = Type.GetType( "UnityEditor.ConsoleWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ConsoleWindow;
			}
		}
			
		static Type _IconSelector;
		public static Type IconSelector {
			get {
				if( _IconSelector == null) {
					_IconSelector = Type.GetType( "UnityEditor.IconSelector, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _IconSelector;
			}
		}
			
		static Type _ObjectSelector;
		public static Type ObjectSelector {
			get {
				if( _ObjectSelector == null) {
					_ObjectSelector = Type.GetType( "UnityEditor.ObjectSelector, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ObjectSelector;
			}
		}
			
		static Type _ProjectBrowser;
		public static Type ProjectBrowser {
			get {
				if( _ProjectBrowser == null) {
					_ProjectBrowser = Type.GetType( "UnityEditor.ProjectBrowser, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ProjectBrowser;
			}
		}
			
		static Type _ProjectTemplateWindow;
		public static Type ProjectTemplateWindow {
			get {
				if( _ProjectTemplateWindow == null) {
					_ProjectTemplateWindow = Type.GetType( "UnityEditor.ProjectTemplateWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ProjectTemplateWindow;
			}
		}
			
		static Type _RagdollBuilder;
		public static Type RagdollBuilder {
			get {
				if( _RagdollBuilder == null) {
					_RagdollBuilder = Type.GetType( "UnityEditor.RagdollBuilder, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _RagdollBuilder;
			}
		}
			
		static Type _SceneHierarchySortingWindow;
		public static Type SceneHierarchySortingWindow {
			get {
				if( _SceneHierarchySortingWindow == null) {
					_SceneHierarchySortingWindow = Type.GetType( "UnityEditor.SceneHierarchySortingWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _SceneHierarchySortingWindow;
			}
		}
			
		static Type _SceneHierarchyWindow;
		public static Type SceneHierarchyWindow {
			get {
				if( _SceneHierarchyWindow == null) {
					_SceneHierarchyWindow = Type.GetType( "UnityEditor.SceneHierarchyWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _SceneHierarchyWindow;
			}
		}
			
		static Type _ScriptableWizard;
		public static Type ScriptableWizard {
			get {
				if( _ScriptableWizard == null) {
					_ScriptableWizard = Type.GetType( "UnityEditor.ScriptableWizard, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ScriptableWizard;
			}
		}
			
		static Type _AnimationWindow;
		public static Type AnimationWindow {
			get {
				if( _AnimationWindow == null) {
					_AnimationWindow = Type.GetType( "UnityEditor.AnimationWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AnimationWindow;
			}
		}
			
		static Type _CurveEditorWindow;
		public static Type CurveEditorWindow {
			get {
				if( _CurveEditorWindow == null) {
					_CurveEditorWindow = Type.GetType( "UnityEditor.CurveEditorWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _CurveEditorWindow;
			}
		}
			
		static Type _MinMaxCurveEditorWindow;
		public static Type MinMaxCurveEditorWindow {
			get {
				if( _MinMaxCurveEditorWindow == null) {
					_MinMaxCurveEditorWindow = Type.GetType( "UnityEditor.MinMaxCurveEditorWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _MinMaxCurveEditorWindow;
			}
		}
			
		static Type _AnnotationWindow;
		public static Type AnnotationWindow {
			get {
				if( _AnnotationWindow == null) {
					_AnnotationWindow = Type.GetType( "UnityEditor.AnnotationWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AnnotationWindow;
			}
		}
			
		static Type _LayerVisibilityWindow;
		public static Type LayerVisibilityWindow {
			get {
				if( _LayerVisibilityWindow == null) {
					_LayerVisibilityWindow = Type.GetType( "UnityEditor.LayerVisibilityWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _LayerVisibilityWindow;
			}
		}
			
		static Type _AssetStoreLoginWindow;
		public static Type AssetStoreLoginWindow {
			get {
				if( _AssetStoreLoginWindow == null) {
					_AssetStoreLoginWindow = Type.GetType( "UnityEditor.AssetStoreLoginWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AssetStoreLoginWindow;
			}
		}
			
		static Type _AssetStoreWindow;
		public static Type AssetStoreWindow {
			get {
				if( _AssetStoreWindow == null) {
					_AssetStoreWindow = Type.GetType( "UnityEditor.AssetStoreWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AssetStoreWindow;
			}
		}
			
		static Type _AudioMixerWindow;
		public static Type AudioMixerWindow {
			get {
				if( _AudioMixerWindow == null) {
					_AudioMixerWindow = Type.GetType( "UnityEditor.AudioMixerWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AudioMixerWindow;
			}
		}
			
		static Type _GameView;
		public static Type GameView {
			get {
				if( _GameView == null) {
					_GameView = Type.GetType( "UnityEditor.GameView, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _GameView;
			}
		}
			
		static Type _SnapSettingsWindow;
		public static Type SnapSettingsWindow {
			get {
				if( _SnapSettingsWindow == null) {
					_SnapSettingsWindow = Type.GetType( "UnityEditor.SnapSettingsWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _SnapSettingsWindow;
			}
		}
			
		static Type _AboutWindow;
		public static Type AboutWindow {
			get {
				if( _AboutWindow == null) {
					_AboutWindow = Type.GetType( "UnityEditor.AboutWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AboutWindow;
			}
		}
			
		static Type _AssetSaveDialog;
		public static Type AssetSaveDialog {
			get {
				if( _AssetSaveDialog == null) {
					_AssetSaveDialog = Type.GetType( "UnityEditor.AssetSaveDialog, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AssetSaveDialog;
			}
		}
			
		static Type _BumpMapSettingsFixingWindow;
		public static Type BumpMapSettingsFixingWindow {
			get {
				if( _BumpMapSettingsFixingWindow == null) {
					_BumpMapSettingsFixingWindow = Type.GetType( "UnityEditor.BumpMapSettingsFixingWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _BumpMapSettingsFixingWindow;
			}
		}
			
		static Type _ColorPicker;
		public static Type ColorPicker {
			get {
				if( _ColorPicker == null) {
					_ColorPicker = Type.GetType( "UnityEditor.ColorPicker, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ColorPicker;
			}
		}
			
		static Type _EditorUpdateWindow;
		public static Type EditorUpdateWindow {
			get {
				if( _EditorUpdateWindow == null) {
					_EditorUpdateWindow = Type.GetType( "UnityEditor.EditorUpdateWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _EditorUpdateWindow;
			}
		}
			
		static Type _FallbackEditorWindow;
		public static Type FallbackEditorWindow {
			get {
				if( _FallbackEditorWindow == null) {
					_FallbackEditorWindow = Type.GetType( "UnityEditor.FallbackEditorWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _FallbackEditorWindow;
			}
		}
			
		static Type _GradientPicker;
		public static Type GradientPicker {
			get {
				if( _GradientPicker == null) {
					_GradientPicker = Type.GetType( "UnityEditor.GradientPicker, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _GradientPicker;
			}
		}
			
		static Type _PackageExport;
		public static Type PackageExport {
			get {
				if( _PackageExport == null) {
					_PackageExport = Type.GetType( "UnityEditor.PackageExport, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PackageExport;
			}
		}
			
		static Type _PackageImport;
		public static Type PackageImport {
			get {
				if( _PackageImport == null) {
					_PackageImport = Type.GetType( "UnityEditor.PackageImport, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PackageImport;
			}
		}
			
		static Type _PopupWindow;
		public static Type PopupWindow {
			get {
				if( _PopupWindow == null) {
					_PopupWindow = Type.GetType( "UnityEditor.PopupWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PopupWindow;
			}
		}
			
		static Type _PopupWindowWithoutFocus;
		public static Type PopupWindowWithoutFocus {
			get {
				if( _PopupWindowWithoutFocus == null) {
					_PopupWindowWithoutFocus = Type.GetType( "UnityEditor.PopupWindowWithoutFocus, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PopupWindowWithoutFocus;
			}
		}
			
		static Type _PragmaFixingWindow;
		public static Type PragmaFixingWindow {
			get {
				if( _PragmaFixingWindow == null) {
					_PragmaFixingWindow = Type.GetType( "UnityEditor.PragmaFixingWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PragmaFixingWindow;
			}
		}
			
		static Type _SaveWindowLayout;
		public static Type SaveWindowLayout {
			get {
				if( _SaveWindowLayout == null) {
					_SaveWindowLayout = Type.GetType( "UnityEditor.SaveWindowLayout, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _SaveWindowLayout;
			}
		}
			
		static Type _DeleteWindowLayout;
		public static Type DeleteWindowLayout {
			get {
				if( _DeleteWindowLayout == null) {
					_DeleteWindowLayout = Type.GetType( "UnityEditor.DeleteWindowLayout, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _DeleteWindowLayout;
			}
		}
			
		static Type _GUIViewDebuggerWindow;
		public static Type GUIViewDebuggerWindow {
			get {
				if( _GUIViewDebuggerWindow == null) {
					_GUIViewDebuggerWindow = Type.GetType( "UnityEditor.GUIViewDebuggerWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _GUIViewDebuggerWindow;
			}
		}
			
		static Type _InspectorWindow;
		public static Type InspectorWindow {
			get {
				if( _InspectorWindow == null) {
					_InspectorWindow = Type.GetType( "UnityEditor.InspectorWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _InspectorWindow;
			}
		}
			
		static Type _PreviewWindow;
		public static Type PreviewWindow {
			get {
				if( _PreviewWindow == null) {
					_PreviewWindow = Type.GetType( "UnityEditor.PreviewWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PreviewWindow;
			}
		}
			
		static Type _AddShaderVariantWindow;
		public static Type AddShaderVariantWindow {
			get {
				if( _AddShaderVariantWindow == null) {
					_AddShaderVariantWindow = Type.GetType( "UnityEditor.AddShaderVariantWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AddShaderVariantWindow;
			}
		}
			
		static Type _FrameDebuggerWindow;
		public static Type FrameDebuggerWindow {
			get {
				if( _FrameDebuggerWindow == null) {
					_FrameDebuggerWindow = Type.GetType( "UnityEditor.FrameDebuggerWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _FrameDebuggerWindow;
			}
		}
			
		static Type _PlayModeView;
		public static Type PlayModeView {
			get {
				if( _PlayModeView == null) {
					_PlayModeView = Type.GetType( "UnityEditor.PlayModeView, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PlayModeView;
			}
		}
			
		static Type _SearchableEditorWindow;
		public static Type SearchableEditorWindow {
			get {
				if( _SearchableEditorWindow == null) {
					_SearchableEditorWindow = Type.GetType( "UnityEditor.SearchableEditorWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _SearchableEditorWindow;
			}
		}
			
		static Type _LightingExplorerWindow;
		public static Type LightingExplorerWindow {
			get {
				if( _LightingExplorerWindow == null) {
					_LightingExplorerWindow = Type.GetType( "UnityEditor.LightingExplorerWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _LightingExplorerWindow;
			}
		}
			
		static Type _LightingWindow;
		public static Type LightingWindow {
			get {
				if( _LightingWindow == null) {
					_LightingWindow = Type.GetType( "UnityEditor.LightingWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _LightingWindow;
			}
		}
			
		static Type _LightmapPreviewWindow;
		public static Type LightmapPreviewWindow {
			get {
				if( _LightmapPreviewWindow == null) {
					_LightmapPreviewWindow = Type.GetType( "UnityEditor.LightmapPreviewWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _LightmapPreviewWindow;
			}
		}
			
		static Type _NavMeshEditorWindow;
		public static Type NavMeshEditorWindow {
			get {
				if( _NavMeshEditorWindow == null) {
					_NavMeshEditorWindow = Type.GetType( "UnityEditor.NavMeshEditorWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _NavMeshEditorWindow;
			}
		}
			
		static Type _OcclusionCullingWindow;
		public static Type OcclusionCullingWindow {
			get {
				if( _OcclusionCullingWindow == null) {
					_OcclusionCullingWindow = Type.GetType( "UnityEditor.OcclusionCullingWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _OcclusionCullingWindow;
			}
		}
			
		static Type _PhysicsDebugWindow;
		public static Type PhysicsDebugWindow {
			get {
				if( _PhysicsDebugWindow == null) {
					_PhysicsDebugWindow = Type.GetType( "UnityEditor.PhysicsDebugWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PhysicsDebugWindow;
			}
		}
			
		static Type _TierSettingsWindow;
		public static Type TierSettingsWindow {
			get {
				if( _TierSettingsWindow == null) {
					_TierSettingsWindow = Type.GetType( "UnityEditor.TierSettingsWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _TierSettingsWindow;
			}
		}
			
		static Type _SceneView;
		public static Type SceneView {
			get {
				if( _SceneView == null) {
					_SceneView = Type.GetType( "UnityEditor.SceneView, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _SceneView;
			}
		}
			
		static Type _SettingsWindow;
		public static Type SettingsWindow {
			get {
				if( _SettingsWindow == null) {
					_SettingsWindow = Type.GetType( "UnityEditor.SettingsWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _SettingsWindow;
			}
		}
			
		static Type _ProjectSettingsWindow;
		public static Type ProjectSettingsWindow {
			get {
				if( _ProjectSettingsWindow == null) {
					_ProjectSettingsWindow = Type.GetType( "UnityEditor.ProjectSettingsWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ProjectSettingsWindow;
			}
		}
			
		static Type _PreferenceSettingsWindow;
		public static Type PreferenceSettingsWindow {
			get {
				if( _PreferenceSettingsWindow == null) {
					_PreferenceSettingsWindow = Type.GetType( "UnityEditor.PreferenceSettingsWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PreferenceSettingsWindow;
			}
		}
			
		//static Type _SpriteUtilityWindow;
		//public static Type SpriteUtilityWindow {
		//	get {
		//		if( _SpriteUtilityWindow == null) {
		//			_SpriteUtilityWindow = Type.GetType( "UnityEditor.SpriteUtilityWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
		//		}
		//		return _SpriteUtilityWindow;
		//	}
		//}
			
		static Type _UndoWindow;
		public static Type UndoWindow {
			get {
				if( _UndoWindow == null) {
					_UndoWindow = Type.GetType( "UnityEditor.UndoWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _UndoWindow;
			}
		}
			
		static Type _MetroCertificatePasswordWindow;
		public static Type MetroCertificatePasswordWindow {
			get {
				if( _MetroCertificatePasswordWindow == null) {
					_MetroCertificatePasswordWindow = Type.GetType( "UnityEditor.MetroCertificatePasswordWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _MetroCertificatePasswordWindow;
			}
		}
			
		static Type _MetroCreateTestCertificateWindow;
		public static Type MetroCreateTestCertificateWindow {
			get {
				if( _MetroCreateTestCertificateWindow == null) {
					_MetroCreateTestCertificateWindow = Type.GetType( "UnityEditor.MetroCreateTestCertificateWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _MetroCreateTestCertificateWindow;
			}
		}
			
		static Type _LicenseManagementWindow;
		public static Type LicenseManagementWindow {
			get {
				if( _LicenseManagementWindow == null) {
					_LicenseManagementWindow = Type.GetType( "UnityEditor.LicenseManagementWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _LicenseManagementWindow;
			}
		}
			
		static Type _ParticleSystemWindow;
		public static Type ParticleSystemWindow {
			get {
				if( _ParticleSystemWindow == null) {
					_ParticleSystemWindow = Type.GetType( "UnityEditor.ParticleSystemWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ParticleSystemWindow;
			}
		}
			
		static Type _ProfilerWindow;
		public static Type ProfilerWindow {
			get {
				if( _ProfilerWindow == null) {
					_ProfilerWindow = Type.GetType( "UnityEditor.ProfilerWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ProfilerWindow;
			}
		}
			
		static Type _UISystemPreviewWindow;
		public static Type UISystemPreviewWindow {
			get {
				if( _UISystemPreviewWindow == null) {
					_UISystemPreviewWindow = Type.GetType( "UnityEditor.UISystemPreviewWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _UISystemPreviewWindow;
			}
		}
			
		static Type _SketchUpImportDlg;
		public static Type SketchUpImportDlg {
			get {
				if( _SketchUpImportDlg == null) {
					_SketchUpImportDlg = Type.GetType( "UnityEditor.SketchUpImportDlg, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _SketchUpImportDlg;
			}
		}
			
		static Type _TerrainWizard;
		public static Type TerrainWizard {
			get {
				if( _TerrainWizard == null) {
					_TerrainWizard = Type.GetType( "UnityEditor.TerrainWizard, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _TerrainWizard;
			}
		}
			
		static Type _ImportRawHeightmap;
		public static Type ImportRawHeightmap {
			get {
				if( _ImportRawHeightmap == null) {
					_ImportRawHeightmap = Type.GetType( "UnityEditor.ImportRawHeightmap, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ImportRawHeightmap;
			}
		}
			
		static Type _ExportRawHeightmap;
		public static Type ExportRawHeightmap {
			get {
				if( _ExportRawHeightmap == null) {
					_ExportRawHeightmap = Type.GetType( "UnityEditor.ExportRawHeightmap, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ExportRawHeightmap;
			}
		}
			
		static Type _TreeWizard;
		public static Type TreeWizard {
			get {
				if( _TreeWizard == null) {
					_TreeWizard = Type.GetType( "UnityEditor.TreeWizard, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _TreeWizard;
			}
		}
			
		static Type _DetailMeshWizard;
		public static Type DetailMeshWizard {
			get {
				if( _DetailMeshWizard == null) {
					_DetailMeshWizard = Type.GetType( "UnityEditor.DetailMeshWizard, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _DetailMeshWizard;
			}
		}
			
		static Type _DetailTextureWizard;
		public static Type DetailTextureWizard {
			get {
				if( _DetailTextureWizard == null) {
					_DetailTextureWizard = Type.GetType( "UnityEditor.DetailTextureWizard, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _DetailTextureWizard;
			}
		}
			
		static Type _PlaceTreeWizard;
		public static Type PlaceTreeWizard {
			get {
				if( _PlaceTreeWizard == null) {
					_PlaceTreeWizard = Type.GetType( "UnityEditor.PlaceTreeWizard, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PlaceTreeWizard;
			}
		}
			
		static Type _FlattenHeightmap;
		public static Type FlattenHeightmap {
			get {
				if( _FlattenHeightmap == null) {
					_FlattenHeightmap = Type.GetType( "UnityEditor.FlattenHeightmap, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _FlattenHeightmap;
			}
		}
			
		static Type _TestEditorWindow;
		public static Type TestEditorWindow {
			get {
				if( _TestEditorWindow == null) {
					_TestEditorWindow = Type.GetType( "UnityEditor.UIAutomation.TestEditorWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _TestEditorWindow;
			}
		}
			
		static Type _ConflictResolverWindow;
		public static Type ConflictResolverWindow {
			get {
				if( _ConflictResolverWindow == null) {
					_ConflictResolverWindow = Type.GetType( "UnityEditor.ShortcutManagement.ConflictResolverWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ConflictResolverWindow;
			}
		}
			
		static Type _DeleteShortcutProfileWindow;
		public static Type DeleteShortcutProfileWindow {
			get {
				if( _DeleteShortcutProfileWindow == null) {
					_DeleteShortcutProfileWindow = Type.GetType( "UnityEditor.ShortcutManagement.DeleteShortcutProfileWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _DeleteShortcutProfileWindow;
			}
		}
			
		static Type _PromptWindow;
		public static Type PromptWindow {
			get {
				if( _PromptWindow == null) {
					_PromptWindow = Type.GetType( "UnityEditor.ShortcutManagement.PromptWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PromptWindow;
			}
		}
			
		static Type _ShortcutManagerWindow;
		public static Type ShortcutManagerWindow {
			get {
				if( _ShortcutManagerWindow == null) {
					_ShortcutManagerWindow = Type.GetType( "UnityEditor.ShortcutManagement.ShortcutManagerWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ShortcutManagerWindow;
			}
		}
			
		static Type _PresetSelector;
		public static Type PresetSelector {
			get {
				if( _PresetSelector == null) {
					_PresetSelector = Type.GetType( "UnityEditor.Presets.PresetSelector, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PresetSelector;
			}
		}
			
		static Type _AddPresetTypeWindow;
		public static Type AddPresetTypeWindow {
			get {
				if( _AddPresetTypeWindow == null) {
					_AddPresetTypeWindow = Type.GetType( "UnityEditor.Presets.AddPresetTypeWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AddPresetTypeWindow;
			}
		}
			
		static Type _PackageManagerWindow;
		public static Type PackageManagerWindow {
			get {
				if( _PackageManagerWindow == null) {
					_PackageManagerWindow = Type.GetType( "UnityEditor.PackageManager.UI.PackageManagerWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PackageManagerWindow;
			}
		}
			
		static Type _WindowChange;
		public static Type WindowChange {
			get {
				if( _WindowChange == null) {
					_WindowChange = Type.GetType( "UnityEditor.VersionControl.WindowChange, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _WindowChange;
			}
		}
			
		static Type _WindowCheckoutFailure;
		public static Type WindowCheckoutFailure {
			get {
				if( _WindowCheckoutFailure == null) {
					_WindowCheckoutFailure = Type.GetType( "UnityEditor.VersionControl.WindowCheckoutFailure, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _WindowCheckoutFailure;
			}
		}
			
		static Type _WindowPending;
		public static Type WindowPending {
			get {
				if( _WindowPending == null) {
					_WindowPending = Type.GetType( "UnityEditor.VersionControl.WindowPending, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _WindowPending;
			}
		}
			
		static Type _WindowResolve;
		public static Type WindowResolve {
			get {
				if( _WindowResolve == null) {
					_WindowResolve = Type.GetType( "UnityEditor.VersionControl.WindowResolve, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _WindowResolve;
			}
		}
			
		static Type _WindowRevert;
		public static Type WindowRevert {
			get {
				if( _WindowRevert == null) {
					_WindowRevert = Type.GetType( "UnityEditor.VersionControl.WindowRevert, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _WindowRevert;
			}
		}
			
		static Type _UnityConnectConsentView;
		public static Type UnityConnectConsentView {
			get {
				if( _UnityConnectConsentView == null) {
					_UnityConnectConsentView = Type.GetType( "UnityEditor.Connect.UnityConnectConsentView, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _UnityConnectConsentView;
			}
		}
			
		static Type _UnityConnectEditorWindow;
		public static Type UnityConnectEditorWindow {
			get {
				if( _UnityConnectEditorWindow == null) {
					_UnityConnectEditorWindow = Type.GetType( "UnityEditor.Connect.UnityConnectEditorWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _UnityConnectEditorWindow;
			}
		}
			
		static Type _WebViewEditorStaticWindow;
		public static Type WebViewEditorStaticWindow {
			get {
				if( _WebViewEditorStaticWindow == null) {
					_WebViewEditorStaticWindow = Type.GetType( "UnityEditor.Web.WebViewEditorStaticWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _WebViewEditorStaticWindow;
			}
		}
			
		static Type _WebViewEditorWindow;
		public static Type WebViewEditorWindow {
			get {
				if( _WebViewEditorWindow == null) {
					_WebViewEditorWindow = Type.GetType( "UnityEditor.Web.WebViewEditorWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _WebViewEditorWindow;
			}
		}
			
		static Type _WebViewEditorWindowTabs;
		public static Type WebViewEditorWindowTabs {
			get {
				if( _WebViewEditorWindowTabs == null) {
					_WebViewEditorWindowTabs = Type.GetType( "UnityEditor.Web.WebViewEditorWindowTabs, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _WebViewEditorWindowTabs;
			}
		}
			
		static Type _AddComponentWindow;
		public static Type AddComponentWindow {
			get {
				if( _AddComponentWindow == null) {
					_AddComponentWindow = Type.GetType( "UnityEditor.AddComponent.AddComponentWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AddComponentWindow;
			}
		}
			
		static Type _TreeViewTestWindow;
		public static Type TreeViewTestWindow {
			get {
				if( _TreeViewTestWindow == null) {
					_TreeViewTestWindow = Type.GetType( "UnityEditor.TreeViewExamples.TreeViewTestWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _TreeViewTestWindow;
			}
		}
			
		static Type _EditorToolWindow;
		public static Type EditorToolWindow {
			get {
				if( _EditorToolWindow == null) {
					_EditorToolWindow = Type.GetType( "UnityEditor.EditorTools.EditorToolWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _EditorToolWindow;
			}
		}
			
		static Type _AdvancedDropdownWindow;
		public static Type AdvancedDropdownWindow {
			get {
				if( _AdvancedDropdownWindow == null) {
					_AdvancedDropdownWindow = Type.GetType( "UnityEditor.IMGUI.Controls.AdvancedDropdownWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AdvancedDropdownWindow;
			}
		}
			
		static Type _CollabPublishDialog;
		public static Type CollabPublishDialog {
			get {
				if( _CollabPublishDialog == null) {
					_CollabPublishDialog = Type.GetType( "UnityEditor.Collaboration.CollabPublishDialog, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _CollabPublishDialog;
			}
		}
			
		static Type _CollabCannotPublishDialog;
		public static Type CollabCannotPublishDialog {
			get {
				if( _CollabCannotPublishDialog == null) {
					_CollabCannotPublishDialog = Type.GetType( "UnityEditor.Collaboration.CollabCannotPublishDialog, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _CollabCannotPublishDialog;
			}
		}
			
		static Type _PackerWindow;
		public static Type PackerWindow {
			get {
				if( _PackerWindow == null) {
					_PackerWindow = Type.GetType( "UnityEditor.Sprites.PackerWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PackerWindow;
			}
		}
			
		static Type _UIElementsEditorWindowCreator;
		public static Type UIElementsEditorWindowCreator {
			get {
				if( _UIElementsEditorWindowCreator == null) {
					_UIElementsEditorWindowCreator = Type.GetType( "UnityEditor.UIElements.UIElementsEditorWindowCreator, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _UIElementsEditorWindowCreator;
			}
		}
			
		static Type _UIElementsSamples;
		public static Type UIElementsSamples {
			get {
				if( _UIElementsSamples == null) {
					_UIElementsSamples = Type.GetType( "UnityEditor.UIElements.Samples.UIElementsSamples, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _UIElementsSamples;
			}
		}
			
		static Type _PanelDebugger;
		public static Type PanelDebugger {
			get {
				if( _PanelDebugger == null) {
					_PanelDebugger = Type.GetType( "UnityEditor.UIElements.Debugger.PanelDebugger, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _PanelDebugger;
			}
		}
			
		static Type _UIElementsDebugger;
		public static Type UIElementsDebugger {
			get {
				if( _UIElementsDebugger == null) {
					_UIElementsDebugger = Type.GetType( "UnityEditor.UIElements.Debugger.UIElementsDebugger, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _UIElementsDebugger;
			}
		}
			
		static Type _UIElementsEventsDebugger;
		public static Type UIElementsEventsDebugger {
			get {
				if( _UIElementsEventsDebugger == null) {
					_UIElementsEventsDebugger = Type.GetType( "UnityEditor.UIElements.Debugger.UIElementsEventsDebugger, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _UIElementsEventsDebugger;
			}
		}
			
		static Type _AllocatorDebugger;
		public static Type AllocatorDebugger {
			get {
				if( _AllocatorDebugger == null) {
					_AllocatorDebugger = Type.GetType( "UnityEditor.UIElements.Debugger.AllocatorDebugger, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AllocatorDebugger;
			}
		}
			
		static Type _UIRDebugger;
		public static Type UIRDebugger {
			get {
				if( _UIRDebugger == null) {
					_UIRDebugger = Type.GetType( "UnityEditor.UIElements.Debugger.UIRDebugger, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _UIRDebugger;
			}
		}
			
		static Type _SearchWindow;
		public static Type SearchWindow {
			get {
				if( _SearchWindow == null) {
					_SearchWindow = Type.GetType( "UnityEditor.Experimental.GraphView.SearchWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _SearchWindow;
			}
		}
			
		static Type _GraphViewBlackboardWindow;
		public static Type GraphViewBlackboardWindow {
			get {
				if( _GraphViewBlackboardWindow == null) {
					_GraphViewBlackboardWindow = Type.GetType( "UnityEditor.Experimental.GraphView.GraphViewBlackboardWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _GraphViewBlackboardWindow;
			}
		}
			
		static Type _GraphViewEditorWindow;
		public static Type GraphViewEditorWindow {
			get {
				if( _GraphViewEditorWindow == null) {
					_GraphViewEditorWindow = Type.GetType( "UnityEditor.Experimental.GraphView.GraphViewEditorWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _GraphViewEditorWindow;
			}
		}
			
		static Type _GraphViewMinimapWindow;
		public static Type GraphViewMinimapWindow {
			get {
				if( _GraphViewMinimapWindow == null) {
					_GraphViewMinimapWindow = Type.GetType( "UnityEditor.Experimental.GraphView.GraphViewMinimapWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _GraphViewMinimapWindow;
			}
		}
			
		static Type _GraphViewToolWindow;
		public static Type GraphViewToolWindow {
			get {
				if( _GraphViewToolWindow == null) {
					_GraphViewToolWindow = Type.GetType( "UnityEditor.Experimental.GraphView.GraphViewToolWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _GraphViewToolWindow;
			}
		}
			
		static Type _AttachToPlayerPlayerIPWindow;
		public static Type AttachToPlayerPlayerIPWindow {
			get {
				if( _AttachToPlayerPlayerIPWindow == null) {
					_AttachToPlayerPlayerIPWindow = Type.GetType( "UnityEditor.Experimental.Networking.PlayerConnection.AttachToPlayerPlayerIPWindow, UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AttachToPlayerPlayerIPWindow;
			}
		}
			
		static Type _AnimatorControllerTool;
		public static Type AnimatorControllerTool {
			get {
				if( _AnimatorControllerTool == null) {
					_AnimatorControllerTool = Type.GetType( "UnityEditor.Graphs.AnimatorControllerTool, UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AnimatorControllerTool;
			}
		}
			
		static Type _LayerSettingsWindow;
		public static Type LayerSettingsWindow {
			get {
				if( _LayerSettingsWindow == null) {
					_LayerSettingsWindow = Type.GetType( "UnityEditor.Graphs.LayerSettingsWindow, UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _LayerSettingsWindow;
			}
		}
			
		static Type _ParameterControllerEditor;
		public static Type ParameterControllerEditor {
			get {
				if( _ParameterControllerEditor == null) {
					_ParameterControllerEditor = Type.GetType( "UnityEditor.Graphs.ParameterControllerEditor, UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _ParameterControllerEditor;
			}
		}
			
		static Type _AddStateMachineBehaviourComponentWindow;
		public static Type AddStateMachineBehaviourComponentWindow {
			get {
				if( _AddStateMachineBehaviourComponentWindow == null) {
					_AddStateMachineBehaviourComponentWindow = Type.GetType( "UnityEditor.Graphs.AnimationStateMachine.AddStateMachineBehaviourComponentWindow, UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _AddStateMachineBehaviourComponentWindow;
			}
		}
			
		//static Type _TimelineWindow;
		//public static Type TimelineWindow {
		//	get {
		//		if( _TimelineWindow == null) {
		//			_TimelineWindow = Type.GetType( "UnityEditor.Timeline.TimelineWindow, Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" );
		//		}
		//		return _TimelineWindow;
		//	}
		//}
			
		static Type _CopyMaterialParameter;
		public static Type CopyMaterialParameter {
			get {
				if( _CopyMaterialParameter == null) {
					_CopyMaterialParameter = Type.GetType( "UnityEditor.Rendering.Universal.Toon.CopyMaterialParameter, Unity.UniversalToonShader.Urp.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _CopyMaterialParameter;
			}
		}
			
		static Type _DebugWindow;
		public static Type DebugWindow {
			get {
				if( _DebugWindow == null) {
					_DebugWindow = Type.GetType( "UnityEditor.Rendering.DebugWindow, Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _DebugWindow;
			}
		}
			
		static Type _FilterWindow;
		public static Type FilterWindow {
			get {
				if( _FilterWindow == null) {
					_FilterWindow = Type.GetType( "UnityEditor.Rendering.FilterWindow, Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _FilterWindow;
			}
		}
			
		static Type _DisplayWindow;
		public static Type DisplayWindow {
			get {
				if( _DisplayWindow == null) {
					_DisplayWindow = Type.GetType( "UnityEditor.Rendering.LookDev.DisplayWindow, Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _DisplayWindow;
			}
		}
			
		static Type _TestRunnerWindow;
		public static Type TestRunnerWindow {
			get {
				if( _TestRunnerWindow == null) {
					_TestRunnerWindow = Type.GetType( "UnityEditor.TestTools.TestRunner.TestRunnerWindow, UnityEditor.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _TestRunnerWindow;
			}
		}
			
		static Type _SpriteEditorMenu;
		public static Type SpriteEditorMenu {
			get {
				if( _SpriteEditorMenu == null) {
					_SpriteEditorMenu = Type.GetType( "UnityEditor.U2D.Sprites.SpriteEditorMenu, Unity.2D.Sprite.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _SpriteEditorMenu;
			}
		}
			
		static Type _SpriteEditorWindow;
		public static Type SpriteEditorWindow {
			get {
				if( _SpriteEditorWindow == null) {
					_SpriteEditorWindow = Type.GetType( "UnityEditor.U2D.Sprites.SpriteEditorWindow, Unity.2D.Sprite.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _SpriteEditorWindow;
			}
		}
			
		static Type _SpriteUtilityWindow;
		public static Type SpriteUtilityWindow {
			get {
				if( _SpriteUtilityWindow == null) {
					_SpriteUtilityWindow = Type.GetType( "UnityEditor.U2D.Sprites.SpriteUtilityWindow, Unity.2D.Sprite.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _SpriteUtilityWindow;
			}
		}
			
		//static Type _GridPaintPaletteWindow;
		//public static Type GridPaintPaletteWindow {
		//	get {
		//		if( _GridPaintPaletteWindow == null) {
		//			_GridPaintPaletteWindow = Type.GetType( "UnityEditor.Tilemaps.GridPaintPaletteWindow, Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
		//		}
		//		return _GridPaintPaletteWindow;
		//	}
		//}
			
		static Type _GridPaletteAddPopup;
		public static Type GridPaletteAddPopup {
			get {
				if( _GridPaletteAddPopup == null) {
					_GridPaletteAddPopup = Type.GetType( "UnityEditor.Tilemaps.GridPaletteAddPopup, Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _GridPaletteAddPopup;
			}
		}
			
		static Type _MaterialGraphEditWindow;
		public static Type MaterialGraphEditWindow {
			get {
				if( _MaterialGraphEditWindow == null) {
					_MaterialGraphEditWindow = Type.GetType( "UnityEditor.ShaderGraph.Drawing.MaterialGraphEditWindow, Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );
				}
				return _MaterialGraphEditWindow;
			}
		}
			
	}
}
