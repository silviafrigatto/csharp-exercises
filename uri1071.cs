using System;

namespace uri1071
{
  class Program
  {
    static void Main(string[] args)
    {
		// Ler primeiro número
		// Ler segundo número
		// Verificar se num1 é maior ou menor que num2
		// Verificar números ímpares entre num1 e num2
		// Imprimir a soma dos ímpares
		
		int num1, num2;
		int sum = 0;
		
		num1 = int.Parse(Console.ReadLine());
		num2 = int.Parse(Console.ReadLine());
		
		while(num1 > num2)
		{
			num1--;
			if(num1 % 2 != 0 && num1 != num2)
			{
				// Console.WriteLine(num1);
				sum += num1;
			}	
		}
		
		while(num1 < num2)
		{
			num1++;
			if(num1 % 2 != 0 && num1 != num2)
			{
				// Console.WriteLine(num1);
				sum += num1;
			}	
		}
		
		// Console.WriteLine();
		Console.WriteLine(sum);
    }
  }
}