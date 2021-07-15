//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1038

using System;
using System.Globalization;

namespace ex1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            double price, total;

            string[] order = Console.ReadLine().Split(' ');
            X = int.Parse(order[0]);
            Y = int.Parse(order[1]);
            
            if (X == 1) {
                price = 4.00;
            }
            else if (X == 2)
            {
                price = 4.50;
            }
            else if (X == 3)
            {
                price = 5.00;
            }
            else if (X == 4)
            {
                price = 2.00;
            }
            else if (X == 5)
            {
                price = 1.50;
            }
            else
            {
                price = 0.00;
            }
            
            total = price * Y; 

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
