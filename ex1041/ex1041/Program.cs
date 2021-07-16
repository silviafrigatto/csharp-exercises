//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1041

using System;
using System.Globalization;

namespace ex1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            string[] coordinates = Console.ReadLine().Split(' ');
            x = double.Parse(coordinates[0], CultureInfo.InvariantCulture);
            y = double.Parse(coordinates[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

        }
    }
}
