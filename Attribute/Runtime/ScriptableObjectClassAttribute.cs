
using System;
using UnityEngine;

namespace Hananoki.ScriptableObjectManager {
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

