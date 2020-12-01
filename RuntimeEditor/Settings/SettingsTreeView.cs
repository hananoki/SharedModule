#if ENABLE_HANANOKI_SETTINGS

using Hananoki.Extensions;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using System.Linq;

using E = Hananoki.SharedModule.SettingsEditor;

namespace Hananoki.SharedModule {

	using Item = SettingsTreeViewItem;

	public class SettingsTreeViewItem : TreeViewItem {
		public string guid;
		public SettingsItem settings;
	}


	public class SettingsTreeView : HTreeView<Item> {

		public SettingsTreeView() : base( new TreeViewState() ) {
			//showAlternatingRowBackgrounds = true;
			m_registerItems = new List<Item>();
			InitID();
		}


		public void SelectAndExpand( string itemName ) {
			if( itemName.IsEmpty() ) return;

			var item = FindItem( itemName.GetHashCode() );
			
			//var item = m_registerItems.Find( x => x.displayName == itemName );
			if( item == null ) return;
			//SetExpandedFollowParents( item );
			SetSelection( new int[] { item.id } );
		}


		public void AddItem( SettingsItem settings ) {
			var ss = settings.displayName.Split( '/' );

			if( ss.Length == 1 ) {
				m_registerItems.Add( new Item() {
					id = settings.displayName.GetHashCode(),
					displayName = settings.displayName,
					settings = settings,
				} );
			}
			else {
				var it = m_registerItems.Find( x => x.displayName == ss[ 0 ] );
				var newi = new Item() {
					id = ss[ 1 ].GetHashCode(),
					displayName = ss[ 1 ],
					settings = settings,
					depth = 1,
				};
				it.AddChild( newi );
			}
		}


		public void ReloadAndSorting() {
			m_registerItems = m_registerItems.OrderBy( x => x.displayName ).ToList();
			Reload();
		}

		protected override void OnRowGUI( RowGUIArgs args ) {
			DefaultRowGUI( args );

			var item = (Item) args.item;
			//if( item.guid.IsEmpty() ) return;

			//var r = args.rowRect;
			//r.width = 16;
			//r.x += ( item.depth + 1 ) * 16;
			//if( EditorHelper.HasMouseClick( r ) ) {
			//	EditorHelper.PingObject( GUIDUtils.GetAssetPath( item.guid ) );
			//}
			if( item.settings.version.IsEmpty() ) return;

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


		protected override void SingleClickedItem( int id ) {
			var it = FindItem( id );
			E.i.selectSettingName = it.displayName;
			E.Save();
			//Debug.Log(it.displayName);
			//Debug.Log( E.i.selectSettingMode );
		}
	}
}

#endif
