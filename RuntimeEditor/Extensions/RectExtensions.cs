
using UnityEngine;

namespace Hananoki.Extensions {
	public static partial class EditorExtensions {

		public static Rect W( this Rect r, float f ) {
			r.width = f;
			return r;
		}


		/// <summary>
		/// 矩形の中心から幅を広げる
		/// </summary>
		/// <param name="r"></param>
		/// <param name="f"></param>
		/// <returns></returns>
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

		/// <summary>
		/// 矩形の左端から指定幅をカットする
		/// </summary>
		/// <param name="r"></param>
		/// <param name="f"></param>
		/// <returns></returns>
		public static Rect TrimL( this Rect r, float f ) {
			r.x += f;
			r.width -= f;
			return r;
		}


		/// <summary>
		/// 入力矩形の右端から指定した幅分の矩形にする
		/// </summary>
		/// <param name="r"></param>
		/// <param name="width"></param>
		/// <returns></returns>
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



		public static void zero( this RectOffset self ) {
			self = new RectOffset( 0, 0, 0, 0 );
		}


		public static void Draw( this GUIStyle style, Rect rc ) {
			if( Event.current.type != EventType.Repaint ) return;

			style.Draw( rc, false, false, false, false );
		}

		public static float CalcHeight( this GUIStyle style, string text ) {

			return style.CalcHeight( EditorHelper.TempContent(text), 16 );
		}
	}
}
