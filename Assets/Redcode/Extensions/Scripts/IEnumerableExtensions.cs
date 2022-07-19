using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Redcode.Extensions
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Get random element from the <paramref name="enumerable"/>.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns>Random element from enumerable.</returns>
        public static T GetRandomElement<T>(this IEnumerable<T> enumerable) => enumerable.ElementAt(Random.Range(0, enumerable.Count()));

        /// <summary>
        /// Excepts passed elements from <paramref name="enumerable"/>.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="elements">Elements to exclude.</param>
        /// <returns>Enumerable without passed elements.</returns>
        public static IEnumerable<T> Except<T>(this IEnumerable<T> enumerable, params T[] elements) => enumerable.Except((IEnumerable<T>)elements);

        /// <summary>
        /// Shuffles <paramref name="enumerable"/>.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns>Shuffled <paramref name="enumerable"/>.</returns>
        public static IEnumerable<T> Shuffled<T>(this IEnumerable<T> enumerable) => enumerable.OrderBy(v => Random.value);

        /// <summary>
        /// Represents an enumerable as a string in the format <see langword="[a, b, c, ...]"/> 
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns>String representation of the <paramref name="enumerable"/></returns>
        public static string AsString<T>(this IEnumerable<T> enumerable) => $"[{string.Join(", ", enumerable)}]";
    }
}