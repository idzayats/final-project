using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LogisticProject.Classes
{
    class DBConnection
    {

        readonly static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Clients.mdf;Integrated Security=True";
        static SqlConnection sqlConnection = new SqlConnection(stringConnection);

        public static void UpdateClientData(string Login, string Password, string Firstname, string Secondname, string Thirdname, double Money)
        {

            string queryUpdateClientData = "";

            if(sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

            try
            {
                sqlConnection.Open();
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
