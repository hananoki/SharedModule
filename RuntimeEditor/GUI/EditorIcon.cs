
using UnityEngine;
using UnityEditor;
using System;

namespace Hananoki {
	public static partial class EditorIcon {
		public static string IconPath( string name ) { return $"icons/{name}.png"; }

		public static string IconProcessed( string s, string name ) { return $"icons/processed{s}/{name} icon.asset"; }
		public static string IconProcessed2( string s, string name ) { return $"icons/processed{s}/{name}"; }
		public static string ProcessedPath( string name ) { return IconProcessed( "", name ); }
		public static string ProcessedEditorPath( string name ) { return IconProcessed( "/unityeditor", name ); }
		public static string ProcessedEnginePath( string name ) { return IconProcessed( "/unityengine", name ); }


		public static Texture2D erroricon_inactive         => console_erroricon_inactive_sml;
		public static Texture2D error                      => console_erroricon_sml;
		public static Texture2D warning                    => console_warnicon_sml;
		public static Texture2D info                       => console_infoicon_sml;
		
		public static Texture2D folder                     => Icon.GetBuiltin( ProcessedPath( "folder" ) );
		//public static Texture2D refresh                    => Icon.GetBuiltin( IconPath( "refresh" ) );
		//public static Texture2D settings                   => Icon.GetBuiltin( IconPath( "settings" ) );
		public static Texture2D collabFileDeleted          => Icon.GetBuiltin( IconPath( "collab.filedeleted" ) );
		public static Texture2D collabFileDeletedIcon      => Icon.GetBuiltin( ProcessedPath( "collabdeleted" ) );

		public static Texture2D pane_options => Icon.Get( "builtin skins/lightskin/images/pane options.png", "builtin skins/darkskin/images/pane options.png" );

		public static Texture2D playButton => EditorIcon.playbutton;

		public static Texture2D allowUp   => Shared.Icon.Get( "AllowUp$" );
		public static Texture2D allowDown => Shared.Icon.Get( "AllowDown$" );
		public static Texture2D minus     => Shared.Icon.Get( Icon.GetBuiltinPath( "ol_minus$" ) );
		public static Texture2D plus      => Shared.Icon.Get( Icon.GetBuiltinPath( "ol_plus$" ) );
		public static Texture2D burger    => Shared.Icon.Get( Icon.GetBuiltinPath( "burger$" ) );
		public static Texture2D dopesheetBackground => Shared.Icon.Get( "DopesheetBackground$" );


		public static Texture2D[] s_waitspin;
		public static Texture2D[] waitspin {
			get {
				if( s_waitspin == null ) {
					s_waitspin = new Texture2D[] { waitspin00, waitspin01, waitspin02, waitspin03, waitspin04, waitspin05, waitspin06, waitspin07, waitspin08, waitspin09, waitspin10, waitspin11 };
				}
				return s_waitspin;
			}
		}


		public static Texture2D search_icon => icons_processed_search_icon_asset;
		public static Texture2D assetstore_icon => asset_store;
		
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



		public static Texture2D scriptableobject => icons_processed_unityengine_scriptableobject_icon_asset;
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
