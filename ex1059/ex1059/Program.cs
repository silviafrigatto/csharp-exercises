// Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1059

using System;

namespace ex1059
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }         
            }
        }
    }
}
