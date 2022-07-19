using UnityEngine;

namespace Redcode.Extensions
{
    public static class Vector2Extensions
    {
        /// <summary>
        /// Sets value to vector's axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="axis">Axis index of the vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector2 With(this Vector2 vector, int axis, float value)
        {
            vector[axis] = value;
            return vector;
        }

        /// <summary>
        /// Sets value to vector's x axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="x">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector2 WithX(this Vector2 vector, float x) => With(vector, 0, x);

        /// <summary>
        /// Sets value to vector's y axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="y">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector2 WithY(this Vector2 vector, float y) => With(vector, 1, y);

        /// <summary>
        /// Gets inverted vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Inverted vector.</returns>
        public static Vector2 GetYX(this Vector2 vector) => new Vector2(vector.y, vector.x);

        /// <summary>
        /// Inserts value to x axis and extends vector to 3-dimensional.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="x">Value to set.</param>
        /// <returns>3-dimensional vector.</returns>
        public static Vector3 InsertX(this Vector2 vector, float x = 0) => new Vector3(x, vector.x, vector.y);

        /// <summary>
        /// Inserts value to y axis and extends vector to 3-dimensional.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="y">Value to set.</param>
        /// <returns>3-dimensional vector.</returns>
        public static Vector3 InsertY(this Vector2 vector, float y = 0) => new Vector3(vector.x, y, vector.y);

        /// <summary>
        /// Inserts value to z axis and extends vector to 3-dimensional.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>3-dimensional vector.</returns>
        public static Vector3 InsertZ(this Vector2 vector, float z = 0) => new Vector3(vector.x, vector.y, z);

        /// <summary>
        /// Gets max component from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's max component</returns>
        public static float MaxComponent(this Vector2 vector) => Mathf.Max(vector.x, vector.y);

        /// <summary>
        /// Gets min component from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's min component</returns>
        public static float MinComponent(this Vector2 vector) => Mathf.Min(vector.x, vector.y);

        /// <summary>
        /// Remaps all vector's components from one interval to other.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="min1">Min value of the beginning interval.</param>
        /// <param name="max1">Max value of the beginning interval.</param>
        /// <param name="min2">Min value of the target interval.</param>
        /// <param name="max2">Max value of the target interval.</param>
        /// <returns>Remaped vector.</returns>
        public static Vector2 Remap(this Vector2 vector, float min1, float max1, float min2, float max2)
        {
            return new Vector2(vector.x.Remap(min1, max1, min2, max2), vector.y.Remap(min1, max1, min2, max2));
        }
    }
}