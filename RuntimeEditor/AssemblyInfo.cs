#if UNITY_2020_1_OR_NEWER
using UnityEditor;
[assembly: Localization]

#elif UNITY_2019_3_OR_NEWER
using UnityEditor.Localization.Editor;
[assembly: Localization]
#endif
