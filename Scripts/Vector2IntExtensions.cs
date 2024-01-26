using System.Collections.Generic;
using UnityEngine;

namespace Codomaster.Extensions
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
        /// Inverts value of specified axis.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <param name="axis">Target axis.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector2Int WithNegate(this Vector2Int vector, int axis) => vector.With(axis, -vector[axis]);

        /// <summary>
        /// Inverts x axis value.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector2Int WithNegateX(this Vector2Int vector) => WithNegate(vector, 0);

        /// <summary>
        /// Inverts y axis value.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector2Int WithNegateY(this Vector2Int vector) => WithNegate(vector, 1);

        /// <summary>
        /// Inverts vector.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Inverted vector.</returns>
        public static Vector2Int Negate(this Vector2Int vector) => new(-vector.x, -vector.y);

        /// <summary>
        /// Gets inverted vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Inverted vector.</returns>
        public static Vector2Int GetYX(this Vector2Int vector) => new(vector.y, vector.x);

        /// <summary>
        /// Inserts value to x axis and extends vector to 3-dimensional.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="x">Value to set.</param>
        /// <returns>3-dimensional vector.</returns>
        public static Vector3Int InsertX(this Vector2Int vector, int x = 0) => new(x, vector.x, vector.y);

        /// <summary>
        /// Inserts value to y axis and extends vector to 3-dimensional.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="y">Value to set.</param>
        /// <returns>3-dimensional vector.</returns>
        public static Vector3Int InsertY(this Vector2Int vector, int y = 0) => new(vector.x, y, vector.y);

        /// <summary>
        /// Inserts value to z axis and extends vector to 3-dimensional.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>3-dimensional vector.</returns>
        public static Vector3Int InsertZ(this Vector2Int vector, int z = 0) => new(vector.x, vector.y, z);

        /// <summary>
        /// Gets max component info from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's max component tuple info.</returns>
        public static (int index, int value) MaxComponent(this Vector2Int vector) => vector.x >= vector.y ? (0, vector.x) : (1, vector.y);

        /// <summary>
        /// Gets min component info from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's min component tuple info.</returns>
        public static (int index, int value) MinComponent(this Vector2Int vector) => vector.x <= vector.y ? (0, vector.x) : (1, vector.y);

        /// <summary>
        /// Creates new vector with absolute components.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector with absolute components.</returns>
        public static Vector2Int Abs(this Vector2Int vector) => new(Mathf.Abs(vector.x), Mathf.Abs(vector.y));

        /// <summary>
        /// Creates new vector with clamped components.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="min">The minimum floating value to campare agains.</param>
        /// <param name="max">The maximum floating value to campare agains.</param>
        /// <returns>Clamped vector.</returns>
        public static Vector2Int Clamp(this Vector2Int vector, int min, int max)
        {
            return new Vector2Int(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max));
        }

        /// <summary>
        /// Create new vector with divided by value components.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="other">Vector on which divide</param>
        /// <returns>Divided vector.</returns>
        public static Vector2Int Divide(this Vector2Int vector, Vector2Int other)
        {
            return new Vector2Int(vector.x / other.x, vector.y / other.y);
        }

        /// <summary>
        /// Checks if the vector components are equals.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see langword="true"/> if vector's components are equals.</returns>
        public static bool IsUniform(this Vector2Int vector) => vector.x == vector.y;

        /// <summary>
        /// Gets closest point info from <paramref name="points"/> list.
        /// </summary>
        /// <param name="point">Origin point.</param>
        /// <param name="points">Compared points.</param>
        /// <returns>Closest point tuple info.</returns>
        public static (Vector2Int point, int index) GetClosestPoint(this Vector2Int point, params Vector2Int[] points)
        {
            return GetClosestPoint(point, (IEnumerable<Vector2Int>)points);
        }

        /// <summary>
        /// Gets closest point info from <paramref name="points"/> list.
        /// </summary>
        /// <param name="point">Origin point.</param>
        /// <param name="points">Compared points.</param>
        /// <returns>Closest point tuple info.</returns>
        public static (Vector2Int point, int index) GetClosestPoint(this Vector2Int point, IEnumerable<Vector2Int> points)
        {
            var enumerator = points.GetEnumerator();

            var index = -1;
            var closestIndex = -1;
            var closestPoint = Vector2Int.zero;
            var closestDistance = float.MaxValue;

            while (enumerator.MoveNext())
            {
                ++index;
                var distance = Vector2Int.Distance(point, enumerator.Current);

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
        public static (Vector2 point, float distance) GetClosestPointOnRay(this Vector2Int point, Vector2 origin, Vector2 direction)
        {
            return Vector2Extensions.GetClosestPointOnRay(point, origin, direction);
        }

        /// <summary>
        /// Get the closest point on a line segment.
        /// </summary>
        /// <param name="point">A point in space.</param>
        /// <param name="start">Start of line segment.</param>
        /// <param name="end">End of line segment.</param>
        /// <returns>Tuple which contains closest point on line and distance from <paramref name="start"/> to calculated point.</returns>
        public static (Vector2 point, float distance) GetClosestPointOnSegment(this Vector2Int point, Vector2 start, Vector2 end)
        {
            return Vector2Extensions.GetClosestPointOnSegment(point, start, end);
        }
    }
}