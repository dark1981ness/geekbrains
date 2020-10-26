using System;
using System.Drawing;
using System.Windows.Forms;

namespace Asteroids.Objects
{
    class BaseObject
    {
        Point _pos, _dir;
        Size _size;
        Image _image;

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

        protected Image Image
        {
            get => _image;
            set => _image = value;
        }

        public BaseObject(Point pos, Point dir, Size size)
        {
            _pos = pos;
            _dir = dir;
            _size = size;
        }

        public virtual void Draw()
        {
            Game.Buffer.Graphics.DrawEllipse(Pens.White, _pos.X, _pos.Y, _size.Width, _size.Height);
        }

        public virtual void Update()
        {
            _pos.X = _pos.X + _dir.X;
            _pos.Y = _pos.Y + _dir.Y;
            if (_pos.X < 0) _dir.X = -_dir.X;
            if (_pos.X > Game.Width) _dir.X = -_dir.X;
            if (_pos.Y < 0) _dir.Y = -_dir.Y;
            if (_pos.Y > Game.Height) _dir.Y = -_dir.Y;
        }
    }
}
