using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {

		public static Texture2D GetIcon( this GameObject target ) {
			var status = PrefabUtility.GetPrefabInstanceStatus( target );
			switch( status ) {
			case PrefabInstanceStatus.Connected:
				return EditorIcon.icons_processed_prefabmodel_icon_asset;
			}
			return EditorIcon.icons_processed_unityengine_gameobject_icon_asset;
		}


		public static bool HasHideFlags( this GameObject go, HideFlags chk ) {
			return 0 != ( go.hideFlags & chk ) ? true : false;
		}

		public static void EnableHideFlags( this GameObject go, HideFlags chk ) {
			go.hideFlags |= chk;
		}

		public static void DisableHideFlags( this GameObject go, HideFlags chk ) {
			go.hideFlags &= ~chk;
		}

		public static GameObject GetParentRoot( this GameObject go ) {
			var trs = go.transform;
			while( trs.parent != null ) {
				trs = trs.parent;
			}
			return trs.gameObject;
		}

		public static GameObject[] GetGameObjects( this GameObject go ) {
			var lst = new List<GameObject>();
			_GetAll( go.transform, ref lst );
			return lst.ToArray();
		}

		static void _GetAll( this Transform trs, ref List<GameObject> lst ) {
			lst.Add( trs.gameObject );
			for( int i = 0; i < trs.childCount; i++ ) {
				_GetAll( trs.GetChild( i ), ref lst );
			}
		}
	}
}
