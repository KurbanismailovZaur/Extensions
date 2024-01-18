using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;
public static class FindMissingScriptsRecursively
{
    private static float _lastCallTime = 0f;

    [MenuItem("Assets/Remove Missing Scripts")]
    [MenuItem("GameObject/Remove Missing Scripts")]
    private static void FindAndRemoveMissingInSelected()
    {
        if (Mathf.Approximately(Time.unscaledTime, _lastCallTime)) 
            return;

        var selected = Selection.gameObjects.SelectMany(go => go.GetComponentsInChildren<Transform>(true)).Select(t => t.gameObject);
        var prefabs = new HashSet<Object>();
        var affectedGameObjects = new List<GameObject>();

        var removedComponentsCount = 0;
        var removedGameObjectsCount = 0;

        foreach (var gameObject in selected)
        {
            var count = GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(gameObject);

            if (count == 0)
                continue;

            if (PrefabUtility.IsPartOfAnyPrefab(gameObject))
            {
                RecursivePrefabSource(gameObject, prefabs, ref removedComponentsCount, ref removedGameObjectsCount);
                count = GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(gameObject);

                if (count == 0)
                    continue;
            }

            Undo.RegisterCompleteObjectUndo(gameObject, "Remove missing scripts");
            GameObjectUtility.RemoveMonoBehavioursWithMissingScript(gameObject);

            affectedGameObjects.Add(gameObject);
            removedComponentsCount += count;
            removedGameObjectsCount += 1;
        }

        if (removedGameObjectsCount == 0)
            Debug.Log("<color=#32a852>There is no selected game objects with missing scripts.</color>");
        else
            Debug.Log($"<color=#c8d649>Removed {removedComponentsCount} missing scripts from {removedGameObjectsCount} game objects.</color>" +
                $"\nGame objects: <color=#c8d649>{string.Join(", ", affectedGameObjects.Select(go => go.name))}.</color>");

        _lastCallTime = Time.unscaledTime;
    }

    private static void RecursivePrefabSource(GameObject instance, HashSet<Object> prefabs, ref int removedComponentsCount, ref int removedGameObjectsCount)
    {
        var source = PrefabUtility.GetCorrespondingObjectFromSource(instance);

        if (source == null || !prefabs.Add(source))
            return;

        RecursivePrefabSource(source, prefabs, ref removedComponentsCount, ref removedGameObjectsCount);

        var count = GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(source);

        if (count > 0)
        {
            Undo.RegisterCompleteObjectUndo(source, "Remove missing scripts");
            GameObjectUtility.RemoveMonoBehavioursWithMissingScript(source);
            
            removedComponentsCount += count;
            removedGameObjectsCount += 1;
        }
    }
}