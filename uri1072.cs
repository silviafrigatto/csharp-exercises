using System;

namespace uri1072
{
  class Program
  {
    static void Main(string[] args)
    {
		// Ler um número N < 10000 = quantidade de números que serão lidos
		// Criar uma sequência de números aleatórios (-10^7 < x < 10^7)
		// Verificar se os números estão dentro do intervalo entre 10 e 20.
		// Mostrar o total de números dentro do intervalo.
		// Mostrar o total de números fora do intervalo.
		
		int i = 0;
		int count;
		int numTests;
		int totalIn = 0;
		int totalOut = 0;
		Random numbers = new Random();
		
		
		numTests = int.Parse(Console.ReadLine());
		int[] tests = new int[numTests];
		
		
		if(numTests < 10000)
		{
			for(count = 0; count < numTests; count++)
			{
				int randomNum = numbers.Next(0, 10000000); // Corrigir
				tests[i] = randomNum;
				//Console.WriteLine(tests[i]);
				i++;
			}
		}
		else
		{
			Console.WriteLine("Out of range");
		}
		
		foreach(int value in tests)
		{
			if(value >= 10 && value <= 20)
			{
				totalIn++;
			}
			else
			{
				totalOut++;
			}

		}
		
		Console.WriteLine($"{totalIn} in");
		Console.WriteLine($"{totalOut} out");
    }
  }
}