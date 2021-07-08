//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1005

using System;
using System.Globalization;

namespace ex1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((3.5 * A) + (7.5 * B)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
