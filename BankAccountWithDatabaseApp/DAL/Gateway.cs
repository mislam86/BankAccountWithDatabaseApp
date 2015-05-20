using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountWithDatabaseApp.Model;

namespace BankAccountWithDatabaseApp.DAL
{
    class Gateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionDb"].ConnectionString;

        public int Save(Account anAccount)
        {
            string query = "INSERT INTO tbl_account_info VALUES ('" + anAccount.CustomerName + "', '" + anAccount.AccountNumber + "', '" + anAccount.Email + "', '" + anAccount.OpeningDate + "', '" + anAccount.Balance + "')";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
    }
}
