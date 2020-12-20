/// UnityEditor.SplitView : 2019.4.5f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorSplitView {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorSplitView( object instance ){
			m_instance = instance;
    }
    public UnityEditorSplitView() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_SplitView, new object[] {} );
    }
    

		public bool vertical {
			get {
				if( __vertical == null ) {
					__vertical = UnityTypes.UnityEditor_SplitView.GetField( "vertical", R.InstanceMembers );
				}
				return (bool) __vertical.GetValue( m_instance );
			}
			set {
				if( __vertical == null ) {
					__vertical = UnityTypes.UnityEditor_SplitView.GetField( "vertical", R.InstanceMembers );
				}
				__vertical.SetValue( m_instance, value );
			}
		}

		public object[] children {
			get {
				if( __getter_children == null ) {
					__getter_children = (Func<object[]>) Delegate.CreateDelegate( typeof( Func<object[]> ), m_instance, UnityTypes.UnityEditor_SplitView.GetMethod( "get_children", R.InstanceMembers ) );
				}
				return __getter_children();
			}
		}

		public UnityEngine.Rect position {
			get {
				if( __getter_position == null ) {
					__getter_position = (Func<UnityEngine.Rect>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect> ), m_instance, UnityTypes.UnityEditor_SplitView.GetMethod( "get_position", R.InstanceMembers ) );
				}
				return __getter_position();
			}
			set {
				if( __setter_position == null ) {
					__setter_position = (Action<UnityEngine.Rect>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Rect> ), m_instance, UnityTypes.UnityEditor_SplitView.GetMethod( "set_position", R.InstanceMembers ) );
			  }
				__setter_position( value );
			}
		}

		public UnityEngine.Rect screenPosition {
			get {
				if( __getter_screenPosition == null ) {
					__getter_screenPosition = (Func<UnityEngine.Rect>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect> ), m_instance, UnityTypes.UnityEditor_SplitView.GetMethod( "get_screenPosition", R.InstanceMembers ) );
				}
				return __getter_screenPosition();
			}
		}

		public static void RecalcMinMaxAndReflowAll( object start ) {
			if( __RecalcMinMaxAndReflowAll_0_1 == null ) {
				__RecalcMinMaxAndReflowAll_0_1 = UnityTypes.UnityEditor_SplitView.GetMethod( "RecalcMinMaxAndReflowAll", R.StaticMembers );
			}
			__RecalcMinMaxAndReflowAll_0_1.Invoke( null, new object[] {  start  } );
		}
		
		public void AddChild( object child, int idx ) {
			if( __AddChild_0_2 == null ) {
				__AddChild_0_2 = UnityTypes.UnityEditor_SplitView.GetMethod( "AddChild", R.InstanceMembers, null, new Type[]{ typeof( object ), typeof( int ) }, null );
			}
			__AddChild_0_2.Invoke( m_instance, new object[] {  child, idx  } );
		}
		
		public void AddChild( object child ) {
			if( __AddChild_1_1 == null ) {
				__AddChild_1_1 = UnityTypes.UnityEditor_SplitView.GetMethod( "AddChild", R.InstanceMembers, null, new Type[]{ typeof( object ) }, null );
			}
			__AddChild_1_1.Invoke( m_instance, new object[] {  child  } );
		}
		
		public void MakeRoomForRect( UnityEngine.Rect r ) {
			if( __MakeRoomForRect_0_1 == null ) {
				__MakeRoomForRect_0_1 = (Action<UnityEngine.Rect>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Rect> ), m_instance, UnityTypes.UnityEditor_SplitView.GetMethod( "MakeRoomForRect", R.InstanceMembers, null, new Type[]{ typeof( UnityEngine.Rect ) }, null ) );
			}
			__MakeRoomForRect_0_1( r );
		}
		
		public void Reflow() {
			if( __Reflow_0_0 == null ) {
				__Reflow_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_SplitView.GetMethod( "Reflow", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__Reflow_0_0();
		}
		
		
		
		FieldInfo __vertical;
		Func<object[]> __getter_children;
		Func<UnityEngine.Rect> __getter_position;
		Action<UnityEngine.Rect> __setter_position;
		Func<UnityEngine.Rect> __getter_screenPosition;
		static MethodInfo __RecalcMinMaxAndReflowAll_0_1;
		MethodInfo __AddChild_0_2;
		MethodInfo __AddChild_1_1;
		Action<UnityEngine.Rect> __MakeRoomForRect_0_1;
		Action __Reflow_0_0;
	}
}

