using UnityEngine;

namespace Codomaster.Extensions
{
    public static class RayExtensions
	{
        /// <summary>
        /// Create reversed ray.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="maxDistance">Max distance for ray.</param>
        /// <returns>Reversed ray.</returns>
		public static Ray Reversed(this Ray ray, float maxDistance) => new Ray(ray.GetPoint(maxDistance), -ray.direction);

        /// <summary>
        /// Arbitrarily deviates ray direction by a given <paramref name="angle"/>.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="angle">Angle on which ray will be deflected.</param>
        /// <returns>Deflected ray.</returns>
        public static Ray RandomDeflected(this Ray ray, float angle) => RandomDeflected(ray, new Vector2(angle, angle), Vector3.up);

        /// <summary>
        /// Arbitrarily deviates ray direction by a given <paramref name="angle"/>, taking into account the <paramref name="up"/> axis.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="angle">Angle on which ray will be deflected.</param>
        /// <param name="up">Up axis.</param>
        /// <returns>Deflected ray.</returns>
        public static Ray RandomDeflected(this Ray ray, float angle, Vector3 up) => RandomDeflected(ray, new Vector2(angle, angle), up);

        /// <summary>
        /// Arbitrarily deviates ray direction by a given <paramref name="angleX"/> and <paramref name="angleY"/>.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="angleX">Angle on which ray will be deflected by X axis.</param>
        /// <param name="angleY">Angle on which ray will be deflected by Y axis.</param>
        /// <returns>Deflected ray.</returns>
        public static Ray RandomDeflected(this Ray ray, float angleX, float angleY) => RandomDeflected(ray, new Vector2(angleX, angleY), Vector3.up);

        /// <summary>
        /// Arbitrarily deviates ray direction by a given <paramref name="angleX"/> and <paramref name="angleY"/>, taking into account the <paramref name="up"/> axis.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="angleX">Angle on which ray will be deflected by X axis.</param>
        /// <param name="angleY">Angle on which ray will be deflected by Y axis.</param>
        /// <param name="up">Up axis.</param>
        /// <returns>Deflected ray.</returns>
        public static Ray RandomDeflected(this Ray ray, float angleX, float angleY, Vector3 up) => RandomDeflected(ray, new Vector2(angleX, angleY), up);

        /// <summary>
        /// Arbitrarily deviates ray direction by a given <paramref name="angles"/>.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="angles">Angles on which ray will be deflected by X and Y axes.</param>
        /// <returns>Deflected ray.</returns>
        public static Ray RandomDeflected(this Ray ray, Vector2 angles) => RandomDeflected(ray, angles, Vector3.up);

        /// <summary>
        /// Arbitrarily deviates ray direction by a given <paramref name="angles"/>, taking into account the <paramref name="up"/> axis.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="angles">Angles on which ray will be deflected by X and Y axes.</param>
        /// <param name="up">Up axis.</param>
        /// <returns>Deflected ray.</returns>
        public static Ray RandomDeflected(this Ray ray, Vector2 angles, Vector3 up) => new Ray(ray.origin, ray.direction.RandomDeflected(angles, up));
    }
}