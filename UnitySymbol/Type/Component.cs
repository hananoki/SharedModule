
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEngine_SpriteRenderer;
		public static Type UnityEngine_SpriteRenderer => Get( ref _UnityEngine_SpriteRenderer, "UnityEngine.SpriteRenderer", "UnityEngine.CoreModule" );

		static Type _UnityEngine_Animator;
		public static Type UnityEngine_Animator => Get( ref _UnityEngine_Animator, "UnityEngine.Animator", "UnityEngine" );

	}
}
