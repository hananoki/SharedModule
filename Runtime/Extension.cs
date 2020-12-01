
#pragma warning disable 0618

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

using UnityRandom = UnityEngine.Random;

namespace Hananoki.Extensions {
	public static partial class Extensions {
#if UNITY_2018_3_OR_NEWER

		public static bool Invert( ref this bool b ) {
			b = !b;
			return b;
		}

		public static bool Has( this uint i, uint chk ) {
			return 0 != ( i & chk ) ? true : false;
		}
		public static bool Has( this int i, int chk ) {
			return 0 != ( i & chk ) ? true : false;
		}

		public static void Enable( ref this int i, int chk ) {
			i |= chk;
		}

		public static void Disable( ref this int i, int chk ) {
			i &= ~chk;
		}

		public static void Enable( ref this uint i, uint chk ) {
			i |= chk;
		}

		public static void Disable( ref this uint i, uint chk ) {
			i &= ~chk;
		}

		public static void Toggle( ref this int i, int chk, bool b ) {
			if( b ) i |= chk;
			else i &= ~chk;
		}

		public static int NumderOfBits( this int i ) {
			int n = 0;
			while( 0 < i ) {
				if( 0 != ( i & 0x01 ) ) {
					n++;
				}
				i >>= 1;
			}
			return n;
		}

		//public static float ToColor( this int i ) {
		//	return i / 255.0f;
		//}

		public static void Clamp( ref this int i, int min, int max ) {
			i = Mathf.Clamp( i, min, max );
		}





		//public static float ToColor( this float i ) {
		//	return i / 255.0f;
		//}


		//public static void Zero( ref this Vector3 v ) {
		//	v.x = 0;
		//	v.y = 0;
		//	v.z = 0;
		//}
#endif
		public static bool IsEmpty<T>( this T[] s ) {
			if( s == null ) return true;
			if( s.Length == 0 ) return true;
			return false;
		}

		public static bool IsEmpty( this string s ) {
			return string.IsNullOrEmpty( s );
		}


#if UNITY_2018_3_OR_NEWER
		public static void Alpha( ref this Color col, float a ) {
			col.a = a;
		}
#endif

		public static Component GetComponentFromType( this GameObject go, Type type ) {
			if( go == null ) return null;
			if( type == null ) return null;
			return go.GetComponent( type );
		}
		public static Component InvokeComponentFromType( this GameObject go, Type type, Action<Component> action ) {
			if( go == null ) return null;
			if( type == null ) return null;
			var comp = go.GetComponent( type );
			if( comp == null ) return null;
			action?.Invoke( comp );
			return comp;
		}
	}
}
