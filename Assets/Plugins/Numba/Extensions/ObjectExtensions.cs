using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class ObjectExtensions
    {
        public static bool EqualsToAll(this object obj, params object[] objects) => objects.All(o => o.Equals(obj));

        public static bool EqualsToAny(this object obj, params object[] objects) => objects.Any(o => o.Equals(obj));
    }
}