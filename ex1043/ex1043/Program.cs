//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1043

using System;
using System.Globalization;

namespace ex1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, perimeter, area;

            string[] measures = Console.ReadLine().Split(' ');
            A = double.Parse(measures[0], CultureInfo.InvariantCulture);
            B = double.Parse(measures[1], CultureInfo.InvariantCulture);
            C = double.Parse(measures[2], CultureInfo.InvariantCulture);

            if (A < B + C && B < A + C && C < A + B) {
                perimeter = A + B + C;
                Console.WriteLine("Perimetro = " + perimeter.ToString("F1", CultureInfo.InvariantCulture));
            }
            else {
                area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
