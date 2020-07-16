/// UnityEditor.EditorAssemblies : 2019.3.10f1

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public static partial class UnityEditorAssemblies {
 



    delegate bool Method_IsSubclassOfGenericType0( System.Type klass, System.Type genericType );
    static Method_IsSubclassOfGenericType0 __IsSubclassOfGenericType0;
    public static bool IsSubclassOfGenericType( System.Type klass, System.Type genericType ) {
      if( __IsSubclassOfGenericType0 == null ) {
        __IsSubclassOfGenericType0 = (Method_IsSubclassOfGenericType0) Delegate.CreateDelegate( typeof( Method_IsSubclassOfGenericType0 ), null, R.Method("IsSubclassOfGenericType", "UnityEditor.EditorAssemblies", "UnityEditor.dll") );
      }
      return __IsSubclassOfGenericType0(  klass, genericType  );
    }



    delegate void Method_SetLoadedEditorAssemblies0( System.Reflection.Assembly[] assemblies );
    static Method_SetLoadedEditorAssemblies0 __SetLoadedEditorAssemblies0;
    public static void SetLoadedEditorAssemblies( System.Reflection.Assembly[] assemblies ) {
      if( __SetLoadedEditorAssemblies0 == null ) {
        __SetLoadedEditorAssemblies0 = (Method_SetLoadedEditorAssemblies0) Delegate.CreateDelegate( typeof( Method_SetLoadedEditorAssemblies0 ), null, R.Method("SetLoadedEditorAssemblies", "UnityEditor.EditorAssemblies", "UnityEditor.dll") );
      }
      __SetLoadedEditorAssemblies0(  assemblies  );
    }



    delegate void Method_ProcessInitializeOnLoadAttributes0( System.Type[] types );
    static Method_ProcessInitializeOnLoadAttributes0 __ProcessInitializeOnLoadAttributes0;
    public static void ProcessInitializeOnLoadAttributes( System.Type[] types ) {
      if( __ProcessInitializeOnLoadAttributes0 == null ) {
        __ProcessInitializeOnLoadAttributes0 = (Method_ProcessInitializeOnLoadAttributes0) Delegate.CreateDelegate( typeof( Method_ProcessInitializeOnLoadAttributes0 ), null, R.Method("ProcessInitializeOnLoadAttributes", "UnityEditor.EditorAssemblies", "UnityEditor.dll") );
      }
      __ProcessInitializeOnLoadAttributes0(  types  );
    }



	}
}

#endif

