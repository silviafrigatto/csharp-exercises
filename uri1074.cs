using System;

namespace uri1074
{
  class Program
  {
    static void Main(string[] args)
    {
		
		// Informar um número N
		// Usuário informa números de acordo com a quantidade de N
		// Informar se o número é par, ímpar, positivo, negativo
		// Se for 0, imprimir NULL
		
		int i = 0;
		int count;
		
		int totalNum = int.Parse(Console.ReadLine());
		
		int[] numbers = new int[totalNum];
		
		
		for(count=1; count <= totalNum; count++)
		{
			int userInput = int.Parse(Console.ReadLine());
			numbers[i] = userInput;
			i++;			
		}
		
		foreach(int value in numbers)
		{
			if(value > 0 && value % 2 ==0)
			{
				Console.WriteLine("EVEN POSITIVE");
			}
			else if(value < 0 && value % 2 ==0)
			{
				Console.WriteLine("EVEN NEGATIVE");
			}
			else if(value > 0 && value % 2 != 0)
			{
				Console.WriteLine("ODD POSITIVE");
			}
			else if(value < 0 && value % 2 != 0)
			{
				Console.WriteLine("ODD NEGATIVE");
			}
			else
			{
				Console.WriteLine("NULL");
			}
			
		}
		
    }
  }
}