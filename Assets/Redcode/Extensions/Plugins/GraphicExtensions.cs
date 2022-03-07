using UnityEngine;
using UnityEngine.UI;

namespace Redcode.Extensions
{
    public static class GraphicExtensions
    {
        /// <summary>
        /// Set color's red channel value of the graphic object.
        /// </summary>
        /// <param name="graphic">Target graphic.</param>
        /// <param name="r">Value to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorR(this Graphic graphic, float r) => graphic.color = graphic.color.WithR(r);

        /// <summary>
        /// Set color's green channel value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="g">Value to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorG(this Graphic graphic, float g) => graphic.color = graphic.color.WithG(g);

        /// <summary>
        /// Set color's blue channel value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="b">Value to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorB(this Graphic graphic, float b) => graphic.color = graphic.color.WithB(b);

        /// <summary>
        /// Set color's alpha channel value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="a">Value to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorA(this Graphic graphic, float a) => graphic.color = graphic.color.WithA(a);

        /// <summary>
        /// Set color's red and green channels value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorRG(this Graphic graphic, float r, float g) => graphic.color = graphic.color.WithRG(r, g);

        /// <summary>
        /// Set color's red and blue channels value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorRB(this Graphic graphic, float r, float b) => graphic.color = graphic.color.WithRB(r, b);

        /// <summary>
        /// Set color's red and alpha channels value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorRA(this Graphic graphic, float r, float a) => graphic.color = graphic.color.WithRA(r, a);

        /// <summary>
        /// Set color's green and blue channels value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorGB(this Graphic graphic, float g, float b) => graphic.color = graphic.color.WithGB(g, b);

        /// <summary>
        /// Set color's green and alpha channels value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorGA(this Graphic graphic, float g, float a) => graphic.color = graphic.color.WithGA(g, a);

        /// <summary>
        /// Set color's blue and alpha channels value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorBA(this Graphic graphic, float b, float a) => graphic.color = graphic.color.WithBA(b, a);

        /// <summary>
        /// Set color's red, green and blue channels value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorRGB(this Graphic graphic, float r, float g, float b) => graphic.color = graphic.color.WithRGB(r, g, b);

        /// <summary>
        /// Set color's red, green and blue channels value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="color">Color to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorRGB(this Graphic graphic, Color color) => graphic.color = color.WithA(graphic.color.a);

        /// <summary>
        /// Set color's red, green and alpha channels value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorRGA(this Graphic graphic, float r, float g, float a) => graphic.color = graphic.color.WithRGA(r, g, a);

        /// <summary>
        /// Set color's red, blue and alpha channels value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorRBA(this Graphic graphic, float r, float b, float a) => graphic.color = graphic.color.WithRBA(r, b, a);

        /// <summary>
        /// Set color's green, blue and alpha channels value.
        /// </summary>
        /// <param name="graphic">Target color.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static void SetColorGBA(this Graphic graphic, float g, float b, float a) => graphic.color = graphic.color.WithGBA(g, b, a);
    }
}