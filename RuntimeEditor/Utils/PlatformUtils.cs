
#if !HANANOKI_WARNING
#pragma warning disable 618
#endif

#if UNITY_EDITOR


//using Hananoki.Reflection;
using HananokiEditor.SharedModule;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityReflection;

namespace HananokiEditor {
	public static class PlatformUtils {

		static List<BuildTargetGroup> s_buildTargetGroup;

		#region Extensions

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
			return GetIcon( targetGroup );
		}

		public static Texture2D IconSmall( this BuildTargetGroup targetGroup ) {
			return GetIconSmall( targetGroup );
		}

		#endregion



		/// <summary>
		/// 確認チェック付きのSwitchプラットフォーム
		/// </summary>
		/// <param name="group"></param>
		/// <returns></returns>
		public static bool SwitchActiveBuildTarget( BuildTargetGroup group ) {
			var target = UnityEditorEditorUserBuildSettingsUtils.CalculateSelectedBuildTarget( group );
			return SwitchActiveBuildTarget( group, target );
		}

		/// <summary>
		/// 確認チェック付きのSwitchプラットフォーム
		/// </summary>
		/// <param name="group"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public static bool SwitchActiveBuildTarget( BuildTargetGroup group, BuildTarget target ) {

			bool result = EditorUtility.DisplayDialog( S._Confirm, $"{ S._RequiresSwitchActiveBuildTarget}\n{S._IsitOK_}", S._OK, S._Cancel );
			if( !result ) return false;

			EditorUserBuildSettings.SwitchActiveBuildTarget( group, target );
			return true;
		}


		public static Texture2D GetIconSmall( BuildTargetGroup platform ) {
			return (Texture2D) GetIcon( platform );
		}

		public static Texture2D GetIcon( BuildTargetGroup platform ) {
			var name = platform.ToString();
			if( name == "Standalone" )
				return (Texture2D) EditorGUIUtility.IconContent( "BuildSettings.Standalone" ).image;
			if( name == "Android" )
				return (Texture2D) EditorGUIUtility.IconContent( "BuildSettings.Android" ).image;
			if( name == "iPhone" || name == "iOS" )
				return (Texture2D) EditorGUIUtility.IconContent( "BuildSettings.iPhone" ).image;
			if( name == "WebGL" )
				return (Texture2D) EditorGUIUtility.IconContent( "BuildSettings.WebGL" ).image;
			if( name == "PS4" )
				return (Texture2D) EditorGUIUtility.IconContent( "BuildSettings.PS4" ).image;
			if( name == "XboxOne" )
				return (Texture2D) EditorGUIUtility.IconContent( "BuildSettings.XboxOne" ).image;
			if( name == "Facebook" ) {
				if( UnitySymbol.Has( "UNITY_2019_3_OR_NEWER" ) ) {
					return null; // アイコンあるけどビルド出来ない
				}
				return (Texture2D) EditorGUIUtility.IconContent( "BuildSettings.Facebook" ).image;
			}
			if( name == "tvOS" )
				return (Texture2D) EditorGUIUtility.IconContent( "BuildSettings.tvOS" ).image;
			if( name == "WSA" || name == "Metro" )
				return (Texture2D) EditorGUIUtility.IconContent( "BuildSettings.Metro" ).image;
			if( name == "Switch" )
				return (Texture2D) EditorGUIUtility.IconContent( "BuildSettings.Switch" ).image;
			if( name == "Lumin" )
				return (Texture2D) EditorGUIUtility.IconContent( "BuildSettings.Lumin" ).image;
			if( name == "Stadia" )
				return (Texture2D) EditorGUIUtility.IconContent( "BuildSettings.Stadia" ).image;
			return null;
		}

		public static Texture2D GetIcon( int platform ) {
			return GetIcon( (BuildTargetGroup) platform );
		}



		public static List<BuildTargetGroup> GetSupportList() {
			if( s_buildTargetGroup != null ) return s_buildTargetGroup;

			s_buildTargetGroup = new List<BuildTargetGroup>();

			//var ll = EnumUtils.GetArray<BuildTargetGroup>();
			//foreach( var e in ll ) {
			//	// iOS、WSAとかダブるので除外
			//	if( 0 <= lst.IndexOf( e ) ) continue;

			//	// ビルドできるプラットフォームならアイコンがあるはず、、という判定
			//	if( e.Icon() == null ) continue;

			//	lst.Add( e );
			//}
			var instance = UnityTypes.UnityEditor_Build_BuildPlatforms.GetProperty<object>( "instance" );

			//var instance = R.Property( "instance", "UnityEditor.Build.BuildPlatforms" );

			var buildPlatforms = instance.GetField<ICollection>( "buildPlatforms" );
			//var buildPlatforms = R.Field( "buildPlatforms", "UnityEditor.Build.BuildPlatforms" );

			//var forceShowTarget = R.Field( "forceShowTarget", "UnityEditor.Build.BuildPlatform" );
			//var targetGroup = R.Field( "targetGroup", "UnityEditor.Build.BuildPlatform" );

			//var lst = buildPlatforms.Get<IList>( instance.GetValue( null ) );
			foreach( var ab in buildPlatforms ) {
				if(  ab.GetField<bool>( "forceShowTarget" )  ) {
					s_buildTargetGroup.Add( ab.GetField<BuildTargetGroup>( "targetGroup" ) /*targetGroup.Get<BuildTargetGroup>( ab )*/ );
				}
			}
			s_buildTargetGroup.Sort();
			return s_buildTargetGroup;
		}
	}
}

#endif
