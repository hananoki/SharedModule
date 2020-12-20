using System;
using UnityReflection;

namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {
		public static string[] SplitFullName( this Type t ) {
			return t.FullName.Split( '.' );
		}


		/// <summary>
		/// UnityTypeでのIDみたいなのを取得する
		/// https://docs.unity3d.com/ja/2018.4/Manual/ClassIDReference.html
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
		public static int GetPersistentTypeID( this Type t ) {
			string text = t.ToString().Substring( t.Namespace.ToString().Length + 1 );
			var unityTYpen = UnityEditorUnityType.FindTypeByName( text );
			var unityType = new UnityEditorUnityType( unityTYpen );
			return unityType.persistentTypeID;
		}
	}
}

