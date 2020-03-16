#pragma warning disable 618
#if UNITY_EDITOR

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using UnityEditor;

using System.Reflection;
using System;
using UnityEditor.Animations;
using UnityEditor.SceneManagement;
using System.Text;

using Hananoki;
using Hananoki.Extensions;
using System.Text.RegularExpressions;
using Hananoki.Reflection;
using Hananoki.Shared.Localize;

using UnityObject = UnityEngine.Object;
using UnityRandom = UnityEngine.Random;
using static System.Convert;

namespace Hananoki {

	public enum EventMouseButton {
		L, R, M,
	}

	public static class PrefabHelper {
		public static void SavePrefab2( GameObject gameObject, string outputPath, Action<GameObject> postProcess = null ) {
			GameObject outobj = null;
			gameObject.SetActive( true );

			var t = AssetDatabase.LoadAssetAtPath<UnityObject>( outputPath );
			if( t != null ) {
				outobj = PrefabUtility.ReplacePrefab( gameObject, t, ReplacePrefabOptions.ReplaceNameBased );
			}
			else {
				outobj = PrefabUtility.CreatePrefab( outputPath, gameObject, ReplacePrefabOptions.Default );
			}

			postProcess.Call( outobj );
			AssetDatabase.SaveAssets();
			AssetDatabase.Refresh();

			Debug.LogFormat( "プレハブを書き出しました. [{0}]", outputPath );
			EditorGUIUtility.PingObject( outobj );
		}

		public static void SavePrefab( GameObject gameObject, string guid, Action<GameObject> postProcess = null ) {
			if( string.IsNullOrEmpty( guid ) ) {
				Debug.Assert( !string.IsNullOrEmpty( guid ), "m_OutputPrefab が未設定" );
				return;
			}

			var outputPath = AssetDatabase.GUIDToAssetPath( guid );

			SavePrefab2( gameObject, outputPath, postProcess );
		}
	}



	public static class EditorHelper {

		public static void PingObject( UnityObject obj ) {
			EditorGUIUtility.PingObject( obj );
		}
		public static void PingObject( string path ) {
			PingObject( AssetDatabase.LoadAssetAtPath<UnityObject>( path ) );
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
			catch( System.Exception ) {
			}


			try {
				icon = EditorGUIUtility.Load( "icons/" + name + ".png" ) as Texture2D;
				if( icon != null ) return icon;
			}
			catch( System.Exception ) {
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
					icon= lst[ 0 ];
					if( icon != null ) return icon;
				}
			}


			return icon;
		}


		

		public static bool HasMenuItem( string menuName ) {
			var menuTop = menuName.Split( '/' )[ 0 ];
			var ss =Unsupported.GetSubmenus( menuTop );
			foreach(var s in ss) {
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
			OpenScene( (string)obj );
		}


			public static void Dirty( UnityEngine.Object obj, System.Action ff ) {
			Undo.RecordObject( obj, "obj" );
			ff.Call();
			EditorUtility.SetDirty( obj );
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
				byte[] readBinary = EditorHelper.ReadBinaryFile( path );

				Texture2D texture = new Texture2D( width, height );
				texture.LoadImage( readBinary );

				return texture;
			}
			catch(Exception ) {
				return null;
			}
		}

#if true
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
#endif



		/// <summary>
		/// 指定したアセットのGUIDを返します
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		//public static string ToGUID( UnityEngine.Object obj ) {
		//	var a = AssetDatabase.GetAssetPath( obj );
		//	var b = AssetDatabase.AssetPathToGUID( a );
		//	return b;
		//}


		#region GUIContent

		private static GUIContent s_Text = new GUIContent();
		public static GUIContent TempContent( string t ) {
			s_Text.text = t;
			return s_Text;
		}

		private static GUIContent s_TextTool = new GUIContent();
		public static GUIContent TempContent( string t, string t2 ) {
			s_TextTool.text = t;
			s_TextTool.tooltip = t2;
			return s_TextTool;
		}

		private static GUIContent s_TextImage = new GUIContent();
		public static GUIContent TempContent( string t, Texture i ) {
			s_TextImage.image = i;
			s_TextImage.text = t;
			return s_TextImage;
		}

		private static GUIContent s_ContentImage = new GUIContent();
		public static GUIContent TempContent( Texture image, string tooltip = "" ) {
			s_ContentImage.image = image;
			s_ContentImage.tooltip = tooltip;
			return s_ContentImage;
		}

		#endregion


		#region エディタ拡張、ポップアップ、マウスクリック等

		public static Rect GetLayout( string s, GUIStyle style, params GUILayoutOption[] option ) {
			return GUILayoutUtility.GetRect( EditorHelper.TempContent( s ), style , option );
		}
		public static Rect GetLayout( Texture2D tex, GUIStyle style, params GUILayoutOption[] option ) {
			return GUILayoutUtility.GetRect( EditorHelper.TempContent( tex ), style, option );
		}

		public static Rect PopupRect( Rect rc ) {
			return new Rect( rc.x, rc.y + 6, rc.width, 12 );
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <param name="type">0=左 1=右</param>
		/// <returns></returns>
		public static bool HasMouseClick( Rect rc, EventMouseButton type = EventMouseButton.L ) {
			var ev = Event.current;
			var pos = ev.mousePosition;
			if( ev.type == EventType.MouseDown && ev.button == (int)type ) {
				if( rc.x < pos.x && pos.x < rc.max.x && rc.y < pos.y && pos.y < rc.max.y ) {
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

		public static void SetBoldFont( SerializedProperty prop ) {
			if( prop.prefabOverride ) {
				GUI.skin.font = EditorStyles.boldFont;
			}
			else {
				GUI.skin.font = EditorStyles.standardFont;
			}
		}


		public static void ForceReloadInspectors() {
			var _ForceReloadInspectors = typeof( UnityEditor.EditorUtility ).GetMethod( "ForceReloadInspectors", BindingFlags.NonPublic | BindingFlags.Static );
			_ForceReloadInspectors.Invoke( null, null );
		}


		public static void ShowNewInspector( UnityObject uobj ) {
			Selection.activeObject = uobj;

			var t = typeof( Editor ).Assembly.GetType( "UnityEditor.InspectorWindow" );
			var inspector = ScriptableObject.CreateInstance( t ) as EditorWindow;

			inspector.titleContent = new GUIContent( uobj.name, LoadIcon( "UnityEditor.InspectorWindow" ) );
			inspector.Show( true );
			inspector.Repaint();

#if UNITY_2018_3_OR_NEWER
			R.Property( "isLocked", "UnityEditor.InspectorWindow" ).SetValue( inspector, (object) true );
#else
			R.Method( "FlipLocked", "UnityEditor.InspectorWindow" ).Invoke( inspector, null );
#endif
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


		public static T DuplicateAsset<T>( T obj ) where T: UnityObject {
			var path = AssetDatabase.GetAssetPath( obj );
			var dir = Path.GetDirectoryName( path );
			var fname = Path.GetFileName( path );
			var newPath = dir + "/" + "@" + fname;
			var uniquePath = AssetDatabase.GenerateUniqueAssetPath( newPath );
			AssetDatabase.CopyAsset( path, uniquePath );
			AssetDatabase.Refresh();
			var asset = AssetDatabase.LoadAssetAtPath<T>( uniquePath );
	
			return asset;
		}





		public static bool AnimationControllerIsRegistered( UnityEditor.Animations.AnimatorController controller, AnimationClip clip ) {
			var st = controller.layers[ 0 ].stateMachine.states;

			if( 0 <= System.Array.FindIndex( controller.animationClips, ( c ) => { return c.name == clip.name; } ) ) {
				int i = System.Array.FindIndex( st, c => c.state.motion == clip );
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
		public static void WriteFile( string fname, Action<StringBuilder> func, bool autoRefresh = true, bool utf8bom=true ) {
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

			var output = new ModelImporter[0];

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

		static Type typeFoldoutTitlebar;
		static MethodInfo methodInfoFoldoutTitlebar;
		static MethodInfo EditorGUI_FoldoutTitlebar;

		public static bool FoldoutTitlebar( bool foldout, GUIContent label, bool skipIconSpacing ) {
			if( methodInfoFoldoutTitlebar == null ) {
#if UNITY_5_5 || UNITY_5_6 || UNITY_2017_1_OR_NEWER
				typeFoldoutTitlebar = System.Reflection.Assembly.Load( "UnityEditor.dll" ).GetType( "UnityEditor.EditorGUILayout" );
#else
				typeFoldoutTitlebar = Types.GetType( "UnityEditor.EditorGUILayout", "UnityEditor.dll" );
#endif
				methodInfoFoldoutTitlebar = typeFoldoutTitlebar.GetMethod( "FoldoutTitlebar", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static );
			}

			var obj = methodInfoFoldoutTitlebar.Invoke( null, new object[] { foldout, label, skipIconSpacing } );
			return Convert.ToBoolean( obj );
		}
		public static bool FoldoutTitlebar( bool foldout, string label, bool skipIconSpacing ) {
			return FoldoutTitlebar( foldout, EditorHelper.TempContent( label ), skipIconSpacing );
		}


		public static bool FoldoutTitlebar( Rect rect, bool foldout, GUIContent label, bool skipIconSpacing ) {
			if( EditorGUI_FoldoutTitlebar == null ) {
#if UNITY_5_5 || UNITY_5_6 || UNITY_2017_1_OR_NEWER
				var t = System.Reflection.Assembly.Load( "UnityEditor.dll" ).GetType( "UnityEditor.EditorGUI" );
#else
				typeFoldoutTitlebar = Types.GetType( "UnityEditor.EditorGUILayout", "UnityEditor.dll" );
#endif
				EditorGUI_FoldoutTitlebar = t.GetMethod( "FoldoutTitlebar", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static );
			}

			var obj = EditorGUI_FoldoutTitlebar.Invoke( null, new object[] { rect, label, foldout, skipIconSpacing } );
			return Convert.ToBoolean( obj );
		}

		public static bool FoldoutTitlebar( Rect rect, bool foldout, string label, bool skipIconSpacing ) {
			return FoldoutTitlebar( rect, foldout, EditorHelper.TempContent( label ), skipIconSpacing );
		}

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


		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
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
			catch( System.Exception ) {
			}

			try {
				Texture2D iconz = EditorGUIUtility.Load( "icons/" + name + ".png" ) as Texture2D;
				//var iconz = EditorGUIUtility.IconContent( name ).image as Texture2D;
				if( iconz != null ) {
					s_iconCache.Add( name, iconz );
					return iconz;
				}
			}
			catch( System.Exception ) {
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
				if(0 < lst.Length) {
					s_iconCache.Add( name, lst[0] );
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
}

#endif
