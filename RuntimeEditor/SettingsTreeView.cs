#if ENABLE_HANANOKI_SETTINGS

using Hananoki.Extensions;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using System.Linq;

using E = Hananoki.SharedModule.SettingsEditor;

namespace Hananoki.SharedModule {

	using SettingsTreeViewItem = SettingsTreeView.Item;


	public class SettingsTreeView : HTreeView<SettingsTreeViewItem> {

		public class Item : TreeViewItem {
			public string guid;
			public SettingsItem settings;
		}


		public SettingsTreeView() : base( new TreeViewState() ) {
			//showAlternatingRowBackgrounds = true;
			m_registerItems = new List<Item>();
			InitID();
		}


		public void SelectItem( string itemName ) {

			var item = m_registerItems.Find( x => x.displayName == itemName );
			if( item == null ) return;
			SetSelection( new int[] { item.id } );
		}


		public void AddItem( SettingsItem settings ) {
			m_registerItems.Add( new Item() {
				id = GetID(),
				displayName = settings.displayName,
				settings = settings,
			} );
		}


		public void ReloadAndSorting() {
			m_registerItems = m_registerItems.OrderBy( x => x.displayName ).ToList();
			Reload();
		}

		protected override void OnRowGUI( RowGUIArgs args ) {
			DefaultRowGUI( args );

			var item = args.item.ToCast<Item>();
			//if( item.guid.IsEmpty() ) return;

			//var r = args.rowRect;
			//r.width = 16;
			//r.x += ( item.depth + 1 ) * 16;
			//if( EditorHelper.HasMouseClick( r ) ) {
			//	EditorHelper.PingObject( GUIDUtils.GetAssetPath( item.guid ) );
			//}
			var lrc = args.rowRect;
			var cont = EditorHelper.TempContent( $"{item.settings.version}" );
			var size = HEditorStyles.versionLabel.CalcSize( cont );
			//var st = new GUIStyle( EditorStyles.miniLabel );
			//st.alignment = TextAnchor.MiddleRight;

			lrc = lrc.AlignR( size.x );
			lrc.x -= 4;
			lrc = lrc.AlignCenterH( 12 );
			EditorGUI.DrawRect( lrc, E.i.versionBackColor );
			HEditorStyles.versionLabel.normal.textColor = E.i.versionTextColor;
			GUI.Label( lrc, $"{item.settings.version}", HEditorStyles.versionLabel );

			//Debug.Log(EditorStyles.miniLabel.fontSize);
			//Debug.Log( EditorStyles.label.fontSize );
		}


		public void DrawCurrent() {
			currentItem?.settings.gui();
		}
	}
}

#endif
