// https://www.beecrowd.com.br/judge/en/problems/view/1094

using System;

namespace uri1094
{
  class Program
  {
    static void Main(string[] args)
    {
		
		// Ler total de testes
		/* Repetir conforme o total de testes:
		- ler um numero e uma inicial
		- somar de acordo com a inicial*/
		
		int numTests = int.Parse(Console.ReadLine());
		int number;
		int sum = 0;
		int totalC = 0;
		int totalR = 0;
		int totalS = 0;
		double percentC;
		double percentR;
		double percentS;
		
		for(int i = 0; i < numTests; i++)
		{
			string userInput = Console.ReadLine();
			
			// Calculating total of rabbits (C)
			if(userInput.ToUpper().Contains('C'))
			{
				string[] values = userInput.Split(' ');
				foreach(string value in values)	
				{  
				  if(int.TryParse(value, out number)) 
				  {
					totalC += number;
				  }
				}
			}
			
			// Calculating total of rats (R)
			if(userInput.ToUpper().Contains('R'))
			{
				string[] values = userInput.Split(' ');
				foreach(string value in values)	
				{  
				  if(int.TryParse(value, out number)) 
				  {
					totalR += number;
				  }
				}
			}
			
			// Calculating total of frogs (S)
			if(userInput.ToUpper().Contains('S'))
			{
				string[] values = userInput.Split(' ');
				foreach(string value in values)	
				{  
				  if(int.TryParse(value, out number)) 
				  {
					totalS += number;
				  }
				}
			}
		}
		
		sum = totalC + totalR + totalS;
		percentC = ((double)totalC / (double)sum) * 100;
		percentR = ((double)totalR / (double)sum) * 100;
		percentS = ((double)totalS / (double)sum) * 100;
		
		Console.WriteLine($"Total: {sum} cobaias");
		Console.WriteLine($"Total de coelhos: {totalC}");
		Console.WriteLine($"Total de ratos: {totalR}");
		Console.WriteLine($"Total de sapos: {totalS}");
		Console.WriteLine($"Percentual de coelhos: {percentC.ToString("F2")} %");
		Console.WriteLine($"Percentual de ratos: {percentR.ToString("F2")} %");
		Console.WriteLine($"Percentual de sapos: {percentS.ToString("F2")} %");
    }
  }
}