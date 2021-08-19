using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class IComparableExtensions
    {
        public static bool IsBetween<T>(this T value, T a, T b, bool aInclusive = true, bool bInclusive = true) where T: IComparable
        {
            if (a.CompareTo(b) == 1)
                (a, b) = (b, a);

            return (aInclusive ? value.CompareTo(a).EqualsToAny(0, 1) : value.CompareTo(a) == 1) && (bInclusive ? value.CompareTo(b).EqualsToAny(-1, 0) : value.CompareTo(b) == -1);
        }
    }
}