//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1016

using System;

namespace ex1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance, time;

            distance = int.Parse(Console.ReadLine());

            time = distance * 2;
            
            Console.WriteLine(time + " minutos");
        }
    }
}
