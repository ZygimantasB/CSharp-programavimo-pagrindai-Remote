using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite antra skaiciu");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite trecia skaiciu");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Irasykite ketvirta skaiciu");
            int skaicius4 = Convert.ToInt32(Console.ReadLine());

            Skaiciavimai patirkinimas = new Skaiciavimai(skaicius1, skaicius2, skaicius3, skaicius4);

            patirkinimas.Patikrinimas_uzduoties(skaicius1, skaicius2, skaicius3, skaicius4);
            
            Console.ReadLine();
        }
    }
}
