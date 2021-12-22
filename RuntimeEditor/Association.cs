using HananokiEditor.Extensions;
using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.Callbacks;
using E = HananokiEditor.SharedModule.SettingsEditor;


namespace HananokiEditor.SharedModule {

	/////////////////////////////////////////
	public class Association {

		static Hashtable s_methods;
		static Hashtable s_methodsOr;

		public static void MakeMethods( bool force = false ) {
			if( !force ) {
				if( s_methods != null ) return;
			}

			s_methods = new Hashtable();
			s_methodsOr = new Hashtable();

			var methods = AssemblieUtils.GetAllMethodsWithAttribute<Hananoki_OnOpenAsset>().ToArray();

			foreach( var p in methods ) {
				var hash = p.GetHash_OnOpenAsset();
				if( E.i.m_enableOnOpen.IndexOf( hash ) < 0 ) continue;

				var atb = p.GetCustomAttributes( typeof( Hananoki_OnOpenAsset ), false ).OfType<Hananoki_OnOpenAsset>().ToList();

				if( atb[ 0 ].type != null ) {
					var m = s_methods[ atb[ 0 ].type ];
					if( m == null ) {
						s_methods.Add( atb[ 0 ].type, p );
					}
				}
				if( atb[ 0 ].subClass != null ) {
					var m2 = s_methodsOr[ atb[ 0 ].subClass ];
					if( m2 == null ) {
						s_methodsOr.Add( atb[ 0 ].subClass, p );
					}
				}
			}
		}


		/////////////////////////////////////////
		[OnOpenAsset( 1 )]
		public static bool OnOpen( int instanceID, int line ) {
			MakeMethods();

			var asset = EditorUtility.InstanceIDToObject( instanceID );

			MethodInfo m = null;
			var type = asset.GetType();
			m = (MethodInfo) s_methods[ type ];

			if( m == null ) {
				foreach( var p in s_methodsOr.Keys ) {
					if( type.IncludesSpecifiedClass( (Type) p ) ) {
						m = (MethodInfo) s_methodsOr[ p ];
					}
				}
			}


			if( m == null ) return false;

			m.Invoke( null, new object[] { asset, line } );
			//AsmdefEditorWindow.OpenAsName( asset );

			return true;
		}
	}


	public static class Extentions {
		public static int GetHash_OnOpenAsset( this MethodInfo method ) {
			var cus = method.GetCustomAttributes( typeof( Hananoki_OnOpenAsset ), false ).OfType<Hananoki_OnOpenAsset>().ToList();
			return $"{method.Name},{cus[ 0 ].GetName()}{method.Module.Name}".GetHashCode();
		}
	}
}
