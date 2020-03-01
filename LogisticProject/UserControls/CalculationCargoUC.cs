using System;
using System.Windows.Forms;
using LogisticProject.Classes;

namespace LogisticProject
{
    public partial class CalculationCargoUC : UserControl
    {
        // цена грузоперевозки

        public CalculationCargoUC()
        {
            InitializeComponent();
            lblMoney.Visible = false;
            lblMoneyName.Visible = false;
            btnPayment.Visible = false;
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbxTo.Text) || string.IsNullOrEmpty(tbxFrom.Text) || string.IsNullOrEmpty(tbxHeight.Text)
              || string.IsNullOrEmpty(tbxLength.Text) || string.IsNullOrEmpty(tbxVolume.Text) || string.IsNullOrEmpty(tbxWidth.Text))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                CalculationCargo.ChooseCity(tbxFrom.Text, tbxTo.Text, tbxHeight.Text, tbxLength.Text, tbxVolume.Text, tbxWidth.Text);
                tbxFrom.Clear();
                tbxTo.Clear();
                tbxHeight.Clear();
                tbxLength.Clear();
                tbxVolume.Clear();
                tbxWidth.Clear();
                lblMoney.Visible = true;
                lblMoneyName.Visible = true;
                btnPayment.Visible = true;
                lblMoney.Text = Convert.ToString(CalculationCargo.CargoPrice);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перевозка оплачена!");
        }

        private void tbxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // только латиница
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void tbxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void tbxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void tbxVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void tbxFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // только кириллица
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void tbxTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }
    }
}
