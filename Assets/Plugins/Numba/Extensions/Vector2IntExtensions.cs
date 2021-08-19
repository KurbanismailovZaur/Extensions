using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class Vector2IntExtensions
    {
        public static Vector2Int With(this Vector2Int vector, int axis, int value)
        {
            vector[axis] = value;
            return vector;
        }

        public static Vector2Int WithX(this Vector2Int vector, int x) => With(vector, 0, x);

        public static Vector2Int WithY(this Vector2Int vector, int y) => With(vector, 1, y);

        public static Vector2Int GetYX(this Vector2Int vector) => new Vector2Int(vector.y, vector.x);

        public static Vector3Int InsertX(this Vector2Int vector, int x = 0) => new Vector3Int(x, vector.x, vector.y);

        public static Vector3Int InsertY(this Vector2Int vector, int y = 0) => new Vector3Int(vector.x, y, vector.y);

        public static Vector3Int InsertZ(this Vector2Int vector, int z = 0) => new Vector3Int(vector.x, vector.y, z);

        public static int MaxComponent(this Vector2Int vector) => Mathf.Max(vector.x, vector.y);

        public static int MinComponent(this Vector2Int vector) => Mathf.Min(vector.x, vector.y);
    }
}