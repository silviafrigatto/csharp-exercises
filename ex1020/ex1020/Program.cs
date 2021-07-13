using System;

namespace ex1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, years, months, days;

            age = int.Parse(Console.ReadLine());
            years = age / 365;
            
            age %= 365;
            months = age / 30;
            
            days = age % 30;
                       
            Console.WriteLine(years + " ano(s)");
            Console.WriteLine(months + " mes(es)");
            Console.WriteLine(days + " dia(s)");
        }
    }
}
