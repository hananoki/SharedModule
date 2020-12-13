/// UnityEditor.ProjectBrowser : 2019.4.5f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
	public  partial class UnityEditorProjectBrowser {

		public UnityEditorProjectBrowser() {
			m_instance = UnityEditorProjectWindowUtil.GetProjectBrowserIfExists();
		}

	}
}


