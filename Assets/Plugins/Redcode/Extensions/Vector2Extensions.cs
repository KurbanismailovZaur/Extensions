using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class Vector2Extensions
    {
        public static Vector2 With(this Vector2 vector, int axis, float value)
        {
            vector[axis] = value;
            return vector;
        }

        public static Vector2 WithX(this Vector2 vector, float x) => With(vector, 0, x);

        public static Vector2 WithY(this Vector2 vector, float y) => With(vector, 1, y);

        public static Vector2 GetYX(this Vector2 vector) => new Vector2(vector.y, vector.x);

        public static Vector3 InsertX(this Vector2 vector, float x = 0) => new Vector3(x, vector.x, vector.y);

        public static Vector3 InsertY(this Vector2 vector, float y = 0) => new Vector3(vector.x, y, vector.y);

        public static Vector3 InsertZ(this Vector2 vector, float z = 0) => new Vector3(vector.x, vector.y, z);

        public static float MaxComponent(this Vector2 vector) => Mathf.Max(vector.x, vector.y);

        public static float MinComponent(this Vector2 vector) => Mathf.Min(vector.x, vector.y);

        public static Vector2 Remap(this Vector2 vector, float min1, float max1, float min2, float max2)
        {
            return new Vector2(vector.x.Remap(min1, max1, min2, max2), vector.y.Remap(min1, max1, min2, max2));
        }
    }
}