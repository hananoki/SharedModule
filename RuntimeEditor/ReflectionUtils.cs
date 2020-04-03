using System;
using System.Reflection;
using System.Collections.Generic;
using UnityEngine;

namespace Hananoki.Reflection {
	public static class R {
		public const BindingFlags StaticMembers = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		public const BindingFlags InstanceMembers = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
		public const BindingFlags AllMembers = StaticMembers | InstanceMembers;


		static Dictionary<string, PropertyInfo> s_properties = new Dictionary<string, PropertyInfo>();


		public static Assembly LoadAssembly( string dllName = "UnityEditor.dll" ) {
			try {
				return Assembly.Load( dllName );
			}
			catch( System.IO.FileNotFoundException ) {
			}
			catch( Exception e ) {
				Debug.LogException( e );
			}
			return null;
		}

		public static Type Type( string typeName, string dllName = "UnityEditor.dll" ) {
			return Assembly.Load( dllName ).GetType( typeName );
		}

		public static EventInfo Event( string methodName, string typeName, string dllName = "UnityEditor.dll" ) {
			var type = Assembly.Load( dllName ).GetType( typeName );
			return type.GetEvent( methodName, AllMembers );
		}

		public static MethodInfo Method( string methodName, string typeName, string dllName = "UnityEditor.dll" ) {
			try {
				//*
				var type = Assembly.Load( dllName ).GetType( typeName );
				/*/
				var type = Assembly.Load( dllName ).GetType( typeName );
				foreach( Assembly assembly in AppDomain.CurrentDomain.GetAssemblies() ) {
					if( assembly.FullName.Contains( dllName ) ) {
						return Method( methodName, assembly.GetType( typeName ) );
					}
				}
				//*/


				return Method( methodName, type );
			}
			catch( System.Exception ee ) {
				//Debug.LogException( ee );
			}
			return null;
		}

		public static MethodInfo Method( string methodName, Type t ) {
			return t.GetMethod( methodName, AllMembers );
		}
		public static T Method<T>( this object obj, string propertyName, params object[] args ) {
			if( obj == null ) throw new ArgumentNullException( "obj" );
			var t = obj.GetType();
			var p = t.GetMethod( propertyName, InstanceMembers );
			return (T) p.Invoke( obj, args );
		}


		public static MethodInfo Method( int parameterLength, string methodName, string typeName, string dllName = "UnityEditor.dll" ) {
			foreach( var p in R.Methods( methodName, typeName, dllName ) ) {
				if( p.GetParameters().Length != parameterLength ) continue;
				return p;
			}
			return null;
		}



		public static MethodInfo[] Methods( string methodName, string typeName, string dllName = "UnityEditor.dll" ) {
			return Methods( methodName, typeName, Assembly.Load( dllName ) );
		}

		public static MethodInfo[] Methods( string methodName, string typeName, Assembly assembly ) {
			if( assembly == null ) throw new Exception( "assembly null" );
			List<MethodInfo> lst = new List<MethodInfo>();
			var type = assembly.GetType( typeName );
			foreach( var mi in type.GetMethods( AllMembers ) ) {
				if( mi.Name == methodName ) {
					lst.Add( mi );
				}
			}
			return lst.ToArray();
		}



		public static MethodInfo[] Methods( Type atbType, string typeName, string dllName = "UnityEditor.dll" ) {
			return Methods( atbType, typeName, Assembly.Load( dllName ) );
		}

		public static MethodInfo[] Methods( Type atbType, string typeName, Assembly assembly ) {
			if( assembly == null ) throw new Exception( "assembly null" );

			try {
				var type = assembly.GetType( typeName );
				List<MethodInfo> lst = new List<MethodInfo>();

				foreach( var method in type.GetMethods( AllMembers ) ) {
					var attributes = method.GetCustomAttributes( atbType, true );
					if( attributes.Length <= 0 ) continue;
					foreach( var attr in attributes ) {
						if( attr.GetType().Name != atbType.Name ) continue;
						lst.Add( method );
					}
				}
				return lst.ToArray();
			}
			catch( Exception ) {
			}
			return new MethodInfo[ 0 ];
		}


		public static PropertyInfo Property( string name, string typeName, string dllName = "UnityEditor.dll" ) {
			var n = $"{typeName}.{name}";
			if( !s_properties.ContainsKey( n ) ) {
				var t = Assembly.Load( dllName ).GetType( typeName );
				var p = t.GetProperty( name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic );
				s_properties.Add( n, p );
			}
			return s_properties[ n ];
		}

		public static T Property<T>( string name, string typeName, string dllName = "UnityEditor.dll" ) {
			return (T) Property( name, typeName, dllName ).GetValue( null, null );
		}

		//public static PropertyInfo FindProperty( this Type type, string propertyName, BindingFlags flags = FULL_BINDING ) {

		//}
		public static T Property<T>( this object obj, string propertyName ) {
			if( obj == null ) throw new ArgumentNullException( "obj" );
			var t = obj.GetType();
			var p = t.GetProperty( propertyName, InstanceMembers );
			return (T) p.GetValue( obj, null );
		}



		public static FieldInfo Field( string name, string typeName, string dllName = "UnityEditor.dll" ) {
			var n = $"{typeName}.{typeName}";
			//if( !s_properties.ContainsKey( n ) ) {
			//	var t = Assembly.Load( dllName ).GetType( typeName );
			//	var p = t.GetProperty( name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic );
			//	s_properties.Add( n, p );
			//}
			//return s_properties[ n ];

			return Field( name, Assembly.Load( dllName ).GetType( typeName ) );
		}

		public static T Field<T>( this object obj, string propertyName ) {
			if( obj == null ) throw new ArgumentNullException( "obj" );
			var t = obj.GetType();
			var p = t.GetField( propertyName, AllMembers );
			return (T) p.GetValue( obj );
		}

		public static FieldInfo Field( string name, Type t ) {
			var p = t.GetField( name, AllMembers );
			return p;
		}

		public static void Field<TObj, TValue>( this TObj obj, string name, TValue value ) {
			obj.GetType().GetField( name, AllMembers ).SetValue( obj, value );
		}


		public static T Get<T>( this FieldInfo fieldInfo, object obj = null ) {
			return (T) fieldInfo.GetValue( obj );
		}
	}
}
