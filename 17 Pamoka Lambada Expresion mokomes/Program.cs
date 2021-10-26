using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Pamoka_Lambada_Expresion_mokomes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Visus skaicvius atvaizduoti su lambda

           Func<int, bool> oldCheck = x => x % 2 != 0;

            // Statment lambda expresion
            Action<int> printOdd = x =>
            {
                var square = x * x;
                var cube = x * x * x;
                var pakelta4 = x * x * x * x;
                var pakelta5 = x * x * x * x * x;
                Console.WriteLine($"{x} {square} {cube} {pakelta4} {pakelta5}");
            };


            

            var oddNumbers = numbers.Where(oldCheck).ToList();

            oddNumbers.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("-----------------------------------");

            oddNumbers.ForEach(printOdd);

            //Func<int, int> square = x => x * x;

            //Console.WriteLine(square(5));

            Console.ReadKey();
        }
    }
}
