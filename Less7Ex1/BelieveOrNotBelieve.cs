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
    public partial class BelieveOrNotBelieve : Form
    {
        // База данных с вопросами
        TrueFalse database;

        public BelieveOrNotBelieve()
        {
            InitializeComponent();
        }

        private void BelieveOrNotBelieve_Load(object sender, EventArgs e)
        {
            toolStripBnB.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        //Обработчик пункта меню Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Обработчик пункта меню New
        private void btnNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }
        // Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            textBoxBnB.Text = database[(int)nudNumber.Value - 1].text;
            cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
        }

        // Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        // Обработчик кнопки Удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить вопрос?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (nudNumber.Maximum == 1 || database == null) return;
                database.Remove((int)nudNumber.Value);
                nudNumber.Maximum--;
                if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
            }
            
        }
        // Обработчик пункта меню Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите сохранить изменения?","Сохранить", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                if (database != null) database.Save();
                else MessageBox.Show("База данных не создана");
            }

        }
        // Обработчик пункта меню Open
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
                BnBdatabase.Text = database.FileName.Split('\\').LastOrDefault();
            }
        }
        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database[(int)nudNumber.Value - 1].text = textBoxBnB.Text;
                database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
            }
            else MessageBox.Show("База данных не создана");
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database.FileName = sfd.FileName;
                database.Save();
            };
        }
    }
}
