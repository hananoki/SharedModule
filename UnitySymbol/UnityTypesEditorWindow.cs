using System;
namespace HananokiEditor {
	public static partial class UnityTypes {
#if false
		static Type _HolographicEmulationWindow;
		public static Type HolographicEmulationWindow {
			get {
				if( _HolographicEmulationWindow == null ) {
					_HolographicEmulationWindow = Get( "UnityEngine.XR.WSA.HolographicEmulationWindow", kUnityEditor );
				}
				return _HolographicEmulationWindow;
			}
		}



		static Type _IconSelector;
		public static Type IconSelector {
			get {
				if( _IconSelector == null ) {
					_IconSelector = Get( "UnityEditor.IconSelector", kUnityEditor );
				}
				return _IconSelector;
			}
		}

		static Type _ObjectSelector;
		public static Type ObjectSelector {
			get {
				if( _ObjectSelector == null ) {
					_ObjectSelector = Get( "UnityEditor.ObjectSelector", kUnityEditor );
				}
				return _ObjectSelector;
			}
		}


		static Type _ProjectTemplateWindow;
		public static Type ProjectTemplateWindow {
			get {
				if( _ProjectTemplateWindow == null ) {
					_ProjectTemplateWindow = Get( "UnityEditor.ProjectTemplateWindow", kUnityEditor );
				}
				return _ProjectTemplateWindow;
			}
		}

		static Type _RagdollBuilder;
		public static Type RagdollBuilder {
			get {
				if( _RagdollBuilder == null ) {
					_RagdollBuilder = Get( "UnityEditor.RagdollBuilder", kUnityEditor );
				}
				return _RagdollBuilder;
			}
		}

		static Type _SceneHierarchySortingWindow;
		public static Type SceneHierarchySortingWindow {
			get {
				if( _SceneHierarchySortingWindow == null ) {
					_SceneHierarchySortingWindow = Get( "UnityEditor.SceneHierarchySortingWindow", kUnityEditor );
				}
				return _SceneHierarchySortingWindow;
			}
		}


		static Type _ScriptableWizard;
		public static Type ScriptableWizard {
			get {
				if( _ScriptableWizard == null ) {
					_ScriptableWizard = Get( "UnityEditor.ScriptableWizard", kUnityEditor );
				}
				return _ScriptableWizard;
			}
		}


		static Type _CurveEditorWindow;
		public static Type CurveEditorWindow {
			get {
				if( _CurveEditorWindow == null ) {
					_CurveEditorWindow = Get( "UnityEditor.CurveEditorWindow", kUnityEditor );
				}
				return _CurveEditorWindow;
			}
		}

		static Type _MinMaxCurveEditorWindow;
		public static Type MinMaxCurveEditorWindow {
			get {
				if( _MinMaxCurveEditorWindow == null ) {
					_MinMaxCurveEditorWindow = Get( "UnityEditor.MinMaxCurveEditorWindow", kUnityEditor );
				}
				return _MinMaxCurveEditorWindow;
			}
		}

		static Type _AnnotationWindow;
		public static Type AnnotationWindow {
			get {
				if( _AnnotationWindow == null ) {
					_AnnotationWindow = Get( "UnityEditor.AnnotationWindow", kUnityEditor );
				}
				return _AnnotationWindow;
			}
		}

		static Type _LayerVisibilityWindow;
		public static Type LayerVisibilityWindow {
			get {
				if( _LayerVisibilityWindow == null ) {
					_LayerVisibilityWindow = Get( "UnityEditor.LayerVisibilityWindow", kUnityEditor );
				}
				return _LayerVisibilityWindow;
			}
		}

		static Type _AssetStoreLoginWindow;
		public static Type AssetStoreLoginWindow {
			get {
				if( _AssetStoreLoginWindow == null ) {
					_AssetStoreLoginWindow = Get( "UnityEditor.AssetStoreLoginWindow", kUnityEditor );
				}
				return _AssetStoreLoginWindow;
			}
		}




		static Type _SnapSettingsWindow;
		public static Type SnapSettingsWindow {
			get {
				if( _SnapSettingsWindow == null ) {
					_SnapSettingsWindow = Get( "UnityEditor.SnapSettingsWindow", kUnityEditor );
				}
				return _SnapSettingsWindow;
			}
		}

		static Type _AboutWindow;
		public static Type AboutWindow {
			get {
				if( _AboutWindow == null ) {
					_AboutWindow = Get( "UnityEditor.AboutWindow", kUnityEditor );
				}
				return _AboutWindow;
			}
		}

		static Type _AssetSaveDialog;
		public static Type AssetSaveDialog {
			get {
				if( _AssetSaveDialog == null ) {
					_AssetSaveDialog = Get( "UnityEditor.AssetSaveDialog", kUnityEditor );
				}
				return _AssetSaveDialog;
			}
		}

		static Type _BumpMapSettingsFixingWindow;
		public static Type BumpMapSettingsFixingWindow {
			get {
				if( _BumpMapSettingsFixingWindow == null ) {
					_BumpMapSettingsFixingWindow = Get( "UnityEditor.BumpMapSettingsFixingWindow", kUnityEditor );
				}
				return _BumpMapSettingsFixingWindow;
			}
		}

		static Type _ColorPicker;
		public static Type ColorPicker {
			get {
				if( _ColorPicker == null ) {
					_ColorPicker = Get( "UnityEditor.ColorPicker", kUnityEditor );
				}
				return _ColorPicker;
			}
		}

		static Type _EditorUpdateWindow;
		public static Type EditorUpdateWindow {
			get {
				if( _EditorUpdateWindow == null ) {
					_EditorUpdateWindow = Get( "UnityEditor.EditorUpdateWindow", kUnityEditor );
				}
				return _EditorUpdateWindow;
			}
		}

		static Type _FallbackEditorWindow;
		public static Type FallbackEditorWindow {
			get {
				if( _FallbackEditorWindow == null ) {
					_FallbackEditorWindow = Get( "UnityEditor.FallbackEditorWindow", kUnityEditor );
				}
				return _FallbackEditorWindow;
			}
		}

		static Type _GradientPicker;
		public static Type GradientPicker {
			get {
				if( _GradientPicker == null ) {
					_GradientPicker = Get( "UnityEditor.GradientPicker", kUnityEditor );
				}
				return _GradientPicker;
			}
		}

		static Type _PackageExport;
		public static Type PackageExport {
			get {
				if( _PackageExport == null ) {
					_PackageExport = Get( "UnityEditor.PackageExport", kUnityEditor );
				}
				return _PackageExport;
			}
		}

		static Type _PackageImport;
		public static Type PackageImport {
			get {
				if( _PackageImport == null ) {
					_PackageImport = Get( "UnityEditor.PackageImport", kUnityEditor );
				}
				return _PackageImport;
			}
		}

		static Type _PopupWindow;
		public static Type PopupWindow {
			get {
				if( _PopupWindow == null ) {
					_PopupWindow = Get( "UnityEditor.PopupWindow", kUnityEditor );
				}
				return _PopupWindow;
			}
		}

		static Type _PopupWindowWithoutFocus;
		public static Type PopupWindowWithoutFocus {
			get {
				if( _PopupWindowWithoutFocus == null ) {
					_PopupWindowWithoutFocus = Get( "UnityEditor.PopupWindowWithoutFocus", kUnityEditor );
				}
				return _PopupWindowWithoutFocus;
			}
		}

		static Type _PragmaFixingWindow;
		public static Type PragmaFixingWindow {
			get {
				if( _PragmaFixingWindow == null ) {
					_PragmaFixingWindow = Get( "UnityEditor.PragmaFixingWindow", kUnityEditor );
				}
				return _PragmaFixingWindow;
			}
		}

		static Type _SaveWindowLayout;
		public static Type SaveWindowLayout {
			get {
				if( _SaveWindowLayout == null ) {
					_SaveWindowLayout = Get( "UnityEditor.SaveWindowLayout", kUnityEditor );
				}
				return _SaveWindowLayout;
			}
		}

		static Type _DeleteWindowLayout;
		public static Type DeleteWindowLayout {
			get {
				if( _DeleteWindowLayout == null ) {
					_DeleteWindowLayout = Get( "UnityEditor.DeleteWindowLayout", kUnityEditor );
				}
				return _DeleteWindowLayout;
			}
		}

		static Type _GUIViewDebuggerWindow;
		public static Type GUIViewDebuggerWindow {
			get {
				if( _GUIViewDebuggerWindow == null ) {
					_GUIViewDebuggerWindow = Get( "UnityEditor.GUIViewDebuggerWindow", kUnityEditor );
				}
				return _GUIViewDebuggerWindow;
			}
		}


		static Type _PreviewWindow;
		public static Type PreviewWindow {
			get {
				if( _PreviewWindow == null ) {
					_PreviewWindow = Get( "UnityEditor.PreviewWindow", kUnityEditor );
				}
				return _PreviewWindow;
			}
		}

		static Type _AddShaderVariantWindow;
		public static Type AddShaderVariantWindow {
			get {
				if( _AddShaderVariantWindow == null ) {
					_AddShaderVariantWindow = Get( "UnityEditor.AddShaderVariantWindow", kUnityEditor );
				}
				return _AddShaderVariantWindow;
			}
		}

		static Type _FrameDebuggerWindow;
		public static Type FrameDebuggerWindow {
			get {
				if( _FrameDebuggerWindow == null ) {
					_FrameDebuggerWindow = Get( "UnityEditor.FrameDebuggerWindow", kUnityEditor );
				}
				return _FrameDebuggerWindow;
			}
		}

		static Type _PlayModeView;
		public static Type PlayModeView {
			get {
				if( _PlayModeView == null ) {
					_PlayModeView = Get( "UnityEditor.PlayModeView", kUnityEditor );
				}
				return _PlayModeView;
			}
		}

		static Type _SearchableEditorWindow;
		public static Type SearchableEditorWindow {
			get {
				if( _SearchableEditorWindow == null ) {
					_SearchableEditorWindow = Get( "UnityEditor.SearchableEditorWindow", kUnityEditor );
				}
				return _SearchableEditorWindow;
			}
		}



		static Type _LightmapPreviewWindow;
		public static Type LightmapPreviewWindow {
			get {
				if( _LightmapPreviewWindow == null ) {
					_LightmapPreviewWindow = Get( "UnityEditor.LightmapPreviewWindow", kUnityEditor );
				}
				return _LightmapPreviewWindow;
			}
		}

		static Type _NavMeshEditorWindow;
		public static Type NavMeshEditorWindow {
			get {
				if( _NavMeshEditorWindow == null ) {
					_NavMeshEditorWindow = Get( "UnityEditor.NavMeshEditorWindow", kUnityEditor );
				}
				return _NavMeshEditorWindow;
			}
		}

		static Type _OcclusionCullingWindow;
		public static Type OcclusionCullingWindow {
			get {
				if( _OcclusionCullingWindow == null ) {
					_OcclusionCullingWindow = Get( "UnityEditor.OcclusionCullingWindow", kUnityEditor );
				}
				return _OcclusionCullingWindow;
			}
		}

		static Type _PhysicsDebugWindow;
		public static Type PhysicsDebugWindow {
			get {
				if( _PhysicsDebugWindow == null ) {
					_PhysicsDebugWindow = Get( "UnityEditor.PhysicsDebugWindow", kUnityEditor );
				}
				return _PhysicsDebugWindow;
			}
		}

		static Type _TierSettingsWindow;
		public static Type TierSettingsWindow {
			get {
				if( _TierSettingsWindow == null ) {
					_TierSettingsWindow = Get( "UnityEditor.TierSettingsWindow", kUnityEditor );
				}
				return _TierSettingsWindow;
			}
		}


		static Type _SettingsWindow;
		public static Type SettingsWindow {
			get {
				if( _SettingsWindow == null ) {
					_SettingsWindow = Get( "UnityEditor.SettingsWindow", kUnityEditor );
				}
				return _SettingsWindow;
			}
		}

		static Type _ProjectSettingsWindow;
		public static Type ProjectSettingsWindow {
			get {
				if( _ProjectSettingsWindow == null ) {
					_ProjectSettingsWindow = Get( "UnityEditor.ProjectSettingsWindow", kUnityEditor );
				}
				return _ProjectSettingsWindow;
			}
		}

		static Type _PreferenceSettingsWindow;
		public static Type PreferenceSettingsWindow {
			get {
				if( _PreferenceSettingsWindow == null ) {
					_PreferenceSettingsWindow = Get( "UnityEditor.PreferenceSettingsWindow", kUnityEditor );
				}
				return _PreferenceSettingsWindow;
			}
		}

		static Type _SpriteUtilityWindow;
		public static Type SpriteUtilityWindow {
			get {
				if( _SpriteUtilityWindow == null ) {
					_SpriteUtilityWindow = Get( "UnityEditor.SpriteUtilityWindow", kUnityEditor );
				}
				return _SpriteUtilityWindow;
			}
		}

		static Type _UndoWindow;
		public static Type UndoWindow {
			get {
				if( _UndoWindow == null ) {
					_UndoWindow = Get( "UnityEditor.UndoWindow", kUnityEditor );
				}
				return _UndoWindow;
			}
		}

		static Type _MetroCertificatePasswordWindow;
		public static Type MetroCertificatePasswordWindow {
			get {
				if( _MetroCertificatePasswordWindow == null ) {
					_MetroCertificatePasswordWindow = Get( "UnityEditor.MetroCertificatePasswordWindow", kUnityEditor );
				}
				return _MetroCertificatePasswordWindow;
			}
		}

		static Type _MetroCreateTestCertificateWindow;
		public static Type MetroCreateTestCertificateWindow {
			get {
				if( _MetroCreateTestCertificateWindow == null ) {
					_MetroCreateTestCertificateWindow = Get( "UnityEditor.MetroCreateTestCertificateWindow", kUnityEditor );
				}
				return _MetroCreateTestCertificateWindow;
			}
		}

		static Type _LicenseManagementWindow;
		public static Type LicenseManagementWindow {
			get {
				if( _LicenseManagementWindow == null ) {
					_LicenseManagementWindow = Get( "UnityEditor.LicenseManagementWindow", kUnityEditor );
				}
				return _LicenseManagementWindow;
			}
		}

		static Type _ParticleSystemWindow;
		public static Type ParticleSystemWindow {
			get {
				if( _ParticleSystemWindow == null ) {
					_ParticleSystemWindow = Get( "UnityEditor.ParticleSystemWindow", kUnityEditor );
				}
				return _ParticleSystemWindow;
			}
		}


		static Type _UISystemPreviewWindow;
		public static Type UISystemPreviewWindow {
			get {
				if( _UISystemPreviewWindow == null ) {
					_UISystemPreviewWindow = Get( "UnityEditor.UISystemPreviewWindow", kUnityEditor );
				}
				return _UISystemPreviewWindow;
			}
		}

		static Type _SketchUpImportDlg;
		public static Type SketchUpImportDlg {
			get {
				if( _SketchUpImportDlg == null ) {
					_SketchUpImportDlg = Get( "UnityEditor.SketchUpImportDlg", kUnityEditor );
				}
				return _SketchUpImportDlg;
			}
		}

		static Type _TerrainWizard;
		public static Type TerrainWizard {
			get {
				if( _TerrainWizard == null ) {
					_TerrainWizard = Get( "UnityEditor.TerrainWizard", kUnityEditor );
				}
				return _TerrainWizard;
			}
		}

		static Type _ImportRawHeightmap;
		public static Type ImportRawHeightmap {
			get {
				if( _ImportRawHeightmap == null ) {
					_ImportRawHeightmap = Get( "UnityEditor.ImportRawHeightmap", kUnityEditor );
				}
				return _ImportRawHeightmap;
			}
		}

		static Type _ExportRawHeightmap;
		public static Type ExportRawHeightmap {
			get {
				if( _ExportRawHeightmap == null ) {
					_ExportRawHeightmap = Get( "UnityEditor.ExportRawHeightmap", kUnityEditor );
				}
				return _ExportRawHeightmap;
			}
		}

		static Type _TreeWizard;
		public static Type TreeWizard {
			get {
				if( _TreeWizard == null ) {
					_TreeWizard = Get( "UnityEditor.TreeWizard", kUnityEditor );
				}
				return _TreeWizard;
			}
		}

		static Type _DetailMeshWizard;
		public static Type DetailMeshWizard {
			get {
				if( _DetailMeshWizard == null ) {
					_DetailMeshWizard = Get( "UnityEditor.DetailMeshWizard", kUnityEditor );
				}
				return _DetailMeshWizard;
			}
		}

		static Type _DetailTextureWizard;
		public static Type DetailTextureWizard {
			get {
				if( _DetailTextureWizard == null ) {
					_DetailTextureWizard = Get( "UnityEditor.DetailTextureWizard", kUnityEditor );
				}
				return _DetailTextureWizard;
			}
		}

		static Type _PlaceTreeWizard;
		public static Type PlaceTreeWizard {
			get {
				if( _PlaceTreeWizard == null ) {
					_PlaceTreeWizard = Get( "UnityEditor.PlaceTreeWizard", kUnityEditor );
				}
				return _PlaceTreeWizard;
			}
		}

		static Type _FlattenHeightmap;
		public static Type FlattenHeightmap {
			get {
				if( _FlattenHeightmap == null ) {
					_FlattenHeightmap = Get( "UnityEditor.FlattenHeightmap", kUnityEditor );
				}
				return _FlattenHeightmap;
			}
		}

		static Type _TestEditorWindow;
		public static Type TestEditorWindow {
			get {
				if( _TestEditorWindow == null ) {
					_TestEditorWindow = Get( "UnityEditor.UIAutomation.TestEditorWindow", kUnityEditor );
				}
				return _TestEditorWindow;
			}
		}

		static Type _ConflictResolverWindow;
		public static Type ConflictResolverWindow {
			get {
				if( _ConflictResolverWindow == null ) {
					_ConflictResolverWindow = Get( "UnityEditor.ShortcutManagement.ConflictResolverWindow", kUnityEditor );
				}
				return _ConflictResolverWindow;
			}
		}

		static Type _DeleteShortcutProfileWindow;
		public static Type DeleteShortcutProfileWindow {
			get {
				if( _DeleteShortcutProfileWindow == null ) {
					_DeleteShortcutProfileWindow = Get( "UnityEditor.ShortcutManagement.DeleteShortcutProfileWindow", kUnityEditor );
				}
				return _DeleteShortcutProfileWindow;
			}
		}

		static Type _PromptWindow;
		public static Type PromptWindow {
			get {
				if( _PromptWindow == null ) {
					_PromptWindow = Get( "UnityEditor.ShortcutManagement.PromptWindow", kUnityEditor );
				}
				return _PromptWindow;
			}
		}

		static Type _ShortcutManagerWindow;
		public static Type ShortcutManagerWindow {
			get {
				if( _ShortcutManagerWindow == null ) {
					_ShortcutManagerWindow = Get( "UnityEditor.ShortcutManagement.ShortcutManagerWindow", kUnityEditor );
				}
				return _ShortcutManagerWindow;
			}
		}

		static Type _PresetSelector;
		public static Type PresetSelector {
			get {
				if( _PresetSelector == null ) {
					_PresetSelector = Get( "UnityEditor.Presets.PresetSelector", kUnityEditor );
				}
				return _PresetSelector;
			}
		}

		static Type _AddPresetTypeWindow;
		public static Type AddPresetTypeWindow {
			get {
				if( _AddPresetTypeWindow == null ) {
					_AddPresetTypeWindow = Get( "UnityEditor.Presets.AddPresetTypeWindow", kUnityEditor );
				}
				return _AddPresetTypeWindow;
			}
		}

		static Type _PackageManagerWindow;
		public static Type PackageManagerWindow {
			get {
				if( _PackageManagerWindow == null ) {
					_PackageManagerWindow = Get( "UnityEditor.PackageManager.UI.PackageManagerWindow", kUnityEditor );
				}
				return _PackageManagerWindow;
			}
		}

		static Type _WindowChange;
		public static Type WindowChange {
			get {
				if( _WindowChange == null ) {
					_WindowChange = Get( "UnityEditor.VersionControl.WindowChange", kUnityEditor );
				}
				return _WindowChange;
			}
		}

		static Type _WindowCheckoutFailure;
		public static Type WindowCheckoutFailure {
			get {
				if( _WindowCheckoutFailure == null ) {
					_WindowCheckoutFailure = Get( "UnityEditor.VersionControl.WindowCheckoutFailure", kUnityEditor );
				}
				return _WindowCheckoutFailure;
			}
		}

		static Type _WindowPending;
		public static Type WindowPending {
			get {
				if( _WindowPending == null ) {
					_WindowPending = Get( "UnityEditor.VersionControl.WindowPending", kUnityEditor );
				}
				return _WindowPending;
			}
		}

		static Type _WindowResolve;
		public static Type WindowResolve {
			get {
				if( _WindowResolve == null ) {
					_WindowResolve = Get( "UnityEditor.VersionControl.WindowResolve", kUnityEditor );
				}
				return _WindowResolve;
			}
		}

		static Type _WindowRevert;
		public static Type WindowRevert {
			get {
				if( _WindowRevert == null ) {
					_WindowRevert = Get( "UnityEditor.VersionControl.WindowRevert", kUnityEditor );
				}
				return _WindowRevert;
			}
		}

		static Type _UnityConnectConsentView;
		public static Type UnityConnectConsentView {
			get {
				if( _UnityConnectConsentView == null ) {
					_UnityConnectConsentView = Get( "UnityEditor.Connect.UnityConnectConsentView", kUnityEditor );
				}
				return _UnityConnectConsentView;
			}
		}

		static Type _UnityConnectEditorWindow;
		public static Type UnityConnectEditorWindow {
			get {
				if( _UnityConnectEditorWindow == null ) {
					_UnityConnectEditorWindow = Get( "UnityEditor.Connect.UnityConnectEditorWindow", kUnityEditor );
				}
				return _UnityConnectEditorWindow;
			}
		}

		static Type _WebViewEditorStaticWindow;
		public static Type WebViewEditorStaticWindow {
			get {
				if( _WebViewEditorStaticWindow == null ) {
					_WebViewEditorStaticWindow = Get( "UnityEditor.Web.WebViewEditorStaticWindow", kUnityEditor );
				}
				return _WebViewEditorStaticWindow;
			}
		}

		static Type _WebViewEditorWindow;
		public static Type WebViewEditorWindow {
			get {
				if( _WebViewEditorWindow == null ) {
					_WebViewEditorWindow = Get( "UnityEditor.Web.WebViewEditorWindow", kUnityEditor );
				}
				return _WebViewEditorWindow;
			}
		}

		static Type _WebViewEditorWindowTabs;
		public static Type WebViewEditorWindowTabs {
			get {
				if( _WebViewEditorWindowTabs == null ) {
					_WebViewEditorWindowTabs = Get( "UnityEditor.Web.WebViewEditorWindowTabs", kUnityEditor );
				}
				return _WebViewEditorWindowTabs;
			}
		}

		static Type _AddComponentWindow;
		public static Type AddComponentWindow {
			get {
				if( _AddComponentWindow == null ) {
					_AddComponentWindow = Get( "UnityEditor.AddComponent.AddComponentWindow", kUnityEditor );
				}
				return _AddComponentWindow;
			}
		}

		static Type _TreeViewTestWindow;
		public static Type TreeViewTestWindow {
			get {
				if( _TreeViewTestWindow == null ) {
					_TreeViewTestWindow = Get( "UnityEditor.TreeViewExamples.TreeViewTestWindow", kUnityEditor );
				}
				return _TreeViewTestWindow;
			}
		}

		static Type _EditorToolWindow;
		public static Type EditorToolWindow {
			get {
				if( _EditorToolWindow == null ) {
					_EditorToolWindow = Get( "UnityEditor.EditorTools.EditorToolWindow", kUnityEditor );
				}
				return _EditorToolWindow;
			}
		}

		static Type _AdvancedDropdownWindow;
		public static Type AdvancedDropdownWindow {
			get {
				if( _AdvancedDropdownWindow == null ) {
					_AdvancedDropdownWindow = Get( "UnityEditor.IMGUI.Controls.AdvancedDropdownWindow", kUnityEditor );
				}
				return _AdvancedDropdownWindow;
			}
		}

		static Type _CollabPublishDialog;
		public static Type CollabPublishDialog {
			get {
				if( _CollabPublishDialog == null ) {
					_CollabPublishDialog = Get( "UnityEditor.Collaboration.CollabPublishDialog", kUnityEditor );
				}
				return _CollabPublishDialog;
			}
		}

		static Type _CollabCannotPublishDialog;
		public static Type CollabCannotPublishDialog {
			get {
				if( _CollabCannotPublishDialog == null ) {
					_CollabCannotPublishDialog = Get( "UnityEditor.Collaboration.CollabCannotPublishDialog", kUnityEditor );
				}
				return _CollabCannotPublishDialog;
			}
		}

		static Type _PackerWindow;
		public static Type PackerWindow {
			get {
				if( _PackerWindow == null ) {
					_PackerWindow = Get( "UnityEditor.Sprites.PackerWindow", kUnityEditor );
				}
				return _PackerWindow;
			}
		}

		static Type _UIElementsEditorWindowCreator;
		public static Type UIElementsEditorWindowCreator {
			get {
				if( _UIElementsEditorWindowCreator == null ) {
					_UIElementsEditorWindowCreator = Get( "UnityEditor.UIElements.UIElementsEditorWindowCreator", kUnityEditor );
				}
				return _UIElementsEditorWindowCreator;
			}
		}

		static Type _UIElementsSamples;
		public static Type UIElementsSamples {
			get {
				if( _UIElementsSamples == null ) {
					_UIElementsSamples = Get( "UnityEditor.UIElements.Samples.UIElementsSamples", kUnityEditor );
				}
				return _UIElementsSamples;
			}
		}

		static Type _PanelDebugger;
		public static Type PanelDebugger {
			get {
				if( _PanelDebugger == null ) {
					_PanelDebugger = Get( "UnityEditor.UIElements.Debugger.PanelDebugger", kUnityEditor );
				}
				return _PanelDebugger;
			}
		}

		static Type _UIElementsDebugger;
		public static Type UIElementsDebugger {
			get {
				if( _UIElementsDebugger == null ) {
					_UIElementsDebugger = Get( "UnityEditor.UIElements.Debugger.UIElementsDebugger", kUnityEditor );
				}
				return _UIElementsDebugger;
			}
		}

		static Type _UIElementsEventsDebugger;
		public static Type UIElementsEventsDebugger {
			get {
				if( _UIElementsEventsDebugger == null ) {
					_UIElementsEventsDebugger = Get( "UnityEditor.UIElements.Debugger.UIElementsEventsDebugger", kUnityEditor );
				}
				return _UIElementsEventsDebugger;
			}
		}

		static Type _AllocatorDebugger;
		public static Type AllocatorDebugger {
			get {
				if( _AllocatorDebugger == null ) {
					_AllocatorDebugger = Get( "UnityEditor.UIElements.Debugger.AllocatorDebugger", kUnityEditor );
				}
				return _AllocatorDebugger;
			}
		}

		static Type _UIRDebugger;
		public static Type UIRDebugger {
			get {
				if( _UIRDebugger == null ) {
					_UIRDebugger = Get( "UnityEditor.UIElements.Debugger.UIRDebugger", kUnityEditor );
				}
				return _UIRDebugger;
			}
		}

		static Type _SearchWindow;
		public static Type SearchWindow {
			get {
				if( _SearchWindow == null ) {
					_SearchWindow = Get( "UnityEditor.Experimental.GraphView.SearchWindow", kUnityEditor );
				}
				return _SearchWindow;
			}
		}

		static Type _GraphViewBlackboardWindow;
		public static Type GraphViewBlackboardWindow {
			get {
				if( _GraphViewBlackboardWindow == null ) {
					_GraphViewBlackboardWindow = Get( "UnityEditor.Experimental.GraphView.GraphViewBlackboardWindow", kUnityEditor );
				}
				return _GraphViewBlackboardWindow;
			}
		}

		static Type _GraphViewEditorWindow;
		public static Type GraphViewEditorWindow {
			get {
				if( _GraphViewEditorWindow == null ) {
					_GraphViewEditorWindow = Get( "UnityEditor.Experimental.GraphView.GraphViewEditorWindow", kUnityEditor );
				}
				return _GraphViewEditorWindow;
			}
		}

		static Type _GraphViewMinimapWindow;
		public static Type GraphViewMinimapWindow {
			get {
				if( _GraphViewMinimapWindow == null ) {
					_GraphViewMinimapWindow = Get( "UnityEditor.Experimental.GraphView.GraphViewMinimapWindow", kUnityEditor );
				}
				return _GraphViewMinimapWindow;
			}
		}

		static Type _GraphViewToolWindow;
		public static Type GraphViewToolWindow {
			get {
				if( _GraphViewToolWindow == null ) {
					_GraphViewToolWindow = Get( "UnityEditor.Experimental.GraphView.GraphViewToolWindow", kUnityEditor );
				}
				return _GraphViewToolWindow;
			}
		}

		static Type _AttachToPlayerPlayerIPWindow;
		public static Type AttachToPlayerPlayerIPWindow {
			get {
				if( _AttachToPlayerPlayerIPWindow == null ) {
					_AttachToPlayerPlayerIPWindow = Get( "UnityEditor.Experimental.Networking.PlayerConnection.AttachToPlayerPlayerIPWindow", kUnityEditor );
				}
				return _AttachToPlayerPlayerIPWindow;
			}
		}

		static Type _AnimatorControllerTool;
		public static Type AnimatorControllerTool {
			get {
				if( _AnimatorControllerTool == null ) {
					_AnimatorControllerTool = Get( "UnityEditor.Graphs.AnimatorControllerTool", "UnityEditor.Graphs" );
				}
				return _AnimatorControllerTool;
			}
		}

		static Type _LayerSettingsWindow;
		public static Type LayerSettingsWindow {
			get {
				if( _LayerSettingsWindow == null ) {
					_LayerSettingsWindow = Get( "UnityEditor.Graphs.LayerSettingsWindow", "UnityEditor.Graphs" );
				}
				return _LayerSettingsWindow;
			}
		}

		static Type _ParameterControllerEditor;
		public static Type ParameterControllerEditor {
			get {
				if( _ParameterControllerEditor == null ) {
					_ParameterControllerEditor = Get( "UnityEditor.Graphs.ParameterControllerEditor", "UnityEditor.Graphs" );
				}
				return _ParameterControllerEditor;
			}
		}

		static Type _AddStateMachineBehaviourComponentWindow;
		public static Type AddStateMachineBehaviourComponentWindow {
			get {
				if( _AddStateMachineBehaviourComponentWindow == null ) {
					_AddStateMachineBehaviourComponentWindow = Get( "UnityEditor.Graphs.AnimationStateMachine.AddStateMachineBehaviourComponentWindow", "UnityEditor.Graphs" );
				}
				return _AddStateMachineBehaviourComponentWindow;
			}
		}



		static Type _GridPaletteAddPopup;
		public static Type GridPaletteAddPopup {
			get {
				if( _GridPaletteAddPopup == null ) {
					_GridPaletteAddPopup = Get( "UnityEditor.Tilemaps.GridPaletteAddPopup", "Unity.2D.Tilemap.Editor" );
				}
				return _GridPaletteAddPopup;
			}
		}
#endif
	}
}
