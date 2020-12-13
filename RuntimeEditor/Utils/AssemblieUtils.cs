using System;
using System.Collections.Generic;
using System.Reflection;
using UnityReflection;

namespace HananokiEditor {
	public sealed class AssemblieUtils {

		public static IEnumerable<Type> loadedTypes => UnityEditorEditorAssemblies.loadedTypes;
		public static Assembly[] loadedAssemblies => UnityEditorEditorAssemblies.loadedAssemblies;

		public static IEnumerable<MethodInfo> GetAllMethodsWithAttribute<T>() where T : Attribute {
#if UNITY_2019_2_OR_NEWER
				return UnityEditorTypeCache.GetMethodsWithAttribute<T>();
#else
			return UnityEditorEditorAssemblies.GetAllMethodsWithAttribute<T>();
#endif
		}
		public static IEnumerable<Type> GetAllTypesWithAttribute<T>() where T : Attribute {
			return UnityEditorEditorAssemblies.GetAllTypesWithAttribute<T>();
		}
			
	}
}

