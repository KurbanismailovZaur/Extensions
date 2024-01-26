using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityRandom = UnityEngine.Random;

namespace Codomaster.Extensions
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Get random element from the <paramref name="enumerable"/>.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns>Random element from enumerable.</returns>
        public static T GetRandom<T>(this IEnumerable<T> enumerable) => enumerable.ElementAt(UnityRandom.Range(0, enumerable.Count()));

        /// <summary>
        /// Get random elements from the <paramref name="enumerable"/>.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="count">Count of the random elements.</param>
        /// <param name="clampCount">Does we need clamp <paramref name="count"/> if it greater than <paramref name="enumerable"/> elements count.</param>
        /// <returns>Random elements from enumerable.</returns>
        public static List<T> GetRandoms<T>(this IEnumerable<T> enumerable, int count, bool clampCount = false)
        {
            if (clampCount)
                count = Mathf.Min(count, enumerable.Count());

            var poppedIndexes = Enumerable.Range(0, enumerable.Count()).ToList().PopRandoms(count).Select(p => p.element);
            return enumerable.Where((el, i) => poppedIndexes.Contains(i)).ToList();
        }

        /// <summary>
        /// Excepts passed elements from <paramref name="enumerable"/>.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="elements">Elements to exclude.</param>
        /// <returns>List without passed elements.</returns>
        public static List<T> Except<T>(this IEnumerable<T> enumerable, params T[] elements) => enumerable.Except((IEnumerable<T>)elements).ToList();

        /// <summary>
        /// Shuffles <paramref name="enumerable"/>.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns>Shuffled copy.</returns>
        public static List<T> Shuffled<T>(this IEnumerable<T> enumerable) => enumerable.OrderBy(v => UnityRandom.value).ToList();

        /// <summary>
        /// Represents an enumerable as a string in the format <see langword="[a, b, c, ...]"/> 
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns>String representation of the <paramref name="enumerable"/></returns>
        public static string AsString<T>(this IEnumerable<T> enumerable) => $"[{string.Join(", ", enumerable)}]";

        /// <summary>
        /// Get random element index with probability selector.
        /// </summary>
        /// <typeparam name="T">Enumerable elements type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="probabilities">Probabilities, must match in count with enumerable.</param>
        /// <returns>Tuple with random element and it's index.</returns>
        /// <exception cref="ArgumentException">Throwed when <paramref name="enumerable"/> and <paramref name="probabilities"/> counts are not match.</exception>
        public static (T element, int index) GetRandomWithProbability<T>(this IEnumerable<T> enumerable, params float[] probabilities) => GetRandomWithProbability(enumerable, (IEnumerable<float>)probabilities);

        /// <summary>
        /// Get random element index with probability selector.
        /// </summary>
        /// <typeparam name="T">Enumerable elements type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="probabilities">Probabilities, must match in count with enumerable.</param>
        /// <param name="probabilitiesSum">Sum of probabilities.</param>
        /// <returns>Tuple with random element and it's index.</returns>
        /// <exception cref="ArgumentException">Throwed when <paramref name="enumerable"/> and <paramref name="probabilities"/> counts are not match.</exception>
        public static (T element, int index) GetRandomWithProbability<T>(this IEnumerable<T> enumerable, double? probabilitiesSum, params float[] probabilities) => GetRandomWithProbability(enumerable, (IEnumerable<float>)probabilities, (float)probabilitiesSum);

        /// <summary>
        /// <inheritdoc cref="GetRandomWithProbability{T}"/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc cref="GetRandomWithProbability{T}"/></typeparam>
        /// <param name="enumerable"><inheritdoc cref="GetRandomWithProbability{T}" path="/param[@name='enumerable']"/></param>
        /// <param name="probabilities"><inheritdoc cref="GetRandomWithProbability{T}" path="/param[@name='probabilities']"/></param>
        /// <param name="probabilitiesSum">Sum of probabilities.</param>
        /// <returns>Tuple with random element and it's index.</returns>
        /// <exception cref="ArgumentException">Throwed when <paramref name="enumerable"/> and <paramref name="probabilities"/> counts are not match.</exception>
        public static (T element, int index) GetRandomWithProbability<T>(this IEnumerable<T> enumerable, IEnumerable<float> probabilities, float? probabilitiesSum = null)
        {
            var count = enumerable.Count();

            if (probabilities.Count() != count)
                throw new ArgumentException($"Count of probabilities and enumerble elements must be equal.");

            if (count == 0)
                throw new ArgumentException($"Enumerable count must be greater than zero");

            if (probabilitiesSum == null)
            {
                probabilitiesSum = 0f;

                foreach (var element in probabilities)
                    probabilitiesSum += element;
            }

            var randomValue = UnityRandom.value * probabilitiesSum.Value;

            var sum = 0f;
            var index = -1;

            var enumerator = probabilities.GetEnumerator();

            while (enumerator.MoveNext())
            {
                index += 1;
                var probability = enumerator.Current;

                sum += probability;

                if (randomValue < sum || randomValue.Approx(sum))
                    return (enumerable.ElementAt(index), index);
            }

            index = count - 1;
            return (enumerable.ElementAt(index), index);
        }

        /// <summary>
        /// <inheritdoc cref="GetRandomWithProbability{T}"/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc cref="GetRandomWithProbability{T}"/></typeparam>
        /// <param name="enumerable"><inheritdoc cref="GetRandomWithProbability{T}" path="/param[@name='enumerable']"/></param>
        /// <param name="probabilitySelector">Probabilities selector.</param>
        /// <param name="probabilitiesSum">Sum of probabilities.</param>
        /// <returns>Tuple with random element and it's index.</returns>
        /// <exception cref="ArgumentException">Throwed when <paramref name="enumerable"/> count are zero.</exception>
        public static (T element, int index) GetRandomWithProbability<T>(this IEnumerable<T> enumerable, Func<T, float> probabilitySelector, float? probabilitiesSum = null)
        {
            var count = enumerable.Count();

            if (count == 0)
                throw new ArgumentException($"Enumerable count must be greater than zero");

            if (probabilitiesSum == null)
            {
                probabilitiesSum = 0f;

                foreach (var element in enumerable)
                    probabilitiesSum += probabilitySelector(element);
            }

            var randomValue = UnityRandom.value * probabilitiesSum.Value;

            var sum = 0f;
            var index = -1;

            var enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                index += 1;
                var probability = probabilitySelector(enumerator.Current);

                sum += probability;

                if (randomValue < sum || randomValue.Approx(sum))
                    return (enumerator.Current, index);
            }

            return (enumerator.Current, count - 1);
        }

        /// <summary>
        /// Loops over all elements.
        /// </summary>
        /// <typeparam name="T">Elements type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="action">What to do with each element?</param>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var element in enumerable)
                action(element);
        }

        /// <summary>
        /// Find object with minimal value by expression.
        /// </summary>
        /// <typeparam name="T">Elements type.</typeparam>
        /// <typeparam name="U"><paramref name="expression"/> result type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="expression">Expression which used to calculate minimal values.</param>
        /// <returns>Tuple <see langword="(index, element)"/> with minimal value by expression. If there is no elements, then <see langword="(-1, default)"/> will be returned.</returns>
        public static (int index, T element) MinBy<T, U>(this IEnumerable<T> enumerable, Func<T, U> expression) where U : IComparable<U>
        {
            var enumerator = enumerable.GetEnumerator();

            if (!enumerator.MoveNext())
                return (-1, default);

            var minIndex = 0;
            var minObj = enumerator.Current;
            var minValue = expression(minObj);

            var index = 0;

            while (enumerator.MoveNext())
            {
                index += 1;
                var otherMinValue = expression(enumerator.Current);

                if (otherMinValue.CompareTo(minValue) > -1)
                    continue;

                minIndex = index;
                minObj = enumerator.Current;
                minValue = otherMinValue;
            }

            return (minIndex, minObj);
        }

        /// <summary>
        /// Find object with maximal value by expression.
        /// </summary>
        /// <typeparam name="T">Elements type.</typeparam>
        /// <typeparam name="U"><paramref name="expression"/> result type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="expression">Expression which used to calculate maximal values.</param>
        /// <returns>Tuple <see langword="(index, element)"/> with maximal value by expression. If there is no elements, then <see langword="(-1, default)"/> will be returned.</returns>
        public static (int index, T element) MaxBy<T, U>(this IEnumerable<T> enumerable, Func<T, U> expression) where U : IComparable<U>
        {
            var enumerator = enumerable.GetEnumerator();

            if (!enumerator.MoveNext())
                return (-1, default);

            var maxIndex = 0;
            var maxObj = enumerator.Current;
            var maxValue = expression(maxObj);

            var index = 0;

            while (enumerator.MoveNext())
            {
                index += 1;
                var otherMinValue = expression(enumerator.Current);

                if (otherMinValue.CompareTo(maxValue) < 1)
                    continue;

                maxIndex = index;
                maxObj = enumerator.Current;
                maxValue = otherMinValue;
            }

            return (maxIndex, maxObj);
        }
    }
}