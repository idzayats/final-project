using System;
using System.Windows.Forms;

namespace LogisticProject
{
    public partial class CalculationCargoUC : UserControl
    {
        public CalculationCargoUC()
        {
            InitializeComponent();
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
                tbxFrom.Clear();
                tbxTo.Clear();
                tbxHeight.Clear();
                tbxLength.Clear();
                tbxVolume.Clear();
                tbxWidth.Clear();
                MessageBox.Show("Перевозка оформлена");
            }
        }
    }
}
