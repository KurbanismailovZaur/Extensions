using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Codomaster.Extensions
{
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Gets <typeparamref name="T"/> component from game object. If it no exist, new one will be created.
        /// </summary>
        /// <typeparam name="T">Component type.</typeparam>
        /// <param name="gameObject">The gameobject.</param>
        /// <returns>Game object's <typeparamref name="T"/> component.</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            if (gameObject.TryGetComponent(out T component))
                return component;

            return gameObject.AddComponent<T>();
        }

        /// <summary>
        /// Trying to get component in this or any it's children.
        /// </summary>
        /// <typeparam name="T">Component type.</typeparam>
        /// <param name="gameObject">Target gameobject.</param>
        /// <param name="component">Target component.</param>
        /// <param name="includeInactive">Should we find component on inactive game objects?</param>
        /// <returns><see langword="true"/> if component was found.</returns>
        public static bool TryGetComponentInChildren<T>(this GameObject gameObject, out T component, bool includeInactive = false) where T : Component
        {
            return component = gameObject.GetComponentInChildren<T>(includeInactive);
        }

        /// <summary>
        /// Trying to get component in this or any it's parent.
        /// </summary>
        /// <typeparam name="T">Component type.</typeparam>
        /// <param name="gameObject">Target gameobject.</param>
        /// <param name="component">Target component.</param>
        /// <param name="includeInactive">Should we find component on inactive game objects?</param>
        /// <returns><see langword="true"/> if component was found.</returns>
        public static bool TryGetComponentInParent<T>(this GameObject gameObject, out T component, bool includeInactive = false) where T : Component
        {
            return component = gameObject.GetComponentInParent<T>(includeInactive);
        }

        /// <summary>
        /// Check if game object is in layer mask.
        /// </summary>
        /// <param name="gameObject">Target gameobject.</param>
        /// <param name="layerMask">Layer mask for check.</param>
        /// <returns><see langword="true"/> if layer mask contain game object's layer.</returns>
        public static bool IsInLayerMask(this GameObject gameObject, LayerMask layerMask) => ((layerMask.value & (1 << gameObject.layer)) > 0);

        /// <summary>
        /// Check if game object is in layers.
        /// </summary>
        /// <param name="gameObject">Target gameobject.</param>
        /// <param name="layerNames">Layers names for check.</param>
        /// <returns><see langword="true"/> if game object's layer is in <paramref name="layerNames"/>.</returns>
        public static bool IsInLayers(this GameObject gameObject, params string[] layerNames) => IsInLayerMask(gameObject, LayerMask.GetMask(layerNames));

        /// <summary>
        /// Sets layer to all game object hierarchy.
        /// </summary>
        /// <param name="gameObject">Target game object.</param>
        /// <param name="layer">Layer to set.</param>
        public static void SetLayerRecursive(this GameObject gameObject, string layer) => SetLayerRecursive(gameObject, LayerMask.NameToLayer(layer));

        /// <summary>
        /// Sets layer to all game object hierarchy.
        /// </summary>
        /// <param name="gameObject">Target game object.</param>
        /// <param name="layer">Layer to set.</param>
        public static void SetLayerRecursive(this GameObject gameObject, int layer)
        {
            gameObject.layer = layer;
            
            foreach (Transform child in gameObject.transform.GetChilds())
                SetLayerRecursive(child.gameObject, layer);
        }
    }
}