/// UnityEditor.ScriptAttributeUtility : 2019.4.5f1

using HananokiEditor;
using System;
using System.Collections.Generic;

namespace UnityReflection {
  public sealed partial class UnityEditorScriptAttributeUtility {
    
		public static System.Type GetDrawerTypeForPropertyAndType( UnityEditor.SerializedProperty property, System.Type type ) {
			if( __GetDrawerTypeForPropertyAndType_0_2 == null ) {
				__GetDrawerTypeForPropertyAndType_0_2 = (Func<UnityEditor.SerializedProperty,System.Type, System.Type>) Delegate.CreateDelegate( typeof( Func<UnityEditor.SerializedProperty,System.Type, System.Type> ), null, UnityTypes.UnityEditor_ScriptAttributeUtility.GetMethod( "GetDrawerTypeForPropertyAndType", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.SerializedProperty ), typeof( System.Type ) }, null ) );
			}
			return __GetDrawerTypeForPropertyAndType_0_2( property, type );
		}
		
		public static System.Reflection.FieldInfo GetFieldInfoFromProperty( UnityEditor.SerializedProperty property, ref System.Type type ) {
			if( __GetFieldInfoFromProperty_0_2 == null ) {
				__GetFieldInfoFromProperty_0_2 = (Method_GetFieldInfoFromProperty_0_2) Delegate.CreateDelegate( typeof( Method_GetFieldInfoFromProperty_0_2 ), null, UnityTypes.UnityEditor_ScriptAttributeUtility.GetMethod( "GetFieldInfoFromProperty", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.SerializedProperty ), typeof( System.Type ).MakeByRefType() }, null ) );
			}
			return __GetFieldInfoFromProperty_0_2( property, ref type );
		}
		
		public static List<UnityEngine.PropertyAttribute> GetFieldAttributes( System.Reflection.FieldInfo field ) {
			if( __GetFieldAttributes_0_1 == null ) {
				__GetFieldAttributes_0_1 = (Func<System.Reflection.FieldInfo, List<UnityEngine.PropertyAttribute>>) Delegate.CreateDelegate( typeof( Func<System.Reflection.FieldInfo, List<UnityEngine.PropertyAttribute>> ), null, UnityTypes.UnityEditor_ScriptAttributeUtility.GetMethod( "GetFieldAttributes", R.StaticMembers, null, new Type[]{ typeof( System.Reflection.FieldInfo ) }, null ) );
			}
			return __GetFieldAttributes_0_1( field );
		}
		
		public static bool GetTypeFromManagedReferenceFullTypeName( string managedReferenceFullTypename, ref System.Type managedReferenceInstanceType ) {
			if( __GetTypeFromManagedReferenceFullTypeName_0_2 == null ) {
				__GetTypeFromManagedReferenceFullTypeName_0_2 = (Method_GetTypeFromManagedReferenceFullTypeName_0_2) Delegate.CreateDelegate( typeof( Method_GetTypeFromManagedReferenceFullTypeName_0_2 ), null, UnityTypes.UnityEditor_ScriptAttributeUtility.GetMethod( "GetTypeFromManagedReferenceFullTypeName", R.StaticMembers, null, new Type[]{ typeof( string ), typeof( System.Type ).MakeByRefType() }, null ) );
			}
			return __GetTypeFromManagedReferenceFullTypeName_0_2( managedReferenceFullTypename, ref managedReferenceInstanceType );
		}
		
		public static System.Type GetScriptTypeFromProperty( UnityEditor.SerializedProperty property ) {
			if( __GetScriptTypeFromProperty_0_1 == null ) {
				__GetScriptTypeFromProperty_0_1 = (Func<UnityEditor.SerializedProperty, System.Type>) Delegate.CreateDelegate( typeof( Func<UnityEditor.SerializedProperty, System.Type> ), null, UnityTypes.UnityEditor_ScriptAttributeUtility.GetMethod( "GetScriptTypeFromProperty", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.SerializedProperty ) }, null ) );
			}
			return __GetScriptTypeFromProperty_0_1( property );
		}
		
		public static object GetHandler( UnityEditor.SerializedProperty property ) {
			if( __GetHandler_0_1 == null ) {
				__GetHandler_0_1 = (Func<UnityEditor.SerializedProperty, object>) Delegate.CreateDelegate( typeof( Func<UnityEditor.SerializedProperty, object> ), null, UnityTypes.UnityEditor_ScriptAttributeUtility.GetMethod( "GetHandler", R.StaticMembers, null, new Type[]{ typeof( UnityEditor.SerializedProperty ) }, null ) );
			}
			return __GetHandler_0_1( property );
		}
		
		
		
		static Func<UnityEditor.SerializedProperty,System.Type, System.Type> __GetDrawerTypeForPropertyAndType_0_2;
		delegate System.Reflection.FieldInfo Method_GetFieldInfoFromProperty_0_2(  UnityEditor.SerializedProperty property, ref System.Type type  );
		static Method_GetFieldInfoFromProperty_0_2 __GetFieldInfoFromProperty_0_2;
		static Func<System.Reflection.FieldInfo, List<UnityEngine.PropertyAttribute>> __GetFieldAttributes_0_1;
		delegate bool Method_GetTypeFromManagedReferenceFullTypeName_0_2(  string managedReferenceFullTypename, ref System.Type managedReferenceInstanceType  );
		static Method_GetTypeFromManagedReferenceFullTypeName_0_2 __GetTypeFromManagedReferenceFullTypeName_0_2;
		static Func<UnityEditor.SerializedProperty, System.Type> __GetScriptTypeFromProperty_0_1;
		static Func<UnityEditor.SerializedProperty, object> __GetHandler_0_1;
	}
}

