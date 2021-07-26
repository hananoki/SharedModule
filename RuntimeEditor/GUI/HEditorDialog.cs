using HananokiEditor.SharedModule;
using System;
using UnityEditor;


namespace HananokiEditor {

	public class HEditorDialog {

		/////////////////////////////////////////
		public static void Confirm( string message ) => _Yes( S._Confirm, message );
		public static bool Confirm( string message, Action action ) => _YesOrCancel( S._Confirm, message, action );
		

		/////////////////////////////////////////
		public static void Info( string message ) => _Yes( S._Info, message );
		public static bool Info( string message, Action action ) => _YesOrCancel( S._Info, message, action );


		/////////////////////////////////////////
		public static void Warning( string message ) => _Yes( S._Warning, message );
		public static bool Warning( string message, Action action ) => _YesOrCancel( S._Warning, message, action );


		/////////////////////////////////////////
		public static void Error( string message ) => _Yes( S._Error, message );
		public static bool Error( string message, Action action ) => _YesOrCancel( S._Error, message, action );


		/////////////////////////////////////////
		static void _Yes( string title, string message ) {
			EditorUtility.DisplayDialog( S._Error, message, S._OK );
		}


		/////////////////////////////////////////
		static bool _YesOrCancel( string title, string message, Action action ) {
			var result = EditorUtility.DisplayDialog( title, message, S._OK, S._Cancel );
			if( !result ) return result;
			action?.Invoke();
			return result;
		}


	}
}
