#if UNITY_EDITOR

using Hananoki.Reflection;
using System;
using UnityObject = UnityEngine.Object;

namespace Hananoki {
	public static class UnityAddressableAssetInspectorGUI {
		public static void SetAaEntry( UnityAddressableAssetSettings aaSettings, UnityObject[] targets, bool create ) {
			R.Method( "SetAaEntry", "UnityEditor.AddressableAssets.GUI.AddressableAssetInspectorGUI", "Unity.Addressables.Editor" ).Invoke( null, new object[] { aaSettings.m_instance, targets, create } );
		}
	}

	public static class UnityAddressableAssetSettingsDefaultObject {
		public static UnityAddressableAssetSettings Settings {
			get {
				var p = R.Property( "Settings", "UnityEditor.AddressableAssets.AddressableAssetSettingsDefaultObject", "Unity.Addressables.Editor" );
				return new UnityAddressableAssetSettings() { m_instance = p.GetValue( null ) };
			}
		}

		public static UnityAddressableAssetSettings GetSettings( bool create ) {
			var obj = R.Method( "GetSettings", "UnityEditor.AddressableAssets.AddressableAssetSettingsDefaultObject", "Unity.Addressables.Editor" ).Invoke( null, new object[] { create } );
			return new UnityAddressableAssetSettings() { m_instance = obj };
		}
	}


	public class UnityAddressableAssetSettings {
		public object m_instance;

		public UnityAddressableAssetEntry FindAssetEntry( string guid ) {
			return new UnityAddressableAssetEntry() { m_instance = m_instance.MethodInvoke<object>( "FindAssetEntry", guid ) };
		}
	}


	public class UnityAddressableAssetEntry {
		public object m_instance;

		//public static bool operator ==( UnityAddressableAssetEntry x, UnityAddressableAssetEntry y ) {
		//	if( ReferenceEquals( x, y ) ) return true;

		//	if( ( (object) x == null ) ) {
		//		return  ( (object) x == y.m_instance );
		//	}
		//	if( ( (object) y == null ) ) {
		//		return ( (object) y == x.m_instance );
		//	}

		//	return x.m_instance == y.m_instance;
		//}

		//public static bool operator !=( UnityAddressableAssetEntry x, UnityAddressableAssetEntry y ) {
		//	return !( x == y );
		//}

		//public override int GetHashCode() {
		//	return m_instance.GetHashCode();
		//}
		//public override bool Equals( object other ) {
		//	var @object = other as UnityAddressableAssetEntry;
		//	return ( this == @object );
		//}
	}
}

#endif
