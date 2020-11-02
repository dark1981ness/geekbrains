using Asteroids.Interfaces;
using System.Drawing;

namespace Asteroids.Objects
{
    public delegate void Message();
    abstract class BaseObject : ICollision
    {
        Point _pos, _dir;
        Size _size;

        protected Point Pos
        {
            get => _pos;
            set => _pos = value;
        }

        protected Point Dir
        {
            get => _dir;
            set => _dir = value;
        }

        protected Size Size
        {
            get => _size;
            set => _size = value;
        }

        public Rectangle Rect => new Rectangle(_pos, _size);

        public BaseObject()
        {

        }
        public BaseObject(Point pos, Point dir, Size size)
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
