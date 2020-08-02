
#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using System.Linq;
using System.Collections.Generic;
using Hananoki;

using UnityObject = UnityEngine.Object;

namespace Hananoki {
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

#endif
