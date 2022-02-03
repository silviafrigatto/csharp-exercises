using System;

namespace uri1066
{
  class Program
  {
    static void Main(string[] args)
    {
		// Read five integers
		// Count how many are even, odd, positives and negatives
		// Print count
		
		int i;
		int countEven = 0;
		int countOdd = 0;
		int countPos = 0;
		int countNeg = 0;
		int[] array = new int[5];
		
		
		for(i=0; i<5; i++)
		{
			array[i] = int.Parse(Console.ReadLine());
			if(array[i] % 2 == 0)
			{
				countEven++;
			}
			if(array[i] % 2 != 0)
			{
				countOdd++;
			}
			if(array[i] > 0)
			{
				countPos++;
			}
			if(array[i] < 0)
			{
				countNeg++;
			}
			
		}
		
		Console.WriteLine($"{countEven} valor(es) par(es)");
		Console.WriteLine($"{countOdd} valor(es) impar(es)");
		Console.WriteLine($"{countPos} valor(es) positivo(s)");
		Console.WriteLine($"{countNeg} valor(es) negativo(s)");
		
    }
  }
}