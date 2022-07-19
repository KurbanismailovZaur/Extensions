using UnityEngine;

namespace Redcode.Extensions
{
    public static class ColorExtensions
    {
        /// <summary>
        /// Set value to color's channel.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="channel">Channel index of the color.</param>
        /// <param name="value">Value to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color With(this Color color, int channel, float value)
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
        public static Color WithR(this Color color, float r) => With(color, 0, r);

        /// <summary>
        /// Set color's green channel value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="g">Value to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color WithG(this Color color, float g) => With(color, 1, g);

        /// <summary>
        /// Set color's blue channel value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="b">Value to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color WithB(this Color color, float b) => With(color, 2, b);

        /// <summary>
        /// Set color's alpha channel value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="a">Value to set.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color WithA(this Color color, float a) => With(color, 3, a);

        /// <summary>
        /// Set values to color's channels.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="channel1">First channel index of the color.</param>
        /// <param name="value1">First channel value.</param>
        /// <param name="channel2">Second channel index of the color.</param>
        /// <param name="value2">Second channel value.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color With(this Color color, int channel1, float value1, int channel2, float value2)
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
        public static Color WithRG(this Color color, float r, float g) => With(color, 0, r, 1, g);

        /// <summary>
        /// Set color's red and blue channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color WithRB(this Color color, float r, float b) => With(color, 0, r, 2, b);

        /// <summary>
        /// Set color's red and alpha channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color WithRA(this Color color, float r, float a) => With(color, 0, r, 3, a);

        /// <summary>
        /// Set color's green and blue channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color WithGB(this Color color, float g, float b) => With(color, 1, g, 2, b);

        /// <summary>
        /// Set color's green and alpha channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color WithGA(this Color color, float g, float a) => With(color, 1, g, 3, a);

        /// <summary>
        /// Set color's blue and alpha channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color WithBA(this Color color, float b, float a) => With(color, 2, b, 3, a);

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
        public static Color With(this Color color, int channel1, float value1, int channel2, float value2, int channel3, float value3)
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
        public static Color WithRGB(this Color color, float r, float g, float b) => With(color, 0, r, 1, g, 2, b);

        /// <summary>
        /// Set color's red, green and alpha channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color WithRGA(this Color color, float r, float g, float a) => With(color, 0, r, 1, g, 3, a);

        /// <summary>
        /// Set color's red, blue and alpha channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="r">Value to set in red channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color WithRBA(this Color color, float r, float b, float a) => With(color, 0, r, 2, b, 3, a);

        /// <summary>
        /// Set color's green, blue and alpha channels value.
        /// </summary>
        /// <param name="color">Target color.</param>
        /// <param name="g">Value to set in green channel.</param>
        /// <param name="b">Value to set in blue channel.</param>
        /// <param name="a">Value to set in alpha channel.</param>
        /// <returns>Changed copy of the color.</returns>
        public static Color WithGBA(this Color color, float g, float b, float a) => With(color, 1, g, 2, b, 3, a);
    }
}