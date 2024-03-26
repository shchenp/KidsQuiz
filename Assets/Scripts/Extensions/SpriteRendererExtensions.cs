using UnityEngine;

namespace Extensions
{
    public static class SpriteRendererExtensions
    {
        public static void SetRandomColor(this SpriteRenderer spriteRenderer)
        {
            var color = Random.ColorHSV(0, 1, 0.5f, 0.5f, 1, 1, 1, 1);

            spriteRenderer.color = color;
        }
    }
}