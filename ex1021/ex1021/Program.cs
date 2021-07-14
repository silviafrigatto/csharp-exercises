//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1021

using System;
using System.Globalization;

namespace ex1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, note, total_notes, cents, total_coins;
         
            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                      
            Console.WriteLine("NOTAS:");

            note = 100;
            total_notes = N / note;
            Console.WriteLine((int)total_notes + " nota(s) de R$ 100.00");

            N = N % note;
            note = 50;
            total_notes = N / note;
            Console.WriteLine((int)total_notes + " nota(s) de R$ 50.00");

            N = N % note;
            note = 20;
            total_notes = N / note;
            Console.WriteLine((int)total_notes + " nota(s) de R$ 20.00");

            N = N % note;
            note = 10;
            total_notes = N / note;
            Console.WriteLine((int)total_notes + " nota(s) de R$ 10.00");

            N = N % note;
            note = 5;
            total_notes = N / note;
            Console.WriteLine((int)total_notes + " nota(s) de R$ 5.00");

            N = N % note;
            note = 2;
            total_notes = N / note;
            Console.WriteLine((int)total_notes + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");

            N = N % note;
            cents = 1;
            total_coins = N / cents;
            Console.WriteLine((int)total_coins + " moeda(s) de R$ 1.00");
                 
            N = N % cents;
            cents = 0.50;
            total_coins = N / cents;
            Console.WriteLine((int)total_coins + " moeda(s) de R$ 0.50");

            N = N % cents;
            cents = 0.25;
            total_coins = N / cents;
            Console.WriteLine((int)total_coins + " moeda(s) de R$ 0.25");

            N = N % cents;
            cents = 0.10;
            total_coins = N / cents;
            Console.WriteLine((int)total_coins + " moeda(s) de R$ 0.10");

            N = N % cents;
            cents = 0.05;
            total_coins = N / cents;
            Console.WriteLine((int)total_coins + " moeda(s) de R$ 0.05");

            N = N % cents;
            cents = 0.01;
            total_coins = N / cents;
            Console.WriteLine((int)total_coins + " moeda(s) de R$ 0.01");
        }
    }
}
