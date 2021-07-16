//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1049
//URI is not accepting this answer as correct, eventhough the code prints the requested output.

using System;

namespace ex1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1, word2, word3;
            
            word1 = Console.ReadLine().ToLower();
            word2 = Console.ReadLine().ToLower();
            word3 = Console.ReadLine().ToLower();

            if (word1 == "vertebrado" && word2 == "ave") {
                if (word3 == "carnivoro") {
                    Console.WriteLine("aguia");
                }
                else {
                    Console.WriteLine("pomba");
                }
            }
            else if (word1 == "vertebrado" && word2 == "mamifero") {
                if (word3 == "onivoro") {
                    Console.WriteLine("homem");
                }
                else {
                    Console.WriteLine("vaca");
                }
            }
            else if (word1 == "invertebrado" && word2 == "inseto" && word3 == "hematofago") {
                    Console.WriteLine("sanguessuga");
            }
            else {
                Console.WriteLine("minhoca");
            }
        }
    }
}
