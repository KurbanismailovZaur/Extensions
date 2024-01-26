using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Codomaster.Extensions
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// Remap a value from one range to another.
        /// </summary>
        /// <param name="value">Source value.</param>
        /// <param name="min1">Source min.</param>
        /// <param name="max1">Source max.</param>
        /// <param name="min2">Target min.</param>
        /// <param name="max2">Target max</param>
        /// <returns>Remaped value.</returns>
        public static double Remap(this double value, double min1, double max1, double min2, double max2)
        {
            return min2 + (value - min1) * (max2 - min2) / (max1 - min1);
        }

        /// <summary>
        /// Checks <paramref name="value"/> for approximate equality with <paramref name="other"/> and <paramref name="tolerance"/>.
        /// </summary>
        /// <param name="value">First operand.</param>
        /// <param name="other">Second operand.</param>
        /// <param name="minDifference">If difference between <paramref name="value"/> and <paramref name="other"/> is smaller than this, then result is true.</param>
        /// <returns><see langword="true"/> if the variables are the same.</returns>
        public static bool Approx(this double value, double other, double minDifference = 1E-17) => Math.Abs(value - other) <= minDifference;

        /// <summary>
        /// Randomly changes the sign (+ or -) of <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Target value.</param>
        /// <returns>Value with randomed sign.</returns>
        public static double WithRandomSign(this double value) => value * (Random.Range(0, 2) * 2 - 1);
    }
}