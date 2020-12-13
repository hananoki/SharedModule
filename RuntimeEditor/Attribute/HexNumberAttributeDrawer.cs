
using UnityEditor;
using UnityEngine;
using HananokiRuntime;

namespace HananokiEditor {
	[CustomPropertyDrawer( typeof( HexNumberAttribute ) )]
	class HexANumberttributeDrawer : PropertyDrawer {
		HexNumberAttribute atb { get { return (HexNumberAttribute) attribute; } }


		public override void OnGUI( Rect rc, SerializedProperty property, GUIContent label ) {

			rc = EditorGUI.PrefixLabel( rc, GUIUtility.GetControlID( FocusType.Passive ), label );

			EditorGUI.BeginDisabledGroup( true );
			EditorGUI.TextField( rc, "0x" + property.intValue.ToString( "x8" ) );
			EditorGUI.EndDisabledGroup();
		}
	}

}

