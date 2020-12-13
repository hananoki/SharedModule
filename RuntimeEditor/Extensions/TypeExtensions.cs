using System;


namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {
		public static string[] SplitFullName( this Type t ) {
			return t.FullName.Split( '.' );
		}
	}
}

