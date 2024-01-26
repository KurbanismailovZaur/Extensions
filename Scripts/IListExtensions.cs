using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Codomaster.Extensions
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
        /// Pops elements by <paramref name="indexes"/>.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <param name="indexes">Indexes of elements to be popped.</param>
        /// <returns>The popped element.</returns>
        public static List<T> Pop<T>(this IList<T> list, params int[] indexes)
        {
            var popped = new List<T>();

            foreach (var index in indexes)
                popped.Add(list[index]);

            foreach (var index in indexes.OrderByDescending(i => i))
                list.RemoveAt(index);

            return popped;
        }

        /// <summary>
        /// Pops random element from <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <returns>Tuple with popped element and it's index.</returns>
        public static (T element, int index) PopRandom<T>(this IList<T> list)
        {
            var index = UnityEngine.Random.Range(0, list.Count);
            return (list.Pop(index), index);
        }

        /// <summary>
        /// Pops random elements from list.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <param name="count">Count of elements to be popped.</param>
        /// <param name="clampCount">Should we clamp <paramref name="count"/> by <paramref name="list"/> elements count?</param>
        /// <returns>List of tuples with popped elements and it's indexes.</returns>
        public static List<(T element, int index)> PopRandoms<T>(this IList<T> list, int count, bool clampCount = false)
        {
            if (clampCount)
                count = Mathf.Clamp(count, 0, list.Count);

            var popped = new List<(T element, int index)>();

            for (int i = 0; i < count; i++)
                popped.Add(list.PopRandom());

            return popped;
        }

        /// <summary>
        /// Pops random elements from list with specified probability.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <param name="probabilities">Probabilities, must match in count with enumerable.</param>
        /// <returns>Popped element.</returns>
        public static (T element, int index) PopRandomWithProbability<T>(this IList<T> list, params float[] probabilities)
        {
            return PopRandomWithProbability(list, (IEnumerable<float>)probabilities);
        }

        /// <summary>
        /// Pops random elements from list with specified probability.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <param name="probabilities">Probabilities, must match in count with enumerable.</param>
        /// <returns>Popped elements.</returns>
        public static (T element, int index) PopRandomWithProbability<T>(this IList<T> list, IEnumerable<float> probabilities)
        {
            var random = list.GetRandomWithProbability(probabilities);
            Pop(list, random.index);

            return random;
        }

        /// <summary>
        /// Pops random elements from list with specified probability selector.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="list">List with elements.</param>
        /// <param name="probabilitiesSelector">Probabilities selector.</param>
        /// <returns>Popped elements.</returns>
        public static (T element, int index) PopRandomWithProbability<T>(this IList<T> list, Func<T, float> probabilitiesSelector)
        {
            var random = list.GetRandomWithProbability(probabilitiesSelector);
            Pop(list, random.index);

            return random;
        }

        /// <summary>
        /// Removes all elements starts from <paramref name="index"/>.
        /// </summary>
        /// <typeparam name="T">Elements type.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="index">From what index need starts removing?</param>
        public static void RemoveRange<T>(this IList<T> list, int index)
        {
            for (int i = list.Count - 1; i >= index; i--)
                list.RemoveAt(i);
        }
        
        /// <summary>
        /// Shuffles <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="list">The original list.</param>
        /// <returns>Shuffled original.</returns>
        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            var n = list.Count;
            
            while (n > 1)
            {
                var index = UnityEngine.Random.Range(0, --n + 1);  
                (list[index], list[n]) = (list[n], list[index]);
            }

            return list;
        }

        /// <summary>
        /// Swaps two elements.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="list">The original list.</param>
        /// <param name="index1">First index to swap.</param>
        /// <param name="index2">Second index to swap.</param>
        /// <returns>Original list.</returns>
        public static IList<T> Swap<T>(this IList<T> list, int index1, int index2)
        {
            (list[index1], list[index2]) = (list[index2], list[index1]);
            return list;
        }
    }
}