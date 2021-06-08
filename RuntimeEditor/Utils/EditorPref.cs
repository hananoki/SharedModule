
using System;
using UnityEditor;
using UnityEngine;

namespace HananokiEditor {

	[Serializable]
	public class EditorPrefsFloat {
		[SerializeField]
		string name = "";

		float initValue;

		public EditorPrefsFloat( string name, float initValue = 0 ) {
			this.name = name;
			this.initValue = initValue;
		}

		public float Value {
			get {
				return EditorPrefs.GetFloat( name, initValue );
			}
			set {
				EditorPrefs.SetFloat( name, value );
			}
		}
	}


	[Serializable]
	public class EditorPrefsInt {
		[SerializeField]
		string name = "";

		int initValue;

		public EditorPrefsInt( string name, int initValue = 0 ) {
			this.name = name;
			this.initValue = initValue;
		}

		public int Value {
			get {
				return EditorPrefs.GetInt( name, initValue );
			}
			set {
				EditorPrefs.SetInt( name, value );
			}
		}

		public bool Has( int flag ) {
			return ( Value & flag ) != 0;
		}

		public void Toggle( int chk, bool b ) {
			if( b ) EditorPrefs.SetInt( name, Value | chk );
			else EditorPrefs.SetInt( name, Value & ~chk );
		}
	}


	[Serializable]
	public class EditorPrefsString {
		[SerializeField]
		string name = "";

		public EditorPrefsString( string name ) { this.name = name; }

		public string Value {
			get {
				return EditorPrefs.GetString( name, "" );
			}
			set {
				EditorPrefs.SetString( name, value );
			}
		}
	}


	[Serializable]
	public class EditorPrefsBool {
		string name = "";

		public EditorPrefsBool( string name ) { this.name = name; }

		public bool Value {
			get {
				return EditorPrefs.GetBool( name, false );
			}
			set {
				EditorPrefs.SetBool( name, value );
			}
		}

		public void Invert() {
			Value = !Value;
		}

		public static implicit operator bool( EditorPrefsBool c ) { return c.Value; }
	}

}
