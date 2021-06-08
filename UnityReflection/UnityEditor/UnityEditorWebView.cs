/// UnityEditor.WebView : 2019.4.21f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorWebView {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorWebView( object instance ){
			m_instance = instance;
    }
    public UnityEditorWebView() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_WebView, new object[] {} );
    }
    

		public void LoadURL( string url ) {
			if( __LoadURL_0_1 == null ) {
				__LoadURL_0_1 = (Action<string>) Delegate.CreateDelegate( typeof( Action<string> ), m_instance, UnityTypes.UnityEditor_WebView.GetMethod( "LoadURL", R.InstanceMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			__LoadURL_0_1( url );
		}
		
		public void LoadFile( string path ) {
			if( __LoadFile_0_1 == null ) {
				__LoadFile_0_1 = (Action<string>) Delegate.CreateDelegate( typeof( Action<string> ), m_instance, UnityTypes.UnityEditor_WebView.GetMethod( "LoadFile", R.InstanceMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			__LoadFile_0_1( path );
		}
		
		public void SetFocus( bool value ) {
			if( __SetFocus_0_1 == null ) {
				__SetFocus_0_1 = (Action<bool>) Delegate.CreateDelegate( typeof( Action<bool> ), m_instance, UnityTypes.UnityEditor_WebView.GetMethod( "SetFocus", R.InstanceMembers, null, new Type[]{ typeof( bool ) }, null ) );
			}
			__SetFocus_0_1( value );
		}
		
		public void Show() {
			if( __Show_0_0 == null ) {
				__Show_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_WebView.GetMethod( "Show", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__Show_0_0();
		}
		
		public void Hide() {
			if( __Hide_0_0 == null ) {
				__Hide_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_WebView.GetMethod( "Hide", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__Hide_0_0();
		}
		
		public void SetHostView( object view ) {
			if( __SetHostView_0_1 == null ) {
				__SetHostView_0_1 = UnityTypes.UnityEditor_WebView.GetMethod( "SetHostView", R.InstanceMembers, null, new Type[]{ UnityTypes.UnityEditor_GUIView }, null );
			}
			__SetHostView_0_1.Invoke( m_instance, new object[] {  view  } );
		}
		
		public void Reload() {
			if( __Reload_0_0 == null ) {
				__Reload_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_WebView.GetMethod( "Reload", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__Reload_0_0();
		}
		
		public void ExecuteJavascript( string scriptCode ) {
			if( __ExecuteJavascript_0_1 == null ) {
				__ExecuteJavascript_0_1 = (Action<string>) Delegate.CreateDelegate( typeof( Action<string> ), m_instance, UnityTypes.UnityEditor_WebView.GetMethod( "ExecuteJavascript", R.InstanceMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			__ExecuteJavascript_0_1( scriptCode );
		}
		
		public bool DefineScriptObject( string path, UnityEngine.ScriptableObject obj ) {
			if( __DefineScriptObject_0_2 == null ) {
				__DefineScriptObject_0_2 = (Func<string,UnityEngine.ScriptableObject, bool>) Delegate.CreateDelegate( typeof( Func<string,UnityEngine.ScriptableObject, bool> ), m_instance, UnityTypes.UnityEditor_WebView.GetMethod( "DefineScriptObject", R.InstanceMembers, null, new Type[]{ typeof( string ), typeof( UnityEngine.ScriptableObject ) }, null ) );
			}
			return __DefineScriptObject_0_2( path, obj );
		}
		
		public void Back() {
			if( __Back_0_0 == null ) {
				__Back_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_WebView.GetMethod( "Back", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__Back_0_0();
		}
		
		public void Forward() {
			if( __Forward_0_0 == null ) {
				__Forward_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_WebView.GetMethod( "Forward", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__Forward_0_0();
		}
		
		public void SetSizeAndPosition( int x, int y, int width, int height ) {
			if( __SetSizeAndPosition_0_4 == null ) {
				__SetSizeAndPosition_0_4 = (Action<int,int,int,int>) Delegate.CreateDelegate( typeof( Action<int,int,int,int> ), m_instance, UnityTypes.UnityEditor_WebView.GetMethod( "SetSizeAndPosition", R.InstanceMembers, null, new Type[]{ typeof( int ), typeof( int ), typeof( int ), typeof( int ) }, null ) );
			}
			__SetSizeAndPosition_0_4( x, y, width, height );
		}
		
		public void SetDelegateObject( UnityEngine.ScriptableObject value ) {
			if( __SetDelegateObject_0_1 == null ) {
				__SetDelegateObject_0_1 = (Action<UnityEngine.ScriptableObject>) Delegate.CreateDelegate( typeof( Action<UnityEngine.ScriptableObject> ), m_instance, UnityTypes.UnityEditor_WebView.GetMethod( "SetDelegateObject", R.InstanceMembers, null, new Type[]{ typeof( UnityEngine.ScriptableObject ) }, null ) );
			}
			__SetDelegateObject_0_1( value );
		}
		
		public void InitWebView( object host, int x, int y, int width, int height, bool showResizeHandle ) {
			if( __InitWebView_0_6 == null ) {
				__InitWebView_0_6 = UnityTypes.UnityEditor_WebView.GetMethod( "InitWebView", R.InstanceMembers, null, new Type[]{ UnityTypes.UnityEditor_GUIView, typeof( int ), typeof( int ), typeof( int ), typeof( int ), typeof( bool ) }, null );
			}
			__InitWebView_0_6.Invoke( m_instance, new object[] {  host, x, y, width, height, showResizeHandle  } );
		}
		
		
		
		Action<string> __LoadURL_0_1;
		Action<string> __LoadFile_0_1;
		Action<bool> __SetFocus_0_1;
		Action __Show_0_0;
		Action __Hide_0_0;
		MethodInfo __SetHostView_0_1;
		Action __Reload_0_0;
		Action<string> __ExecuteJavascript_0_1;
		Func<string,UnityEngine.ScriptableObject, bool> __DefineScriptObject_0_2;
		Action __Back_0_0;
		Action __Forward_0_0;
		Action<int,int,int,int> __SetSizeAndPosition_0_4;
		Action<UnityEngine.ScriptableObject> __SetDelegateObject_0_1;
		MethodInfo __InitWebView_0_6;
	}
}

