using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Extensions
{
    public static class SceneManagerExtensions
    {
        public static T[] FindObjectsOfTypeInActiveScene<T>() => SceneManager.GetActiveScene().FindObjectsOfType<T>();

        public static T[] FindObjectsOfTypeInOpenScenes<T>() => Enumerable.Range(0, SceneManager.sceneCount).Select(index => SceneManager.GetSceneAt(index)).SelectMany(scene => scene.FindObjectsOfType<T>()).ToArray();
    }
}