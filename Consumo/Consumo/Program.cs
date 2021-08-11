using System;
using System.Globalization;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            double y, combustivel;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            combustivel = (double)x / y;

            Console.WriteLine(combustivel.ToString("F3", CultureInfo.InvariantCulture) + " km/l");



        }
    }
}
