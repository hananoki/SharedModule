
#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using System.Linq;
using System.Collections.Generic;
using Hananoki;

using UnityObject = UnityEngine.Object;

namespace Hananoki {

	[CustomPropertyDrawer( typeof( GUIDStringAttribute ) )]
	class GUIDStringAttributeDrawer : PropertyDrawer {
		GUIDStringAttribute atb { get { return (GUIDStringAttribute) attribute; } }

		UnityObject m_scnCache = null;

		public override void OnGUI( Rect rc, SerializedProperty property, GUIContent label ) {
			//EditorGUI.PropertyField( rc, property, label );
			if( m_scnCache != null ) {
				if( m_scnCache.name != property.stringValue ) {
					m_scnCache = null;
				}
			}

			if( m_scnCache == null ) {
				var path = AssetDatabase.GUIDToAssetPath( property.stringValue );
				if( !string.IsNullOrEmpty( path ) ) {
					m_scnCache = AssetDatabase.LoadAssetAtPath<UnityObject>( path );
					//try {
					//	Debug.Log( m_scnCache.GetType() );
					//}
					//catch ( System.Exception e ){
					//	Debug.Log( e.ToString() );
					//}
				}
			}

			rc = EditorGUI.PrefixLabel( rc, GUIUtility.GetControlID( FocusType.Passive ), label );
			GUI.changed = false;
			Object value = (UnityObject) EditorGUI.ObjectField( rc, m_scnCache, atb.m_type, false );
			if( GUI.changed ) {
				property.stringValue = AssetDatabase.AssetPathToGUID( AssetDatabase.GetAssetPath( value ) );
			}
		}
	}
}

#endif
