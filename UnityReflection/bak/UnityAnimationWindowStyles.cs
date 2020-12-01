//#if UNITY_EDITOR
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEditor;

//namespace Hananoki {
//	public class UnityAnimationWindowStyles {

//		public static Texture2D pointIcon                       = UnityEditorGUIUtility.LoadIcon( "animationkeyframe" );
//		public static GUIContent playContent                    = EditorGUIUtility.IconContent( "Animation.Play", "|Play the animation clip." );
//		public static GUIContent recordContent                  = EditorGUIUtility.IconContent( "Animation.Record", "|Enable/disable keyframe recording mode." );
//		public static GUIContent previewContent                 = UnityEditorGUIUtility.TextContent( "Preview|Enable/disable scene preview mode." );
//		public static GUIContent prevKeyContent                 = EditorGUIUtility.IconContent( "Animation.PrevKey", "|Go to previous keyframe." );
//		public static GUIContent nextKeyContent                 = EditorGUIUtility.IconContent( "Animation.NextKey", "|Go to next keyframe." );
//		public static GUIContent firstKeyContent                = EditorGUIUtility.IconContent( "Animation.FirstKey", "|Go to the beginning of the animation clip." );
//		public static GUIContent lastKeyContent                 = EditorGUIUtility.IconContent( "Animation.LastKey", "|Go to the end of the animation clip." );
//		public static GUIContent addKeyframeContent             = EditorGUIUtility.IconContent( "Animation.AddKeyframe", "|Add keyframe." );
//		public static GUIContent addEventContent                = EditorGUIUtility.IconContent( "Animation.AddEvent", "|Add event." );
//		public static GUIContent sequencerLinkContent           = EditorGUIUtility.IconContent( "Animation.SequencerLink", "|Animation Window is linked to Sequence Editor.  Press to Unlink." );
//		public static GUIContent noAnimatableObjectSelectedText = UnityEditorGUIUtility.TextContent( "No animatable object selected." );
//		public static GUIContent formatIsMissing                = UnityEditorGUIUtility.TextContent( "To begin animating {0}, create {1}." );
//		public static GUIContent animatorAndAnimationClip       = UnityEditorGUIUtility.TextContent( "an Animator and an Animation Clip" );
//		public static GUIContent animationClip                  = UnityEditorGUIUtility.TextContent( "an Animation Clip" );
//		public static GUIContent create                         = UnityEditorGUIUtility.TextContent( "Create" );
//		public static GUIContent dopesheet                      = UnityEditorGUIUtility.TextContent( "Dopesheet" );
//		public static GUIContent curves                         = UnityEditorGUIUtility.TextContent( "Curves" );
//		public static GUIContent samples                        = UnityEditorGUIUtility.TextContent( "Samples" );
//		public static GUIContent createNewClip                  = UnityEditorGUIUtility.TextContent( "Create New Clip..." );
//		public static GUIContent animatorOptimizedText          = UnityEditorGUIUtility.TextContent( "Editing and playback of animations on optimized game object hierarchy is not supported.\nPlease select a game object that does not have 'Optimize Game Objects' applied." );
//		public static GUIStyle playHead                         = "AnimationPlayHead";
//		public static GUIStyle curveEditorBackground            = "CurveEditorBackground";
//		public static GUIStyle curveEditorLabelTickmarks        = "CurveEditorLabelTickmarks";
//		public static GUIStyle eventBackground                  = "AnimationEventBackground";
//		public static GUIStyle eventTooltip                     = "AnimationEventTooltip";
//		public static GUIStyle eventTooltipArrow                = "AnimationEventTooltipArrow";
//		public static GUIStyle keyframeBackground               = "AnimationKeyframeBackground";
//		public static GUIStyle timelineTick                     = "AnimationTimelineTick";
//		public static GUIStyle dopeSheetKeyframe                = "Dopesheetkeyframe";
//		public static GUIStyle dopeSheetBackground              = "DopesheetBackground";
//		public static GUIStyle popupCurveDropdown               = "PopupCurveDropdown";
//		public static GUIStyle popupCurveEditorBackground       = "PopupCurveEditorBackground";
//		public static GUIStyle popupCurveEditorSwatch           = "PopupCurveEditorSwatch";
//		public static GUIStyle popupCurveSwatchBackground       = "PopupCurveSwatchBackground";
//		public static GUIStyle miniToolbar                      = new GUIStyle( EditorStyles.toolbar );
//		public static GUIStyle miniToolbarButton                = new GUIStyle( EditorStyles.toolbarButton );
//		public static GUIStyle toolbarLabel                     = new GUIStyle( EditorStyles.toolbarPopup );
		
//		public static void Initialize() {
//			UnityAnimationWindowStyles.toolbarLabel.normal.background = null;
//			UnityAnimationWindowStyles.miniToolbarButton.padding.top = 0;
//			UnityAnimationWindowStyles.miniToolbarButton.padding.bottom = 3;
//		}
//	}
//}
//#endif

