using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class Vector4Extensions
    {
        public static Vector2 With(this Vector4 vector, int axis, float value)
        {
            vector[axis] = value;
            return vector;
        }

        public static Vector4 WithX(this Vector4 vector, float x) => With(vector, 0, x);

        public static Vector4 WithY(this Vector4 vector, float y) => With(vector, 1, y);

        public static Vector4 WithZ(this Vector4 vector, float z) => With(vector, 2, z);

        public static Vector4 WithW(this Vector4 vector, float w) => With(vector, 3, w);

        public static Vector2 With(this Vector4 vector, int axis1, float value1, int axis2, float value2)
        {
            vector[axis1] = value1;
            vector[axis2] = value2;

            return vector;
        }

        public static Vector4 WithXY(this Vector4 vector, float x, float y) => With(vector, 0, x, 1, y);

        public static Vector4 WithXZ(this Vector4 vector, float x, float z) => With(vector, 0, x, 2, z);

        public static Vector4 WithXW(this Vector4 vector, float x, float w) => With(vector, 0, x, 3, w);

        public static Vector4 WithYZ(this Vector4 vector, float y, float z) => With(vector, 1, y, 2, z);

        public static Vector4 WithYW(this Vector4 vector, float y, float w) => With(vector, 1, y, 3, w);

        public static Vector4 WithZW(this Vector4 vector, float z, float w) => With(vector, 2, z, 3, w);

        public static Vector2 With(this Vector4 vector, int axis1, float value1, int axis2, float value2, int axis3, float value3)
        {
            vector[axis1] = value1;
            vector[axis2] = value2;
            vector[axis3] = value3;

            return vector;
        }

        public static Vector4 WithXYZ(this Vector4 vector, float x, float y, float z) => With(vector, 0, x, 1, y, 2, z);

        public static Vector4 WithXYW(this Vector4 vector, float x, float y, float w) => With(vector, 0, x, 1, y, 3, w);

        public static Vector4 WithXZW(this Vector4 vector, float x, float z, float w) => With(vector, 0, x, 2, z, 3, w);

        public static Vector4 WithYZW(this Vector4 vector, float y, float z, float w) => With(vector, 1, y, 2, z, 3, w);

        public static Vector3 Get(this Vector4 vector, int axis1, int axis2) => new Vector2(vector[axis1], vector[axis2]);

        public static Vector2 GetXY(this Vector4 vector) => Get(vector, 0, 1);

        public static Vector2 GetXZ(this Vector4 vector) => Get(vector, 0, 2);

        public static Vector2 GetXW(this Vector4 vector) => Get(vector, 0, 3);

        public static Vector2 GetYX(this Vector4 vector) => Get(vector, 1, 0);

        public static Vector2 GetYZ(this Vector4 vector) => Get(vector, 1, 2);

        public static Vector2 GetYW(this Vector4 vector) => Get(vector, 1, 3);

        public static Vector2 GetZX(this Vector4 vector) => Get(vector, 2, 0);

        public static Vector2 GetZY(this Vector4 vector) => Get(vector, 2, 1);

        public static Vector2 GetZW(this Vector4 vector) => Get(vector, 2, 3);

        public static Vector2 GetWX(this Vector4 vector) => Get(vector, 3, 0);

        public static Vector2 GetWY(this Vector4 vector) => Get(vector, 3, 1);

        public static Vector2 GetWZ(this Vector4 vector) => Get(vector, 3, 2);

        public static Vector3 Get(this Vector4 vector, int axis1, int axis2, int axis3) => new Vector3(vector[axis1], vector[axis2], vector[axis3]);

        public static Vector3 GetXYZ(this Vector4 vector) => Get(vector, 0, 1, 2);

        public static Vector3 GetXYW(this Vector4 vector) => Get(vector, 0, 1, 3);

        public static Vector3 GetXZY(this Vector4 vector) => Get(vector, 0, 2, 1);

        public static Vector3 GetXZW(this Vector4 vector) => Get(vector, 0, 2, 3);

        public static Vector3 GetXWY(this Vector4 vector) => Get(vector, 0, 3, 1);

        public static Vector3 GetXWZ(this Vector4 vector) => Get(vector, 0, 3, 2);

        public static Vector3 GetYXZ(this Vector4 vector) => Get(vector, 1, 0, 2);

        public static Vector3 GetYXW(this Vector4 vector) => Get(vector, 1, 0, 3);

        public static Vector3 GetYZX(this Vector4 vector) => Get(vector, 1, 2, 0);

        public static Vector3 GetYZW(this Vector4 vector) => Get(vector, 1, 2, 3);

        public static Vector3 GetYWX(this Vector4 vector) => Get(vector, 1, 3, 0);

        public static Vector3 GetYWZ(this Vector4 vector) => Get(vector, 1, 3, 2);

        public static Vector3 GetZXY(this Vector4 vector) => Get(vector, 2, 0, 1);

        public static Vector3 GetZXW(this Vector4 vector) => Get(vector, 2, 0, 3);

        public static Vector3 GetZYX(this Vector4 vector) => Get(vector, 2, 1, 0);

        public static Vector3 GetZYW(this Vector4 vector) => Get(vector, 2, 1, 3);

        public static Vector3 GetZWX(this Vector4 vector) => Get(vector, 2, 3, 0);

        public static Vector3 GetZWY(this Vector4 vector) => Get(vector, 2, 3, 1);

        public static Vector3 GetWXY(this Vector4 vector) => Get(vector, 3, 0, 1);

        public static Vector3 GetWXZ(this Vector4 vector) => Get(vector, 3, 0, 2);

        public static Vector3 GetWYX(this Vector4 vector) => Get(vector, 3, 1, 0);

        public static Vector3 GetWYZ(this Vector4 vector) => Get(vector, 3, 1, 2);

        public static Vector3 GetWZX(this Vector4 vector) => Get(vector, 3, 2, 0);

        public static Vector3 GetWZY(this Vector4 vector) => Get(vector, 3, 2, 1);

        public static Vector3 Get(this Vector4 vector, int axis1, int axis2, int axis3, int axis4) => new Vector4(vector[axis1], vector[axis2], vector[axis3], vector[axis4]);

        public static Vector4 GetXYWZ(this Vector4 vector) => Get(vector, 0, 1, 3, 2);

        public static Vector4 GetXZYW(this Vector4 vector) => Get(vector, 0, 2, 1, 3);

        public static Vector4 GetXZWY(this Vector4 vector) => Get(vector, 0, 2, 3, 1);

        public static Vector4 GetXWYZ(this Vector4 vector) => Get(vector, 0, 3, 1, 2);

        public static Vector4 GetXWZY(this Vector4 vector) => Get(vector, 0, 3, 2, 1);

        public static Vector4 GetYXZW(this Vector4 vector) => Get(vector, 1, 0, 2, 3);

        public static Vector4 GetYXWZ(this Vector4 vector) => Get(vector, 1, 0, 3, 2);

        public static Vector4 GetYZXW(this Vector4 vector) => Get(vector, 1, 2, 0, 3);

        public static Vector4 GetYZWX(this Vector4 vector) => Get(vector, 1, 2, 3, 0);

        public static Vector4 GetYWXZ(this Vector4 vector) => Get(vector, 1, 3, 0, 2);

        public static Vector4 GetYWZX(this Vector4 vector) => Get(vector, 1, 3, 2, 0);

        public static Vector4 GetZXYW(this Vector4 vector) => Get(vector, 2, 0, 1, 3);

        public static Vector4 GetZXWY(this Vector4 vector) => Get(vector, 2, 0, 3, 1);

        public static Vector4 GetZYXW(this Vector4 vector) => Get(vector, 2, 1, 0, 3);

        public static Vector4 GetZYWX(this Vector4 vector) => Get(vector, 2, 1, 3, 0);

        public static Vector4 GetZWXY(this Vector4 vector) => Get(vector, 2, 3, 0, 1);

        public static Vector4 GetZWYX(this Vector4 vector) => Get(vector, 2, 3, 1, 0);

        public static Vector4 GetWXYZ(this Vector4 vector) => Get(vector, 3, 0, 1, 2);

        public static Vector4 GetWXZY(this Vector4 vector) => Get(vector, 3, 0, 2, 1);

        public static Vector4 GetWYXZ(this Vector4 vector) => Get(vector, 3, 1, 0, 2);

        public static Vector4 GetWYZX(this Vector4 vector) => Get(vector, 3, 1, 2, 0);

        public static Vector4 GetWZXY(this Vector4 vector) => Get(vector, 3, 2, 0, 1);

        public static Vector4 GetWZYX(this Vector4 vector) => Get(vector, 3, 2, 1, 0);

        public static float MaxComponent(this Vector4 vector) => Mathf.Max(vector.x, vector.y, vector.z, vector.w);

        public static float MinComponent(this Vector4 vector) => Mathf.Min(vector.x, vector.y, vector.z, vector.w);
    }
}