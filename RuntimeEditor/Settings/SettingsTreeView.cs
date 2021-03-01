#define ENABLE_HANANOKI_SETTINGS

#if ENABLE_HANANOKI_SETTINGS

using HananokiEditor.Extensions;
using HananokiRuntime.Extensions;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

using E = HananokiEditor.SharedModule.SettingsEditor;

namespace HananokiEditor.SharedModule {

	using Item = SettingsTreeViewItem;

	public class SettingsTreeViewItem : TreeViewItem {
		public string guid;
		public SettingsItem settings;

		public bool root;
	}


	public class SettingsTreeView : HTreeView<Item> {

		List<Item> m_rootItems;

		public SettingsTreeView() : base( new TreeViewState() ) {
			//showAlternatingRowBackgrounds = true;
			m_registerItems = new List<Item>();
			InitID();


			m_rootItems = new List<Item>();

			m_rootItems.Add( new Item() {
				id = "Editor".GetHashCode(),
				displayName = "Editor",
				//settings = settings,
				depth = 0,
				icon=EditorIcon.settings,
				root=true,
			} );
			m_rootItems.Add( new Item() {
				id = "Project".GetHashCode(),
				displayName = "Project",
				//settings = settings,
				depth = 0,
				icon = EditorIcon.settings,
				root = true,
			} );

			foreach( var p in m_rootItems )
				m_registerItems.Add( p );
		}


		public void SelectAndExpand( string itemName, int mode ) {
			if( itemName.IsEmpty() ) return;

			var item = FindItem( itemName.GetHashCode()+mode );

			//var item = m_registerItems.Find( x => x.displayName == itemName );
			if( item == null ) return;
			//SetExpandedFollowParents( item );
			SetSelection( new int[] { item.id } );
		}


		public void AddItem( SettingsItem settings ) {
			var ss = settings.displayName.Split( '/' );

			if( ss.Length == 1 ) {
				var item = new Item() {
					id = settings.hashCode,
					displayName = settings.displayName,
					settings = settings,
					depth = 1,
					//icon = EditorIcon.settings,
				};
				m_rootItems[ settings.mode ].AddChild( item );
			}
			else {
				var it=m_rootItems[ settings.mode ].children.Find( x => x.displayName == ss[ 0 ] );

				//var it = m_registerItems.Find( x => x.displayName == ss[ 0 ] );
				var newi = new Item() {
					id = settings.hashCode,
					displayName = ss[ 1 ],
					settings = settings,
					depth = 2,
				};
				it.AddChild( newi );
			}
		}


		public void ReloadAndSorting() {
			for( int i = 0; i < m_rootItems.Count; i++ ) {
				if( !m_rootItems[ i ].hasChildren ) continue;
				m_rootItems[ i ].children = m_rootItems[ i ].children.OrderBy( x => x.displayName ).ToList();
			}
			//m_registerItems = m_registerItems.OrderBy( x => x.displayName ).ToList();
			Reload();
		}


		protected override void OnRowGUI( RowGUIArgs args ) {
			var item = (Item) args.item;
			if( item.root && !args.selected ) {
				HEditorStyles.sceneTopBarBg.Draw( args.rowRect );
			}

			DefaultRowGUI( args );

			//if( item.guid.IsEmpty() ) return;

			//var r = args.rowRect;
			//r.width = 16;
			//r.x += ( item.depth + 1 ) * 16;
			//if( EditorHelper.HasMouseClick( r ) ) {
			//	EditorHelper.PingObject( GUIDUtils.GetAssetPath( item.guid ) );
			//}
			if( item.settings == null ) return;
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
			if( currentItem == null ) return;
			if( currentItem.settings == null ) return;

			if( currentItem.settings .customLayoutMode) {
				currentItem.settings?.gui();
			}
			else {
				using( new GUILayoutScope() ) {
					GUILayout.Space( 4 );
					currentItem.settings?.gui();
				}
			}
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
