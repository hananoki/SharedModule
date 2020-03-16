
using System;
using UnityEngine;

namespace Hananoki {

	[Serializable]
	public class PlayerPrefsInt {
		[SerializeField]
		string name = "";
		int initValue;

		public PlayerPrefsInt( string name, int initValue = 0 ) {
			this.name = name;
			this.initValue = initValue;
		}

		public int Value {
			get {
				return PlayerPrefs.GetInt( name, initValue );
			}
			set {
				PlayerPrefs.SetInt( name, value );
			}
		}

		public bool Has( int flag ) {
			return ( Value & flag ) != 0;
		}
	}


	[Serializable]
	public class PlayerPrefsString {
		[SerializeField]
		string name = "";
		string initValue;

		public PlayerPrefsString( string name, string initValue = "" ) { 
			this.name = name;
			this.initValue = initValue;
		}

		public string Value {
			get {
				return PlayerPrefs.GetString( name, initValue );
			}
			set {
				PlayerPrefs.SetString( name, value );
			}
		}
	}


	[Serializable]
	public class PlayerPrefsFloat {
		string name = "";

		public PlayerPrefsFloat( string name ) { this.name = name; }

		public float Value {
			get {
				return PlayerPrefs.GetFloat( name, 0.0f );
			}
			set {
				PlayerPrefs.SetFloat( name, value );
			}
		}
	}
}
