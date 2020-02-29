using System;
using System.Windows.Forms;

namespace LogisticProject.Classes
{
    class CalculationCargo
    {
        // определение дистанции от точки до точки
        static int cargoDistance = 0;

        // габариты для расчета грузоперевозки 
        static double cargoHeight = 0;
        static double cargoLength = 0;
        static double cargoWidth = 0;
        static int cargoVolume = 0;

        public static void ChooseCity(string cityFrom, string cityTo, string Height, string Length, string Volume, string Width)
        {
            if ((cityFrom == "Казань" && cityTo == "Москва") || (cityFrom == "Москва" && cityTo == "Казань"))
            {
                cargoDistance = 800;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
            if ((cityFrom == "Сочи"  && cityTo == "Казань") || (cityFrom == "Казань" && cityTo == "Сочи"))
            {
                cargoDistance = 2000;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
            if((cityFrom == "Сочи" && cityTo == "Москва") || (cityFrom == "Казань" && cityTo == "Москва"))
            {
                cargoDistance = 1800;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
        }

        private static void CalcCargo(int cargoDistance, string Height, string Length, string Volume, string Width)
        {
            cargoHeight = Convert.ToDouble(Height);
            cargoLength = Convert.ToDouble(Length);
            cargoWidth = Convert.ToDouble(Width);
            cargoVolume = Convert.ToInt32(Volume);


        }
    }
}
