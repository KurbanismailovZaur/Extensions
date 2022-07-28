using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Redcode.Extensions
{
    public static class RenderTextureExtensions
    {
        /// <summary>
        /// Create texture and write <paramref name="renderTexture"/> to it.
        /// </summary>
        /// <param name="renderTexture">The render texture.</param>
        /// <returns>Created texture.</returns>
        public static Texture2D ToTexture2D(this RenderTexture renderTexture, TextureFormat format)
        {
            var texture = new Texture2D(renderTexture.width, renderTexture.height, format, false);
            renderTexture.WriteToTexture2D(texture);

            return texture;
        }

        /// <summary>
        /// Write <paramref name="renderTexture"/> to <paramref name="texture"/>.
        /// </summary>
        /// <param name="renderTexture">The render texture.</param>
        /// <param name="texture">Texture to write render texture.</param>
        public static void WriteToTexture2D(this RenderTexture renderTexture, Texture2D texture)
        {
            var oldRenderTexture = RenderTexture.active;
            RenderTexture.active = renderTexture;

            texture.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
            texture.Apply();

            RenderTexture.active = oldRenderTexture;
        }

        /// <summary>
        /// Create sprite and write <paramref name="renderTexture"/> to it.
        /// </summary>
        /// <param name="renderTexture">The render texture.</param>
        /// <returns>Created sprite.</returns>
        public static Sprite ToSprite(this RenderTexture renderTexture, TextureFormat format)
        {
            var texture = renderTexture.ToTexture2D(format);
            return Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        }

        /// <summary>
        /// Write <paramref name="renderTexture"/> to <paramref name="sprite"/>.
        /// </summary>
        /// <param name="renderTexture">The render texture.</param>
        /// <param name="sprite">Sprite to write render texture.</param>
        public static void WriteToSprite(this RenderTexture renderTexture, Sprite sprite)
        {
            renderTexture.WriteToTexture2D(sprite.texture);
        }
    }
}