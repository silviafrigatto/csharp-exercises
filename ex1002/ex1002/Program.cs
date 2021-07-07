//Exercise available on: https://www.urionlinejudge.com.br/judge/en/problems/view/1002

using System;
using System.Globalization;

namespace ex1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, n = 3.14159, r, R;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R = Math.Pow(r, 2);

            A = n * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
