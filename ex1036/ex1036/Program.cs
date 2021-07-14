//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1036

using System;
using System.Globalization;

namespace ex1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta, r1, r2;

            string[] numbers = Console.ReadLine().Split(' ');
            A = double.Parse(numbers[0], CultureInfo.InvariantCulture);
            B = double.Parse(numbers[1], CultureInfo.InvariantCulture);
            C = double.Parse(numbers[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(B, 2) - 4 * A * C;

            if (delta < 0 || A == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = (-B + Math.Sqrt(delta)) / (2 * A);
                r2 = (-B - Math.Sqrt(delta)) / (2 * A);
                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
