// Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1061

using System;

namespace ex1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int w1, x1, y1, z1, w2, x2, y2, z2, w, x, y, z, start, end, duration, remainder;

            string[] values = Console.ReadLine().Split(' ');
            w1 = int.Parse(values[1]);

            values = Console.ReadLine().Split(" : ");
            x1 = int.Parse(values[0]);
            y1 = int.Parse(values[1]);
            z1 = int.Parse(values[2]);

            values = Console.ReadLine().Split(' ');
            w2 = int.Parse(values[1]);

            values = Console.ReadLine().Split(" : ");
            x2 = int.Parse(values[0]);
            y2 = int.Parse(values[1]);
            z2 = int.Parse(values[2]);

            start = (w1 - 1) * 24 * 60 * 60 + x1 * 60 * 60 + y1 * 60 + z1;
            end = (w2 - 1) * 24 * 60 * 60 + x2 * 60 * 60 + y2 * 60 + z2;

            duration = end - start;

            w = duration / (24 * 60 * 60);
            remainder = duration % (24 * 60 * 60);
            x = remainder / (60 * 60);
            remainder = remainder % (60 * 60);
            y = remainder / 60;
            z = remainder % 60;

            Console.WriteLine(w + " dia(s)");
            Console.WriteLine(x + " hora(s)");
            Console.WriteLine(y + " minuto(s)");
            Console.WriteLine(z + " segundo(s)");

        }
    }
}
