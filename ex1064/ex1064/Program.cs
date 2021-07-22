// Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1064

using System;
using System.Globalization;

namespace ex1064
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            double num, sum = 0.0, average = 0.0;

            for (int i = 1; i < 7; i++)
            {
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (num > 0)
                {
                    total += 1;
                    sum += num;
                }
            }

            average = sum / total;
            Console.WriteLine(total + " valores positivos");
            Console.WriteLine(average.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
