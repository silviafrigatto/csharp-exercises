//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1011

using System;
using System.Globalization;

namespace ex1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, volume;

            radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            volume = (4 / 3.0) * 3.14159 * Math.Pow(radius, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
