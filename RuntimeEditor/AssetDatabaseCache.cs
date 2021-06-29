using HananokiEditor.Extensions;
using HananokiRuntime.Extensions;
using System;
using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions;
using UnityObject = UnityEngine.Object;

namespace HananokiEditor {
	public class AssetDatabaseCache {

		static Hashtable s_cacheAssets = new Hashtable();

		static AssetCacheData GetCache( string guid, long localID ) {
			try {
				var table = (AssetCacheTable) s_cacheAssets[ guid ];
				if( table == null ) return null;
				return table[ localID ];
			}
			catch( ArgumentNullException ) {
				Debug.LogError( $"{guid} : {localID}" );
			}
			catch( Exception e ) {
				Debug.LogException( e );
			}
			return null;
		}

		static void SetCache( string guid, long localID, AssetCacheData data ) {
			var table = (AssetCacheTable) s_cacheAssets[ guid ];
			if( table == null ) {
				table = new AssetCacheTable();
				s_cacheAssets.Add( guid, table );
			}
			table[ localID ] = data;
		}


		public static AssetCacheData LoadAssetAtGUIDAndLocalID( string guid, long localID ) {
			if( guid == null ) {
				// null‚ÍEmpty‚ÅŠÛ‚ß‚é
				guid = string.Empty;
			}
			var cache = GetCache( guid, localID );
			if( cache != null ) return cache;

			cache = new AssetCacheData();
			if( guid.IsEmpty() ) {
			}
			else {
				var result = localID == 0 ? guid.LoadAsset() : AssetDatabaseUtils.LoadAssetAtGUIDAndLocalID( guid, localID );
				cache.unityObject = result;
				if( result == null ) {
					cache.missing = true;
				}
			}
			SetCache( guid, localID, cache );
			return cache;
		}
	}


	public class AssetCacheTable {
		public Hashtable m_table = new Hashtable();
		public AssetCacheData this[ long localID ] {
			get {
				return (AssetCacheData) m_table[ localID ];
			}
			set {
				Assert.IsNull( m_table[ localID ] );
				m_table.Add( localID, value );
			}
		}
	}

	public class AssetCacheData {
		public UnityObject unityObject;
		public bool missing;

		public MonoScript monoScript => (MonoScript) unityObject;
		public Material material => (Material) unityObject;

		public string label;
	}

	public class AssetDatabaseID {
		public string guid;
		public long localID;
	}
}