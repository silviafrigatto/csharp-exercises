//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1006

using System;
using System.Globalization;

namespace ex1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((2 * A) + (3 * B) + (5 * C)) / 10;     //average calculation
            
            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
