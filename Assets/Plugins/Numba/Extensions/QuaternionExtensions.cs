using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions
{
    public static class QuaternionExtensions
    {
        public static Quaternion WithX(this Quaternion quaternion, float x)
        {
            quaternion.x = x;
            return quaternion;
        }

        public static Quaternion WithY(this Quaternion quaternion, float y)
        {
            quaternion.y = y;
            return quaternion;
        }

        public static Quaternion WithZ(this Quaternion quaternion, float z)
        {
            quaternion.z = z;
            return quaternion;
        }

        public static Quaternion WithXY(this Quaternion quaternion, float x, float y)
        {
            quaternion.x = x;
            quaternion.y = y;

            return quaternion;
        }

        public static Quaternion WithXZ(this Quaternion quaternion, float x, float z)
        {
            quaternion.x = x;
            quaternion.z = z;
            return quaternion;
        }

        public static Quaternion WithYZ(this Quaternion quaternion, float y, float z)
        {
            quaternion.y = y;
            quaternion.z = z;

            return quaternion;
        }

        public static Quaternion WithXYZ(this Quaternion quaternion, float x, float y, float z)
        {
            quaternion.x = x;
            quaternion.y = y;
            quaternion.z = z;

            return quaternion;
        }

        public static Quaternion WithW(this Quaternion quaternion, float w)
        {
            quaternion.w = w;

            return quaternion;
        }

        public static Quaternion WithXW(this Quaternion quaternion, float x, float w)
        {
            quaternion.x = x;
            quaternion.w = w;

            return quaternion;
        }

        public static Quaternion WithYW(this Quaternion quaternion, float y, float w)
        {
            quaternion.y = y;
            quaternion.w = w;

            return quaternion;
        }

        public static Quaternion WithZW(this Quaternion quaternion, float z, float w)
        {
            quaternion.z = z;
            quaternion.w = w;

            return quaternion;
        }

        public static Quaternion WithXYW(this Quaternion quaternion, float x, float y, float w)
        {
            quaternion.y = x;
            quaternion.y = y;
            quaternion.w = w;

            return quaternion;
        }

        public static Quaternion WithXZW(this Quaternion quaternion, float x, float z, float w)
        {
            quaternion.x = x;
            quaternion.z = z;
            quaternion.w = w;

            return quaternion;
        }

        public static Quaternion WithYZW(this Quaternion quaternion, float y, float z, float w)
        {
            quaternion.y = y;
            quaternion.z = z;
            quaternion.w = w;

            return quaternion;
        }
    }
}