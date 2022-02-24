using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class IEnumerableExtensions
    {
        public static T GetRandomElement<T>(this IEnumerable<T> enumerable) => enumerable.ElementAt(Random.Range(0, enumerable.Count()));

        public static IEnumerable<T> Except<T>(this IEnumerable<T> enumerable, params T[] elements) => enumerable.Except((IEnumerable<T>)elements);

        public static IEnumerable<T> Shuffled<T>(this IEnumerable<T> enumerable) => enumerable.OrderBy(v => Random.value);

        public static string AsString<T>(this IEnumerable<T> enumerable) => $"[{string.Join(", ", enumerable)}]";
    }
}