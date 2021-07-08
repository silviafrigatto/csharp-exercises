//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1004

using System;

namespace ex1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, PROD;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            PROD = n1 * n2;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}
