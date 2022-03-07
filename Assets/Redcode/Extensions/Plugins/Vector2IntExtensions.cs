using UnityEngine;

namespace Redcode.Extensions
{
    public static class Vector2IntExtensions
    {
        /// <summary>
        /// Sets value to vector's axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="axis">Axis index of the vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector2Int With(this Vector2Int vector, int axis, int value)
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
        public static Vector2Int WithX(this Vector2Int vector, int x) => With(vector, 0, x);

        /// <summary>
        /// Sets value to vector's y axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="y">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector2Int WithY(this Vector2Int vector, int y) => With(vector, 1, y);

        /// <summary>
        /// Gets inverted vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Inverted vector.</returns>
        public static Vector2Int GetYX(this Vector2Int vector) => new Vector2Int(vector.y, vector.x);

        /// <summary>
        /// Inserts value to x axis and extends vector to 3-dimensional.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="x">Value to set.</param>
        /// <returns>3-dimensional vector.</returns>
        public static Vector3Int InsertX(this Vector2Int vector, int x = 0) => new Vector3Int(x, vector.x, vector.y);

        /// <summary>
        /// Inserts value to y axis and extends vector to 3-dimensional.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="y">Value to set.</param>
        /// <returns>3-dimensional vector.</returns>
        public static Vector3Int InsertY(this Vector2Int vector, int y = 0) => new Vector3Int(vector.x, y, vector.y);

        /// <summary>
        /// Inserts value to z axis and extends vector to 3-dimensional.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>3-dimensional vector.</returns>
        public static Vector3Int InsertZ(this Vector2Int vector, int z = 0) => new Vector3Int(vector.x, vector.y, z);

        /// <summary>
        /// Gets max component from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's max component</returns>
        public static int MaxComponent(this Vector2Int vector) => Mathf.Max(vector.x, vector.y);

        /// <summary>
        /// Gets min component from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's min component</returns>
        public static int MinComponent(this Vector2Int vector) => Mathf.Min(vector.x, vector.y);
    }
}