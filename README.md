# Shared Module

![](https://img.shields.io/badge/dynamic/json.svg?uri=https://raw.githubusercontent.com/hananoki/SharedModule/master/package.json&label=&query=$.version&prefix=v)
![](https://img.shields.io/badge/unity-2018.3%20or%20later-3BAF75.svg)
![](https://img.shields.io/badge/license-MIT-informational.svg)

[Japanese](https://translate.google.com/translate?sl=en&tl=ja&u=https://github.com/hananoki/SharedModule) (by Google Translate)

## Overview
- Module required for package created by "Hananoki"

## Installation
- Add following lines to the `dependencies` section of the `Packages/manifest.json`.
```js
"dependencies": {
  "com.hananoki.shared-module": "https://github.com/hananoki/SharedModule.git",
  ...
}
```

## Description
- It summarizes useful processing for editor extension

#### EditorExtension
- I want to omit the argument, I want to make it as short as possible, it is a mass of laziness
```cs
var path = "Assets/sample.asset";
var obj1 = path.LoadAsset(); // Can be read
var guid = "bfb0d91c07d48f140962d6de9b6fef33";
var obj2 = path.LoadAsset(); // Can be read
var m = new GenericMenu();
m.AddItem("Menu", ()=>{ Debug.Log("GUIContent is a hassle") } );
m.DropDownAtMousePosition(); // I also call Event.current.Use()
```

#### EditorIcon
- Over 1000 Unity Icon Resources Available
- Automatically switches according to the skin
```cs
GUILayout.Label( EditorIcon.customtool );
```

#### UnityTypes
- Get internal type without using reflection
- Considering version compatibility
```cs
EditorWindow.GetWindow( UnityTypes.UnityEditor_ProjectBrowser );
```

#### UnityReflection
- Access private features
- Delegate.CreateDelegate whenever possible
```cs
AudioClip clip;
UnityEditorAudioUtil.PlayClip( clip );

// Why is it internal?
BuildTargetGroup group = UnityEditorEditorUserBuildSettings.activeBuildTargetGroup;

// Splitter used in AnimatobWindow etc.
var splitter = new UnityEditorSplitterState( 0.20f, 0.80f );
UnityEditorSplitterGUILayout.BeginHorizontalSplit( splitter );
GUILayout.BeginVertical()
... GUI Function
GUILayout.EndVertical()
GUILayout.BeginVertical()
... GUI Function
GUILayout.EndVertical()
UnityEditorSplitterGUILayout.EndHorizontalSplit();
```

- I introduced some functions by excerpting

## Other Tools
- Introduction of packages that use this module

### [BuildAssist](https://github.com/hananoki/BuildAssist)
- An auxiliary tool for differential build, batch build, etc.
![](https://raw.githubusercontent.com/hananoki/BuildAssist/master/Documentation~/Preview.png)

### [CustomHierarchy](https://github.com/hananoki/CustomHierarchy)
- A simple customized hierarchy

### [CustomProjectBrowser](https://github.com/hananoki/CustomProjectBrowser)
- A simple customized project browser

### [EditorFontTweak](https://github.com/hananoki/EditorFontTweak)
- You can edit fontsettings.txt
- Rewrite font settings in UnityEditor.EditorStyles

### [EditorToolbar](https://github.com/hananoki/EditorToolbar)
- Frequently used functions are summarized in the toolbar
  ![](https://raw.githubusercontent.com/hananoki/EditorToolbar/master/Documentation~/Preview_2019.3.png)

### [HierarchyDropDown](https://github.com/hananoki/HierarchyDropDown)
- Add a drop down menu next to the hierarchy game object name
![](https://raw.githubusercontent.com/hananoki/HierarchyDropDown/master/Documentation~/Preview.png)

### [PackageFileTools](https://assetstore.unity.com/packages/tools/utilities/package-file-tools-171114)
![](https://assetstorev1-prd-cdn.unity3d.com/package-screenshot/94141e50-a008-49d3-b1c4-b1231d465335.webp)

### [SceneViewTools](https://github.com/hananoki/SceneViewTools)
- Add tools to SceneView

### [ScriptableObjectManager](https://assetstore.unity.com/packages/tools/utilities/scriptableobject-manager-170587)
![](https://assetstorev1-prd-cdn.unity3d.com/package-screenshot/6aea12ae-89ff-413c-9cad-de02c9e07136.webp)

### [SymbolSettings](https://github.com/hananoki/SymbolSettings)
- Tool to manage ScriptingDefineSymbols
![](https://raw.githubusercontent.com/hananoki/SymbolSettings/master/Documentation~/Preview.png)

~~### [UnityReflection](https://github.com/hananoki/UnityReflection)~~
~~- Provides access to UnityEditor's inner classes with reflection~~


## Licence

[MIT](https://github.com/hananoki/SharedModule/blob/master/LICENSE.md)