
using UnityEngine;

namespace Hananoki {
	public static class ColorUtils {
		public static Color RGB( int r, int g, int b ) {
			return new Color( r / 255.0f, g / 255.0f, b / 255.0f );
		}
		public static Color RGB( int rgb ) {
			return new Color( rgb / 255.0f, rgb / 255.0f, rgb / 255.0f );
		}

		public static Color Alpha( Color color, float alpha ) {
			return new Color( color.r, color.g, color.b, alpha );
		}
	}
}
