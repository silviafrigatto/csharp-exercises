// Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1060

using System;
using System.Globalization;

namespace ex1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            double num;

            for (int i = 1;  i < 7; i++) {
                num = double.Parse(Console.ReadLine());
                if (num > 0) {
                    total += 1;
                }
            }
            Console.WriteLine(total + " valores positivos");
        }
    }
}
