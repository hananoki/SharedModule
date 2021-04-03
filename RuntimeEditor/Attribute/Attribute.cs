using System;
using UnityEngine;


namespace HananokiEditor {

	[AttributeUsage( AttributeTargets.Method )]
	public class HananokiEditorLocalizeRegister : Attribute { }

	[AttributeUsage( AttributeTargets.Method )]
	public class HananokiSettingsRegister : Attribute { }

	[AttributeUsage( AttributeTargets.Method )]
	public class HananokiDebugMonitor : Attribute { }


	#region SceneViewTools

	[AttributeUsage( AttributeTargets.Method )]
	public class Hananoki_SceneView_ComponentButton : Attribute {
		public Type type;
		public Hananoki_SceneView_ComponentButton( Type t ) {
			type = t;
		}
		public Hananoki_SceneView_ComponentButton( string t ) {
			type = EditorHelper.GetTypeFromString( t );
		}
	}

	[AttributeUsage( AttributeTargets.Class )]
	public class Hananoki_SceneView_ComponentTool : Attribute {
		public Type type;
		public Hananoki_SceneView_ComponentTool( Type t ) {
			type = t;
		}
	}

	#endregion


	#region CustomHierarchy

	[AttributeUsage( AttributeTargets.Class )]
	public class Hananoki_Hierarchy_ComponentTool : Attribute {
		public Type type;
		public Hananoki_Hierarchy_ComponentTool( Type t ) {
			type = t;
		}
		public Hananoki_Hierarchy_ComponentTool( string t ) {
			type = EditorHelper.GetTypeFromString( t );
		}
	}

	#endregion


	#region CustomHierarchy

	//[AttributeUsage( AttributeTargets.Class )]
	public class ScriptableObjectSelectorAttribute : PropertyAttribute {
		public bool disablePrefixLabel;
		public ScriptableObjectSelectorAttribute( bool disablePrefixLabel = false ) {
			this.disablePrefixLabel = disablePrefixLabel;
		}
	}

	#endregion
}


namespace HananokiRuntime {


}
