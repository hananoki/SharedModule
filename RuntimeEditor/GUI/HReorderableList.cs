using System;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
using System.Reflection;
using Hananoki.Extensions;
using System.Collections.Generic;
using Hananoki.Reflection;

namespace Hananoki {
	public class HReorderableList {
		ReorderableList m_lst;

		SerializedObject m_serializedObject;
		SerializedProperty m_serializedProperty;


		public ReorderableList reorderableList => m_lst;

		string m_headerName = "";

		//public static HReorderableList CreateInstance() {
		//}

		public static HReorderableList CreateInstance( SerializedObject serializedObject, string propertyName, int heightNum = 1, string headerName = "" ) {
			var s = new HReorderableList();
			s.Create( serializedObject, propertyName, heightNum, headerName );
			return s;
		}

		//public void Create<T>( List<T> list, int heightNum = 1, string headerName = "" ) where T : class, new() {
		//	m_headerName = headerName;
		//	m_lst = new ReorderableList( list, typeof( T ) );

		//	m_lst.drawHeaderCallback = ( rect ) => {
		//		EditorGUI.LabelField( rect, headerName );
		//	};

		//	m_lst.onAddCallback = ( rect ) => {
		//		if( list.Count == 0 ) {
		//			list.Add( new T() );
		//		}
		//		else {
		//			list.Add( list[ m_lst.count - 1 ]  );
		//		}
		//	};
		//}



		public void Create( SerializedObject serializedObject, string propertyName, int heightNum = 1, string headerName = "" ) {
			m_serializedObject = serializedObject;
			m_serializedProperty = serializedObject.FindProperty( propertyName );
			m_headerName = headerName;
			m_lst = new ReorderableList( serializedObject, serializedObject.FindProperty( propertyName ) );

			m_lst.drawElementCallback = ( rect, index, isActive, isFocused ) => {
				var rc1 = rect;
				rc1.y += 1;
				rc1.height = EditorGUIUtility.singleLineHeight;
				EditorGUI.PropertyField( rc1, serializedObject.FindProperty( propertyName + ".Array.data[" + index + "]" ) );
			};
			m_lst.drawHeaderCallback = ( rect ) => {
				var rc1 = rect;
				rc1.x += 10;

				string title;
				if( m_headerName.IsEmpty() ) {
					title = $"{m_serializedProperty.displayName}";
				}
				else {
					title = m_headerName;
				}

				if( !m_serializedProperty.isExpanded ) {
					title = $"{title}  [{m_serializedProperty.arraySize}]";
				}

				m_serializedProperty.isExpanded = EditorGUI.Foldout( rc1, m_serializedProperty.isExpanded, title );
			};
			m_lst.elementHeight = ( EditorGUIUtility.singleLineHeight * heightNum ) + 4;
		}


		public void DoLayoutList( Action changed = null ) {
			EditorGUI.BeginChangeCheck();
			if( m_serializedProperty.isExpanded ) {
				m_lst.DoLayoutList();
			}
			else {
				m_lst.DoListHeader();
			}
			if( EditorGUI.EndChangeCheck() ) {
				changed?.Invoke();
			}
		}
	}



	public static class ReorderableListExtension {
		static FieldInfo _s_Defaults;
		static MethodInfo _DoListHeader;

		public static void DoListHeader( this ReorderableList r ) {
			if( _s_Defaults == null ) {
				_s_Defaults = R.Field<ReorderableList>( "s_Defaults" );// typeof( ReorderableList ).GetField( "s_Defaults", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic );
			}
			if( _DoListHeader == null ) {
				_DoListHeader = typeof( ReorderableList ).GetMethod( "DoListHeader", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic );
			}

			if( _s_Defaults.GetValue( null ) == null ) {
				_s_Defaults.SetValue( null, new ReorderableList.Defaults() );
			}
			var rect = GUILayoutUtility.GetRect( 0f, 18f, GUILayout.ExpandWidth( true ) );
			_DoListHeader.Invoke( r, new object[] { rect } );
		}
	}
}

#endif
