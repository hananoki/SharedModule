using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if false

using Hananoki.Reflection;
using System;
using System.Reflection;

namespace Hananoki {
	public static class UnityStyleSheetsStyleCatalogKeyword {
		static Type _type;
		static Type type {
			get {
				if( _type == null ) _type = Assembly.Load( "UnityEditor.dll" ).GetType( "UnityEditor.StyleSheets.StyleCatalogKeyword" );
				return _type;
			}
		}
		static int GetValue( string s) => (int) type.GetField( s ).GetValue( null );

		public static int root => GetValue( "root" );
		public static int left => GetValue( "left" );
		public static int right => GetValue( "right" );
		public static int top => GetValue( "top" );
		public static int bottom => GetValue( "bottom" );
		public static int background => GetValue( "background" );
		public static int backgroundAttachment => GetValue( "backgroundAttachment" );
		public static int backgroundColor => GetValue( "backgroundColor" );
		public static int backgroundImage => GetValue( "backgroundImage" );
		public static int scaledBackgroundImage => GetValue( "scaledBackgroundImage" );
		public static int backgroundPosition => GetValue( "backgroundPosition" );
		public static int backgroundPositionX => GetValue( "backgroundPositionX" );
		public static int backgroundPositionY => GetValue( "backgroundPositionY" );
		public static int contentImageOffsetX => GetValue( "contentImageOffsetX" );
		public static int contentImageOffsetY => GetValue( "contentImageOffsetY" );
		public static int backgroundRepeat => GetValue( "backgroundRepeat" );
		public static int backgroundSize => GetValue( "backgroundSize" );
		public static int border => GetValue( "border" );
		public static int borderBottom => GetValue( "borderBottom" );
		public static int borderBottomColor => GetValue( "borderBottomColor" );
		public static int borderBottomStyle => GetValue( "borderBottomStyle" );
		public static int borderBottomWidth => GetValue( "borderBottomWidth" );
		public static int borderColor => GetValue( "borderColor" );
		public static int borderLeft => GetValue( "borderLeft" );
		public static int borderLeftColor => GetValue( "borderLeftColor" );
		public static int borderLeftStyle => GetValue( "borderLeftStyle" );
		public static int borderLeftWidth => GetValue( "borderLeftWidth" );
		public static int borderRadius => GetValue( "borderRadius" );
		public static int borderRight => GetValue( "borderRight" );
		public static int borderRightColor => GetValue( "borderRightColor" );
		public static int borderRightStyle => GetValue( "borderRightStyle" );
		public static int borderRightWidth => GetValue( "borderRightWidth" );
		public static int borderStyle => GetValue( "borderStyle" );
		public static int borderTop => GetValue( "borderTop" );
		public static int borderTopColor => GetValue( "borderTopColor" );
		public static int borderTopStyle => GetValue( "borderTopStyle" );
		public static int borderTopWidth => GetValue( "borderTopWidth" );
		public static int borderWidth => GetValue( "borderWidth" );
		public static int clear => GetValue( "clear" );
		public static int clip => GetValue( "clip" );
		public static int color => GetValue( "color" );
		public static int cursor => GetValue( "cursor" );
		public static int display => GetValue( "display" );
		public static int filter => GetValue( "filter" );
		public static int cssFloat => GetValue( "cssFloat" );
		public static int font => GetValue( "font" );
		public static int fontFamily => GetValue( "fontFamily" );
		public static int fontSize => GetValue( "fontSize" );
		public static int fontVariant => GetValue( "fontVariant" );
		public static int fontWeight => GetValue( "fontWeight" );
		public static int height => GetValue( "height" );
		public static int letterSpacing => GetValue( "letterSpacing" );
		public static int lineHeight => GetValue( "lineHeight" );
		public static int listStyle => GetValue( "listStyle" );
		public static int listStyleImage => GetValue( "listStyleImage" );
		public static int listStylePosition => GetValue( "listStylePosition" );
		public static int listStyleType => GetValue( "listStyleType" );
		public static int margin => GetValue( "margin" );
		public static int marginBottom => GetValue( "marginBottom" );
		public static int marginLeft => GetValue( "marginLeft" );
		public static int marginRight => GetValue( "marginRight" );
		public static int marginTop => GetValue( "marginTop" );
		public static int opacity => GetValue( "opacity" );
		public static int overflow => GetValue( "overflow" );
		public static int overflowX => GetValue( "overflowX" );
		public static int overflowY => GetValue( "overflowY" );
		public static int padding => GetValue( "padding" );
		public static int paddingBottom => GetValue( "paddingBottom" );
		public static int paddingLeft => GetValue( "paddingLeft" );
		public static int paddingRight => GetValue( "paddingRight" );
		public static int paddingTop => GetValue( "paddingTop" );
		public static int pageBreakAfter => GetValue( "pageBreakAfter" );
		public static int pageBreakBefore => GetValue( "pageBreakBefore" );
		public static int position => GetValue( "position" );
		public static int size => GetValue( "size" );
		public static int strokeDasharray => GetValue( "strokeDasharray" );
		public static int strokeDashoffset => GetValue( "strokeDashoffset" );
		public static int strokeWidth => GetValue( "strokeWidth" );
		public static int textAlign => GetValue( "textAlign" );
		public static int textDecoration => GetValue( "textDecoration" );
		public static int textDecorationColor => GetValue( "textDecorationColor" );
		public static int textIndent => GetValue( "textIndent" );
		public static int textTransform => GetValue( "textTransform" );
		public static int verticalAlign => GetValue( "verticalAlign" );
		public static int visibility => GetValue( "visibility" );
		public static int width => GetValue( "width" );
		public static int minWidth => GetValue( "minWidth" );
		public static int maxWidth => GetValue( "maxWidth" );
		public static int zIndex => GetValue( "zIndex" );


	}
}

#endif
