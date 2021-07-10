//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1012

using System;
using System.Globalization;

namespace ex1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangle, circle, trapezium, square, rect;

            string[] values = Console.ReadLine().Split(' ');
            A = double.Parse(values[0], CultureInfo.InvariantCulture);
            B = double.Parse(values[1], CultureInfo.InvariantCulture);
            C = double.Parse(values[2], CultureInfo.InvariantCulture);

            //Calculating areas
            triangle = (A * C) / 2;
            circle = 3.14159 * Math.Pow(C, 2);
            trapezium = ((A + B) * C) / 2;
            square = B * B;
            rect = A * B;

            Console.WriteLine("TRIANGULO: " + triangle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezium.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + square.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + rect.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
