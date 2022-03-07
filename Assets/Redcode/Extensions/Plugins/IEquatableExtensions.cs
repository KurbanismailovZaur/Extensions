using System;
using System.Linq;

namespace Redcode.Extensions
{
    public static class IEquatableExtensions
    {
        /// <summary>
        ///  Checks if the <paramref name="value"/> equals to all elements of <paramref name="values"/> array.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="value">Object to compare.</param>
        /// <param name="values">Array with objects to compare.</param>
        /// <returns><see langword="true"/> if the all element of <paramref name="values"/> are equals to <paramref name="value"/>.</returns>
        public static bool EqualsToAll<T>(this T value, params T[] values) where T : IEquatable<T> => values.All(o => o.Equals(value));

        /// <summary>
        ///  Checks if the <paramref name="value"/> equals to at least one of elements of <paramref name="values"/> array.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="value">Object to compare.</param>
        /// <param name="values">Array with objects to compare.</param>
        /// <returns><see langword="true"/> if at least one of all elements of <paramref name="values"/> are equals to <paramref name="value"/>.</returns>
        public static bool EqualsToAny<T>(this T value, params T[] values) where T : IEquatable<T> => values.Any(o => o.Equals(value));
    }
}