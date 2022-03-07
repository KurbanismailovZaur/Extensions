using UnityEngine;

namespace Redcode.Extensions
{
    public static class Vector4Extensions
    {
        /// <summary>
        /// Sets value to vector's axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="axis">Axis index of the vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector2 With(this Vector4 vector, int axis, float value)
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
        public static Vector4 WithX(this Vector4 vector, float x) => With(vector, 0, x);

        /// <summary>
        /// Sets value to vector's y axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="y">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithY(this Vector4 vector, float y) => With(vector, 1, y);

        /// <summary>
        /// Sets value to vector's z axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithZ(this Vector4 vector, float z) => With(vector, 2, z);

        /// <summary>
        /// Sets value to vector's w axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithW(this Vector4 vector, float w) => With(vector, 3, w);

        /// <summary>
        /// Sets values to vector's axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="axis1">First axis index of the vector.</param>
        /// <param name="value1">First value to set.</param>
        /// <param name="axis2">Second axis index of the vector.</param>
        /// <param name="value2">Second value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector2 With(this Vector4 vector, int axis1, float value1, int axis2, float value2)
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
        public static Vector4 WithXY(this Vector4 vector, float x, float y) => With(vector, 0, x, 1, y);

        /// <summary>
        /// Sets value to vector's x and y axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithXY(this Vector4 vector, Vector2 value) => With(vector, 0, value.x, 1, value.y);

        /// <summary>
        /// Sets value to vector's x and z axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithXZ(this Vector4 vector, float x, float z) => With(vector, 0, x, 2, z);

        /// <summary>
        /// Sets value to vector's x and z axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithXZ(this Vector4 vector, Vector2 value) => With(vector, 0, value.x, 2, value.y);

        /// <summary>
        /// Sets value to vector's x and w axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithXW(this Vector4 vector, float x, float w) => With(vector, 0, x, 3, w);

        /// <summary>
        /// Sets value to vector's x and w axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithXW(this Vector4 vector, Vector2 value) => With(vector, 0, value.x, 3, value.y);

        /// <summary>
        /// Sets value to vector's y and z axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithYZ(this Vector4 vector, float y, float z) => With(vector, 1, y, 2, z);

        /// <summary>
        /// Sets value to vector's y and z axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithYZ(this Vector4 vector, Vector2 value) => With(vector, 1, value.x, 2, value.y);

        /// <summary>
        /// Sets value to vector's y and w axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithYW(this Vector4 vector, float y, float w) => With(vector, 1, y, 3, w);

        /// <summary>
        /// Sets value to vector's y and w axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithYW(this Vector4 vector, Vector2 value) => With(vector, 1, value.x, 3, value.y);

        /// <summary>
        /// Sets value to vector's z and w axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="z">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithZW(this Vector4 vector, float z, float w) => With(vector, 2, z, 3, w);

        /// <summary>
        /// Sets value to vector's z and w axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithZW(this Vector4 vector, Vector2 value) => With(vector, 2, value.x, 3, value.y);

        /// <summary>
        /// Sets values to vector's axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="axis1">First axis index of the vector.</param>
        /// <param name="value1">First value to set.</param>
        /// <param name="axis2">Second axis index of the vector.</param>
        /// <param name="value2">Second value to set.</param>
        /// <param name="axis3">Second axis index of the vector.</param>
        /// <param name="value3">Second value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector2 With(this Vector4 vector, int axis1, float value1, int axis2, float value2, int axis3, float value3)
        {
            vector[axis1] = value1;
            vector[axis2] = value2;
            vector[axis3] = value3;

            return vector;
        }

        /// <summary>
        /// Sets value to vector's x, y and z axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithXYZ(this Vector4 vector, float x, float y, float z) => With(vector, 0, x, 1, y, 2, z);

        /// <summary>
        /// Sets value to vector's x, y and z axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithXYZ(this Vector4 vector, Vector3 value) => With(vector, 0, value.x, 1, value.y, 2, value.z);

        /// <summary>
        /// Sets value to vector's x, y and w axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithXYW(this Vector4 vector, float x, float y, float w) => With(vector, 0, x, 1, y, 3, w);

        /// <summary>
        /// Sets value to vector's x, y and w axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithXYW(this Vector4 vector, Vector3 value) => With(vector, 0, value.x, 1, value.y, 3, value.z);

        /// <summary>
        /// Sets value to vector's x, z and w axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithXZW(this Vector4 vector, float x, float z, float w) => With(vector, 0, x, 2, z, 3, w);

        /// <summary>
        /// Sets value to vector's x, z and w axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithXZW(this Vector4 vector, Vector3 value) => With(vector, 0, value.x, 2, value.y, 3, value.z);

        /// <summary>
        /// Sets value to vector's y, z and w axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithYZW(this Vector4 vector, float y, float z, float w) => With(vector, 1, y, 2, z, 3, w);

        /// <summary>
        /// Sets value to vector's y, z and w axis.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the vector.</returns>
        public static Vector4 WithYZW(this Vector4 vector, Vector3 value) => With(vector, 1, value.x, 2, value.y, 3, value.z);

        /// <summary>
        /// Gets <see cref="Vector2"/> by axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="axis1">First axis.</param>
        /// <param name="axis2">Second axis.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2 Get(this Vector4 vector, int axis1, int axis2) => new Vector2(vector[axis1], vector[axis2]);

        /// <summary>
        /// Gets <see cref="Vector2"/> by x and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2 GetXY(this Vector4 vector) => Get(vector, 0, 1);

        /// <summary>
        /// Gets <see cref="Vector2"/> by x and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2 GetXZ(this Vector4 vector) => Get(vector, 0, 2);

        /// <summary>
        /// Gets <see cref="Vector2"/> by x and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2 GetXW(this Vector4 vector) => Get(vector, 0, 3);

        /// <summary>
        /// Gets <see cref="Vector2"/> by y and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2 GetYX(this Vector4 vector) => Get(vector, 1, 0);

        /// <summary>
        /// Gets <see cref="Vector2"/> by y and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2 GetYZ(this Vector4 vector) => Get(vector, 1, 2);

        /// <summary>
        /// Gets <see cref="Vector2"/> by y and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2 GetYW(this Vector4 vector) => Get(vector, 1, 3);

        /// <summary>
        /// Gets <see cref="Vector2"/> by z and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2 GetZX(this Vector4 vector) => Get(vector, 2, 0);

        /// <summary>
        /// Gets <see cref="Vector2"/> by z and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2 GetZY(this Vector4 vector) => Get(vector, 2, 1);

        /// <summary>
        /// Gets <see cref="Vector2"/> by z and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2 GetZW(this Vector4 vector) => Get(vector, 2, 3);

        /// <summary>
        /// Gets <see cref="Vector2"/> by w and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2 GetWX(this Vector4 vector) => Get(vector, 3, 0);

        /// <summary>
        /// Gets <see cref="Vector2"/> by w and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2 GetWY(this Vector4 vector) => Get(vector, 3, 1);

        /// <summary>
        /// Gets <see cref="Vector2"/> by w and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector2"/> vector.</returns>
        public static Vector2 GetWZ(this Vector4 vector) => Get(vector, 3, 2);

        /// <summary>
        /// Gets vector with swapped axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="axis1">First axis.</param>
        /// <param name="axis2">Second axis.</param>
        /// <param name="axis3">Third axis.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 Get(this Vector4 vector, int axis1, int axis2, int axis3) => new Vector3(vector[axis1], vector[axis2], vector[axis3]);

        /// <summary>
        /// Gets vector by x, y and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetXYZ(this Vector4 vector) => Get(vector, 0, 1, 2);

        /// <summary>
        /// Gets vector by x, y and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetXYW(this Vector4 vector) => Get(vector, 0, 1, 3);

        /// <summary>
        /// Gets vector by x, z and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetXZY(this Vector4 vector) => Get(vector, 0, 2, 1);

        /// <summary>
        /// Gets vector by x, z and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetXZW(this Vector4 vector) => Get(vector, 0, 2, 3);

        /// <summary>
        /// Gets vector by x, w and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetXWY(this Vector4 vector) => Get(vector, 0, 3, 1);

        /// <summary>
        /// Gets vector by x, w and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetXWZ(this Vector4 vector) => Get(vector, 0, 3, 2);

        /// <summary>
        /// Gets vector by y, x and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetYXZ(this Vector4 vector) => Get(vector, 1, 0, 2);

        /// <summary>
        /// Gets vector by y, x and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetYXW(this Vector4 vector) => Get(vector, 1, 0, 3);

        /// <summary>
        /// Gets vector by y, z and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetYZX(this Vector4 vector) => Get(vector, 1, 2, 0);

        /// <summary>
        /// Gets vector by y, z and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetYZW(this Vector4 vector) => Get(vector, 1, 2, 3);

        /// <summary>
        /// Gets vector by y, w and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetYWX(this Vector4 vector) => Get(vector, 1, 3, 0);

        /// <summary>
        /// Gets vector by y, w and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetYWZ(this Vector4 vector) => Get(vector, 1, 3, 2);

        /// <summary>
        /// Gets vector by z, x and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetZXY(this Vector4 vector) => Get(vector, 2, 0, 1);

        /// <summary>
        /// Gets vector by z, x and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetZXW(this Vector4 vector) => Get(vector, 2, 0, 3);

        /// <summary>
        /// Gets vector by z, y and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetZYX(this Vector4 vector) => Get(vector, 2, 1, 0);

        /// <summary>
        /// Gets vector by z, y and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetZYW(this Vector4 vector) => Get(vector, 2, 1, 3);

        /// <summary>
        /// Gets vector by z, w and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetZWX(this Vector4 vector) => Get(vector, 2, 3, 0);

        /// <summary>
        /// Gets vector by z, w and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetZWY(this Vector4 vector) => Get(vector, 2, 3, 1);

        /// <summary>
        /// Gets vector by w, x and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetWXY(this Vector4 vector) => Get(vector, 3, 0, 1);

        /// <summary>
        /// Gets vector by w, x and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetWXZ(this Vector4 vector) => Get(vector, 3, 0, 2);

        /// <summary>
        /// Gets vector by w, y and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetWYX(this Vector4 vector) => Get(vector, 3, 1, 0);

        /// <summary>
        /// Gets vector by w, y and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetWYZ(this Vector4 vector) => Get(vector, 3, 1, 2);

        /// <summary>
        /// Gets vector by w, z and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetWZX(this Vector4 vector) => Get(vector, 3, 2, 0);

        /// <summary>
        /// Gets vector by w, z and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector3"/> vector.</returns>
        public static Vector3 GetWZY(this Vector4 vector) => Get(vector, 3, 2, 1);

        /// <summary>
        /// Gets vector with swapped axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="axis1">First axis.</param>
        /// <param name="axis2">Second axis.</param>
        /// <param name="axis3">Third axis.</param>
        /// <param name="axis4">Fourth axis.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 Get(this Vector4 vector, int axis1, int axis2, int axis3, int axis4) => new Vector4(vector[axis1], vector[axis2], vector[axis3], vector[axis4]);

        /// <summary>
        /// Gets vector by x, y, w and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetXYWZ(this Vector4 vector) => Get(vector, 0, 1, 3, 2);

        /// <summary>
        /// Gets vector by x, z, y and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetXZYW(this Vector4 vector) => Get(vector, 0, 2, 1, 3);

        /// <summary>
        /// Gets vector by x, z, w and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetXZWY(this Vector4 vector) => Get(vector, 0, 2, 3, 1);

        /// <summary>
        /// Gets vector by x, w, y and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetXWYZ(this Vector4 vector) => Get(vector, 0, 3, 1, 2);

        /// <summary>
        /// Gets vector by x, w, z and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetXWZY(this Vector4 vector) => Get(vector, 0, 3, 2, 1);

        /// <summary>
        /// Gets vector by y, x, z and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetYXZW(this Vector4 vector) => Get(vector, 1, 0, 2, 3);

        /// <summary>
        /// Gets vector by y, x, w and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetYXWZ(this Vector4 vector) => Get(vector, 1, 0, 3, 2);

        /// <summary>
        /// Gets vector by y, z, x and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetYZXW(this Vector4 vector) => Get(vector, 1, 2, 0, 3);

        /// <summary>
        /// Gets vector by y, z, w and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetYZWX(this Vector4 vector) => Get(vector, 1, 2, 3, 0);

        /// <summary>
        /// Gets vector by y, w, x and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetYWXZ(this Vector4 vector) => Get(vector, 1, 3, 0, 2);

        /// <summary>
        /// Gets vector by y, w, z and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetYWZX(this Vector4 vector) => Get(vector, 1, 3, 2, 0);

        /// <summary>
        /// Gets vector by z, x, y and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetZXYW(this Vector4 vector) => Get(vector, 2, 0, 1, 3);

        /// <summary>
        /// Gets vector by z, x, w and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetZXWY(this Vector4 vector) => Get(vector, 2, 0, 3, 1);

        /// <summary>
        /// Gets vector by z, y, x and w axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetZYXW(this Vector4 vector) => Get(vector, 2, 1, 0, 3);

        /// <summary>
        /// Gets vector by z, y, w and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetZYWX(this Vector4 vector) => Get(vector, 2, 1, 3, 0);

        /// <summary>
        /// Gets vector by z, w, x and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetZWXY(this Vector4 vector) => Get(vector, 2, 3, 0, 1);

        /// <summary>
        /// Gets vector by z, w, y and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetZWYX(this Vector4 vector) => Get(vector, 2, 3, 1, 0);

        /// <summary>
        /// Gets vector by w, x, y and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetWXYZ(this Vector4 vector) => Get(vector, 3, 0, 1, 2);

        /// <summary>
        /// Gets vector by w, x, z and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetWXZY(this Vector4 vector) => Get(vector, 3, 0, 2, 1);

        /// <summary>
        /// Gets vector by w, y, x and z axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetWYXZ(this Vector4 vector) => Get(vector, 3, 1, 0, 2);

        /// <summary>
        /// Gets vector by w, y, z and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetWYZX(this Vector4 vector) => Get(vector, 3, 1, 2, 0);

        /// <summary>
        /// Gets vector by w, z, x and y axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetWZXY(this Vector4 vector) => Get(vector, 3, 2, 0, 1);

        /// <summary>
        /// Gets vector by w, z, y and x axes.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see cref="Vector4"/> vector.</returns>
        public static Vector4 GetWZYX(this Vector4 vector) => Get(vector, 3, 2, 1, 0);

        /// <summary>
        /// Gets max component from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's max component</returns>
        public static float MaxComponent(this Vector4 vector) => Mathf.Max(vector.x, vector.y, vector.z, vector.w);

        /// <summary>
        /// Gets min component from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's min component</returns>
        public static float MinComponent(this Vector4 vector) => Mathf.Min(vector.x, vector.y, vector.z, vector.w);

        /// <summary>
        /// Remaps all vector's components from one interval to other.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="min1">Min value of the beginning interval.</param>
        /// <param name="max1">Max value of the beginning interval.</param>
        /// <param name="min2">Min value of the target interval.</param>
        /// <param name="max2">Max value of the target interval.</param>
        /// <returns>Remaped vector.</returns>
        public static Vector4 Remap(this Vector4 vector, float min1, float max1, float min2, float max2)
        {
            return new Vector4(vector.x.Remap(min1, max1, min2, max2), vector.y.Remap(min1, max1, min2, max2), vector.z.Remap(min1, max1, min2, max2), vector.w.Remap(min1, max1, min2, max2));
        }
    }
}