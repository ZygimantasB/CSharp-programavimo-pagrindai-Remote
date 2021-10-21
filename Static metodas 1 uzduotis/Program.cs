using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_metodas_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] labas = new int[] { 1, 2, 3, 4, 5 };
            
            General.NuskaitytiSveikajiSkaiciu(45);

            General.NuskaitytiDoubleSkaiciu(45.45);

            General.PrintIntArray(labas);

            Console.ReadKey();


        }
    }
}
