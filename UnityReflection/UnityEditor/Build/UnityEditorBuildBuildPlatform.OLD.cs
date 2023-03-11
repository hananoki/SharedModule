#if !UNITY_2021_2_OR_NEWER
/// UnityEditor.Build.BuildPlatform : 2020.2.7f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorBuildBuildPlatform {
		public object m_instance;
    
    public UnityEditorBuildBuildPlatform( object instance ){
			m_instance = instance;
    }
    public UnityEditorBuildBuildPlatform( string locTitle, string iconId, UnityEditor.BuildTargetGroup targetGroup, UnityEditor.BuildTarget defaultTarget, bool forceShowTarget ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_Build_BuildPlatform, new object[] { locTitle, iconId, targetGroup, defaultTarget, forceShowTarget } );
    }
    public UnityEditorBuildBuildPlatform( string locTitle, string tooltip, string iconId, UnityEditor.BuildTargetGroup targetGroup, UnityEditor.BuildTarget defaultTarget, bool forceShowTarget ) {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_Build_BuildPlatform, new object[] { locTitle, tooltip, iconId, targetGroup, defaultTarget, forceShowTarget } );
    }
    

		public string name {
			get {
				if( __name == null ) {
					__name = UnityTypes.UnityEditor_Build_BuildPlatform.GetField( "name", R.InstanceMembers );
				}
				return (string) __name.GetValue( m_instance );
			}
			set {
				if( __name == null ) {
					__name = UnityTypes.UnityEditor_Build_BuildPlatform.GetField( "name", R.InstanceMembers );
				}
				__name.SetValue( m_instance, value );
			}
		}

		public bool forceShowTarget {
			get {
				if( __forceShowTarget == null ) {
					__forceShowTarget = UnityTypes.UnityEditor_Build_BuildPlatform.GetField( "forceShowTarget", R.InstanceMembers );
				}
				return (bool) __forceShowTarget.GetValue( m_instance );
			}
			set {
				if( __forceShowTarget == null ) {
					__forceShowTarget = UnityTypes.UnityEditor_Build_BuildPlatform.GetField( "forceShowTarget", R.InstanceMembers );
				}
				__forceShowTarget.SetValue( m_instance, value );
			}
		}

		public UnityEditor.BuildTargetGroup targetGroup {
			get {
				if( __targetGroup == null ) {
					__targetGroup = UnityTypes.UnityEditor_Build_BuildPlatform.GetField( "targetGroup", R.InstanceMembers );
				}
				return (UnityEditor.BuildTargetGroup) __targetGroup.GetValue( m_instance );
			}
			set {
				if( __targetGroup == null ) {
					__targetGroup = UnityTypes.UnityEditor_Build_BuildPlatform.GetField( "targetGroup", R.InstanceMembers );
				}
				__targetGroup.SetValue( m_instance, value );
			}
		}

		public string tooltip {
			get {
				if( __tooltip == null ) {
					__tooltip = UnityTypes.UnityEditor_Build_BuildPlatform.GetField( "tooltip", R.InstanceMembers );
				}
				return (string) __tooltip.GetValue( m_instance );
			}
			set {
				if( __tooltip == null ) {
					__tooltip = UnityTypes.UnityEditor_Build_BuildPlatform.GetField( "tooltip", R.InstanceMembers );
				}
				__tooltip.SetValue( m_instance, value );
			}
		}

		public UnityEditor.BuildTarget defaultTarget {
			get {
				if( __defaultTarget == null ) {
					__defaultTarget = UnityTypes.UnityEditor_Build_BuildPlatform.GetField( "defaultTarget", R.InstanceMembers );
				}
				return (UnityEditor.BuildTarget) __defaultTarget.GetValue( m_instance );
			}
			set {
				if( __defaultTarget == null ) {
					__defaultTarget = UnityTypes.UnityEditor_Build_BuildPlatform.GetField( "defaultTarget", R.InstanceMembers );
				}
				__defaultTarget.SetValue( m_instance, value );
			}
		}

		public UnityEngine.GUIContent title {
			get {
				if( __getter_title == null ) {
					__getter_title = (Func<UnityEngine.GUIContent>) Delegate.CreateDelegate( typeof( Func<UnityEngine.GUIContent> ), m_instance, UnityTypes.UnityEditor_Build_BuildPlatform.GetMethod( "get_title", R.InstanceMembers ) );
				}
				return __getter_title();
			}
		}

		public UnityEngine.Texture2D smallIcon {
			get {
				if( __getter_smallIcon == null ) {
					__getter_smallIcon = (Func<UnityEngine.Texture2D>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Texture2D> ), m_instance, UnityTypes.UnityEditor_Build_BuildPlatform.GetMethod( "get_smallIcon", R.InstanceMembers ) );
				}
				return __getter_smallIcon();
			}
		}

		
		
		FieldInfo __name;
		FieldInfo __forceShowTarget;
		FieldInfo __targetGroup;
		FieldInfo __tooltip;
		FieldInfo __defaultTarget;
		Func<UnityEngine.GUIContent> __getter_title;
		Func<UnityEngine.Texture2D> __getter_smallIcon;
	}
}

#endif
