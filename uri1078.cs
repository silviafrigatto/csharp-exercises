using System;

namespace uri1078
{
  class Program
  {
    static void Main(string[] args)
    {
		
		int i;
		int num = int.Parse(Console.ReadLine());
		
		if(num > 1 && num < 1000)
		{
			for(i=1; i <= 10; i++)
			{
				Console.WriteLine($"{i} x {num} = {i * num}");			
			}
		}
		else
		{
			Console.WriteLine("Out of range");
		}
    }
  }
}