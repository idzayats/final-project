using System;
using System.Windows.Forms;
using LogisticProject.Classes;

namespace LogisticProject
{
    public partial class CalculationCargoUC : UserControl
    {
        // цена грузоперевозки
        public static int CargoPrice { get; set; }

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
                CalculationCargo.ChooseCity(tbxFrom.Text, tbxTo.Text, tbxHeight.Text, tbxLength.Text, tbxVolume.Text, tbxWidth.Text);
                tbxFrom.Clear();
                tbxTo.Clear();
                tbxHeight.Clear();
                tbxLength.Clear();
                tbxVolume.Clear();
                tbxWidth.Clear();
            }
        }
    }
}
