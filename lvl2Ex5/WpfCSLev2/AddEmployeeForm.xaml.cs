using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfCSLev2
{
    /// <summary>
    /// Interaction logic for AddEmployeeForm.xaml
    /// </summary>
    public partial class AddEmployeeForm : Window
    {
        public Employee Employee { get; set; }
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void OnDragMoveWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2 && this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if (e.ClickCount == 2 && this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_OK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Employee = new Employee(Convert.ToInt32(uId.Text), uName.Text, uSurname.Text, uPatr.Text, Convert.ToDateTime(uBithday.Text), Convert.ToByte(uAge.Text), Convert.ToSingle(uSalary.Text), uPos.Text, uPhone.Text, uEmail.Text);
                this.DialogResult = true;
            }
            catch (Exception)
            {

                this.DialogResult = false;
            }
            Close();
        }

        private void Button_Cancek_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
