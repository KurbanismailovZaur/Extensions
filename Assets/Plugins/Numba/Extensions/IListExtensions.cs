using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class IListExtensions
    {
        public static T Pop<T>(this IList<T> list, int index)
        {
            var element = list[index];
            list.RemoveAt(index);

            return element;
        }

        public static T PopRandom<T>(this IList<T> list) => Pop(list, Random.Range(0, list.Count));
    }
}