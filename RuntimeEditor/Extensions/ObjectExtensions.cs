using UnityEditor;
using UnityEngine;
using System;
using UnityObject = UnityEngine.Object;

namespace Hananoki.Extensions {
	public static class ObjectExtensions {

		/// <summary>
		/// parent に child を追加
		/// </summary>
		/// <param name="parent">メインアセット</param>
		/// <param name="child">サブアセット</param>
		public static void AddObjectToAsset( this UnityObject parent, UnityObject child ) {
			AssetDatabase.AddObjectToAsset( child, parent );
		}


		/// <summary>
		/// アイコンを取得します
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static Texture2D GetCachedIcon( this UnityObject obj ) {
			return (Texture2D) AssetDatabase.GetCachedIcon( obj.ToAssetPath() );
		}

		/// <summary>
		/// アセットがプロジェクトウインドウでメインのアセットかどうか
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static bool IsMainAsset( this UnityObject obj ) {
			return AssetDatabase.IsMainAsset( obj );
		}


		/// <summary>
		/// このアセットが他のアセットの一部かどうか
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static bool IsSubAsset( this UnityObject obj ) {
			return AssetDatabase.IsSubAsset( obj );
		}


		public static bool IsSubclassOf( this UnityObject obj, Type type ) {
			return obj.GetType().IsSubclassOf( type );
		}


		/// <summary>
		/// アセットが保存されているプロジェクトフォルダーのパス名を返します
		/// </summary>
		/// <param name="o"></param>
		/// <returns></returns>
		public static string ToAssetPath( this UnityObject o ) {
			return AssetDatabase.GetAssetPath( o );
		}


		/// <summary>
		/// アセットから GUID を取得します
		/// </summary>
		/// <param name="o"></param>
		/// <returns></returns>
		public static string ToGUID( this UnityObject o ) {
			return o.ToAssetPath().ToGUID();
		}


		public static SerializedObject CreateSerializedObject( this UnityObject o ) {
			return  new SerializedObject( o );
		}
	}
}

