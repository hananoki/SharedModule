using System;


namespace HananokiEditor {

	[AttributeUsage( AttributeTargets.Method )]
	public class HananokiEditorLocalizeRegister : Attribute { }

	[AttributeUsage( AttributeTargets.Method )]
	public class HananokiSettingsRegister : Attribute { }

	//[AttributeUsage( AttributeTargets.Method )]
	//public class HananokiDebugMonitor : Attribute { }

	[AttributeUsage( AttributeTargets.Method )]
	public class HananokiEditorMDViewerRegister : Attribute { }


	[AttributeUsage( AttributeTargets.Method )]
	public class Hananoki_OnOpenAsset : Attribute {
		public Type type;
		public Type subClass;
		public Hananoki_OnOpenAsset( Type type, Type subClass = null ) {
			this.type = type;
			this.subClass = subClass;
		}

		public string GetName() {
			var s1 = type != null ? type.Name : string.Empty;
			var s2 = subClass != null ? subClass.Name : string.Empty;
			return $"{s1},{s2}";
		}
	}


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


}


namespace HananokiRuntime {


}
