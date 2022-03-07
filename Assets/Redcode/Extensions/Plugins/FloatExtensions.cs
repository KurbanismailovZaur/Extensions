using UnityEngine;

namespace Redcode.Extensions
{
    public static class FloatExtensions
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
        public static float Remap(this float value, float min1, float max1, float min2, float max2)
        {
            return min2 + (value - min1) * (max2 - min2) / (max1 - min1);
        }

        /// <summary>
        /// Checks <paramref name="value"/> for approximate equality with <paramref name="other"/>.
        /// </summary>
        /// <param name="value">First operand.</param>
        /// <param name="other">Second operand.</param>
        /// <returns><see langword="true"/> if the variables are the same.</returns>
        public static bool Approximately(this float value, float other) => Mathf.Approximately(value, other);
}
}