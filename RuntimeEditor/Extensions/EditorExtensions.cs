#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using System.Text.RegularExpressions;
using Hananoki.Extensions;

using UnityObject = UnityEngine.Object;

namespace Hananoki.Extensions {

	public static partial class EditorExtensions {

		public static Type ContextToType( this object context ) {
			Type result = context as Type;

			if( result !=null) return result;

			if( Type.GetTypeHandle( context ).Equals( typeof( string ).TypeHandle ) ) {
				var s = (string) context;
				result = Type.GetType( s );
				if( result == null ) {
					result = EditorHelper.GetTypeFromString(s);
				}
			}

			return result;
		}

		public static string ContextToAssetPath( this object context ) {
			string result;

			if( Type.GetTypeHandle( context ).Equals( typeof( string ).TypeHandle ) ) {
				var s = (string) context;
				if( s.StartWithAssets() ) {
					result = s;
				}
				else {
					result = s.ToAssetPath();
				}
			}
			else {
				result = ( (UnityObject) context ).ToAssetPath();
			}
			return result;
		}

		public static UnityObject ContextToObject( this object context ) {
			UnityObject result;
			if( Type.GetTypeHandle( context ).Equals( typeof( string ).TypeHandle ) ) {
				var s = (string) context;

				result = s.LoadAsset();
			}
			else {
				result = (UnityObject) context;
			}
			return result;
		}


		public static void SetTitle( this EditorWindow wnd, string text ) {
			wnd.SetTitle( new GUIContent( text ) );
		}

		public static void SetTitle( this EditorWindow wnd, string text, Texture2D image ) {
			wnd.SetTitle( new GUIContent( text, image ) );
		}

		public static void SetTitle( this EditorWindow wnd, GUIContent cont ) {
			if( UnitySymbol.UNITY_5_3_OR_NEWER ) {
				wnd.titleContent = cont;
			}
			else {
				wnd.title = cont.text;
			}
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


		public static void Field( this SerializedProperty property ) {
			EditorGUILayout.PropertyField( property );
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
