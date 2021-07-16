//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1044

using System;

namespace ex1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            string[] numbers = Console.ReadLine().Split(' ');
            a = int.Parse(numbers[0]);
            b = int.Parse(numbers[1]);

            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}
