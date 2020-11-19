
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using System.Text.RegularExpressions;
using Hananoki.Reflection;

using UnityObject = UnityEngine.Object;

namespace Hananoki.Extensions {

	public static partial class EditorExtensions {

		public static T ToCast<T>( this object obj ) {
			return (T) obj;
		}
		public static int ToInt( this object obj ) {
			return obj.ToCast<int>();
		}

		public static void SetTitle( this EditorWindow wnd, string text ) {
			wnd.SetTitle( new GUIContent( text ) );
		}

		public static void SetTitle( this EditorWindow wnd, string text, Texture2D image ) {
			wnd.SetTitle( new GUIContent( text, image ) );
		}

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

		public static Texture2D GetCachedIcon( this UnityObject obj ) {
			return (Texture2D) AssetDatabase.GetCachedIcon( obj.GetAssetPath() );
		}

		public static string GetAssetPath( this UnityObject obj ) {
			return AssetDatabase.GetAssetPath( obj );
		}

		public static string GetGUID( this UnityObject obj ) {
			return AssetDatabase.AssetPathToGUID( GetAssetPath( obj ) );
		}

		public static string GetPropertyType( this SerializedProperty property ) {
			var type = property.type;
			var match = Regex.Match( type, @"PPtr<\$(.*?)>" );
			return match.Success ? match.Groups[ 1 ].Value : type;
		}

		//public static string GetProperty( this SerializedProperty property ) {
		//	var type = typeof( SerializedProperty );
		//	object _property;
		//	_property.GetProperty<string>
		//}

		public static void AddObjectToAsset( this UnityObject parent, UnityObject child ) {
			AssetDatabase.AddObjectToAsset( child, parent );
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
