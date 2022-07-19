using System.Linq;
using UnityEngine.SceneManagement;

namespace Redcode.Extensions
{
    public static class SceneManagerExtensions
    {
        /// <summary>
        /// Finds game objects in active scene with <typeparamref name="T"/> component.
        /// </summary>
        /// <typeparam name="T">Component type.</typeparam>
        /// <returns>Finded game objects.</returns>
        public static T[] FindObjectsOfTypeInActiveScene<T>() => SceneManager.GetActiveScene().FindObjectsOfType<T>();

        /// <summary>
        /// Finds game objects in open scenes with <typeparamref name="T"/> component.
        /// </summary>
        /// <typeparam name="T">Component type.</typeparam>
        /// <returns>Finded game objects.</returns>
        public static T[] FindObjectsOfTypeInOpenScenes<T>() => Enumerable.Range(0, SceneManager.sceneCount).Select(index => SceneManager.GetSceneAt(index)).SelectMany(scene => scene.FindObjectsOfType<T>()).ToArray();
    }
}