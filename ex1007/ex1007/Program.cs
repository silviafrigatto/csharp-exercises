//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1007

using System;

namespace ex1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, diferenca;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            diferenca = (A * B) - (C * D);      //Calculates the difference

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}
