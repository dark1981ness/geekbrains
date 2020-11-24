using System;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace WpfCSLev2_ADO
{
    /// <summary>
    /// Interaction logic for AddEmployeeForm.xaml
    /// </summary>
    public partial class AddEmployeeForm : Window
    {
        public DataRow Employee { get; set; }
        public AddEmployeeForm(DataRow dataRow)
        {
            InitializeComponent();
            Employee = dataRow;
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
            Close();
        }

        private void Button_OK_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Employee["department"] = uId.Text;
                Employee["name"] = uName.Text;
                Employee["surname"] = uSurname.Text;
                Employee["patronymic"] = uPatr.Text;
                Employee["birthday"] = Convert.ToDateTime(uBithday.Text);
                Employee["salary"] = Convert.ToSingle(uSalary.Text);
                Employee["position"] = uPos.Text;
                Employee["phone"] = uPhone.Text;
                Employee["email"] = uEmail.Text;

                DialogResult = true;
            }
            catch (Exception)
            {
                DialogResult = false;
            }
            Close();
        }

        private void Button_Cancek_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            uId.Text =  Employee["department"].ToString();
            uName.Text = Employee["name"].ToString();
            uSurname.Text = Employee["surname"].ToString();
            uPatr.Text = Employee["patronymic"].ToString();
            uBithday.Text = Employee["birthday"].ToString();
            uSalary.Text = Employee["salary"].ToString();
            uPos.Text = Employee["position"].ToString();
            uPhone.Text = Employee["phone"].ToString();
            uEmail.Text = Employee["email"].ToString();
        }
    }
}
