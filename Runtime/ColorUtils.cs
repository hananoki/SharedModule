
using UnityEngine;

namespace HananokiRuntime {
	public static class ColorUtils {
		public static Color RGBA( byte r, byte g, byte b, byte a ) {
			return new Color( r / 255.0f, g / 255.0f, b / 255.0f, a / 255.0f );
		}

		public static Color RGB( int r, int g, int b ) {
			return new Color( r / 255.0f, g / 255.0f, b / 255.0f );
		}

		public static Color RGB( int rgb ) {
			return new Color( rgb / 255.0f, rgb / 255.0f, rgb / 255.0f );
		}

		public static Color RGB( float rgb ) {
			return new Color( rgb / 255.0f, rgb / 255.0f, rgb / 255.0f );
		}

		public static Color RGBA( Color rgb, Color a ) {
			return RGBA( rgb, a.a );
		}
		public static Color RGBA( Color rgb, float a ) {
			return new Color( rgb.r, rgb.g, rgb.b, a );
		}
	}
}
