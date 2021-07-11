//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1014

using System;
using System.Globalization;

namespace ex1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, consumption;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumption = X / Y;

            Console.WriteLine(consumption.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
