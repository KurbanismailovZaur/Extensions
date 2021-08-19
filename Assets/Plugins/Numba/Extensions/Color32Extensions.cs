using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class Color32Extensions
    {
        public static Color32 With(this Color32 color, int axis, byte value)
        {
            color[axis] = value;
            return color;
        }

        public static Color32 WithR(this Color32 color, byte r) => With(color, 0, r);

        public static Color32 WithG(this Color32 color, byte g) => With(color, 1, g);

        public static Color32 WithB(this Color32 color, byte b) => With(color, 2, b);

        public static Color32 WithA(this Color32 color, byte a) => With(color, 3, a);

        public static Color32 With(this Color32 color, int axis1, byte value1, int axis2, byte value2)
        {
            color[axis1] = value1;
            color[axis2] = value2;

            return color;
        }

        public static Color32 WithRG(this Color32 color, byte r, byte g) => With(color, 0, r, 1, g);

        public static Color32 WithRB(this Color32 color, byte r, byte b) => With(color, 0, r, 2, b);

        public static Color32 WithRA(this Color32 color, byte r, byte a) => With(color, 0, r, 3, a);

        public static Color32 WithGB(this Color32 color, byte g, byte b) => With(color, 1, g, 2, b);

        public static Color32 WithGA(this Color32 color, byte g, byte a) => With(color, 1, g, 3, a);

        public static Color32 WithBA(this Color32 color, byte b, byte a) => With(color, 2, b, 3, a);

        public static Color32 With(this Color32 color, int axis1, byte value1, int axis2, byte value2, int axis3, byte value3)
        {
            color[axis1] = value1;
            color[axis2] = value2;
            color[axis3] = value3;

            return color;
        }

        public static Color32 WithRGB(this Color32 color, byte r, byte g, byte b) => With(color, 0, r, 1, g, 2, b);

        public static Color32 WithRGA(this Color32 color, byte r, byte g, byte a) => With(color, 0, r, 1, g, 3, a);

        public static Color32 WithRBA(this Color32 color, byte r, byte b, byte a) => With(color, 0, r, 2, b, 3, a);

        public static Color32 WithGBA(this Color32 color, byte g, byte b, byte a) => With(color, 1, g, 2, b, 3, a);
    }
}