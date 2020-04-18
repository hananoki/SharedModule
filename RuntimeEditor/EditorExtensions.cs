
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Hananoki.Extensions {

	public static class EditorExtensions {

		#region string

		public static string quote( this string s ) {
			return '"' + s + '"';
		}

		public static string nicify( this string s ) {
			return ObjectNames.NicifyVariableName( s );
		}

		public static string stringModify( this string s1 ) {
			s1 = s1.Replace( " ", "" );
			s1 = s1.Replace( "-", "_" );
			s1 = s1.Replace( ".", "_" );
			s1 = s1.Replace( "&", "_" );
			s1 = s1.Replace( ",", "_" );
			s1 = s1.Replace( "?", "_" );
			s1 = s1.Replace( "[", "_" );
			s1 = s1.Replace( "]", "_" );
			s1 = s1.Replace( "(", "_" );
			s1 = s1.Replace( ")", "_" );
			s1 = s1.Replace( "+", "_" );
			s1 = s1.Replace( "\"", "_" );
			s1 = s1.Replace( "…", "_" );
			s1 = s1.Replace( "#", "Sharp" );

			return s1;
		}

		public static string ToStringLower( this object obj ) {
			return obj.ToString().ToLower();
		}

		public static GUIContent content( this string s ) {
			return new GUIContent( s, s );
		}
		public static GUIContent content( this Texture2D s ) {
			return new GUIContent( s );
		}

		public static GUIContent contentTemp( this string s ) {
			return EditorHelper.TempContent( s, s );
		}



		public static string FileNameWithoutExtension( this string s ) {
			return Path.GetFileNameWithoutExtension( s );
		}

		public static string DirectoryName( this string s ) {
			return Path.GetDirectoryName( s );
		}

		public static string FileName( this string s ) {
			return Path.GetFileName( s );
		}

		public static string Extension( this string s ) {
			return Path.GetExtension( s );
		}

		#endregion




		public static T ToCast<T>( this object obj ) {
			return (T) obj;
		}
		public static int ToInt( this object obj ) {
			return obj.ToCast<int>();
		}

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



		#region GenericMenu

		public static void AddItem( this GenericMenu menu, string s, bool on, GenericMenu.MenuFunction func ) {
			menu.AddItem( new GUIContent( s ), on, func );
		}

		public static void AddItem( this GenericMenu menu, string s1, string s2, bool on, GenericMenu.MenuFunction func ) {
			menu.AddItem( new GUIContent( s1, s2 ), on, func );
		}

		public static void AddItem( this GenericMenu menu, string s, bool on, GenericMenu.MenuFunction2 func, object userData ) {
			menu.AddItem( new GUIContent( s ), on, func, userData );
		}

		public static void AddDisabledItem( this GenericMenu menu, string s ) {
			menu.AddDisabledItem( new GUIContent( s ) );
		}

		public static void AddDisabledItem( this GenericMenu menu, string s1, string s2 ) {
			menu.AddDisabledItem( new GUIContent( s1, s2 ) );
		}

		public static void DropDown( this GenericMenu menu ) {
			menu.DropDown( new Rect( Event.current.mousePosition, new Vector2( 0, 0 ) ) );
		}

		#endregion


		/// <summary>
		/// スネークケースをアッパーキャメル(パスカル)ケースに変換します
		/// 例) quoted_printable_encode → QuotedPrintableEncode
		/// </summary>
		public static string SnakeToUpperCamel( this string self ) {
			if( string.IsNullOrEmpty( self ) ) return self;

			return self
					.Split( new[] { '_' }, StringSplitOptions.RemoveEmptyEntries )
					.Select( s => char.ToUpperInvariant( s[ 0 ] ) + s.Substring( 1, s.Length - 1 ) )
					.Aggregate( string.Empty, ( s1, s2 ) => s1 + s2 )
			;
		}

		/// <summary>
		/// スネークケースをローワーキャメル(キャメル)ケースに変換します
		/// 例) quoted_printable_encode → quotedPrintableEncode
		/// </summary>
		//public static string SnakeToLowerCamel( this string self ) {
		//	if( string.IsNullOrEmpty( self ) ) return self;

		//	return self
		//			.SnakeToUpperCamel()
		//			.Insert( 0, char.ToLowerInvariant( self[ 0 ] ).ToString() ).Remove( 1, 1 )
		//	;
		//}

		public static void SetTitle( this EditorWindow wnd, GUIContent cont ) {
			var property = typeof( EditorWindow ).GetProperty( "titleContent" );

			if( property != null ) {
				// インスタンスの値を取得
				var beforeName = property.GetValue( wnd, null );

				// インスタンスに値を設定
				property.SetValue( wnd, cont, null );
			}
			else {
#if UNITY_5_0
				wnd.title = cont.text;
#else
				wnd.titleContent = cont;
#endif
			}
		}


		public static string colorTag( this string s, string color ) {
			return "<color=" + s + ">" + s + "</color>";
		}







		//public static string GUID2Path( this string guid ) {
		//	return AssetDatabase.GUIDToAssetPath( guid );
		//}

		/// <summary>
		/// 指定したアセットのGUIDを返します
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		//public static string toGUID( UnityEngine.Object obj ) {
		//	var a = AssetDatabase.GetAssetPath( obj );
		//	var b = AssetDatabase.AssetPathToGUID( a );
		//	return b;
		//}


		//public static T GUID2Asset<T>( this string guid ) where T : UnityEngine.Object {
		//	var a = AssetDatabase.GUIDToAssetPath( guid );
		//	T b = AssetDatabase.LoadAssetAtPath( a, typeof( T ) ) as T;
		//	return b;
		//}
		//public static UnityEngine.Object GUID2Asset( this string guid ) {
		//	var a = AssetDatabase.GUIDToAssetPath( guid );
		//	var b = (UnityEngine.Object) AssetDatabase.LoadAssetAtPath( a, typeof( UnityEngine.Object ) );
		//	return b;
		//}
		//public static UnityEngine.Object pathAsset( this string path ) {
		//	var b = (UnityEngine.Object) AssetDatabase.LoadAssetAtPath( path, typeof( UnityEngine.Object ) );
		//	return b;
		//}

		public static int toInt( this string s ) {
			return int.Parse( s );
		}



		public static float toRealTime( this AnimationClip clip ) {
			return clip.frameRate * clip.length;
		}





	}

	public static class IEnumerableExtensions {
		private sealed class CommonSelector<T, TKey> : IEqualityComparer<T> {
			private Func<T, TKey> m_selector;

			public CommonSelector( Func<T, TKey> selector ) {
				m_selector = selector;
			}

			public bool Equals( T x, T y ) {
				return m_selector( x ).Equals( m_selector( y ) );
			}

			public int GetHashCode( T obj ) {
				return m_selector( obj ).GetHashCode();
			}
		}

		public static IEnumerable<T> Distinct<T, TKey>(
				this IEnumerable<T> source,
				Func<T, TKey> selector
		) {
			return source.Distinct( new CommonSelector<T, TKey>( selector ) );
		}
	}
}
