
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace HananokiEditor {
	public class IconDictionary {
		public Dictionary<int, Texture2D> icons;
		public string[] i;

		public IconDictionary( string[] i ) {
			this.i = i;
		}

		public Texture2D Get( int n ) {
			if( icons == null ) {
				icons = new Dictionary<int, Texture2D>();
			}
			bool load = false;
			if( !icons.ContainsKey( n ) ) load = true;

			else if( icons[ n ] == null ) load = true;

			if( load ) {
				var bb = B64.Decode( "iVBORw0KGgoAAAAN" + i[ n ] );
				const int wOff = 16;
				const int hOff = 20;
				var Widht = BitConverter.ToInt32( new[] { bb[ wOff + 3 ], bb[ wOff + 2 ], bb[ wOff + 1 ], bb[ wOff + 0 ], }, 0 );
				var Height = BitConverter.ToInt32( new[] { bb[ hOff + 3 ], bb[ hOff + 2 ], bb[ hOff + 1 ], bb[ hOff + 0 ], }, 0 );

				var t = new Texture2D( Widht, Height );
				t.LoadImage( bb );
				IconGarbage.Set( t );

				//t.hideFlags |= HideFlags.DontUnloadUnusedAsset;
				if( icons.ContainsKey( n ) ) {
					icons[ n ] = t;
				}
				else {
					icons.Add( n, t );

				}
			}

			return icons[ n ];
		}


		public static Texture2D GetSelect( Texture2D light, Texture2D dark ) => EditorGUIUtility.isProSkin ? dark : light;
	}


}
