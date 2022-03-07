using UnityEngine;

namespace Redcode.Extensions
{
    public static class Vector3IntExtensions
    {
        /// <summary>
        /// Sets value to vector's axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="axis">Axis index of the vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector3Int With(this Vector3Int vector, int axis, int value)
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
        public static Vector3Int WithX(this Vector3Int vector, int x) => With(vector, 0, x);

        /// <summary>
        /// Sets value to vector's y axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="y">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector3Int WithY(this Vector3Int vector, int y) => With(vector, 1, y);

        /// <summary>
        /// Sets value to vector's z axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector3Int WithZ(this Vector3Int vector, int z) => With(vector, 2, z);

        /// <summary>
        /// Sets values to vector's axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="axis1">First axis index of the vector.</param>
        /// <param name="value1">First value to set.</param>
        /// <param name="axis2">Second axis index of the vector.</param>
        /// <param name="value2">Second value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector3Int With(this Vector3Int vector, int axis1, int value1, int axis2, int value2)
        {
            vector[axis1] = value1;
            vector[axis2] = value2;

            return vector;
        }

        /// <summary>
        /// Sets value to vector's x and y axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector3Int WithXY(this Vector3Int vector, int x, int y) => With(vector, 0, x, 1, y);

        /// <summary>
        /// Sets value to vector's x and y axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector3 WithXY(this Vector3Int vector, Vector2Int value) => With(vector, 0, value.x, 1, value.y);

        /// <summary>
        /// Sets value to vector's x and z axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector3Int WithXZ(this Vector3Int vector, int x, int z) => With(vector, 0, x, 2, z);

        /// <summary>
        /// Sets value to vector's x and z axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector3 WithXZ(this Vector3Int vector, Vector2Int value) => With(vector, 0, value.x, 2, value.y);

        /// <summary>
        /// Sets value to vector's y and z axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector3Int WithYZ(this Vector3Int vector, int y, int z) => With(vector, 1, y, 2, z);

        /// <summary>
        /// Sets value to vector's y and z axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector3 WithYZ(this Vector3Int vector, Vector2Int value) => With(vector, 1, value.x, 2, value.y);

        /// <summary>
        /// Gets <see cref="Vector2"/> by axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="axis1">First axis.</param>
        /// <param name="axis2">Second axis.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2Int Get(this Vector3Int vector, int axis1, int axis2) => new Vector2Int(vector[axis1], vector[axis2]);

        /// <summary>
        /// Gets <see cref="Vector2"/> by x and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2Int GetXY(this Vector3Int vector) => Get(vector, 0, 1);

        /// <summary>
        /// Gets <see cref="Vector2"/> by x and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2Int GetXZ(this Vector3Int vector) => Get(vector, 0, 2);

        /// <summary>
        /// Gets <see cref="Vector2"/> by y and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2Int GetYX(this Vector3Int vector) => Get(vector, 1, 0);

        /// <summary>
        /// Gets <see cref="Vector2"/> by y and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2Int GetYZ(this Vector3Int vector) => Get(vector, 1, 2);

        /// <summary>
        /// Gets <see cref="Vector2"/> by z and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2Int GetZX(this Vector3Int vector) => Get(vector, 2, 0);

        /// <summary>
        /// Gets <see cref="Vector2"/> by z and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2Int GetZY(this Vector3Int vector) => Get(vector, 2, 1);

        /// <summary>
        /// Gets vector with swapped axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="axis1">First axis.</param>
        /// <param name="axis2">Second axis.</param>
        /// <param name="axis3">Third axis.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector3Int Get(this Vector3Int vector, int axis1, int axis2, int axis3) => new Vector3Int(vector[axis1], vector[axis2], vector[axis3]);

        /// <summary>
        /// Gets vector with with order XZY.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector3Int GetXZY(this Vector3Int vector) => Get(vector, 0, 2, 1);

        /// <summary>
        /// Gets vector with with order YXZ.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector3Int GetYXZ(this Vector3Int vector) => Get(vector, 1, 0, 2);

        /// <summary>
        /// Gets vector with with order YZX.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector3Int GetYZX(this Vector3Int vector) => Get(vector, 1, 2, 0);

        /// <summary>
        /// Gets vector with with order ZXY.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector3Int GetZXY(this Vector3Int vector) => Get(vector, 2, 0, 1);

        /// <summary>
        /// Gets vector with with order ZYX.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector3Int GetZYX(this Vector3Int vector) => Get(vector, 2, 1, 0);

        /// <summary>
        /// Gets max component from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's max component</returns>
        public static int MaxComponent(this Vector3Int vector) => Mathf.Max(vector.x, vector.y, vector.z);

        /// <summary>
        /// Gets min component from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's min component</returns>
        public static int MinComponent(this Vector3Int vector) => Mathf.Min(vector.x, vector.y, vector.z);
    }
}