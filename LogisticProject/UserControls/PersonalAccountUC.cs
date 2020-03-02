using System;
using LogisticProject.Classes;
using System.Windows.Forms;

namespace LogisticProject.UserControls
{
    public partial class PersonalAccountUC : UserControl
    {
        public PersonalAccountUC()
        {
            InitializeComponent();
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbxFirsname.Text) || string.IsNullOrEmpty(tbxMoney.Text) || string.IsNullOrEmpty(tbxPassword.Text) ||
                string.IsNullOrEmpty(tbxSecondname.Text) || string.IsNullOrEmpty(tbxThirdname.Text))
            {
                MessageBox.Show("Не все поля были заполнены!");
                lblLogin.Text = Client.ClientLogin;
                tbxPassword.Text = Client.ClientPassword;
                lblEmail.Text = Client.ClientEmail;
                tbxFirsname.Text = Client.ClientFirsname;
                tbxSecondname.Text = Client.ClientSecondname;
                tbxThirdname.Text = Client.ClientThirdname;
                tbxMoney.Text = Convert.ToString(Client.ClientMoney);
            }
            else DBConnection.UpdateClientData("alexsonz", tbxPassword.Text, tbxFirsname.Text,
                tbxSecondname.Text, tbxThirdname.Text, tbxMoney.Text);
        }
    }
}
