
using Hananoki.Extensions;
using UnityEditor;
using UnityEngine;
using System.Linq;
using System;

using UnityObject = UnityEngine.Object;

namespace Hananoki {
	public static class AssetDatabaseUtils {

		#region GetOrCreateInstance

		public static T GetOrCreateInstance<T>( string assetPath ) where T : ScriptableObject {
			T instance;
			if( assetPath.IsExistsFile() ) {
				instance = AssetDatabase.LoadAssetAtPath<T>( assetPath );
			}
			else {
				instance = ScriptableObject.CreateInstance<T>();
				AssetDatabase.CreateAsset( instance, assetPath );
			}
			return instance;
		}

		public static ScriptableObject GetOrCreateInstance( string assetPath ) {
			return GetOrCreateInstance<ScriptableObject>( assetPath );
		}

		#endregion



		#region RemoveSubAssetAll

		public static void RemoveSubAssetAll( UnityObject asset, Action exitAction = null ) {
			RemoveSubAssetAll( asset.ToAssetPath(), exitAction );
		}

		public static void RemoveSubAssetAll( string assetPath, Action exitAction = null ) {
			var objes = AssetDatabase.LoadAllAssetsAtPath( assetPath );
			var lst = objes.Where( x => !AssetDatabase.IsMainAsset( x ) ).ToArray();
			for( int i = 0; i < lst.Length; i++ ) {
				UnityObject.DestroyImmediate( lst[ i ], true );
			}

			exitAction?.Invoke();
		}

		#endregion



		#region LoadAssetAtGUID

		public static T LoadAssetAtGUID<T>( string guid ) where T : UnityObject {
			return (T) LoadAssetAtGUID( guid, typeof( T ) );
		}

		public static UnityObject LoadAssetAtGUID( string guid ) {
			return LoadAssetAtGUID( guid, typeof( UnityObject ) );
		}

		public static UnityObject LoadAssetAtGUID( string guid, Type type ) {
			return AssetDatabase.LoadAssetAtPath( guid.ToAssetPath(), type );
		}

		#endregion



		#region LoadAllSubAssetsAtPath

		//public static UnityObject[] LoadAllSubAssetsAtPath( UnityObject asset ) {
		//	return LoadAllSubAssetsAtPath( asset.ToAssetPath() );
		//}

		public static UnityObject[] LoadAllSubAssets( object obj ) {
			var assetPath = obj.ContextToAssetPath();
			return AssetDatabase.LoadAllAssetsAtPath( assetPath ).Where( x => !x.IsMainAsset() ).ToArray();
		}

		#endregion



		#region LoadSubAssetAtName

		/// <summary>
		/// name が一致するサブアセットを取得します
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="asset">メインアセット</param>
		/// <param name="name">サブアセット名</param>
		/// <returns></returns>
		public static T LoadSubAssetAtName<T>( object obj, string name ) where T : UnityObject {
			foreach( var p in LoadAllSubAssets( obj ) ) {
				if( p.name == name ) {
					return (T) p;
				}
			}
			return null;
		}

		public static UnityObject LoadSubAssetAtName( object obj, string name ) {
			return LoadSubAssetAtName<UnityObject>( obj, name );
		}

		#endregion



		public static void SaveAssetsAndRefresh() {
			AssetDatabase.SaveAssets();
			AssetDatabase.Refresh();
		}
	}
}
