using System.Drawing;

namespace Asteroids.Objects
{
    class Star : BaseObject
    {
        Image image;
        public Star(Point pos, Point dir, Size size, Image image) : base(pos, dir, size)
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
            Pos = new Point(Pos.X - Dir.X, Pos.Y);
            if (Pos.X < 0) Pos = new Point(Game.Width, Pos.Y);
        }
    }
}
