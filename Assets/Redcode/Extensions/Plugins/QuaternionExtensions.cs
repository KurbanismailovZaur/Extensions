using UnityEngine;

namespace Redcode.Extensions
{
    public static class QuaternionExtensions
    {
        /// <summary>
        /// Sets <paramref name="value"/> to passed <paramref name="axis"/>.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="axis">Axis to set.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion With(this Quaternion quaternion, int axis, float value)
        {
            quaternion[axis] = value;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="x"/> value to x axis.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithX(this Quaternion quaternion, float x) => With(quaternion, 0, x);

        /// <summary>
        /// Sets <paramref name="y"/> value to y axis.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="y">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithY(this Quaternion quaternion, float y) => With(quaternion, 1, y);

        /// <summary>
        /// Sets <paramref name="z"/> value to z axis.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="z">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithZ(this Quaternion quaternion, float z) => With(quaternion, 2, z);

        /// <summary>
        /// Sets <paramref name="w"/> value to w axis.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="w">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithW(this Quaternion quaternion, float w) => With(quaternion, 3, w);

        /// <summary>
        /// Sets values to passed axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="axis1">First axis to set.</param>
        /// <param name="value1">First value to set.</param>
        /// <param name="axis2">Second axis to set.</param>
        /// <param name="value2">Second value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion With(this Quaternion quaternion, int axis1, float value1, int axis2, float value2)
        {
            quaternion[axis1] = value1;
            quaternion[axis2] = value2;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="x"/> and <paramref name="y"/> values to respective axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithXY(this Quaternion quaternion, float x, float y) => With(quaternion, 0, x, 1, y);

        /// <summary>
        /// Sets <paramref name="values"/> components to specified axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithXY(this Quaternion quaternion, Vector2 values) => With(quaternion, 0, values.x, 1, values.y);

        /// <summary>
        /// Sets <paramref name="x"/> and <paramref name="z"/> values to respective axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithXZ(this Quaternion quaternion, float x, float z) => With(quaternion, 0, x, 2, z);

        /// <summary>
        /// Sets <paramref name="values"/> components to specified axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithXZ(this Quaternion quaternion, Vector2 values) => With(quaternion, 0, values.x, 2, values.y);

        /// <summary>
        /// Sets <paramref name="y"/> and <paramref name="z"/> values to respective axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithYZ(this Quaternion quaternion, float y, float z) => With(quaternion, 1, y, 2, z);

        /// <summary>
        /// Sets <paramref name="values"/> components to specified axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithYZ(this Quaternion quaternion, Vector2 values) => With(quaternion, 1, values.x, 2, values.y);

        /// <summary>
        /// Sets <paramref name="x"/> and <paramref name="w"/> values to respective axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithXW(this Quaternion quaternion, float x, float w) => With(quaternion, 0, x, 3, w);

        /// <summary>
        /// Sets <paramref name="values"/> components to specified axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithXW(this Quaternion quaternion, Vector2 values) => With(quaternion, 0, values.x, 3, values.y);

        /// <summary>
        /// Sets <paramref name="y"/> and <paramref name="w"/> values to respective axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithYW(this Quaternion quaternion, float y, float w) => With(quaternion, 1, y, 3, w);

        /// <summary>
        /// Sets <paramref name="values"/> components to specified axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithYW(this Quaternion quaternion, Vector2 values) => With(quaternion, 1, values.x, 3, values.y);

        /// <summary>
        /// Sets <paramref name="z"/> and <paramref name="w"/> values to respective axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="z">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithZW(this Quaternion quaternion, float z, float w) => With(quaternion, 2, z, 3, w);

        /// <summary>
        /// Sets <paramref name="values"/> components to specified axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithZW(this Quaternion quaternion, Vector2 values) => With(quaternion, 2, values.x, 3, values.y);

        /// <summary>
        /// Sets values to passed axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="axis1">First axis to set.</param>
        /// <param name="value1">First value to set.</param>
        /// <param name="axis2">Second axis to set.</param>
        /// <param name="value2">Second value to set.</param>
        /// <param name="axis3">Third axis to set.</param>
        /// <param name="value3">Third value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion With(this Quaternion quaternion, int axis1, float value1, int axis2, float value2, int axis3, float value3)
        {
            quaternion[axis1] = value1;
            quaternion[axis2] = value2;
            quaternion[axis3] = value3;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="x"/>, <paramref name="y"/> and <paramref name="z"/> values to respective axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithXYZ(this Quaternion quaternion, float x, float y, float z) => With(quaternion, 0, x, 1, y, 2, z);

        /// <summary>
        /// Sets <paramref name="values"/> components to specified axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithXYZ(this Quaternion quaternion, Vector3 values) => With(quaternion, 0, values.x, 1, values.y, 2, values.z);

        /// <summary>
        /// Sets <paramref name="x"/>, <paramref name="y"/> and <paramref name="w"/> values to respective axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithXYW(this Quaternion quaternion, float x, float y, float w) => With(quaternion, 0, x, 1, y, 3, w);

        /// <summary>
        /// Sets <paramref name="values"/> components to specified axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithXYW(this Quaternion quaternion, Vector3 values) => With(quaternion, 0, values.x, 1, values.y, 3, values.z);

        /// <summary>
        /// Sets <paramref name="x"/>, <paramref name="z"/> and <paramref name="w"/> values to respective axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithXZW(this Quaternion quaternion, float x, float z, float w) => With(quaternion, 0, x, 2, z, 3, w);

        /// <summary>
        /// Sets <paramref name="values"/> components to specified axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithXZW(this Quaternion quaternion, Vector3 values) => With(quaternion, 0, values.x, 2, values.y, 3, values.z);

        /// <summary>
        /// Sets <paramref name="y"/>, <paramref name="z"/> and <paramref name="w"/> values to respective axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithYZW(this Quaternion quaternion, float y, float z, float w) => With(quaternion, 1, y, 2, z, 3, w);

        /// <summary>
        /// Sets <paramref name="values"/> components to specified axes.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Value to set.</param>
        /// <returns><inheritdoc cref="With(Quaternion, int, float)"/></returns>
        public static Quaternion WithYZW(this Quaternion quaternion, Vector3 values) => With(quaternion, 1, values.x, 2, values.y, 3, values.z);
    }
}