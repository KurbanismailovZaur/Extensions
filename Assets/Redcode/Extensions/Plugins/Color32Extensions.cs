using UnityEngine;

namespace Redcode.Extensions
{
    public static class Color32Extensions
    {
        /// <summary>
        /// Set value to color's channel.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="channel">Channel index of the color.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 With(this Color32 color, int channel, byte value)
        {
            color[channel] = value;
            return color;
        }

        /// <summary>
        /// Set color's red channel value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="r">Value to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithR(this Color32 color, byte r) => With(color, 0, r);

        /// <summary>
        /// Set color's green channel value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="g">Value to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithG(this Color32 color, byte g) => With(color, 1, g);

        /// <summary>
        /// Set color's blue channel value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="b">Value to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithB(this Color32 color, byte b) => With(color, 2, b);

        /// <summary>
        /// Set color's alpha channel value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="a">Value to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithA(this Color32 color, byte a) => With(color, 3, a);

        /// <summary>
        /// Set values to color's channels.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="channel1">First channel index of the color.</param>
        /// <param name="value1">First channel value.</param>
        /// <param name="channel2">Second channel index of the color.</param>
        /// <param name="value2">Second channel value.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 With(this Color32 color, int channel1, byte value1, int channel2, byte value2)
        {
            color[channel1] = value1;
            color[channel2] = value2;

            return color;
        }

        /// <summary>
        /// Set color's red and green channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithRG(this Color32 color, byte r, byte g) => With(color, 0, r, 1, g);

        /// <summary>
        /// Set color's red and blue channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithRB(this Color32 color, byte r, byte b) => With(color, 0, r, 2, b);

        /// <summary>
        /// Set color's red and alpha channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithRA(this Color32 color, byte r, byte a) => With(color, 0, r, 3, a);

        /// <summary>
        /// Set color's green and blue channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithGB(this Color32 color, byte g, byte b) => With(color, 1, g, 2, b);

        /// <summary>
        /// Set color's green and alpha channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithGA(this Color32 color, byte g, byte a) => With(color, 1, g, 3, a);

        /// <summary>
        /// Set color's blue and alpha channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithBA(this Color32 color, byte b, byte a) => With(color, 2, b, 3, a);

        /// <summary>
        /// Set values to color's channels.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="channel1">First channel index of the color.</param>
        /// <param name="value1">First channel value.</param>
        /// <param name="channel2">Second channel index of the color.</param>
        /// <param name="value2">Second channel value.</param>
        /// <param name="channel3">Third channel index of the color.</param>
        /// <param name="value3">Third channel value.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 With(this Color32 color, int channel1, byte value1, int channel2, byte value2, int channel3, byte value3)
        {
            color[channel1] = value1;
            color[channel2] = value2;
            color[channel3] = value3;

            return color;
        }

        /// <summary>
        /// Set color's red, green and blue channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithRGB(this Color32 color, byte r, byte g, byte b) => With(color, 0, r, 1, g, 2, b);

        /// <summary>
        /// Set color's red, green and alpha channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithRGA(this Color32 color, byte r, byte g, byte a) => With(color, 0, r, 1, g, 3, a);

        /// <summary>
        /// Set color's red, blue and alpha channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithRBA(this Color32 color, byte r, byte b, byte a) => With(color, 0, r, 2, b, 3, a);

        /// <summary>
        /// Set color's green, blue and alpha channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color32 WithGBA(this Color32 color, byte g, byte b, byte a) => With(color, 1, g, 2, b, 3, a);
    }
}