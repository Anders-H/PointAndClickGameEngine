using System;
using System.Drawing;
using System.Resources;
using PointAndClickEngine.Properties;

namespace PointAndClickEngine
{
    public class Sprite
    {
        private static ResourceManager _resourceManager;
        public Bitmap Bitmap { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        static Sprite()
        {
            _resourceManager = Resources.ResourceManager;
        }

        public static void SetResourceManager(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }

        public static void ResetResourceManager()
        {
            _resourceManager = Resources.ResourceManager;
        }

        public static Sprite LoadFromResources(string resourceName)
        {
            var sprite = new Sprite();
            sprite.Bitmap = (Bitmap)_resourceManager.GetObject(resourceName);
            
            if (sprite.Bitmap == null)
                throw new SystemException("Bitmap is null.");

            sprite.Width = sprite.Bitmap.Width;
            sprite.Height = sprite.Bitmap.Height;
            return sprite;
        }

        public static Sprite LoadFromBitmap(Bitmap bitmap)
        {
            var sprite = new Sprite();
            sprite.Bitmap = bitmap;

            if (sprite.Bitmap == null)
                throw new SystemException("Bitmap is null.");

            sprite.Width = sprite.Bitmap.Width;
            sprite.Height = sprite.Bitmap.Height;
            return sprite;
        }
    }
}