using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Less7Ex1
{
    public partial class CsvToXml : Form
    {
        string fileName;
        List<Student> list;

        public string SourceFileName
        {
            get { return fileName; }
            set { fileName = value; }
        }


        public CsvToXml()
        {
            InitializeComponent();
        }

        public void LoadCsv()
        {
            StreamReader streamReader = new StreamReader(SourceFileName);
            list = new List<Student>();
            while (!streamReader.EndOfStream)
            {
                try
                {
                    string[] s = streamReader.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                }
                catch (Exception e)
                {
                    
                }
            }
            streamReader.Close();
        }

        public void SaveXml()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        private void btnOpenCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SourceFileName = openFileDialog.FileName;
                LoadCsv();
            }
            lblPathToCsv.Text = SourceFileName.Split('\\').LastOrDefault();
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SourceFileName = saveFileDialog.FileName;
                SaveXml();
            }
            lblPathToXml.Text = SourceFileName.Split('\\').LastOrDefault();
            lblResult.Text = $"«готово»";
        }
    }
}
