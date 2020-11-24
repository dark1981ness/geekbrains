using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq;
using System.Collections.ObjectModel;
using System.Configuration;

namespace WpfCSLev2_ADO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        public MainWindow()
        {
            InitializeComponent();

            //this.DataContext = employeeViewModel;
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
                case "Employees":
                    DataRow dataRow = dataTable.NewRow();
                    AddEmployeeForm addEmployeeForm = new AddEmployeeForm(dataRow);
                    addEmployeeForm.ShowDialog();
                    if (addEmployeeForm.DialogResult.HasValue && addEmployeeForm.DialogResult.Value)
                    {
                        dataTable.Rows.Add(addEmployeeForm.Employee);
                        dataAdapter.Update(dataTable);
                    }
                    break;
                case "RemoveEmployees":
                    DataRowView dataRowView = (DataRowView)MainGrid.SelectedItem;
                    dataRowView.Row.Delete();
                    dataAdapter.Update(dataTable);
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestBase"].ConnectionString;
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter();

            // fill datatable
            string cmdText = @"SELECT id, surname, name, patronymic, birthday, salary, position,
            phone, email, department FROM employees";
            SqlCommand command = new SqlCommand(cmdText, connection);
            dataAdapter.SelectCommand = command;

            //insert
            string insertText = @"INSERT INTO employees (surname, name, patronymic, birthday, salary, position,
            phone, email, department) VALUES (@surname, @name, @patronymic, @birthday, @salary, @position,
            @phone, @email, @department); SET @id = @@IDENTITY;";
            command = new SqlCommand(insertText, connection);
            command.Parameters.Add("@surname", SqlDbType.NVarChar, 50, "surname");
            command.Parameters.Add("@name", SqlDbType.NVarChar, 50, "name");
            command.Parameters.Add("@patronymic", SqlDbType.NVarChar, 50, "patronymic");
            command.Parameters.Add("@birthday", SqlDbType.Date, 0, "birthday");
            command.Parameters.Add("@salary", SqlDbType.Float, 0, "salary");
            command.Parameters.Add("@position", SqlDbType.NVarChar, 50, "position");
            command.Parameters.Add("@phone", SqlDbType.NVarChar, 50, "phone");
            command.Parameters.Add("@email", SqlDbType.NVarChar, 50, "email");
            command.Parameters.Add("@department", SqlDbType.NVarChar, 50, "department");
            SqlParameter parameter = command.Parameters.Add("@id", SqlDbType.Int, 0, "id");
            parameter.Direction = ParameterDirection.Output;
            dataAdapter.InsertCommand = command;

            //update
            string updateText = @"UPDATE employees SET surname = @surname, name = @name, patronymic = @patronymic, birthday = @birthday,
            salary = @salary, position = @position,
            phone = @phone, email = @email, department = @department WHERE id = @id;";
            command = new SqlCommand(updateText, connection);
            command.Parameters.Add("@surname", SqlDbType.NVarChar, 50, "surname");
            command.Parameters.Add("@name", SqlDbType.NVarChar, 50, "name");
            command.Parameters.Add("@patronymic", SqlDbType.NVarChar, 50, "patronymic");
            command.Parameters.Add("@birthday", SqlDbType.Date, 0, "birthday");
            command.Parameters.Add("@salary", SqlDbType.Float, 0, "salary");
            command.Parameters.Add("@position", SqlDbType.NVarChar, 50, "position");
            command.Parameters.Add("@phone", SqlDbType.NVarChar, 50, "phone");
            command.Parameters.Add("@email", SqlDbType.NVarChar, 50, "email");
            command.Parameters.Add("@department", SqlDbType.NVarChar, 50, "department");
            parameter = command.Parameters.Add("@id", SqlDbType.Int, 0, "id");
            parameter.SourceVersion = DataRowVersion.Original;
            dataAdapter.UpdateCommand = command;

            //remove
            string removeText = @"DELETE FROM employees WHERE id = @id";
            command = new SqlCommand(removeText, connection);
            parameter = command.Parameters.Add("@id", SqlDbType.Int, 0, "id");
            parameter.SourceVersion = DataRowVersion.Original;
            dataAdapter.DeleteCommand = command;

            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            MainGrid.DataContext = dataTable.DefaultView;
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView rowView = (DataRowView)MainGrid.SelectedItem;
            rowView.BeginEdit();
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(rowView.Row);
            addEmployeeForm.ShowDialog();
            if (addEmployeeForm.DialogResult.HasValue && addEmployeeForm.DialogResult.Value)
            {
                rowView.EndEdit();
                dataAdapter.Update(dataTable);
            }
            else
            {
                rowView.CancelEdit();
            }
        }
    }
}
