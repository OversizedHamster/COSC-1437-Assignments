using System.Data;
using Microsoft.Data.SqlClient;

//Ethan Smith

namespace DatabaseAccess
{
    public class ConventionalAdo
    {
        public DataTable RunQueryTable(string sqlConnectionString, string dataTableQueryString)
        {
            DataTable dataTable;

            using (var sqlConnection = new SqlConnection(sqlConnectionString))
            {
                sqlConnection.Open();
                using (var sqlDataAdapter = new SqlDataAdapter(dataTableQueryString, sqlConnectionString))
                {
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    }
}
