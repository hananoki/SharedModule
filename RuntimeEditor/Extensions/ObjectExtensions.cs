using UnityEditor;
using UnityEngine;
using System;
using HananokiRuntime;
using UnityObject = UnityEngine.Object;

namespace HananokiEditor.Extensions {
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
			// ??? AssetDatabase.IsSubAssetの結果がおかしい、バグ? 2019.4.5f1
			return !AssetDatabase.IsMainAsset( obj );
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


		/// <summary>
		/// オブジェクトをダーティとしてマークします
		/// </summary>
		/// <param name="target">UnityEngine.Object</param>
		public static void SetDirty( this UnityObject target ) {
			EditorUtility.SetDirty( target );
		}


		/// <summary>
		/// すべてのサブアセット配列を返します
		/// </summary>
		/// <param name="target"></param>
		/// <returns>サブアセット配列</returns>
		public static UnityObject[] LoadAllSubAssets( this UnityObject target ) {
			return AssetDatabaseUtils.LoadAllSubAssets( target );
		}


		public static string GetTypeName( this UnityObject target ) {
			return target.GetType().Name;
		}

		public static bool IsNull( this UnityObject target ) {
			return Helper.IsNull( target );
		}

		public static SerializedObject CreateSerializedObject( this UnityObject o ) {
			return new SerializedObject( o );
		}
	}
}

