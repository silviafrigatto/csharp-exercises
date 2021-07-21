//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1051

using System;
using System.Globalization;

namespace ex1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary, taxes = 0;
            
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salary > 2000 && salary <= 3000)
            {
                taxes = (salary - 2000.0) * 0.08;
            }
            else if (salary > 3000 && salary <= 4500)
            {
                taxes = (salary - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else if (salary > 4500)
            {
                taxes = (salary - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                taxes = 0;
            }

            if (taxes == 0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + taxes.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
