
using UnityEngine;

namespace Hananoki {
	public static class EditorIcon {

		public static Texture2D animationWindow => Icon.Get( "UnityEditor.AnimationWindow" );
		public static Texture2D animatorWindow => Icon.Get( "UnityEditor.Graphs.AnimatorControllerTool" );

		public static Texture2D error => Icon.Get( "console.erroricon.sml" );
		public static Texture2D warning => Icon.Get( "console.warnicon.sml" );
		public static Texture2D info => Icon.Get( "console.infoicon.sml" );
		public static Texture2D sceneAsset => Shared.Icon.Get( "$BuildSettings_SelectedIcon" );

		public static Texture2D playButton => Icon.Get( "PlayButton" );

		public static Texture2D allowUp => Shared.Icon.Get( "$AllowUp" );
		public static Texture2D allowDown => Shared.Icon.Get( "$AllowDown" );
		public static Texture2D minus => Shared.Icon.Get( "$olminus" );
		public static Texture2D plus => Shared.Icon.Get( "$olplus" );
		public static Texture2D settings => Shared.Icon.Get( "$Settings" );

		public static Texture2D refresh => Icon.Get( "Refresh" );

		//"console.warnicon.inactive.sml"
	}
}
