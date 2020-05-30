
using UnityEngine;

namespace Hananoki.Extensions {
	public static partial class EditorExtensions {
		public static Rect AddW( this Rect r, float f ) {
			r.x -= f;
			r.width += ( f * 2 );
			return r;
		}

		public static Rect AddH( this Rect r, float f ) {
			r.y -= f;
			r.height += ( f * 2 );
			return r;
		}

		public static Rect AlignR( this Rect r, float width ) {
			r.x = r.x + r.width;
			r.x -= width;
			r.width = width;
			return r;
		}
		public static Rect AlignCenterH( this Rect r, float height ) {
			r.y += ( r.height * 0.5f );
			r.y -= ( height * 0.5f );
			r.height = height;
			return r;
		}

		public static Rect AlignCenter( this Rect r, float width, float height ) {
			r.x += ( r.width * 0.5f );
			r.x -= ( width * 0.5f );
			r.width = width;

			r.y += ( r.height * 0.5f );
			r.y -= ( height * 0.5f );
			r.height = height;
			return r;
		}

		public static Rect PopupRect( this Rect rc ) {
			return new Rect( rc.x, rc.y + 6, rc.width, 12 );
		}
	}
}
