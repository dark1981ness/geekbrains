using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;


namespace WpfCSLev2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmployeeViewModel employeeViewModel = new EmployeeViewModel();
        public MainWindow()
        {
            InitializeComponent();
            
            this.DataContext = employeeViewModel;
        }

        #region window title bar
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

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #endregion

        #region slide menu
        private void CloseMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenMenuBtn.Visibility = Visibility.Visible;
            CloseMenuBtn.Visibility = Visibility.Collapsed;
        }

        private void OpenMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenMenuBtn.Visibility = Visibility.Collapsed;
            CloseMenuBtn.Visibility = Visibility.Visible;
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            switch (item.Name)
            {
                case "Home":
                    AddDepartmentForm addDepartmentForm = new AddDepartmentForm();
                    addDepartmentForm.depListView.ItemsSource = employeeViewModel.GetDepartment;
                    addDepartmentForm.AddDepData += (s, ev) => employeeViewModel.GetDepartment.Add(new Department { Id = ev.Id, Name = ev.Name });
                    addDepartmentForm.Show();
                    
                    break;
                case "Employees":
                    AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
                    addEmployeeForm.ShowDialog();
                    if (addEmployeeForm.DialogResult.HasValue && addEmployeeForm.DialogResult.Value)
                    {
                        employeeViewModel.GetEmployee.Add(addEmployeeForm.Employee);
                    }
                    break;
                case "Logout":
                    Application.Current.Shutdown();
                    break;
            }
        }

        #endregion

        private void MainCC_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollViewer = (ScrollViewer)sender;
            scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        private void employeeView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
