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
//using UnityReflection;

using static System.Convert;
using UnityObject = UnityEngine.Object;
using EditorAssemblies = UnityReflection.UnityEditorEditorAssemblies;
using CustomEditorAttributes = UnityReflection.UnityEditorCustomEditorAttributes;

namespace Hananoki {

	public enum EventMouseButton {
		L, R, M,
	}




	public static class EditorHelper {

		public static void ShowMessagePop( string text ) {
			var content = new MessagePop( text );
			var mouseRect = new Rect( Event.current.mousePosition, Vector2.one );
			PopupWindow.Show( mouseRect, content );
		}


		#region ScreenCapture

		static string MakeScreenCaptureFileName( int width, int height ) {
			string fpath = string.Format( "{0}/ScreenShot/ScreenShot_{1}x{2}_{3}",
													Directory.GetCurrentDirectory(),
													width, height,
													DateTime.Now.ToString( "yyyy-MM-dd_HH-mm-ss" ) );

			string f = fpath;
			int index = 1;

			while( File.Exists( f + ".png" ) ) {
				f = string.Format( "{0}_{1}", fpath, index );
				index++;
			}

			return f + ".png";
		}

		public static int s_captureScale = 1;

		public static void SaveScreenCapture() {
			var dname = Directory.GetCurrentDirectory() + "/ScreenShot";
			if( !Directory.Exists( dname ) ) {
				Directory.CreateDirectory( dname );
			}

			string filename = MakeScreenCaptureFileName( (int) Handles.GetMainGameViewSize().x * s_captureScale, (int) Handles.GetMainGameViewSize().y * s_captureScale );
#if UNITY_2017_1_OR_NEWER
			ScreenCapture.CaptureScreenshot( filename, s_captureScale );
#else
			Application.CaptureScreenshot( filename, Multi );
#endif
			Debug.Log( $"SaveScreenCapture: {filename }" );

			var gameview = EditorWindow.GetWindow( typeof( EditorWindow ).Assembly.GetType( "UnityEditor.GameView" ) );
			// GameViewを再描画 
			gameview.Repaint();
		}

		#endregion



		public static void ForceReloadInspectors() {
			var _ForceReloadInspectors = typeof( UnityEditor.EditorUtility ).GetMethod( "ForceReloadInspectors", BindingFlags.NonPublic | BindingFlags.Static );
			_ForceReloadInspectors.Invoke( null, null );
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



		// Example "Unity.Addressables.Editor"
		public static bool IsLoadAssembly(string assemblyName ) {
			foreach( var p in EditorAssemblies.loadedAssemblies ) {
				if( p.FullName == assemblyName ) return true;
			}
			return false;
		}


		public static Type GetTypeFromString( string typeName ) {
			var t = Type.GetType( typeName );
			if( t != null ) return t;

			var lst = EditorAssemblies.loadedTypes
					.Where( x => x.FullName.Contains( typeName ) )
					.Where( x => !x.FullName.Contains( "+" ) )
					.ToList();

			if( lst.Count == 0 ) return null;
			if( lst.Count == 1 ) return lst[ 0 ];

			var tt = typeName.Split( '.' );

			foreach( var p in lst ) {
				var ss = new List<string>( p.SplitFullName() );
				if( ss.Count != tt.Length ) continue;
				ss.AddRange( tt );
				if( tt.Length == ss.Distinct().Count() ) return p;
			}

			return null;
		}


		/// <summary>
		/// 指定したUnityObjectのEditor型を取得します
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="o"></param>
		/// <returns></returns>
		public static Type GetEditorType<T>( T o ) where T : UnityObject {
			var t = CustomEditorAttributes.FindCustomEditorTypeByType( o.GetType(), false );
			if( t == null ) return UnityTypes.UnityEditor_GenericInspector;
			return t;
		}


		public static void Reboot() {
			ShellUtils.Start( EditorApplication.applicationPath, $"-projectPath \"{Application.dataPath.DirectoryName()}\"" );
			EditorApplication.Exit( 0 );
		}

		public static UnityObject[] LoadSerializedFileAll( string path ) {
			return UnityEditorInternal.InternalEditorUtility.LoadSerializedFileAndForget( path );
		}

		public static UnityObject LoadSerializedFileAtName( string path, string name ) {
			return LoadSerializedFileAtName<UnityObject>( path, name );
		}

		public static T LoadSerializedFileAtName<T>( string path, string name ) where T : UnityObject {
			try {
				foreach( var p in UnityEditorInternal.InternalEditorUtility.LoadSerializedFileAndForget( path ) ) {
					if( p == null ) {
						Debug.LogWarning( $"path: {path}, name: {name}" );
						continue;
					}
					if( p.name != name ) continue;
					return (T) p;
				}
			}
			catch( Exception e ) {
				Debug.LogException( e );
				Debug.LogError( $"path: {path}, name: {name}" );
			}
			return null;
		}


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
			else if( p.GetType().IsSubclassOf( UnityTypes.TMPro_TMP_Text ) ) {
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
#if UNITY_2018_3_OR_NEWER
			EditorHelper.TravaseAllType( cb );
			void cb( Type t ) {
				if( !t.IsSubclassOf( type ) ) return;
				types.Add( t );
			}
#endif
			return types.ToArray();
		}


		public static void TravaseAllType( Action<Type> action ) {
			if( action == null ) return;

			var assemblys = AppDomain.CurrentDomain.GetAssemblies();

			foreach( Assembly assembly in assemblys ) {
				try {
					var types = assembly.GetTypes();

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
		}



#if UNITY_2018_3_OR_NEWER
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
#endif
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

		//public static void EditScript( Type t ) {
		//	var a = ScriptableObject.CreateInstance( t );
		//	AssetDatabase.OpenAsset( MonoScript.FromScriptableObject( a ) );
		//	UnityObject.DestroyImmediate( a );
		//}

		public static void EditScript( UnityObject obj ) {
			if( obj.IsSubclassOf( UnityTypes.UnityEngine_ScriptableObject ) ) {
				EditScriptIsScriptableObject( (ScriptableObject) obj );
			}
			else {
				EditScriptIsMonoBehaviour( (MonoBehaviour) obj );
			}
		}

		public static void EditScriptIsScriptableObject( ScriptableObject obj ) {
			AssetDatabase.OpenAsset( MonoScript.FromScriptableObject( obj ) );
		}

		public static void EditScriptIsMonoBehaviour( MonoBehaviour obj ) {
			AssetDatabase.OpenAsset( MonoScript.FromMonoBehaviour( obj ) );
		}


		//public static void PingObject( Type t ) {
		//	var a = ScriptableObject.CreateInstance( t );
		//	PingObject( MonoScript.FromScriptableObject( a ) );
		//	UnityObject.DestroyImmediate( a );
		//}



		public static void PingObject( object context ) {
			EditorGUIUtility.PingObject( context.ContextToObject() );
		}

		public static void PingAndSelectObject( object context ) {
			var o = context.ContextToObject();
			EditorGUIUtility.PingObject( o );
			Selection.activeObject = o;
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

#if false
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
#endif


		/// <summary>
		/// 指定したメニューの文字列が存在するかチェックします
		/// </summary>
		/// <param name="menuName"></param>
		/// <returns></returns>
		public static bool HasMenuItem( string menuName ) {
			var menuTop = menuName.Split( '/' )[ 0 ];
			var ss = Unsupported.GetSubmenus( menuTop );
			foreach( var s in ss ) {
				if( s == menuName ) return true;
			}
			return false;
		}


#if false
		public static void TraverseHierarchyObjects( Action<GameObject> func ) {
			foreach( GameObject obj in Resources.FindObjectsOfTypeAll( typeof( GameObject ) ) ) {
				string path = AssetDatabase.GetAssetOrScenePath( obj );
				if( path.Contains( ".unity" ) ) {
					func( obj );
				}
			}
		}
#endif

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

		public static void ShowInspector( UnityObject uobj ) {
			if( Selection.activeObject == uobj ) return;
			Selection.activeObject = uobj;
			ProjectBrowserUtils.lockOnce();
		}


		public static void ShowNewInspectorWindow( UnityObject uobj ) {
			Selection.activeObject = uobj;

			var t = typeof( Editor ).Assembly.GetType( "UnityEditor.InspectorWindow" );
			var inspector = ScriptableObject.CreateInstance( t ) as EditorWindow;

			inspector.titleContent = new GUIContent( uobj.name, EditorIcon.unityeditor_inspectorwindow );
			inspector.Show( true );
			inspector.Repaint();

			if( UnitySymbol.Has( "UNITY_2018_3_OR_NEWER" ) ) {
				inspector.SetProperty( "isLocked", true );
			}
			else {
				inspector.MethodInvoke( "FlipLocked" );
			}
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

#if UNITY_2018_3_OR_NEWER

		// IsSubAsset
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
			var fname = obj.name.IsEmpty() ? type.Name : obj.name;
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
#endif
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




#if false
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
#endif


#if false
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
#endif

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


#if false
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
#endif


#if false
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
#endif
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

		public static void DisableFocus() {
			GUI.FocusControl( "" );
		}

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
