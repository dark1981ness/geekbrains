using System;
using System.Drawing;

namespace Asteroids.Objects
{
    class AidPack : BaseObject
    {
        Image image;
        public AidPack(PointF pos, PointF dir, Size size, Image image) : base(pos, dir, size)
        {
            this.image = image;
        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(image, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        /// <summary>
        /// Переопределенный абстрактный метод родителя
        /// </summary>
        public override void Update()
        {
            Pos = new PointF(Pos.X - Dir.X, Pos.Y);
            if (Pos.X < 0) Pos = new PointF(Game.Width, new Random().Next(50, Game.Height));
        }
    }
}
