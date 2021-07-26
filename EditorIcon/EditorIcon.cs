
using System;
using UnityEditor;
using UnityEngine;

namespace HananokiEditor {
	public static partial class EditorIcon {
		public static string IconPath( string name ) { return $"icons/{name}.png"; }

		public static string IconProcessed( string s, string name ) { return $"icons/processed{s}/{name}"; }
		public static string IconProcessed2( string s, string name ) { return $"icons/processed{s}/{name}"; }


		public static Texture2D erroricon_inactive => console_erroricon_inactive_sml;
		public static Texture2D error              => console_erroricon_sml;
		public static Texture2D warning            => console_warnicon_sml;
		public static Texture2D info               => console_infoicon_sml;

		public static Texture2D folder      => icons_processed_folder_icon_asset;
		public static Texture2D folderOpen =>
#if UNITY_2020_1_OR_NEWER
			icons_processed_folderopened_icon_asset;
#elif UNITY_2019_3_OR_NEWER
			icons_processed_openedfolder_icon_asset;
#else
			icons_processed_folder_icon_asset;
#endif

		public static Texture2D folderEmpty => icons_processed_folderempty_icon_asset;


		public static Texture2D collabFileDeletedIcon => icons_processed_collabdeleted_icon_asset;

		public static Texture2D pane_options => Icon.Get( "builtin skins/lightskin/images/pane options.png", "builtin skins/darkskin/images/pane options.png" );

		//public static Texture2D playButton => EditorIcon.playbutton;

		public static Texture2D allowUp                          => SharedModule.Icon.AllowUp_;
		public static Texture2D allowDown                        => SharedModule.Icon.AllowDown_;
		public static Texture2D minus                            => IconDictionary.GetSelect( SharedModule.Icon.ol_minus_, SharedModule.Icon.d_ol_minus_ );
		public static Texture2D plus                             => IconDictionary.GetSelect( SharedModule.Icon.ol_plus_, SharedModule.Icon.d_ol_plus_ );
		public static Texture2D burger                           => IconDictionary.GetSelect( SharedModule.Icon.burger_, SharedModule.Icon.d_burger_ );
		public static Texture2D dopesheetBackground              => SharedModule.Icon.DopesheetBackground_;
		public static Texture2D VisualEffectAsset                => Icon.Get( "light/VisualEffectAsset Icon", "dark/d_VisualEffectAsset Icon" );
		public static Texture2D RayTracingShader                 => Icon.Get( "light/RayTracingShader Icon", "dark/d_RayTracingShader Icon" );
		public static Texture2D AssemblyDefinitionReferenceAsset => Icon.Get( "light/AssemblyDefinitionReferenceAsset Icon", "dark/d_AssemblyDefinitionReferenceAsset Icon" );
		public static Texture2D LightingSettings                 => Icon.Get( "light/LightingSettings Icon", "dark/d_LightingSettings Icon" );
		public static Texture2D Texture2D                        => Icon.Get( "light/Texture2D Icon", "dark/d_Texture2D Icon" );
		public static Texture2D VisualEffectSubgraphBlock        => Icon.Get( "light/VisualEffectSubgraphBlock Icon", "dark/d_VisualEffectSubgraphBlock Icon" );
		public static Texture2D VisualEffectSubgraphOperator     => Icon.Get( "light/VisualEffectSubgraphOperator Icon", "dark/d_VisualEffectSubgraphOperator Icon" );
		public static Texture2D AnimationFilterBySelection       => Icon.Get( "light/Animation.FilterBySelection", "dark/d_Animation.FilterBySelection" );
		public static Texture2D CustomTool                       => Icon.Get( "light/CustomTool", "dark/d_CustomTool" );

		//public static Texture2D installed => Icon.GetPackageManagerIcon( "installed" );
		public static Texture2D CH_T => IconDictionary.GetSelect( SharedModule.Icon.CH_T, SharedModule.Icon.d_CH_T );
		public static Texture2D CH_I => IconDictionary.GetSelect( SharedModule.Icon.CH_I, SharedModule.Icon.d_CH_I );

		public static Texture2D[] s_waitspin;
		public static Texture2D[] waitspin {
			get {
				if( s_waitspin == null ) {
					s_waitspin = new Texture2D[] { waitspin00, waitspin01, waitspin02, waitspin03, waitspin04, waitspin05, waitspin06, waitspin07, waitspin08, waitspin09, waitspin10, waitspin11 };
				}
				return s_waitspin;
			}
		}

		public static Texture2D lightmeter_greenlight  => Icon.GetOrLoadFromBuiltin( IconPath( "lightmeter/greenlight" ) );
		public static Texture2D lightmeter_lightoff    => Icon.GetOrLoadFromBuiltin( IconPath( "lightmeter/lightoff" ) );
		public static Texture2D lightmeter_lightrim    => Icon.GetOrLoadFromBuiltin( IconPath( "lightmeter/lightrim" ) );
		public static Texture2D lightmeter_orangelight => Icon.GetOrLoadFromBuiltin( IconPath( "lightmeter/orangelight" ) );
		public static Texture2D lightmeter_redlight    => Icon.GetOrLoadFromBuiltin( IconPath( "lightmeter/redlight" ) );


		public static Texture2D search_icon => icons_processed_search_icon_asset;
		public static Texture2D assetstore_icon => asset_store;

		public static Texture2D cs_script => icons_processed_cs_script_icon_asset;

		public static Texture2D sceneasset => icons_processed_unityeditor_sceneasset_icon_asset;

		public static Texture2D scriptableobject => icons_processed_unityengine_scriptableobject_icon_asset;

		public static Texture2D assetIcon_CsScript           => icons_processed_cs_script_icon_asset;
		public static Texture2D assetIcon_SceneAsset         => icons_processed_unityeditor_sceneasset_icon_asset;
		public static Texture2D assetIcon_ScriptableObject   => icons_processed_unityengine_scriptableobject_icon_asset;
		public static Texture2D assetIcon_AssemblyDefinition => icons_processed_unityeditorinternal_assemblydefinitionasset_icon_asset;
		public static Texture2D assetIcon_Preset             => icons_processed_unityeditor_presets_preset_icon_asset;
	}



	public class IconWaitSpin : IDisposable {

		float _curTime;
		float _lastTime;
		float _watiTime;

		int _count;
		Action _repaint;

		public static implicit operator Texture2D( IconWaitSpin c ) { return EditorIcon.waitspin[ c._count ]; }
		//public static implicit operator Texture( WaitSpinIcon c ) { return EditorIcon.waitspin[ c._count ]; }

		public IconWaitSpin( Action repaint = null ) {
			_repaint = repaint;
			EditorApplication.update += UpdateEditor;
			//Debug.Log( "ctor: WaitSpinIcon" );
		}

		~IconWaitSpin() {
			_Dispose( false );
			//Debug.Log( "dtor: WaitSpinIcon" );
		}

		public void UpdateEditor() {
			_curTime = Time.realtimeSinceStartup;
			float deltaTime = (float) ( _curTime - _lastTime );
			_lastTime = _curTime;

			_watiTime -= deltaTime;
			if( _watiTime < 0 ) {
				_watiTime = 0.1250f;

				_count++;
				if( 12 <= _count ) {
					_count = 0;
				}
				_repaint?.Invoke();
			}
		}

		public void Dispose() {
			_Dispose( true );
			GC.SuppressFinalize( this );
		}

		protected virtual void _Dispose( bool disposing ) {
			if( disposing ) {
				// 管理（managed）リソースの破棄処理をここに記述します。 
			}

			// 非管理（unmanaged）リソースの破棄処理をここに記述します。
			EditorApplication.update -= UpdateEditor;
			//Debug.Log( "dtor: _Dispose" );
		}


	}
}
