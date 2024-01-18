using System.Collections.Generic;
using UnityEngine;

namespace Codomaster.Extensions
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
        /// Inverts value of specified axis.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <param name="axis">Target axis.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector3Int WithNegate(this Vector3Int vector, int axis) => vector.With(axis, -vector[axis]);

        /// <summary>
        /// Inverts x axis value.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector3Int WithNegateX(this Vector3Int vector) => WithNegate(vector, 0);

        /// <summary>
        /// Inverts y axis value.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector3Int WithNegateY(this Vector3Int vector) => WithNegate(vector, 1);

        /// <summary>
        /// Inverts z axis value.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector3Int WithNegateZ(this Vector3Int vector) => WithNegate(vector, 2);

        /// <summary>
        /// Inverts values of specified axes.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <param name="axis1">First axis.</param>
        /// <param name="axis2">Second axis.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector3Int WithNegate(this Vector3Int vector, int axis1, int axis2)
        {
            vector[axis1] = -vector[axis1];
            vector[axis2] = -vector[axis2];

            return vector;
        }

        /// <summary>
        /// Inverts x and y axes values.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector3Int WithNegateXY(this Vector3Int vector) => vector.WithNegate(0, 1);

        /// <summary>
        /// Inverts x and z axes values.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector3Int WithNegateXZ(this Vector3Int vector) => vector.WithNegate(0, 2);

        /// <summary>
        /// Inverts y and z axes values.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector3Int WithNegateYZ(this Vector3Int vector) => vector.WithNegate(1, 2);

        /// <summary>
        /// Inverts vector.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Inverted vector.</returns>
        public static Vector3Int Negate(this Vector3Int vector) => new(-vector.x, -vector.y, -vector.z);

        /// <summary>
        /// Gets <see cref="Vector2"/> by axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="axis1">First axis.</param>
        /// <param name="axis2">Second axis.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2Int Get(this Vector3Int vector, int axis1, int axis2) => new(vector[axis1], vector[axis2]);

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
        public static Vector3Int Get(this Vector3Int vector, int axis1, int axis2, int axis3) => new(vector[axis1], vector[axis2], vector[axis3]);

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

        private static void Compare(Vector3Int vector, ref int index, int compareIndex, int result)
        {
            if (vector[compareIndex].CompareTo(vector[index]) == result)
                index = compareIndex;
        }

        private static int CompareAllComponents(Vector3Int vector, int result)
        {
            var index = 0;

            Compare(vector, ref index, 1, result);
            Compare(vector, ref index, 2, result);

            return index;
        }

        /// <summary>
        /// Gets max component info from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's max component tuple info.</returns>
        public static (int index, float value) MaxComponent(this Vector3Int vector)
        {
            var index = CompareAllComponents(vector, 1);
            return (index, vector[index]);
        }

        /// <summary>
        /// Gets min component info from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's min component tuple info.</returns>
        public static (int index, float value) MinComponent(this Vector3Int vector)
        {
            var index = CompareAllComponents(vector, -1);
            return (index, vector[index]);
        }

        /// <summary>
        /// Creates new vector with absolute components.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector with absolute components.</returns>
        public static Vector3Int Abs(this Vector3Int vector) => new(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));

        /// <summary>
        /// Creates new vector with clamped components.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="min">The minimum floating value to campare agains.</param>
        /// <param name="max">The maximum floating value to campare agains.</param>
        /// <returns>Clamped vector.</returns>
        public static Vector3Int Clamp(this Vector3Int vector, int min, int max)
        {
            return new Vector3Int(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max), Mathf.Clamp(vector.z, min, max));
        }

        /// <summary>
        /// Creates and returns a vector whose components are divided by the value.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="other">Vector on which divide</param>
        /// <returns>Divided vector.</returns>
        public static Vector3Int Divide(this Vector3Int vector, Vector3Int other)
        {
            return new Vector3Int(vector.x / other.x, vector.y / other.y, vector.z / other.z);
        }

        /// <summary>
        /// Checks if the vector components are equals.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see langword="true"/> if vector's components are equals.</returns>
        public static bool IsUniform(this Vector3Int vector) => vector.x == vector.y && vector.y == vector.z;

        /// <summary>
        /// Gets closest point info from <paramref name="points"/> list.
        /// </summary>
        /// <param name="point">Origin point.</param>
        /// <param name="points">Compared points.</param>
        /// <returns>Closest point tuple info.</returns>
        public static (Vector3Int point, int index) GetClosestPoint(this Vector3Int point, params Vector3Int[] points)
        {
            return GetClosestPoint(point, (IEnumerable<Vector3Int>)points);
        }

        /// <summary>
        /// Gets closest point info from <paramref name="points"/> list.
        /// </summary>
        /// <param name="point">Origin point.</param>
        /// <param name="points">Compared points.</param>
        /// <returns>Closest point tuple info.</returns>
        public static (Vector3Int point, int index) GetClosestPoint(this Vector3Int point, IEnumerable<Vector3Int> points)
        {
            var enumerator = points.GetEnumerator();

            var index = -1;
            var closestIndex = -1;
            var closestPoint = Vector3Int.zero;
            var closestDistance = float.MaxValue;

            while (enumerator.MoveNext())
            {
                ++index;
                var distance = Vector3Int.Distance(point, enumerator.Current);

                if (distance < closestDistance)
                {
                    closestIndex = index;
                    closestDistance = distance;
                    closestPoint = enumerator.Current;
                }
            }

            return (closestPoint, closestIndex);
        }

        /// <summary>
        /// Get the closest point on a ray.
        /// </summary>
        /// <param name="point">A point in space.</param>
        /// <param name="origin">Start point of ray.</param>
        /// <param name="direction">Ray direction. Must be normalized.</param>
        /// <returns>Tuple which contains closest point on line and distance from <paramref name="origin"/> to calculated point.</returns>
        public static (Vector3 point, float distance) GetClosestPointOnRay(this Vector3Int point, Vector3 origin, Vector3 direction)
        {
            return Vector3Extensions.GetClosestPointOnRay(point, origin, direction);
        }

        /// <summary>
        /// Get the closest point on a line segment.
        /// </summary>
        /// <param name="point">A point in space.</param>
        /// <param name="start">Start of line segment.</param>
        /// <param name="end">End of line segment.</param>
        /// <returns>Tuple which contains closest point on line and distance from <paramref name="start"/> to calculated point.</returns>

        public static (Vector3 point, float distance) GetClosestPointOnSegment(this Vector3 point, Vector3 start, Vector3 end)
        {
            return Vector3Extensions.GetClosestPointOnSegment(point, start, end);
        }
    }
}