using System;
using System.Collections.Generic;

namespace HananokiRuntime {
	public static class EnumUtils {

		public static T[] GetArray<T>() where T : struct {
			Type type = typeof( T );
			T[] values = (T[]) Enum.GetValues( type );
			return values;
		}
		public static Array GetArray( Type type ) {
			return Enum.GetValues( type );
		}

		public static int[] GetValuesArray( Type t ) {
			return (int[]) Enum.GetValues( t );
		}

		public static List<int> GetValuesList( Type t ) {
			return new List<int>( GetValuesArray( t ) );
		}

		public static string[] GetNamesArray( Type t ) {
			return Enum.GetNames( t );
		}

		public static List<string> GetNamesList( Type t ) {
			return new List<string>( GetNamesArray( t ) );
		}


		public static void Remove<T>( ref T[] array, T item ) {
			List<T> list = new List<T>( array );
			list.Remove( item );
			array = list.ToArray();
		}

		public static int Length<T>() where T : struct {
			return Enum.GetNames( typeof( T ) ).Length;
		}

		public static void Shuffle<T>( ref T[] array ) where T : struct {
			//Fisher-Yatesアルゴリズムでシャッフルする
			Random rng = new Random();
			int n = array.Length;
			while( n > 1 ) {
				n--;
				int k = rng.Next( n + 1 );
				T tmp = array[ k ];
				array[ k ] = array[ n ];
				array[ n ] = tmp;
			}
		}
	}
}
