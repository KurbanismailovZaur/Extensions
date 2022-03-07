using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Redcode.Extensions
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
        /// Sets sibling index to previous.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void SetToPreviousSibling(this Transform transform) => transform.SetSiblingIndex(transform.GetSiblingIndex() - 1);

        /// <summary>
        /// Sets sibling index to next.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void SetToNextSibling(this Transform transform) => transform.SetSiblingIndex(transform.GetSiblingIndex() + 1);

        /// <summary>
        /// Gets list of all childs.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <returns>List of all childs.</returns>
        public static List<Transform> GetChilds(this Transform transform) => Enumerable.Range(0, transform.childCount).Select(index => transform.GetChild(index)).ToList();

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
        public static void DestroyChilds(this Transform transform) => GetChilds(transform).ForEach(child => GameObject.Destroy(child.gameObject));

        /// <summary>
        /// Destroy all childs by coindition.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="predicate">Condition.</param>
        public static void DestroyChildsWhere(this Transform transform, Predicate<Transform> predicate)
        {
            var filtered = GetChilds(transform).Where(c => predicate(c));

            foreach (var child in filtered)
                GameObject.Destroy(child.gameObject);
        }

        /// <summary>
        /// Destroy child by index.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void DestroyChild(this Transform transform, int index) => GameObject.Destroy(transform.GetChild(index).gameObject);

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
    }
}