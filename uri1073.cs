using System;

namespace uri1073
{
  class Program
  {
    static void Main(string[] args)
    {
		
		//	Ler um número N (5 < N < 2000)
		//	Verificar quais são os números pares entre 1 e N
		//	Elevar ao quadrado cada um desses números
		//	Mostrar na tela
		
		int i;
		int num = int.Parse(Console.ReadLine());
		
		for(i=1; i <= num; i++)
		{
			
			if(i % 2 == 0)
			{
				Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
			}
			
		}	
		
    }
  }
}