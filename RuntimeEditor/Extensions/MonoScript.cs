using System;
using System.Linq;
using UnityEditor;

namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {

		/// <summary>
		/// MonoScript.GetClassの差し替え
		/// ScriptableObject型が返って来ない場合の対処等
		/// Type情報だけではどのMonoScriptかまでは判断できないため、複数の場合等outputを元に外側で判断してもらう
		/// output.Length == 0 は該当無し
		/// output.Length == N は複数該当有り
		/// </summary>
		/// <param name="target">検索対象</param>
		/// <param name="output">指定したtargetに一致すると思われるType配列を返す</param>
		/// <returns>見つかった型</returns>
		public static Type GetObjectClassType( this MonoScript target, out Type[] output ) {
			var result = target.GetClass();
			output = null;

			// 標準で返ってくるならそれを返す
			if( result != null ) {
				return result;
			}

			// ファイル名==クラス名になるはず、名前一致したものから検索
			output = AssemblieUtils.loadedTypes
					.Where( x => x.FullName.Contains( target.name ) )
					.Where( x => !x.FullName.Contains( "+" ) )
					.ToArray();

			// 一個なら確定なので返す
			if( output.Length == 1 ) return output[ 0 ];

			return null;
		}

	}
}
