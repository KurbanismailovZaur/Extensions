using UnityEngine;

namespace Redcode.Extensions
{
    public static class RectExtensions
    {
        /// <summary>
        /// Sets rect center.
        /// </summary>
        /// <param name="rect">Target rect.</param>
        /// <param name="center">Value to set.</param>
        /// <returns>Changed copy ot the <paramref name="rect"/></returns>
        public static Rect WithCenter(this Rect rect, Vector2 center)
        {
            rect.center = center;
            return rect;
        }

        /// <summary>
        /// Sets rect position.
        /// </summary>
        /// <param name="rect">Target rect.</param>
        /// <param name="position">Value to set.</param>
        /// <returns>Changed copy ot the <paramref name="rect"/></returns>
        public static Rect WithPosition(this Rect rect, Vector2 position)
        {
            rect.position = position;
            return rect;
        }

        /// <summary>
        /// Sets rect height.
        /// </summary>
        /// <param name="rect">Target rect.</param>
        /// <param name="height">Value to set.</param>
        /// <returns>Changed copy ot the <paramref name="rect"/></returns>
        public static Rect WithHeight(this Rect rect, float height)
        {
            rect.height = height;
            return rect;
        }

        /// <summary>
        /// Sets rect width.
        /// </summary>
        /// <param name="rect">Target rect.</param>
        /// <param name="width">Value to set.</param>
        /// <returns>Changed copy ot the <paramref name="rect"/></returns>
        public static Rect WithWidth(this Rect rect, float width)
        {
            rect.width = width;
            return rect;
        }

        /// <summary>
        /// Sets rect max point.
        /// </summary>
        /// <param name="rect">Target rect.</param>
        /// <param name="max">Value to set.</param>
        /// <returns>Changed copy ot the <paramref name="rect"/></returns>
        public static Rect WithMax(this Rect rect, Vector2 max)
        {
            rect.max = max;
            return rect;
        }

        /// <summary>
        /// Sets rect min point.
        /// </summary>
        /// <param name="rect">Target rect.</param>
        /// <param name="min">Value to set.</param>
        /// <returns>Changed copy ot the <paramref name="rect"/></returns>
        public static Rect WithMin(this Rect rect, Vector2 min)
        {
            rect.min = min;
            return rect;
        }

        /// <summary>
        /// Sets rect size.
        /// </summary>
        /// <param name="rect">Target rect.</param>
        /// <param name="size">Value to set.</param>
        /// <returns>Changed copy ot the <paramref name="rect"/></returns>
        public static Rect WithSize(this Rect rect, Vector2 size)
        {
            rect.size = size;
            return rect;
        }

        /// <summary>
        /// Sets rect x position.
        /// </summary>
        /// <param name="rect">Target rect.</param>
        /// <param name="x">Value to set.</param>
        /// <returns>Changed copy ot the <paramref name="rect"/></returns>
        public static Rect WithX(this Rect rect, float x)
        {
            rect.x = x;
            return rect;
        }

        /// <summary>
        /// Sets rect x position.
        /// </summary>
        /// <param name="rect">Target rect.</param>
        /// <param name="y">Value to set.</param>
        /// <returns>Changed copy ot the <paramref name="rect"/></returns>
        public static Rect WithY(this Rect rect, float y)
        {
            rect.y = y;
            return rect;
        }

        /// <summary>
        /// Sets rect x max position.
        /// </summary>
        /// <param name="rect">Target rect.</param>
        /// <param name="xMax">Value to set.</param>
        /// <returns>Changed copy ot the <paramref name="rect"/></returns>
        public static Rect WithXMax(this Rect rect, float xMax)
        {
            rect.xMax = xMax;
            return rect;
        }

        /// <summary>
        /// Sets rect x min position.
        /// </summary>
        /// <param name="rect">Target rect.</param>
        /// <param name="xMin">Value to set.</param>
        /// <returns>Changed copy ot the <paramref name="rect"/></returns>
        public static Rect WithXMin(this Rect rect, float xMin)
        {
            rect.xMin = xMin;
            return rect;
        }

        /// <summary>
        /// Sets rect y max position.
        /// </summary>
        /// <param name="rect">Target rect.</param>
        /// <param name="yMax">Value to set.</param>
        /// <returns>Changed copy ot the <paramref name="rect"/></returns>
        public static Rect WithYMax(this Rect rect, float yMax)
        {
            rect.yMax = yMax;
            return rect;
        }

        /// <summary>
        /// Sets rect y min position.
        /// </summary>
        /// <param name="rect">Target rect.</param>
        /// <param name="yMin">Value to set.</param>
        /// <returns>Changed copy ot the <paramref name="rect"/></returns>
        public static Rect WithYMin(this Rect rect, float yMin)
        {
            rect.yMin = yMin;
            return rect;
        }
    }
}