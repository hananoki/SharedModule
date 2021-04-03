/// UnityEditor.WebGL.HttpServerEditorWrapper : 2020.2.7f1

using HananokiEditor;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorWebGLHttpServerEditorWrapper {

		public static class Cache<T> {
			public static T cache;
		}

		public static void CreateIfNeeded( string path, ref int port ) {
			if( __CreateIfNeeded_0_2 == null ) {
				__CreateIfNeeded_0_2 = (Method_CreateIfNeeded_0_2) Delegate.CreateDelegate( typeof( Method_CreateIfNeeded_0_2 ), null, UnityTypes.UnityEditor_WebGL_HttpServerEditorWrapper.GetMethod( "CreateIfNeeded", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( int ).MakeByRefType() }, null ) );
			}
			__CreateIfNeeded_0_2( path, ref port );
		}
		
		
		
		delegate void Method_CreateIfNeeded_0_2( string path, ref int port );
		static Method_CreateIfNeeded_0_2 __CreateIfNeeded_0_2;
	}
}

