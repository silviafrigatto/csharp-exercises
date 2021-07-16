//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1045

using System;
using System.Globalization;

namespace ex1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, s1, s2, s3;

            string[] sides = Console.ReadLine().Split(' ');
            s1 = double.Parse(sides[0], CultureInfo.InvariantCulture);
            s2 = double.Parse(sides[1], CultureInfo.InvariantCulture);
            s3 = double.Parse(sides[2], CultureInfo.InvariantCulture);

            if (s1 > s2 && s1 > s3) {
                a = s1;
                if (s2 > s3) {
                    b = s2;
                    c = s3;
                }
                else {
                    b = s3;
                    c = s2;
                }
            }
            else if (s2 > s1 && s2 > s3) {
                a = s2;
                if (s1 > s3) {
                    b = s1;
                    c = s3;
                }
                else {
                    b = s3;
                    c = s1;
                }
            }
            else {
                a = s3;
                if (s1 > s2) {
                    b = s1;
                    c = s2;
                }
                else {
                    b = s2;
                    c = s1;
                }
            }

            if (a >= b + c) {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else {
                if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2)) {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                else {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (a == b && b == c) {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || a == c || b == c) {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }

        }
    }
}
