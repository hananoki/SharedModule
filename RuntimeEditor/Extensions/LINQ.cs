#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using System.Text.RegularExpressions;
using HananokiEditor.Extensions;

using UnityObject = UnityEngine.Object;

namespace HananokiEditor.Extensions {

	public static class IEnumerableExtensions {
		sealed class CommonSelector<T, TKey> : IEqualityComparer<T> {
			Func<T, TKey> m_selector;

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


		public static IEnumerable<T> Distinct<T, TKey>( this IEnumerable<T> source, Func<T, TKey> selector ) {
			return source.Distinct( new CommonSelector<T, TKey>( selector ) );
		}


		/// <summary>
		/// 引数のリスト（何らかの名称のリスト）から、重複する要素を抽出する。
		/// </summary>
		/// <param name="list">何らかの名称のリスト。</param>
		/// <returns>重複している要素のリスト。</returns>
		public static IEnumerable<T> FindDuplication<T>( this IEnumerable<T> list ) {
			// 要素名でGroupByした後、グループ内の件数が2以上（※重複あり）に絞り込み、
			// 最後にIGrouping.Keyからグループ化に使ったキーを抽出している。
			var duplicates = list.GroupBy( name => name ).Where( name => name.Count() > 1 )
					.Select( group => group.Key );

			return duplicates;
		}

		public static IEnumerable<UnityObject> ToAsset( this IEnumerable<string> list ) {
			//foreach( var p in list ) Debug.Log( p.ToString() );

			return list.Select( x => x.LoadAsset() );
		}

		public static IEnumerable<T> Print<T>( this IEnumerable<T> list ) {
			foreach( var p in list ) Debug.Log( p.ToString() );

			return list;
		}
	}
}
