//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1015

using System;
using System.Globalization;

namespace ex1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, distance;

            string[] values = Console.ReadLine().Split(' ');
            x1 = double.Parse(values[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(values[1], CultureInfo.InvariantCulture);
           
            values = Console.ReadLine().Split(' ');
            x2 = double.Parse(values[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(values[1], CultureInfo.InvariantCulture);

            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(distance.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
