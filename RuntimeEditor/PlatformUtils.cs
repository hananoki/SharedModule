
#if !ENABLE_WARNING
#pragma warning disable 618
#endif

#if UNITY_EDITOR

using Hananoki;
using Hananoki.Reflection;
using Hananoki.SharedModule;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Hananoki {
	public static class PlatformUtils  {

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
			var target = UEditorUserBuildSettingsUtils.CalculateSelectedBuildTarget( group );
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
			return (Texture2D) IconContent( platform )?.image;
		}

		public static Texture2D GetIcon( BuildTargetGroup platform ) {
			return (Texture2D) IconContent( platform )?.image;
		}
		public static Texture2D GetIcon( int platform ) {
			return (Texture2D) IconContent( (BuildTargetGroup) platform )?.image;
		}

		public static GUIContent IconContent( BuildTargetGroup platform ) {
			if( platform == BuildTargetGroup.Standalone )
				return EditorGUIUtility.IconContent( "BuildSettings.Standalone" );
			if( platform == BuildTargetGroup.Android )
				return EditorGUIUtility.IconContent( "BuildSettings.Android" );
			if( platform == BuildTargetGroup.iOS )
				return EditorGUIUtility.IconContent( "BuildSettings.iPhone" );
			if( platform == BuildTargetGroup.WebGL )
				return EditorGUIUtility.IconContent( "BuildSettings.WebGL" );
			if( platform == BuildTargetGroup.PS4 )
				return EditorGUIUtility.IconContent( "BuildSettings.PS4" );
			if( platform == BuildTargetGroup.XboxOne )
				return EditorGUIUtility.IconContent( "BuildSettings.XboxOne" );
			if( platform == BuildTargetGroup.Facebook ) {
				if( EditorHelper.IsDefine( "UNITY_2019_3_OR_NEWER" ) ) {
					return null; // アイコンあるけどビルド出来ない
				}
				return EditorGUIUtility.IconContent( "BuildSettings.Facebook" );
			}
			if( platform == BuildTargetGroup.tvOS )
				return EditorGUIUtility.IconContent( "BuildSettings.tvOS" );
			if( platform == BuildTargetGroup.WSA )
				return EditorGUIUtility.IconContent( "BuildSettings.Metro" );
			if( platform == BuildTargetGroup.Switch )
				return EditorGUIUtility.IconContent( "BuildSettings.Switch" );
#if UNITY_2018_3_OR_NEWER
			if( platform == BuildTargetGroup.Lumin )
				return EditorGUIUtility.IconContent( "BuildSettings.Lumin" );
#endif
#if UNITY_2019_3_OR_NEWER
			if( platform == BuildTargetGroup.Stadia )
				return EditorGUIUtility.IconContent( "BuildSettings.Stadia" );
#endif
			return null;
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

			var instance = R.Property( "instance", "UnityEditor.Build.BuildPlatforms" );
			var buildPlatforms = R.Field( "buildPlatforms", "UnityEditor.Build.BuildPlatforms" );

			var forceShowTarget = R.Field( "forceShowTarget", "UnityEditor.Build.BuildPlatform" );
			var targetGroup = R.Field( "targetGroup", "UnityEditor.Build.BuildPlatform" );
			
			var lst = buildPlatforms.Get<IList>( instance.GetValue( null ) );
			foreach( var ab in lst ) {
				if( forceShowTarget.Get<bool>( ab ) ) {
					s_buildTargetGroup.Add( targetGroup.Get<BuildTargetGroup>( ab ) );
				}
			}
			s_buildTargetGroup.Sort();
			return s_buildTargetGroup;
		}
	}
}

#endif
