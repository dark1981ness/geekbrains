using System;
using System.Drawing;

namespace Asteroids.Objects
{
    class Bullet : BaseObject
    {
        Image image;
        public Bullet(PointF pos, PointF dir, Size size, Image image) : base(pos, dir, size)
        {
            this.image = image;
        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(image, new RectangleF(Pos.X, Pos.Y, Size.Width, Size.Height));
        }
        public override void Update()
        {
            Pos = new PointF(Pos.X + Dir.X, Pos.Y);
        }
    }
}
