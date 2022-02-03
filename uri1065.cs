using System;

namespace uri1065
{
  class Program
  {
    static void Main(string[] args)
    {
		// Read five integers
		// Count how many are even
		// Print count
		
		int i;
		int count = 0;
		int[] array = new int[5];
		
		
		for(i=0; i<5; i++)
		{
			array[i] = int.Parse(Console.ReadLine());
			if(array[i] % 2 == 0)
			{
				count++;
			}
		}
		
		Console.WriteLine($"{count} valores pares");
		
    }
  }
}