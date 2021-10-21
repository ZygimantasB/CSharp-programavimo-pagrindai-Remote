using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Uzduotis_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite asmnes amziu");
            int asmensAmzius = Convert.ToInt32(Console.ReadLine());

            AmziausGrupe patikrinimas = new AmziausGrupe(asmensAmzius);

            patikrinimas.Amzius_uzduotis(asmensAmzius);

            Console.ReadLine();
        }
    }
}
