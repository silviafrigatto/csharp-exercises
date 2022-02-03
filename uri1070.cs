using System;

namespace uri1070
{
  class Program
  {
    static void Main(string[] args)
    {
		// Read one integer
		// Print the next 6 odd numbers
		
		// input de um número
		// ir somando 1 a esse número
		// verificar se o número é ímpar
		// se for ímpar, imprimir na tela (incluir o próprio número, se for ímpar)
		// máximo de números ímpares = 6
		
		int num;
		int totalOdds = 0;
		
		num = int.Parse(Console.ReadLine());
		
		if(num >= 0)
		{
			while(totalOdds < 6)
			{
				if(num % 2 != 0)
				{
					Console.WriteLine(num);
					totalOdds++;
				}
				num++;
			}
		}
		else
		{
			Console.WriteLine("You must enter a positive number.");
		}
		
    }
  }
}