using HananokiEditor.Extensions;
using HananokiRuntime;
using System;
using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityReflection;
using UnityObject = UnityEngine.Object;


namespace HananokiEditor {

	public static class ExternalPackages {

		static Hashtable m_enables;
		static bool check( string guid ) {
			if( m_enables == null ) m_enables = new Hashtable();

			var item = m_enables[ guid ];
			if( item == null ) {
				m_enables[ guid ] = guid.ToAssetPath().IsExistsFile();
				item = m_enables[ guid ];
			}
			return (bool) item;
		}


		#region AsmdefGraph 

		public class AsmdefGraph {

			public static bool enabled => check( "2510bf44735f1aa419689bbb7ebf6400" );

			public static void OpenAsName( UnityObject unityObject ) {
				var t = EditorHelper.GetTypeFromString( "HananokiEditor.AsmdefEditorWindow" );
				t.MethodInvoke( "OpenAsName", new Type[] { typeof( UnityObject ) }, new object[] { unityObject } );
			}

			public static void OpenAsName( string assetPath ) {
				var t = EditorHelper.GetTypeFromString( "HananokiEditor.AsmdefEditorWindow" );
				t.MethodInvoke( "OpenAsName", new Type[] { typeof( string ) }, new object[] { assetPath } );
			}
		}

		#endregion


		#region CustomProjectBrowser 

		public class CustomProjectBrowser {
			public static bool enabled => check( "68cd53ef6b462bc48a6292d6e84fdfa4" );

			static Action<string, long, Rect> __DrawProjectItemCallback;

			public static void DrawProjectItemCallback( string guid, long localID, Rect selectionRect ) {
				if( !enabled ) return;

				if( __DrawProjectItemCallback == null ) {
					var t = EditorHelper.GetTypeFromString( $"HananokiEditor.CustomProjectBrowser.CustomProjectBrowser" );
					__DrawProjectItemCallback = (Action<string, long, Rect>) Delegate.CreateDelegate( typeof( Action<string, long, Rect> ), null, t.GetMethod( "DrawProjectItemCallback", R.StaticMembers ) );
				}
				__DrawProjectItemCallback( guid, localID, selectionRect );
			}
		}

		#endregion


		#region ScriptableObjectManager 

		public class ScriptableObjectManager {
			public const string nameSpace = "HananokiEditor.ScriptableObjectManager";
			public static bool enabled => check( "885435c0eb7180a4aad886bc82f9aea3" );

			public static void ShowCreateMenu() {
				if( !enabled ) return;
				var t = EditorHelper.GetTypeFromString( $"{nameSpace}.Utils" );
				t.MethodInvoke( "ShowMenu", null );
			}

			public static Type[] GetRegistTypes() {
				if( !enabled ) return null;
				var t = EditorHelper.GetTypeFromString( $"{nameSpace}.Utils" );
				var types = t.MethodInvoke<Type[]>( "GetRegistTypes", null );

				return types;
			}

			public static void SetShow( bool flag ) {
				if( !enabled ) return;
				var t = EditorHelper.GetTypeFromString( $"{nameSpace}.Utils" );
				t.MethodInvoke( "SetShow", new object[] { flag } );
			}

		}

		#endregion


		#region FavoriteAssets

		public class FavoriteAssets {
			public const string nameSpace = "HananokiEditor.FavoriteAssets";
			public static bool enabled => check( "d5e70998d915c354a9c0d7b6ce57a2c1" );

			public static void SetShow( bool flag ) {
				if( !enabled ) return;
				var t = EditorHelper.GetTypeFromString( $"{nameSpace}.Utils" );
				t.MethodInvoke( "SetShow", new object[] { flag } );
			}

		}

		#endregion


		#region ToolbarExtension 

		public class ToolbarExtension {

			public static bool enabled => check( "a4b88bda276254649b633a17904a96db" );

			public static void AddGUI( Action action ) {
				var t = EditorHelper.GetTypeFromString( "ToolbarExtension.Core" );
				if( t == null ) {
					Debug.Log( "nullt " );
					return;
				}
				t.MethodInvoke( "AddGUI", new object[] { action } );
			}
		}

		#endregion


		public static bool ManifestJsonUtility => check( "91a50302e95aae445aa204c762274bfb" );


		public delegate void myDelegate( string a, string b, ref Rect c );

		public static myDelegate PBcall;

		//public static Action<string,string,ref Rect> PBcall;
		public static void AddPB( myDelegate a ) {
			PBcall += a;
		}
	}



	public abstract class HierarchyComponentTool {
		public Type type;
		public GameObject go;
		public UnityObject obj;
		public abstract void OnGUI( ref Rect rect );

		public virtual UnityObject GetReferenceObject() => null;

		protected void _ColorField( ref Rect rect, UnityObject obj, Color color, Action<Color> changed ) {
			rect.width = 32;
			ScopeChange.Begin();
			var _color = UnityEditorEditorGUI.DoColorField( rect, obj.GetInstanceID(), color, true, true, false );
			if( ScopeChange.End() ) {
				EditorHelper.Dirty( obj, () => {
					changed( _color );
				} );
			}
			rect.x += rect.width + 4;
		}

		protected void _AlphaSlider( ref Rect rect, UnityObject obj, float alpha, Action<float> changed ) {
			rect.width = 40;

			ScopeChange.Begin();
			var _a = HEditorGUI.Slider( rect, alpha, 0, 1 );
			if( ScopeChange.End() ) {
				EditorHelper.Dirty( obj, () => {
					changed( _a );
				} );
			}
			rect.x += rect.width + 4;
		}

		protected void _AlphaSlider( ref Rect rect, UnityObject obj, Color color, Action<Color> changed ) {
			rect.width = 40;

			ScopeChange.Begin();
			var _a = HEditorGUI.Slider( rect, color.a, 0, 1 );
			if( ScopeChange.End() ) {
				EditorHelper.Dirty( obj, () => {
					changed( ColorUtils.RGBA( color, _a ) );
				} );
			}
			rect.x += rect.width + 4;
		}

		public static GUIStyle objectField;

		protected void _ObjectField<T>( ref Rect rect, T obj, Action<T> changed ) where T : UnityObject {
			if( objectField == null ) {
				objectField = new GUIStyle( EditorStyles.objectField );
				objectField.padding.top = 1;
				objectField.padding.left = 2;
			}
			rect.width = 33;
			ScopeChange.Begin();
			var id = go.GetInstanceID();
			var t = obj != null ? obj.GetType() : typeof( T );
			var _obj = UnityEditorEditorGUI.DoObjectField( rect, rect, id, obj, t, null, null, false, objectField );
			if( ScopeChange.End() ) {
				EditorHelper.Dirty( go, () => {
					changed( (T) _obj );
				} );
			}
			rect.x += rect.width + 4;
		}

		protected void _Graphic( ref Rect rect, Graphic obj ) {
			_ColorField( ref rect, obj, obj.color, ( color ) => {
				obj.color = color;
			} );
			_AlphaSlider( ref rect, obj, obj.color, ( color ) => {
				obj.color = color;
			} );

			rect.width = 16;
			ScopeChange.Begin();
			var _b = EditorGUI.Toggle( rect, obj.raycastTarget );
			if( ScopeChange.End() ) {
				EditorHelper.Dirty( obj, () => {
					obj.raycastTarget = _b;
				} );
			}
		}
	}
}
