/// UnityEditor.SplitterState : 2019.3.0f6

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public partial class UnitySplitterState {
    public object m_instance;
    public object GetInstance() { return m_instance; }

    public UnitySplitterState( params float[] relativeSizes ) {
      m_instance = Activator.CreateInstance( R.Type("UnityEditor.SplitterState", "UnityEditor.dll"), new object[] {  relativeSizes  } );
    }
    public UnitySplitterState( int[] realSizes, int[] minSizes, int[] maxSizes ) {
      m_instance = Activator.CreateInstance( R.Type("UnityEditor.SplitterState", "UnityEditor.dll"), new object[] {  realSizes, minSizes, maxSizes  } );
    }
    public UnitySplitterState( float[] relativeSizes, int[] minSizes, int[] maxSizes ) {
      m_instance = Activator.CreateInstance( R.Type("UnityEditor.SplitterState", "UnityEditor.dll"), new object[] {  relativeSizes, minSizes, maxSizes  } );
    }
    public UnitySplitterState( float[] relativeSizes, int[] minSizes, int[] maxSizes, int splitSize ) {
      m_instance = Activator.CreateInstance( R.Type("UnityEditor.SplitterState", "UnityEditor.dll"), new object[] {  relativeSizes, minSizes, maxSizes, splitSize  } );
    }


    delegate void Method_Init0( float[] relativeSizes, int[] minSizes, int[] maxSizes, int splitSize );
    Method_Init0 __Init0;
    public void Init( float[] relativeSizes, int[] minSizes, int[] maxSizes, int splitSize ) {
      if( __Init0 == null ) {
        __Init0 = (Method_Init0) Delegate.CreateDelegate( typeof( Method_Init0 ), m_instance, R.Method("Init", "UnityEditor.SplitterState", "UnityEditor.dll") );
      }
      __Init0(  relativeSizes, minSizes, maxSizes, splitSize  );
    }



	}
}

#endif

