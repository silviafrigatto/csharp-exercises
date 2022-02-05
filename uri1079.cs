using System;

namespace uri1079
{
  class Program
  {
    static void Main(string[] args)
    {
		
		int i;	// Counter for number of lines
		int j = 0; // Counter for array's index
		int numCases = int.Parse(Console.ReadLine()); // User sets the number of lines
		float num1, num2, num3; 
		float[] averages = new float[numCases];	// Creates an array to store the averages

        
		
		for(i = 1; i <= numCases; i++)
		{
			
			string[] values = Console.ReadLine().Split(' ');	// Reads the input numbers in the same line
			num1 = float.Parse(values[0]);
			num2 = float.Parse(values[1]);
			num3 = float.Parse(values[2]);

			float average = ((num1 * 2) + (num2 * 3) + (num3 * 5)) / 10;
			
			averages[j] = average;	// Stores each average in the array
			j++;
			
		}
		
		foreach(float value in averages)
		{
			Console.WriteLine(value.ToString("F1"));
		}
			
    }
  }
}