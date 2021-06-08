using System;
using System.IO;
using UnityEngine;

namespace HananokiEditor {
	public static class PackageDatabaseUtils {
		//public static void InstallFromUrl( string url );

		public static void InstallFromUrl( string url ) {
			if( UnitySymbol.UNITY_2019_3_OR_NEWER ) {
				var db = UnityTypes.UnityEditor_PackageManager_UI_PackageDatabase.GetProperty<object>( "instance" );
				if( db == null ) {
					Debug.Log( "not found PackageDatabase" );
					return;
				}
				//foreach(var p in UnityTypes.UnityEditor_PackageManager_UI_PackageDatabase_PackageDatabaseInternal.GetMethods( R.AllMembers ) ) {
				//	Debug.Log(p.Name);
				//	}
				//var m = UnityTypes.UnityEditor_PackageManager_UI_PackageDatabase_PackageDatabaseInternal.GetMethod( "InstallFromPath", R.InstanceMembers );

				//m.Invoke( db, new object[] { path } );
				//th( Path.GetDirectoryName( text ) );
				db.MethodInvoke( "InstallFromUrl", new object[] { url } );
			}
			else if( UnitySymbol.UNITY_2019_2_OR_NEWER ) {
				//Debug.Log( UnityTypes.UnityEditor_PackageManager_UI_Package.Name );
				//UnityTypes.UnityEditor_PackageManager_UI_Package.MethodInvoke( "AddFromLocalDisk", new object[] { Path.GetDirectoryName( path ) } );
			}
			else {
				//var t = Type.GetType( $"UnityEditor.PackageManager.UI.Package, Unity.PackageManagerUI.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );

				////var t = EditorHelper.GetTypeFromString( "UnityEditor.PackageManager.UI.Package" );
				//t.MethodInvoke( "AddFromLocalDisk", new object[] { Path.GetDirectoryName( path ) } );
			}
		}

		public static void InstallFromPath( string path ) {
			if( UnitySymbol.UNITY_2019_3_OR_NEWER ) {
				var db = UnityTypes.UnityEditor_PackageManager_UI_PackageDatabase.GetProperty<object>( "instance" );
				if( db == null ) {
					Debug.Log( "not found PackageDatabase" );
					return;
				}
				//foreach(var p in UnityTypes.UnityEditor_PackageManager_UI_PackageDatabase_PackageDatabaseInternal.GetMethods( R.AllMembers ) ) {
				//	Debug.Log(p.Name);
				//	}
				//var m = UnityTypes.UnityEditor_PackageManager_UI_PackageDatabase_PackageDatabaseInternal.GetMethod( "InstallFromPath", R.InstanceMembers );

				//m.Invoke( db, new object[] { path } );
				//th( Path.GetDirectoryName( text ) );
				db.MethodInvoke( "InstallFromPath", new object[] { Path.GetDirectoryName( path ) } );
			}
			else if( UnitySymbol.UNITY_2019_2_OR_NEWER ) {
				Debug.Log( UnityTypes.UnityEditor_PackageManager_UI_Package.Name );
				UnityTypes.UnityEditor_PackageManager_UI_Package.MethodInvoke( "AddFromLocalDisk", new object[] { Path.GetDirectoryName( path ) } );
			}
			else {
				var t = Type.GetType( $"UnityEditor.PackageManager.UI.Package, Unity.PackageManagerUI.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" );

				//var t = EditorHelper.GetTypeFromString( "UnityEditor.PackageManager.UI.Package" );
				t.MethodInvoke( "AddFromLocalDisk", new object[] { Path.GetDirectoryName( path ) } );
			}
		}



		public static void RemovePackage( string displayName ) {
			if( UnitySymbol.UNITY_2019_3_OR_NEWER ) {
				var db = UnityTypes.UnityEditor_PackageManager_UI_PackageDatabase.GetProperty<object>( "instance" );
				if( db == null ) {
					Debug.LogError( "not found PackageDatabase" );
					return;
				}

				var ipackage = db.MethodInvoke<object>( "GetPackage", new Type[] { typeof( string ) }, new object[] { "com.hananoki.auto-back-upper-backup" } );
				//var ipackage = db.MethodInvoke<object>( "GetPackageByDisplayName", new object[] { displayName } );
				if( ipackage == null ) {
					//Debug.LogError( $"GetPackage failed. not found [{displayName}]" );
					throw new Exception( $"GetPackage Failed: not found [{displayName}]" );
				}

				db.MethodInvoke( "Uninstall", new object[] { ipackage } );
			}
			else {
				// UNITY_2019_2以前はウィンドウ立ち上げないとパッケージリストが取れない
				// UNITY_2019_1はアセンブリが別でさらに手間
				// UNITY_2018_4以前はユーザパッケージが正式対応してない
				// 諸々踏まえて2019_1と2019_2は非対応、手動によるパッケージ削除にする
				throw new Exception( "Not supported before UNITY_2019_2" );
			}
		}
	}
}
