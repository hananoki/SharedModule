
#pragma warning disable 0618

using System;
using System.Collections.Generic;
using UnityEngine;

using UnityObject = UnityEngine.Object;

namespace HananokiRuntime.Extensions {
	public static partial class Extensions {
#if CSHARP_7_3_OR_NEWER

#if UNITY_2019_2_OR_NEWER
		public static (short, short) GetWord( this int i ) {
			return ((short) ( ( i >> 16 ) & 0x0000FFFF ), (short) ( i & 0x0000FFFF ));
		}
#endif
		public static void SetWord( ref this int i, int high, int low ) {
			i = (int) ( ( high << 16 ) & 0xFFFF0000 ) | ( low & 0x0000FFFF );
		}

		public static int MakeWord( this int i, int high, int low ) {
			return (int) ( ( high << 16 ) & 0xFFFF0000 ) | ( low & 0x0000FFFF );
		}

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

		public static void Toggle( ref this int i, int flag, bool b ) {
			if( b ) i |= flag;
			else i &= ~flag;
		}

		public static void Invert( ref this int i, int flag ) {
			Toggle( ref i, flag, !i.Has( flag ) );
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

		public static bool IsEmpty<T>( this List<T> s ) {
			if( s == null ) return true;
			if( s.Count == 0 ) return true;
			return false;
		}

		public static bool IsEmpty( this string s ) {
			return string.IsNullOrEmpty( s );
		}

		public static UnityEngine.SceneManagement.Scene GetSceneByName( this string s ) {
			return UnityEngine.SceneManagement.SceneManager.GetSceneByName( s );
		}


		public static string ToStringSafe( this string s ) {
			if( s.IsEmpty() ) return "";
			return s.ToString();
		}

#if CSHARP_7_3_OR_NEWER
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

#if UNITY_2019_2_OR_NEWER
#else
		public static bool TryGetComponent<T>( this GameObject go, out T component ) {
			component = go.GetComponent<T>();
			if( component != null ) return true;
			return false;
		}
#endif

		public static T TryAddComponent<T>( this GameObject go ) where T : UnityObject {
			return (T) TryAddComponent( go, typeof( T ) );
		}

		public static UnityObject TryAddComponent( this GameObject go, Type componentType ) {
			var comp = go.GetComponent( componentType );
			if( comp != null ) return comp;
			comp = go.AddComponent( componentType );
			return comp;
		}


		public static void RemoveComponent( this GameObject go, Type componentType ) {
			var comp = go.GetComponent( componentType );
			if( comp == null ) return;
			if( Application.isPlaying ) {
				UnityObject.Destroy( comp );
			}
			else {
				UnityObject.DestroyImmediate( comp, true );
			}
		}


		public static void AddRangeSafe<T>( this List<T> lst, IEnumerable<T> collection ) {
			if( collection == null ) return;
			lst.AddRange( collection );
		}

		public static T First<T>( this List<T> lst ) {
			return lst[ 0 ];
		}

		public static T Last<T>( this List<T> lst ) {
			return lst[ lst.Count - 1 ];
		}

		public static T First<T>( this T[] lst ) {
			return lst[ 0 ];
		}

		public static T Last<T>( this T[] lst ) {
			return lst[ lst.Length - 1 ];
		}

		public static T Choice<T>( this T[] lst ) {
			return lst[ UnityEngine.Random.Range( 0, lst.Length ) ];
		}


		public static void FindRemove<T>( this List<T> lst, Predicate<T> match ) {
		loop:
			var index = lst.FindIndex( match );
			if( index < 0 ) return;
			lst.RemoveAt( index );
			goto loop;
		}


		public static Vector3 PositionToBottomSphre( this CharacterController cc ) {
			var ofs = cc.center;
			var pos = cc.transform.TransformPoint( ofs );

			pos.y -= ( ( cc.height * 0.5f ) - cc.radius );
			return pos;
		}
	}
}
