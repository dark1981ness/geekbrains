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
    public partial class BnBGame : Form
    {
        TrueFalse gameDB;

        public int QuestionIndex { get; set; } = 0;
        public int DBIndex { get; set; }
        public int GameDBCount { get; set; }
        public bool UserAnswer { get; set; }
        public bool BaseAnswer { get; set; }
        public int RightAnswersCount { get; set; } = 0;
        public int WrongAnswersCount { get; set; } = 0;

        public BnBGame()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            QuestionIndex++;
            panel1.Visible = true;
            btnStartGame.Visible = false;
            LoadGameBase();
            GameDBCount = gameDB.Count;
            GetQuestion();
        }

        private void LoadGameBase()
        {
            gameDB = new TrueFalse("myDB");
            gameDB.Load();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            UserAnswer = true;
            CheckAnswer(UserAnswer, BaseAnswer);
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            UserAnswer = false;
            CheckAnswer(UserAnswer,BaseAnswer);
        }

        private void CheckAnswer(bool userValue, bool baseValue)
        {
            if (gameDB.Count > 0)
            {
                QuestionIndex++;
                GetQuestion();
                CompareAnswers(userValue, baseValue);
            }
            else if (gameDB.Count == 0)
            {
                CompareAnswers(userValue, baseValue);
                btnFalse.Enabled = false;
                btnTrue.Enabled = false;
                ShowMessage();
            }
        }

        private void GetQuestion()
        {
            
            Random random = new Random();
            DBIndex = random.Next(0, gameDB.Count);
            label2.Text = $"{QuestionIndex} из {GameDBCount}";
            textBoxQuestion.Text = gameDB[DBIndex].text;
            BaseAnswer = gameDB[DBIndex].trueFalse;
            gameDB.Remove(DBIndex);
        }

        private void CompareAnswers(bool userValue, bool baseValue)
        {
            if (userValue == baseValue)
            {
                RightAnswersCount++;
                lblTrueCount.Text = RightAnswersCount.ToString();
                lblCompareResult.ForeColor = Color.Green;
                lblCompareResult.Text = "V";
            }
            else
            {
                WrongAnswersCount++;
                lblFalseCount.Text = WrongAnswersCount.ToString();
                lblCompareResult.ForeColor = Color.Red;
                lblCompareResult.Text = "X";
            }
        }

        private void ShowMessage()
        {
            Form myMessageBox = new MyMessageBox();
            Panel msgPanel = (Panel)myMessageBox.Controls.Find("pnlMain", true).FirstOrDefault();
            lblTrueAnswerCount.Text = $"Количество верных ответов:";
            lblTrueAnswerCount.Location = new Point(76, 108);
            lblFalseAnswerCount.Text = $"Количество неверных ответов:";
            lblFalseAnswerCount.Location = new Point(76, 145);
            lblTrueCount.Text = $"{RightAnswersCount}";
            lblTrueCount.Location = new Point(351, 108);
            lblFalseCount.Text = $"{WrongAnswersCount}";
            lblFalseCount.Location = new Point(351, 145);
            Label lblH = new Label();
            lblH.Text = lblHeader.Text;
            lblH.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblH.Location = new Point(192, 3);
            lblH.Size = new Size(151, 20);
            Label gameOver = new Label();
            gameOver.Text = $"!!!ИГРА ЗАКОНЧЕНА!!!";
            gameOver.Location = new Point(180, 36);
            gameOver.Size = new Size(180, 20);
            gameOver.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            msgPanel.Controls.Add(lblTrueAnswerCount);
            msgPanel.Controls.Add(lblTrueCount);
            msgPanel.Controls.Add(lblFalseAnswerCount);
            msgPanel.Controls.Add(lblFalseCount);
            msgPanel.Controls.Add(lblH);
            msgPanel.Controls.Add(gameOver);
            myMessageBox.Show();
        }

        
    }
}
