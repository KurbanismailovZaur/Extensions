using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class GyroscopeExtensions
    {
        public static Quaternion GetRotation(this Gyroscope gyroscope) => gyroscope.attitude.WithZW(-gyroscope.attitude.z, -gyroscope.attitude.w);
    }
}