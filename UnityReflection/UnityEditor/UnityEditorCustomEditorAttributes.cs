/// UnityEditor.CustomEditorAttributes : 2019.4.5f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorCustomEditorAttributes {
    
		public static System.Type FindCustomEditorType( UnityEngine.Object o, bool multiEdit ) {
			if( __FindCustomEditorType_0_2 == null ) {
				__FindCustomEditorType_0_2 = (Func<UnityEngine.Object,bool, System.Type>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Object,bool, System.Type> ), null, UnityTypes.UnityEditor_CustomEditorAttributes.GetMethod( "FindCustomEditorType", R.StaticMembers, null, new Type[]{ typeof( UnityEngine.Object ), typeof( bool ) }, null ) );
			}
			return __FindCustomEditorType_0_2( o, multiEdit );
		}
		
		public static System.Type FindCustomEditorTypeByType( System.Type type, bool multiEdit ) {
			if( __FindCustomEditorTypeByType_0_2 == null ) {
				__FindCustomEditorTypeByType_0_2 = (Func<System.Type,bool, System.Type>) Delegate.CreateDelegate( typeof( Func<System.Type,bool, System.Type> ), null, UnityTypes.UnityEditor_CustomEditorAttributes.GetMethod( "FindCustomEditorTypeByType", R.StaticMembers, null, new Type[]{ typeof( System.Type ), typeof( bool ) }, null ) );
			}
			return __FindCustomEditorTypeByType_0_2( type, multiEdit );
		}
		
		public static bool IsAppropriateEditor( object editor, System.Type parentClass, bool isChildClass, bool isFallback ) {
			if( __IsAppropriateEditor_0_4 == null ) {
				__IsAppropriateEditor_0_4 = UnityTypes.UnityEditor_CustomEditorAttributes.GetMethod( "IsAppropriateEditor", R.StaticMembers, null, new Type[]{ typeof( object ), typeof( System.Type ), typeof( bool ), typeof( bool ) }, null );
			}
			return __IsAppropriateEditor_0_4.MethodInvoke<bool>( "IsAppropriateEditor", new object[] { editor, parentClass, isChildClass, isFallback } );
		}
		
		
		
		static Func<UnityEngine.Object,bool, System.Type> __FindCustomEditorType_0_2;
		static Func<System.Type,bool, System.Type> __FindCustomEditorTypeByType_0_2;
		static MethodInfo __IsAppropriateEditor_0_4;
	}
}

