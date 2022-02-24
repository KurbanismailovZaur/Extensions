using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class TransformExtensions
    {
        public static void SetPositionX(this Transform transform, float x) => transform.position = transform.position.WithX(x);

        public static void SetPositionY(this Transform transform, float y) => transform.position = transform.position.WithY(y);

        public static void SetPositionZ(this Transform transform, float z) => transform.position = transform.position.WithZ(z);

        public static void SetPositionXY(this Transform transform, float x, float y) => transform.position = transform.position.WithXY(x, y);

        public static void SetPositionXZ(this Transform transform, float x, float z) => transform.position = transform.position.WithXZ(x, z);

        public static void SetPositionYZ(this Transform transform, float y, float z) => transform.position = transform.position.WithYZ(y, z);

        public static void SetLocalPositionX(this Transform transform, float x) => transform.localPosition = transform.localPosition.WithX(x);

        public static void SetLocalPositionY(this Transform transform, float y) => transform.localPosition = transform.localPosition.WithY(y);

        public static void SetLocalPositionZ(this Transform transform, float z) => transform.localPosition = transform.localPosition.WithZ(z);

        public static void SetLocalPositionXY(this Transform transform, float x, float y) => transform.localPosition = transform.localPosition.WithXY(x, y);

        public static void SetLocalPositionXZ(this Transform transform, float x, float z) => transform.localPosition = transform.localPosition.WithXZ(x, z);

        public static void SetLocalPositionYZ(this Transform transform, float y, float z) => transform.localPosition = transform.localPosition.WithYZ(y, z);

        public static void SetEulerAnglesX(this Transform transform, float x) => transform.eulerAngles = transform.eulerAngles.WithX(x);

        public static void SetEulerAnglesY(this Transform transform, float y) => transform.eulerAngles = transform.eulerAngles.WithY(y);

        public static void SetEulerAnglesZ(this Transform transform, float z) => transform.eulerAngles = transform.eulerAngles.WithZ(z);

        public static void SetEulerAnglesXY(this Transform transform, float x, float y) => transform.eulerAngles = transform.eulerAngles.WithXY(x, y);

        public static void SetEulerAnglesXZ(this Transform transform, float x, float z) => transform.eulerAngles = transform.eulerAngles.WithXZ(x, z);

        public static void SetEulerAnglesYZ(this Transform transform, float y, float z) => transform.eulerAngles = transform.eulerAngles.WithYZ(y, z);

        public static void SetLocalEulerAnglesX(this Transform transform, float x) => transform.localEulerAngles = transform.localEulerAngles.WithX(x);

        public static void SetLocalEulerAnglesY(this Transform transform, float y) => transform.localEulerAngles = transform.localEulerAngles.WithY(y);

        public static void SetLocalEulerAnglesZ(this Transform transform, float z) => transform.localEulerAngles = transform.localEulerAngles.WithZ(z);

        public static void SetLocalEulerAnglesXY(this Transform transform, float x, float y) => transform.localEulerAngles = transform.localEulerAngles.WithXY(x, y);

        public static void SetLocalEulerAnglesXZ(this Transform transform, float x, float z) => transform.localEulerAngles = transform.localEulerAngles.WithXZ(x, z);

        public static void SetLocalEulerAnglesYZ(this Transform transform, float y, float z) => transform.localEulerAngles = transform.localEulerAngles.WithYZ(y, z);

        public static void SetLocalScaleX(this Transform transform, float x) => transform.localScale = transform.localScale.WithX(x);

        public static void SetLocalScaleY(this Transform transform, float y) => transform.localScale = transform.localScale.WithY(y);

        public static void SetLocalScaleZ(this Transform transform, float z) => transform.localScale = transform.localScale.WithZ(z);

        public static void SetLocalScaleXY(this Transform transform, float x, float y) => transform.localScale = transform.localScale.WithXY(x, y);

        public static void SetLocalScaleXZ(this Transform transform, float x, float z) => transform.localScale = transform.localScale.WithXZ(x, z);

        public static void SetLocalScaleYZ(this Transform transform, float y, float z) => transform.localScale = transform.localScale.WithYZ(y, z);

        public static void SetAsPreviousSibling(this Transform transform) => transform.SetSiblingIndex(transform.GetSiblingIndex() - 1);

        public static void SetAsNextSibling(this Transform transform) => transform.SetSiblingIndex(transform.GetSiblingIndex() + 1);

        public static List<Transform> GetChilds(this Transform transform) => Enumerable.Range(0, transform.childCount).Select(index => transform.GetChild(index)).ToList();

        public static void AddChilds(this Transform transform, params Transform[] childs) => AddChilds(transform, (IEnumerable<Transform>)childs);

        public static void AddChilds(this Transform transform, IEnumerable<Transform> childs)
        {
            foreach (var child in childs)
                child.parent = transform;
        }

        public static void DestroyChilds(this Transform transform) => GetChilds(transform).ForEach(child => GameObject.Destroy(child.gameObject));

        public static void DestroyChildsWhere(this Transform transform, Predicate<Transform> predicate)
        {
            var filtered = GetChilds(transform).Where(c => predicate(c));

            foreach (var child in filtered)
                GameObject.Destroy(child.gameObject);
        }

        public static void DestroyChild(this Transform transform, int index) => GameObject.Destroy(transform.GetChild(index).gameObject);

        public static void DestroyFirstChild(this Transform transform) => DestroyChild(transform, 0);

        public static void DestroyLastChild(this Transform transform) => DestroyChild(transform, transform.childCount - 1);
    }
}