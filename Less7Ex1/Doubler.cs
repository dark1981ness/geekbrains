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
    public partial class Doubler : Form
    {
        private int counter = 0;

        public int EndPoint { get; private set; }

        public int StartPoint { get; private set; }

        public int MyRandomValue { get; private set; }

        Stack<int> userRes;

        Dictionary<string, Button> btnDic;

        public Doubler()
        {
            InitializeComponent();
            userRes = new Stack<int>();
            StartPoint = 1;
            EndPoint = 100;
        }

        public Doubler(int startPoint, int endPoint)
        {
            InitializeComponent();
            userRes = new Stack<int>();
            StartPoint = startPoint;
            EndPoint = endPoint;
            btnDic = PutButtonsToDic(panel2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblUserResult.Text = (int.Parse(lblUserResult.Text) + 1).ToString();
            counter++;
            lblUserStepCount.Text = counter.ToString();
            userRes.Push(int.Parse(lblUserResult.Text));
            CheckResult();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            lblUserResult.Text = (int.Parse(lblUserResult.Text) * 2).ToString();
            counter++;
            lblUserStepCount.Text = counter.ToString();
            userRes.Push(int.Parse(lblUserResult.Text));
            CheckResult();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblUserResult.Text = "0";
            counter = 0;
            lblUserStepCount.Text = counter.ToString();
            btnDic["btnAdd"].Enabled = true;
            btnDic["btnMulti"].Enabled = true;
            btnDic["btnUndo"].Enabled = true;
            userRes.Clear();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            MyRandomValue = RandomValue(StartPoint, EndPoint);
            lblForRandomNum.Text = MyRandomValue.ToString();
            userRes.Clear();
            btnDic["btnStartGame"].Enabled = false;
            btnDic["btnNewGame"].Enabled = true;
            btnDic["btnAdd"].Enabled = true;
            btnDic["btnMulti"].Enabled = true;
            btnDic["btnClear"].Enabled = true;
            btnDic["btnUndo"].Enabled = true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblUserResult.Text = "0";
            lblUserStepCount.Text = "0";
            lblForRandomNum.Text = "0";
            lblMinCount.Text = "?";
            btnDic["btnStartGame"].Enabled = true;
            btnDic["btnNewGame"].Enabled = false;
            btnDic["btnAdd"].Enabled = false;
            btnDic["btnMulti"].Enabled = false;
            btnDic["btnClear"].Enabled = false;
            btnDic["btnUndo"].Enabled = false;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if(userRes.Count != 0)
            {
                userRes.Pop();
                counter--;
                lblUserResult.Text = userRes.Peek().ToString();
                lblUserStepCount.Text = counter.ToString();
                CheckResult();
            }
            
        }

        /// <summary>
        /// сравнение получаемого значения с сгенерированным
        /// </summary>
        private void CheckResult()
        {
            if (int.Parse(lblUserResult.Text) > int.Parse(lblForRandomNum.Text))
            {
                btnDic["btnAdd"].Enabled = false;
                btnDic["btnMulti"].Enabled = false;
                lblMinCount.Text = TryCount(MyRandomValue).ToString();
            }
            else if (int.Parse(lblUserResult.Text) == int.Parse(lblForRandomNum.Text))
            {
                btnDic["btnAdd"].Enabled = false;
                btnDic["btnMulti"].Enabled = false;
                btnDic["btnUndo"].Enabled = false;
                lblMinCount.Text = TryCount(MyRandomValue).ToString();
            }
            else if(int.Parse(lblUserResult.Text)*2 > int.Parse(lblForRandomNum.Text))
            {
                btnDic["btnMulti"].Enabled = false;
            }
            else if (int.Parse(lblUserResult.Text) < int.Parse(lblForRandomNum.Text))
            {
                btnDic["btnAdd"].Enabled = true;
                btnDic["btnMulti"].Enabled = true;
            }
        }

        /// <summary>
        /// генерация случайного числа в заланном диапазоне
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="endPoint"></param>
        /// <returns></returns>
        private int RandomValue(int startPoint, int endPoint)
        {
            Random random = new Random();
            return random.Next(startPoint, endPoint);
        }

        #region test

        /// <summary>
        /// Публикация кнопок, размещенных на Panel в словарь
        /// </summary>
        /// <param name="panel"></param>
        /// <returns></returns>
        private Dictionary<string, Button> PutButtonsToDic(Panel panel)
        {
            Dictionary<string, Button> dicOfButtons = new Dictionary<string, Button>();
            var fCount = panel.Controls;
            foreach (var item in fCount)
            {
                if (item is Button)
                {
                    Button newItem = item as Button;
                    dicOfButtons.Add(newItem.Name, newItem);
                }
            }
            return dicOfButtons;
        }

        #endregion

        /// <summary>
        /// Минимальное число попыток получения числа
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int TryCount(int value)
        {
            int count = 0;

            while(value > 0)
            {
                if (value % 2 == 0)
                {
                    count++;
                    value /= 2;
                }
                else if (value%2 != 0)
                {
                    count++;
                    value -= 1;
                }
            }

            return count;
        }
    }
}
