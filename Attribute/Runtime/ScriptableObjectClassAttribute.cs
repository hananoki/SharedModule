
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
}

