
using UnityEngine;
using UnityEditor;


namespace Hananoki {
	public static class EditorIcon {
		public static string IconPath( string name ) { return $"icons/{name}.png"; }

		public static string IconProcessed( string s, string name ) { return $"icons/processed{s}/{name} icon.asset"; }
		public static string ProcessedPath( string name ) { return IconProcessed( "", name ); }
		public static string ProcessedEditorPath( string name ) { return IconProcessed( "/unityeditor", name ); }
		public static string ProcessedEnginePath( string name ) { return IconProcessed( "/unityengine", name ); }




		public static Texture2D buildsettings_editor       => Icon.GetBuiltin( IconPath( "buildsettings.editor.png" ) );
		public static Texture2D buildsettings_editor_small => Icon.GetBuiltin( IconPath( "buildsettings.editor.small" ) );
		public static Texture2D buildsettings_selectedicon => Icon.GetBuiltin( IconPath( "buildsettings.selectedicon" ) );
		public static Texture2D erroricon_inactive         => Icon.GetBuiltin( IconPath( "console.erroricon.inactive.sml" ) );
		public static Texture2D error                      => Icon.GetBuiltin( IconPath( "console.erroricon.sml" ) );
		public static Texture2D warning                    => Icon.GetBuiltin( IconPath( "console.warnicon.sml" ) );
		public static Texture2D info                       => Icon.GetBuiltin( IconPath( "console.infoicon.sml" ) );
		public static Texture2D folder                     => Icon.GetBuiltin( ProcessedPath( "folder" ) );
		public static Texture2D refresh                    => Icon.GetBuiltin( IconPath( "refresh" ) );
		public static Texture2D settings                   => Icon.GetBuiltin( IconPath( "settings" ) );
		public static Texture2D collabFileDeleted          => Icon.GetBuiltin( IconPath( "collab.filedeleted" ) );
		public static Texture2D collabFileDeletedIcon      => Icon.GetBuiltin( ProcessedPath( "collabdeleted" ) );
		public static Texture2D preset_context             => Icon.GetBuiltin( IconPath( "preset.context" ) );
		public static Texture2D toolbar_plus_more          => Icon.GetBuiltin( IconPath( "toolbar plus more" ) );
		public static Texture2D toolbar_plus               => Icon.GetBuiltin( IconPath( "toolbar plus" ) );

		//		icons/processed/collabdeleted icon.asset

		public static Texture2D pane_options => Icon.Get( "builtin skins/lightskin/images/pane options.png", "builtin skins/darkskin/images/pane options.png" );

		//public static Texture2D sceneAsset => Shared.Icon.Get( "$BuildSettings_SelectedIcon" );

		public static Texture2D playButton => Icon.Get( "PlayButton" );

		public static Texture2D allowUp   => Shared.Icon.Get( "AllowUp$" );
		public static Texture2D allowDown => Shared.Icon.Get( "AllowDown$" );
		public static Texture2D minus     => Shared.Icon.Get( Icon.GetBuiltinPath( "ol_minus$" ) );
		public static Texture2D plus      => Shared.Icon.Get( Icon.GetBuiltinPath( "ol_plus$" ) );
		public static Texture2D burger    => Shared.Icon.Get( Icon.GetBuiltinPath( "burger$" ) );

		public static Texture2D asset_store => Icon.GetBuiltin( IconPath( "asset store" ) );
		public static Texture2D sceneviewfx => Icon.GetBuiltin( IconPath( "sceneviewfx" ) );

		//(Texture2D) EditorGUIUtility.Load( EditorGUIUtility.isProSkin ? "icons/d_Settings.png" : "icons/settings.png" );
		//public static Texture2D settings => (Texture2D) EditorGUIUtility.Load( "settings" );

		public static Texture2D dopesheetBackground => Shared.Icon.Get( "DopesheetBackground$" );

		public static Texture2D favorite => Icon.GetBuiltin( "icons/favorite.png" );


		public static Texture2D animationWindow => Icon.GetBuiltin( IconPath( "unityeditor.animationwindow" ) );
		public static Texture2D animatorcontrollertool => Icon.GetBuiltin( IconPath( "unityeditor.graphs.animatorcontrollertool" ) );


		public static Texture2D assetstore_icon => Icon.Get( ProcessedPath( "assetstore" ) );
		public static Texture2D cs_script {
			get {
				if( UnitySymbol.Has( "UNITY_2019_3_OR_NEWER" ) ) {
					return Icon.GetBuiltin( ProcessedPath( "cs script" ) );
				}
				return Icon.Get( ProcessedPath( "cs script" ) );
			}
		}
		public static Texture2D sceneasset {
			get {
				if( UnitySymbol.Has( "UNITY_2019_3_OR_NEWER" ) ) {
					return Icon.GetBuiltin( ProcessedEditorPath( "sceneasset" ) );
				}
				return Icon.Get( ProcessedEditorPath( "sceneasset" ) );
			}
		}
		public static Texture2D scriptableobject => Icon.Get( ProcessedEnginePath( "scriptableobject" ) );


		//"console.warnicon.inactive.sml"
	}
}
