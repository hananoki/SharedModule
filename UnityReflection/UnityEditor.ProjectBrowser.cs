/// UnityEditor.ProjectBrowser : 2019.4.5f1

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
	public static partial class UnityEditorProjectBrowser {

		public static System.Collections.IList GetAllProjectBrowsers() {
			return  UnityTypes.ProjectBrowser.MethodInvoke<System.Collections.IList>( "GetAllProjectBrowsers", new object[] { } );
		}



	}
}

#endif

