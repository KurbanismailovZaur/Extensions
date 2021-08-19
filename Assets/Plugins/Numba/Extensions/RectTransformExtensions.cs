using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class RectTransformExtensions
    {
        public static void SetSizeDeltaX(this RectTransform rectTransform, float x) => rectTransform.sizeDelta = rectTransform.sizeDelta.WithX(x);

        public static void SetSizeDeltaY(this RectTransform rectTransform, float y) => rectTransform.sizeDelta = rectTransform.sizeDelta.WithY(y);

        public static void SetAnchorMinX(this RectTransform rectTransform, float x) => rectTransform.anchorMin = rectTransform.anchorMin.WithX(x);

        public static void SetAnchorMinY(this RectTransform rectTransform, float y) => rectTransform.anchorMin = rectTransform.anchorMin.WithY(y);

        public static void SetAnchorMaxX(this RectTransform rectTransform, float x) => rectTransform.anchorMax = rectTransform.anchorMax.WithX(x);

        public static void SetAnchorMaxY(this RectTransform rectTransform, float y) => rectTransform.anchorMax = rectTransform.anchorMax.WithY(y);

        public static void SetAnchoredPositionX(this RectTransform rectTransform, float x) => rectTransform.anchoredPosition = rectTransform.anchoredPosition.WithX(x);

        public static void SetAnchoredPositionY(this RectTransform rectTransform, float y) => rectTransform.anchoredPosition = rectTransform.anchoredPosition.WithY(y);

        public static void SetAnchoredPosition3DX(this RectTransform rectTransform, float x) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithX(x);

        public static void SetAnchoredPosition3DY(this RectTransform rectTransform, float y) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithY(y);

        public static void SetAnchoredPosition3DZ(this RectTransform rectTransform, float z) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithZ(z);

        public static void SetAnchoredPosition3DXY(this RectTransform rectTransform, float x, float y) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXY(x, y);

        public static void SetAnchoredPosition3DXZ(this RectTransform rectTransform, float x, float z) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXZ(x, z);

        public static void SetAnchoredPosition3DYZ(this RectTransform rectTransform, float y, float z) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithYZ(y, z);

        public static void SetPivotX(this RectTransform rectTransform, float x) => rectTransform.pivot = rectTransform.pivot.WithX(x);

        public static void SetPivotY(this RectTransform rectTransform, float y) => rectTransform.pivot = rectTransform.pivot.WithY(y);

        public static void SetPivotOnlyX(this RectTransform rectTransform, float x)
        {
            var deltaPercent = rectTransform.pivot.x - x;
            rectTransform.SetPivotX(x);
            rectTransform.SetAnchoredPositionX(rectTransform.anchoredPosition.x - rectTransform.sizeDelta.x * deltaPercent);
        }

        public static void SetPivotOnlyY(this RectTransform rectTransform, float y)
        {
            var deltaPercent = rectTransform.pivot.y - y;
            rectTransform.SetPivotY(y);
            rectTransform.SetAnchoredPositionY(rectTransform.anchoredPosition.y - rectTransform.sizeDelta.y * deltaPercent);
        }

        public static void SetPivotOnly(this RectTransform rectTransform, float x, float y)
        {
            SetPivotOnlyX(rectTransform, x);
            SetPivotOnlyY(rectTransform, y);
        }

        public static void SetPivotOnly(this RectTransform rectTransform, Vector2 pivot) => SetPivotOnly(rectTransform, pivot.x, pivot.y);

        public static Vector2 GetSize(this RectTransform rectTransform)
        {
            if (rectTransform.GetComponent<Canvas>() != null)
                return rectTransform.sizeDelta;

            return Vector2.Scale(GetSize(rectTransform.parent as RectTransform), rectTransform.anchorMax - rectTransform.anchorMin) + rectTransform.sizeDelta;
        }
    }
}