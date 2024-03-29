﻿
using System;

namespace HananokiEditor {
	public static partial class UnityTypes {

		static Type _UnityEngine_Audio_AudioMixer;
		public static Type UnityEngine_Audio_AudioMixer => Get( ref _UnityEngine_Audio_AudioMixer, "UnityEngine.Audio.AudioMixer", "UnityEngine" );

		static Type _UnityEditor_Audio_AudioMixerController;
		public static Type UnityEditor_Audio_AudioMixerController => Get( ref _UnityEditor_Audio_AudioMixerController, "UnityEditor.Audio.AudioMixerController", "UnityEditor" );

		static Type _UnityEditor_Audio_AudioMixerGroupController;
		public static Type UnityEditor_Audio_AudioMixerGroupController => Get( ref _UnityEditor_Audio_AudioMixerGroupController, "UnityEditor.Audio.AudioMixerGroupController", "UnityEditor" );

		static Type _UnityEditor_Audio_AudioMixerSnapshotController;
		public static Type UnityEditor_Audio_AudioMixerSnapshotController => Get( ref _UnityEditor_Audio_AudioMixerSnapshotController, "UnityEditor.Audio.AudioMixerSnapshotController", "UnityEditor" );

	}
}
