//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1010

using System;
using System.Globalization;

namespace ex1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int code1, units1, code2, units2;
            double price1, price2, total;

            string[] values = Console.ReadLine().Split(' ');
            code1 = int.Parse(values[0]);
            units1 = int.Parse(values[1]);
            price1 = double.Parse(values[2], CultureInfo.InvariantCulture);

            values = Console.ReadLine().Split(' ');
            code2 = int.Parse(values[0]);
            units2 = int.Parse(values[1]);
            price2 = double.Parse(values[2], CultureInfo.InvariantCulture);

            total = (units1 * price1) + (units2 * price2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
