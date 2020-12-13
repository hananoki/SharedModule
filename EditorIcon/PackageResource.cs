﻿using UnityEngine;

namespace HananokiEditor.SharedModule {
	internal static class PackageResource {
		public static string[] i = { "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" };
	}

	public static class Icon {
		static IconDictionary packageResourceIcons;
		public static Texture2D Get( int n ) {
			if( packageResourceIcons == null ) {
				packageResourceIcons = new IconDictionary( PackageResource.i );
			}
			return packageResourceIcons.Get( n );
		}
		public static Texture2D AllowDown_ => Get( 0 );
		public static Texture2D AllowUp_ => Get( 1 );
		public static Texture2D ol_minus_ => Get( 2 );
		public static Texture2D d_ol_minus_ => Get( 3 );
		public static Texture2D ol_plus_ => Get( 4 );
		public static Texture2D d_ol_plus_ => Get( 5 );
		public static Texture2D icondropdown_ => Get( 6 );
		public static Texture2D DopesheetBackground_ => Get( 7 );
		public static Texture2D burger_ => Get( 8 );
		public static Texture2D d_burger_ => Get( 9 );
		public static Texture2D under_line_ => Get( 10 );
	}
}
