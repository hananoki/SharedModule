/// UnityEditor.PopupWindow : 2020.3.8f1

using HananokiEditor;
using System;
using System.Reflection;

namespace UnityReflection {
  public sealed partial class UnityEditorPopupWindow {

		public static double s_LastClosedTime {
			get {
				if( __s_LastClosedTime == null ) {
					__s_LastClosedTime = UnityTypes.UnityEditor_PopupWindow.GetField( "s_LastClosedTime", R.StaticMembers );
				}
				return (double) __s_LastClosedTime.GetValue( null );
			}
			set {
				if( __s_LastClosedTime == null ) {
					__s_LastClosedTime = UnityTypes.UnityEditor_PopupWindow.GetField( "s_LastClosedTime", R.StaticMembers );
				}
				__s_LastClosedTime.SetValue( null, value );
			}
		}

		public static UnityEngine.Rect s_LastActivatorRect {
			get {
				if( __s_LastActivatorRect == null ) {
					__s_LastActivatorRect = UnityTypes.UnityEditor_PopupWindow.GetField( "s_LastActivatorRect", R.StaticMembers );
				}
				return (UnityEngine.Rect) __s_LastActivatorRect.GetValue( null );
			}
			set {
				if( __s_LastActivatorRect == null ) {
					__s_LastActivatorRect = UnityTypes.UnityEditor_PopupWindow.GetField( "s_LastActivatorRect", R.StaticMembers );
				}
				__s_LastActivatorRect.SetValue( null, value );
			}
		}

		
		
		static FieldInfo __s_LastClosedTime;
		static FieldInfo __s_LastActivatorRect;
	}
}

