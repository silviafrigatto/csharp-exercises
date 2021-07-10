//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1013

using System;

namespace ex1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, greaterAB, greater;

            string[] numbers = Console.ReadLine().Split(' ');
            A = int.Parse(numbers[0]);
            B = int.Parse(numbers[1]);
            C = int.Parse(numbers[2]);

            greaterAB = (A + B + Math.Abs(A - B)) / 2;
            greater = (greaterAB+ C + Math.Abs(greaterAB - C)) / 2;

            Console.WriteLine(greater + " eh o maior");
        }
    }
}
