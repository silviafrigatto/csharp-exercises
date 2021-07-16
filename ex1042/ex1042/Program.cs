//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1042

using System;

namespace ex1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max, min, mid;

            string[] numbers = Console.ReadLine().Split(' ');
            a = int.Parse(numbers[0]);
            b = int.Parse(numbers[1]);
            c = int.Parse(numbers[2]);
                                  
            if (a > b && b > c)
            {
                max = a;
                mid = b;
                min = c;
                Console.WriteLine(min + "\n" + mid + "\n" + max);
            }
            else if (a > c && c > b)
            {
                max = a;
                mid = c;
                min = b;
                Console.WriteLine(min + "\n" + mid + "\n" + max);
            }
            else if (b > a && a > c)
            {
                max = b;
                mid = a;
                min = c;
                Console.WriteLine(min + "\n" + mid + "\n" + max);
            }
            else if (b > c && c > a)
            {
                max = b;
                mid = c;
                min = a;
                Console.WriteLine(min + "\n" + mid + "\n" + max);
            }
            else if (c > a && a > b)
            {
                max = c;
                mid = a;
                min = b;
                Console.WriteLine(min + "\n" + mid + "\n" + max);
            }
            else if (c > b && b > a)
            {
                max = c;
                mid = b;
                min = a;
                Console.WriteLine(min + "\n" + mid + "\n" + max);
            }
            else
            {
                Console.WriteLine(a + "\n" + b + "\n" + c);
            }

            Console.WriteLine("\n" + a + "\n" + b + "\n" + c);

        }
    }
}
