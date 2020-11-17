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
    /// Interaction logic for AddDepartmentForm.xaml
    /// </summary>
    public partial class AddDepartmentForm : Window
    {
        public AddDepartmentForm()
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
    }
}
