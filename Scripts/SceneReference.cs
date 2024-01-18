using System;
using UnityEngine;
using UnityObject = UnityEngine.Object;
using UnityEngine.SceneManagement;
using System.IO;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
#endif

namespace Codomaster.Extensions
{
    /// <summary>
    /// Wrapper for scene asset.
    /// </summary>
    [Serializable]
    public class SceneReference : ISerializationCallbackReceiver
    {
#if UNITY_EDITOR
        [SerializeField]
        private UnityObject _sceneObject;

        private bool IsValidSceneObject => _sceneObject && _sceneObject is SceneAsset;
#endif

        [SerializeField]
        private string _path;

        /// <summary>
        /// Path to scene in project.
        /// </summary>
        public string Path
        {
            get
            {
#if UNITY_EDITOR
                return GetScenePathFromAsset();
#else
                return _path;
#endif
            }
            set
            {
                _path = value;
#if UNITY_EDITOR
                _sceneObject = GetSceneAssetFromPath();
#endif
            }
        }

        public void OnBeforeSerialize()
        {
#if UNITY_EDITOR
            if (!IsValidSceneObject && !string.IsNullOrEmpty(_path))
            {
                if (!(_sceneObject = GetSceneAssetFromPath()))
                    _path = null;

                EditorSceneManager.MarkAllScenesDirty();
                return;
            }

            _path = GetScenePathFromAsset();
#endif
        }

        public void OnAfterDeserialize()
        {
#if UNITY_EDITOR
            EditorApplication.update += HandleAfterDeserialize;
#endif
        }

#if UNITY_EDITOR
        private void HandleAfterDeserialize()
        {
            EditorApplication.update -= HandleAfterDeserialize;

            if (IsValidSceneObject)
                return;

            if (string.IsNullOrEmpty(_path))
                return;

            if (!(_sceneObject = GetSceneAssetFromPath()))
                _path = null;

            if (!Application.isPlaying)
                EditorSceneManager.MarkAllScenesDirty();
        }

        private SceneAsset GetSceneAssetFromPath() => string.IsNullOrEmpty(_path) ? null : AssetDatabase.LoadAssetAtPath<SceneAsset>(_path);

        private string GetScenePathFromAsset() => !_sceneObject ? string.Empty : AssetDatabase.GetAssetPath(_sceneObject);
#endif

        public static implicit operator string(SceneReference sceneReference) => sceneReference.Path;
    }

    #region Property Drawer
#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(SceneReference))]
    public class SceneReferencePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.serializedObject.isEditingMultipleObjects)
            {
                GUI.Label(position, "Scene multiediting not supported");
                return;
            }

            var sceneAssetProperty = property.FindPropertyRelative("_sceneObject");
            EditorGUI.BeginChangeCheck();

            sceneAssetProperty.objectReferenceValue = EditorGUI.ObjectField(position, label, sceneAssetProperty.objectReferenceValue, typeof(SceneAsset), false);

            if (EditorGUI.EndChangeCheck() && GetEditorBuildSettingsScene(sceneAssetProperty.objectReferenceValue) == null)
                property.FindPropertyRelative("_path").stringValue = string.Empty;
        }

        private static EditorBuildSettingsScene GetEditorBuildSettingsScene(UnityObject sceneObject)
        {
            if (sceneObject is not SceneAsset)
                return null;

            var assetPath = AssetDatabase.GetAssetPath(sceneObject);
            var assetGuid = new GUID(AssetDatabase.AssetPathToGUID(assetPath));

            var scenes = EditorBuildSettings.scenes;
            for (int i = 0; i < scenes.Length; i++)
            {
                var scene = scenes[i];

                if (assetGuid != scene.guid)
                    continue;

                return scene;
            }

            return null;
        }
    }
#endif
    #endregion
}