using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura ex.: 15ºC ");
            string[] temperatura = Console.ReadLine().Split("º");
            double tempCelsius = double.Parse(temperatura[0]);
            char tipoTemp = char.Parse(temperatura[1].ToLower());

            Console.WriteLine("Para qual tipo de temperatura você deseja converter? ");
            char tipoTemp2 = char.Parse(Console.ReadLine().ToLower());

            if (tipoTemp == 'c' && tipoTemp2 == 'f')
                CelsiusFahrenheit(tempCelsius);

            else if (tipoTemp == 'k' && tipoTemp2 == 'f')
                KelvinFahrenheit(tempCelsius);
        }

        static void CelsiusFahrenheit(double temperatura)
        {
            double tempFahrenheit = (((temperatura * 9) + 160) / 5);
            Console.WriteLine("Temperatura convertida para Fahrenheit = " + tempFahrenheit.ToString("F2") + "ºF");
        }

        static void KelvinFahrenheit(double temperatura)
        {
            double tempFahrenheit = (((temperatura - 273.15) * 9) / 5) + 32;
            Console.WriteLine("Temperatura convertida para Fahrenheit = " + tempFahrenheit.ToString("F2") + "ºF");
        }
    }
}
