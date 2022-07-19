using System;

namespace Redcode.Extensions
{
    public static class IComparableExtensions
    {
        /// <summary>
        /// Checks if the object is on the specified interval. 
        /// </summary>
        /// <typeparam name="T">Value type.</typeparam>
        /// <param name="value">Target value.</param>
        /// <param name="a">Interval's start value.</param>
        /// <param name="b">Interval's end value.</param>
        /// <param name="aInclusive">Is the beginning of the interval included?</param>
        /// <param name="bInclusive">Is the end of the interval included?</param>
        /// <returns><see langword="true"/> if the <paramref name="value"/> is between <paramref name="a"/> and <paramref name="b"/>.</returns>
        public static bool IsBetween<T>(this T value, T a, T b, bool aInclusive = true, bool bInclusive = true) where T: IComparable
        {
            if (a.CompareTo(b) == 1)
            {
                (a, b) = (b, a);
                (aInclusive, bInclusive) = (bInclusive, aInclusive);
            }

            return (aInclusive ? value.CompareTo(a).EqualsToAny(0, 1) : value.CompareTo(a) == 1) && (bInclusive ? value.CompareTo(b).EqualsToAny(-1, 0) : value.CompareTo(b) == -1);
        }
    }
}