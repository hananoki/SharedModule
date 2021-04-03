/// UnityEditor.Build.BuildPlatforms : 2020.2.7f1

using HananokiEditor;
using System;
using System.Reflection;
using System.Collections;

namespace UnityReflection {
  public sealed partial class UnityEditorBuildBuildPlatforms {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorBuildBuildPlatforms( object instance ){
			m_instance = instance;
    }
    public UnityEditorBuildBuildPlatforms() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_Build_BuildPlatforms, new object[] {} );
    }
    

		public ICollection buildPlatforms {
			get {
				if( __buildPlatforms == null ) {
					__buildPlatforms = UnityTypes.UnityEditor_Build_BuildPlatforms.GetField( "buildPlatforms", R.InstanceMembers );
				}
				return (ICollection) __buildPlatforms.GetValue( m_instance );
			}
			set {
				if( __buildPlatforms == null ) {
					__buildPlatforms = UnityTypes.UnityEditor_Build_BuildPlatforms.GetField( "buildPlatforms", R.InstanceMembers );
				}
				__buildPlatforms.SetValue( m_instance, value );
			}
		}

		public static object instance {
			get {
				if( __getter_instance == null ) {
					__getter_instance = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), null, UnityTypes.UnityEditor_Build_BuildPlatforms.GetMethod( "get_instance", R.StaticMembers ) );
				}
				return __getter_instance();
			}
		}

		public string GetBuildTargetDisplayName( UnityEditor.BuildTargetGroup group, UnityEditor.BuildTarget target ) {
			if( __GetBuildTargetDisplayName_0_2 == null ) {
				__GetBuildTargetDisplayName_0_2 = (Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, string>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, string> ), m_instance, UnityTypes.UnityEditor_Build_BuildPlatforms.GetMethod( "GetBuildTargetDisplayName", R.InstanceMembers, null, new Type[]{ typeof( UnityEditor.BuildTargetGroup ), typeof( UnityEditor.BuildTarget ) }, null ) );
			}
			return __GetBuildTargetDisplayName_0_2( group, target );
		}
		
		public string GetModuleDisplayName( UnityEditor.BuildTargetGroup buildTargetGroup, UnityEditor.BuildTarget buildTarget ) {
			if( __GetModuleDisplayName_0_2 == null ) {
				__GetModuleDisplayName_0_2 = (Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, string>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, string> ), m_instance, UnityTypes.UnityEditor_Build_BuildPlatforms.GetMethod( "GetModuleDisplayName", R.InstanceMembers, null, new Type[]{ typeof( UnityEditor.BuildTargetGroup ), typeof( UnityEditor.BuildTarget ) }, null ) );
			}
			return __GetModuleDisplayName_0_2( buildTargetGroup, buildTarget );
		}
		
		public int BuildPlatformIndexFromTargetGroup( UnityEditor.BuildTargetGroup group ) {
			if( __BuildPlatformIndexFromTargetGroup_0_1 == null ) {
				__BuildPlatformIndexFromTargetGroup_0_1 = (Func<UnityEditor.BuildTargetGroup, int>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTargetGroup, int> ), m_instance, UnityTypes.UnityEditor_Build_BuildPlatforms.GetMethod( "BuildPlatformIndexFromTargetGroup", R.InstanceMembers, null, new Type[]{ typeof( UnityEditor.BuildTargetGroup ) }, null ) );
			}
			return __BuildPlatformIndexFromTargetGroup_0_1( group );
		}
		
		public bool ContainsBuildTarget( UnityEditor.BuildTargetGroup group ) {
			if( __ContainsBuildTarget_0_1 == null ) {
				__ContainsBuildTarget_0_1 = (Func<UnityEditor.BuildTargetGroup, bool>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTargetGroup, bool> ), m_instance, UnityTypes.UnityEditor_Build_BuildPlatforms.GetMethod( "ContainsBuildTarget", R.InstanceMembers, null, new Type[]{ typeof( UnityEditor.BuildTargetGroup ) }, null ) );
			}
			return __ContainsBuildTarget_0_1( group );
		}
		
		public object BuildPlatformFromTargetGroup( UnityEditor.BuildTargetGroup group ) {
			if( __BuildPlatformFromTargetGroup_0_1 == null ) {
				__BuildPlatformFromTargetGroup_0_1 = (Func<UnityEditor.BuildTargetGroup, object>) Delegate.CreateDelegate( typeof( Func<UnityEditor.BuildTargetGroup, object> ), m_instance, UnityTypes.UnityEditor_Build_BuildPlatforms.GetMethod( "BuildPlatformFromTargetGroup", R.InstanceMembers, null, new Type[]{ typeof( UnityEditor.BuildTargetGroup ) }, null ) );
			}
			return __BuildPlatformFromTargetGroup_0_1( group );
		}
		
		public IList GetValidPlatforms( bool includeMetaPlatforms ) {
			if( __GetValidPlatforms_0_1 == null ) {
				__GetValidPlatforms_0_1 = (Func<bool, IList>) Delegate.CreateDelegate( typeof( Func<bool, IList> ), m_instance, UnityTypes.UnityEditor_Build_BuildPlatforms.GetMethod( "GetValidPlatforms", R.InstanceMembers, null, new Type[]{ typeof( bool ) }, null ) );
			}
			return __GetValidPlatforms_0_1( includeMetaPlatforms );
		}
		
		public IList GetValidPlatforms() {
			if( __GetValidPlatforms_1_0 == null ) {
				__GetValidPlatforms_1_0 = (Func<IList>) Delegate.CreateDelegate( typeof( Func<IList> ), m_instance, UnityTypes.UnityEditor_Build_BuildPlatforms.GetMethod( "GetValidPlatforms", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			return __GetValidPlatforms_1_0();
		}
		
		
		
		FieldInfo __buildPlatforms;
		static Func<object> __getter_instance;
		Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, string> __GetBuildTargetDisplayName_0_2;
		Func<UnityEditor.BuildTargetGroup,UnityEditor.BuildTarget, string> __GetModuleDisplayName_0_2;
		Func<UnityEditor.BuildTargetGroup, int> __BuildPlatformIndexFromTargetGroup_0_1;
		Func<UnityEditor.BuildTargetGroup, bool> __ContainsBuildTarget_0_1;
		Func<UnityEditor.BuildTargetGroup, object> __BuildPlatformFromTargetGroup_0_1;
		Func<bool, IList> __GetValidPlatforms_0_1;
		Func<IList> __GetValidPlatforms_1_0;
	}
}

