using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class Vector3Extensions
    {
        public static Vector3 With(this Vector3 vector, int axis, float value)
        {
            vector[axis] = value;
            return vector;
        }

        public static Vector3 WithX(this Vector3 vector, float x) => With(vector, 0, x);

        public static Vector3 WithY(this Vector3 vector, float y) => With(vector, 1, y);

        public static Vector3 WithZ(this Vector3 vector, float z) => With(vector, 2, z);

        public static Vector3 With(this Vector3 vector, int axis1, float value1, int axis2, float value2)
        {
            vector[axis1] = value1;
            vector[axis2] = value2;

            return vector;
        }

        public static Vector3 WithXY(this Vector3 vector, float x, float y) => With(vector, 0, x, 1, y);

        public static Vector3 WithXZ(this Vector3 vector, float x, float z) => With(vector, 0, x, 2, z);

        public static Vector3 WithYZ(this Vector3 vector, float y, float z) => With(vector, 1, y, 2, z);

        public static Vector2 Get(this Vector3 vector, int axis1, int axis2) => new Vector2(vector[axis1], vector[axis2]);

        public static Vector2 GetXY(this Vector3 vector) => Get(vector, 0, 1);

        public static Vector2 GetXZ(this Vector3 vector) => Get(vector, 0, 2);

        public static Vector2 GetYX(this Vector3 vector) => Get(vector, 1, 0);

        public static Vector2 GetYZ(this Vector3 vector) => Get(vector, 1, 2);

        public static Vector2 GetZX(this Vector3 vector) => Get(vector, 2, 0);

        public static Vector2 GetZY(this Vector3 vector) => Get(vector, 2, 1);

        public static Vector3 Get(this Vector3 vector, int axis1, int axis2, int axis3) => new Vector3(vector[axis1], vector[axis2], vector[axis3]);

        public static Vector3 GetXZY(this Vector3 vector) => Get(vector, 0, 2, 1);

        public static Vector3 GetYXZ(this Vector3 vector) => Get(vector, 1, 0, 2);

        public static Vector3 GetYZX(this Vector3 vector) => Get(vector, 1, 2, 0);

        public static Vector3 GetZXY(this Vector3 vector) => Get(vector, 2, 0, 1);

        public static Vector3 GetZYX(this Vector3 vector) => Get(vector, 2, 1, 0);

        public static Vector4 InsertX(this Vector3 vector, float x = 0) => new Vector4(x, vector.x, vector.y, vector.z);

        public static Vector4 InsertY(this Vector3 vector, float y = 0) => new Vector4(vector.x, y, vector.y, vector.z);

        public static Vector4 InsertZ(this Vector3 vector, float z = 0) => new Vector4(vector.x, vector.y, z, vector.z);

        public static Vector4 InsertW(this Vector3 vector, float w = 0) => new Vector4(vector.x, vector.y, vector.z, w);

        public static float MaxComponent(this Vector3 vector) => Mathf.Max(vector.x, vector.y, vector.z);

        public static float MinComponent(this Vector3 vector) => Mathf.Min(vector.x, vector.y, vector.z);

        public static Vector3 Remap(this Vector3 vector, float min1, float max1, float min2, float max2)
        {
            return new Vector3(vector.x.Remap(min1, max1, min2, max2), vector.y.Remap(min1, max1, min2, max2), vector.z.Remap(min1, max1, min2, max2));
        }
    }
}