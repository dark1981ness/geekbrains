using System;
using System.Drawing;
using System.Windows.Forms;
using Asteroids.Objects;
using Asteroids.Properties;
using System.Collections.Generic;

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
        static List<Asteroid> _asteroids;
        static int _asteroidColCount;
        static AidPack[] _aidPacks;
        static Asteroid _destrCount;
        static List<Bullet> _bullets = new List<Bullet>();
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
            if (e.KeyCode == Keys.Space) _bullets.Add(new Bullet(new PointF(_ship.Rect.X + 10, _ship.Rect.Y + 4), new PointF(40, 0), new Size(40, 40), Resources.bullet));
            if (e.KeyCode == Keys.Up) _ship.Up();
            if (e.KeyCode == Keys.Down) _ship.Down();
            if (e.KeyCode == Keys.Left) _ship.Left();
            if (e.KeyCode == Keys.Right) _ship.Right();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Update();
            Draw();
        }

        public static void Load()
        {
            _asteroidColCount = Random.Next(5, 15);
            _destrCount = new Asteroid();
            _aidPacks = new AidPack[3];
            _objs = new BaseObject[30];
            _asteroids = new List<Asteroid>();
            _ship = new Ship(new PointF(10, 400), new PointF(10, 10), new Size(72, 50), Resources.starship);
            AddAsteroid(_asteroidColCount);
            for (int i = 0; i < _objs.Length; i++)
            {
                _objs[i] = new Star(new PointF(Width, Random.Next(50, (Height - 60))), new PointF(i, 0), new Size(50, 50), Resources.star_new);
            }
            for (int i = 0; i < _aidPacks.Length; i++)
            {
                _aidPacks[i] = new AidPack(new PointF(Width, Random.Next(50, (Height - 60))), new PointF(10 - i, 0), new Size(30, 30), Resources.firstaidpack);
            }
        }

        public static void Draw()
        {
            Buffer.Graphics.DrawImage(Resources.background, 0, 0, Width, Height);

            foreach (BaseObject obj in _objs) obj.Draw();

            foreach (Asteroid asteroid in _asteroids) asteroid?.Draw();

            foreach (AidPack pack in _aidPacks) pack?.Draw();

            foreach (Bullet bullet in _bullets) bullet?.Draw();

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
            foreach (Bullet bullet in _bullets) bullet?.Update();
            if (_asteroids.Count == 0)
            {
                _asteroidColCount = Random.Next(5, 20);
                AddAsteroid(_asteroidColCount);
            }
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
                    _aidPacks[i] = new AidPack(new PointF(Width, Random.Next(50, (Height - 60))), new PointF(10 - i, 0), new Size(30, 30), Resources.firstaidpack); ;
                    if (_ship.Energy > 100) _ship.Energy = 100;
                }
            }
        }

        private static void AsteroidCollision()
        {
            for (int i = 0; i < _asteroids.Count; i++)
            {
                if (_asteroids[i] == null) continue;
                _asteroids[i].Update();

                for (int j = 0; j < _bullets.Count; j++)
                {
                    if (_bullets[j] != null && _bullets[j].Collision(_asteroids[i]))
                    {
                        _asteroids.RemoveAt(i);
                        _destrCount.AsteroidDestrCount();
                        _bullets.RemoveAt(j);
                        if (i > 0) i--;
                        if (j > 0) j--;
                        break;
                    }
                }

                if (_asteroids.Count != 0)
                {
                    if (_ship.Collision(_asteroids[i]))
                    {
                        var rnd = new Random();
                        _ship?.EnergyLow(rnd.Next(1, 10));
                    }
                }

                if (_ship.Energy <= 0) _ship?.Die();
            }
        }

        private static void AddAsteroid(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _asteroids.Add(new Asteroid(new PointF(Width, Random.Next(50, (Height - 60))), new PointF(15 - i, 15 - i), new Size(100, 100), Resources.asteroid_new));
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
