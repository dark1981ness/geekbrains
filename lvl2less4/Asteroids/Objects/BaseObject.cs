using Asteroids.Interfaces;
using System.Drawing;

namespace Asteroids.Objects
{
    public delegate void Message();
    abstract class BaseObject : ICollision
    {
        PointF _pos, _dir;
        Size _size;

        protected PointF Pos
        {
            get => _pos;
            set => _pos = value;
        }

        protected PointF Dir
        {
            get => _dir;
            set => _dir = value;
        }

        protected Size Size
        {
            get => _size;
            set => _size = value;
        }

        public RectangleF Rect => new RectangleF(_pos, _size);

        public BaseObject()
        {

        }
        public BaseObject(PointF pos, PointF dir, Size size)
        {
            _pos = pos;
            _dir = dir;
            _size = size;
        }

        public abstract void Draw();
       
        /// <summary>
        /// Обновление позиции объекта на игровом поле
        /// </summary>
        public abstract void Update();

        public bool Collision(ICollision obj) => obj.Rect.IntersectsWith(this.Rect);
    }
}
