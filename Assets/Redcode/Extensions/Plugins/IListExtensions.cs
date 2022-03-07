using System.Collections.Generic;
using UnityEngine;

namespace Redcode.Extensions
{
    public static class IListExtensions
    {
        /// <summary>
        /// Pops element by <paramref name="index"/>.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <param name="index">Index of element to pop.</param>
        /// <returns>The popped element.</returns>
        public static T Pop<T>(this IList<T> list, int index)
        {
            var element = list[index];
            list.RemoveAt(index);

            return element;
        }

        /// <summary>
        /// Pops random element from <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <returns>The popped element.</returns>
        public static T PopRandom<T>(this IList<T> list) => Pop(list, Random.Range(0, list.Count));
    }
}