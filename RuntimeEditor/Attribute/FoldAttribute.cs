
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
using HananokiEditor;
#endif

namespace HananokiRuntime {
	public class GroupAttribute : PropertyAttribute {
		public string name;
		public bool prefix;

		public GroupAttribute( string name = null, bool prefix = false ) {
			this.name = name;
			this.prefix = prefix;
		}
	}
	public class GroupAndPrefixAttribute : GroupAttribute {
		public GroupAndPrefixAttribute( string name = null ) : base( name, true ) { }
	}



	public class HeaderTitleAttribute : PropertyAttribute {
		public string name;
		public HeaderTitleAttribute( string name ) {
			this.name = name;
		}
	}


#if UNITY_EDITOR
	[CustomPropertyDrawer( typeof( HeaderTitleAttribute ), true )]
	class HeaderTitleAttributeDrawer : DecoratorDrawer {

		HeaderTitleAttribute atb { get { return (HeaderTitleAttribute) attribute; } }
		
		public override void OnGUI( Rect rc ) {
			try {
				HEditorGUI.HeaderTitle( rc , atb.name );
			}
			catch( ExitGUIException ) {
			}
			catch( System.Exception e ) {
				Debug.LogError( e );
			}
		}

		public override float GetHeight() {
			return 26;
		}
	}


	//[CustomPropertyDrawer( typeof( GroupAttribute ), true )]
	//class GroupAttributeDrawer : DecoratorDrawer {

	//	GroupAttribute atb { get { return (GroupAttribute) attribute; } }


	//	public override void OnGUI( Rect rc ) {

	//	}

	//	//public override float GetHeight() {
	//	//	return 26;
	//	//}
	//}

#endif
}
