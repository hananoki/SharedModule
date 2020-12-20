
using HananokiEditor.Extensions;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEditorInternal;
using UnityReflection;
using E = HananokiEditor.SharedModule.SettingsEditor;

namespace HananokiEditor {

	public class __ : AssetPostprocessor {
		static __() {
			E.Load();
			if( UnitySymbol.UNITY_2019_3_OR_NEWER ) {
				if( E.i.m_disableSyncVS ) {
					EditorApplication.update -= KillVSSync;
					EditorApplication.update += KillVSSync;
				}
			}
		}

		static void OnPostprocessAllAssets( string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths ) {
			//Debug.Log( $"i:{importedAssets.Length}, d:{deletedAssets.Length}, ma:{movedAssets.Length}, mfap:{movedFromAssetPaths.Length}" );

			if( E.i.m_asmdefNameSync || E.i.m_asmdefAutoReferenceOFF ) {
				var _asmdefNameSync = E.i.m_asmdefNameSync;
				var _asmdefAutoReferenceOFF = E.i.m_asmdefAutoReferenceOFF;
				foreach( var p in importedAssets ) {
					if( p[ 0 ] == 'P' ) continue;
					if( !p.EndsWith( ".asmdef" ) ) continue;

					bool dirty = false;
					var asmdef = p.LoadAsset<AssemblyDefinitionAsset>();
					var json = (Dictionary<string, object>) UnityEditorJson.Deserialize( asmdef.text );

					if( _asmdefNameSync ) {
						var fname = p.FileNameWithoutExtension();
						if( (string) json[ "name" ] != fname ) {
							json[ "name" ] = fname;
							dirty = true;
						}
					}
					if( _asmdefAutoReferenceOFF ) {
						if( json.ContainsKey( "autoReferenced" ) ) {
							if( (bool) json[ "autoReferenced" ] ) {
								json[ "autoReferenced" ] = false;
								dirty = true;
							}
						}
						else {
							json.Add( "autoReferenced", false );
							dirty = true;
						}
					}
					if( dirty ) {
						fs.WriteAllText( p, EditorJson.Serialize( json, true ), new UTF8Encoding( false ) );
						AssetDatabase.ImportAsset( p );
					}
				}
			}
		}

		static void KillVSSync() {
			if( UnityEditorSyncVS.s_Enabled == false ) return;

			UnityEditorSyncVS.s_Enabled = false;
			EditorApplication.update -= KillVSSync;
			UnityEngine.Debug.Log( "off" );
		}
	}
}
