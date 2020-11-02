using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Asteroids.Objects;
using Asteroids.Properties;

namespace Asteroids
{
    static class Game
    {
        static public ulong Counter { get; private set; } = 0;
        static BufferedGraphicsContext context;
        static public BufferedGraphics Buffer { get; private set; }
        static public Random Random { get; } = new Random();
        static public int Width { get; private set; }
        static public int Height { get; private set; }
        static Timer timer = new Timer();
        static BaseObject[] _objs;
        static Asteroid[] _asteroids;
        static AidPack[] _aidPacks;
        static Asteroid _destrCount;
        static Bullet _bullet;
        static Ship _ship;

        static Game()
        {

        }
        public static void Init(Form form)
        {
            Ship.MessageDie += Finish;
            Graphics g;
            context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;

            if (Width > 1000 || Width < 0)
            {
                throw new ArgumentOutOfRangeException("Width", "OutOfScreenRange");

            }
            else if (Height > 1000 || Height < 0)
            {
                throw new ArgumentOutOfRangeException("Height", "OutOfScreenRange");
            }
            form.KeyDown += Form_KeyDown;
            Buffer = context.Allocate(g, new Rectangle(0, 0, Width, Height));
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
            Load();

        }

        private static void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) _bullet = new Bullet(new Point(_ship.Rect.X + 10, _ship.Rect.Y + 4), new Point(40, 0), new Size(40, 40), Resources.bullet);
            if (e.KeyCode == Keys.Up) _ship.Up();
            if (e.KeyCode == Keys.Down) _ship.Down();
            if (e.KeyCode == Keys.Left) _ship.Left();
            if (e.KeyCode == Keys.Right) _ship.Right();
            if (e.KeyCode == Keys.Up && e.KeyCode == Keys.Right) _ship.FromTest();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Update();
            Draw();
        }

        public static void Load()
        {
            Random random = new Random();
            _destrCount = new Asteroid();
            _aidPacks = new AidPack[3];
            _objs = new BaseObject[30];
            _asteroids = new Asteroid[5];
            _ship = new Ship(new Point(10, 400), new Point(5, 5), new Size(72, 50), Resources.starship);
            for (int i = 0; i < _asteroids.Length; i++)
            {
                _asteroids[i] = new Asteroid(new Point(Width, Random.Next(50, (Height - 60))), new Point(15 - i, 15 - i), new Size(100, 100), Resources.asteroid_new);

            }
            for (int i = 0; i < _objs.Length; i++)
            {
                _objs[i] = new Star(new Point(Width, Random.Next(50, (Height - 60))), new Point(i, 0), new Size(50, 50), Resources.star_new);
            }
            for (int i = 0; i < _aidPacks.Length; i++)
            {
                _aidPacks[i] = new AidPack(new Point(Width, Random.Next(50, (Height - 60))), new Point(10 - i, 0), new Size(30, 30), Resources.firstaidpack);
            }
        }

        public static void Draw()
        {
            Buffer.Graphics.DrawImage(Resources.background, 0, 0, Width, Height);
            foreach (BaseObject obj in _objs)
            {
                obj.Draw();
            }
            foreach (Asteroid asteroid in _asteroids)
            {
                asteroid?.Draw();
            }
            foreach (AidPack pack in _aidPacks)
            {
                pack?.Draw();
            }
            _bullet?.Draw();
            _ship?.Draw();
            if (_ship != null)
            {
                Buffer.Graphics.DrawString("Energy:" + _ship.Energy, SystemFonts.DefaultFont, Brushes.White, 0, 0);
                Buffer.Graphics.DrawString("destroyed asteroids:" + _destrCount.DestrCount, SystemFonts.DefaultFont, Brushes.White, 100, 0);
            }

            Buffer.Render();
        }

        public static void Update()
        {
            foreach (BaseObject obj in _objs) obj.Update();
            foreach (AidPack pack in _aidPacks) pack.Update();
            _bullet?.Update();
            AsteroidCollision();
            AidPaksCollision();

        }

        private static void AidPaksCollision()
        {
            for (int i = 0; i < _aidPacks.Length; i++)
            {
                if (_ship.Collision(_aidPacks[i]))
                {
                    _ship.AidPack(20);
                    _aidPacks[i] = new AidPack(new Point(Width, Random.Next(50, (Height - 60))), new Point(10 - i, 0), new Size(30, 30), Resources.firstaidpack); ;
                    if (_ship.Energy > 100) _ship.Energy = 100;
                }
            }
        }

        private static void AsteroidCollision()
        {
            for (int i = 0; i < _asteroids.Length; i++)
            {
                if (_asteroids[i] == null) continue;
                _asteroids[i].Update();
                if (_bullet != null && _bullet.Collision(_asteroids[i]))
                {
                    _asteroids[i] = new Asteroid(new Point(Width, Random.Next(0, Height)), new Point(15, 15), new Size(100, 100), Resources.asteroid_new);
                    _destrCount.AsteroidDestrCount();
                    _bullet = null;
                    continue;
                }
                if (!_ship.Collision(_asteroids[i]))
                {
                    continue;
                }
                else
                {
                    var rnd = new Random();
                    _ship?.EnergyLow(rnd.Next(1, 10));
                }

                if (_ship.Energy <= 0) _ship?.Die();
            }
        }

        public static void Finish()
        {
            timer.Stop();
            Buffer.Graphics.DrawString("The End", new Font(FontFamily.GenericSansSerif, 60, FontStyle.Underline), Brushes.Red, 200, 100);
            Buffer.Render();
        }

    }
}
