using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class IEquatableExtensions
    {
        public static bool EqualsToAll<T>(this T obj, params T[] objects) where T : IEquatable<T> => objects.All(o => o.Equals(obj));

        public static bool EqualsToAny<T>(this T obj, params T[] objects) where T : IEquatable<T> => objects.Any(o => o.Equals(obj));
    }
}