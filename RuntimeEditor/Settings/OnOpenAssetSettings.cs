using HananokiRuntime;
using System.Linq;
using UnityEditor;
using UnityEngine;
using E = HananokiEditor.SharedModule.SettingsEditor;


namespace HananokiEditor.SharedModule {

	public class OnOpenAssetSettings {

		[HananokiSettingsRegister]
		public static SettingsItem RegisterSettings() {
			return new SettingsItem() {
				displayName = $"{Package.nameNicify}/OnOpenAsset",
				gui = DrawGUI,
			};
		}


		public static void DrawGUI() {
			var method1 = AssemblieUtils.GetAllMethodsWithAttribute<Hananoki_OnOpenAsset>().ToArray();
			Helper.New( ref E.i.m_enableOnOpen );

			foreach( var p in method1 ) {
				var cus = p.GetCustomAttributes( typeof( Hananoki_OnOpenAsset ), false ).OfType<Hananoki_OnOpenAsset>().ToList();
				//cus.Find(x=>)
				ScopeHorizontal.Begin( EditorStyles.helpBox );
				ScopeVertical.Begin( GUILayout.Height( 40 ), GUILayout.Width( 20 ) );
				GUILayout.FlexibleSpace();

				var hash = p.GetHash_OnOpenAsset();
				int idx = E.i.m_enableOnOpen.IndexOf( hash );

				ScopeChange.Begin();
				var _enable = EditorGUILayout.Toggle( 0 <= idx, GUILayout.Width( 20 ) );
				if( ScopeChange.End() ) {
					if( _enable ) {
						E.i.m_enableOnOpen.Add( hash );
					}
					else {
						E.i.m_enableOnOpen.Remove( hash );
					}
					E.Save();
					Association.MakeMethods( true );
				}

				GUILayout.FlexibleSpace();
				ScopeVertical.End();
				ScopeVertical.Begin();


				EditorGUILayout.LabelField( EditorHelper.TempContent( $"{p.Name} : { cus[ 0 ].GetName()}", EditorIcon.assetIcon_CsScript ) );
				EditorGUI.indentLevel++;
				EditorGUILayout.LabelField( EditorHelper.TempContent( $"{p.Module.Name}", EditorIcon.icons_processed_assembly_icon_asset ) );
				EditorGUI.indentLevel--;
				ScopeVertical.End();
				ScopeHorizontal.End();
			}
		}

	}
}
