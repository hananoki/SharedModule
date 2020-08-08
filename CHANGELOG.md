# Shared Module

## [1.5.4] - 2020-08-08

### Added
- Added EditorWindowExtensions
- Added UnityTypes
- Added HEditorWindow.ShowConsoleWindow
- Added HEditorWindow.ShowAnimationWindow
- Added HEditorWindow.ShowAnimatorControllerTool
- Added HEditorWindow.ShowProfilerWindow
- Added HEditorWindow.ShowTimelineWindow
- Added HEditorWindow.FindArray
- Added HEditorWindow.Find
- Added UnityEditorGUIUtility.GetEditorAssetBundle
- Added UnityEditorGUIUtility.GetDefaultBackgroundColor

### Changed
- Adjusted the position of HEditorGUI.HeaderTitle
- Spaces are now inserted in HEditorGUILayout.HeaderTitle
- Built-in icon properties are automatically generated

## [1.5.3] - 2020-08-02

### Added
- Added EditorHelper.TravaseAllType
- Added EditorHelper.ShowInspector
- Added HGUIUtility.GUIToScreenRect
- Added EditorExtensions.GetCachedIcon
- Added EditorExtensions.GetAssetPath
- Added EditorExtensions.LoadAsset
- Added EditorExtensions.CalcSizeFromLabel
- Added EditorIcon.search_icon
- Added HEditorGUI.MiniLabelR
- Added HEditorGUI.ClickableIcon
- Added HTreeView.DisableSelectionStyle
- Added HTreeView.DrawLayoutGUI
- Added HTreeView.SetSelectionNone
- Added HexNumberAttribute

### Changed
- Changed argument of EditorHelper.DuplicateAsset
- Changed to deselect when clicking blank in HTreeView
- Separated the assembly of Hananoki.Attribute

## [1.5.2] - 2020-07-25

### Added
- Added GUIDStringAttribute
- Added IconWaitSpin

### Changed
- Support for both folders and files in fs.mv

### Fixed
- Fixed an issue with HReorderableList

## [1.5.1] - 2020-07-17

### Fixed
- Addressed an issue where the storage location of project settings would switch when ENABLE_HANANOKI_SETTINGS was defined.

## [1.5.0] - 2020-07-16

### Added
- Integrated settings menu added
  - ENABLE_HANANOKI_SETTINGS is required
- Added ReflectionUtils and UnitySymbols asmdef

### Changed
- UnityReflection is now integrated, asmdef continues
- EditorIcon pro-skin support

## [1.3.0] - 2020-05-31

### Added
- Added HTreeView
- Added SerializedObjectScope
- Added LockReloadAssembliesScope
- Added AssetEditingScope
- Added GUIDUtils.NewString
- Added GUIDUtils.NewInt32
- Added EditorHelper.GetWindow
- Added EditorHelper.CreateWindow
- Added EditorHelper.MarkSceneDirty
- Added EditorHelper.EditScript

### Changed
- Changed the arrangement of the files.

## [1.2.0] - 2020-04-18

### Added
- Added extended method GetComponentAndAttach.
- Added HEditorGUI.ImageButton
- Added EditorIcon.PlayButton

### Fixed
- Fixed the scrolling in HSettingsEditorWindow.

## [1.1.0] - 2020-04-04

### Changed
- Refactoring of using, code format, etc
- Assigning editor extension methods to namespaces
- moved ReflectionUtils to the RuntimeEditor

## [1.0.2] - 2020-04-02

### Changed
- HSettingsEditorWindow: SettingsProvider drawing has been improved to work
- Updated embedded resources.

## [1.0.1] - 2020-03-28

### Added
- Added a method to ReflectionUtils

### Changed
- Refactoring, etc.

## [1.0.0] - 2020-03-21

### Changed
- Namespace refactoring
- Split editor localization string

## [0.1.0] - 2020-03-16
- First release