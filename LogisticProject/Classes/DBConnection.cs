using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LogisticProject.Classes;

namespace LogisticProject.Classes
{
    class DBConnection
    {

        private readonly static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Clients.mdf;Integrated Security=True";
        private static SqlConnection sqlConnection = new SqlConnection(stringConnection);
        private static SqlDataReader sqlDataReader;

        public static void UpdateClientData(string Login, string Password, string Firstname, string Secondname, string Thirdname, string Money)
        {
            double dMoney = Convert.ToDouble(Money);
            string queryUpdateClientData = $"UPDATE Clients SET client_password = N'{Password}', client_firstname = N'{Firstname}', client_secondname = N'{Secondname}'," +
                $"client_thirdname = N'{Thirdname}', client_money = '{dMoney}' WHERE client_login = '{Login}'";

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

        public static void GetClientData(string Login, string Password)
        {

            string queryGetClientData = $"SELECT * FROM Clients WHERE client_login = '{Login}' AND client_password = '{Password}'";

            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

            try
            {
                sqlConnection.Open();
                SqlCommand commGetClientData = new SqlCommand(queryGetClientData, sqlConnection);
                sqlDataReader = commGetClientData.ExecuteReader();

                if(sqlDataReader.HasRows)
                {
                    while(sqlDataReader.Read())
                    {
                        Client.ClientLogin = sqlDataReader[0].ToString();
                        Client.ClientPassword = sqlDataReader[1].ToString();
                        Client.ClientEmail = sqlDataReader[2].ToString();
                        Client.ClientFirsname = sqlDataReader[3].ToString();
                        Client.ClientSecondname = sqlDataReader[4].ToString();
                        Client.ClientThirdname = sqlDataReader[5].ToString();
                        Client.ClientMoney = Convert.ToDouble(sqlDataReader[6].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует в системе!");
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
