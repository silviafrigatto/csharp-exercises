https://www.beecrowd.com.br/judge/en/problems/view/1095

using System;

class Program {
    static void Main(string[] args) {
        
		int i = 1;
		int j;
		
		for(j = 60; j >= 0; j -= 5)
		{
			Console.WriteLine($"I={i} J={j}");
			i += 3;
		}
		
    }
}