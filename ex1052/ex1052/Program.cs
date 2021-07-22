// Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1052

using System;

namespace ex1052
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            num = int.Parse(Console.ReadLine());
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
           
            Console.WriteLine(months[num - 1]);
        }
    }
}
