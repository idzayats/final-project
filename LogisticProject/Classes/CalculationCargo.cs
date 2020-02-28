using System;
using System.Windows.Forms;

namespace LogisticProject.Classes
{
    class CalculationCargo
    {
        static int cargoDistance = 0;

        public static void ChooseCity(string cityFrom, string cityTo, int Height, int Length, int Volume, int Width)
        {
            if ((cityFrom == "Казань" && cityTo == "Москва") || (cityFrom == "Москва" && cityTo == "Казань"))
            {
                cargoDistance = 800;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
        }

        private static void CalcCargo(int cargoDistance, int Height, int Length, int Volume, int Width)
        {
            MessageBox.Show(Convert.ToString(cargoDistance));
        }
    }
}
