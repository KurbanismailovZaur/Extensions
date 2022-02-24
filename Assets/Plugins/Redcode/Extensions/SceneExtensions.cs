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
        public static T[] FindObjectsOfType<T>(this Scene scene) => scene.GetRootGameObjects().SelectMany(go => go.GetComponentsInChildren<T>(true)).ToArray();
    }
}