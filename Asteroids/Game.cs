using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Asteroids.Objects;

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
        static public Image background = Image.FromFile("..\\..\\images\\background.jpg");
        static public Image starImage = Image.FromFile("..\\..\\images\\star_new.png");
        static public Image asteroidImage = Image.FromFile("..\\..\\images\\asteroid_new.png");
        static Timer timer = new Timer();
        static BaseObject[] _objs;

        static Game()
        {

        }
        static public void Init(Form form)
        {
            Graphics g;
            context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            Buffer = context.Allocate(g, new Rectangle(0, 0, Width, Height));
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
            Load();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Update();
            Draw();
        }

        static public void Load()
        {
            Random random = new Random();
            _objs = new BaseObject[30];
            for (int i = 0; i < _objs.Length - 25; i++)
            {
                int y = random.Next(50, (Height - 60));
                _objs[i] = new Asteroid(new Point(600, y), new Point(15 - i, 15 - i), new Size(100, 100), asteroidImage);
            }
            for (int i = 5; i < _objs.Length; i++)
            {
                int y = random.Next(50, (Height - 60));
                _objs[i] = new Star(new Point(600, y), new Point(-i, 0), new Size(50, 50), starImage);
            }
        }

        static public void Draw()
        {
            Buffer.Graphics.DrawImage(background, 0, 0, Width, Height);
            foreach (BaseObject obj in _objs)
            {
                obj.Draw();
            }
            Buffer.Render();
        }

        static public void Update()
        {
            foreach (BaseObject obj in _objs)
            {
                obj.Update();
            }
        }
    }
}
