using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Extensions
{
    public static class SceneExtensions
    {
        /// <summary>
        /// Finds game objects in scene with <typeparamref name="T"/> component.
        /// </summary>
        /// <typeparam name="T">Component type.</typeparam>
        /// <param name="scene">Target scene.</param>
        /// <returns>Finded game objects.</returns>
        public static T[] FindObjectsOfType<T>(this Scene scene) => scene.GetRootGameObjects().SelectMany(go => go.GetComponentsInChildren<T>(true)).ToArray();
    }
}