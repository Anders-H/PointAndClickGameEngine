using System.Drawing;
using PointAndClickEngine;

namespace TestGame.Scenes
{
    public class ButtonScene : Scene
    {
        public ButtonScene()
        {
            var bitmap = new Bitmap(100, 30);

            using (var g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.DarkSlateBlue);
                g.DrawRectangle(Pens.White, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
            }

            var sprite = Sprite.LoadFromBitmap(bitmap);
            var button1 = new Button(sprite, "Button 1");
            var button2 = new Button(sprite, "Button 2");
            
            var button3 = new Button(sprite, "Button 3")
            {
                Enabled = false
            };

            Buttons.Add(button1);
            Buttons.Add(button2);
            Buttons.Add(button3);
        }
    }
}