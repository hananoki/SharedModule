//using Hananoki.Reflection;
using System;
using UnityEditor;

//#if UNITY_2019_1_OR_NEWER
//using UnityEngine.UIElements;
//using UnityEditor.UIElements;
//#else
//using UnityEngine.Experimental.UIElements;
//using UnityEditor.Experimental.UIElements;
//#endif

namespace HananokiEditor.Extensions {
	public static partial class EditorWindowExtensions {

		public static void RepaintArray( this EditorWindow[] ew ) {
			if( ew == null ) return;
			foreach( var p in ew ) p?.Repaint();
		}

		public static object GetRootVisualElement( this EditorWindow ew ) {
			if( UnitySymbol.Has( "UNITY_2019_1_OR_NEWER" ) ) {
				return (object) ew.GetProperty<object>( "rootVisualElement" );
			}
			return (object) ew.GetProperty<object>( "rootVisualContainer" );
		}


		public static void RemoveIMGUIContainer( this EditorWindow ew, object IMGUIContainer, bool parent = false ) {
			var visualTree = ew.GetRootVisualElement();
			if( IMGUIContainer == null ) return;
			if( !parent ) {
				visualTree.MethodInvoke( "Remove", new object[] { IMGUIContainer } );
			}
			else {
				visualTree.GetProperty<object>( "parent" ).MethodInvoke( "Remove", new object[] { IMGUIContainer } );
			}
		}

		public static void AddIMGUIContainer( this EditorWindow ew, object IMGUIContainer, bool parent = false ) {
			var visualTree = ew.GetRootVisualElement();

			if( !parent ) {
				visualTree.MethodInvoke( "Add", new object[] { IMGUIContainer } );
			}
			else {
				var parentObj = visualTree.GetProperty<object>( "parent" );
				parentObj?.MethodInvoke( "Add", new object[] { IMGUIContainer } );
			}
		}

		public static void AddIMGUIContainer( this EditorWindow ew, Action gui, bool parent = false ) {
			var instance = Activator.CreateInstance( UnityTypes.UnityEngine_UIElements_IMGUIContainer, new object[] { gui } );

			AddIMGUIContainer( ew, instance, parent );
		}
	}
}
