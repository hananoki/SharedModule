//#pragma warning disable 618
#if UNITY_EDITOR

using Hananoki.Extensions;
using Hananoki.Reflection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

using static System.Convert;
using UnityObject = UnityEngine.Object;

namespace Hananoki {

	public enum EventMouseButton {
		L, R, M,
	}




	public static class EditorHelper {

		/// <summary>
		/// Verify whether it can be converted to the specified component.
		/// </summary>
		public static bool CanConvertTo<T>( UnityEngine.Object context )
		 where T : MonoBehaviour {
			return context && context.GetType() != typeof( T );
		}


		/// <summary>
		/// Convert to the specified component.
		/// </summary>
		public static void ConvertTo<T>( UnityEngine.Object context ) where T : MonoBehaviour {
			var target = context as MonoBehaviour;
			var so = new SerializedObject( target );
			so.Update();

			bool oldEnable = target.enabled;
			target.enabled = false;

			// Find MonoScript of the specified component.
			foreach( var script in Resources.FindObjectsOfTypeAll<MonoScript>() ) {
				if( script.GetClass() != typeof( T ) )
					continue;

				// Set 'm_Script' to convert.
				so.FindProperty( "m_Script" ).objectReferenceValue = script;
				so.ApplyModifiedProperties();
				break;
			}

		 ( so.targetObject as MonoBehaviour ).enabled = oldEnable;
		}


		public static void SetGameObjectName<T>( T p, string prefix = "" ) where T : Component {
			if( p.GetType() == UnityTypes.UnityEngine_UI_Image ) {
				var sprite = p.GetProperty<Sprite>( "sprite" );
				p.gameObject.name = $"{prefix}{sprite.name}";
			}
			else if( p.GetType() == UnityTypes.UnityEngine_UI_RawImage ) {
				var texture = p.GetProperty<Texture>( "texture" );
				p.gameObject.name = $"{prefix}{texture.name}";
			}
			else if( p.GetType().IsSubclassOf( UnityTypes.TMPro_TMP_Text )  ) {
				var text = p.GetProperty<string>( "text" ); ;
				Regex re = new Regex( "<.*?>", RegexOptions.Singleline );
				text = re.Replace( text, "" );
				text = text.Replace( "\n", " " );
				text = $"{prefix} {text}";
				text = text.TrimStart();
				p.gameObject.name = text;
			}
		}

		public static void MenuCopyPos( SerializedProperty prop ) {
			Vector3 v;
			if( prop.propertyType == SerializedPropertyType.Quaternion ) {
				v = prop.quaternionValue.eulerAngles;
			}
			else {
				v = prop.vector3Value;
			}
			GUIUtility.systemCopyBuffer = string.Format( "{0}, {1}, {2}", v.x, v.y, v.z );
		}

		public static void MenuPastePos( SerializedProperty prop ) {

			var mm = Regex.Matches( GUIUtility.systemCopyBuffer, @"(-?[0-9]+\.*[0-9]*)[\s,]+(-?[0-9]+\.*[0-9]*)[\s,]+(-?[0-9]+\.*[0-9]*)" );
			if( 0 < mm.Count ) {
				if( mm[ 0 ].Groups.Count == 4 ) {
					var a = float.Parse( mm[ 0 ].Groups[ 1 ].Value );
					var b = float.Parse( mm[ 0 ].Groups[ 2 ].Value );
					var c = float.Parse( mm[ 0 ].Groups[ 3 ].Value );

					prop.serializedObject.Update();
					if( prop.propertyType == SerializedPropertyType.Quaternion ) {
						prop.quaternionValue = Quaternion.Euler( a, b, c );
						//m_positionProperty.vector3Value = new Vector3( a, b, c );
					}
					else {
						prop.vector3Value = new Vector3( a, b, c );
					}
					prop.serializedObject.ApplyModifiedProperties();
				}
			}
			else {
				Debug.LogWarning( "transform is parse failed" );
			}
		}


		public static Type[] GetInheritType( Type type ) {
			var types = new List<Type>();
			EditorHelper.TravaseAllType( cb );
			void cb( Type t ) {
				if( !t.IsSubclassOf( type ) ) return;
				types.Add( t );
			}
			return types.ToArray();
		}

		public static void TravaseAllType( Action<Type> action ) {
			Debug.Assert( action != null, "EditorHelper.TravaseAllType is NULL" );
			if( action == null ) return;

			float fval = 0.00f;

			var assemblys = AppDomain.CurrentDomain.GetAssemblies();

			foreach( Assembly assembly in assemblys ) {
				float fmax = 1.00f / assemblys.Length;
				EditorUtility.DisplayProgressBar( "TravaseAllType", assembly.FullName, fval );

				try {
					var types = assembly.GetTypes();
					float fadd = fmax / types.Length;

					foreach( Type t in types ) {
						try {
							action.Invoke( t );
						}
						catch( Exception ee ) {
							Debug.LogException( ee );
						}
					}
				}
				catch( ReflectionTypeLoadException ) {
				}
				catch( Exception ee ) {
					Debug.LogException( ee );
				}
			}
			EditorUtility.ClearProgressBar();
		}

		public static EditorWindow GetWindow( Type windowT, params Type[] desiredDockNextTo ) {
			return GetWindow( windowT, null, true, desiredDockNextTo );
		}

		public static EditorWindow GetWindow( Type windowT, string title, bool focus, params Type[] desiredDockNextTo ) {
			var array = Resources.FindObjectsOfTypeAll( windowT ) as EditorWindow[];
			EditorWindow t = ( array.Length != 0 ) ? array[ 0 ] : default;

			EditorWindow result;
			if( t != null ) {
				if( focus ) {
					t.Focus();
				}
				result = t;
			}
			else {
				result = CreateWindow( windowT, title, desiredDockNextTo );
			}
			return result;
		}

		public static EditorWindow CreateWindow( Type windowT, string title, params Type[] desiredDockNextTo ) {
			EditorWindow t = (EditorWindow) ScriptableObject.CreateInstance( windowT );
			bool flag = title != null;
			if( flag ) {
				t.titleContent = new GUIContent( title );
			}
			EditorWindow result;
			for( int i = 0; i < desiredDockNextTo.Length; i++ ) {
				Type desired = desiredDockNextTo[ i ];
				var windows = (Array) R.Property( "windows", "UnityEditor.ContainerWindow" ).GetValue( null );
				//var a = windows.GetType();
				foreach( var containerWindow in windows ) {

					var rootView = R.Property( "rootView", "UnityEditor.ContainerWindow" ).GetValue( containerWindow );
					var allChildren = (Array) R.Property( "allChildren", "UnityEditor.View" ).GetValue( rootView );
					foreach( var view in allChildren ) {

						if( view == null ) continue;
						if( view.GetType().Name != "DockArea" ) continue;

						var arg_B9_0 = (IEnumerable<EditorWindow>) R.Field( "m_Panes", "UnityEditor.DockArea" ).GetValue( view );
						if( arg_B9_0 == null ) continue;

						bool flag3 = arg_B9_0.Any( x => x.GetType() == desired );
						if( flag3 ) {
							view.MethodInvoke( "AddTab", new Type[] { typeof( EditorWindow ), typeof( bool ) }, new object[] { t, true } );
							result = t;
							return result;
						}
						//Debug.Log( arg_B9_0.ToString() );
					}
				}
			}
			t.Show();
			result = t;
			return result;
		}


		public static void MarkSceneDirty() {
			EditorSceneManager.MarkAllScenesDirty();
		}

		public static void EditScript( Type t ) {
			var a = ScriptableObject.CreateInstance( t );
			AssetDatabase.OpenAsset( MonoScript.FromScriptableObject( a ) );
			UnityObject.DestroyImmediate( a );
		}

		public static void EditScript( ScriptableObject obj ) {
			AssetDatabase.OpenAsset( MonoScript.FromScriptableObject( obj ) );
		}

		public static void EditScript( MonoBehaviour obj ) {
			AssetDatabase.OpenAsset( MonoScript.FromMonoBehaviour( obj ) );
		}

		public static void PingObject( Type t ) {
			var a = ScriptableObject.CreateInstance( t );
			PingObject( MonoScript.FromScriptableObject( a ) );
			UnityObject.DestroyImmediate( a );
		}

		public static void PingObject( UnityObject obj ) {
			EditorGUIUtility.PingObject( obj );
		}
		public static void PingObject( string path ) {
			PingObject( AssetDatabase.LoadAssetAtPath<UnityObject>( path ) );
		}

		public static void PingAndSelectObject( UnityObject obj ) {
			EditorGUIUtility.PingObject( obj );
			Selection.activeObject = obj;
		}

		public static bool IsDefine( string symbol ) {
			foreach( var s in EditorUserBuildSettings.activeScriptCompilationDefines ) {
				if( symbol == s ) return true;
			}
			return false;

		}

		public static bool IsWait() {
			return EditorApplication.isPlaying || Application.isPlaying || EditorApplication.isCompiling;
		}

		public static Texture2D LoadIcon( string name ) {
			Texture2D icon = null;

			try {
				icon = EditorGUIUtility.FindTexture( name ) as Texture2D;
				if( icon != null ) return icon;
			}
			catch( Exception ) {
			}


			try {
				icon = EditorGUIUtility.Load( "icons/" + name + ".png" ) as Texture2D;
				if( icon != null ) return icon;
			}
			catch( Exception ) {
			}


			var a = AssetDatabase.FindAssets( "Icons" );
			foreach( var b in a ) {
				var v = AssetDatabase.GUIDToAssetPath( b );
				var vv = Path.GetExtension( v );
				if( !string.IsNullOrEmpty( vv ) ) continue;

				icon = AssetDatabase.LoadAssetAtPath<Texture2D>( v + "/" + name + ".png" );
				if( icon != null ) return icon;
			}


			{
				var lst = Resources.FindObjectsOfTypeAll<Texture2D>().Where( x => x.name.Contains( name ) ).ToArray();
				if( 0 < lst.Length ) {
					icon = lst[ 0 ];
					if( icon != null ) return icon;
				}
			}


			return icon;
		}




		public static bool HasMenuItem( string menuName ) {
			var menuTop = menuName.Split( '/' )[ 0 ];
			var ss = Unsupported.GetSubmenus( menuTop );
			foreach( var s in ss ) {
				if( s == menuName ) return true;
			}
			return false;
		}

		public static void TraverseHierarchyObjects( Action<GameObject> func ) {
			foreach( GameObject obj in Resources.FindObjectsOfTypeAll( typeof( GameObject ) ) ) {
				string path = AssetDatabase.GetAssetOrScenePath( obj );
				if( path.Contains( ".unity" ) ) {
					func( obj );
				}
			}
		}

		public static List<string> IsMissingProperty( GameObject gameObject ) {
			var lst = new List<string>();
			foreach( var p in gameObject.GetComponents<Component>() ) {
				if( p == null ) {
					//b = true;
					continue;
				}

				// SerializedObjectを通してアセットのプロパティを取得する
				SerializedObject sobj = new SerializedObject( p );
				SerializedProperty property = sobj.GetIterator();


				while( property.Next( true ) ) {
					// プロパティの種類がオブジェクト（アセット）への参照で、  
					// その参照がnullなのにもかかわらず、参照先インスタンスIDが0でないものはMissing状態！  
					//Debug.Log( $"{property.displayName}" );
					//if( p.GetType().Name == "StateGame" && property.propertyType == SerializedPropertyType.ArraySize ) {
					//	Debug.Log( $"{property.propertyType.ToString()}" );
					////	Debug.Log( $"{property.objectReferenceValue}" );
					////	Debug.Log( $"{property.objectReferenceInstanceIDValue}" );
					//}
					if( property.propertyType == SerializedPropertyType.ObjectReference &&
							property.objectReferenceValue == null &&
							property.objectReferenceInstanceIDValue != 0 ) {

						// Missing状態のプロパティリストに追加する  
						//missingList.Add( new AssetParameterData() {
						//	obj = obj,
						//	path = path,
						//	property = property
						//} );
						//Debug.Log( $"obj: {p.name}: property: {property.displayName}" );
						//b = true;PPtr<$SpriteRenderer>
						//property.FindPropertyRelative
						var mm = Regex.Matches( property.type, @"PPtr<\$?(.*)>" );
						lst.Add( $"[{p.GetType().Name}:{property.propertyPath}:{mm[ 0 ].Groups[ 1 ].Value}]" );
					}
				}
			}


			return lst;
		}

		public static bool IsMissingComponent( GameObject gameObject ) {
			foreach( var p in gameObject.GetComponents<Component>() ) {
				if( p == null ) return true;
			}
			return false;
		}

		public static void DeleteMissing( GameObject gameObject ) {
			var components = gameObject.GetComponents<Component>();

			// Create a serialized object so that we can edit the component list
			var serializedObject = new SerializedObject( gameObject );
			// Find the component list property
			var prop = serializedObject.FindProperty( "m_Component" );

			// Track how many components we've removed
			int r = 0;

			// Iterate over all components
			for( int j = 0; j < components.Length; j++ ) {
				// Check if the ref is null
				if( components[ j ] == null ) {
					// If so, remove from the serialized component array
					prop.DeleteArrayElementAtIndex( j - r );
					// Increment removed count
					r++;
				}
			}

			// Apply our changes to the game object
			serializedObject.ApplyModifiedProperties();
		}


		/// <summary>
		/// 変更点があるかチェックしてからシーンを開きます
		/// </summary>
		/// <param name="sceneName"></param>
		public static void OpenScene( string sceneName ) {
			if( EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo() ) {
				EditorSceneManager.OpenScene( sceneName );
			}
		}
		public static void OpenScene( object obj ) {
			OpenScene( (string) obj );
		}


		public static void Dirty( UnityObject obj, string name, Action ff ) {
			Undo.RecordObject( obj, name );
			ff?.Invoke();
			EditorUtility.SetDirty( obj );
		}

		public static void Dirty( UnityObject obj, Action ff ) => Dirty( obj, $"{obj.name} Changed", ff );


		public static void Dirty<T>( UnityObject[] objs, Action<T> ff ) where T : UnityObject {
			Undo.RecordObjects( objs, $"{objs.ToArray()} Changed" );
			foreach( var p in objs ) {
				ff?.Invoke( (T) p );
				EditorUtility.SetDirty( p );
			}
		}

		public static byte[] ReadBinaryFile( string path ) {
			FileStream fileStream = new FileStream( path, FileMode.Open, FileAccess.Read );
			BinaryReader bin = new BinaryReader( fileStream );
			byte[] values = bin.ReadBytes( (int) bin.BaseStream.Length );

			bin.Close();

			return values;
		}

		public static Texture ReadTexture( string path, int width, int height ) {
			try {
				if( !File.Exists( path ) ) return null;
				byte[] readBinary = ReadBinaryFile( path );

				Texture2D texture = new Texture2D( width, height );
				texture.LoadImage( readBinary );

				return texture;
			}
			catch( Exception ) {
				return null;
			}
		}


		public static void DrawTexture( Rect r, Texture2D tex, bool useDropshadow, GUIStyle style ) {
			if( !( tex == null ) ) {
				float num = (float) tex.width;
				float num2 = (float) tex.height;
				if( num >= num2 && num > r.width ) {
					num2 = num2 * r.width / num;
					num = r.width;
				}
				else {
					if( num2 > num && num2 > r.height ) {
						num = num * r.height / num2;
						num2 = r.height;
					}
				}
				float x = r.x + Mathf.Round( ( r.width - num ) / 2f );
				float y = r.y + Mathf.Round( ( r.height - num2 ) / 2f );
				r = new Rect( x, y, num, num2 );
				if( useDropshadow && Event.current.type == EventType.Repaint ) {
					Rect position = new RectOffset( 1, 1, 1, 1 ).Remove( style.border.Add( r ) );
					style.Draw( position, GUIContent.none, false, false, false, false );
				}
				//GUI.DrawTexture( r, tex, ScaleMode.ScaleToFit, true );
				GUI.DrawTexture( r, tex, ScaleMode.ScaleToFit );
			}
		}


		#region TempContent

		static GUIContent s_Text = new GUIContent();
		public static GUIContent TempContent( string t ) {
			s_Text.text = t;
			return s_Text;
		}

		static GUIContent s_TextTool = new GUIContent();
		public static GUIContent TempContent( string t, string t2 ) {
			s_TextTool.text = t;
			s_TextTool.tooltip = t2;
			return s_TextTool;
		}

		static GUIContent s_TextImage = new GUIContent();
		public static GUIContent TempContent( string t, Texture i ) {
			s_TextImage.image = i;
			s_TextImage.text = t;
			s_TextImage.tooltip = null;
			return s_TextImage;
		}

		static GUIContent s_ContentImage = new GUIContent();
		public static GUIContent TempContent( Texture image, string tooltip = "" ) {
			s_ContentImage.image = image;
			s_ContentImage.tooltip = tooltip;
			return s_ContentImage;
		}

		#endregion


		#region エディタ拡張、ポップアップ、マウスクリック等

		public static Rect GetLayout( string s, GUIStyle style, params GUILayoutOption[] option ) {
			return GUILayoutUtility.GetRect( TempContent( s ), style, option );
		}

		public static Rect GetLayout( Texture2D tex, GUIStyle style, params GUILayoutOption[] option ) {
			return GUILayoutUtility.GetRect( TempContent( tex ), style, option );
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <param name="type">0=左 1=右</param>
		/// <returns></returns>
		public static bool HasMouseClick( Rect rc, EventMouseButton type = EventMouseButton.L ) {
			var ev = Event.current;
			if( ev.type == EventType.MouseDown && ev.button == (int) type ) {
				if( rc.Contains( ev.mousePosition ) ) {
					return true;
				}
			}
			return false;
		}


		public static bool IsMouseAreaHit( Rect rc ) {
			var ev = Event.current;
			var pos = ev.mousePosition;
			return rc.Contains( pos );
		}

		#endregion


		//public static void SetBoldFont( SerializedProperty prop ) {
		//	if( prop.prefabOverride ) {
		//		GUI.skin.font = EditorStyles.boldFont;
		//	}
		//	else {
		//		GUI.skin.font = EditorStyles.standardFont;
		//	}
		//}


		public static void ForceReloadInspectors() {
			var _ForceReloadInspectors = typeof( EditorUtility ).GetMethod( "ForceReloadInspectors", BindingFlags.NonPublic | BindingFlags.Static );
			_ForceReloadInspectors.Invoke( null, null );
		}

		public static void ShowInspector( UnityObject uobj ) {
			if( Selection.activeObject == uobj ) return;
			Selection.activeObject = uobj;
			ProjectBrowserUtils.lockOnce();
		}


		public static void ShowNewInspectorWindow( UnityObject uobj ) {
			Selection.activeObject = uobj;

			var t = typeof( Editor ).Assembly.GetType( "UnityEditor.InspectorWindow" );
			var inspector = ScriptableObject.CreateInstance( t ) as EditorWindow;

			inspector.titleContent = new GUIContent( uobj.name, LoadIcon( "UnityEditor.InspectorWindow" ) );
			inspector.Show( true );
			inspector.Repaint();

			if( UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				R.Property( "isLocked", "UnityEditor.InspectorWindow" ).SetValue( inspector, (object) true );
			}
			else {
				R.Method( "FlipLocked", "UnityEditor.InspectorWindow" ).Invoke( inspector, null );
			}
		}


		public static void SetPrefabOverride( object userData ) {
			SerializedProperty serializedProperty = (SerializedProperty) userData;

			serializedProperty.serializedObject.Update();
			serializedProperty.prefabOverride = false;
			serializedProperty.serializedObject.ApplyModifiedProperties();

			//Assembly assembly = typeof( UnityEditor.EditorUtility ).Assembly;

			ForceReloadInspectors();
			//EditorUtility.ForceReloadInspectors();
			//Debug.Log(aaa);
			GUI.FocusControl( "" );

			serializedProperty.serializedObject.Update();
			serializedProperty.prefabOverride = false;
			serializedProperty.serializedObject.ApplyModifiedProperties();
			ForceReloadInspectors();
		}

		//public static UnityObject DuplicateAsset( UnityObject obj, string prefix = "" ) {
		//	Type type = obj.GetType();

		//	var path = AssetDatabase.GetAssetPath( obj );
		//	var dir = Path.GetDirectoryName( path );
		//	var fname = Path.GetFileName( path );
		//	var newPath = dir + "/" + prefix + fname;
		//	var uniquePath = AssetDatabase.GenerateUniqueAssetPath( newPath );
		//	AssetDatabase.CopyAsset( path, uniquePath );
		//	AssetDatabase.Refresh();
		//	var asset = AssetDatabase.LoadAssetAtPath( uniquePath, type );

		//	return asset;
		//}

		// preview
		public static UnityObject DuplicateAsset2( UnityObject obj, string prefix = "" ) {

			if( !AssetDatabase.IsSubAsset( obj ) ) {

				return DuplicateAsset( obj );
			}

			void _pasteparameters( UnityObject src, UnityObject dst ) {
				if( src.GetType() == dst.GetType() ) {
					var so1 = new SerializedObject( dst );
					var so2 = new SerializedObject( src );
					so2.Update();
					so1.Update();
					var it = so2.GetIterator();
					it.NextVisible( true );
					while( it.NextVisible( true ) ) {
						//Debug.Log( it.name );
						var prop = so2.FindProperty( it.name );
						if( prop == null ) continue;
						so1.CopyFromSerializedProperty( prop );
					}
					so1.ApplyModifiedProperties();
				}
				else {
					//Debug.LogError( $"{obj.GetType().Name} != {copyObject.GetType().Name}: {S._Typedoesnotmatch}" );
				}
			}

			Type type = obj.GetType();

			var path = AssetDatabase.GetAssetPath( obj );
			var dir = Path.GetDirectoryName( path );
			var fname = obj.name;
			var newPath = $"{dir}/{prefix}{fname}.asset";
			var uniquePath = AssetDatabase.GenerateUniqueAssetPath( newPath );
			//AssetDatabase.CopyAsset( path, uniquePath );

			var newobj = UnityObject.Instantiate( obj );
			AssetDatabase.CreateAsset( newobj, uniquePath );
			_pasteparameters( obj, newobj );

			AssetDatabase.Refresh();
			var asset = AssetDatabase.LoadAssetAtPath( uniquePath, type );

			return asset;
		}

		public static T DuplicateAsset<T>( T obj, string prefix = "" ) where T : UnityObject {
			var path = AssetDatabase.GetAssetPath( obj );
			var dir = Path.GetDirectoryName( path );
			var fname = Path.GetFileName( path );
			var newPath = dir + "/" + prefix + fname;
			var uniquePath = AssetDatabase.GenerateUniqueAssetPath( newPath );
			AssetDatabase.CopyAsset( path, uniquePath );
			AssetDatabase.Refresh();
			var asset = AssetDatabase.LoadAssetAtPath<T>( uniquePath );

			return asset;
		}





		public static bool AnimationControllerIsRegistered( UnityEditor.Animations.AnimatorController controller, AnimationClip clip ) {
			var st = controller.layers[ 0 ].stateMachine.states;

			if( 0 <= Array.FindIndex( controller.animationClips, ( c ) => { return c.name == clip.name; } ) ) {
				int i = Array.FindIndex( st, c => c.state.motion == clip );
				if( 0 <= i ) {
					if( st[ i ].state.name != clip.name ) {
						//console.log( st[ i ].state.name );
						st[ i ].state.name = clip.name;
					}
				}
				return true;
			}
			return false;
		}


		public static void showNotification( string text ) {
			if( SceneView.lastActiveSceneView ) {
				GUIContent guiContent = new GUIContent();
				guiContent.text = text;
				guiContent.image = EditorGUIUtility.FindTexture( "SceneAsset Icon" );

				//UnityEditor.SceneView.currentDrawingSceneView.ShowNotification( guiContent );
				SceneView.lastActiveSceneView.ShowNotification( guiContent );
				SceneView.RepaintAll();
			}
		}

		/// <summary>
		/// EditorBuildSettingsからシーン名の配列を取得する
		/// </summary>
		/// <returns>シーン名の配列</returns>
		public static string[] GetBuildSceneNames() {
			return EditorBuildSettings
						.scenes
						.Where( x => x.enabled )
						.Select( x => x.path )
						.ToArray();
		}


		public static T[] GetSceneObjects<T>() where T : UnityObject {
			return Resources.FindObjectsOfTypeAll( typeof( T ) )
				.Where( a => AssetDatabase.GetAssetOrScenePath( a ).Contains( ".unity" ) )
				.Select( a => (T) a )
				.ToArray();
		}


		public static void ReadLine( string fname, char sepa, Action<string[]> func ) {
			var sss = fs.ReadAllText( fname );
			if( sss.IsEmpty() ) return;

			var ss = sss.Split( '\n' );
			for( int i = 0; i < ss.Length; i++ ) {
				var s = ss[ i ];
				s = s.TrimEnd( '\r' );
				if( string.IsNullOrEmpty( s ) ) {
					func( null );
				}
				else {
					func( s.Split( sepa ) );
				}
			}
		}


		/// <summary>
		/// テキストファイルを書き出します
		/// </summary>
		/// <param name="fname">ファイルパス</param>
		/// <param name="func">書き出しアクション</param>
		/// <param name="autoRefresh">AssetDataBaseにリフレッシュを呼び出すかどうか</param>
		/// <param name="utf8bom">UTF8のbomをつけるかどうか</param>
		public static void WriteFile( string fname, Action<StringBuilder> func, bool autoRefresh = true, bool utf8bom = true ) {
			if( fname.IsEmpty() ) return;

			var builder = new StringBuilder();

			func( builder );

			var directoryName = Path.GetDirectoryName( fname );
			if( !directoryName.IsEmpty() && !Directory.Exists( directoryName ) ) {
				Directory.CreateDirectory( directoryName );
			}

			if( utf8bom )
				File.WriteAllText( fname, builder.ToString().Replace( "\r\n", "\n" ), Encoding.UTF8 );
			else
				File.WriteAllText( fname, builder.ToString().Replace( "\r\n", "\n" ) );
			if( autoRefresh ) {
				AssetDatabase.Refresh( ImportAssetOptions.ImportRecursive );
			}
		}





		public static ModelImporter[] GetUpdateRigList() {
			var type = Assembly.Load( "UnityEditor.dll" ).GetType( "UnityEditor.ModelImporterRigEditor" );
			MethodInfo mi = type.GetMethod( "DoesHumanDescriptionMatch", BindingFlags.NonPublic | BindingFlags.Static );

			var files = DirectoryUtils.GetFiles( "Assets", "*.fbx", SearchOption.AllDirectories );

			var models = files.Select( a => { return AssetImporter.GetAtPath( a ) as ModelImporter; } ).ToArray();

			float fval = 0.00f;
			float fadd = 1.00f / ( (float) models.Length );

			var output = new ModelImporter[ 0 ];

			foreach( var obj in models ) {
				var path = AssetDatabase.GetAssetPath( obj );
				EditorUtility.DisplayProgressBar( "Search UpdateRig", Path.GetFileName( path ), fval );
				fval += fadd;

				var labels = AssetDatabase.GetLabels( obj );
				ArrayUtility.Remove( ref labels, "UpdateRig" );
				AssetDatabase.SetLabels( obj, labels );

				if( obj.sourceAvatar == null ) {
					//UnityDebug.LogFormat( "{0} : sourceAvatar null", obj.name );
					continue;
				}

				string assetPath = AssetDatabase.GetAssetPath( obj.sourceAvatar );
				ModelImporter otherImporter = AssetImporter.GetAtPath( assetPath ) as ModelImporter;
				bool avatarCopyIsUpToDate = (bool) mi.Invoke( null, new object[] { obj, otherImporter } );


				if( avatarCopyIsUpToDate == false ) {
					//AssetDatabase.SetLabels( obj, new string[] { "UpdateRig" } );
					ArrayUtility.Add( ref output, obj );
				}
			}
			//AssetDatabase.Refresh();

			EditorUtility.ClearProgressBar();

			return output;

		}



		#region インスペクタ

		//		static Type typeFoldoutTitlebar;
		//		static MethodInfo methodInfoFoldoutTitlebar;
		//		static MethodInfo EditorGUI_FoldoutTitlebar;

		//		public static bool FoldoutTitlebar( bool foldout, GUIContent label, bool skipIconSpacing ) {
		//			if( methodInfoFoldoutTitlebar == null ) {
		//#if UNITY_5_5 || UNITY_5_6 || UNITY_2017_1_OR_NEWER
		//				typeFoldoutTitlebar = Assembly.Load( "UnityEditor.dll" ).GetType( "UnityEditor.EditorGUILayout" );
		//#else
		//				typeFoldoutTitlebar = Types.GetType( "UnityEditor.EditorGUILayout", "UnityEditor.dll" );
		//#endif
		//				methodInfoFoldoutTitlebar = typeFoldoutTitlebar.GetMethod( "FoldoutTitlebar", BindingFlags.NonPublic | BindingFlags.Static );
		//			}

		//			var obj = methodInfoFoldoutTitlebar.Invoke( null, new object[] { foldout, label, skipIconSpacing } );
		//			return ToBoolean( obj );
		//		}
		//		public static bool FoldoutTitlebar( bool foldout, string label, bool skipIconSpacing ) {
		//			return FoldoutTitlebar( foldout, TempContent( label ), skipIconSpacing );
		//		}


		//		public static bool FoldoutTitlebar( Rect rect, bool foldout, GUIContent label, bool skipIconSpacing ) {
		//			if( EditorGUI_FoldoutTitlebar == null ) {
		//#if UNITY_5_5 || UNITY_5_6 || UNITY_2017_1_OR_NEWER
		//				var t = Assembly.Load( "UnityEditor.dll" ).GetType( "UnityEditor.EditorGUI" );
		//#else
		//				typeFoldoutTitlebar = Types.GetType( "UnityEditor.EditorGUILayout", "UnityEditor.dll" );
		//#endif
		//				EditorGUI_FoldoutTitlebar = t.GetMethod( "FoldoutTitlebar", BindingFlags.NonPublic | BindingFlags.Static );
		//			}

		//			var obj = EditorGUI_FoldoutTitlebar.Invoke( null, new object[] { rect, label, foldout, skipIconSpacing } );
		//			return ToBoolean( obj );
		//		}

		//		public static bool FoldoutTitlebar( Rect rect, bool foldout, string label, bool skipIconSpacing ) {
		//			return FoldoutTitlebar( rect, foldout, TempContent( label ), skipIconSpacing );
		//		}

		#endregion
	}



	/// <summary>
	/// 
	/// </summary>
	public static class Icon {
		static Dictionary<string, Texture2D> s_iconCache;

		/// <summary>
		/// 
		/// </summary>
		static Icon() {
			s_iconCache = new Dictionary<string, Texture2D>();
		}


		public static Texture2D Get( string lightskin, string darkskin ) {
			if( EditorGUIUtility.isProSkin ) {
				return Get( darkskin );
			}
			return Get( lightskin );
		}

		public static string GetBuiltinPath( string path ) {
			var paths = path.Split( '/' );
			if( EditorGUIUtility.isProSkin ) {
				paths[ paths.Length - 1 ] = "d_" + paths[ paths.Length - 1 ];
			}

			return string.Join( "/", paths );
		}

		public static Texture2D GetBuiltin( string path ) {
			if( EditorGUIUtility.isProSkin ) {
				var icon = Get( GetBuiltinPath( path ) );
				if( icon != null ) return icon;
			}
			return Get( path );
		}


		public static Texture2D Get( string name ) {
			if( s_iconCache.ContainsKey( name ) ) {
				return s_iconCache[ name ];
			}
			if( name.IsEmpty() ) return null;

			Texture2D icon;

			try {
				icon = EditorGUIUtility.FindTexture( name ) as Texture2D;
				if( icon != null ) {
					s_iconCache.Add( name, icon );
					return icon;
				}
			}
			catch( Exception ) {
			}

			try {
				Texture2D iconz = EditorGUIUtility.Load( name ) as Texture2D;
				//var iconz = EditorGUIUtility.IconContent( name ).image as Texture2D;
				if( iconz != null ) {
					s_iconCache.Add( name, iconz );
					return iconz;
				}
			}
			catch( Exception ) {
			}

			try {
				Texture2D iconz = EditorGUIUtility.Load( "icons/" + name + ".png" ) as Texture2D;
				//var iconz = EditorGUIUtility.IconContent( name ).image as Texture2D;
				if( iconz != null ) {
					s_iconCache.Add( name, iconz );
					return iconz;
				}
			}
			catch( Exception ) {
			}

			try {
				Texture2D iconz = EditorGUIUtility.Load( name ) as Texture2D;
				//var iconz = EditorGUIUtility.IconContent( name ).image as Texture2D;
				if( iconz != null ) {
					s_iconCache.Add( name, iconz );
					return iconz;
				}
			}
			catch( Exception ) {
			}

			var a = AssetDatabase.FindAssets( "Icons" );
			foreach( var b in a ) {
				var v = AssetDatabase.GUIDToAssetPath( b );
				var vv = Path.GetExtension( v );
				if( !string.IsNullOrEmpty( vv ) ) continue;

				icon = AssetDatabase.LoadAssetAtPath<Texture2D>( v + "/" + name + ".png" );
				if( icon != null ) {
					//UnityEngine.Debug.Log( "m_iconCache: add: " + name );
					s_iconCache.Add( name, icon );
					return icon;
				}
			}

			{
				var lst = Resources.FindObjectsOfTypeAll<Texture2D>().Where( x => x.name.Contains( name ) ).ToArray();
				if( 0 < lst.Length ) {
					s_iconCache.Add( name, lst[ 0 ] );
					return lst[ 0 ];
				}
			}
			return null;
		}
	}


	public static class B64 {
		public static string Encode( UnityObject obj ) {
			if( obj == null ) return string.Empty;
			return Encode( AssetDatabase.GetAssetPath( obj ) );
		}
		public static string Encode( string filePath ) {
			if( filePath.IsEmpty() ) return string.Empty;

			return ToBase64String( File.ReadAllBytes( filePath ) );
		}

		public static byte[] Decode( string base64Str ) {
			return FromBase64String( base64Str );
		}
	}


	// preview
	public static class HGUIUtility {

		// GUIToScreenRectは2019.1から
		public static Rect GUIToScreenRect( Rect guiRect ) {
			Vector2 vector = GUIUtility.GUIToScreenPoint( new Vector2( guiRect.x, guiRect.y ) );
			guiRect.x = vector.x;
			guiRect.y = vector.y;
			return guiRect;
		}
	}
}

#endif
