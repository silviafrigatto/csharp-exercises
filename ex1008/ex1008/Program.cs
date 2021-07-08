//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1008

using System;
using System.Globalization;

namespace ex1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, hours;
            double hourly_wage, wage;

            number = int.Parse(Console.ReadLine());
            hours = int.Parse(Console.ReadLine());
            hourly_wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            wage = hours * hourly_wage;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + wage.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
