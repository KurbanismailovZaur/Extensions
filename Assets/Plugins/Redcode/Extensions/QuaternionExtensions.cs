using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions
{
    public static class QuaternionExtensions
    {
        public static Quaternion With(this Quaternion quaternion, int axis, float value)
        {
            quaternion[axis] = value;
            return quaternion;
        }

        public static Quaternion WithX(this Quaternion quaternion, float x) => With(quaternion, 0, x);

        public static Quaternion WithY(this Quaternion quaternion, float y) => With(quaternion, 1, y);

        public static Quaternion WithZ(this Quaternion quaternion, float z) => With(quaternion, 2, z);

        public static Quaternion WithW(this Quaternion quaternion, float w) => With(quaternion, 3, w);

        public static Quaternion With(this Quaternion quaternion, int axis1, float value1, int axis2, float value2)
        {
            quaternion[axis1] = value1;
            quaternion[axis2] = value2;
            return quaternion;
        }

        public static Quaternion WithXY(this Quaternion quaternion, float x, float y) => With(quaternion, 0, x, 1, y);

        public static Quaternion WithXZ(this Quaternion quaternion, float x, float z) => With(quaternion, 0, x, 2, z);

        public static Quaternion WithYZ(this Quaternion quaternion, float y, float z) => With(quaternion, 1, y, 2, z);

        public static Quaternion WithXW(this Quaternion quaternion, float x, float w) => With(quaternion, 0, x, 3, w);

        public static Quaternion WithYW(this Quaternion quaternion, float y, float w) => With(quaternion, 1, y, 3, w);

        public static Quaternion WithZW(this Quaternion quaternion, float z, float w) => With(quaternion, 2, z, 3, w);

        public static Quaternion With(this Quaternion quaternion, int axis1, float value1, int axis2, float value2, int axis3, float value3)
        {
            quaternion[axis1] = value1;
            quaternion[axis2] = value2;
            quaternion[axis3] = value3;
            return quaternion;
        }

        public static Quaternion WithXYZ(this Quaternion quaternion, float x, float y, float z) => With(quaternion, 0, x, 1, y, 2, z);

        public static Quaternion WithXYW(this Quaternion quaternion, float x, float y, float w) => With(quaternion, 0, x, 1, y, 3, w);

        public static Quaternion WithXZW(this Quaternion quaternion, float x, float z, float w) => With(quaternion, 0, x, 2, z, 3, w);

        public static Quaternion WithYZW(this Quaternion quaternion, float y, float z, float w) => With(quaternion, 1, y, 2, z, 3, w);
    }
}