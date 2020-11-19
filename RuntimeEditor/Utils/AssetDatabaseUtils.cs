
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
			RemoveSubAssetAll( asset.GetAssetPath(), exitAction );
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



		#region LoadAllSubAssetsAtPath

		public static UnityObject[] LoadAllSubAssetsAtPath( UnityObject asset ) {
			return LoadAllSubAssetsAtPath( asset.GetAssetPath() );
		}

		public static UnityObject[] LoadAllSubAssetsAtPath( string assetPath ) {
			return AssetDatabase.LoadAllAssetsAtPath( assetPath ).Where( x => !AssetDatabase.IsMainAsset( x ) ).ToArray();
		}

		#endregion



		#region LoadSubAssetAtName

		public static T LoadSubAssetAtName<T>( UnityObject asset, string name ) where T : UnityObject {
			foreach( var p in LoadAllSubAssetsAtPath( asset ) ) {
				if( p.name == name ) {
					return (T) p;
				}
			}
			return null;
		}

		public static UnityObject LoadSubAssetAtName( UnityObject asset, string name ) {
			return LoadSubAssetAtName<UnityObject>( asset, name );
		}

		#endregion



		public static void SaveAssetsAndRefresh() {
			AssetDatabase.SaveAssets();
			AssetDatabase.Refresh();
		}
	}
}
