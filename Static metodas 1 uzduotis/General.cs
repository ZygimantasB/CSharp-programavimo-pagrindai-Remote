using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_metodas_1_uzduotis
{
   public class General
    {
        public static int NuskaitytiSveikajiSkaiciu(int skaicius_a)
        {
            return skaicius_a;
        }
        public static double NuskaitytiDoubleSkaiciu(double skaicius_b)
        {
            return skaicius_b;
        }
        public static void PrintIntArray (int [] mano_masyvas)
        {
            foreach (var a in mano_masyvas)
            {
                Console.WriteLine($"{a}");
            }


        }
    }
}
