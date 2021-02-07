
using System;
using UnityEngine;

namespace HananokiRuntime {
	//[AttributeUsage( AttributeTargets.Class )]
	//public class ScriptableObjectClassAttribute : PropertyAttribute {
	//	public string category;
	//	public ScriptableObjectClassAttribute( string category = "" ) {
	//		this.category = category;
	//	}
	//}


	using System;



	[AttributeUsage( AttributeTargets.Class )]
	public class UtilityWindowAttribute : PropertyAttribute {
		public UtilityWindowAttribute() {
		}
	}

//#if UNITY_EDITOR
	[AttributeUsage( AttributeTargets.Class )]
	public class TypeIDAttribute : Attribute {
		public int id;
		public TypeIDAttribute( int id ) { this.id = id; }
	}
//#endif
}

