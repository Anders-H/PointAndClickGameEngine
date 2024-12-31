using PointAndClickEngine.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PointAndClickEngine
{
    public class MainWindowController
    {
        private readonly Form _owner;
        private readonly PictureBox _pictureBox;
        public int ActualWidth { get; }
        public int ActualHeight { get; }
        public int ZoomFactor { get; internal set; }
        public int PhysicalWidth { get; internal set; }
        public int PhysicalHeight { get; internal set; }
        public Scene CurrentScene { get; set; }

        public MainWindowController(Form owner, int actualWidth, int actualHeight)
        {
            ActualWidth = actualWidth;
            ActualHeight = actualHeight;
            _owner = owner;
            _owner.Paint += DoBackgroundPaint;
            _owner.BackgroundImage = (Bitmap)Resources.ResourceManager.GetObject("zinktexture");
            _owner.BackgroundImageLayout = ImageLayout.Tile;
            _owner.Shown += OwnerShown;
            _owner.Resize += OwnerResize;
            _pictureBox = new PictureBox();
            _pictureBox.Paint += DoGameAreaPaint;
            _pictureBox.MouseClick += DoPlayFieldClick;
            _owner.Controls.Add(_pictureBox);
        }

        private void CheckSizes()
        {
            var clientWidth = _owner.ClientRectangle.Width;
            var clientHeight = _owner.ClientRectangle.Height;

            for (var i = 7; i > 0; i--)
            {
                if (ActualWidth * i > clientWidth || ActualHeight * i > clientHeight)
                    continue;

                ZoomFactor = i;
                PhysicalWidth = ActualWidth * i;
                PhysicalHeight = ActualHeight * i;
                break;
            }

            _pictureBox.Width = PhysicalWidth;
            _pictureBox.Height = PhysicalHeight;
            _pictureBox.Left = (clientWidth / 2) - (PhysicalWidth / 2);
            _pictureBox.Top = (clientHeight / 2) - (PhysicalHeight / 2);
        }

        private void OwnerShown(object sender, EventArgs e)
        {
            CheckSizes();
            _owner.Invalidate();
            _pictureBox.Invalidate();
        }

        private void OwnerResize(object sender, EventArgs e)
        {
            CheckSizes();
            _owner.Invalidate();
            _pictureBox.Invalidate();
        }

        private void DoBackgroundPaint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            using (var pen1 = new Pen(Color.FromArgb(200, 0, 0, 0)))
            {
                using (var pen2 = new Pen(Color.FromArgb(70, 0, 0, 0)))
                {
                    using (var pen3 = new Pen(Color.FromArgb(20, 0, 0, 0)))
                    {
                        g.DrawRectangle(pen1, _pictureBox.Left - 1, _pictureBox.Top - 1, _pictureBox.Width + 1, _pictureBox.Height + 1);
                        g.DrawRectangle(pen2, _pictureBox.Left - 2, _pictureBox.Top - 2, _pictureBox.Width + 3, _pictureBox.Height + 3);
                        g.DrawRectangle(pen3, _pictureBox.Left - 3, _pictureBox.Top - 3, _pictureBox.Width + 5, _pictureBox.Height + 5);
                    }
                }
            }
        }

        private void DoPlayFieldClick(object sender, MouseEventArgs e)
        {
            var x = e.X;
            var y = e.Y;

            if (ZoomFactor > 1)
            {
                x = x / ZoomFactor;
                y = y / ZoomFactor;
            }

            if (CurrentScene != null)
                CurrentScene.Click(x, y);

            _pictureBox.Invalidate();
        }

        private void DoGameAreaPaint(object sender, PaintEventArgs e)
        {
            if (CurrentScene != null)
                CurrentScene.Paint(e.Graphics, ZoomFactor, ActualWidth, ActualHeight, PhysicalWidth, PhysicalHeight);
        }
    }
}