using System.Text.RegularExpressions;
using UnityEditor;
using System.Runtime.CompilerServices;
using System;
using HananokiRuntime.Extensions;
using UnityReflection;

namespace HananokiEditor.Extensions {
	public static partial class EditorExtensions {

		public static bool IsMissing( this SerializedProperty property ) {
			if( property.propertyType != SerializedPropertyType.ObjectReference ) return false;
			if( property.objectReferenceValue != null ) return false;

			var fileId = property.FindPropertyRelative( "m_FileID" );
			if( fileId == null ) return false;
			if( fileId.intValue == 0 ) return false;

			return true;
		}

		public static bool IsManagedReference( this SerializedProperty property ) {
#if UNITY_2019_3_OR_NEWER
			return property.propertyType == SerializedPropertyType.ManagedReference;
#else
			return false;
#endif
		}

		public static float GetPropertyHeight( this SerializedProperty property, bool includeChildren ) {
			return EditorGUI.GetPropertyHeight( property, includeChildren );
		}


		public static Type GetPropertyType( this SerializedProperty property ) {
			Type type = null;
			UnityEditorScriptAttributeUtility.GetFieldInfoFromProperty( property, ref type );
			return type;
		}

		//[Obsolete( "Use Type GetPropertyType( this SerializedProperty property ) instead" )]
		//public static string GetPropertyType( this SerializedProperty property ) {
		//	var type = property.type;
		//	var match = Regex.Match( type, @"PPtr<\$(.*?)>" );
		//	return match.Success ? match.Groups[ 1 ].Value : type;
		//}

		public static Type GetManagedReferenceFieldType( this SerializedProperty property ) {
#if UNITY_2019_3_OR_NEWER
			var ss = property.managedReferenceFieldTypename.Split( ' ' );
			return EditorHelper.GetTypeFromString( ss[ 1 ] );
#else
			return null;
#endif
		}

		public static void SetManagedReferenceValue( this SerializedProperty property, Type type ) {
#if UNITY_2019_3_OR_NEWER
			property.managedReferenceValue = type == null ? null : Activator.CreateInstance( type );
#endif
		}

		public static string GetManagedReferenceFullTypeName( this SerializedProperty property ) {
#if UNITY_2019_3_OR_NEWER
			if( property == null ) return string.Empty;
			if( property.managedReferenceFullTypename.IsEmpty() ) return string.Empty;

			return property.managedReferenceFullTypename.Split( ' ' )[ 1 ];
#else
			return string.Empty;
#endif
		}


		//public static string GetProperty( this SerializedProperty property ) {
		//	var type = typeof( SerializedProperty );
		//	object _property;
		//	_property.GetProperty<string>
		//}


		public static void Field( this SerializedProperty property ) {
			if( property == null ) {
				EditorGUILayout.HelpBox( "SerializedProperty is null", MessageType.Error );
				return;
			}
			EditorGUILayout.PropertyField( property );
		}

		//public static string GetString( this SerializedProperty property, string name ) where T : string {
		//	var p = GetChildProperty( property, name );
		//	//if( p == null ) return null;

		//	return (T) p.stringValue;
		//}

		public static void SetChildValue( this SerializedProperty property, string name, string value ) {
			var p = GetChildProperty( property, name );
			if( p == null ) return;

			p.stringValue = value;
		}
		public static void SetChildValue( this SerializedProperty property, string name, float value ) {
			var p = GetChildProperty( property, name );
			if( p == null ) return;

			p.floatValue = value;
		}
		public static void SetChildValue( this SerializedProperty property, string name, bool value ) {
			var p = GetChildProperty( property, name );
			if( p == null ) return;

			p.boolValue = value;
		}
		public static void SetChildValue( this SerializedProperty property, string name, int value ) {
			var p = GetChildProperty( property, name );
			if( p == null ) return;

			p.intValue = value;
		}
		static SerializedProperty GetChildProperty( SerializedProperty parent, string name ) {
			SerializedProperty child = parent.Copy();
			child.Next( true );
			do {
				if( child.name == name ) return child;
			}
			while( child.Next( false ) );
			return null;
		}


	}
}
