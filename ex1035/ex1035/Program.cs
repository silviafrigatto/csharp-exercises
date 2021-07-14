//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1035

using System;

namespace ex1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            string[] numbers = Console.ReadLine().Split(' ');
            A = int.Parse(numbers[0]);
            B = int.Parse(numbers[1]);
            C = int.Parse(numbers[2]);
            D = int.Parse(numbers[3]);

            if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
                     
        }
    }
}
