
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEditor_Tilemaps_GridPalettes;
		public static Type UnityEditor_Tilemaps_GridPalettes => Get( ref _UnityEditor_Tilemaps_GridPalettes, "UnityEditor.Tilemaps.GridPalettes", "Unity.2D.Tilemap.Editor" );

		static Type _UnityEditor_Tilemaps_GridPaintPaletteWindow;
		public static Type UnityEditor_Tilemaps_GridPaintPaletteWindow {
			get {
				if( _UnityEditor_Tilemaps_GridPaintPaletteWindow == null ) {
					if( UnitySymbol.UNITY_2019_2_OR_NEWER ) {
						_UnityEditor_Tilemaps_GridPaintPaletteWindow = Get( ref _UnityEditor_Tilemaps_GridPaintPaletteWindow,"UnityEditor.Tilemaps.GridPaintPaletteWindow", "Unity.2D.Tilemap.Editor" );
					}
					else {
						_UnityEditor_Tilemaps_GridPaintPaletteWindow = Get( ref _UnityEditor_Tilemaps_GridPaintPaletteWindow,"UnityEditor.GridPaintPaletteWindow", "UnityEditor" );
					}
				}
				return _UnityEditor_Tilemaps_GridPaintPaletteWindow;
			}
		}

	}
}
