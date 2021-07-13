//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1019

using System;

namespace ex1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, hours, minutes, seconds;

            N = int.Parse(Console.ReadLine());
            hours = N / 3600;
            
            N = N % 3600;
            minutes = N / 60;

            N = N % 60;
            seconds = N;

            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }
    }
}
