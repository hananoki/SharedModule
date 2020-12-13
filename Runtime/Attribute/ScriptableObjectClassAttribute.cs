
using System;
using UnityEngine;

namespace HananokiRuntime {
	[AttributeUsage( AttributeTargets.Class )]
	public class ScriptableObjectClassAttribute : PropertyAttribute {
		public string category;
		public ScriptableObjectClassAttribute( string category = "" ) {
			this.category = category;
		}
	}


	[AttributeUsage( AttributeTargets.Class )]
	public class UtilityWindowAttribute : PropertyAttribute {
		public UtilityWindowAttribute() {
		}
	}
}

