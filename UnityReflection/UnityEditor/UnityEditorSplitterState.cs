/// UnityEditor.SplitterState : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;

namespace UnityReflection {
  public sealed partial class UnityEditorSplitterState {
		public object m_instance;
    
    public UnityEditorSplitterState( object instance ){
			m_instance = instance;
    }
    public UnityEditorSplitterState( params float[] relativeSizes ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_SplitterState, new object[] { relativeSizes } );
    }
    public UnityEditorSplitterState( int[] realSizes, int[] minSizes, int[] maxSizes ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_SplitterState, new object[] { realSizes, minSizes, maxSizes } );
    }
    public UnityEditorSplitterState( float[] relativeSizes, int[] minSizes, int[] maxSizes ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_SplitterState, new object[] { relativeSizes, minSizes, maxSizes } );
    }
    public UnityEditorSplitterState( float[] relativeSizes, int[] minSizes, int[] maxSizes, int splitSize ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_SplitterState, new object[] { relativeSizes, minSizes, maxSizes, splitSize } );
    }
    
    
		public void Init( float[] relativeSizes, int[] minSizes, int[] maxSizes, int splitSize ) {
			if( __Init_0_4 == null ) {
				__Init_0_4 = (Action<float[],int[],int[],int>) Delegate.CreateDelegate( typeof( Action<float[],int[],int[],int> ), m_instance, UnityTypes.UnityEditor_SplitterState.GetMethod( "Init", R.InstanceMembers, null, new Type[]{ typeof( float[] ), typeof( int[] ), typeof( int[] ), typeof( int ) }, null ) );
			}
			__Init_0_4( relativeSizes, minSizes, maxSizes, splitSize );
		}
		
		public bool IsValid() {
			if( __IsValid_0_0 == null ) {
				__IsValid_0_0 = (Func<bool>) Delegate.CreateDelegate( typeof( Func<bool> ), m_instance, UnityTypes.UnityEditor_SplitterState.GetMethod( "IsValid", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __IsValid_0_0(  );
		}
		
		public void NormalizeRelativeSizes() {
			if( __NormalizeRelativeSizes_0_0 == null ) {
				__NormalizeRelativeSizes_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_SplitterState.GetMethod( "NormalizeRelativeSizes", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__NormalizeRelativeSizes_0_0(  );
		}
		
		public void RealToRelativeSizes() {
			if( __RealToRelativeSizes_0_0 == null ) {
				__RealToRelativeSizes_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_SplitterState.GetMethod( "RealToRelativeSizes", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__RealToRelativeSizes_0_0(  );
		}
		
		public void RelativeToRealSizes( int totalSpace ) {
			if( __RelativeToRealSizes_0_1 == null ) {
				__RelativeToRealSizes_0_1 = (Action<int>) Delegate.CreateDelegate( typeof( Action<int> ), m_instance, UnityTypes.UnityEditor_SplitterState.GetMethod( "RelativeToRealSizes", R.InstanceMembers, null, new Type[]{ typeof( int ) }, null ) );
			}
			__RelativeToRealSizes_0_1( totalSpace );
		}
		
		public void DoSplitter( int i1, int i2, int diff ) {
			if( __DoSplitter_0_3 == null ) {
				__DoSplitter_0_3 = (Action<int,int,int>) Delegate.CreateDelegate( typeof( Action<int,int,int> ), m_instance, UnityTypes.UnityEditor_SplitterState.GetMethod( "DoSplitter", R.InstanceMembers, null, new Type[]{ typeof( int ), typeof( int ), typeof( int ) }, null ) );
			}
			__DoSplitter_0_3( i1, i2, diff );
		}
		
		
		
		Action<float[],int[],int[],int> __Init_0_4;
		Func<bool> __IsValid_0_0;
		Action __NormalizeRelativeSizes_0_0;
		Action __RealToRelativeSizes_0_0;
		Action<int> __RelativeToRealSizes_0_1;
		Action<int,int,int> __DoSplitter_0_3;
	}
}

