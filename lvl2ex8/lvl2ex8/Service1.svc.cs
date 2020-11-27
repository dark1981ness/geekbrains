using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace lvl2ex8
{
    public class Service1 : IService1
    {
        
        public DataSet GetSummary()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestBase"].ConnectionString;
            string sqlStoredProcedure = "Summary";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(sqlStoredProcedure, sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        public DataSet GetAllDepartments()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestBase"].ConnectionString;
            string sqlStoredProcedure = "sp_GetDepartments";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(sqlStoredProcedure, sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }
    }
}
