using HananokiRuntime.Extensions;
using HananokiEditor.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

using E = HananokiEditor.SharedModule.SettingsEditor;

namespace HananokiEditor.SharedModule {
	[Serializable]
	public class CSPFileData {
		public bool Enable;
		public string TypeName;

		public int flag;
		const int CS0162 = 1 << 0;
		const int CS0169 = 1 << 1;
		const int CS0414 = 1 << 2;
		const int CS0618 = 1 << 3;
		const int CS0649 = 1 << 4;
		const int CS0105 = 1 << 5;
		const int CS8321 = 1 << 6;

		const int UNSAFE = 1 << 30;

		public bool cs0105 { get => flag.Has( CS0105 ); set => flag.Toggle( CS0105, value ); }
		public bool cs0162 { get => flag.Has( CS0162 ); set => flag.Toggle( CS0162, value ); }
		public bool cs0169 { get => flag.Has( CS0169 ); set => flag.Toggle( CS0169, value ); }
		public bool cs0414 { get => flag.Has( CS0414 ); set => flag.Toggle( CS0414, value ); }
		public bool cs0618 { get => flag.Has( CS0618 ); set => flag.Toggle( CS0618, value ); }
		public bool cs0649 { get => flag.Has( CS0649 ); set => flag.Toggle( CS0649, value ); }
		public bool cs8321 { get => flag.Has( CS8321 ); set => flag.Toggle( CS8321, value ); }
		public bool isUnsafe { get => flag.Has( UNSAFE ); set => flag.Toggle( UNSAFE, value ); }

		public static string[] NameOf() {
			return new string[] {
				nameof( cs0162 ),
				nameof( cs0169 ),
				nameof( cs0414 ),
				nameof( cs0618 ),
				nameof( cs0649 ),
				nameof( cs0105 ),
				nameof( cs8321 ),
				};
		}
	}


	internal class CSPFileGUI : HSettingsEditorWindow {

		[HananokiSettingsRegister]
		public static SettingsItem RegisterSettings() {
			return new SettingsItem() {
				displayName = $"{Package.nameNicify}/csc.rsp",
				gui = DrawGUI,
			};
		}

		const string kAssetPath = "Assets/csc.rsp";

		static CSPFileData pref => E.i.m_CSPFileData;


		public static void DrawGUI() {
			///////////////////
			ScopeHorizontal.Begin( EditorStyles.helpBox );
			var height = GUI.skin.button.CalcHeight( "csc.rsp" );
			GUILayout.Label( "csc.rsp", EditorStyles.boldLabel, GUILayout.Height( EditorGUIUtility.singleLineHeight ) );
			GUILayout.Space( 8 );
			bool exist = kAssetPath.IsExistsFile();
			if( exist ) {
				HGUILayout.Label( S._Fileexists, EditorIcon.info, EditorStyles.miniLabel, GUILayout.Height( EditorGUIUtility.singleLineHeight ) );
			}
			else {
				HGUILayout.Label( S._Filedoesnotexist, EditorIcon.error, EditorStyles.miniLabel, GUILayout.Height( EditorGUIUtility.singleLineHeight ) );
			}
			GUILayout.FlexibleSpace();
			ScopeDisable.Begin( !exist );
			if( GUILayout.Button( S._DisplayContents ) ) {
				EditorUtility.DisplayDialog( S._Confirm, fs.ReadAllText( kAssetPath ), S._OK );
			}
			if( GUILayout.Button( S._Delete ) ) {
				fs.rm( kAssetPath );
				AssetDatabase.Refresh();
			}
			ScopeDisable.End();
			ScopeHorizontal.End();

			///////////////////
			///
			GUILayout.Space( 8 );

			HEditorGUILayout.HeaderTitle( S._Suppresswarnings );
			EditorGUI.indentLevel++;
			ScopeChange.Begin();

			pref.cs0105 = HEditorGUILayout.ToggleLeft( $"CS0105 - {S._Theusingdirectivefor_namespace_appearedpreviouslyinthisnamespace}", pref.cs0105 );
			pref.cs0162 = HEditorGUILayout.ToggleLeft( $"CS0162 - {S._Unreachablecodedetected}", pref.cs0162 );
			pref.cs0169 = HEditorGUILayout.ToggleLeft( $"CS0169 - {S._Theprivatefield_classmember_isneverused}", pref.cs0169 );
			pref.cs0414 = HEditorGUILayout.ToggleLeft( $"CS0414 - {S._Theprivatefield_field_isassignedbutitsvalueisneverused}", pref.cs0414 );
			pref.cs0618 = HEditorGUILayout.ToggleLeft( $"CS0618 - {S._member_isobsolete__text_}", pref.cs0618 );
			pref.cs0649 = HEditorGUILayout.ToggleLeft( $"CS0649 - {S._Field_field_isneverassignedto_andwillalwayshaveitsdefaultvalue_value_}", pref.cs0649 );
			pref.cs8321 = HEditorGUILayout.ToggleLeft( $"CS8321 - {S._Thelocalfunction_function_isdeclaredbutneverused}", pref.cs8321 );

			//

			EditorGUI.indentLevel--;
			if( ScopeChange.End() ) E.Save();

			///////////////////
			GUILayout.Space( 8 );

			HEditorGUILayout.HeaderTitle( S._Unsafe );
			EditorGUI.indentLevel++;
			ScopeChange.Begin();
			pref.isUnsafe = HEditorGUILayout.ToggleLeft( S._Allowsyoutocompilecodethatusestheunsafekeyword, pref.isUnsafe );
			if( ScopeChange.End() ) E.Save();
			EditorGUI.indentLevel--;

			///////////////////
			GUILayout.Space( 16 );

			ScopeHorizontal.Begin();
			GUILayout.FlexibleSpace();

			if( GUILayout.Button( exist ? " " + S._OverwriteSave : " " + S._CreateNew ) ) {
				SaveFile();
			}

			ScopeHorizontal.End();
		}


		static void SaveFile() {
			fs.WriteFile( "Assets/csc.rsp", ( b ) => {
				var names = CSPFileData.NameOf();
				var str = new List<string>( 16 );
				for( int i = 0; i < names.Length; i++ ) {
					if( pref.flag.Has( 1 << i ) ) {
						str.Add( $"{names[ i ].Replace( "cs", "" )}" );
					}
				}
				var s = string.Join( "\n", str.Select( x => $"-nowarn:{x}" ).OrderBy( x => x ).ToArray() );
				b.AppendLine( s );
				if( pref.isUnsafe ) b.AppendLine( "-unsafe" );
			} );
		}
	}


}
