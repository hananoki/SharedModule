

using System;

namespace HananokiEditor {

	[AttributeUsage( AttributeTargets.Method )]
	public class HananokiEditorLocalizeRegister : Attribute { }



	[AttributeUsage( AttributeTargets.Method )]
	public class HananokiSettingsRegister : Attribute { }
}

