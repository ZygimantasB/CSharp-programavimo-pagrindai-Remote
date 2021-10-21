using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Uzduotis_1
{
    class AmziausGrupe
    {
        public int Amzius;

        public AmziausGrupe(int amzius)
        {
            Amzius = amzius;
        }

        public void Amzius_uzduotis (int amzius)
        {
            if (amzius < 18)
            {
                Console.WriteLine("Asmuo negali vartoti alkoholio");
            }
            else if (amzius > 18 && amzius < 20 )
            {
                Console.WriteLine("Gali vairuoti, bet negali pirkti alkoholio");
            }
            else if (amzius >= 20)
            {
                Console.WriteLine("Asmuo gali vartoti ir pirkti alkoholi");
            }
            else
            {
                Console.WriteLine("Kalidingi parametrai");
            }
        }
            
    }
}
