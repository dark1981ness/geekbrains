using System.Drawing;

namespace Asteroids.Objects
{
    class Asteroid : BaseObject
    {
        Image image;

        private int _destrCount = 0;
        public int DestrCount
        {
            get => _destrCount;
           
        }

        public Asteroid()
        {

        }
        public Asteroid(Point pos, Point dir, Size size, Image image) : base(pos, dir, size)
        {
            this.image = image;
        }


        public void AsteroidDestrCount()
        {
           _destrCount++;
        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(image, new Rectangle(Pos.X, Pos.Y, Size.Width, Size.Height));
        }

        /// <summary>
        /// Переопределенный абстрактный метод родителя
        /// </summary>
        public override void Update()
        {
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            Pos = new Point(Pos.X + Dir.X, Pos.Y + Dir.Y);
            if (Pos.X < 0) Dir = new Point(Dir.X * (-1), Dir.Y);
            if (Pos.X > Game.Width) Dir = new Point(Dir.X * (-1), Dir.Y);
            if (Pos.Y < 0) Dir = new Point(Dir.X, Dir.Y * (-1));
            if (Pos.Y > Game.Height) Dir = new Point(Dir.X, Dir.Y * (-1));
        }
    }
}
