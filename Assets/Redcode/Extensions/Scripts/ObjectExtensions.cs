using System.Linq;

namespace Redcode.Extensions
{
    public static class ObjectExtensions
    {
        /// <summary>
        ///  Checks if the <paramref name="obj"/> equals to all elements of <paramref name="objects"/> array.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="obj">Object to compare.</param>
        /// <param name="objects">Array with objects to compare.</param>
        /// <returns><see langword="true"/> if the all element of <paramref name="objects"/> are equals to <paramref name="obj"/></returns>
        public static bool EqualsToAll(this object obj, params object[] objects) => objects.All(o => o.Equals(obj));

        /// <summary>
        ///  Checks if the <paramref name="value"/> equals to at least one of elements of <paramref name="values"/> array.
        /// </summary>
        /// <typeparam name="T">Source type.</typeparam>
        /// <param name="value">Object to compare.</param>
        /// <param name="values">Array with objects to compare.</param>
        /// <returns><see langword="true"/> if at least one of all elements of <paramref name="values"/> are equals to <paramref name="value"/>.</returns>
        public static bool EqualsToAny(this object obj, params object[] objects) => objects.Any(o => o.Equals(obj));
    }
}