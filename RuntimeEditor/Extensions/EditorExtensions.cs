#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using System.Text.RegularExpressions;
using HananokiRuntime.Extensions;

using UnityObject = UnityEngine.Object;

namespace HananokiEditor.Extensions {

	public static partial class EditorExtensions {

		public static Type ContextToType( this object context ) {
			Type result = context as Type;

			if( result != null ) return result;

			if( Type.GetTypeHandle( context ).Equals( typeof( string ).TypeHandle ) ) {
				var s = (string) context;
				result = Type.GetType( s );
				if( result == null ) {
					result = EditorHelper.GetTypeFromString( s );
				}
			}

			return result;
		}

		public static string ContextToAssetPath( this object context ) {
			string result;

			if( Type.GetTypeHandle( context ).Equals( typeof( string ).TypeHandle ) ) {
				var s = (string) context;
				if( s.StartWithAssets() ) {
					result = s;
				}
				else {
					result = s.ToAssetPath();
				}
			}
			else {
				result = ( (UnityObject) context ).ToAssetPath();
			}
			return result;
		}

		public static UnityObject ContextToObject( this object context ) {
			UnityObject result;
			if( Type.GetTypeHandle( context ).Equals( typeof( string ).TypeHandle ) ) {
				var s = (string) context;

				result = s.LoadAsset();
			}
			else {
				result = (UnityObject) context;
			}
			return result;
		}








		/// <summary>
		/// シーン上に配置されたGameObjectか判定します
		/// </summary>
		/// <param name="go">ゲームオブジェクト</param>
		/// <returns>true: シーン上に配置されている</returns>
		public static bool IsOnScene( this GameObject go ) {
			return go.ToAssetPath().IsEmpty();
		}

		public static T TryAddComponent<T>( this GameObject go ) where T : UnityObject {
			return (T) TryAddComponent( go, typeof( T ) );
		}

		public static UnityObject TryAddComponent( this GameObject go, Type componentType ) {
			var comp = go.GetComponent( componentType );
			if( comp != null ) return comp;
			comp = go.AddComponent( componentType );
			return comp;
		}


	}
}
