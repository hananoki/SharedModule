using HananokiRuntime;
using System;
using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityReflection;

namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {
		public static string[] SplitFullName( this Type t ) {
			return t.FullName.Split( '.' );
		}


		/// <summary>
		/// UnityTypeでのIDみたいなのを取得する
		/// https://docs.unity3d.com/ja/2018.4/Manual/ClassIDReference.html
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
		public static int GetPersistentTypeID( this Type t ) {
			string text = t.ToString().Substring( t.Namespace.ToString().Length + 1 );
			var unityTYpen = UnityEditorUnityType.FindTypeByName( text );
			var unityType = new UnityEditorUnityType( unityTYpen );
			return unityType.persistentTypeID;
		}


		static Hashtable s_iconCache;

		/// <summary>
		/// Typeからアイコンを取得します
		/// 注意点、ObjectContentから取得できない場合、MonoScript検索が行われるため重いです
		/// 20210624 ScriptableObject系のものがObjectContentだと変な結果になるので専用の対応をする
		/// 20210716 キャッシュ対応と存在しないアイコンの時の対応を追加
		/// </summary>
		/// <param name="t">アセットorコンポーネントの型</param>
		/// <returns>アイコン</returns>
		public static Texture2D GetIcon( this Type t ) {
			Helper.New( ref s_iconCache );
			Texture2D icon = null;

			if( t == null ) {
				return HananokiEditor.Icon.iconFailed;
			}
			icon = (Texture2D) s_iconCache[ t ];

			// キャッシュが見つかったらそれを返す
			if( icon != null ) return icon;

			// 見つからない時はいろいろと探す
			// それでも見つからない場合はマゼンタなエラーアイコンになる

			if( t.IncludesSpecifiedClass( typeof( ScriptableObject ) ) ) {
				var mn = EditorHelper.GetMonoScriptFromType( t );
				if( mn != null ) {
					var ic = mn.GetCachedIcon();

					// スクリプトに割り付けられたアイコンがあるなら、それを返す
					if( EditorIcon.cs_script != ic ) {
						icon = ic;
						goto find;
					}
				}
				// ObjectContentではdefaultアイコンなので直接指定アイコンを返す
				icon = EditorIcon.scriptableobject;
				goto find;
			}

			icon = (Texture2D) EditorGUIUtility.ObjectContent( null, t ).image;
			if( icon != null ) {
				goto find;
			}

			var mono = EditorHelper.GetMonoScriptFromType( t );
			if( mono == null ) {
				icon = HananokiEditor.Icon.iconFailed;
				goto find;
			}
			icon = mono.GetCachedIcon();

		find:
			s_iconCache.Add( t, icon );
			return icon;
		}


		
		public static bool IncludesSpecifiedClass( this Type t, Type subClass ) {
			if( t == null ) return false;
			if( t == subClass ) return true;
			return t.IsSubclassOf( subClass );
		}

	}
}

