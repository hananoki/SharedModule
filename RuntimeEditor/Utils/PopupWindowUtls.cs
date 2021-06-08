using UnityEditor;
using UnityEngine;
using UnityReflection;

namespace HananokiEditor {
	public static partial class PopupWindowUtls {
		internal enum ShowMode {
			// Show as a normal window with max, min & close buttons.
			NormalWindow = 0,
			// Used for a popup menu. On mac this means light shadow and no titlebar.
			PopupMenu = 1,
			// Utility window - floats above the app. Disappears when app loses focus.
			Utility = 2,
			// Window has no shadow or decorations. Used internally for dragging stuff around.
			NoShadow = 3,
			// The Unity main window. On mac, this is the same as NormalWindow, except window doesn't have a close button.
			MainWindow = 4,
			// Aux windows. The ones that close the moment you move the mouse out of them.
			AuxWindow = 5,
			// Like PopupMenu, but without keyboard focus
			Tooltip = 6,
			// Modal Utility window
			ModalUtility = 7
		}

		internal enum PopupLocation {
			Below,
			BelowAlignLeft = Below,
			Above,
			AboveAlignLeft = Above,
			Left,
			Right,
			Overlay,
			BelowAlignRight,
			AboveAlignRight
		}



		public static void Show( Rect activatorRect, PopupWindowContent windowContent ) {
			Show( activatorRect, windowContent, null );
		}

		internal static void Show( Rect activatorRect, PopupWindowContent windowContent, PopupLocation[] locationPriorityOrder ) {
			Show( activatorRect, windowContent, locationPriorityOrder, ShowMode.PopupMenu );
		}

		internal static void Show( Rect activatorRect, PopupWindowContent windowContent, PopupLocation[] locationPriorityOrder, ShowMode showMode ) {
			// If we already have a popup window showing this type of content, then just close
			// the existing one.
			var existingWindows = Resources.FindObjectsOfTypeAll( typeof( PopupWindow ) );
			if( existingWindows != null && existingWindows.Length > 0 ) {
				var existingPopup = existingWindows[ 0 ] as PopupWindow;
				if( existingPopup != null ) {
					object _WindowContent = existingPopup.GetField<object>( "m_WindowContent" );

					if( _WindowContent != null && _WindowContent.GetType() == windowContent.GetType() ) {
						//existingPopup.CloseWindow();
						//existingPopup.MethodInvoke( "CloseWindow", null );
						existingPopup.Close();
						return;
					}
				}
			}

			if( ShouldShowWindow( activatorRect ) ) {
				object win =  ScriptableObject.CreateInstance<PopupWindow>() ;
				if( win != null ) {
					win.MethodInvoke("Init", new object[] { activatorRect, windowContent, null, 1, true } );
				}
				if( Event.current != null ) {
					EditorGUIUtility.ExitGUI(); // Needed to prevent GUILayout errors on OSX
				}
			}
		}

		internal static bool ShouldShowWindow( Rect activatorRect ) {
			const double kJustClickedTime = 0.2;
			bool justClosed = ( EditorApplication.timeSinceStartup - UnityEditorPopupWindow.s_LastClosedTime ) < kJustClickedTime;
			if( !justClosed || activatorRect != UnityEditorPopupWindow.s_LastActivatorRect ) {
				UnityEditorPopupWindow.s_LastActivatorRect = activatorRect;
				return true;
			}
			return false;
		}
	}
}
