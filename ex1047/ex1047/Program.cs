//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1047
//URI is not accepting this answer as correct, eventhough it prints the output requested by the exercise.

using System;

namespace ex1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int initial_hour, initial_minute, end_hour, end_minute, total_hours = 0, total_minutes = 0;

            string[] hours = Console.ReadLine().Split(' ');
            initial_hour = int.Parse(hours[0]);
            initial_minute = int.Parse(hours[1]);
            end_hour = int.Parse(hours[2]);
            end_minute = int.Parse(hours[3]);

            if (initial_hour == end_hour && initial_minute == end_minute) {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else {
                if (initial_hour < end_hour) {
                    total_hours = end_hour - initial_hour;
                }
                else {
                    total_hours = (24 - initial_hour) + end_hour;
                }
                if (initial_minute < end_minute) {
                    total_minutes = end_minute - initial_minute;
                }
                else {
                    total_minutes = (60 - initial_minute) + end_minute;
                    if (end_hour - initial_hour == 1) {
                        total_hours = 0;
                    }
                }
                Console.WriteLine("O JOGO DUROU " + total_hours + " HORA(S)" + " E " + total_minutes + " MINUTO(S)");
            }
        }
    }
}
