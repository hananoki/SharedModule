using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

namespace HananokiEditor {
	public class EditorPrefJson<T> where T : new() {
		[Serializable]
		public class Serialization {
			[SerializeField]
			public T target;
			public T To() { return target; }

			public Serialization( T target ) {
				this.target = target;
			}
		}

		public static T Get( string name ) {
			var lst = JsonUtility.FromJson<Serialization>( EditorPrefs.GetString( name, "" ) );
			if( lst == null ) {
				return new T();
			}
			return lst.To();
		}

		public static void Set( string name, T data ) {
			string json = JsonUtility.ToJson( new Serialization( data ) );
#if LOCAL_DEBUG
			Debug.Log( json );
#endif
			EditorPrefs.SetString( name, json );
		}
	}
}

