using System;

namespace uri1067
{
  class Program
  {
    static void Main(string[] args)
    {
		// Read one integer X (1 <= X <= 1000)
		// Print odd number each in one line
		
		int num;
		int count;
		
		num = int.Parse(Console.ReadLine());
		for(count=1; count <= num; count++)
		{
			if(num >= 1 && num <= 1000)
			{
				Console.WriteLine(count);
				count++;	
			}
		}
    }
  }
}