using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LogisticProject.Classes
{
    class DBConnection
    {

        readonly static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Clients.mdf;Integrated Security=True";
        static SqlConnection sqlConnection = new SqlConnection(stringConnection);

        public static void UpdateClientData(string Login, string Password, string Firstname, string Secondname, string Thirdname, string Money)
        {
            double dMoney = Convert.ToDouble(Money);
            string queryUpdateClientData = $"UPDATE Clients SET client_password = N'{Password}', client_firstname = N'{Firstname}', client_secondname = N'{Secondname}'," +
                $"client_thirdname = N'{Thirdname}', client_money = '{dMoney}'";

            if(sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

            try
            {
                sqlConnection.Open();
                SqlCommand commUpdateClientData = new SqlCommand(queryUpdateClientData, sqlConnection);
                commUpdateClientData.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
