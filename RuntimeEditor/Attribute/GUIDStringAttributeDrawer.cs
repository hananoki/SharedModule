﻿
#if UNITY_EDITOR

using HananokiRuntime;
using UnityEditor;
using UnityEngine;
using UnityObject = UnityEngine.Object;

namespace HananokiEditor {

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

			if( m_scnCache == null && !string.IsNullOrEmpty( property.stringValue ) ) {
				//var col = GUI.contentColor;
				//GUI.contentColor = Color.red;
				EditorGUI.DrawRect( rc, new Color( 1, 0, 0, 0.2f ) );
				rc = EditorGUI.PrefixLabel( rc, GUIUtility.GetControlID( FocusType.Passive ), new GUIContent( $"{label.text}: missing" ) );
				//GUI.contentColor = col;
			}
			else {
				rc = EditorGUI.PrefixLabel( rc, GUIUtility.GetControlID( FocusType.Passive ), label );
			}
			EditorGUI.BeginChangeCheck();
			//if()
			UnityObject value = (UnityObject) EditorGUI.ObjectField( rc, m_scnCache, atb.m_type, false );
			if( EditorGUI.EndChangeCheck() ) {
				property.stringValue = AssetDatabase.AssetPathToGUID( AssetDatabase.GetAssetPath( value ) );
			}
		}
	}
}

#endif
