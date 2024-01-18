using UnityEngine;
using UnityEngine.UI;

namespace Codomaster.Extensions
{
    public static class CanvasScalerExtensions
    {
        /// <summary>
        /// Get scale factor which canvas scaler calculated when work in <see cref="CanvasScaler.ScaleMode.ScaleWithScreenSize"/> mode.
        /// </summary>
        /// <param name="scaler">The canvas scaler.</param>
        /// <returns>Calculated scale factor.</returns>
        public static float GetScaleFactor(this CanvasScaler scaler)
        {
            return Mathf.Lerp(Screen.width / scaler.referenceResolution.x, Screen.height / scaler.referenceResolution.y, scaler.matchWidthOrHeight);
        }
    }
}