//Exercise available on https://www.urionlinejudge.com.br/judge/en/problems/view/1048

using System;
using System.Globalization;

namespace ex1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary, rate = 0, readjustment = 0, new_salary = 0;
  
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salary > 0 && salary <= 400) {
                rate = 15;
                readjustment = salary * (rate / 100);
                new_salary = salary + readjustment;
            }
            else if (salary > 400 && salary <= 800) {
                rate = 12;
                readjustment = salary * (rate / 100);
                new_salary = salary + readjustment;
            }
            else if (salary > 800 && salary <= 1200) {
                rate = 10;
                readjustment = salary * (rate / 100);
                new_salary = salary + readjustment;
            }
            else if (salary > 1200 && salary <= 2000) {
                rate = 7;
                readjustment = salary * (rate / 100);
                new_salary = salary + readjustment;
            }
            else {
                rate = 4;
                readjustment = salary * (rate / 100);
                new_salary = salary + readjustment;
            }
            Console.WriteLine("Novo salario: " + new_salary.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + readjustment.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + rate + " %");
        }
    }
}
