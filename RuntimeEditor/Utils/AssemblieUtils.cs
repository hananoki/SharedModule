using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityReflection;

namespace HananokiEditor {
	public sealed class AssemblieUtils {

		public static IEnumerable<Type> loadedTypes => UnityEditorEditorAssemblies.loadedTypes;
		public static Assembly[] loadedAssemblies => UnityEditorEditorAssemblies.loadedAssemblies;

		public static IEnumerable<Type> SubclassesOf<T>() where T : class {
			return SubclassesOf( typeof( T ) );
		}

		public static IEnumerable<Type> SubclassesOf( Type type ) {
			return UnityEditorEditorAssemblies.SubclassesOf( type );
		}


		public static IEnumerable<MethodInfo> GetAllMethodsWithAttribute<T>() where T : Attribute {
#if UNITY_2019_2_OR_NEWER
			return UnityEditorTypeCache.GetMethodsWithAttribute<T>();
#else
			return UnityEditorEditorAssemblies.GetAllMethodsWithAttribute<T>();
#endif
		}

		public static IEnumerable<MethodInfo> GetAllMethodsWithAttribute( Type type ) {
			return UnityEditorEditorAssemblies.Internal_GetAllMethodsWithAttribute( type, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic ).Cast<MethodInfo>();
		}


		public static IEnumerable<Type> GetAllTypesWithAttribute<T>() where T : Attribute {
			return UnityEditorEditorAssemblies.GetAllTypesWithAttribute<T>();
		}

	}
}

