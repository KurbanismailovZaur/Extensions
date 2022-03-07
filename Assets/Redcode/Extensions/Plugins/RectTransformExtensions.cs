using UnityEngine;

namespace Redcode.Extensions
{
    public static class RectTransformExtensions
    {
        /// <summary>
        /// Sets size delta x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetSizeDeltaX(this RectTransform rectTransform, float x) => rectTransform.sizeDelta = rectTransform.sizeDelta.WithX(x);

        /// <summary>
        /// Sets size delta y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetSizeDeltaY(this RectTransform rectTransform, float y) => rectTransform.sizeDelta = rectTransform.sizeDelta.WithY(y);

        /// <summary>
        /// Sets anchor min x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetAnchorMinX(this RectTransform rectTransform, float x) => rectTransform.anchorMin = rectTransform.anchorMin.WithX(x);

        /// <summary>
        /// Sets anchor min y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetAnchorMinY(this RectTransform rectTransform, float y) => rectTransform.anchorMin = rectTransform.anchorMin.WithY(y);

        /// <summary>
        /// Sets anchor max x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetAnchorMaxX(this RectTransform rectTransform, float x) => rectTransform.anchorMax = rectTransform.anchorMax.WithX(x);

        /// <summary>
        /// Sets anchor max y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetAnchorMaxY(this RectTransform rectTransform, float y) => rectTransform.anchorMax = rectTransform.anchorMax.WithY(y);

        /// <summary>
        /// Sets offset min x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetOffsetMinX(this RectTransform rectTransform, float x) => rectTransform.offsetMin = rectTransform.offsetMin.WithX(x);

        /// <summary>
        /// Sets offset min y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetOffsetMinY(this RectTransform rectTransform, float y) => rectTransform.offsetMin = rectTransform.offsetMin.WithY(y);

        /// <summary>
        /// Sets offset max x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetOffsetMaxX(this RectTransform rectTransform, float x) => rectTransform.offsetMax = rectTransform.offsetMax.WithX(x);

        /// <summary>
        /// Sets offset max y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetOffsetMaxY(this RectTransform rectTransform, float y) => rectTransform.offsetMax = rectTransform.offsetMax.WithY(y);

        /// <summary>
        /// Sets anchor position x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetAnchoredPositionX(this RectTransform rectTransform, float x) => rectTransform.anchoredPosition = rectTransform.anchoredPosition.WithX(x);

        /// <summary>
        /// Sets anchor position y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetAnchoredPositionY(this RectTransform rectTransform, float y) => rectTransform.anchoredPosition = rectTransform.anchoredPosition.WithY(y);

        /// <summary>
        /// Sets anchor position 3d x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetAnchoredPosition3DX(this RectTransform rectTransform, float x) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithX(x);

        /// <summary>
        /// Sets anchor position 3d y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetAnchoredPosition3DY(this RectTransform rectTransform, float y) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithY(y);

        /// <summary>
        /// Sets anchor position 3d z value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="z">Value to set.</param>
        public static void SetAnchoredPosition3DZ(this RectTransform rectTransform, float z) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithZ(z);

        /// <summary>
        /// Sets anchor position 3d x and y values of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetAnchoredPosition3DXY(this RectTransform rectTransform, float x, float y) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXY(x, y);

        /// <summary>
        /// Sets anchor position 3d x and y values of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetAnchoredPosition3DXY(this RectTransform rectTransform, Vector2 position) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXY(position.x, position.y);

        /// <summary>
        /// Sets anchor position 3d x and z values of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetAnchoredPosition3DXZ(this RectTransform rectTransform, float x, float z) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXZ(x, z);

        /// <summary>
        /// Sets anchor position 3d x and z values of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetAnchoredPosition3DXZ(this RectTransform rectTransform, Vector2 position) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXZ(position.x, position.y);

        /// <summary>
        /// Sets anchor position 3d y and z values of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetAnchoredPosition3DYZ(this RectTransform rectTransform, float y, float z) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithYZ(y, z);

        /// <summary>
        /// Sets anchor position 3d y and z values of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetAnchoredPosition3DYZ(this RectTransform rectTransform, Vector2 position) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithYZ(position.x, position.y);

        /// <summary>
        /// Sets pivot x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>

        public static void SetPivotX(this RectTransform rectTransform, float x) => rectTransform.pivot = rectTransform.pivot.WithX(x);

        /// <summary>
        /// Sets pivot y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetPivotY(this RectTransform rectTransform, float y) => rectTransform.pivot = rectTransform.pivot.WithY(y);

        /// <summary>
        /// Sets pivot x value of the rectTransform without any changes min and max points.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetPivotOnlyX(this RectTransform rectTransform, float x)
        {
            var deltaPercent = rectTransform.pivot.x - x;
            rectTransform.SetPivotX(x);
            rectTransform.SetAnchoredPositionX(rectTransform.anchoredPosition.x - rectTransform.sizeDelta.x * deltaPercent);
        }

        /// <summary>
        /// Sets pivot y value of the rectTransform without any changes min and max points.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetPivotOnlyY(this RectTransform rectTransform, float y)
        {
            var deltaPercent = rectTransform.pivot.y - y;
            rectTransform.SetPivotY(y);
            rectTransform.SetAnchoredPositionY(rectTransform.anchoredPosition.y - rectTransform.sizeDelta.y * deltaPercent);
        }

        /// <summary>
        /// Sets pivot value of the rectTransform without any changes min and max points.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="pivot">Value to set.</param>
        public static void SetPivotOnly(this RectTransform rectTransform, Vector2 pivot) => SetPivotOnly(rectTransform, pivot.x, pivot.y);

        /// <summary>
        /// Sets pivot x and y values of the rectTransform without any changes min and max points.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetPivotOnly(this RectTransform rectTransform, float x, float y)
        {
            SetPivotOnlyX(rectTransform, x);
            SetPivotOnlyY(rectTransform, y);
        }

        /// <summary>
        /// Calculate size of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        public static Vector2 GetSize(this RectTransform rectTransform)
        {
            if (rectTransform.GetComponent<Canvas>() != null)
                return rectTransform.sizeDelta;

            return Vector2.Scale(GetSize(rectTransform.parent as RectTransform), rectTransform.anchorMax - rectTransform.anchorMin) + rectTransform.sizeDelta;
        }
    }
}