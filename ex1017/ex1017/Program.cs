//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1017

using System;
using System.Globalization;

namespace ex1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours, speed, distance;
            double liters;

            hours = int.Parse(Console.ReadLine());
            speed = int.Parse(Console.ReadLine());

            distance = hours * speed;
            liters = distance / 12.0;

            Console.WriteLine(liters.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
