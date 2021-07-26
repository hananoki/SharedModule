using HananokiEditor.Extensions;
using HananokiRuntime;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using ScriptAttributeUtility = UnityReflection.UnityEditorScriptAttributeUtility;


namespace HananokiEditor {
	public class HEditor : Editor {
		Dictionary<string, HReorderableList> _reorderableLists;
		Dictionary<string, Editor> _editorLists;
		Dictionary<string, bool> _foldLists;

		Type[] m_managedReferenceTypes;
		GUIContent[] m_managedReferencePopup;
		string[] m_managedReferenceFullnames;

		void OnEnable() {
			//_reorderableLists = new Dictionary<string, HReorderableList>();
			//_editorLists = new Dictionary<string, Editor>();
			//_foldLists = new Dictionary<string, bool>();

			OnEnableOveride();
		}

		protected virtual void OnEnableOveride() {
		}

		protected virtual void OnDestroy() {
			if( _reorderableLists != null ) {
				_reorderableLists.Clear();
				_reorderableLists = null;
			}
			if( _editorLists != null ) {
				_editorLists.Clear();
				_editorLists = null;
			}
			if( _foldLists != null ) {
				_foldLists.Clear();
				_foldLists = null;
			}
		}

		public override void OnInspectorGUI() {
			EasyButtonsEditorExtensions.DrawEasyButtons( this );

			DrawPropertys();
		}

		bool GetHas( List<PropertyAttribute> propAttr, Type prop ) {
			if( propAttr == null ) return false;
			foreach( var p in propAttr ) {
				var t = p.GetType();
				if( t == prop ) {
					return true;
				}
				else if( p.GetType().IsSubclassOf( prop ) ) {
					return true;
				}
			}
			return false;
		}

		T Get<T>( List<PropertyAttribute> propAttr ) where T : PropertyAttribute {
			if( propAttr == null ) return null;
			foreach( var p in propAttr ) {
				var t1 = p.GetType();
				if( t1 == typeof( T ) ) {
					return (T) p;
				}
				else if( p.GetType().IsSubclassOf( typeof( T ) ) ) {
					return (T) p;
				}
			}
			return null;
		}


		public void DrawPropertys() {
			if( _reorderableLists == null ) _reorderableLists = new Dictionary<string, HReorderableList>();
			if( _editorLists == null ) _editorLists = new Dictionary<string, Editor>();
			if( _foldLists == null ) _foldLists = new Dictionary<string, bool>();

			using( new SerializedObjectScope( serializedObject ) ) {
				var it = serializedObject.GetIterator();

				bool fold = true;
				if( !it.NextVisible( true ) ) return;

				bool mono = it.name.Equals( "m_Script" );// && it.type.Equals( "PPtr<MonoScript>" ) && it.propertyType == SerializedPropertyType.ObjectReference && it.propertyPath.Equals( "m_Script" );

				if( !mono ) {
					_Draw( it, ref fold );
				}
				if( !it.NextVisible( false ) ) return;

				do {
					_Draw( it, ref fold );
				} while( it.NextVisible( false ) );


			}
		}


		void _Draw( SerializedProperty it, ref bool fold ) {
			Type type = null;
			var field = ScriptAttributeUtility.GetFieldInfoFromProperty( it, ref type );
			var attrs = ScriptAttributeUtility.GetFieldAttributes( field );
			//Debug.Log(it.displayName);

			if( GetHas( attrs, typeof( GroupAttribute ) ) ) {
				if( !_foldLists.ContainsKey( it.displayName ) ) {
					_foldLists.Add( it.displayName, true );
				}


				var atb = Get<GroupAttribute>( attrs );
				var rect = GUILayoutUtility.GetRect( EditorHelper.TempContent( it.displayName ), EditorStyles.helpBox );
				if( Event.current.type == EventType.Repaint ) {
					var rect2 = rect;
					rect2.x -= 16;
					rect2.width += 16;
					EditorStyles.helpBox.Draw( rect2, false, false, false, false );
				}
				var sss = "";
				if( atb.prefix ) sss = "Group - ";
				sss += atb.name;
				_foldLists[ it.displayName ] = EditorGUI.Foldout( rect, _foldLists[ it.displayName ], sss, true );

				fold = _foldLists[ it.displayName ];
				//EditorGUILayout.LabelField( it.displayName );
				//if( _foldLists[ it.displayName ] ) {
				//	EditorGUILayout.PropertyField( it, true );
				//}
				//if( fold  ) {
				//	EditorGUI.indentLevel++;
				//}
				//else {
				//	EditorGUI.indentLevel--;
				//}
			}
			if( fold == false ) {
				return;
			}
#if false
					if( it.isArray && type != typeof( string ) ) {
						HReorderableList lst = null;
						_reorderableLists.TryGetValue( it.displayName, out lst );
						if( lst == null ) {
							lst = HReorderableList.CreateInstance( serializedObject, it.name );
							_reorderableLists.Add( it.displayName, lst );
						}
						//EditorGUILayout.LabelField( it.displayName );
						lst.DoLayoutList();
					}
					//else if( it.propertyType == SerializedPropertyType.Vector3 ) {
					//}
					else
#endif
			//if( GetHas( attrs, typeof( PropertyAttribute ) ) {
			//	var hander = UnityScriptAttributeUtility.GetHandler( it );
			//	hander.MethodInvoke<bool>( "OnGUI", new object[] { } );
			//}
			//OnGUI( Rect position, SerializedProperty property, GUIContent label, bool includeChildren )
#if UNITY_2019_3_OR_NEWER
			if( it.propertyType == SerializedPropertyType.ManagedReference ) {
				DrawSerializeReference( it  );
			}
			else
#endif
			if( it.propertyType == SerializedPropertyType.ObjectReference && !GetHas( attrs, typeof( PropertyAttribute ) ) ) {
				if( it.objectReferenceValue == null ) {
					//EditorGUILayout.PropertyField( it, true );
					//Debug.Log( it.GetTypeReflection().Name );
					//if( it.GetTypeReflection() == typeof( Sprite ) ) {
					//	it.objectReferenceValue = EditorGUILayout.ObjectField( it.displayName, it.objectReferenceValue,typeof( Sprite), false );
					//}
					//else {
					//	EditorGUILayout.PropertyField( it, true );
					//}
					ScopeHorizontal.Begin();
					it.objectReferenceValue = EditorGUILayout.ObjectField( it.displayName, it.objectReferenceValue, type, true );
					if( HEditorGUILayout.IconButton( EditorIcon.plus, 3 ) ) {
						var so = CreateInstance( type );
						var path = $"Assets/New {type.Name}.asset".GenerateUniqueAssetPath();
						AssetDatabase.CreateAsset( so, path );
						AssetDatabase.Refresh();
						it.objectReferenceValue = so;
					}
					ScopeHorizontal.End();
					//it.objectReferenceValue = EditorGUILayout.ObjectField( it.displayName, it.objectReferenceValue, it.GetTypeReflection(), true );
					//it.objectReferenceValue=EditorGUILayout.ObjectField( it.displayName, it.objectReferenceValue, it.GetTypeReflection(), true, GUILayout.Height() );
				}
				else if( it.objectReferenceValue.GetType() == typeof( Animator ) ) {
					HEditorGUI.PropertyField( it,
						EditorIcon.unityeditor_animationwindow, () => { EditorWindowUtils.Find( UnityTypes.UnityEditor_AnimationWindow ); },
						EditorIcon.unityeditor_graphs_animatorcontrollertool, () => { EditorWindowUtils.Find( UnityTypes.UnityEditor_Graphs_AnimatorControllerTool ); } );
				}
				else if( it.objectReferenceValue.GetType().IsSubclassOf( typeof( ScriptableObject ) ) ) {
					Editor ed = null;
					if( _editorLists == null ) return;
					_editorLists.TryGetValue( it.displayName, out ed );
					if( ed == null ) {
						ed = Editor.CreateEditor( it.objectReferenceValue );
						_editorLists.Add( it.displayName, ed );
					}

					var h = EditorStyles.objectField.CalcHeight( GUIContent.none, 10 );
					EditorGUILayout.PropertyField( it, EditorHelper.TempContent( "  " ), true );
					var r = GUILayoutUtility.GetLastRect();
					r.y = r.yMax - h;
					r.height = h;
					it.isExpanded = EditorGUI.Foldout( r, it.isExpanded, EditorHelper.TempContent( it.displayName ), true );
					if( it.isExpanded ) {
						try {
							EditorGUI.indentLevel++;
							EditorGUIUtility.hierarchyMode = false;
							ScopeVertical.Begin( /*EditorStyles.helpBox*/ );
							ed.OnInspectorGUI();
							//GUILayout.FlexibleSpace();
							ScopeVertical.End();
							EditorGUIUtility.hierarchyMode = true;
							EditorGUI.indentLevel--;
						}
						catch( Exception e ) {
							Debug.LogException( e );
						}
					}
				}
				else {
					//HGUIScope.Horizontal(_);
					//void _() {
					//it.objectReferenceValue = EditorGUILayout.ObjectField( it.displayName, it.objectReferenceValue, type, true );
					EditorGUILayout.PropertyField( it, EditorHelper.TempContent( L10n.Tr( it.displayName ) ), true );
					//	GUILayout.Button("aaaa");
					//}
				}
			}
			else {
				//Debug.Log( type .Name);
				EditorGUILayout.PropertyField( it, EditorHelper.TempContent( L10n.Tr( it.displayName ) ), true );
			}
		}

#if UNITY_2019_3_OR_NEWER
		void DrawSerializeReference( SerializedProperty property ) {
			var cont = EditorHelper.TempContent( L10n.Tr( property.displayName ) );
			var rect = GUILayoutUtility.GetRect( cont , EditorStyles.numberField, GUILayout.Height( property.GetPropertyHeight( true ) ) );
			
			var rectR = EditorGUI.PrefixLabel( rect, cont );
			rectR.height = EditorGUIUtility.singleLineHeight;

			if( m_managedReferenceTypes == null ) {
				InitSubClass( property );
			}

			ScopeChange.Begin();
			var index = Array.IndexOf( m_managedReferenceFullnames, property.managedReferenceFullTypename );
			index = EditorGUI.Popup( rectR, index, m_managedReferencePopup );
			if( ScopeChange.End() ) {
				property.SetManagedReferenceValue( m_managedReferenceTypes[ index ] );
			}

			//GUI.Button( rectR , "DrawSerializeReference" );
			//HEditorGUI.DrawDebugRect( rectR );
			;
			EditorGUI.PropertyField( rect, property, GUIContent.none, true );

			void InitSubClass( SerializedProperty p ) {
				var lst = AssemblieUtils.SubclassesOf( property.GetManagedReferenceFieldType() ).ToList();
				lst.Insert( 0, null );
				m_managedReferenceTypes = lst.ToArray();
				m_managedReferencePopup = m_managedReferenceTypes.Select( t => t == null ? new GUIContent( "None", EditorIcon.warning ) : new GUIContent( t.ToString(), EditorIcon.icons_processed_boo_script_icon_asset ) ).ToArray();
				m_managedReferenceFullnames = m_managedReferenceTypes.Select( t => t == null ? "" : $"{t.Assembly.ToString().Split( ',' )[ 0 ]} {t.FullName}" ).ToArray();
			}
		}
#endif

	}

}

