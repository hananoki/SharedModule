
using System;
using UnityEngine;
using UnityEditor;

namespace Hananoki {

	[Serializable]
	public class EditorPrefsInt {
		[SerializeField]
		string name = "";

		public EditorPrefsInt( string name ) { this.name = name; }

		public int Value {
			get {
				return EditorPrefs.GetInt( name, 0 );
			}
			set {
				EditorPrefs.SetInt( name, value );
			}
		}

		public bool Has( int flag ) {
			return ( Value & flag ) != 0;
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

		public void Flip() {
			Value = !Value;
		}

		public static implicit operator bool( EditorPrefsBool c ) { return c.Value; }
	}

}
