using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace PointAndClickEngine
{
    public abstract class Scene
    {
        public List<Sprite> Sprites { get; }

        public Scene()
        {
            Sprites = new List<Sprite>();
        }

        public void Paint(Graphics g, int zoomFactor, int actualWidth, int actualHeight, int physicalWidth, int physicalHeight)
        {
            g.CompositingQuality = CompositingQuality.HighSpeed;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.Clear(Color.FromArgb(60, 50, 40));

            foreach (var sprite in Sprites)
            {
                var x = sprite.X * zoomFactor;
                var y = sprite.Y * zoomFactor;
                var width = sprite.Width * zoomFactor;
                var height = sprite.Height * zoomFactor;
                g.DrawImage(sprite.Bitmap, x, y, width, height);
            }
        }

        public virtual void Click(int x, int y)
        {
        }
    }
}