

using System;



namespace HananokiEditor {

	[AttributeUsage( AttributeTargets.Method )]
	public class HananokiEditorLocalizeRegister : Attribute { }

	[AttributeUsage( AttributeTargets.Method )]
	public class HananokiSettingsRegister : Attribute { }

	[AttributeUsage( AttributeTargets.Method )]
	public class HananokiDebugMonitor : Attribute { }



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
}

namespace HananokiRuntime {

}
