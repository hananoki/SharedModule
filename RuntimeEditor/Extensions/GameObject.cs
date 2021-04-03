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

	}
}
