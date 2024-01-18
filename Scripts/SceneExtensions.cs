using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Codomaster.Extensions
{
    public static class SceneExtensions
    {
        /// <summary>
        /// Finds game object in scene with <typeparamref name="T"/> component.
        /// </summary>
        /// <typeparam name="T">Component type.</typeparam>
        /// <param name="scene">Target scene.</param>
        /// <param name="includeInactive">Should we find inactive game objects?</param>
        /// <returns>Founded game object.</returns>
        public static T FindObjectOfType<T>(this Scene scene, bool includeInactive = false) where T : Component
        {
            foreach (var root in scene.GetRootGameObjects().Where(r => r.activeSelf || includeInactive))
            {
                if (root.TryGetComponentInChildren<T>(out T component, includeInactive))
                    return component;
            }

            return null;
        }

        /// <summary>
        /// Finds game objects in scene with <typeparamref name="T"/> component.
        /// </summary>
        /// <typeparam name="T">Component type.</typeparam>
        /// <param name="scene">Target scene.</param>
        /// <param name="includeInactive">Should we find inactive game objects?</param>
        /// <returns>Founded game objects.</returns>
        public static T[] FindObjectsOfType<T>(this Scene scene, bool includeInactive = false)
        {
            var filtered = scene.GetRootGameObjects().Where(r => r.activeSelf || includeInactive);
            return filtered.SelectMany(go => go.GetComponentsInChildren<T>(includeInactive)).ToArray();
        }

        /// <summary>
        /// Counts the whole number of game objects in scene.
        /// </summary>
        /// <param name="scene">Target scene.</param>
        /// <param name="includeInactive">Should we count inactive game objects?</param>
        /// <returns></returns>
        public static int ObjectsCount(this Scene scene, bool includeInactive = false)
        {
            var filtered = scene.GetRootGameObjects().Where(r => r.activeSelf || includeInactive);
            return filtered.SelectMany(r => r.GetComponentsInChildren<Transform>(includeInactive)).Count();
        }
    }
}
