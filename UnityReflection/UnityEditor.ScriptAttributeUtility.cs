/// UnityEditor.ScriptAttributeUtility : 2019.4.0f1

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public static partial class UnityScriptAttributeUtility {
    delegate System.Type Method_GetDrawerTypeForPropertyAndType0( UnityEditor.SerializedProperty property, System.Type type );
    static Method_GetDrawerTypeForPropertyAndType0 __GetDrawerTypeForPropertyAndType0;
    public static System.Type GetDrawerTypeForPropertyAndType( UnityEditor.SerializedProperty property, System.Type type ) {
      if( __GetDrawerTypeForPropertyAndType0 == null ) {
        __GetDrawerTypeForPropertyAndType0 = (Method_GetDrawerTypeForPropertyAndType0) Delegate.CreateDelegate( typeof( Method_GetDrawerTypeForPropertyAndType0 ), null, R.Method("GetDrawerTypeForPropertyAndType", "UnityEditor.ScriptAttributeUtility", "UnityEditor.dll") );
      }
      return __GetDrawerTypeForPropertyAndType0(  property, type  );
    }



    delegate System.Reflection.FieldInfo Method_GetFieldInfoFromProperty0( UnityEditor.SerializedProperty property, ref System.Type type );
    static Method_GetFieldInfoFromProperty0 __GetFieldInfoFromProperty0;
    public static System.Reflection.FieldInfo GetFieldInfoFromProperty( UnityEditor.SerializedProperty property, ref System.Type type ) {
      if( __GetFieldInfoFromProperty0 == null ) {
        __GetFieldInfoFromProperty0 = (Method_GetFieldInfoFromProperty0) Delegate.CreateDelegate( typeof( Method_GetFieldInfoFromProperty0 ), null, R.Method("GetFieldInfoFromProperty", "UnityEditor.ScriptAttributeUtility", "UnityEditor.dll") );
      }
      return __GetFieldInfoFromProperty0(  property, ref type  );
    }



    delegate System.Collections.Generic.List<UnityEngine.PropertyAttribute> Method_GetFieldAttributes0( System.Reflection.FieldInfo field );
    static Method_GetFieldAttributes0 __GetFieldAttributes0;
    public static System.Collections.Generic.List<UnityEngine.PropertyAttribute> GetFieldAttributes( System.Reflection.FieldInfo field ) {
      if( __GetFieldAttributes0 == null ) {
        __GetFieldAttributes0 = (Method_GetFieldAttributes0) Delegate.CreateDelegate( typeof( Method_GetFieldAttributes0 ), null, R.Method("GetFieldAttributes", "UnityEditor.ScriptAttributeUtility", "UnityEditor.dll") );
      }
      return __GetFieldAttributes0(  field  );
    }



    delegate bool Method_GetTypeFromManagedReferenceFullTypeName0( string managedReferenceFullTypename, ref System.Type managedReferenceInstanceType );
    static Method_GetTypeFromManagedReferenceFullTypeName0 __GetTypeFromManagedReferenceFullTypeName0;
    public static bool GetTypeFromManagedReferenceFullTypeName( string managedReferenceFullTypename, ref System.Type managedReferenceInstanceType ) {
      if( __GetTypeFromManagedReferenceFullTypeName0 == null ) {
        __GetTypeFromManagedReferenceFullTypeName0 = (Method_GetTypeFromManagedReferenceFullTypeName0) Delegate.CreateDelegate( typeof( Method_GetTypeFromManagedReferenceFullTypeName0 ), null, R.Method("GetTypeFromManagedReferenceFullTypeName", "UnityEditor.ScriptAttributeUtility", "UnityEditor.dll") );
      }
      return __GetTypeFromManagedReferenceFullTypeName0(  managedReferenceFullTypename, ref managedReferenceInstanceType  );
    }



    delegate System.Type Method_GetScriptTypeFromProperty0( UnityEditor.SerializedProperty property );
    static Method_GetScriptTypeFromProperty0 __GetScriptTypeFromProperty0;
    public static System.Type GetScriptTypeFromProperty( UnityEditor.SerializedProperty property ) {
      if( __GetScriptTypeFromProperty0 == null ) {
        __GetScriptTypeFromProperty0 = (Method_GetScriptTypeFromProperty0) Delegate.CreateDelegate( typeof( Method_GetScriptTypeFromProperty0 ), null, R.Method("GetScriptTypeFromProperty", "UnityEditor.ScriptAttributeUtility", "UnityEditor.dll") );
      }
      return __GetScriptTypeFromProperty0(  property  );
    }



    delegate object Method_GetHandler0( UnityEditor.SerializedProperty property );
    static Method_GetHandler0 __GetHandler0;
    public static object GetHandler( UnityEditor.SerializedProperty property ) {
      if( __GetHandler0 == null ) {
        __GetHandler0 = (Method_GetHandler0) Delegate.CreateDelegate( typeof( Method_GetHandler0 ), null, R.Method("GetHandler", "UnityEditor.ScriptAttributeUtility", "UnityEditor.dll") );
      }
      return __GetHandler0(  property  );
    }



	}
}

#endif

