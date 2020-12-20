/// UnityEditor.ContainerWindow : 2019.4.5f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorContainerWindow {
		public object m_instance;
    
    public UnityEditorContainerWindow( object instance ){
			m_instance = instance;
    }
    public UnityEditorContainerWindow() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_ContainerWindow, new object[] {} );
    }
    

		public int m_ShowMode {
			get {
				if( __m_ShowMode == null ) {
					__m_ShowMode = UnityTypes.UnityEditor_ContainerWindow.GetField( "m_ShowMode", R.InstanceMembers );
				}
				return (int) __m_ShowMode.GetValue( m_instance );
			}
			set {
				if( __m_ShowMode == null ) {
					__m_ShowMode = UnityTypes.UnityEditor_ContainerWindow.GetField( "m_ShowMode", R.InstanceMembers );
				}
				__m_ShowMode.SetValue( m_instance, value );
			}
		}

		public static object[] windows {
			get {
				if( __getter_windows == null ) {
					__getter_windows = (Func<object[]>) Delegate.CreateDelegate( typeof( Func<object[]> ), null, UnityTypes.UnityEditor_ContainerWindow.GetMethod( "get_windows", R.StaticMembers ) );
				}
				return __getter_windows();
			}
		}

		public UnityEngine.Rect position {
			get {
				if( __getter_position == null ) {
					__getter_position = (Func<UnityEngine.Rect>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect> ), m_instance, UnityTypes.UnityEditor_ContainerWindow.GetMethod( "get_position", R.InstanceMembers ) );
				}
				return __getter_position();
			}
			set {
				if( __setter_position == null ) {
					__setter_position = (Action<UnityEngine.Rect>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Rect> ), m_instance, UnityTypes.UnityEditor_ContainerWindow.GetMethod( "set_position", R.InstanceMembers ) );
			  }
				__setter_position( value );
			}
		}

		public object rootView {
			get {
				if( __getter_rootView == null ) {
					__getter_rootView = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), m_instance, UnityTypes.UnityEditor_ContainerWindow.GetMethod( "get_rootView", R.InstanceMembers ) );
				}
				return __getter_rootView();
			}
			set {
				if( __setter_rootView == null ) {
					__setter_rootView = (Action<object>) Delegate.CreateDelegate( typeof( Action<object> ), m_instance, UnityTypes.UnityEditor_ContainerWindow.GetMethod( "set_rootView", R.InstanceMembers ) );
			  }
				__setter_rootView( value );
			}
		}

		public object rootSplitView {
			get {
				if( __getter_rootSplitView == null ) {
					__getter_rootSplitView = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), m_instance, UnityTypes.UnityEditor_ContainerWindow.GetMethod( "get_rootSplitView", R.InstanceMembers ) );
				}
				return __getter_rootSplitView();
			}
		}

		public string title {
			get {
				if( __getter_title == null ) {
					__getter_title = (Func<string>) Delegate.CreateDelegate( typeof( Func<string> ), m_instance, UnityTypes.UnityEditor_ContainerWindow.GetMethod( "get_title", R.InstanceMembers ) );
				}
				return __getter_title();
			}
			set {
				if( __setter_title == null ) {
					__setter_title = (Action<string>) Delegate.CreateDelegate( typeof( Action<string> ), m_instance, UnityTypes.UnityEditor_ContainerWindow.GetMethod( "set_title", R.InstanceMembers ) );
			  }
				__setter_title( value );
			}
		}

		
		
		FieldInfo __m_ShowMode;
		static Func<object[]> __getter_windows;
		Func<UnityEngine.Rect> __getter_position;
		Action<UnityEngine.Rect> __setter_position;
		Func<object> __getter_rootView;
		Action<object> __setter_rootView;
		Func<object> __getter_rootSplitView;
		Func<string> __getter_title;
		Action<string> __setter_title;
	}
}

