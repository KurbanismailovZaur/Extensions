using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Redcode.Extensions
{
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Finds all components of type <typeparamref name="T"/> on this <paramref name="gameObject"/> and all its children and sets their enabled state.
        /// </summary>
        /// <typeparam name="T">Components type.</typeparam>
        /// <param name="gameObject">Target object.</param>
        /// <param name="enabled">Enabled state to set.</param>
        public static void SetComponentsEnabledInChildren<T>(this GameObject gameObject, bool enabled) where T : MonoBehaviour
        {
            var components = gameObject.GetComponentsInChildren<T>();

            foreach (var component in components)
                component.enabled = enabled;
        }

        /// <summary>
        /// Finds all components of type <typeparamref name="T"/> on this <paramref name="gameObject"/> and all its parents and sets their enabled state.
        /// </summary>
        /// <typeparam name="T">Components type.</typeparam>
        /// <param name="gameObject">Target object.</param>
        /// <param name="enabled">Enabled state to set.</param>
        public static void SetComponentsEnabledInParents<T>(this GameObject gameObject, bool enabled) where T : MonoBehaviour
        {
            var components = gameObject.GetComponentsInParent<T>();
            
            foreach (var component in components)
                component.enabled = enabled;
        }
    }
}