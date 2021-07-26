
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _HananokiEditor_FavoriteAssets_Utils;
		public static Type HananokiEditor_FavoriteAssets_Utils => Get( ref _HananokiEditor_FavoriteAssets_Utils, "HananokiEditor.FavoriteAssets.Utils", "Hananoki.FavoriteAssets.Editor" );

		static Type _HananokiEditor_CustomProjectBrowser_Utils;
		public static Type HananokiEditor_CustomProjectBrowser_Utils => Get( ref _HananokiEditor_CustomProjectBrowser_Utils, "HananokiEditor.CustomProjectBrowser.Utils", "Hananoki.CustomProjectBrowser.Editor" );

		static Type _HananokiEditor_SelectionHistory_Main;
		public static Type HananokiEditor_SelectionHistory_Main => Get( ref _HananokiEditor_SelectionHistory_Main, "HananokiEditor.SelectionHistory.Main", "Hananoki.SelectionHistory.Editor" );

		static Type _HananokiEditor_ScriptableObjectManager_Utils;
		public static Type HananokiEditor_ScriptableObjectManager_Utils => Get( ref _HananokiEditor_ScriptableObjectManager_Utils, "HananokiEditor.ScriptableObjectManager.Utils", "Hananoki.ScriptableObjectManager.Editor" );

	}
}
