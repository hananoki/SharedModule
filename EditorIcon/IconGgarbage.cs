using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace HananokiEditor {

	[Serializable]
	internal class IconGarbage : ScriptableSingleton<IconGarbage>, ISerializationCallbackReceiver {

		public List<Texture2D> m_textures;
		public bool m_gabageOn;

		void ISerializationCallbackReceiver.OnBeforeSerialize() {

		}

		void ISerializationCallbackReceiver.OnAfterDeserialize() {
			m_gabageOn = true;
			// DidReloadScriptsはOnEnable後に呼ばれる
			// ここでDestroyImmediateはUnityException
		}

		//[DidReloadScripts]
		static void OnDidReloadScripts() {
			for( int i = 0; i < instance.m_textures.Count; i++ ) {
				DestroyImmediate( instance.m_textures[ i ] );
				instance.m_textures[ i ] = null;
			}
			instance.m_textures.Clear();
			instance.m_gabageOn = false;
		}


		public static void Set( Texture2D texture ) {
			if( instance.m_textures == null ) {
				instance.m_textures = new List<Texture2D>();
			}

			if( instance.m_gabageOn ) OnDidReloadScripts();
			
			instance.m_textures.Add( texture );
		}
	}
}
