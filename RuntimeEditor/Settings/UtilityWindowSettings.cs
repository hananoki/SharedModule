
using Hananoki.Extensions;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using E = Hananoki.SharedModule.SettingsEditor;

namespace Hananoki.SharedModule {
	[Serializable]
	public class UtilityWindowSettingsData {
		public bool Enable;
		public string TypeName;

		Type _cache;
		public Type GetUtilityType() {
			if( _cache == null ) {
				_cache = EditorHelper.GetTypeFromString( TypeName );
			}
			return _cache;
		}
	}


	internal class UtilityWindowGUI : HSettingsEditorWindow {

		const string kCom = "Version=0.0.0.0, Culture=neutral, PublicKeyToken=null";

		static string[] typeList = {
			$"Hananoki.ScriptableObjectManager.MainWindow",
			$"Hananoki.PackageFileTools.MainWindow",
			$"Hananoki.BuildAssist.BuildAssistWindow",
			
			UnityTypes.UnityEditor_AssetStoreWindow.AssemblyQualifiedName,
		};


		[SettingsMethod]
		public static SettingsItem RegisterSettings() {
			return new SettingsItem() {
				//mode = 1,
				displayName = $"{Package.name}/UtilityWindow",
				gui = DrawGUI,
			};
		}

		static void CheckNullType() {
			var dels = new List<UtilityWindowSettingsData>();
			foreach( var p in E.i.utilityWindowSettingsData ) {
				var t = p.GetUtilityType();
				if( t == null ) {
					dels.Add( p );
					continue;
				}
			}
			foreach( var p in dels ) {
				Debug.Log( $"Remove: {p.TypeName}" );
				E.i.utilityWindowSettingsData.Remove( p );
			}
		}

		public static void DrawGUI() {
#if UNITY_2018_3_OR_NEWER
			using( new GUILayout.HorizontalScope() ) {
				if( GUILayout.Button( "add" ) ) {
					var m = new GenericMenu();
					foreach( var p in typeList ) {
						m.AddItem( p.Split( ',' )[ 0 ], reg, p );
					}
					m.DropDownAtMousePosition();
					void reg( object context ) {
						var typeName = (string) context;
						if( E.i.utilityWindowSettingsData.Find( x => x.TypeName == typeName ) == null ) {
							E.i.utilityWindowSettingsData.Add( new UtilityWindowSettingsData { Enable = true, TypeName = typeName } );
						}
						CheckNullType();
						E.Save();
					}
				}

				if( GUILayout.Button( "remove" ) ) {
					E.i.utilityWindowSettingsData = new List<UtilityWindowSettingsData>();
				}
			}


			UtilityWindowSettingsData _remove = null;

			foreach( var p in E.i.utilityWindowSettingsData ) {
				EditorGUI.BeginChangeCheck();
				p.Enable = HEditorGUILayout.ToggleBox( $"{p.GetUtilityType().FullName}", p.Enable, EditorIcon.minus, OnButton );
				if( EditorGUI.EndChangeCheck() ) {
					E.Save();
				}
				void OnButton() {
					_remove = p;
				}
			}
			if( _remove != null ) {
				E.i.utilityWindowSettingsData.Remove( _remove );
				E.Save();
			}

#endif
		}
	}
}
