# Shared Module

## [1.13.0] - 2021-03-11

### Changed
- Correspondence up to 2022.2

## [1.12.2] - 2021-12-22

### Fixed
- Renamed to `_EditorAnimationClip.cs` because Git doesn't recognize it due to changes in `EditorAnimationClip.cs`
- Argument name is changed to English

## [1.12.1] - 2021-12-22

### Fixed
- Method names are now in English.

## [1.12.0] - 2021-07-27

### Added
- Added the icon extracted from EditorAssetBundle
- Added HananokiEditor.SharedModule.Association
- Added HananokiEditor.HEditorDialog
- Added HananokiEditor.Hananoki_OnOpenAsset
- Added HananokiEditor.Extensions.EditorExtensions
  - HasHideFlags
  - EnableHideFlags
  - DisableHideFlags
  - GetParentRoot
  - GetGameObjects
  - displayNameで探す
  - displayNameでアルファベット順にする
- Added HananokiEditor.SelectionHistory
- Added HananokiEditor.ProjectBrowserUtils.ClearSearchFieldText

### Changed
- EditorIcon
  - Changed to get a dummy when icon acquisition fails
- EditorIcon.Get
  - Organized read methods
- EditorHelper.FixSerializeReference
  - Decomposed the process so that it can be processed in multiple threads
- HananokiEditor.Extensions.EditorExtensions.GetIcon
  - Changed to cache loaded icons
- HananokiEditor.HEditor
  - Changed to handle Managed Reference

## [1.11.0] - 2021-06-29

### Added
- Added `AssetDatabaseCache`
- Added `AssetDatabaseUtils.LoadAssetAtGUIDAndLocalID`
- Added `ProjectBrowserUtils.isSearching`
- Added `ProjectBrowserUtils.isPinging`
- Added `TreeViewItem` extension method
- Added `EditorExtensions.指定クラスを含む`
- Added `ExternalPackages.AsmdefGraph.OpenAsName`
- Added `ExternalPackages.CustomProjectBrowser.DrawProjectItemCallback`
- Added `ExternalPackages.ScriptableObjectManager.GetRegistTypes`
- Added `ExternalPackages.ScriptableObjectManager.SetShow`
- Added `ExternalPackages.FavoriteAssets.SetShow`
- Added method to `HTreeView`
  - `GetAllItems`
  - `GetTreeItems`
  - `UpdateAllDepth`
  - `UpdateDepth`
  - `SetExpanded`

### Changed
- Changed the automatic output name of `UnitySymbol`
- Changed the return value of `HEditorGUI.MiniLabelR` to `Rect`
- Changed the argument of `HTreeView.OnRowGUI`
- Changed the argument of `HTreeView.OnContextClickedItem`
- Changed `HTreeView.DoubleClickedItem` to sealed
Do `HTreeView.OnDoubleClickedItem` instead
- Changed `HTreeView.SetupDragAndDrop` to sealed
Do `HTreeView.OnSetupDragAndDrop` instead
- Changed `HTreeView.CanStartDrag` to sealed
Do `HTreeView.OnCanStartDrag` instead
- Removed `HTreeView.FindItem`
- Removed `HTreeViewContextMenu`

### Fixed
- `EditorExtensions.GetIcon`
  - Fixed the acquisition result of `ScriptableObject`
- `HEditorGUI.FolderObjectField`
  - Fixed display being distorted before 2019.2.

## [1.10.0] - 2021-06-21

### Added
- Added `Extensions.Invert`
- Added `EditorExtensions.GetAssetType`
- Added `HEditorGUI.FolderObjectField`
- Added `HEditorStyles.backGroundColor`
- Added `HTreeView.OnSingleClickedItem`

### Changed
- Changed `HTreeView.SelectionChanged` to sealed
Do `HTreeView.OnSelectionChanged` instead

## [1.9.0] - 2021-06-09

### Added
- Add options to Settings Editor: `UIElements Font Fix`	
- Added `EditorIcon.folderOpen`
- Added `EditorExtensions.L10n`
- Added `IEnumerableExtensions.OrEmptyIfNull`
- Added `AssetDatabaseUtils.OpenAsset`
- Added `EditorPrefsFloat`
- Added `EditorStylesHelper.standardFont`
- Added `ExternalPackages.ScriptableObjectManager`
  - `enabled`
  - `ShowCreateMenu`
- Added `ProjectBrowserUtils.SetFolderSelection`

### Changed
- `fs.WriteFile` is now `fs.WriteFileAll`
- `EditorHelper.GetTypeFromString`: Added arguments for inner class

### Fixed
- `EditorHelper.ShowNewInspectorWindow`: Fixed to return the state of Selection
- Fixed p4 icons for 2020_1

## [1.8.0] - 2021-04-03
### Added
- Add miscellaneous classes and methods

### Changed
- EditorHelper.GetTypeFromString: Changed to cache search results
- EditorIcon: Changed to use the output file for each version
- Changed to get the platform icon from the system
- Organized code format and unused using

## [1.7.7] - 2021-03-01

### Added
- Added attributes
  - Hananoki_SceneView_ComponentButton
  - HananokiEditor.Hananoki_SceneView_ComponentTool
  - Hananoki_Hierarchy_ComponentTool
- Other functions added, etc.

### Changed
- EditorContextHandler.ForceReserializeAssets: Folder can be specified
- EditorHelper.FixSerializeReferencex: Enabled to specify field name
- HTreeView: A function to restore the selected state is now available.

## [1.7.6] - 2021-02-19

### Added
- Other functions added, etc.

### Changed
- Temporarily disable the automatic OFF function of AutoReference

## [1.7.5] - 2021-02-07

### Added
- Added support for Unity 2020.2
- Added animation reflection
- Other functions added, etc.

## [1.7.4] - 2020-12-20

### Added
- Added Class
  - ExternalPackages
  - EditorWindowUtils

- Added EditorHelper Method
  - GetMonoScriptFromType
- Added EditorExtensions Method
  - IsOnScene
  - StartWithResource
  - HasExtention
  - GetPersistentTypeID
- Added AssemblieUtils Method
  - SubclassesOf

### Changed
- Changed IconButton event handling to MouseUp
- Made all editor windows configurable as utility windows

### Fixed
- Fixed an icon resource leaking

## [1.7.3] - 2020-12-13

### Changed
- Revised the configuration of asmdef
- Changed namespace to distinguish between editor and runtime
- Integrated asmdef of Attribute
- Separated asmdef as EditorIcon
- Deprecated HGUIScope
  - Alternatives ScopeHorizontal, ScopeVertical, ScopeDisable, ScopeChange
- ENABLE_HANANOKI_SETTINGS is no longer set automatically
- fs.ReadAllText: UTF8N is standardized 

### Fixed
- SettingsTreeView: Fixed GUIStyle error in 2018.3 ~ 2019.2 environment

## [1.7.2] - 2020-12-09

### Added
- Added window shade function to HEditorWindow
- Added an event to HEditorWindow that pressed the close button
- Added the ability to generate csc.rsp
- Added processing when importing asmdef
- Added UnityReflection.UnityEditorEditorWindow Class
- Added EditorHelper Method
  - ShowMessagePop
- Added ObjectExtensions Method
  - SetDirty
  - LoadAllSubAssets
  - GetTypeName
  - IsNull
- Added HTreeView Method
  - SelectItem

### Changed
- HGUILayout.ToggleBox
  - Changed the order of arguments
- HEditorGUILayout.ToggleLeft
  - Adjusted the layout
- HGUIToolbar.Button
  - Adjusted the layout

## [1.7.1] - 2020-12-04

### Added
- Added Class
  - PlayerSettingsUtils
  - UnityEditorWindowLayout
- Added EditorExtensions Method
  - Draw( this GUIStyle style, Rect rc )

### Changed
- Changed the tree display of Hananoki.SharedModule.SettingsWindow
- Changed UnityEditorEditorAssemblies generic types to work
- Changed ENABLE_HANANOKI_SETTINGS to be set automatically
- Remove Tests

## [1.7.0] - 2020-12-02

### Added
- Added Helper Class
- Added EditorContextHandler Class
- Added EditorFolder Class
- Added ObjectExtensions Class
- Added StopwatchScope Class
- Added ProgressBarScope Class
- Added Clipboard Class
- Added ShellUtils Class
- Added EditorHelper Method
  - IsLoadAssembly
  - GetTypeFromString
  - GetEditorType
  - Reboot
- Added HGUIUtility Method
  - DisableFocus
- Added EditorExtensions Method
  - separatorToOS
  - separatorToSlash
  - PrettyDirectoryName
  - StartWithAssets
  - LoadAsset
  - LoadAllAssets
  - LoadAllSubAssets
  - FileToDirectory
  - ReadAllText
  - WriteAllText
- Added HEditorWindow Method
  - OnDefaultGUI <- OnGUI wrapper
  - RepaintProjectWindow
  - RepaintHierarchyWindow
  - RepaintAnimationWindow
- Added HTreeView Method
  - SetExpandedFollowParents
- Added ProjectBrowserUtils Method
  - ProjectBrowserUtils
- Added CreateScriptAssetFromTemplateFile

### Changed
- EditorExtensions Method
  - LoadAssetAtPath, LoadAssetAtGUID have been integrated into LoadAsset
  - IsExistsFile, IsExistsDirectory moved from Extensions
- Unified asset path acquisition to ToAssetPath
- Unified GUID acquisition to ToGUID
- HGUILayoutToolbar changed to EditorStyles base as HGUIToolbar
- Commented on unused methods in EditorHelper
- EditorResourceIcon -> PackageResourceIcon
- We are organizing ReflectionUtils, which is still ongoing.
- Separation of reflection into UnityReflection namespace
  - Replace Delegate with Action

### Fixed
- Fixed iOS and Universal Windows Platform icon acquisition mistakes

## [1.6.2] - 2020-11-19

### Added
- Added EditorLocalizeData
- Added AssetDatabaseUtils
- Added Extensions.IsExistsFile
- Added Extensions.IsExistsDirectory
- Added EditorHelper.LoadSerializedFileAll
- Added EditorHelper.LoadSerializedFileAtName
- Added EditorExtensions.AddObjectToAsset
- Added EditorExtensions.GetFilesFromAssetGUID

### Changed
- Changed localization process from dictionary to array
- Changed the processing when missing in GUIDString
- Changed to check the existence of the source file with fs.cp

## [1.6.1] - 2020-11-17

### Changed
- Changed the language selection display

## [1.6.0] - 2020-11-15

### Added
- Added EditorResourceIcon
- Added UnityEditorBuildPlayerWindow
- Added UnityEditorModulesModuleManager
- Added EditorExtensions.GetFilesFromAssetPath
- Added EditorExtensions.stringModify character pattern
- Added directory existence check in DirectoryUtils
- Added DirectoryUtils.DirectoryCopy
- Added DirectoryUtils.GetDirectorySize
- Added platform verdict to UnitySymbol

### Changed
- Change the handling of embedded resources
- Moved ManifestJsonUtils from ManifestJsonUtility
- Changed to handle HTreeView.Reload exceptions
- Changed  HTreeView.RowGUI to sealed
- DirectoryUtils

### Fixed
- Fixed Method Invoke argument processing

## [1.5.8] - 2020-11-01

### Added
- Added Extensions.GetComponentFromType
- Added Extensions.InvokeComponentFromType
- Added UnityTypes ... SpriteRenderer, Image, RawImage, TMP_Text, TextMeshProUGUI

### Changed
- Refactoring, etc.

## [1.5.7] - 2020-09-14

### Fixed
- Fixed an error when the argument of UnityEditorProjectBrowser.IsTwoColumns was null

## [1.5.6] - 2020-09-13

### Added
- Added ColorUtils.Alpha
- Added Extensions.Alpha
- Added EditorHelper.MenuCopyPos
- Added EditorHelper.MenuPastePos
- Added EditorHelper.GetInheritType
- Added Dirty( UnityObject obj, string name, Action ff )
- Added Extensions.RepaintArray
- Added EditorExtensions.AddItemAndDisable
- Added HTreeView.FindItem
### Changed
- Refactor EditorUtils.cs
- ProjectBrowserUtils.cs
- Changed the target character to EditorExtensions.stringModify
- Enabled to allow right click with HEditorGUI.IconButton

## [1.5.5] - 2020-08-09

### Added
- Added HGUIScope.Area
- Added EditorExtensions.LoadAssetAtGUID
- Added EditorExtensions.LoadAssetAtPath
- Added HEditorWindow.ShowWindow
- Added UnitySymbol.UNITY_2018_1_OR_NEWER ～ UnitySymbol.UNITY_2020_1_OR_NEWER

### Changed
- Changed to automatically generate EditorWindow type

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