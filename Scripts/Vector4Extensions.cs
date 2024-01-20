using System.Collections.Generic;
using UnityEngine;

namespace Codomaster.Extensions
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
        /// Inverts value of specified axis.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <param name="axis">Target axis.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector4 WithNegate(this Vector4 vector, int axis) => vector.With(axis, -vector[axis]);

        /// <summary>
        /// Inverts x axis value.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector4 WithNegateX(this Vector4 vector) => WithNegate(vector, 0);

        /// <summary>
        /// Inverts y axis value.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector4 WithNegateY(this Vector4 vector) => WithNegate(vector, 1);

        /// <summary>
        /// Inverts z axis value.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector4 WithNegateZ(this Vector4 vector) => WithNegate(vector, 2);

        /// <summary>
        /// Inverts w axis value.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axis value.</returns>
        public static Vector4 WithNegateW(this Vector4 vector) => WithNegate(vector, 3);

        /// <summary>
        /// Inverts values of specified axes.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <param name="axis1">First axis.</param>
        /// <param name="axis2">Second axis.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector4 WithNegate(this Vector4 vector, int axis1, int axis2)
        {
            vector[axis1] = -vector[axis1];
            vector[axis2] = -vector[axis2];

            return vector;
        }

        /// <summary>
        /// Inverts x and y axes values.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector4 WithNegateXY(this Vector4 vector) => vector.WithNegate(0, 1);

        /// <summary>
        /// Inverts x and z axes values.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector4 WithNegateXZ(this Vector4 vector) => vector.WithNegate(0, 2);

        /// <summary>
        /// Inverts x and w axes values.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector4 WithNegateXW(this Vector4 vector) => vector.WithNegate(0, 3);

        /// <summary>
        /// Inverts y and z axes values.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector4 WithNegateYZ(this Vector4 vector) => vector.WithNegate(1, 2);

        /// <summary>
        /// Inverts y and w axes values.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector4 WithNegateYW(this Vector4 vector) => vector.WithNegate(1, 3);

        /// <summary>
        /// Inverts values of specified axes.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <param name="axis1">First axis.</param>
        /// <param name="axis2">Second axis.</param>
        /// <param name="axis2">Third axis.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector4 WithNegate(this Vector4 vector, int axis1, int axis2, int axis3)
        {
            vector[axis1] = -vector[axis1];
            vector[axis2] = -vector[axis2];
            vector[axis3] = -vector[axis3];

            return vector;
        }

        /// <summary>
        /// Inverts x, y and z axes values.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector4 WithNegateXYZ(this Vector4 vector) => vector.WithNegate(0, 1, 2);

        /// <summary>
        /// Inverts x, y and w axes values.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector4 WithNegateXYW(this Vector4 vector) => vector.WithNegate(0, 1, 3);

        /// <summary>
        /// Inverts x, z and w axes values.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector4 WithNegateXZW(this Vector4 vector) => vector.WithNegate(0, 2, 3);

        /// <summary>
        /// Inverts y, z and w axes values.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Vector with inverted axes values.</returns>
        public static Vector4 WithNegateYZW(this Vector4 vector) => vector.WithNegate(1, 2, 3);

        /// <summary>
        /// Inverts vector.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>Inverted vector.</returns>
        public static Vector4 Negate(this Vector4 vector) => new(-vector.x, -vector.y, -vector.z, -vector.w);

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

        private static void Compare(Vector4 vector, ref int index, int compareIndex, int result)
        {
            if (vector[compareIndex].CompareTo(vector[index]) == result)
                index = compareIndex;
        }

        private static int CompareAllComponents(Vector4 vector, int result)
        {
            var index = 0;

            Compare(vector, ref index, 1, result);
            Compare(vector, ref index, 2, result);
            Compare(vector, ref index, 3, result);

            return index;
        }

        /// <summary>
        /// Gets max component info from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's max component tuple info.</returns>
        public static (int index, float value) MaxComponent(this Vector4 vector)
        {
            var index = CompareAllComponents(vector, 1);
            return (index, vector[index]);
        }

        /// <summary>
        /// Gets min component info from vector.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector's min component tuple info.</returns>
        public static (int index, float value) MinComponent(this Vector4 vector)
        {
            var index = CompareAllComponents(vector, -1);
            return (index, vector[index]);
        }

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

        /// <summary>
        /// Creates new vector with absolute components.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Vector with absolute components.</returns>
        public static Vector4 Abs(this Vector4 vector) => new Vector4(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z), Mathf.Abs(vector.w));

        /// <summary>
        /// Creates new vector with clamped components.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="min">The minimum floating value to campare agains.</param>
        /// <param name="max">The maximum floating value to campare agains.</param>
        /// <returns>Clamped vector.</returns>
        public static Vector4 Clamp(this Vector4 vector, float min, float max)
        {
            return new Vector4(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max), Mathf.Clamp(vector.z, min, max), Mathf.Clamp(vector.w, min, max));
        }

        /// <summary>
        /// Creates and returns a vector whose components are limited to 0 and 1.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>Clamped vector.</returns>
        public static Vector4 Clamp01(this Vector4 vector)
        {
            return new Vector4(Mathf.Clamp01(vector.x), Mathf.Clamp01(vector.y), Mathf.Clamp01(vector.z), Mathf.Clamp01(vector.w));
        }

        /// <summary>
        /// Creates and returns a vector whose components are divided by the value.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <param name="other">Vector on which divide</param>
        /// <returns>Divided vector.</returns>
        public static Vector4 Divide(this Vector4 vector, Vector4 other)
        {
            return new Vector4(vector.x / other.x, vector.y / other.y, vector.z / other.z, vector.w / other.w);
        }

        /// <summary>
        /// Checks if the vector contains NaN component.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns>True, if any components of the vector are NaN</returns>
        public static bool IsNaN(this Vector4 vector) => float.IsNaN(vector.x) || float.IsNaN(vector.y) || float.IsNaN(vector.z) || float.IsNaN(vector.w);

        /// <summary>
        /// Checks if the vector components are equals.
        /// </summary>
        /// <param name="vector">Target vector.</param>
        /// <returns><see langword="true"/> if vector's components are equals.</returns>
        public static bool IsUniform(this Vector4 vector)
        {
            return vector.x.Approx(vector.y) && vector.y.Approx(vector.z) && vector.z.Approx(vector.w);
        }
    }
}