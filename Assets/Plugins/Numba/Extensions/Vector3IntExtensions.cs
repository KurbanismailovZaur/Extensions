using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class Vector3IntExtensions
    {
        public static Vector3Int With(this Vector3Int vector, int axis, int value)
        {
            vector[axis] = value;
            return vector;
        }

        public static Vector3Int WithX(this Vector3Int vector, int x) => With(vector, 0, x);

        public static Vector3Int WithY(this Vector3Int vector, int y) => With(vector, 1, y);

        public static Vector3Int WithZ(this Vector3Int vector, int z) => With(vector, 2, z);

        public static Vector3Int With(this Vector3Int vector, int axis1, int value1, int axis2, int value2)
        {
            vector[axis1] = value1;
            vector[axis2] = value2;

            return vector;
        }

        public static Vector3Int WithXY(this Vector3Int vector, int x, int y) => With(vector, 0, x, 1, y);

        public static Vector3Int WithXZ(this Vector3Int vector, int x, int z) => With(vector, 0, x, 2, z);

        public static Vector3Int WithYZ(this Vector3Int vector, int y, int z) => With(vector, 1, y, 2, z);

        public static Vector2Int Get(this Vector3Int vector, int axis1, int axis2) => new Vector2Int(vector[axis1], vector[axis2]);

        public static Vector2Int GetXY(this Vector3Int vector) => Get(vector, 0, 1);

        public static Vector2Int GetXZ(this Vector3Int vector) => Get(vector, 0, 2);

        public static Vector2Int GetYX(this Vector3Int vector) => Get(vector, 1, 0);

        public static Vector2Int GetYZ(this Vector3Int vector) => Get(vector, 1, 2);

        public static Vector2Int GetZX(this Vector3Int vector) => Get(vector, 2, 0);

        public static Vector2Int GetZY(this Vector3Int vector) => Get(vector, 2, 1);

        public static Vector3Int Get(this Vector3Int vector, int axis1, int axis2, int axis3) => new Vector3Int(vector[axis1], vector[axis2], vector[axis3]);

        public static Vector3Int GetXZY(this Vector3Int vector) => Get(vector, 0, 2, 1);

        public static Vector3Int GetYXZ(this Vector3Int vector) => Get(vector, 1, 0, 2);

        public static Vector3Int GetYZX(this Vector3Int vector) => Get(vector, 1, 2, 0);

        public static Vector3Int GetZXY(this Vector3Int vector) => Get(vector, 2, 0, 1);

        public static Vector3Int GetZYX(this Vector3Int vector) => Get(vector, 2, 1, 0);

        public static int MaxComponent(this Vector3Int vector) => Mathf.Max(vector.x, vector.y, vector.z);

        public static int MinComponent(this Vector3Int vector) => Mathf.Min(vector.x, vector.y, vector.z);
    }
}