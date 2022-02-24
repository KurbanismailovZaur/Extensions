using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Extensions;

namespace Extensions
{
	public static class DoubleExtensions
    {
        public static bool NearlyEquals(this double value, double other, double epsilon = 0.0000001f)
        {
            if (value == other) // Simple check, also handles infinities.
                return true;

            value = Math.Abs(value);
            other = Math.Abs(other);

            return Math.Abs(value - other) < epsilon;
        }

        public static double Remap(this double value, double min1, double max1, double min2, double max2)
        {
            return min2 + (value - min1) * (max2 - min2) / (max1 - min1);
        }
    }
}