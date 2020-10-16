using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Less7Ex1
{
    public partial class MainWindow : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            mainMenu.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void Doubler_Click(object sender, EventArgs e)
        {
            Form doubler = new Doubler(1, 100) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            CloseFormsInsidePanel(mainPanel);
            this.mainPanel.Controls.Add(doubler);
            doubler.Show();
        }

        private void GuessNumber_Click(object sender, EventArgs e)
        {
            Form guessNumbers = new GuessNumbers(5, 0, 100) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            CloseFormsInsidePanel(mainPanel);
            this.mainPanel.Controls.Add(guessNumbers);
            guessNumbers.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ДЗ к 7 уроку.\nВыполнил Носков Константин.");
        }

        /// <summary>
        /// Закрываем дочерние формы панели
        /// </summary>
        /// <param name="panel"></param>
        private void CloseFormsInsidePanel(Panel panel)
        {
            var fCount = panel.Controls;
            foreach (var item in fCount)
            {
                if (item is Form)
                {
                    Form newItem = item as Form;
                    newItem.Close();
                }
            }
        }

        #region DragMove метод, не очень удачный, скорее всего
        private void mainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void mainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void mainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Black;
        }
    }
}
