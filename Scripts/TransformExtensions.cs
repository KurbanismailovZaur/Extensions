using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityObject = UnityEngine.Object;

namespace Codomaster.Extensions
{
    public static class TransformExtensions
    {
        /// <summary>
        /// Sets x position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetPositionX(this Transform transform, float x) => transform.position = transform.position.WithX(x);

        /// <summary>
        /// Sets y position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetPositionY(this Transform transform, float y) => transform.position = transform.position.WithY(y);

        /// <summary>
        /// Sets z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="z">Value to set.</param>
        public static void SetPositionZ(this Transform transform, float z) => transform.position = transform.position.WithZ(z);

        /// <summary>
        /// Sets x and y position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetPositionXY(this Transform transform, float x, float y) => transform.position = transform.position.WithXY(x, y);

        /// <summary>
        /// Sets x and y position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetPositionXY(this Transform transform, Vector2 position) => transform.position = transform.position.WithXY(position);

        /// <summary>
        /// Sets x and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetPositionXZ(this Transform transform, float x, float z) => transform.position = transform.position.WithXZ(x, z);

        /// <summary>
        /// Sets x and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetPositionXZ(this Transform transform, Vector2 position) => transform.position = transform.position.WithXZ(position);

        /// <summary>
        /// Sets y and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetPositionYZ(this Transform transform, float y, float z) => transform.position = transform.position.WithYZ(y, z);

        /// <summary>
        /// Sets y and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetPositionYZ(this Transform transform, Vector2 position) => transform.position = transform.position.WithYZ(position);

        /// <summary>
        /// Sets local x position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetLocalPositionX(this Transform transform, float x) => transform.localPosition = transform.localPosition.WithX(x);

        /// <summary>
        /// Sets local y position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetLocalPositionY(this Transform transform, float y) => transform.localPosition = transform.localPosition.WithY(y);

        /// <summary>
        /// Sets local z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalPositionZ(this Transform transform, float z) => transform.localPosition = transform.localPosition.WithZ(z);

        /// <summary>
        /// Sets local x and y position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetLocalPositionXY(this Transform transform, float x, float y) => transform.localPosition = transform.localPosition.WithXY(x, y);

        /// <summary>
        /// Sets local x and y position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetLocalPositionXY(this Transform transform, Vector2 position) => transform.position = transform.localPosition.WithXY(position);

        /// <summary>
        /// Sets local x and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalPositionXZ(this Transform transform, float x, float z) => transform.localPosition = transform.localPosition.WithXZ(x, z);

        /// <summary>
        /// Sets local x and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetLocalPositionXZ(this Transform transform, Vector2 position) => transform.position = transform.localPosition.WithXZ(position);

        /// <summary>
        /// Sets local y and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalPositionYZ(this Transform transform, float y, float z) => transform.localPosition = transform.localPosition.WithYZ(y, z);

        /// <summary>
        /// Sets local y and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetLocalPositionYZ(this Transform transform, Vector2 position) => transform.position = transform.localPosition.WithYZ(position);

        /// <summary>
        /// Sets euler angles x value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetEulerAnglesX(this Transform transform, float x) => transform.eulerAngles = transform.eulerAngles.WithX(x);

        /// <summary>
        /// Sets euler angles y value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetEulerAnglesY(this Transform transform, float y) => transform.eulerAngles = transform.eulerAngles.WithY(y);

        /// <summary>
        /// Sets euler angles z value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="z">Value to set.</param>
        public static void SetEulerAnglesZ(this Transform transform, float z) => transform.eulerAngles = transform.eulerAngles.WithZ(z);

        /// <summary>
        /// Sets euler angles x and y values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetEulerAnglesXY(this Transform transform, float x, float y) => transform.eulerAngles = transform.eulerAngles.WithXY(x, y);

        /// <summary>
        /// Sets euler angles x and y values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="eulers">Angles to set.</param>
        public static void SetEulerAnglesXY(this Transform transform, Vector2 eulers) => transform.eulerAngles = transform.eulerAngles.WithXY(eulers);

        /// <summary>
        /// Sets euler angles x and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetEulerAnglesXZ(this Transform transform, float x, float z) => transform.eulerAngles = transform.eulerAngles.WithXZ(x, z);

        /// <summary>
        /// Sets euler angles x and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="eulers">Angles to set.</param>
        public static void SetEulerAnglesXZ(this Transform transform, Vector2 eulers) => transform.eulerAngles = transform.eulerAngles.WithXZ(eulers);

        /// <summary>
        /// Sets euler angles y and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetEulerAnglesYZ(this Transform transform, float y, float z) => transform.eulerAngles = transform.eulerAngles.WithYZ(y, z);

        /// <summary>
        /// Sets euler angles y and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="eulers">Angles to set.</param>
        public static void SetEulerAnglesYZ(this Transform transform, Vector2 eulers) => transform.eulerAngles = transform.eulerAngles.WithYZ(eulers);

        /// <summary>
        /// Sets local euler angles x value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetLocalEulerAnglesX(this Transform transform, float x) => transform.localEulerAngles = transform.localEulerAngles.WithX(x);

        /// <summary>
        /// Sets local euler angles y value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetLocalEulerAnglesY(this Transform transform, float y) => transform.localEulerAngles = transform.localEulerAngles.WithY(y);

        /// <summary>
        /// Sets local euler angles z value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalEulerAnglesZ(this Transform transform, float z) => transform.localEulerAngles = transform.localEulerAngles.WithZ(z);

        /// <summary>
        /// Sets local euler angles x and y values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetLocalEulerAnglesXY(this Transform transform, float x, float y) => transform.localEulerAngles = transform.localEulerAngles.WithXY(x, y);

        /// <summary>
        /// Sets local euler angles x and y values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="eulers">Angles to set.</param>
        public static void SetLocalEulerAnglesXY(this Transform transform, Vector2 eulers) => transform.localEulerAngles = transform.localEulerAngles.WithXY(eulers);

        /// <summary>
        /// Sets local euler angles x and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalEulerAnglesXZ(this Transform transform, float x, float z) => transform.localEulerAngles = transform.localEulerAngles.WithXZ(x, z);

        /// <summary>
        /// Sets local euler angles x and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="eulers">Angles to set.</param>
        public static void SetLocalEulerAnglesXZ(this Transform transform, Vector2 eulers) => transform.localEulerAngles = transform.localEulerAngles.WithXZ(eulers);

        /// <summary>
        /// Sets local euler angles y and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalEulerAnglesYZ(this Transform transform, float y, float z) => transform.localEulerAngles = transform.localEulerAngles.WithYZ(y, z);

        /// <summary>
        /// Sets local euler angles y and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="eulers">Angles to set.</param>
        public static void SetLocalEulerAnglesYZ(this Transform transform, Vector2 eulers) => transform.localEulerAngles = transform.localEulerAngles.WithYZ(eulers);

        /// <summary>
        /// Sets local scale x value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetLocalScaleX(this Transform transform, float x) => transform.localScale = transform.localScale.WithX(x);

        /// <summary>
        /// Sets local scale y value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetLocalScaleY(this Transform transform, float y) => transform.localScale = transform.localScale.WithY(y);

        /// <summary>
        /// Sets local scale z value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalScaleZ(this Transform transform, float z) => transform.localScale = transform.localScale.WithZ(z);

        /// <summary>
        /// Sets local scale x and y values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetLocalScaleXY(this Transform transform, float x, float y) => transform.localScale = transform.localScale.WithXY(x, y);

        /// <summary>
        /// Sets local scale x and y values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="scale">Scale to set.</param>
        public static void SetLocalScaleXY(this Transform transform, Vector2 scale) => transform.localScale = transform.localScale.WithXY(scale);

        /// <summary>
        /// Sets local scale x and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalScaleXZ(this Transform transform, float x, float z) => transform.localScale = transform.localScale.WithXZ(x, z);

        /// <summary>
        /// Sets local scale x and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="scale">Scale to set.</param>
        public static void SetLocalScaleXZ(this Transform transform, Vector2 scale) => transform.localScale = transform.localScale.WithXZ(scale);

        /// <summary>
        /// Sets local scale y and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalScaleYZ(this Transform transform, float y, float z) => transform.localScale = transform.localScale.WithYZ(y, z);

        /// <summary>
        /// Sets local scale y and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="scale">Scale to set.</param>
        public static void SetLocalScaleYZ(this Transform transform, Vector2 scale) => transform.localScale = transform.localScale.WithYZ(scale);

        /// <summary>
        /// Sets uniform local scale.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="scale">Uniform scale to set.</param>
        public static void SetLocalScale(this Transform transform, float scale) => transform.localScale = transform.localScale = new Vector3(scale, scale, scale);

        /// <summary>
        /// Resets transform position, rotation and scale.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="useWorldSpace">Use world space?</param>
        public static void Reset(this Transform transform, bool useWorldSpace = false)
        {
            if (useWorldSpace)
                transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
            else
            {
                transform.localPosition = Vector3.zero;
                transform.localRotation = Quaternion.identity;
            }

            transform.localScale = Vector3.one;
        }

        /// <summary>
        /// Sets sibling index to previous.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void SetToPreviousSibling(this Transform transform) => transform.SetSiblingIndex(Mathf.Max(transform.GetSiblingIndex() - 1, 0));

        /// <summary>
        /// Sets sibling index to next.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void SetToNextSibling(this Transform transform)
        {
            var maxSiblingIndex = (transform.parent != null ? transform.parent.childCount : transform.gameObject.scene.rootCount) - 1;
            transform.SetSiblingIndex(Mathf.Min(transform.GetSiblingIndex() + 1, maxSiblingIndex));
        }

        /// <summary>
        /// Returns the previous transform next to the current object. If there is no previous one, then the current transform is returned.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <returns>Previous object's transform.</returns>
        public static Transform GetPreviousSiblingTransform(this Transform transform)
        {
            if (transform.GetSiblingIndex() == 0)
                return null;

            if (transform.parent)
                return transform.parent.GetChild(transform.GetSiblingIndex() - 1);
            else
                return transform.gameObject.scene.GetRootGameObjects()[transform.GetSiblingIndex() - 1].transform;
        }

        /// <summary>
        /// Returns the next transform next to the current object. If there is no next one, then the current transform is returned.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <returns>Next object's transform.</returns>
        public static Transform GetNextSiblingTransform(this Transform transform)
        {
            if (transform.parent)
            {
                if (transform.GetSiblingIndex() == transform.parent.childCount - 1)
                    return null;

                return transform.parent.GetChild(transform.GetSiblingIndex() + 1);
            }

            if (transform.GetSiblingIndex() == transform.gameObject.scene.rootCount - 1)
                return null;

            return transform.gameObject.scene.GetRootGameObjects()[transform.GetSiblingIndex() + 1].transform;
        }

        /// <summary>
        /// Returns all sibling objects (its transform components).
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="includeThis">Include this <paramref name="transform"/> object.</param>
        /// <returns>Sibling objects transforms.</returns>
        public static List<Transform> GetAllSiblingObjects(this Transform transform, bool includeThis = true)
        {
            List<Transform> siblings;

            if (transform.parent)
            {
                siblings = new List<Transform>(transform.parent.childCount);

                for (int i = 0; i < transform.parent.childCount; i++)
                {
                    var child = transform.parent.GetChild(i);

                    if (includeThis || !includeThis && child != transform)
                        siblings.Add(child);
                }    
            }
            else
            {
                var childs = transform.gameObject.scene.GetRootGameObjects();
                siblings = new List<Transform>(childs.Length);

                for (int i = 0; i < childs.Length; i++)
                {
                    var child = childs[i].transform;

                    if (includeThis || !includeThis && child != transform)
                        siblings.Add(child);
                }
            }

            return siblings;
        }

        /// <summary>
        /// Gets list of all childs.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <returns>List of all childs.</returns>
        public static List<Transform> GetChilds(this Transform transform) => transform.Cast<Transform>().ToList();

        /// <summary>
        /// Gets a random child.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <returns>Random child.</returns>
        public static Transform GetRandomChild(this Transform transform) => transform.GetChild(UnityEngine.Random.Range(0, transform.childCount));

        /// <summary>
        /// Adds childs to transform.
        /// </summary>
        /// <param name="childs">Childs to add.</param>
        /// <param name="transform">Target transform.</param>
        public static void AddChilds(this Transform transform, params Transform[] childs) => AddChilds(transform, (IEnumerable<Transform>)childs);

        /// <summary>
        /// Adds childs to transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="childs">Childs to add.</param>
        public static void AddChilds(this Transform transform, IEnumerable<Transform> childs)
        {
            foreach (var child in childs)
                child.parent = transform;
        }

        /// <summary>
        /// Destroy all childs.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void DestroyChilds(this Transform transform) => GetChilds(transform).ForEach(child => UnityObject.Destroy(child.gameObject));

        /// <summary>
        /// Destroy all childs start from <paramref name="index"/>.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void DestroyChilds(this Transform transform, int index) => GetChilds(transform).Skip(index).ForEach(child => UnityObject.Destroy(child.gameObject));

        /// <summary>
        /// Destroy <paramref name="count"/> childs start from <paramref name="index"/>.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void DestroyChilds(this Transform transform, int index, int count) => GetChilds(transform).Skip(index).Take(count).ForEach(child => UnityObject.Destroy(child.gameObject));

        /// <summary>
        /// Destroy all childs by coindition.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="predicate">Condition.</param>
        public static void DestroyChildsWhere(this Transform transform, Predicate<Transform> predicate)
        {
            var filtered = GetChilds(transform).Where(c => predicate(c));

            foreach (var child in filtered)
                UnityObject.Destroy(child.gameObject);
        }

        /// <summary>
        /// Destroy child by index.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void DestroyChild(this Transform transform, int index) => UnityObject.Destroy(transform.GetChild(index).gameObject);

        /// <summary>
        /// Destroy first child.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void DestroyFirstChild(this Transform transform) => DestroyChild(transform, 0);

        /// <summary>
        /// Destroy last child.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void DestroyLastChild(this Transform transform) => DestroyChild(transform, transform.childCount - 1);

        /// <summary>
        /// Cast transform to RectTransform type.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <returns>Casted RectTransform object.</returns>
        public static RectTransform AsRect(this Transform transform) => transform as RectTransform;
    }
}