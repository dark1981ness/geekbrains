using System;
using System.Windows;
using System.Windows.Input;

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
                Employee = new Employee
                {
                    DepartmentId = Convert.ToInt32(this.uId.Text),
                    Name = this.uName.Text,
                    Surname = this.uSurname.Text,
                    Patronymic = this.uPatr.Text,
                    Birthday = Convert.ToDateTime(this.uBithday.Text),
                    Age = Convert.ToByte(this.uAge.Text),
                    Salary = Convert.ToSingle(this.uSalary.Text),
                    Position = this.uPos.Text,
                    Phone = this.uPhone.Text,
                    Email = this.uEmail.Text
                };
                this.DialogResult = true;
            }
            catch (Exception)
            {
                this.DialogResult = false;
            }
            this.Close();
        }

        private void Button_Cancek_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
