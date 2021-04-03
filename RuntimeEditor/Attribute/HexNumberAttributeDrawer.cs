
using HananokiEditor.Extensions;
using HananokiRuntime;
using UnityEditor;
using UnityEngine;

namespace HananokiEditor {
	[CustomPropertyDrawer( typeof( HexNumberAttribute ) )]
	public class HexANumberttributeDrawer : PropertyDrawer {
		HexNumberAttribute atb { get { return (HexNumberAttribute) attribute; } }


		public override void OnGUI( Rect rc, SerializedProperty property, GUIContent label ) {

			rc = EditorGUI.PrefixLabel( rc, GUIUtility.GetControlID( FocusType.Passive ), label );

			EditorGUI.BeginDisabledGroup( true );
			EditorGUI.TextField( rc, "0x" + property.intValue.ToString( "x8" ) );
			EditorGUI.EndDisabledGroup();
		}

		public static void DrawGUILauout( string label, int value ) {
			DrawGUILauout( label.content(), value );
		}

		public static void DrawGUILauout( GUIContent label, int value ) {
			var rect = GUILayoutUtility.GetRect( label, EditorStyles.label );
			DrawGUI( rect, label, value );
		}

		public static void DrawGUI( Rect rect, GUIContent label, int value ) {
			//EditorGUI.BeginDisabledGroup( true );
			EditorGUI.LabelField( rect, label, $"0x{value:x8}".content() );
			//EditorGUI.EndDisabledGroup();
		}
	}

}

