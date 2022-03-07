namespace Redcode.Extensions
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
    }
}