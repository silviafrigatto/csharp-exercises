//Exercise available on: https://www.urionlinejudge.com.br/judge/en/problems/view/1003

using System;

namespace ex1003
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, SOMA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}
