using UnityEditor;
using UnityEngine;

namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {

		public static string GetShortName( this BuildTargetGroup targetGroup ) {
			if( targetGroup == BuildTargetGroup.iOS ) return "iOS";
			if( targetGroup == BuildTargetGroup.WSA ) return "UWP";
			return targetGroup.ToString();
		}

		public static string GetName( this BuildTargetGroup targetGroup ) {
			if( targetGroup == BuildTargetGroup.WSA ) return "Universal Windows Platform";
			if( targetGroup == BuildTargetGroup.XboxOne ) return "Xbox One";
			return GetShortName( targetGroup );
		}

		public static Texture2D Icon( this BuildTargetGroup targetGroup ) {
			return PlatformUtils.GetIcon( targetGroup );
		}

		public static Texture2D IconSmall( this BuildTargetGroup targetGroup ) {
			return PlatformUtils.GetIconSmall( targetGroup );
		}
	}
}
