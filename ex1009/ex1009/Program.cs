//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1009

using System;
using System.Globalization;

namespace ex1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double salary, sales, total;

            name = Console.ReadLine();
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            total = salary + (0.15 * sales);

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
