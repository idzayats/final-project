using System;
using System.Windows.Forms;

namespace LogisticProject.Classes
{
    class CalculationCargo
    {
        // цена за перевозку
        public static double CargoPrice { get; set; }
        public static double CargoVolume { get; set; }

        // определение дистанции от точки до точки
        static int cargoDistance = 0;

        // габариты для расчета грузоперевозки 
        static double cargoHeight = 0;
        static double cargoLength = 0;
        static double cargoWidth = 0;
        static double cargoVolume = 0;

        // цена бензина за литр
        const int fuelLiter = 45;

        public static void ChooseCity(string cityFrom, string cityTo, string Height, string Length, string Volume, string Width)
        {
            if ((cityFrom == "Казань" && cityTo == "Москва") || (cityFrom == "Москва" && cityTo == "Казань"))
            {
                cargoDistance = 815;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
            else if ((cityFrom == "Сочи"  && cityTo == "Казань") || (cityFrom == "Казань" && cityTo == "Сочи"))
            {
                cargoDistance = 2011;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
            else if((cityFrom == "Сочи" && cityTo == "Москва") || (cityFrom == "Казань" && cityTo == "Москва"))
            {
                cargoDistance = 1621;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
            else if((cityFrom == "Нижний Новгород" && cityTo == "Казань") || (cityFrom == "Казань" && cityTo == "Нижний Новгород"))
            {
                cargoDistance = 388;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
            else if((cityFrom == "Нижний Новгород" && cityTo == "Сочи") || (cityFrom == "Сочи" && cityTo == "Нижний Новгород"))
            {
                cargoDistance = 1812;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
            else if ((cityFrom == "Нижний Новгород" && cityTo == "Москва") || (cityFrom == "Москва" && cityTo == "Нижний Новгород"))
            {
                cargoDistance = 417;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
            else if ((cityFrom == "Хабаровск" && cityTo == "Москва") || (cityFrom == "Москва" && cityTo == "Хабаровск"))
            {
                cargoDistance = 8245;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
            else if ((cityFrom == "Хабаровск" && cityTo == "Казань") || (cityFrom == "Казань" && cityTo == "Хабаровск"))
            {
                cargoDistance = 7422;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
            else if ((cityFrom == "Хабаровск" && cityTo == "Сочи") || (cityFrom == "Сочи" && cityTo == "Хабаровск"))
            {
                cargoDistance = 9155;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
            else if ((cityFrom == "Хабаровск" && cityTo == "Нижний Новгород") || (cityFrom == "Нижний Новгород" && cityTo == "Хабаровск"))
            {
                cargoDistance = 7818;
                CalcCargo(cargoDistance, Height, Length, Volume, Width);
            }
            else
            {
                MessageBox.Show("В введенном(ых) городе(ах) нет терминала нашей компании!");
            }
        }

        private static void CalcCargo(int cargoDistance, string Height, string Length, string Volume, string Width)
        {
            // перевод единиц измерений с точкой
            cargoHeight = Convert.ToDouble(Height);
            cargoLength = Convert.ToDouble(Length);
            cargoWidth = Convert.ToDouble(Width);
            cargoVolume = Convert.ToInt32(Volume);

            // расчет обьема груза
            cargoVolume = Convert.ToDouble(cargoHeight * cargoLength * cargoVolume * cargoWidth * cargoDistance);
            // расчет перевозки
            CargoPrice = Convert.ToDouble(cargoVolume / fuelLiter);
            // свойство = переменна 
            CargoVolume = cargoVolume;
        }
    }
}
