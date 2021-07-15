//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1040
//URI is not accepting this answer as correct, eventhough the code runs without any errors on VS.

using System;
using System.Globalization;

namespace ex1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, media, exam, final;

            string[] scores = Console.ReadLine().Split(' ');
            N1 = float.Parse(scores[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(scores[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(scores[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(scores[3], CultureInfo.InvariantCulture);

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media < 5.0) {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 5.0 && media < 7.0) {
                Console.WriteLine("Aluno em exame.");
                Console.Write("Nota do exame: ");
                exam = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                final = (exam + media) / 2;
                if (final >= 5.0) {
                    Console.WriteLine("Aluno aprovado.");
                }
                else {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + final.ToString("F1", CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("Aluno aprovado.");
            }
   
        }
    }
}
