
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

		#region int ot uint (Bit manipulation)

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

		#endregion


		#region int

		public static float ToColor( this int i ) {
			return i / 255.0f;
		}

		#endregion


		#region float

		public static float ToColor( this float i ) {
			return i / 255.0f;
		}

		#endregion


		#region Vector3

		public static void Zero( ref this Vector3 v ) {
			v.x = 0;
			v.y = 0;
			v.z = 0;
		}

		#endregion


		#region Generic

		/// <summary>
		/// ランダムに並び替え
		/// </summary>
		public static List<T> Shuffle<T>( this List<T> list ) {

			for( int i = 0; i < list.Count; i++ ) {
				T temp = list[ i ];
				int randomIndex = UnityRandom.Range( 0, list.Count );
				list[ i ] = list[ randomIndex ];
				list[ randomIndex ] = temp;
			}

			return list;
		}

		public static void Fill( this int[] v, int value ) {
			for( int i = 0; i < v.Length; i++ ) {
				v[ i ] = value;
			}
		}

		public static string[] ToStringArray<T>( this T[] lst ) where T : struct {
			return lst.Select( a => a.ToString() ).ToArray();
		}

		#endregion


		#region string

		public static bool IsEmpty( this string s ) {
			return string.IsNullOrEmpty( s );
		}

		public static string GetExtension( this string s ) {
			return Path.GetExtension( s );
		}

		public static string GetDirectory( this string s ) {
			if( s == "" ) return "";
			return Path.GetDirectoryName( s );
		}

		#endregion


		#region RectOffset

		public static void zero( this RectOffset self ) {
			self = new RectOffset( 0, 0, 0, 0 );
		}

		#endregion


		public static void KillCoroutine( this MonoBehaviour mo, ref Coroutine co ) {
			if( co != null ) {
				mo.StopCoroutine( co );
			}
			co = null;
		}



		public static T AddComponentSafe<T>( this GameObject gobj ) where T : Component {
			var p = gobj.GetComponent<T>();
			if( p != null ) return p;
			return gobj.AddComponent<T>();
		}

		public static void SendMessageForce( this GameObject gobj, string methodName ) {
			var cc = gobj.GetComponents<Component>();
			foreach( var c in cc ) {
				Type thisType = c.GetType();
				MethodInfo theMethod = thisType.GetMethod( methodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic );
				if( theMethod != null ) {
					theMethod.Invoke( c, new object[] { } );
				}
			}
		}


		public static void GetComponentAndAttach<T>( this GameObject gobj, Action<T> attach ) where T : Component {
			var p = gobj.GetComponent<T>();
			if( p == null ) return;
			attach?.Invoke( p );
		}


		/// <summary>
		/// パラメーターを受け取らない Action デリゲートを実行します
		/// </summary>
		public static void Call( this Action action ) {
			if( action == null ) return;
			action();
		}


		public static void Call<T>( this Action<T> action, T param ) {
			if( action == null ) return;
			action( param );
		}

		public static void Call<T1, T2>( this Action<T1, T2> action, T1 param01, T2 param02 ) {
			if( action == null ) return;
			action( param01, param02 );
		}



		public static void SetEnabled<T>( this T p, bool value ) where T : Behaviour {
			if( p == null ) return;
			p.enabled = value;
		}

		public static void SetActive<T>( this T p, bool value ) where T : Component {
			if( p == null ) return;
			p.gameObject.SetActive( value );
		}
		public static void SetActiveOn<T>( this T p ) where T : Component {
			p.SetActive( true );
		}
		public static void SetActiveOff<T>( this T p ) where T : Component {
			p.SetActive( false );
		}
		public static bool GetActive<T>( this T p ) where T : Component {
			if( p == null ) return false;
			return p.gameObject.activeSelf;
		}
		public static void ActiveToggle<T>( this T p ) where T : Component {
			if( p == null ) return;
			p.gameObject.SetActive( !p.GetActive() );
		}

		public static void SetActiveArray<T>( this T[] pp, bool value ) where T : Component {
			if( pp == null ) return;
			foreach( var p in pp ) {
				if( p == null ) continue;
				p.gameObject.SetActive( value );
			}
		}


		public static void EnableCompomentArray<T>( this T[] pp ) where T : Behaviour {
			if( pp == null ) return;
			foreach( var p in pp ) {
				if( p == null ) continue;
				p.enabled = true;
			}
		}
		public static void DisableCompomentArray<T>( this T[] pp ) where T : Behaviour {
			if( pp == null ) return;
			foreach( var p in pp ) {
				if( p == null ) continue;
				p.enabled = false;
			}
		}

		#region Transform

		public static Vector3 GetLocalPos<T>( this T i ) where T : Component {
			return i.transform.localPosition;
		}

		public static void SetLocalPos( this Transform i, Vector3 pos ) {
			i.localPosition = pos;
		}
		public static void SetLocalPos<T>( this T i, Vector3 pos ) where T : Component {
			i.transform.localPosition = pos;
		}
		public static void SetLocalPosX<T>( this T i, float x ) where T : Component {
			i.transform.localPosition = new Vector3( x, i.transform.localPosition.y, i.transform.localPosition.z );
		}
		public static void SetLocalPosY<T>( this T i, float y ) where T : Component {
			i.transform.localPosition = new Vector3( i.transform.localPosition.x, y, i.transform.localPosition.z );
		}
		public static void SetLocalPosZ<T>( this T i, float z ) where T : Component {
			i.transform.localPosition = new Vector3( i.transform.localPosition.x, i.transform.localPosition.y, z );
		}

		public static void SetLocalRot( this Transform i, Quaternion rot ) {
			i.localRotation = rot;
		}
		public static void SetLocalRot<T>( this T i, Quaternion rot ) where T : Component {
			i.transform.localRotation = rot;
		}
		public static void SetLocalEuler<T>( this T i, Vector3 euler ) where T : Component {
			i.transform.localEulerAngles = euler;
		}

		public static void SetLocalSclX<T>( this T p, float x ) where T : Component {
			p.transform.localScale = new Vector3( x, p.transform.localScale.y, p.transform.localScale.z );
		}
		public static void SetLocalSclY<T>( this T p, float y ) where T : Component {
			p.transform.localScale = new Vector3( p.transform.localScale.x, y, p.transform.localScale.z );
		}
		public static void SetLocalSclZ<T>( this T p, float z ) where T : Component {
			p.transform.localScale = new Vector3( p.transform.localScale.x, p.transform.localScale.y, z );
		}
		public static void SetLocalScl<T>( this T p, float xyz ) where T : Component {
			p.transform.localScale = new Vector3( xyz, xyz, xyz );
		}
		public static void SetLocalScl<T>( this T p, Vector3 xyz ) where T : Component {
			p.transform.localScale = xyz;
		}

		public static float GetPosY<T>( this T i ) where T : Component {
			return i.transform.position.y;
		}
		public static void SetPosY<T>( this T i, float y ) where T : Component {
			i.transform.position = new Vector3( i.transform.position.x, y, i.transform.position.z );
		}


		public static void SetPos<T>( this T i, ref Vector3 pos ) where T : Component {
			i.transform.position = pos;
		}
		#endregion


		#region SpriteRenderer

		public static float GetAlpha( this SpriteRenderer p ) {
			return p.color.a;
		}

		public static void SetAlpha( this SpriteRenderer p, float alpha ) {
			p.color = new Color( p.color.r, p.color.g, p.color.b, alpha );
		}
		public static void SetAlphaArray( this SpriteRenderer[] pp, float value ) {
			if( pp == null ) return;
			foreach( var p in pp ) {
				if( p == null ) continue;
				p.SetAlpha( value );
			}
		}

		public static void SetSpriteArray( this SpriteRenderer[] pp, Sprite spr ) {
			if( pp == null ) return;
			foreach( var p in pp ) {
				if( p == null ) continue;
				p.sprite = spr;
			}
		}

		#endregion


		#region RawImage

		public static float GetAlpha( this RawImage p ) {
			return p.color.a;
		}

		public static void SetAlpha( this RawImage p, float alpha ) {
			p.color = new Color( p.color.r, p.color.g, p.color.b, alpha );
		}
		public static void SetColor( this RawImage p, Color color ) {
			p.color = new Color( color.r, color.g, color.b, p.color.a );
		}

		public static void SetAlphaArray( this RawImage[] pp, float value ) {
			if( pp == null ) return;
			foreach( var p in pp ) {
				if( p == null ) continue;
				p.SetAlpha( value );
			}
		}
		#endregion



		#region Image

		public static void Default( this Image p ) {
			p.SetActive( false );
			p.SetAlpha( 0.0f );
		}

		public static float GetAlpha( this Image p ) {
			return p.color.a;
		}

		public static void SetAlpha( this Image p, float alpha ) {
			p.color = new Color( p.color.r, p.color.g, p.color.b, alpha );
		}
		public static void SetColor( this Image p, Color color ) {
			p.color = new Color( color.r, color.g, color.b, p.color.a );
		}

		public static void SetAlphaArray( this Image[] pp, float value ) {
			if( pp == null ) return;
			foreach( var p in pp ) {
				if( p == null ) continue;
				p.SetAlpha( value );
			}
		}
		#endregion






		#region ParticleSystem

		public static void Play( this ParticleSystem[] ps ) {
			foreach( var p in ps ) p.Play();
		}

		public static void Stop( this ParticleSystem[] ps ) {
			foreach( var p in ps ) p.Stop();
		}

		public static bool IsAlive( this ParticleSystem[] ps ) {
			foreach( var p in ps ) {
				if( p.IsAlive() ) return true;
			}
			return false;
		}

		#endregion



		#region CanvasGroup

		public static void Default( this CanvasGroup p ) {
			p.SetActive( false );
			p.SetAlpha( 0.0f );
		}
		public static void Default( this CanvasGroup[] pp ) {
			if( pp == null ) return;
			foreach( var p in pp ) {
				if( p == null ) continue;
				p.Default();
			}
		}

		public static void SetAlpha( this CanvasGroup p, float alpha ) {
			if( p == null ) return;
			p.alpha = alpha;
		}

		public static void SetAlphaArray( this CanvasGroup[] pp, float value ) {
			if( pp == null ) return;
			foreach( var p in pp ) {
				if( p == null ) continue;
				p.SetAlpha( value );
			}
		}

		#endregion


	}
}
