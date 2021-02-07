
#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;
using HananokiEditor.Extensions;

namespace HananokiEditor {

	public class SessionStateString {
		string m_name;

		public SessionStateString( string name ) {
			this.m_name = name;
		}

		public string Value {
			get {
				return SessionState.GetString( m_name, string.Empty );
			}
			set {
				SessionState.SetString( m_name, value );
			}
		}

		public static implicit operator string( SessionStateString c ) { return c.Value; }
	}


	[System.Serializable]
	public class SessionStateBool {
		public string m_name;

		[SerializeField]
		bool initValue;

		public SessionStateBool( string name, bool initValue = false ) {
			this.m_name = name;
			this.initValue = initValue;
		}

		public bool Value {
			get {
				return SessionState.GetBool( m_name, initValue );
			}
			set {
				SessionState.SetBool( m_name, value );
			}
		}

		public void Invert() {
			Value = !Value;
		}

		public static implicit operator bool( SessionStateBool c ) { return c.Value; }
	}



	[System.Serializable]
	public class SessionStateInt {
		public string m_name;
		public int m_initValue;
		public SessionStateInt( string name, int initValue = 0 ) {
			this.m_name = name;
			this.m_initValue = initValue;
		}
		public int Value {
			get {
				return SessionState.GetInt( m_name, m_initValue );
			}
			set {
				SessionState.SetInt( m_name, value );
			}
		}

		public static implicit operator int( SessionStateInt c ) { return c.Value; }
		//public static implicit operator SessionStateInt( int c ) { return c; }
	}


	[System.Serializable]
	public class SessionStateFloat {
		public string m_name;
		public float m_initValue;
		public SessionStateFloat( string name, float initValue = 0.0f ) {
			this.m_name = name;
			this.m_initValue = initValue;
		}
		public float Value {
			get {
				return SessionState.GetFloat( m_name, m_initValue );
			}
			set {
				SessionState.SetFloat( m_name, value );
			}
		}

		public static implicit operator float( SessionStateFloat c ) { return c.Value; }
	}


	[CustomPropertyDrawer( typeof( SessionStateBool ) )]
	public class SessionStateBoolDrawer : PropertyDrawer {

		public static bool OnGUILayout( SessionStateBool ss ) {
			var _name = ss.m_name.nicify();
			var rect = GUILayoutUtility.GetRect( EditorHelper.TempContent( _name ), EditorStyles.objectField );

			EditorGUI.DrawRect( rect, new Color( 0f, 1f, 0f, 0.25f ) );

			return EditorGUI.ToggleLeft( rect, _name, ss.Value );
		}



		public override void OnGUI( Rect rc, SerializedProperty property, GUIContent label ) {

			var nameProp = property.FindPropertyRelative( nameof( SessionStateBool.m_name ) );
			//var labelProp = property.FindPropertyRelative( "__label" );

			EditorGUI.DrawRect( rc, new Color( 0f, 1f, 0f, 0.25f ) );
			GUI.changed = false;

			bool value = EditorGUI.Toggle( rc, nameProp.stringValue.nicify(), SessionState.GetBool( nameProp.stringValue, false ) );

			if( GUI.changed ) {
				SessionState.SetBool( nameProp.stringValue, value );
			}
		}
	}


	[CustomPropertyDrawer( typeof( SessionStateInt ) )]
	public class SessionStateIntDrawer : PropertyDrawer {

		public static int OnGUILayout( SessionStateInt ss ) {
			var rect = GUILayoutUtility.GetRect( EditorHelper.TempContent( ss.m_name ), EditorStyles.objectField );

			EditorGUI.DrawRect( rect, new Color( 0f, 1f, 0f, 0.25f ) );

			return EditorGUI.IntField( rect, ss.m_name, ss.Value );
		}


		public override void OnGUI( Rect rc, SerializedProperty property, GUIContent label ) {

			var nameProp = property.FindPropertyRelative( nameof( SessionStateInt.m_name ) );
			//var labelProp = property.FindPropertyRelative( "__label" );

			EditorGUI.DrawRect( rc, new Color( 0f, 1f, 0f, 0.25f ) );
			GUI.changed = false;

			int value = EditorGUI.IntField( rc, nameProp.stringValue.nicify(), SessionState.GetInt( nameProp.stringValue, 0 ) );

			if( GUI.changed ) {
				SessionState.SetInt( nameProp.stringValue, value );
			}
		}
	}



	[CustomPropertyDrawer( typeof( SessionStateFloat ) )]
	public class SessionStateFloatDrawer : PropertyDrawer {

		public static float OnGUILayout( SessionStateFloat ss ) {
			var rect = GUILayoutUtility.GetRect( EditorHelper.TempContent( ss.m_name ), EditorStyles.objectField );

			EditorGUI.DrawRect( rect, new Color( 0f, 1f, 0f, 0.25f ) );

			return EditorGUI.FloatField( rect, ss.m_name, ss.Value );
		}


		public override void OnGUI( Rect rc, SerializedProperty property, GUIContent label ) {

			var nameProp = property.FindPropertyRelative( nameof( SessionStateFloat.m_name ) );
			//var labelProp = property.FindPropertyRelative( "__label" );

			EditorGUI.DrawRect( rc, new Color( 0f, 1f, 0f, 0.25f ) );
			GUI.changed = false;

			var value = EditorGUI.FloatField( rc, nameProp.stringValue.nicify(), SessionState.GetFloat( nameProp.stringValue, 0 ) );

			if( GUI.changed ) {
				SessionState.SetFloat( nameProp.stringValue, value );
			}
		}
	}
}

#endif
