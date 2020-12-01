
#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace Hananoki {

	[System.Serializable]
	public class SessionStateBool {
		public string __name;
		public string __label;
		[SerializeField]
		bool initValue;
		public SessionStateBool( string name, string label = "", bool initValue = false ) {
			this.__name = name;
			if( string.IsNullOrEmpty( label ) ) {
				//this.__label = ObjectNames.NicifyVariableName( name );
				this.__label = name;
			}
			else {
				this.__label = label;
			}
			this.initValue = initValue;
		}
		public bool Value {
			get {
				return SessionState.GetBool( __name, initValue );
			}
			set {
				SessionState.SetBool( __name, value );
			}
		}

		public void Invert() {
			Value = !Value;
		}

		public static implicit operator bool( SessionStateBool c ) { return c.Value; }
	}


	[System.Serializable]
	public class SessionStateInt {
		public string __name;
		public string __label;
		public SessionStateInt( string name, string label ) {
			this.__name = name;
			this.__label = label;
		}
		public int Value {
			get {
				return SessionState.GetInt( __name, 0 );
			}
			set {
				SessionState.SetInt( __name, value );
			}
		}

		public static implicit operator int( SessionStateInt c ) { return c.Value; }
	}


	[System.Serializable]
	public class SessionStateFloat {
		public string __name;
		public string __label;
		public SessionStateFloat( string name, string label ) {
			this.__name = name;
			this.__label = label;
		}
		public float Value {
			get {
				return SessionState.GetFloat( __name, 0 );
			}
			set {
				SessionState.SetFloat( __name, value );
			}
		}

		public static implicit operator float( SessionStateFloat c ) { return c.Value; }
	}


	[CustomPropertyDrawer( typeof( SessionStateBool ) )]
	public class SessionStateBoolDrawer : PropertyDrawer {

		public static bool OnGUILayout( SessionStateBool ss ) {
			var rect = GUILayoutUtility.GetRect( EditorHelper.TempContent( ss.__name ), EditorStyles.objectField );

			EditorGUI.DrawRect( rect, new Color( 0f, 1f, 0f, 0.25f ) );

			return EditorGUI.ToggleLeft( rect, ss.__label, ss.Value );
		}



		public override void OnGUI( Rect rc, SerializedProperty property, GUIContent label ) {

			var nameProp = property.FindPropertyRelative( "__name" );
			var labelProp = property.FindPropertyRelative( "__label" );

			EditorGUI.DrawRect( rc, new Color( 0f, 1f, 0f, 0.25f ) );
			GUI.changed = false;

			bool value = EditorGUI.Toggle( rc, ObjectNames.NicifyVariableName( labelProp.stringValue ), SessionState.GetBool( nameProp.stringValue, false ) );

			if( GUI.changed ) {
				SessionState.SetBool( nameProp.stringValue, value );
			}
		}
	}


	[CustomPropertyDrawer( typeof( SessionStateInt ) )]
	public class SessionStateIntDrawer : PropertyDrawer {

		public static int OnGUILayout( SessionStateInt ss ) {
			var rect = GUILayoutUtility.GetRect( EditorHelper.TempContent( ss.__name ), EditorStyles.objectField );

			EditorGUI.DrawRect( rect, new Color( 0f, 1f, 0f, 0.25f ) );

			return EditorGUI.IntField( rect, ss.__label, ss.Value );
		}


		public override void OnGUI( Rect rc, SerializedProperty property, GUIContent label ) {

			var nameProp = property.FindPropertyRelative( "__name" );
			var labelProp = property.FindPropertyRelative( "__label" );

			EditorGUI.DrawRect( rc, new Color( 0f, 1f, 0f, 0.25f ) );
			GUI.changed = false;

			int value = EditorGUI.IntField( rc, labelProp.stringValue, SessionState.GetInt( nameProp.stringValue, 0 ) );

			if( GUI.changed ) {
				SessionState.SetInt( nameProp.stringValue, value );
			}
		}
	}



	[CustomPropertyDrawer( typeof( SessionStateFloat ) )]
	class SessionStateFloatDrawer : PropertyDrawer {

		public override void OnGUI( Rect rc, SerializedProperty property, GUIContent label ) {

			var nameProp = property.FindPropertyRelative( "__name" );
			var labelProp = property.FindPropertyRelative( "__label" );

			EditorGUI.DrawRect( rc, new Color( 0f, 1f, 0f, 0.25f ) );
			GUI.changed = false;

			var value = EditorGUI.FloatField( rc, labelProp.stringValue, SessionState.GetFloat( nameProp.stringValue, 0 ) );

			if( GUI.changed ) {
				SessionState.SetFloat( nameProp.stringValue, value );
			}
		}
	}
}

#endif
