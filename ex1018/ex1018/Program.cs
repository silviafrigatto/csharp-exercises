//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1018

using System;

namespace ex1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), nota, total_notas;

            Console.WriteLine(N);

            nota = 100;
            total_notas = N / nota;
            Console.WriteLine(total_notas + " nota(s) de R$ 100,00");

            N = N % nota;
            nota = 50;
            total_notas = N / nota;
            Console.WriteLine(total_notas + " nota(s) de R$ 50,00");

            N = N % nota;
            nota = 20;
            total_notas = N / nota;
            Console.WriteLine(total_notas + " nota(s) de R$ 20,00");

            N = N % nota;
            nota = 10;
            total_notas = N / nota;
            Console.WriteLine(total_notas + " nota(s) de R$ 10,00");

            N = N % nota;
            nota = 5;
            total_notas = N / nota;
            Console.WriteLine(total_notas + " nota(s) de R$ 5,00");

            N = N % nota;
            nota = 2;
            total_notas = N / nota;
            Console.WriteLine(total_notas + " nota(s) de R$ 2,00");

            N = N % nota;
            nota = 1;
            total_notas = N / nota;
            Console.WriteLine(total_notas + " nota(s) de R$ 1,00");

        }
    }
}
