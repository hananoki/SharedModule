using System;

namespace HananokiRuntime {
	[AttributeUsage( AttributeTargets.Method, Inherited = true, AllowMultiple = false )]
	public sealed class InspectorGUIAttribute : Attribute {

		public InspectorGUIAttribute() {
		}

	}
}
