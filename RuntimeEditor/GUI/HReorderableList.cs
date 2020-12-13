using HananokiRuntime.Extensions;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using PropertyHandler = UnityReflection.UnityEditorPropertyHandler;
using ScriptAttributeUtility = UnityReflection.UnityEditorScriptAttributeUtility;
using UnityEditorInternalReorderableList = UnityReflection.UnityEditorInternalReorderableList;

namespace HananokiEditor {
	public class HReorderableList {
		ReorderableList m_lst;
		UnityEditorInternalReorderableList m_lstMethod;

		SerializedObject m_serializedObject;
		SerializedProperty m_serializedProperty;

		bool isExpanded = true;

		public ReorderableList reorderableList => m_lst;

		string m_headerName = "";



		public static HReorderableList CreateInstance<T>( List<T> list, string headerName, int heightNum = 1 ) where T : class {
			var s = new HReorderableList();
			s.Create<T>( list, headerName, heightNum );
			return s;
		}


		public void Create<T>( List<T> list, string headerName, int heightNum = 1 ) where T : class {
			m_headerName = headerName;
			m_lst = new ReorderableList( list, typeof( T ) );
			m_lstMethod = new UnityEditorInternalReorderableList( m_lst );

			m_lst.drawHeaderCallback = ( rect ) => {
				var rc1 = rect;
				rc1.x += 10;

				string title = m_headerName;

				if( !isExpanded ) {
					title = $"{title}  [{list.Count}]";
				}

				isExpanded = EditorGUI.Foldout( rc1, isExpanded, title );
			};

			//	m_lst.onAddCallback = ( rect ) => {
			//		if( list.Count == 0 ) {
			//			list.Add( new T() );
			//		}
			//		else {
			//			list.Add( list[ m_lst.count - 1 ]  );
			//		}
			//	};
			m_lst.elementHeight = ( EditorGUIUtility.singleLineHeight * heightNum ) + 4;
		}



		public static HReorderableList CreateInstance( SerializedObject serializedObject, string propertyName, int heightNum = 1, string headerName = "", bool drawer = false ) {
			var s = new HReorderableList();
			s.Create( serializedObject, propertyName, heightNum, headerName, drawer );
			return s;
		}

		public void Create( SerializedObject serializedObject, string propertyName, int heightNum = 1, string headerName = "", bool drawer = false ) {
			m_serializedObject = serializedObject;
			m_serializedProperty = serializedObject.FindProperty( propertyName );
			m_headerName = headerName;
			m_lst = new ReorderableList( serializedObject, m_serializedProperty );
			m_lstMethod = new UnityEditorInternalReorderableList( m_lst );


			if( drawer ) {
				m_lst.drawElementCallback = ( rect, index, isActive, isFocused ) => {
					var rc1 = rect;
					rc1.y += 1;
					rc1.height = EditorGUIUtility.singleLineHeight;
					EditorGUI.PropertyField( rc1, serializedObject.FindProperty( propertyName + ".Array.data[" + index + "]" ) );
				};
			}
			else {
				m_lst.drawElementCallback = ( rect, index, isActive, isFocused ) => {
					var rc1 = rect;
					rc1.y += 1;
					rc1.height = EditorGUIUtility.singleLineHeight;
					var prop = serializedObject.FindProperty( propertyName + ".Array.data[" + index + "]" );

					var hander = new PropertyHandler( ScriptAttributeUtility.GetHandler( prop ) );

					try {
						if( hander.hasPropertyDrawer ) {
							//m_lst.elementHeightCallback = (index2) => {
							//	var prop2 = serializedObject.FindProperty( propertyName + ".Array.data[" + index2 + "]" );
							//	var hander2 = UnityScriptAttributeUtility.GetHandler( prop2 );
							//	return hander2.GetProperty<PropertyDrawer>( "propertyDrawer" ).GetPropertyHeight( prop2, EditorHelper.TempContent( prop2.displayName ) );
							//};
							//	m_lst.elementHeight = hander.GetProperty<PropertyDrawer>( "propertyDrawer" ).GetPropertyHeight( prop, EditorHelper.TempContent( prop.displayName ) );
							EditorGUI.PropertyField( rc1, prop );
						}
						else if( prop != null ) {
							if( prop.propertyType == SerializedPropertyType.Generic ) {
								prop.Next( true );
								int ii = 0;
								int depth = prop.depth;

								do {

									EditorGUI.PropertyField( rc1, prop );

									rc1.y += EditorGUIUtility.singleLineHeight;
									//if( prop.propertyType == SerializedPropertyType.Vector3 ) {
									//	rc1.y += EditorGUIUtility.singleLineHeight;
									//	ii++;
									//}
									ii++;
									if( prop.Next( false ) == false ) break;
								} while( depth == prop.depth );

								m_lst.elementHeight = ( EditorGUIUtility.singleLineHeight * ii ) + 4;
							}
							else {
								var cont = EditorHelper.TempContent( $"0x{index:X02}:" );
								var size = EditorStyles.label.CalcSize( cont );
								rc1.width = 40;
								EditorGUI.LabelField( rc1, cont );
								var rc2 = rect;
								rc2.x = rc1.xMax;
								rc2.width = rect.width - 40;
								rc2.y += 1;
								rc2.height = EditorGUIUtility.singleLineHeight;
								EditorGUI.PropertyField( rc2, prop, GUIContent.none );
							}
						}
					}
					catch( NullReferenceException e ) {
						Debug.LogException( e );
					}
					//if( !prop.hasChildren ) {
					//	return;
					//}
					//prop.Next( true );
					//int ii = 0;
					//int depth = prop.depth;
					//do {
					//	EditorGUI.PropertyField( rc1, prop );
					//	rc1.y += EditorGUIUtility.singleLineHeight;
					//	ii++;
					//	prop.Next( false );
					//} while( depth == prop.depth );
					//m_lst.elementHeight = ( EditorGUIUtility.singleLineHeight * ii ) + 4;
				};
			}
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
			if( m_serializedProperty == null ) {
				if( isExpanded ) {
					m_lst.DoLayoutList();
				}
				else {
					m_lst.DoListHeader( m_lstMethod );
				}
			}
			else {
				if( m_serializedProperty.isExpanded ) {
					m_lst.DoLayoutList();
				}
				else {
					m_lst.DoListHeader( m_lstMethod );
				}
			}
			if( EditorGUI.EndChangeCheck() ) {
				changed?.Invoke();
			}
		}
	}



	public static class ReorderableListExtension {
		static FieldInfo _s_Defaults;
		//static MethodInfo _DoListHeader;

		public static void DoListHeader( this ReorderableList r, UnityEditorInternalReorderableList method ) {

			//if( _DoListHeader == null ) {
			//	_DoListHeader = typeof( ReorderableList ).GetMethod( "DoListHeader", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic );
			//}

			//if( _s_Defaults.GetValue( null ) == null ) {
			if( ReorderableList.defaultBehaviours == null ) {
				if( _s_Defaults == null ) {
					_s_Defaults = R.Field<ReorderableList>( "s_Defaults" );// typeof( ReorderableList ).GetField( "s_Defaults", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic );
				}
				_s_Defaults.SetValue( null, new ReorderableList.Defaults() );
			}
			var rect = GUILayoutUtility.GetRect( 0f, 18f, GUILayout.ExpandWidth( true ) );
			method.DoListHeader( rect );
		}
	}
}

