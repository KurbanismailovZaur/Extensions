using System.Collections.Generic;
using UnityEngine;

namespace Codomaster.Extensions
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
        /// Inverts value of specified axis.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <param name="axis">Target axis.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector2 WithNegate(this Vector2 vector, int axis) => vector.With(axis, -vector[axis]);

        /// <summary>
        /// Inverts x axis value.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector2 WithNegateX(this Vector2 vector) => WithNegate(vector, 0);

        /// <summary>
        /// Inverts y axis value.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector2 WithNegateY(this Vector2 vector) => WithNegate(vector, 1);

        /// <summary>
        /// Inverts vector.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Inverted vector.</returns>
        public static Vector2 Negate(this Vector2 vector) => new(-vector.x, -vector.y);

        /// <summary>
        /// Gets inverted vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Inverted vector.</returns>
        public static Vector2 GetYX(this Vector2 vector) => new(vector.y, vector.x);

        /// <summary>
        /// Inserts value to x axis and extends vector to 3-dimensional.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="x">Value to set.</param>
        /// <returns>3-dimensional vector.</returns>
        public static Vector3 InsertX(this Vector2 vector, float x = 0) => new(x, vector.x, vector.y);

        /// <summary>
        /// Inserts value to y axis and extends vector to 3-dimensional.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="y">Value to set.</param>
        /// <returns>3-dimensional vector.</returns>
        public static Vector3 InsertY(this Vector2 vector, float y = 0) => new(vector.x, y, vector.y);

        /// <summary>
        /// Inserts value to z axis and extends vector to 3-dimensional.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>3-dimensional vector.</returns>
        public static Vector3 InsertZ(this Vector2 vector, float z = 0) => new(vector.x, vector.y, z);

        /// <summary>
        /// Gets max component index from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's max component index.</returns>
        public static int MaxComponentIndex(this Vector2 vector) => vector.x >= vector.y ? 0 : 1;

        /// <summary>
        /// Gets max component from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's max component</returns>
        public static float MaxComponent(this Vector2 vector) => vector[MaxComponentIndex(vector)];

        /// <summary>
        /// Gets min component index from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's min component index.</returns>
        public static int MinComponentIndex(this Vector2 vector) => vector.x <= vector.y ? 0 : 1;

        /// <summary>
        /// Gets min component from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's min component</returns>
        public static float MinComponent(this Vector2 vector) => vector[MinComponentIndex(vector)];

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

        /// <summary>
        /// Creates new vector with absolute components.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector with absolute components.</returns>
        public static Vector2 Abs(this Vector2 vector) => new(Mathf.Abs(vector.x), Mathf.Abs(vector.y));

        /// <summary>
        /// Creates new vector with clamped components.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="min">The minimum floating value to campare agains.</param>
        /// <param name="max">The maximum floating value to campare agains.</param>
        /// <returns>Clamped vector.</returns>
        public static Vector2 Clamp(this Vector2 vector, float min, float max)
        {
            return new Vector2(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max));
        }

        /// <summary>
        /// Creates and returns a vector whose components are limited to 0 and 1.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Clamped vector.</returns>
        public static Vector2 Clamp01(this Vector2 vector)
        {
            return new Vector2(Mathf.Clamp01(vector.x), Mathf.Clamp01(vector.y));
        }

        /// <summary>
        /// Creates and returns a vector whose components are divided by the value.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="other">Vector on which divide</param>
        /// <returns>Divided vector.</returns>
        public static Vector2 Divide(this Vector2 vector, Vector2 other) => vector / other;

        /// <summary>
        /// Checks if the vector components are equals.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see langword="true"/> if vector's components are equals.</returns>
        public static bool IsUniform(this Vector2 vector) => vector.x.Approx(vector.y);

        /// <summary>
        /// Calculate evently distributed point position on circle.
        /// </summary>
        /// <param name="index">Index of point.</param>
        /// <param name="radius">Radius of the circle.</param>
        /// <param name="count">Total count of points in circle.</param>
        /// <returns>Calculated evently distributed point.</returns>
        public static Vector2 EventlyDistributedPointOnCircle(int index, float radius, int count)
        {
            var k = index + 0.5f;
            var r = Mathf.Sqrt((k) / count);
            var theta = Mathf.PI * (1f + Mathf.Sqrt(5f)) * k;

            var x = r * Mathf.Cos(theta) * radius;
            var y = r * Mathf.Sin(theta) * radius;

            return new Vector2(x, y);
        }

        /// <summary>
        /// Gets closest point info from <paramref name="points"/> list.
        /// </summary>
        /// <param name="point">Origin point.</param>
        /// <param name="points">Compared points.</param>
        /// <returns>Closest point tuple info.</returns>
        public static (Vector2 point, int index) GetClosestPoint(this Vector2 point, params Vector2[] points)
        {
            return GetClosestPoint(point, (IEnumerable<Vector2>)points);
        }

        /// <summary>
        /// Gets closest point info from <paramref name="points"/> list.
        /// </summary>
        /// <param name="point">Origin point.</param>
        /// <param name="points">Compared points.</param>
        /// <returns>Closest point tuple info.</returns>
        public static (Vector2 point, int index) GetClosestPoint(this Vector2 point, IEnumerable<Vector2> points)
        {
            var enumerator = points.GetEnumerator();

            var index = -1;
            var closestIndex = -1;
            var closestPoint = Vector2.zero;
            var closestDistance = float.MaxValue;

            while (enumerator.MoveNext())
            {
                ++index;
                var distance = Vector2.Distance(point, enumerator.Current);

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
        public static (Vector2 point, float distance) GetClosestPointOnRay(this Vector2 point, Vector2 origin, Vector2 direction)
        {
            var distance = Vector2.Dot(point - origin, direction);
            return (origin + direction * distance, distance);
        }

        /// <summary>
        /// Get the closest point on a line segment.
        /// </summary>
        /// <param name="point">A point in space.</param>
        /// <param name="start">Start of line segment.</param>
        /// <param name="end">End of line segment.</param>
        /// <returns>Tuple which contains closest point on line and distance from <paramref name="start"/> to calculated point.</returns>
        public static (Vector2 point, float distance) GetClosestPointOnSegment(this Vector2 point, Vector2 start, Vector2 end)
        {
            var direction = end - start;
            var lineMagnitude = direction.magnitude;
            direction.Normalize();
            
            var distance = Mathf.Clamp(Vector2.Dot(point - start, direction), 0f, lineMagnitude);
            return (start + direction * distance, distance);
        }

        /// <summary>
        /// Arbitrarily deviates the direction vector by a given <paramref name="angle"/>.
        /// </summary>
        /// <param name="direction">Target vector.</param>
        /// <param name="angle">Angle on which vector will be deflected.</param>
        /// <returns>Deflected directional vector.</returns>
        public static Vector2 RandomDeflected(this Vector2 direction, float angle) => Quaternion.AngleAxis(Random.value * angle.WithRandomSign(), Vector3.forward) * direction;
    }
}