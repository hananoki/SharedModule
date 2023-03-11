
#if !HANANOKI_WARNING
#pragma warning disable 618
#endif

#if UNITY_EDITOR


using HananokiEditor.SharedModule;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityReflection;

namespace HananokiEditor {
	public static class PlatformUtils {

		static List<UnityEditorBuildBuildPlatform> s_buildTargetGroup;

		static void Init() {
			if( s_buildTargetGroup != null ) return;

			var lst = new List<UnityEditorBuildBuildPlatform>();

			var instance = new UnityEditorBuildBuildPlatforms( UnityEditorBuildBuildPlatforms.instance );

			foreach( var p in instance.buildPlatforms ) {
				var buildPlatform = new UnityEditorBuildBuildPlatform( p );
#if UNITY_2021_2_OR_NEWER
				if( buildPlatform.targetGroup == BuildTargetGroup.Standalone || !buildPlatform.hideInUi ) {
					lst.Add( buildPlatform );
				}
#else
				if( buildPlatform.forceShowTarget ) {
					lst.Add( buildPlatform );
				}
#endif
			}

			s_buildTargetGroup = lst.OrderBy( x => x.targetGroup ).ToList();
		}


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
			return HEditorDialog.Confirm( $"{S._RequiresSwitchActiveBuildTarget}\n{S._IsitOK_}", () => {
				EditorUserBuildSettings.SwitchActiveBuildTarget( group, target );
			} );
		}


		public static Texture2D GetIcon( int platform ) => GetIcon( (BuildTargetGroup) platform );


		public static Texture2D GetIcon( BuildTargetGroup platform ) {
			Init();
			try {
				var buildTarget = s_buildTargetGroup.Find( x => x.targetGroup == platform );
				if( buildTarget == null ) return null;
#if UNITY_2019_3_OR_NEWER
				return (Texture2D) buildTarget.title.image;
#else
				return (Texture2D) buildTarget.m_instance.GetField<GUIContent>( "title" ).image;
#endif
			}
			catch( System.Exception e ) {
				Debug.LogException( e );
			}
			return null;
		}


		public static Texture2D GetIconSmall( BuildTargetGroup platform ) {
			Init();
			try {
				var buildTarget = s_buildTargetGroup.Find( x => x.targetGroup == platform );
				if( buildTarget == null ) return null;
				if( UnitySymbol.UNITY_2019_3_OR_NEWER ) {
					return buildTarget.smallIcon;
				}
				else {
					return buildTarget.m_instance.GetField<Texture2D>( "smallIcon" );
				}
			}
			catch( System.Exception e ) {
				Debug.LogException( e );
			}
			return null;
		}

		/// <summary>
		/// BuildSettingsで表示されるプラットフォームのBuildTargetGroupを返します
		/// </summary>
		/// <returns>List<BuildTargetGroup></returns>
		public static List<BuildTargetGroup> GetSupportList() {
			Init();

			return s_buildTargetGroup.Select( x => x.targetGroup ).ToList();
		}
	}
}

#endif
