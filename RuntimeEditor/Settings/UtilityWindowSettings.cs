
using HananokiEditor.Extensions;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using E = HananokiEditor.SharedModule.SettingsEditor;

namespace HananokiEditor.SharedModule {
	[Serializable]
	public class UtilityWindowSettingsData {
		public bool Enable;
		public string TypeFullName;

		Type _cache;
		public Type GetUtilityType() {
			if( _cache == null ) {
				_cache = EditorHelper.GetTypeFromString( TypeFullName );
			}
			return _cache;
		}
	}


	internal class UtilityWindowGUI : HSettingsEditorWindow {

		const string kCom = "Version=0.0.0.0, Culture=neutral, PublicKeyToken=null";

		//static string[] typeList = {
		//	$"HananokiEditor.ScriptableObjectManager.MainWindow",
		//	$"HananokiEditor.PackageFileTools.MainWindow",
		//	$"HananokiEditor.BuildAssist.BuildAssistWindow",

		//	UnityTypes.UnityEditor_AssetStoreWindow.AssemblyQualifiedName,
		//};


		[HananokiSettingsRegister]
		public static SettingsItem RegisterSettings() {
			CheckNullType();
			return new SettingsItem() {
				//mode = 1,
				displayName = $"{Package.nameNicify}/UtilityWindow",
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
				//Debug.Log( $"Remove: {p.TypeFullName}" );
				E.i.utilityWindowSettingsData.Remove( p );
			}
		}

		public static void DrawGUI() {
#if UNITY_2018_3_OR_NEWER
			using( new GUILayout.HorizontalScope() ) {
				if( GUILayout.Button( "add" ) ) {
					var m = new GenericMenu();
					var list = AssemblieUtils.SubclassesOf<EditorWindow>();
					foreach( var p in list ) {
						m.AddItem( p.FullName.Replace(".","/"), reg, p );
					}
					m.DropDownAtMousePosition();
					void reg( object context ) {
						var t = (Type) context;
						if( E.i.utilityWindowSettingsData.Find( x => x.TypeFullName == t.FullName ) == null ) {
							E.i.utilityWindowSettingsData.Add( new UtilityWindowSettingsData { Enable = true, TypeFullName = t.FullName } );
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
