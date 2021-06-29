using System;
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


		/// <summary>
		/// Typeからアイコンを取得します
		/// 注意点、ObjectContentから取得できない場合、MonoScript検索が行われるため重いです
		/// 20210624 ScriptableObject系のものがObjectContentだと変な結果になるので専用の対応をする
		/// @todo キャッシュ化
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
		public static Texture2D GetIcon( this Type t ) {
			if( t.指定クラスを含む( typeof( ScriptableObject ) ) ) {
				var mn = EditorHelper.GetMonoScriptFromType( t );
				if( mn != null ) {
					var ic = mn.GetCachedIcon();
					
					// スクリプトに割り付けられたアイコンがあるなら、それを返す
					if( EditorIcon.cs_script != ic ) return ic;
				}
				// ObjectContentではdefaultアイコンなので直接指定アイコンを返す
				return EditorIcon.scriptableobject;
			}

			// 2020.3、ScriptableObjectだとDefaultアイコンが返ってくるので↑で専用判定で回避
			var ico = (Texture2D) EditorGUIUtility.ObjectContent( null, t ).image;
			if( ico != null ) return ico;

			var mono = EditorHelper.GetMonoScriptFromType( t );
			if( mono == null ) return null;
			ico = mono.GetCachedIcon();
			return ico;
		}



		public static bool 指定クラスを含む( this Type t, Type subClass ) {
			if( t == null ) return false;
			if( t == subClass ) return true;
			return t.IsSubclassOf( subClass );
		}

	}
}

