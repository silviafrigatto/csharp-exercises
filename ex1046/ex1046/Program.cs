//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1046

using System;

namespace ex1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end, total_hours = 0;

            string[] hours = Console.ReadLine().Split(' ');
            start = int.Parse(hours[0]);
            end = int.Parse(hours[1]);

            if (start == end){
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else {
                if (start < end) {
                    total_hours = end - start;
                }
                else {
                    total_hours = (24 - start) + end;
                }
                Console.WriteLine("O JOGO DUROU " + total_hours + " HORA(S)");
            }

        }
    }
}
