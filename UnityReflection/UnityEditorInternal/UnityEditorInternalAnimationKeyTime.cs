/// UnityEditorInternal.AnimationKeyTime : 2020.3.0f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorInternalAnimationKeyTime {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorInternalAnimationKeyTime( object instance ){
			m_instance = instance;
    }
    

		public int frame {
			get {
				if( __getter_frame == null ) {
					__getter_frame = (Func<int>) Delegate.CreateDelegate( typeof( Func<int> ), m_instance, UnityTypes.UnityEditorInternal_AnimationKeyTime.GetMethod( "get_frame", R.InstanceMembers ) );
				}
				return __getter_frame();
			}
		}

		public float frameCeiling {
			get {
				if( __getter_frameCeiling == null ) {
					__getter_frameCeiling = (Func<float>) Delegate.CreateDelegate( typeof( Func<float> ), m_instance, UnityTypes.UnityEditorInternal_AnimationKeyTime.GetMethod( "get_frameCeiling", R.InstanceMembers ) );
				}
				return __getter_frameCeiling();
			}
		}

		public float frameFloor {
			get {
				if( __getter_frameFloor == null ) {
					__getter_frameFloor = (Func<float>) Delegate.CreateDelegate( typeof( Func<float> ), m_instance, UnityTypes.UnityEditorInternal_AnimationKeyTime.GetMethod( "get_frameFloor", R.InstanceMembers ) );
				}
				return __getter_frameFloor();
			}
		}

		public float frameRate {
			get {
				if( __getter_frameRate == null ) {
					__getter_frameRate = (Func<float>) Delegate.CreateDelegate( typeof( Func<float> ), m_instance, UnityTypes.UnityEditorInternal_AnimationKeyTime.GetMethod( "get_frameRate", R.InstanceMembers ) );
				}
				return __getter_frameRate();
			}
		}

		public float time {
			get {
				if( __getter_time == null ) {
					__getter_time = (Func<float>) Delegate.CreateDelegate( typeof( Func<float> ), m_instance, UnityTypes.UnityEditorInternal_AnimationKeyTime.GetMethod( "get_time", R.InstanceMembers ) );
				}
				return __getter_time();
			}
		}

		public float timeRound {
			get {
				if( __getter_timeRound == null ) {
					__getter_timeRound = (Func<float>) Delegate.CreateDelegate( typeof( Func<float> ), m_instance, UnityTypes.UnityEditorInternal_AnimationKeyTime.GetMethod( "get_timeRound", R.InstanceMembers ) );
				}
				return __getter_timeRound();
			}
		}

		public static object Frame( int frame, float frameRate ) {
			if( __Frame_0_2 == null ) {
				__Frame_0_2 = UnityTypes.UnityEditorInternal_AnimationKeyTime.GetMethod( "Frame", R.StaticMembers, null, new Type[]{ typeof( int ), typeof( float ) }, null );
			}
			return (object) __Frame_0_2.Invoke( null, new object[] {  frame, frameRate  } );
		}
		
		public static object Time( float time, float frameRate ) {
			if( __Time_0_2 == null ) {
				__Time_0_2 = (Func<float,float, object>) Delegate.CreateDelegate( typeof( Func<float,float, object> ), null, UnityTypes.UnityEditorInternal_AnimationKeyTime.GetMethod( "Time", R.StaticMembers, null, new Type[]{ typeof( float ), typeof( float ) }, null ) );
			}
			return __Time_0_2( time, frameRate );
		}
		
		
		
		Func<int> __getter_frame;
		Func<float> __getter_frameCeiling;
		Func<float> __getter_frameFloor;
		Func<float> __getter_frameRate;
		Func<float> __getter_time;
		Func<float> __getter_timeRound;
		static MethodInfo __Frame_0_2;
		static Func<float,float, object> __Time_0_2;
	}
}

