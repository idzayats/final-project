using System;
using System.Windows.Forms;
using LogisticProject.Classes;

namespace LogisticProject
{
    public partial class CalculationCargoUC : UserControl
    {
        // цена грузоперевозки
        public static int CargoPrice { get; set; }

        // данные которые ввел пользователь в текстбоксы
        int UserHeight = 0;
        int UserLength = 0;
        int UserWidth = 0;
        int UserVolume = 0;

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
                CalculationCargo.ChooseCity(tbxFrom.Text, tbxTo.Text, UserHeight, UserLength, UserVolume, UserWidth);
            }
        }
    }
}
