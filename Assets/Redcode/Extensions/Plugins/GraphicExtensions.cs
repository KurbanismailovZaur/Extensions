using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Extensions
{
    public static class GraphicExtensions
    {
        public static void SetColorR(this Graphic graphic, float r) => graphic.color = graphic.color.WithR(r);

        public static void SetColorG(this Graphic graphic, float g) => graphic.color = graphic.color.WithG(g);

        public static void SetColorB(this Graphic graphic, float b) => graphic.color = graphic.color.WithB(b);

        public static void SetColorRG(this Graphic graphic, float r, float g) => graphic.color = graphic.color.WithRG(r, g);

        public static void SetColorRB(this Graphic graphic, float r, float b) => graphic.color = graphic.color.WithRB(r, b);

        public static void SetColorGB(this Graphic graphic, float g, float b) => graphic.color = graphic.color.WithGB(g, b);

        public static void SetColorRGB(this Graphic graphic, float r, float g, float b) => graphic.color = graphic.color.WithRGB(r, g, b);

        public static void SetColorRGB(this Graphic graphic, Color color) => graphic.color = color.WithA(graphic.color.a);

        public static void SetColorA(this Graphic graphic, float a) => graphic.color = graphic.color.WithA(a);

        public static void SetColorRA(this Graphic graphic, float r, float a) => graphic.color = graphic.color.WithRA(r, a);

        public static void SetColorGA(this Graphic graphic, float g, float a) => graphic.color = graphic.color.WithGA(g, a);

        public static void SetColorBA(this Graphic graphic, float b, float a) => graphic.color = graphic.color.WithBA(b, a);

        public static void SetColorRGA(this Graphic graphic, float r, float g, float a) => graphic.color = graphic.color.WithRGA(r, g, a);

        public static void SetColorRBA(this Graphic graphic, float r, float b, float a) => graphic.color = graphic.color.WithRBA(r, b, a);

        public static void SetColorGBA(this Graphic graphic, float g, float b, float a) => graphic.color = graphic.color.WithGBA(g, b, a);
    }
}